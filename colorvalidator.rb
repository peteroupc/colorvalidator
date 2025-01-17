#!/usr/bin/ruby
=begin
This file is in the public domain. Peter O., 2012. http://peteroupc.github.io
    Any copyright to this work is released to the Public Domain.  In case this is not possible, this work is also licensed under the Unlicense: https://unlicense.org/

 This file converts between different representations of HTML and CSS colors.

ColorValidator.hls_to_rgb(hls):

Converts Hue/Lightness/Sat colors to Red/Green/Blue colors.
"hls" is a 3-element array containing the hue (0-360), lightness (0-255)
and saturation (0-255).
Returns a 3-element array containing the red, green, and blue (each 0-255).

ColorValidator.color_to_rgba(color):
Converts HTML colors to Red/Green/Blue/Alpha colors.
"color" is as follows.
A string that names a color. The letters in the string can be in any combination of basic uppercase letters A to Z (U+0041 to U+005A) and basic lowercase letters. The string can begin with any combination of white space characters (U+0009, U+000A, U+000C, U+000D, U+0020), can end with any combination of those characters, or both.

**What colors can I use?** You can use values like the following as color strings.

1. CSS color names (from the CSS3 Color Module): `red`, `blue`, `silver`, `fuchsia`, `darkslateblue`.

2. HTML hexadecimal (base-16) colors: `#223344`, `#234`, `#234F`, or `#223344FF` (see _What is the syntax for HTML colors?_).

3. RGB notation: `rgb(20, 30, 40)` or `rgba(20, 30, 40, 50%)` (see _What is RGB notation?_, later).

4. HSL notation: `hsl(200, 100%, 50%)` or `hsla(200, 100%, 50%, 80%` (see _What is HSL notation?_, later).

5. The newly-added color name `rebeccapurple`.

6. The word `transparent`, meaning a fully-transparent color.

