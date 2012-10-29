
=begin
This file is in the public domain. Peter O., 2012. http://upokecenter.dreamhosters.com 
    Public domain dedication: http://creativecommons.org/publicdomain/zero/1.0/legalcode 

 This file converts between different representations of HTML and CSS colors.

ColorValidator.hls_to_rgb(hls):

Converts Hue/Lightness/Sat colors to Red/Green/Blue colors.
"hls" is a 3-element array containing the hue (0-360), lightness (0-255)
and saturation (0-255).
Returns a 3-element array containing the red, green, and blue (each 0-255).


ColorValidator.color_to_rgba(color):
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

ColorValidator.color_to_rgb(color):
--- NOTE: Use this function to parse colors from normal color picker controls:
--- http://peteroupc.github.com/colorpicker/
Converts HTML colors to Red/Green/Blue colors.
"color" is a CSS color, HTML color, or color name, NOT including
RGBA or HSLA (ex. #223344 or #234 or royalblue 
or rgb(20,20,20) or hsl(100,100%,50%)).
Invalid strings result in a return value of nil.
Returns a 4-element array containing the red, green, blue, and alpha
(each 0-255); the alpha is always 255.

ColorValidator.rgb_to_color(rgb):

Converts an RGBA color to a string, either rgb(...) or rgba(...) as applicable.
"rgb" must contain at least 3 elements: the red, green, and blue (each 0-255).
It can optionally contain a fourth element representing the alpha (0-255).

ColorValidator.rgb_to_color_display(rgb):

