# com.upokecenter.util.ColorValidator

    public final class ColorValidator extends Object

Contains methods to convert between different representations of HTML and
 CSS colors.

## Methods

* `static double[] ColorToRgba(String x)`<br>
 Converts an HTML or CSS color string to a 4-element RGB array.
* `static double[] HlsToRgb(double hueval,
        double lum,
        double sat)`<br>
 Converts a color in the HLS color space to red/green/blue.
* `static String RgbToColor(double[] arrayRGB)`<br>
 Converts an RGBA color to a string, either rgb(...) or rgba(...) as
 applicable.
* `static String RgbToColorDisplay(double[] rgb)`<br>
 Converts a red-green-blue-alpha color to a string in CSS format.
* `static String RgbToColorHtml(double[] rgb)`<br>
 Converts an RGBA color to an HTML color, (ex.

## Method Details

### HlsToRgb
    public static double[] HlsToRgb(double hueval, double lum, double sat)
Converts a color in the HLS color space to red/green/blue. Hue can range
 from 0 to 360, and lightness and saturation can range from 0 to 255.
 If lightness and saturation are out of range, those values are
 clamped to fit that range.

**Parameters:**

* <code>hueval</code> - Not documented yet.

* <code>lum</code> - Not documented yet.

* <code>sat</code> - Not documented yet. (3).

**Returns:**

* An array containing three elements, with the red, green, and blue
 components of the same color, each from 0 to 255.

**Throws:**

* <code>NullPointerException</code> - The parameter "hls" is null.

### ColorToRgba
    public static double[] ColorToRgba(String x)
Converts an HTML or CSS color string to a 4-element RGB array.

**Parameters:**

* <code>x</code> - A string which names a color. The following lists the kinds of
 colors accepted: <ul> <li>HTML colors with the syntax <code>#RRGGBB</code>, where RR is the hexadecimal form of the red component
 (00-FF), GG is the hexadecimal green component, and BB is the
 hexadecimal blue component. Example: #88DFE0.</li> <li>HTML colors
 with the syntax <code>#RGB</code>, where R is the hexadecimal form of the
 red component (0-F), G is the hexadecimal green component, and B is
 the hexadecimal blue component. Example: #8DE.</li> <li>CSS colors
 with the syntax <code>rgb(red, green, blue)</code> or <code>rgba(red,
 green, blue, alpha)</code> where <code>red</code>, <code>green</code>, and <code>blue</code> are the red, green, and blue components, respectively, either
 as a number (0-255) or as a percent, and <code>alpha</code> is a number
 from 0-1 specifying the alpha component. Examples: <code>rgb(255, 0,
 0)</code>, <code>rgb(100%, 50%, 0%)</code>, <code>rgba(20, 255, 255,
 0.5)</code>.</li> <li>CSS colors with the syntax <code>hsl(hue, sat,
 light)</code> or <code>hsla(hue, sat, light, alpha)</code> where <code>hue</code> is
 the hue component in degrees (0-360), <code>sat</code> and <code>light</code>
 are the saturation and lightness components, respectively, as
 percents, and <code>alpha</code> is a number from 0-1 specifying the alpha
 component. Examples: <code>rgb(255, 0, 0)</code>, <code>hsl(200, 50%,
 50%)</code>, <code>hsla(20, 80%, 90%, 0.5)</code>.</li> <li>CSS colors such as
 <code>red</code>, <code>green</code>, <code>white</code>, <code>lemonchiffon</code>,
 <code>chocolate</code>, and so on, including the newly added <code>rebeccapurple</code>.</li> <li>The value <code>transparent</code>, meaning
 transparent black.</li></ul> <p>For more information:
 [https://peteroupc.github.io/html3dutil/tutorial-colors.html</p>](https://peteroupc.github.io/html3dutil/tutorial-colors.html</p>) .

**Returns:**

* An array containing four elements, with the red, green, blue, and
 alpha components of the same color, each from 0 to 255. Returns null
 if <code>x</code> is null, empty, or has invalid syntax.

### RgbToColor
    public static String RgbToColor(double[] arrayRGB)
Converts an RGBA color to a string, either rgb(...) or rgba(...) as
 applicable.

**Parameters:**

* <code>arrayRGB</code> - A 3- or 4-item array containing the intensity of red, green,
 and blue (each from 0-255), with optional alpha (0-255).

**Returns:**

* A string object.

**Throws:**

* <code>NullPointerException</code> - The parameter <code>arrayRGB</code> is null.

### RgbToColorDisplay
    public static String RgbToColorDisplay(double[] rgb)
Converts a red-green-blue-alpha color to a string in CSS format.

**Parameters:**

* <code>rgb</code> - An array containing three or four elements, with the red, green,
 blue, and alpha components of the color, each from 0 to 255. Each
 element's value is adjusted to 0 if it's less than 0 and to 255 if
 it's greater than 255 (the array itself is not modified, though).

**Returns:**

* A string in HTML color format: "#RRGGBB", if there are three
 elements or the fourth value in the array is 255, or a string in the
 RGBA color format otherwise.

**Throws:**

* <code>IllegalArgumentException</code> - The parameter <code>rgb</code> is null or contains
 fewer than three elements.

* <code>NullPointerException</code> - The parameter <code>rgb</code> is null.

### RgbToColorHtml
    public static String RgbToColorHtml(double[] rgb)
Converts an RGBA color to an HTML color, (ex. #002233).&#x22;rgb&#x22; must
 contain at least 3 elements: the red, green, and blue (each 0-255).

**Parameters:**

* <code>rgb</code> - A double[] object.

**Returns:**

* A string object.

**Throws:**

* <code>NullPointerException</code> - The parameter <code>rgb</code> is null.