**What do some colors look like?** Consult a [list of useful colors sorted by hue or color tone](https://peteroupc.github.io/html3dutil/websafe.svg). This particular list was historically called the "Web safe" colors or the "safety palette", and consists of 216 colors that are uniformly spaced in the red&#x2013;green&#x2013;blue color cube. Robert Hess's article "[The Safety Palette](https://learn.microsoft.com/en-us/previous-versions/ms976419(v=msdn.10))", 1996, described the advantage that images that use only colors in this palette won't dither when displayed by Web browsers on displays that can show up to 256 colors at once. (See also [**Wikipedia**](http://en.wikipedia.org/wiki/Web_colors). Dithering is the scattering of colors in a limited set to simulate colors outside that set.) Each entry in the list consists of a color swatch and the corresponding HTML name (see next question).

A [second list](https://peteroupc.github.io/html3dutil/colornames.svg) shows the colors defined in the [**CSS3 Color Module section 4**](https://www.w3.org/TR/css3-color/#colorunits), as well as the newly-added name `rebeccapurple`. Where `gray` is part of a name, it can be replaced with `grey`. Next to the name of each color in the list, the color's HTML notation is shown.

**What is the syntax for HTML colors?** The notation employed in the "safety palette" in the preceding section is HTML's way to define colors. The notation expresses a hexadecimal (base-16) color. Take `#ff80cc` as an example. The color defined is a carnation pink. There are four parts to this example:

1. The `#` identifies this code as a color.

2. The `ff` is two letters and/or digits that show the red component of the color. This is a so-called hexadecimal number, or base-16 number. Each digit of this number can range from 0 to 9 and from A to F, with 0 being the lowest digit, and F being the highest digit. The highest two-digit value is 00, and the lowest two-digit value is FF (255). The digits A-F may appear in uppercase or lowercase.

3. The `80` is a base-16 number showing the color&#8217;s green component.

4. The `cc` is a base-16 number showing the color&#8217;s blue component.

The notation may also include an additional base-16 number, as in this example: `#ac80ccff`. Here, the last `ff` shows the color's alpha component (see _What is an alpha component?_, later). Two shortened notations are supported: colors with only three or four base-16 digits are the same as their expanded six-digit or eight-digit form, respectively. For example, `#f8c`  is the same as `#ff88cc`; and `#f8ce`, `#ff88ccee`.

**How do I make HTML colors?** Look at the following table that shows some of the values possible for the red, green, and blue components of some colors.

Red.. 00 10 20 30 40 50 60 70 80 90 A0 B0 C0 D0 E0 F0 FF.

Green 00 10 20 30 40 50 60 70 80 90 A0 B0 C0 D0 E0 F0 FF.

Blue. 00 10 20 30 40 50 60 70 80 90 A0 B0 C0 D0 E0 F0 FF.

Now, to make a custom color, you choose one value from the red row, one value from the green row, and one value from the blue row. Each value shows the intensity of the "light" that the color ideally reflects. For example, a red value of 00 means that, ideally, "red light" is not reflected, and a red value of FF, fully reflected.

If you choose the same value in all three rows, the result is black (if you choose 00), white (if you choose FF) or a shade of gray. This shows that "red light", "green light", and "blue light" are ideally equally reflected.

After you choose the three values, combine them by writing the `#` , then the red value, then the green value, then the blue value. For example, if you choose `FF` for red, `A0` for green, and `00` for blue, write the resulting color (orange) like this: `#FFA000`.

**How do I "darken" an HTML color?** To "darken" a color (make a _shade_ of it), consult the table shown in the question _How do I make HTML colors?_, earlier, and move each component (red, green, and blue) the same number of steps to the left. If you can&#8217;t move a component that far to the left, that component becomes 00. For example, to make a "darker" sky blue, start with 00, FF, and FF for red, green, and blue. When we move these components ten steps to the left, we get 00, 60, and 60. The final color becomes #006060.

**How do I "lighten" an HTML color?** "Lightening" a color (making a _tint_ of it) is almost the same as "darkening" a color, except we move the same number of steps to the right rather than the left. If you can&#8217;t move a component that far to the right, that component becomes FF. For example, to make a "lighter" red, start with FF, 00, and 00 for red, green, and blue. When we move these components ten steps to the right, we get FF, A0, and A0. The final color becomes #FFA0A0.

**How do I "desaturate" an HTML color?** To make a "desaturated" ("washed-out") version (or *tone*) of a color, move the color components closer to each other, in about the same proportion. (If they&#8217;re exactly the same, the result is a shade of gray.) For example, to make a "washed-out" red, start with FF, 00, and 00 for red, green, and blue. When we move these components closer to each other, we get C0, 40, and 40. The final color becomes #C04040.

**What is RGB notation?** A color in RGB notation contains the same information as an HTML color, except that each value is shown in the familiar base-10 format. For example, the value `rgb(192, 64, 0)` is the same as the HTML color value `#C04000`.

The components of the RGB color (red, green, and blue, in that order) can range from `0`  to `255` , or from `0%` to `100%`, but mixing ranges is not allowed. For example, `rgb(192, 64, 0)` and `rgb(80%, 50%, 0%)` are allowed, but not `rgb(192, 50%, 0%)`. The steps for "darkening", "lightening", and "desaturating" RGB colors are largely the same as with HTML colors. Another syntax for RGB colors supports the alpha component (see _What is an alpha component?_, later): in the example `rgba(192, 64, 0, 0.5)` , the `0.5` is the alpha component. This component supports either range for RGB colors, either 0-255 or percentages. (Note that the example starts with `rgba`, not just `rgb`.)

**What is HSL notation?** A color in HSL notation is made of the following three components:

1. _Hue_ ranges from 0 to 360 degrees. Each angle on the color wheel (which looks more like a hexagon than like a circle in HSL) stands for a different hue: red, yellow, green, cyan (sky-blue), blue, and magenta correspond roughly to hue 0 (say, 12 o&#8217;clock), 60, 120, 180, 240, and 300, respectively.

2. "Saturation", which ranges from 0% to 100%, is the distance of the color from gray (0% means gray; 100% means most distant from gray).

3. "Lightness", which likewise ranges from 0% to 100%, is roughly the amount of black or white mixed with the color (0% means black; 100% means white; closer to 0% means closer to black; closer to 100% means closer to white).

**Example:** The value `hsl(240, 100%, 50%)` has a hue of 240 (blue), a "saturation" of 100% ("fully saturated"), and a "lightness" of 50% (as far from "black" as from "white"). It represents a vivid blue. If we lower "lightness" to 20%, we get a "darker" blue. If we also change the hue to 0, we get a "dark" red.

An alternative syntax for HSL colors supports the alpha component (see next question): in the example `hsla(240, 100%, 50%, 80%)`, the `80%` is the alpha component.

**What is an alpha component?** An alpha component shows how much the color is transparent (see-through) or opaque. The alpha component can range from `00`  / `0.0`, or "fully transparent" (completely invisible), to `FF` / `1.0` , or "fully opaque" (letting nothing through it). If a color notation doesn't provide for an alpha component, the color is fully opaque.
Returns a 4-element array containing the red, green, blue, and alpha
(each 0-255).

ColorValidator.color_to_rgb(color):
Same as color_to_rgb, except the 'rgba' and 'hsla' notation
is not allowed and neither are color strings that result in a
nonopaque color (color with an alpha component other than 255).

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
 if(!x || x.length==0);return [0,0,0,255];end;
 ColorValidator.color_to_rgba_setUpNamedColors();
 x=x.downcase;
 if(x.index("grey"));x=x.sub(/grey/,"gray");end;# support "grey" variants
 ret=@color_to_rgba_namedColors[x];
 if(ret.is_a?(String));return ColorValidator.color_to_rgba(ret);end;
 i=(x[0]=="#") ? 1 : 0;while i<x.length do
  c=0
  x[i,1].each_byte{|b| c=b };
  hex=0;
  if(c>=0x30 && c<=0x39);hex=c-0x30;end;
  if(c>=0x61 && c<=0x66);hex=c-0x61+10;end;
  arr.push(hex);
  i+=1;
 end
 sublength=((arr.length+2)/3).floor;
 while(arr.length<sublength*3)
  arr.push(0);
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
 elsif(/\Argb\(\s*([\+\-]?\d+)\s*,\s*([\+\-]?\d+)\s*,\s*([\+\-]?\d+)\s*\)\z/=~x)
  r1=((c=$1.to_i)<0 ? 0 : (c>255 ? 255 : c));
  r2=((c=$2.to_i)<0 ? 0 : (c>255 ? 255 : c));
  r3=((c=$3.to_i)<0 ? 0 : (c>255 ? 255 : c));
  return [r1,r2,r3,255];
 elsif(/\Argb\(\s*([\+\-]?\d+(?:\.\d+)?%)\s*,\s*([\+\-]?\d+(?:\.\d+)?%)\s*,\s*([\+\-]?\d+(?:\.\d+)?%)\s*\)\z/=~x)
  r1=((c=$1.to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  r2=((c=$2.to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  r3=((c=$3.to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  return [r1,r2,r3,255];
 elsif(/\Argba\(\s*([\+\-]?\d+)\s*,\s*([\+\-]?\d+)\s*,\s*([\+\-]?\d+)\s*,\s*([\+\-]?\d+(?:\.\d+)?)\s*\)\z/=~x)
  r1=((c=$1.to_i)<0 ? 0 : (c>255 ? 255 : c));
  r2=((c=$2.to_i)<0 ? 0 : (c>255 ? 255 : c));
  r3=((c=$3.to_i)<0 ? 0 : (c>255 ? 255 : c));
  r4=((c=$4.to_f)<0 ? 0 : (c>1 ? 1 : c))*255;
  return [r1,r2,r3,r4];
 elsif(/\Argba\(\s*([\+\-]?\d+(?:\.\d+)?%)\s*,\s*([\+\-]?\d+(?:\.\d+)?%)\s*,\s*([\+\-]?\d+(?:\.\d+)?%)\s*,\s*([\+\-]?\d+(?:\.\d+)?)\s*\)\z/=~x)
  r1=((c=($1).to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  r2=((c=($2).to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  r3=((c=($3).to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  r4=((c=($4).to_f)<0 ? 0 : (c>1 ? 1 : c))*255;
  return [r1,r2,r3,r4];
 elsif(/\A#([A-Fa-f0-9]{1})([A-Fa-f0-9]{1})([A-Fa-f0-9]{1})\z/=~x)
  a=$1.to_i(16);b=$2.to_i(16);c=$3.to_i(16);
  return [a+(a<<4),b+(b<<4),c+(c<<4),255];
 elsif(/\Ahsl\(\s*([\+\-]?\d+(?:\.\d+)?)\s*,\s*([\+\-]?\d+(?:\.\d+)?)%\s*,\s*([\+\-]?\d+(?:\.\d+)?)%\s*\)\z/=~x)
  r1=($1).to_f;
  if(r1<0||r1>=360);r1=(((r1%360)+360)%360);end;
  r2=((c=($3).to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  r3=((c=($2).to_f)<0 ? 0 : (c>100 ? 100 : c))*255.0/100.0;
  rgb=hls_to_rgb([r1,r2,r3]);
  return [rgb[0],rgb[1],rgb[2],255];
 elsif(/\Ahsla\(\s*([\+\-]?\d+(?:\.\d+)?)\s*,\s*([\+\-]?\d+(?:\.\d+)?)%\s*,\s*([\+\-]?\d+(?:\.\d+)?)%\s*,\s*([\+\-]?\d+(?:\.\d+)?)\s*\)\z/=~x)
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
"lightcoral,f08080,lightcyan,e0ffff,lightgoldenrodyellow,fafad2,lightgray,d3d3d3,lightgreen,90ee90,lightpink,ffb6c1,lightsalmon,ffa07a,lightseagreen,20b2aa,"+
"lightskyblue,87cefa,lightslategray,778899,lightsteelblue,b0c4de,lightyellow,ffffe0,lime,00ff00,limegreen,32cd32,linen,faf0e6,magenta,ff00ff,maroon,800000,"+
"mediumaquamarine,66cdaa,mediumblue,0000cd,mediumorchid,ba55d3,mediumpurple,9370d8,mediumseagreen,3cb371,mediumslateblue,7b68ee,mediumspringgreen,"+
"00fa9a,mediumturquoise,48d1cc,mediumvioletred,c71585,midnightblue,191970,mintcream,f5fffa,mistyrose,ffe4e1,moccasin,ffe4b5,navajowhite,ffdead,navy,"+
"000080,oldlace,fdf5e6,olive,808000,olivedrab,6b8e23,orange,ffa500,orangered,ff4500,orchid,da70d6,palegoldenrod,eee8aa,palegreen,98fb98,paleturquoise,"+
"afeeee,palevioletred,d87093,papayawhip,ffefd5,peachpuff,ffdab9,peru,cd853f,pink,ffc0cb,plum,dda0dd,powderblue,b0e0e6,purple,800080,rebeccapurple,663399,red,ff0000,rosybrown,"+
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
