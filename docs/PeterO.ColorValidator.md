## PeterO.ColorValidator

    public static class ColorValidator

Color validator.

### Member Summary
* <code>[ColorToRgba(string)](#ColorToRgba_string)</code> - Converts an HTML or CSS color string to a 4-element RGB array.
* <code>[HlsToRgb(double, double, double)](#HlsToRgb_double_double_double)</code> - Converts a color in the HLS color space to red/green/blue.
* <code>[RgbToColor(double[])](#RgbToColor_double)</code> - Converts an RGBA color to a string, either rgb(.
* <code>[RgbToColorDisplay(double[])](#RgbToColorDisplay_double)</code> - Converts a red&ndash;green&ndash;blue-alpha color to a string in CSS format.
* <code>[RgbToColorHtml(double[])](#RgbToColorHtml_double)</code> - Converts an RGBA color to an HTML color, (ex.

<a id="ColorToRgba_string"></a>
### ColorToRgba

    public static double[] ColorToRgba(
        string x);

Converts an HTML or CSS color string to a 4-element RGB array.

<b>Parameters:</b>

 * <i>x</i>: A string which names a color. The letters in the string can be in any combination of basic upper-case letters A to Z (U+0041 to U+005A) and basic lower-case letters. The string can begin with any combination of white space characters (U+0009, U+000A, U+000C, U+000D, U+0020), can end with any combination of those characters, or both.

**What colors can I use?** You can use values like the following as color strings.

 * CSS color names (from the CSS3 Color Module):  `red`  ,  `blue`  ,  `silver`  ,  `fuchsia`  ,  `darkslateblue`  .

 * HTML “hex colors”:  `#223344`  ,  `#234`  ,  `#234F`  , or  `#223344FF`  . (See _What is the syntax for HTML colors?_)

 * RGB notation:  `rgb(20, 30, 40)`  or  `rgba(20, 30, 40, 50%)`  . (See _What is RGB notation?_, later.)

 * HSL notation:  `hsl(200, 100%, 50%)`  or  `hsla(200, 100%, 50%, 80%`  . (See _What is HSL notation?_, later.)

 * The newly-added color name  `rebeccapurple`  .

 * The word  `transparent`  , meaning a fully-transparent color.

**What do some colors look like?** Consult a [list of useful colors sorted by hue or color tone](https://peteroupc.github.io/html3dutil/websafe.svg). This particular list was historically called the "Web safe" colors, which were chosen "specifically because they matched the palettes selected by various browser applications" for 256-color displays (according to [**Wikipedia**](http://en.wikipedia.org/wiki/Web_colors)). Each entry in the list consists of a color swatch and the corresponding HTML name (see next question).

A [second list](https://peteroupc.github.io/html3dutil/colornames.svg) shows the colors defined in the [**CSS3 Color Module section 4**](http://www.w3.org/TR/css3-color/#colorunits), as well as the newly-added name  `rebeccapurple`  . Where  `gray`  is part of a name, it can be replaced with  `grey`  . Next to the name of each color in the list, the color's HTML notation is shown.

**What is the syntax for HTML colors?** The notation employed in the list of "Web safe colors" in the preceding section is HTML's way to define colors. It’s also known as “hex colors”. Take  `#ff80cc`  as an example. The color defined is a carnation pink. There are four parts to this example:

 * The  `#`  identifies this code as a color.

 * The  `ff`  is two letters and/or digits that show the red component of the color. This is a so-called hexadecimal number, or base-16 number. Each digit of this number can range from 0-9 and from A-F, with 0 being the lowest digit, and F being the highest digit. The highest two-digit value is 00, and the lowest two-digit value is FF (256). (The digits A-F may appear in upper or lower case.)

 * The  `80`  is a base-16 number showing the color’s green component.

 * The  `cc`  is a base-16 number showing the color’s blue component.

The notation may also include an additional base-16 number, as in this example:  `#ac80ccff`  . Here, the last  `ff`  shows the color's alpha component (see _What is an alpha component?_, later). Two shortened notations are supported: colors with only three or four base-16 digits are the same as their expanded six-digit or eight-digit form, respectively. For example,  `#f8c`  is the same as  `#ff88cc`  ; and  `#f8ce`  ,  `#ff88ccee`  .

**How do I make HTML colors?** Look at the table below that shows some of the values possible for the red, green, and blue components of some colors.

                Red.. 00 10 20 30 40 50 60 70 80 90 A0 B0 C0 D0 E0 F0 FF
                Green 00 10 20 30 40 50 60 70 80 90 A0 B0 C0 D0 E0 F0 FF
                Blue. 00 10 20 30 40 50 60 70 80 90 A0 B0 C0 D0 E0 F0 FF

Now, to make a custom color, you choose one value from the red row, one value from the green row, and one value from the blue row. Each value shows the intensity of the "light" that the color ideally reflects. For example, a red value of 00 means that, ideally, "red light" is not reflected, and a red value of FF, fully reflected.

If you choose the same value in all three rows, the result is black (if you choose 00), white (if you choose FF) or a shade of gray. This shows that "red light", "green light", and "blue light" are ideally equally reflected.

After you choose the three values, combine them by writing the  `#`  , then the red value, then the green value, then the blue value. For example, if you choose  `FF`  for red,  `A0`  for green, and  `00`  for blue, write the resulting color (orange) like this:  `#FFA000`  .

**How do I "darken" an HTML color?** To darken a color (make a * shade* of it), consult the table shown in the question _How do I make HTML colors?_, earlier, and move each component (red, green, and blue) the same number of steps to the left. If you can’t move a component that far to the left, that component becomes 00. For example, to make a "darker" sky blue, start with 00, FF, and FF for red, green, and blue. When we move these components ten steps to the left, we get 00, 60, and 60. The final color becomes #006060.

**How do I "lighten" an HTML color?** "Lightening" a color (making a *tint* of it) is almost the same as "darkening" a color, except we move the same number of steps to the right rather than the left. If you can’t move a component that far to the right, that component becomes FF. For example, to make a "lighter" red, start with FF, 00, and 00 for red, green, and blue. When we move these components ten steps to the right, we get FF, A0, and A0. The final color becomes #FFA0A0.

**How do I "desaturate" an HTML color?** To make a "desaturated" ("washed-out") version (or *tone*) of a color, move the color components closer to each other, in about the same proportion. (If they’re exactly the same, the result is a shade of gray.) For example, to make a "washed-out" red, start with FF, 00, and 00 for red, green, and blue. When we move these components closer to each other, we get C0, 40, and 40. The final color becomes #C04040.

**What is RGB notation?** A color in RGB notation contains the same information as an HTML color, except that each value is shown in the familiar base-10 format. For example, the value  `rgb(192, 64, 0)`  is the same as the HTML color value  `#C04000`  .

The components of the RGB color (red, green, and blue, in that order) can range from  `0`  to  `255`  , or from  `0%`  to  `100%`  , but mixing ranges is not allowed. For example,  `rgb(192, 64, 0)`  and  `rgb(80%, 50%, 0%)`  are allowed, but not  `rgb(192, 50%, 0%)`  . The steps for "darkening", "lightening", and "desaturating" RGB colors are pretty much the same as with HTML colors. Another syntax for RGB colors supports the alpha component (see _What is an alpha component?_, later): in the example  `rgba(192, 64, 0, 0.5)`  , the  `0.5`  is the alpha component. This component supports either range for RGB colors, either 0-255 or percentages. (Note that the example starts with  `rgba`  , not just  `rgb`  .)

**What is HSL notation?** A color in HSL notation is made of the following three components:

 * _Hue_ ranges from 0 to 360 degrees. Each angle on the color wheel (which looks more like a hexagon than like a circle in HSL) stands for a different hue: red, yellow, green, cyan (sky-blue), blue, and magenta correspond roughly to hue 0 (say, 12 o’clock), 60, 120, 180, 240, and 300, respectively.

 * "Saturation" and "lightness" range from 0% to 100%. "Saturation" is the distance of the color from gray (0% means gray; 100% means most distant from gray). "Lightness" is roughly the amount of black or white mixed with the color (0% means black; 100% means white; closer to 0 means closer to black; closer to 1 means clmagenta correspond roughly to hue 0 (say, 12 o’clock), 60, 120, 180, 240, and 300, respectively.

**Example:** The value  `hsl(240, 100%, 50%)`  has a hue of 240 (blue), a "saturation" of 100% (fully saturated), and a "lightness" of 50% (neither black or white). It represents a vivid blue. If we lower "lightness" to 20%, we get a "darker" blue. If we also change the hue to 0, we get a "dark" red.

An alternate syntax for HSL colors supports the alpha component (see next question): in the example  `hsla(240, 100%,
            50%, 80%)`  , the  `80%`  is the alpha component.

**What is an alpha component?** An alpha component shows how much the color is transparent (see-through) or opaque. The alpha component can range from  `00`  /  `0.0`  , or "fully transparent" (completely invisible), to  `FF`  /  `1.0`  , or "fully opaque" (letting nothing through it). If a color notation doesn't provide for an alpha component, the color is fully opaque.

 .

<b>Return Value:</b>

An array containing four elements, with the red, green, blue, and alpha components of the same color, each from 0 to 255. Returns null if  <i>x</i>
 is null, empty, or has invalid syntax.

<a id="HlsToRgb_double_double_double"></a>
### HlsToRgb

    public static double[] HlsToRgb(
        double hueval,
        double lum,
        double sat);

Converts a color in the HLS color space to red/green/blue. Hue can range from 0 to 360, and lightness and saturation can range from 0 to 255. If lightness and saturation are out of range, those values are clamped to fit that range.

<b>Parameters:</b>

 * <i>hueval</i>: The parameter  <i>hueval</i>
 is a 64-bit floating-point number.

 * <i>lum</i>: The parameter  <i>lum</i>
 is a 64-bit floating-point number.

 * <i>sat</i>: The parameter  <i>sat</i>
 is a 64-bit floating-point number.

<b>Return Value:</b>

An array containing three elements, with the red, green, and blue components of the same color, each from 0 to 255.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter "hls" is null.

<a id="RgbToColor_double"></a>
### RgbToColor

    public static string RgbToColor(
        double[] arrayRGB);

Converts an RGBA color to a string, either rgb(...) or rgba(...) as applicable.

<b>Parameters:</b>

 * <i>arrayRGB</i>: A 3- or 4-item array containing the intensity of red, green, and blue (each from 0-255), with optional alpha (0-255).

<b>Return Value:</b>

A text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>arrayRGB</i>
 is null.

<a id="RgbToColorDisplay_double"></a>
### RgbToColorDisplay

    public static string RgbToColorDisplay(
        double[] rgb);

Converts a red&ndash;green&ndash;blue-alpha color to a string in CSS format.

<b>Parameters:</b>

 * <i>rgb</i>: An array containing three or four elements, with the red, green, blue, and alpha components of the color, each from 0 to 255. Each element's value is adjusted to 0 if it's less than 0 and to 255 if it's greater than 255 (the array itself is not modified, though).

<b>Return Value:</b>

A string in HTML color format: "#RRGGBB", if there are three elements or the fourth value in the array is 255, or a string in the RGBA color format otherwise.

<b>Exceptions:</b>

 * System.ArgumentException:
The parameter  <i>rgb</i>
 is null or contains fewer than three elements.

 * System.ArgumentNullException:
The parameter  <i>rgb</i>
 is null.

<a id="RgbToColorHtml_double"></a>
### RgbToColorHtml

    public static string RgbToColorHtml(
        double[] rgb);

Converts an RGBA color to an HTML color, (ex. #002233)."rgb" must contain at least 3 elements: the red, green, and blue (each 0-255).

<b>Parameters:</b>

 * <i>rgb</i>: A double[] object.

<b>Return Value:</b>

A text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>rgb</i>
 is null.