Converts an RGBA color to a string, (ex. #002233 or rgba(...) as applicable).
"rgb" must contain at least 3 elements: the red, green, and blue (each 0-255).
It can optionally contain a fourth element representing the alpha (0-255).

ColorValidator.rgb_to_color_html(rgb):

Converts an RGBA color to an HTML color, (ex. #002233).
"rgb" must contain at least 3 elements: the red, green, and blue (each 0-255).

ColorValidator.color_html_to_rgba(color):

Converts HTML colors to Red/Green/Blue colors.
"color" is an HTML color or color name (ex. #223344, #234, or royalblue).
All strings are treated as valid.
Returns a 4-element array containing the red, green, blue, and alpha
(each 0-255); the alpha is always 255.
=end

module ColorValidator
def self.hls_to_rgb(hls) 
 hueval=hls[0]*1.0;#[0-360)
 lum=hls[1]*1.0;#[0-255]
 sat=hls[2]*1.0;#[0-255]
 lum=(lum<0 ? 0 : (lum>255 ? 255 : lum));
 sat=(sat<0 ? 0 : (sat>255 ? 255 : sat));
 if(sat==0)
  return array(lum,lum,lum);
 end
 b=0;
 if (lum<=127.5) 
  b=(lum*(255.0+sat))/255.0;
 else
  b=lum*sat;
  b=b/255.0;
  b=lum+sat-b;
 end
 a=(lum*2)-b;
 r=0;g=0;bl=0;
 if(hueval<0||hueval>=360);hueval=(((hueval%360)+360)%360);end;
 hue=hueval+120;
 if(hue>=360);hue-=360;end;
 if (hue<60); r=(a+(b-a)*hue/60);
 elsif (hue<180); r=b;
 elsif (hue<240); r=(a+(b-a)*(240-hue)/60);
 else r=a;end;
 hue=hueval;
 if (hue<60); g=(a+(b-a)*hue/60);
 elsif (hue<180); g=b;
 elsif (hue<240); g=(a+(b-a)*(240-hue)/60);
 else g=a;end;
 hue=hueval-120;
 if(hue<0);hue+=360;end;
 if (hue<60); bl=(a+(b-a)*hue/60);
 elsif (hue<180); bl=b;
 elsif (hue<240); bl=(a+(b-a)*(240-hue)/60);
 else bl=a;end;
 return [(r<0 ? 0 : (r>255 ? 255 : r)),
   (g<0 ? 0 : (g>255 ? 255 : g)),
   (bl<0 ? 0 : (bl>255 ? 255 : bl))];
end

def self.color_html_to_rgba(x)
 arr=[];
 if(!x || strlen(x)==0);return [0,0,0,255];end;
 ColorValidator.color_to_rgba_setUpNamedColors();
 x=x.downcase;
 if(x.index("grey"));x=x.sub(/grey/,"gray");end;# support "grey" variants
 ret=@color_to_rgba_namedColors[x];
 if(ret.is_a?(String));return ColorValidator.color_to_rgba(ret);end;
 i=(x[0]=="#") ? 1 : 0;while i<x.length do
  c=Ord(x[i]);
  hex=0;
  if(c>=0x30 && c<=0x39);hex=c-0x30;end;
  if(c>=0x61 && c<=0x66);hex=c-0x61+10;end;
  arr[count(arr)]=hex;
  i+=1;
 end
 sublength=floor((count(arr)+2)/3);
 while(count(arr)<sublength*3)
  arr[count(arr)]=0;
 end
 currlength=sublength;
 offset=0;
 while(currlength>2)
  if(arr[offset]==0 && arr[sublength+offset]==0 &&
      arr[sublength*2+offset]==0)
   currlength-=1; offset+=1; 
  else break; end;
 end
 return [
   arr[offset]*16+arr[offset+1],
   arr[sublength+offset]*16+arr[sublength+offset+1],
   arr[sublength*2+offset]*16+arr[sublength*2+offset+1],
   255
 ];
end

# Converts a representation of a color to its RGB form
# Returns a 4-item array containing the intensity of red,
# green, blue, and alpha (each from 0-255)
def self.color_to_rgba(x)
 e=[];
 if(!x);return nil;end
 c=nil;
 if(/\A#([A-Fa-f0-9]{2})([A-Fa-f0-9]{2})([A-Fa-f0-9]{2})\z/=~x)
  return [$1.to_i(16),$2.to_i(16),$3.to_i(16),255];
 elsif(/\Argb\(\s*(-?\d+)\s*,\s*(-?\d+)\s*,\s*(-?\d+)\s*\)\z/=~x)
  r1=((c=$1.to_i)<0 ? 0 : (c>255 ? 255 : c));
  r2=((c=$2.to_i)<0 ? 0 : (c>255 ? 255 : c));
  r3=((c=$3.to_i)<0 ? 0 : (c>255 ? 255 : c));
  return [r1,r2,r3,255];
 elsif(/\Argb\(\s*(-?\d+(?:\.\d+)?%)\s*,\s*(-?\d+(?:\.\d+)?%)\s*,\s*(-?\d+(?:\.\d+)?%)\s*\)\z/=~x)
  r1=((c=$1.to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  r2=((c=$2.to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  r3=((c=$3.to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  return [r1,r2,r3,255];
 elsif(/\Argba\(\s*(-?\d+)\s*,\s*(-?\d+)\s*,\s*(-?\d+)\s*,\s*(-?\d+(?:\.\d+)?)\s*\)\z/=~x)
  r1=((c=$1.to_i)<0 ? 0 : (c>255 ? 255 : c));
  r2=((c=$2.to_i)<0 ? 0 : (c>255 ? 255 : c));
  r3=((c=$3.to_i)<0 ? 0 : (c>255 ? 255 : c));
  r4=((c=$4.to_f)<0 ? 0 : (c>1 ? 1 : c))*255;
  return [r1,r2,r3,r4];
 elsif(/\Argba\(\s*(-?\d+(?:\.\d+)?%)\s*,\s*(-?\d+(?:\.\d+)?%)\s*,\s*(-?\d+(?:\.\d+)?%)\s*,\s*(-?\d+(?:\.\d+)?)\s*\)\z/=~x)
  r1=((c=($1).to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  r2=((c=($2).to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  r3=((c=($3).to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  r4=((c=($4).to_f)<0 ? 0 : (c>1 ? 1 : c))*255;
  return [r1,r2,r3,r4];
 elsif(/\A#([A-Fa-f0-9]{1})([A-Fa-f0-9]{1})([A-Fa-f0-9]{1})\z/=~x)
  a=$1.to_i(16);b=$2.to_i(16);c=$3.to_i(16);
  return [a+(a<<4),b+(b<<4),c+(c<<4),255];
 elsif(/\Ahsl\(\s*(-?\d+(?:\.\d+)?)\s*,\s*(-?\d+(?:\.\d+)?)%\s*,\s*(-?\d+(?:\.\d+)?)%\s*\)\z/=~x)
  r1=($1).to_f;
  if(r1<0||r1>=360);r1=(((r1%360)+360)%360);end;
  r2=((c=($3).to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  r3=((c=($2).to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  rgb=hls_to_rgb([r1,r2,r3]);
  return [rgb[0],rgb[1],rgb[2],255];
 elsif(/\Ahsla\(\s*(-?\d+(?:\.\d+)?)\s*,\s*(-?\d+(?:\.\d+)?)%\s*,\s*(-?\d+(?:\.\d+)?)%\s*,\s*(-?\d+(?:\.\d+)?)\s*\)\z/=~x)
  r1=($1).to_f;
  if(r1<0||r1>=360);r1=(((r1%360)+360)%360);end;
  r2=((c=($3).to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  r3=((c=($2).to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  r4=((c=($4).to_f)<0 ? 0 : (c>1 ? 1 : c))*255;
  rgb=hls_to_rgb([r1,r2,r3]);
  return [rgb[0],rgb[1],rgb[2],r4];
 else
  ColorValidator.color_to_rgba_setUpNamedColors();
  x=x.downcase;
  if(x.index("grey"));x=x.sub(/grey/,"gray");end;# support "grey" variants
  ret=@color_to_rgba_namedColors[x];
  if(ret.is_a?(String));return ColorValidator.color_to_rgba(ret);end
  if(x=="transparent");return [0,0,0,0];end
  return nil;
 end
end

def self.color_to_rgb(x)
 # don't include rgba or hsla
 if(index(x,"rgba")==0 || index(x,"hsla")==0);return nil;end;
 rgba=ColorValidator.color_to_rgba(x);
 if(!rgba || rgba[3]==0);return nil;end;
 return array(rgba[0],rgba[1],rgba[2],255);
end

# Converts a color to a string.
# 'x' is a 3- or 4-item array containing the intensity of red,
# green, and blue (each from 0-255), with optional alpha (0-255)
def self.rgb_to_color(x)
 # we should include the spaces
 x=[0,0,0,0] if !x
 if((x.length>3 && (x[3]==255 || x[3]==nil)) || x.length==3)
  return "rgb("+(x[0]).round.to_s+", "+(x[1]).round.to_s+", "+(x[2]).round.to_s+")";
 else
  prec=(x[3]/255.0).round(2);
  prec=prec.to_i if prec.to_i==prec
  return "rgba("+(x[0]).round.to_s+", "+(x[1]).round.to_s+", "+(x[2]).round.to_s+", "+prec.to_s+")";
 end
end

def self.rgb_to_color_display(rgb)
 rgb=[0,0,0,0] if !rgb
 if(rgb.length==3 || (rgb.length>3 && rgb[3]==nil || rgb[3]==255))
  return rgb_to_color_html(rgb);
 else
  return rgb_to_color(rgb).gsub(/\s+/,"");
 end
end
@rgb_to_color_html_table=nil;
def self.rgb_to_color_html(r,g=nil,b=nil)
 if(!@rgb_to_color_html_table)
  @rgb_to_color_html_table=[];
  256.times do |i|
   y=i.to_s(16);
   @rgb_to_color_html_table[i]=(y.length==1) ? "0"+y : y;
  end
 end
 c=nil;
 if(r!=nil && g==nil && b==nil)
   return "#"+@rgb_to_color_html_table[((c=(r[0]).round)<0 ? 0 : (c>255 ? 255 : c))]+
        @rgb_to_color_html_table[((c=(r[1]).round)<0 ? 0 : (c>255 ? 255 : c))]+
        @rgb_to_color_html_table[((c=(r[2]).round)<0 ? 0 : (c>255 ? 255 : c))];
 else
   return "#"+@rgb_to_color_html_table[((c=(r).round)<0 ? 0 : (c>255 ? 255 : c))]+
        @rgb_to_color_html_table[((c=(g).round)<0 ? 0 : (c>255 ? 255 : c))]+
        @rgb_to_color_html_table[((c=(b).round)<0 ? 0 : (c>255 ? 255 : c))];
 end
end
private
@color_to_rgba_namedColors=nil;
def self.color_to_rgba_setUpNamedColors()
  if(!@color_to_rgba_namedColors)
    ncs=("aliceblue,f0f8ff,antiquewhite,faebd7,aqua,00ffff,aquamarine,7fffd4,azure,f0ffff,beige,f5f5dc,bisque,ffe4c4,black,000000,blanchedalmond,ffebcd,blue,0000ff,"+
"blueviolet,8a2be2,brown,a52a2a,burlywood,deb887,cadetblue,5f9ea0,chartreuse,7fff00,chocolate,d2691e,coral,ff7f50,cornflowerblue,6495ed,cornsilk,fff8dc,"+
"crimson,dc143c,cyan,00ffff,darkblue,00008b,darkcyan,008b8b,darkgoldenrod,b8860b,darkgray,a9a9a9,darkgreen,006400,darkkhaki,bdb76b,darkmagenta,8b008b,"+
"darkolivegreen,556b2f,darkorange,ff8c00,darkorchid,9932cc,darkred,8b0000,darksalmon,e9967a,darkseagreen,8fbc8f,darkslateblue,483d8b,darkslategray,2f4f4f,"+
"darkturquoise,00ced1,darkviolet,9400d3,deeppink,ff1493,deepskyblue,00bfff,dimgray,696969,dodgerblue,1e90ff,firebrick,b22222,floralwhite,fffaf0,forestgreen,"+
"228b22,fuchsia,ff00ff,gainsboro,dcdcdc,ghostwhite,f8f8ff,gold,ffd700,goldenrod,daa520,gray,808080,green,008000,greenyellow,adff2f,honeydew,f0fff0,hotpink,"+
"ff69b4,indianred,cd5c5c,indigo,4b0082,ivory,fffff0,khaki,f0e68c,lavender,e6e6fa,lavenderblush,fff0f5,lawngreen,7cfc00,lemonchiffon,fffacd,lightblue,add8e6,"+
"lightcoral,f08080,lightcyan,e0ffff,lightgoldenrodyellow,fafad2,lightgrey,d3d3d3,lightgreen,90ee90,lightpink,ffb6c1,lightsalmon,ffa07a,lightseagreen,20b2aa,"+
"lightskyblue,87cefa,lightslategray,778899,lightsteelblue,b0c4de,lightyellow,ffffe0,lime,00ff00,limegreen,32cd32,linen,faf0e6,magenta,ff00ff,maroon,800000,"+
"mediumaquamarine,66cdaa,mediumblue,0000cd,mediumorchid,ba55d3,mediumpurple,9370d8,mediumseagreen,3cb371,mediumslateblue,7b68ee,mediumspringgreen,"+
"00fa9a,mediumturquoise,48d1cc,mediumvioletred,c71585,midnightblue,191970,mintcream,f5fffa,mistyrose,ffe4e1,moccasin,ffe4b5,navajowhite,ffdead,navy,"+
"000080,oldlace,fdf5e6,olive,808000,olivedrab,6b8e23,orange,ffa500,orangered,ff4500,orchid,da70d6,palegoldenrod,eee8aa,palegreen,98fb98,paleturquoise,"+
"afeeee,palevioletred,d87093,papayawhip,ffefd5,peachpuff,ffdab9,peru,cd853f,pink,ffc0cb,plum,dda0dd,powderblue,b0e0e6,purple,800080,red,ff0000,rosybrown,"+
"bc8f8f,royalblue,4169e1,saddlebrown,8b4513,salmon,fa8072,sandybrown,f4a460,seagreen,2e8b57,seashell,fff5ee,sienna,a0522d,silver,c0c0c0,skyblue,87ceeb,"+
"slateblue,6a5acd,slategray,708090,snow,fffafa,springgreen,00ff7f,steelblue,4682b4,tan,d2b48c,teal,008080,thistle,d8bfd8,tomato,ff6347,turquoise,40e0d0,violet,"+
"ee82ee,wheat,f5deb3,white,ffffff,whitesmoke,f5f5f5,yellow,ffff00,yellowgreen,9acd32");
    nc=ncs.split(",");
    @color_to_rgba_namedColors={};
    i=0;while i<nc.length;
     @color_to_rgba_namedColors[nc[i]]="#"+nc[i+1];
     i+=2;
    end
  end
end
end
