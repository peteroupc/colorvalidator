# com.upokecenter.util.ColorValidator

    public final class ColorValidator extends Object

Contains methods to convert between different representations of HTML and
 CSS colors.

## Methods

* `static double[] ColorHtmlToRgba(String x)`<br>
 Converts HTML colors to Red/Green/Blue colors.
* `static double[] ColorToRgb(String x)`<br>
 Converts HTML colors to Red/Green/Blue colors.
* `static double[] ColorToRgba(String x)`<br>
 Not documented yet.
* `static double[] HlsToRgb(double[] hls)`<br>
 Converts a color in the HLS color space to red/green/blue.
* `static String RgbToColor(double[] arrayRGB)`<br>
 Converts an RGBA color to a string, either rgb(...) or rgba(...) as
 applicable.
* `static String RgbToColorDisplay(double[] rgb)`<br>
 Converts a red-green-blue-alpha color to a string in CSS format.
* `static String RgbToColorHtml(double[] rgb)`<br>
 Converts an RGBA color to an HTML color, (ex.
* `static String RgbToColorHtml(double r,
              double g,
              double b)`<br>
 Converts a red-green-blue color to a string in HTML format.

## Method Details

### HlsToRgb
    public static double[] HlsToRgb(double[] hls)
Converts a color in the HLS color space to red/green/blue.

**Parameters:**

* <code>hls</code> - Another double[] object.

**Returns:**

* A double[] object.

**Throws:**

* <code>NullPointerException</code> - The parameter <code>hls</code> is null.

### ColorHtmlToRgba
    public static double[] ColorHtmlToRgba(String x)
Converts HTML colors to Red/Green/Blue colors.

**Parameters:**

* <code>x</code> - A string object.

**Returns:**

* A double[] object.

**Throws:**

* <code>NullPointerException</code> - The parameter <code>x</code> is null.

### ColorToRgba
    public static double[] ColorToRgba(String x)
Not documented yet.

**Parameters:**

* <code>x</code> - A string object.

**Returns:**

* Not documented yet.

### ColorToRgb
    public static double[] ColorToRgb(String x)
Converts HTML colors to Red/Green/Blue colors. Use this function to parse
 colors from normal color picker controls:
 http://peteroupc.github.com/colorpicker/.

**Parameters:**

* <code>x</code> - A string object.

**Returns:**

* A double[] object.

### RgbToColor
    public static String RgbToColor(double[] arrayRGB)
Converts an RGBA color to a string, either rgb(...) or rgba(...) as
 applicable.

**Parameters:**

* <code>arrayRGB</code> - A double[] object.

**Returns:**

* A string object.

**Throws:**

* <code>NullPointerException</code> - The parameter <code>arrayRGB</code> is null.

### RgbToColorDisplay
    public static String RgbToColorDisplay(double[] rgb)
Converts a red-green-blue-alpha color to a string in CSS format.

**Parameters:**

* <code>rgb</code> - A double[] object.

**Returns:**

* A string object.

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

### RgbToColorHtml
    public static String RgbToColorHtml(double r, double g, double b)
Converts a red-green-blue color to a string in HTML format.

**Parameters:**

* <code>r</code> - A 64-bit floating-point number.

* <code>g</code> - Another 64-bit floating-point number.

* <code>b</code> - A 64-bit floating-point number. (3).

**Returns:**

* A string object.
