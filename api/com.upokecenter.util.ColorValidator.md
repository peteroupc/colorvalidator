# com.upokecenter.util.ColorValidator

    public final class ColorValidator extends Object

Color validator.

## Methods

* `static double[] ColorToRgba(String x)`<br>
 Converts an HTML or CSS color string to a 4-element RGB array.

* `static double[] HlsToRgb(double hueval,
 double lum,
 double sat)`<br>
 Converts a color in the HLS color space to red/green/blue.

* `static String RgbToColor(double[] arrayRGB)`<br>
 Converts an RGBA color to a string, either rgb(...) or rgba(...) as
 applicable.

* `static String RgbToColorDisplay(double[] rgb)`<br>
 Converts a red–green–blue-alpha color to a string in CSS format.

* `static String RgbToColorHtml(double[] rgb)`<br>
 Converts an RGBA color to an HTML color, (ex.

## Method Details

### HlsToRgb
    public static double[] HlsToRgb(double hueval, double lum, double sat)
Converts a color in the HLS color space to red/green/blue. Hue can range
 from 0 to 360, and lightness and saturation can range from 0 to 255. If
 lightness and saturation are out of range, those values are clamped to fit
 that range.

**Parameters:**

* <code>hueval</code> - The parameter <code>hueval</code> is a 64-bit floating-point
 number.

* <code>lum</code> - The parameter <code>lum</code> is a 64-bit floating-point number.

* <code>sat</code> - The parameter <code>sat</code> is a 64-bit floating-point number.

**Returns:**

* An array containing three elements, with the red, green, and blue
 components of the same color, each from 0 to 255.

**Throws:**

* <code>NullPointerException</code> - The parameter "hls" is null.

### ColorToRgba
    public static double[] ColorToRgba(String x)
Converts an HTML or CSS color string to a 4-element RGB array.

**Parameters:**

* <code>x</code> - <p>A string which names a color. The letters in the string can be
 in any combination of basic upper-case letters A to Z (U+0041 to U+005A) and
 basic lower-case letters. The string can begin with any combination of white
 space characters (U+0009, U+000A, U+000C, U+000D, U+0020), can end with any
 combination of those characters, or both.</p> <p>**What colors can I use?**
 You can use values like the following as color strings.</p> <ul><li>CSS
 color names (from the CSS3 Color Module): <code>red</code> , <code>blue</code> ,
 <code>silver</code> , <code>fuchsia</code> , <code>darkslateblue</code> .</li><li>HTML “hex
 colors”: <code>#223344</code> , <code>#234</code> , <code>#234F</code> , or <code>
 #223344FF</code> . (See _What is the syntax for HTML colors?_)</li><li>RGB
 notation: <code>rgb(20, 30, 40)</code> or <code>rgba(20, 30, 40, 50%)</code> . (See
 _What is RGB notation?_, later.)</li><li>HSL notation: <code>hsl(200, 100%,
 50%)</code> or <code>hsla(200, 100%, 50%, 80%</code> . (See _What is HSL notation?_,
 later.)</li><li>The newly-added color name <code>rebeccapurple</code>
 .</li><li>The word <code>transparent</code> , meaning a fully-transparent
 color.</li></ul> <p>**What do some colors look like?** Consult a.get(list of
 useful colors sorted by hue or color
 tone)(https://peteroupc.github.io/html3dutil/websafe.svg). This particular
 list was historically called the "Web safe" colors or the "safety palette",
 and consists of 216 colors that are uniformly spaced in the red–green–blue
 color cube. Robert Hess's article "[The Safety
   Palette](https://learn.microsoft.com/en-us/previous-versions/ms976419(v=msdn.10))",
 1996, described the advantage that images that use only colors in this
 palette won't dither when displayed by Web browsers on displays that can
 show up to 256 colors at once. (See also
 [**Wikipedia**](http://en.wikipedia.org/wiki/Web_colors). Dithering is the
 scattering of colors in a limited set to simulate colors outside that set.)
 Each entry in the list consists of a color swatch and the corresponding HTML
 name (see next question).</p> <p>A.get(second
 list)(https://peteroupc.github.io/html3dutil/colornames.svg) shows the
 colors defined in the.get(**CSS3 Color Module section
 4**)(http://www.w3.org/TR/css3-color/#colorunits), as well as the
 newly-added name <code>rebeccapurple</code> . Where <code>gray</code> is part of a
 name, it can be replaced with <code>grey</code> . Next to the name of each color
 in the list, the color's HTML notation is shown.</p> <p>**What is the syntax
 for HTML colors?** The notation employed in the "safety palette" in the
 preceding section is HTML's way to define colors. It’s also known as “hex
 colors”. Take <code>#ff80cc</code> as an example. The color defined is a
 carnation pink. There are four parts to this example:</p> <ul><li>The <code>
 #</code> identifies this code as a color.</li><li>The <code>ff</code> is two letters
 and/or digits that show the red component of the color. This is a so-called
 hexadecimal number, or base-16 number. Each digit of this number can range
 from 0-9 and from A-F, with 0 being the lowest digit, and F being the
 highest digit. The highest two-digit value is 00, and the lowest two-digit
 value is FF (256). (The digits A-F may appear in upper or lower
 case.)</li><li>The <code>80</code> is a base-16 number showing the color’s green
 component.</li><li>The <code>cc</code> is a base-16 number showing the color’s
 blue component.</li></ul> <p>The notation may also include an additional
 base-16 number, as in this example: <code>#ac80ccff</code> . Here, the last
 <code>ff</code> shows the color's alpha component (see _What is an alpha
 component?_, later). Two shortened notations are supported: colors with only
 three or four base-16 digits are the same as their expanded six-digit or
 eight-digit form, respectively. For example, <code>#f8c</code> is the same as
 <code>#ff88cc</code> ; and <code>#f8ce</code> , <code>#ff88ccee</code> .</p> <p>**How do I
 make HTML colors?** Look at the table below that shows some of the values
 possible for the red, green, and blue components of some colors.</p> <pre>
 Red.. 00 10 20 30 40 50 60 70 80 90 A0 B0 C0 D0 E0 F0 FF Green 00 10 20 30
 40 50 60 70 80 90 A0 B0 C0 D0 E0 F0 FF Blue. 00 10 20 30 40 50 60 70 80 90
 A0 B0 C0 D0 E0 F0 FF</pre> <p>Now, to make a custom color, you choose one
 value from the red row, one value from the green row, and one value from the
 blue row. Each value shows the intensity of the "light" that the color
 ideally reflects. For example, a red value of 00 means that, ideally, "red
 light" is not reflected, and a red value of FF, fully reflected.</p> <p>If
 you choose the same value in all three rows, the result is black (if you
 choose 00), white (if you choose FF) or a shade of gray. This shows that
 "red light", "green light", and "blue light" are ideally equally
 reflected.</p> <p>After you choose the three values, combine them by writing
 the <code>#</code> , then the red value, then the green value, then the blue
 value. For example, if you choose <code>FF</code> for red, <code>A0</code> for green,
 and <code>00</code> for blue, write the resulting color (orange) like this:
 <code>#FFA000</code> .</p> <p>**How do I "darken" an HTML color?** To darken a
 color (make a * shade* of it), consult the table shown in the question _How
 do I make HTML colors?_, above, and move each component (red, green, and
 blue) the same number of steps to the left. If you can’t move a component
 that far to the left, that component becomes 00. For example, to make a
 "darker" sky blue, start with 00, FF, and FF for red, green, and blue. When
 we move these components ten steps to the left, we get 00, 60, and 60. The
 final color becomes #006060.</p> <p>**How do I "lighten" an HTML color?**
 "Lightening" a color (making a *tint* of it) is almost the same as
 "darkening" a color, except we move the same number of steps to the right
 rather than the left. If you can’t move a component that far to the right,
 that component becomes FF. For example, to make a "lighter" red, start with
 FF, 00, and 00 for red, green, and blue. When we move these components ten
 steps to the right, we get FF, A0, and A0. The final color becomes
 #FFA0A0.</p> <p>**How do I "desaturate" an HTML color?** To make a
 "desaturated" ("washed-out") version (or *tone*) of a color, move the color
 components closer to each other, in about the same proportion. (If they’re
 exactly the same, the result is a shade of gray.) For example, to make a
 "washed-out" red, start with FF, 00, and 00 for red, green, and blue. When
 we move these components closer to each other, we get C0, 40, and 40. The
 final color becomes #C04040.</p> <p>**What is RGB notation?** A color in RGB
 notation contains the same information as an HTML color, except that each
 value is shown in the familiar base-10 format. For example, the value <code>
 rgb(192, 64, 0)</code> is the same as the HTML color value <code>#C04000</code> .</p>
 <p>The components of the RGB color (red, green, and blue, in that order) can
 range from <code>0</code> to <code>255</code> , or from <code>0%</code> to <code>100%</code> ,
 but mixing ranges is not allowed. For example, <code>rgb(192, 64, 0)</code> and
 <code>rgb(80%, 50%, 0%)</code> are allowed, but not <code>rgb(192, 50%, 0%)</code> .
 The steps for "darkening", "lightening", and "desaturating" RGB colors are
 pretty much the same as with HTML colors. Another syntax for RGB colors
 supports the alpha component (see _What is an alpha component?_, later): in
 the example <code>rgba(192, 64, 0, 0.5)</code> , the <code>0.5</code> is the alpha
 component. This component supports either range for RGB colors, either 0-255
 or percentages. (Note that the example starts with <code>rgba</code> , not just
 <code>rgb</code> .)</p> <p>**What is HSL notation?** A color in HSL notation is
 made of the following three components:</p> <ul><li>_Hue_ ranges from 0 to
 360 degrees. Each angle on the color wheel (which looks more like a hexagon
 than like a circle in HSL) stands for a different hue: red, yellow, green,
 cyan (sky-blue), blue, and magenta correspond roughly to hue 0 (say, 12
 o’clock), 60, 120, 180, 240, and 300, respectively.</li><li>"Saturation" and
 "lightness" range from 0% to 100%. "Saturation" is the distance of the color
 from gray (0% means gray; 100% means most distant from gray). "Lightness" is
 roughly the amount of black or white mixed with the color (0% means black;
 100% means white; closer to 0% means closer to black; closer to 100% means
 closer to white).</li></ul> <p>**Example:** The value <code>hsl(240, 100%,
 50%)</code> has a hue of 240 (blue), a "saturation" of 100% (fully saturated), and
 a "lightness" of 50% (as far from "black" as from "white"). It represents a
 vivid blue. If we lower "lightness" to 20%, we get a "darker" blue. If we
 also change the hue to 0, we get a "dark" red.</p> <p>An alternate syntax
 for HSL colors supports the alpha component (see next question): in the
 example <code>hsla(240, 100%, 50%, 80%)</code> , the <code>80%</code> is the alpha
 component.</p> <p>**What is an alpha component?** An alpha component shows
 how much the color is transparent (see-through) or opaque. The alpha
 component can range from <code>00</code> / <code>0.0</code> , or "fully transparent"
 (completely invisible), to <code>FF</code> / <code>1.0</code> , or "fully opaque"
 (letting nothing through it). If a color notation doesn't provide for an
 alpha component, the color is fully opaque.</p> .

**Returns:**

* An array containing four elements, with the red, green, blue, and
 alpha components of the same color, each from 0 to 255. Returns null if
 <code>x</code> is null, empty, or has invalid syntax.

### RgbToColor
    public static String RgbToColor(double[] arrayRGB)
Converts an RGBA color to a string, either rgb(...) or rgba(...) as
 applicable.

**Parameters:**

* <code>arrayRGB</code> - A 3- or 4-item array containing the intensity of red, green,
 and blue (each from 0-255), with optional alpha (0-255).

**Returns:**

* A text string.

**Throws:**

* <code>NullPointerException</code> - The parameter <code>arrayRGB</code> is null.

### RgbToColorDisplay
    public static String RgbToColorDisplay(double[] rgb)
Converts a red–green–blue-alpha color to a string in CSS format.

**Parameters:**

* <code>rgb</code> - An array containing three or four elements, with the red, green,
 blue, and alpha components of the color, each from 0 to 255. Each element's
 value is adjusted to 0 if it's less than 0 and to 255 if it's greater than
 255 (the array itself is not modified, though).

**Returns:**

* A string in HTML color format: "#RRGGBB", if there are three
 elements or the fourth value in the array is 255, or a string in the RGBA
 color format otherwise.

**Throws:**

* <code>IllegalArgumentException</code> - The parameter <code>rgb</code> is null or contains
 fewer than three elements.

* <code>NullPointerException</code> - The parameter <code>rgb</code> is null.

### RgbToColorHtml
    public static String RgbToColorHtml(double[] rgb)
Converts an RGBA color to an HTML color, (ex. #002233)."rgb" must contain at
 least 3 elements: the red, green, and blue (each 0-255).

**Parameters:**

* <code>rgb</code> - A double[] object.

**Returns:**

* A text string.

**Throws:**

* <code>NullPointerException</code> - The parameter <code>rgb</code> is null.
