/*
 * This file is in the public domain. Peter O., 2012. http://upokecenter.dreamhosters.com
    Public domain dedication: http://creativecommons.org/publicdomain/zero/1.0/legalcode

 This file converts between different representations of HTML and CSS colors.

ColorValidator.HlsToRgb(hls):

Converts Hue/Lightness/Sat colors to Red/Green/Blue colors.
"hls" is a 3-element array containing the hue (0-360), lightness (0-255)
and saturation (0-255).
Returns a 3-element array containing the red, green, and blue (each 0-255).


ColorValidator.ColorToRgba(color):
--- NOTE: Use this function to parse colors from alpha color picker controls:
--- http://peteroupc.github.com/colorpicker/
Converts HTML colors to Red/Green/Blue colors.
"color" is a CSS color, HTML color, or color name, including
RGBA and HSLA (ex. #223344 or #234 or royalblue or
rgb(20,20,20) or rgba(20,30,40,0.5) or hsl(100,100%,50%)
or hsla(100,100%,50%,0.5) ).
Invalid strings result in a return value of nil.
Returns a 4-element array containing the red, green, blue, and alpha
(each 0-255).

ColorValidator.ColorToRgb(color):
--- NOTE: Use this function to parse colors from normal color picker controls:
--- http://peteroupc.github.com/colorpicker/
Converts HTML colors to Red/Green/Blue colors.
"color" is a CSS color, HTML color, or color name, NOT including
RGBA or HSLA (ex. #223344 or #234 or royalblue
or rgb(20,20,20) or hsl(100,100%,50%)).
Invalid strings result in a return value of nil.
Returns a 4-element array containing the red, green, blue, and alpha
(each 0-255); the alpha is always 255.

ColorValidator.RgbToColor(rgb):

Converts an RGBA color to a string, either rgb(...) or rgba(...) as applicable.
"rgb" must contain at least 3 elements: the red, green, and blue (each 0-255).
It can optionally contain a fourth element representing the alpha (0-255).

ColorValidator.RgbToColorDisplay(rgb):

Converts an RGBA color to a string, (ex. #002233 or rgba(...) as applicable).
"rgb" must contain at least 3 elements: the red, green, and blue (each 0-255).
It can optionally contain a fourth element representing the alpha (0-255).

ColorValidator.RgbToColorHtml(rgb):

Converts an RGBA color to an HTML color, (ex. #002233).
"rgb" must contain at least 3 elements: the red, green, and blue (each 0-255).

ColorValidator.ColorHtmlToRgba(color):

Converts HTML colors to Red/Green/Blue colors.
"color" is an HTML color or color name (ex. #223344, #234, or royalblue).
All strings are treated as valid.
Returns a 4-element array containing the red, green, blue, and alpha
(each 0-255); the alpha is always 255.
 */

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace PeterO {

	public static class ColorValidator {

		public static double[] HlsToRgb(double[] hls) {
			double hueval=hls[0]*1.0;//[0-360)
			double lum=hls[1]*1.0;//[0-255]
			double sat=hls[2]*1.0;//[0-255]
			lum=(lum<0 ? 0 : (lum>255 ? 255 : lum));
			sat=(sat<0 ? 0 : (sat>255 ? 255 : sat));
			if(sat==0){
				return new double[]{lum,lum,lum};
			}
			double b=0;
			if (lum<=127.5){
				b=(lum*(255.0+sat))/255.0;
			} else {
				b=lum*sat;
				b=b/255.0;
				b=lum+sat-b;
			}
			double a=(lum*2)-b;
			double r,g,bl;
			if(hueval<0||hueval>=360)hueval=(((hueval%360)+360)%360);
			double hue=hueval+120;
			if(hue>=360)hue-=360;
			if (hue<60) r=(a+(b-a)*hue/60);
			else if (hue<180) r=b;
			else if (hue<240) r=(a+(b-a)*(240-hue)/60);
			else r=a;
			hue=hueval;
			if (hue<60) g=(a+(b-a)*hue/60);
			else if (hue<180) g=b;
			else if (hue<240) g=(a+(b-a)*(240-hue)/60);
			else g=a;
			hue=hueval-120;
			if(hue<0)hue+=360;
			if (hue<60) bl=(a+(b-a)*hue/60);
			else if (hue<180) bl=b;
			else if (hue<240) bl=(a+(b-a)*(240-hue)/60);
			else bl=a;
			return new double[]{(r<0 ? 0 : (r>255 ? 255 : r)),
				(g<0 ? 0 : (g>255 ? 255 : g)),
				(bl<0 ? 0 : (bl>255 ? 255 : bl))};
		}

		public static double[] ColorHtmlToRgba(string x){

			ColorToRgbaSetUpNamedColors();
			if(x==null || x.Length==0)return new double[]{0,0,0,255};
			x=x.ToLower();
			if(x.IndexOf("grey")>=0)x=x.Replace("grey","gray");// support "grey" variants
			if(ColorToRgbaNamedColors.ContainsKey(x)){
				string ret=ColorToRgbaNamedColors[x];
				if(ret!=null)return ColorToRgba(ret);
			}
			int[] arr=new int[x.Length];
			for(int i=(x[0]=='#') ? 1 : 0;i<x.Length;i++){
				int c=x[i];
				int hex=0;
				if(c>=0x30 && c<=0x39)hex=c-0x30;
				if(c>=0x61 && c<=0x66)hex=c-0x61+10;
				arr[arr.Length]=hex;
			}
			int sublength=((arr.Length+2)/3);
			while(arr.Length<sublength*3){
				arr[arr.Length]=0;
			}
			int currlength=sublength;
			int offset=0;
			while(currlength>2){
				if(arr[offset]==0 && arr[sublength+offset]==0 &&
				   arr[sublength*2+offset]==0){
					currlength--; offset++;
				} else break;
			}
			return new double[]{
				arr[offset]*16+arr[offset+1],
				arr[sublength+offset]*16+arr[sublength+offset+1],
				arr[sublength*2+offset]*16+arr[sublength*2+offset+1],
				255
			};
		}

		private static Regex[] patterns=new Regex[]{
			new Regex("^#([A-Fa-f0-9]{2})([A-Fa-f0-9]{2})([A-Fa-f0-9]{2})$"),
			new Regex("^rgb\\(\\s*(-?\\d+(?:\\.\\d+)?%)\\s*,\\s*(-?\\d+(?:\\.\\d+)?%)\\s*,\\s*(-?\\d+(?:\\.\\d+)?%)\\s*\\)$"),
			new Regex("^rgb\\(\\s*(-?\\d+)\\s*,\\s*(-?\\d+)\\s*,\\s*(-?\\d+)\\s*\\)$"),
			new Regex("^rgba\\(\\s*(-?\\d+(?:\\.\\d+)?%)\\s*,\\s*(-?\\d+(?:\\.\\d+)?%)\\s*,\\s*(-?\\d+(?:\\.\\d+)?%)\\s*,\\s*(-?\\d+(?:\\.\\d+)?)\\s*\\)$"),
			new Regex("^rgba\\(\\s*(-?\\d+)\\s*,\\s*(-?\\d+)\\s*,\\s*(-?\\d+)\\s*,\\s*(-?\\d+(?:\\.\\d+)?)\\s*\\)$"),
			new Regex("^#([A-Fa-f0-9]{1})([A-Fa-f0-9]{1})([A-Fa-f0-9]{1})$"),
			new Regex("^hsl\\(\\s*(-?\\d+(?:\\.\\d+)?)\\s*,\\s*(-?\\d+(?:\\.\\d+)?)%\\s*,\\s*(-?\\d+(?:\\.\\d+)?)%\\s*\\)$"),
			new Regex("^hsla\\(\\s*(-?\\d+(?:\\.\\d+)?)\\s*,\\s*(-?\\d+(?:\\.\\d+)?)%\\s*,\\s*(-?\\d+(?:\\.\\d+)?)%\\s*,\\s*(-?\\d+(?:\\.\\d+)?)\\s*\\)$")
		};
		
		private static Match execPattern(Regex p, string s){
			Match m=p.Match(s);
			return (m.Success) ? m : null;
		}
		
		private static double parseHue(string value){
			try {
				double c=Convert.ToDouble(value,System.Globalization.CultureInfo.InvariantCulture);
				if(c<0||c>=360)c=(((c%360)+360)%360);
				return c;
			} catch(OverflowException){
				return Double.NaN;
			}
		}
		private static double parseByte(string value){
			try {
				double c=Convert.ToDouble(value,System.Globalization.CultureInfo.InvariantCulture);
				return (c<0 ? 0 : (c>255 ? 255 : c));
			} catch(OverflowException){
				return Double.NaN;
			}
		}
		private static double parseUnit(string value){
			try {
				double c=Convert.ToDouble(value,System.Globalization.CultureInfo.InvariantCulture);
				return (c<0 ? 0 : (c>1.0 ? 1.0 : c))*255.0;
			} catch(OverflowException){
				return Double.NaN;
			}
		}

		private static double parsePercent(string value){
			try {
				double c=Convert.ToDouble(value,System.Globalization.CultureInfo.InvariantCulture);
				return (c<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
			} catch(OverflowException){
				return Double.NaN;
			}
		}
		
		private static int GetHex(string s){
			return Int32.Parse(s,System.Globalization.NumberStyles.HexNumber,
			                   System.Globalization.CultureInfo.InvariantCulture);
		}

		public static double[] ColorToRgba(string x){
			Match e=null;
			if(x==null)return new double[]{0,0,0,0};
			if((e=execPattern(patterns[0],x))!=null){
				return new double[]{
					GetHex(e.Groups[1].ToString()),
					GetHex(e.Groups[2].ToString()),
					GetHex(e.Groups[3].ToString()),
					255
				};
			} else if((e=execPattern(patterns[1],x))!=null){
				double r1=parsePercent(e.Groups[1].ToString());
				double r2=parsePercent(e.Groups[2].ToString());
				double r3=parsePercent(e.Groups[3].ToString());
				if(Double.IsNaN(r1)||Double.IsNaN(r2)||Double.IsNaN(r3))return null;
				return new double[]{r1,r2,r3,255};
			} else if((e=execPattern(patterns[2],x))!=null){
				double r1=parseByte(e.Groups[1].ToString());
				double r2=parseByte(e.Groups[2].ToString());
				double r3=parseByte(e.Groups[3].ToString());
				if(Double.IsNaN(r1)||Double.IsNaN(r2)||Double.IsNaN(r3))return null;
				return new double[]{r1,r2,r3,255};
			} else if((e=execPattern(patterns[3],x))!=null){
				double r1=parsePercent(e.Groups[1].ToString());
				double r2=parsePercent(e.Groups[2].ToString());
				double r3=parsePercent(e.Groups[3].ToString());
				double r4=parseUnit(e.Groups[4].ToString());
				if(Double.IsNaN(r1)||Double.IsNaN(r2)||Double.IsNaN(r3)||Double.IsNaN(r4))return null;
				return new double[]{r1,r2,r3,r4};
			} else if((e=execPattern(patterns[4],x))!=null){
				double r1=parseByte(e.Groups[1].ToString());
				double r2=parseByte(e.Groups[2].ToString());
				double r3=parseByte(e.Groups[3].ToString());
				double r4=parseUnit(e.Groups[4].ToString());
				if(Double.IsNaN(r1)||Double.IsNaN(r2)||Double.IsNaN(r3)||Double.IsNaN(r4))return null;
				return new double[]{r1,r2,r3,r4};
			} else if((e=execPattern(patterns[5],x))!=null){
				int a=GetHex(e.Groups[1].ToString());
				int b=GetHex(e.Groups[2].ToString());
				int c=GetHex(e.Groups[3].ToString());
				return new double[]{a+(a<<4),b+(b<<4),c+(c<<4),255};
			} else if((e=execPattern(patterns[6],x))!=null){ // hsl
				double r1=parseHue(e.Groups[1].ToString());
				double r2=parsePercent(e.Groups[3].ToString());
				double r3=parsePercent(e.Groups[2].ToString());
				if(Double.IsNaN(r1)||Double.IsNaN(r2)||Double.IsNaN(r3))return null;
				double[] rgb=HlsToRgb(new double[]{r1,r2,r3});
				return new double[]{rgb[0],rgb[1],rgb[2],255};
			} else if((e=execPattern(patterns[7],x))!=null){ // hsla
				double r1=parseHue(e.Groups[1].ToString());
				double r2=parsePercent(e.Groups[3].ToString());
				double r3=parsePercent(e.Groups[2].ToString());
				double r4=parseUnit(e.Groups[4].ToString());
				if(Double.IsNaN(r1)||Double.IsNaN(r2)||Double.IsNaN(r3)||Double.IsNaN(r4))return null;
				double[] rgb=HlsToRgb(new double[]{r1,r2,r3});
				return new double[]{rgb[0],rgb[1],rgb[2],r4};
			} else {
				x=x.ToLower();
				if(x.IndexOf("grey")>=0)x=x.Replace("grey","gray");// support "grey" variants
				if(ColorToRgbaNamedColors.ContainsKey(x)){
					string ret=ColorToRgbaNamedColors[x];
					if(ret!=null)return ColorToRgba(ret);
				}
				if(x=="transparent")return new double[]{0,0,0,0};
				return new double[]{0,0,0,0};
			}
		}
		
		private static Dictionary<string,string> ColorToRgbaNamedColors=ColorToRgbaSetUpNamedColors();
		
		private static Dictionary<string,string> ColorToRgbaSetUpNamedColors(){
			string ncs=("aliceblue,f0f8ff,antiquewhite,faebd7,aqua,00ffff,aquamarine,7fffd4,azure,f0ffff,beige,f5f5dc,bisque,ffe4c4,black,000000,blanchedalmond,ffebcd,blue,0000ff,"
			            +"blueviolet,8a2be2,brown,a52a2a,burlywood,deb887,cadetblue,5f9ea0,chartreuse,7fff00,chocolate,d2691e,coral,ff7f50,cornflowerblue,6495ed,cornsilk,fff8dc,"
			            +"crimson,dc143c,cyan,00ffff,darkblue,00008b,darkcyan,008b8b,darkgoldenrod,b8860b,darkgray,a9a9a9,darkgreen,006400,darkkhaki,bdb76b,darkmagenta,8b008b,"
			            +"darkolivegreen,556b2f,darkorange,ff8c00,darkorchid,9932cc,darkred,8b0000,darksalmon,e9967a,darkseagreen,8fbc8f,darkslateblue,483d8b,darkslategray,2f4f4f,"
			            +"darkturquoise,00ced1,darkviolet,9400d3,deeppink,ff1493,deepskyblue,00bfff,dimgray,696969,dodgerblue,1e90ff,firebrick,b22222,floralwhite,fffaf0,forestgreen,"
			            +"228b22,fuchsia,ff00ff,gainsboro,dcdcdc,ghostwhite,f8f8ff,gold,ffd700,goldenrod,daa520,gray,808080,green,008000,greenyellow,adff2f,honeydew,f0fff0,hotpink,"
			            +"ff69b4,indianred,cd5c5c,indigo,4b0082,ivory,fffff0,khaki,f0e68c,lavender,e6e6fa,lavenderblush,fff0f5,lawngreen,7cfc00,lemonchiffon,fffacd,lightblue,add8e6,"
			            +"lightcoral,f08080,lightcyan,e0ffff,lightgoldenrodyellow,fafad2,lightgrey,d3d3d3,lightgreen,90ee90,lightpink,ffb6c1,lightsalmon,ffa07a,lightseagreen,20b2aa,"
			            +"lightskyblue,87cefa,lightslategray,778899,lightsteelblue,b0c4de,lightyellow,ffffe0,lime,00ff00,limegreen,32cd32,linen,faf0e6,magenta,ff00ff,maroon,800000,"
			            +"mediumaquamarine,66cdaa,mediumblue,0000cd,mediumorchid,ba55d3,mediumpurple,9370d8,mediumseagreen,3cb371,mediumslateblue,7b68ee,mediumspringgreen,"
			            +"00fa9a,mediumturquoise,48d1cc,mediumvioletred,c71585,midnightblue,191970,mintcream,f5fffa,mistyrose,ffe4e1,moccasin,ffe4b5,navajowhite,ffdead,navy,"
			            +"000080,oldlace,fdf5e6,olive,808000,olivedrab,6b8e23,orange,ffa500,orangered,ff4500,orchid,da70d6,palegoldenrod,eee8aa,palegreen,98fb98,paleturquoise,"
			            +"afeeee,palevioletred,d87093,papayawhip,ffefd5,peachpuff,ffdab9,peru,cd853f,pink,ffc0cb,plum,dda0dd,powderblue,b0e0e6,purple,800080,red,ff0000,rosybrown,"
			            +"bc8f8f,royalblue,4169e1,saddlebrown,8b4513,salmon,fa8072,sandybrown,f4a460,seagreen,2e8b57,seashell,fff5ee,sienna,a0522d,silver,c0c0c0,skyblue,87ceeb,"
			            +"slateblue,6a5acd,slategray,708090,snow,fffafa,springgreen,00ff7f,steelblue,4682b4,tan,d2b48c,teal,008080,thistle,d8bfd8,tomato,ff6347,turquoise,40e0d0,violet,"
			            +"ee82ee,wheat,f5deb3,white,ffffff,whitesmoke,f5f5f5,yellow,ffff00,yellowgreen,9acd32");
			string[] nc=ncs.Split(',');
			Dictionary<string,string> ColorToRgbaNamedColors=new Dictionary<string,string>();
			for(int i=0;i<nc.Length;i+=2){
				ColorToRgbaNamedColors.Add(nc[i],"#"+nc[i+1]);
			}
			return ColorToRgbaNamedColors;
		}

		public static double[] ColorToRgb(string x){
			// don't include rgba or hsla
			if(x.IndexOf("rgba")==0 || x.IndexOf("hsla")==0)return null;
			double[] rgba=ColorToRgba(x);
			if(rgba==null || rgba[3]==0)return null; // transparent
			return new double[]{rgba[0],rgba[1],rgba[2],255};
		}

		private static string RoundedString(double r){
			r=Math.Round(r,MidpointRounding.AwayFromZero);
			return Convert.ToString(r,System.Globalization.CultureInfo.InvariantCulture);
		}
		
		// Converts a color to a string.
		// 'x' is a 3- or 4-item array containing the intensity of red,
		// green, and blue (each from 0-255), with optional alpha (0-255)
		public static string RgbToColor(double[] x){
			// we should include the spaces
			if((x.Length>3 && (x[3]==255)) || x.Length==3){
				return "rgb("+RoundedString(x[0])+", "+
					RoundedString(x[1])+", "+
					RoundedString(x[2])+")";
			} else {
				double prec=Math.Round((x[3]/255.0) * Math.Pow(10, 2)) / Math.Pow(10, 2);
				return "rgba("+RoundedString(x[0])+", "+
					RoundedString(x[1])+", "+
					RoundedString(x[2])+", "+
					Convert.ToString(prec,System.Globalization.CultureInfo.InvariantCulture)+")";
			}
		}

		public static string RgbToColorDisplay(double[] rgb){
			if(rgb.Length==3 || (rgb.Length>3 && rgb[3]==255)){
				return RgbToColorHtml(rgb);
			} else {
				return RgbToColor(rgb).Replace(" ","");
			}
		}
		
		private static string HexArray="0123456789abcdef";
		
		public static string RgbToColorHtml(double[] r){
			StringBuilder sb=new StringBuilder();
			int c;
			c=((c=(int)Math.Round(r[0],MidpointRounding.AwayFromZero))<0 ? 0 : (c>255 ? 255 : c));
			sb.Append(HexArray[(c>>4)&15]);
			sb.Append(HexArray[(c)&15]);
			c=((c=(int)Math.Round(r[1],MidpointRounding.AwayFromZero))<0 ? 0 : (c>255 ? 255 : c));
			sb.Append(HexArray[(c>>4)&15]);
			sb.Append(HexArray[(c)&15]);
			c=((c=(int)Math.Round(r[2],MidpointRounding.AwayFromZero))<0 ? 0 : (c>255 ? 255 : c));
			sb.Append(HexArray[(c>>4)&15]);
			sb.Append(HexArray[(c)&15]);
			return sb.ToString();
		}
		public static string RgbToColorHtml(double r, double g,double b){
			StringBuilder sb=new StringBuilder();
			int c;
			c=((c=(int)Math.Round(r,MidpointRounding.AwayFromZero))<0 ? 0 : (c>255 ? 255 : c));
			sb.Append(HexArray[(c>>4)&15]);
			sb.Append(HexArray[(c)&15]);
			c=((c=(int)Math.Round(g,MidpointRounding.AwayFromZero))<0 ? 0 : (c>255 ? 255 : c));
			sb.Append(HexArray[(c>>4)&15]);
			sb.Append(HexArray[(c)&15]);
			c=((c=(int)Math.Round(b,MidpointRounding.AwayFromZero))<0 ? 0 : (c>255 ? 255 : c));
			sb.Append(HexArray[(c>>4)&15]);
			sb.Append(HexArray[(c)&15]);
			return sb.ToString();
		}

		private static void Main(string[] args){
			Console.WriteLine(RgbToColorDisplay(ColorToRgba("#abc")));
			Console.WriteLine(RgbToColorDisplay(ColorToRgba("#aebece")));
			Console.WriteLine(RgbToColorDisplay(ColorToRgba("rgb(20,30,40)")));
			Console.WriteLine(RgbToColorDisplay(ColorToRgba("rgb(20,30%,40)")));
			Console.WriteLine(RgbToColorDisplay(ColorToRgba("rgba(20,30,40,0.5)")));
			Console.WriteLine(RgbToColorDisplay(ColorToRgba("rgba(20,30%,40,0.5)")));

			Console.WriteLine(RgbToColorDisplay(ColorToRgba("hsl(20,30%,40%)")));
			Console.WriteLine(RgbToColorDisplay(ColorToRgba("hsl(20,30%,40)")));
			Console.WriteLine(RgbToColorDisplay(ColorToRgba("hsla(20,30%,40%,0.5)")));
			Console.WriteLine(RgbToColorDisplay(ColorToRgba("hsla(20,30%,40,0.5)")));

			Console.WriteLine(RgbToColorDisplay(ColorToRgba("green")));
			Console.WriteLine(RgbToColorDisplay(ColorToRgba("greenish")));
			Console.WriteLine(RgbToColorDisplay(ColorToRgba("transparent")));

			Console.WriteLine(RgbToColorDisplay(ColorToRgba("gray")));
			Console.WriteLine(RgbToColorDisplay(ColorToRgba("grey")));
			Console.WriteLine(RgbToColorDisplay(ColorToRgba("aliceblue")));
			Console.WriteLine(RgbToColorDisplay(ColorToRgba("#aebece")));
			Console.ReadLine();
		}
	}

}