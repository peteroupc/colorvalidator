## PeterO.ColorValidator

    public static class ColorValidator

Contains methods to convert between different representations of HTML and CSS colors.

### ColorHtmlToRgba

    public static double[] ColorHtmlToRgba(
        string x);

Converts HTML colors to Red/Green/Blue colors.

<b>Parameters:</b>

 * <i>x</i>: A string in the form of an HTML color or CSS color name (ex. #223344, #234, or royalblue).All strings are treated as valid.Returns a 4-element array containing the red, green, blue, and alpha(each 0-255); the alpha is always 255..

<b>Return Value:</b>

An array of four elements, each from 0 to 255: the red, green, blue, and alpha components, in that order.

<b>Exceptions:</b>

 * System.ArgumentNullException: 
The parameter  <i>x</i>
is null.

### ColorToRgb

    public static double[] ColorToRgb(
        string x);

Converts HTML colors to Red/Green/Blue colors. Use this function to parse colors from normal color picker controls: http://peteroupc.github.com/colorpicker/.

<b>Parameters:</b>

 * <i>x</i>: A string object.

<b>Return Value:</b>

A double[] object.

### ColorToRgba

    public static double[] ColorToRgba(
        string x);

Not documented yet.

<b>Parameters:</b>

 * <i>x</i>: Not documented yet.

<b>Return Value:</b>

Not documented yet.

### HlsToRgb

    public static double[] HlsToRgb(
        double[] hls);

Converts a color in the HLS color space to red/green/blue.

<b>Parameters:</b>

 * <i>hls</i>: An array containing three elements: The first is the hue, in degrees, ranging from 0 through 360; the second is the luminosity (luminance or lightness), ranging from 0 to 255; and the third is the saturation, ranging from 0 to 255.

<b>Return Value:</b>

An array of three elements, each from 0 to 255: the red, green, and blue components, in that order.

<b>Exceptions:</b>

 * System.ArgumentNullException: 
The parameter  <i>hls</i>
 is null.

### RgbToColor

    public static string RgbToColor(
        double[] arrayRGB);

Converts an RGBA color to a string, either rgb(...) or rgba(...) as applicable.

<b>Parameters:</b>

 * <i>arrayRGB</i>: A double[] object.

<b>Return Value:</b>

A string object.

<b>Exceptions:</b>

 * System.ArgumentNullException: 
The parameter  <i>arrayRGB</i>
 is null.

### RgbToColorDisplay

    public static string RgbToColorDisplay(
        double[] rgb);

Converts a red-green-blue-alpha color to a string in CSS format.

<b>Parameters:</b>

 * <i>rgb</i>: A double[] object.

<b>Return Value:</b>

A string object.

<b>Exceptions:</b>

 * System.ArgumentException: 
The parameter  <i>rgb</i>
 is null or contains fewer than three elements.

 * System.ArgumentNullException: 
The parameter  <i>rgb</i>
is null.

### RgbToColorHtml

    public static string RgbToColorHtml(
        double r,
        double g,
        double b);

Converts a red-green-blue color to a string in HTML format.

<b>Parameters:</b>

 * <i>r</i>: A 64-bit floating-point number.

 * <i>g</i>: Another 64-bit floating-point number.

 * <i>b</i>: A 64-bit floating-point number. (3).

<b>Return Value:</b>

A string object.

### RgbToColorHtml

    public static string RgbToColorHtml(
        double[] rgb);

Converts an RGBA color to an HTML color, (ex. #002233)."rgb" must contain at least 3 elements: the red, green, and blue (each 0-255).

<b>Parameters:</b>

 * <i>rgb</i>: A double[] object.

<b>Return Value:</b>

A string object.

<b>Exceptions:</b>

 * System.ArgumentNullException: 
The parameter  <i>rgb</i>
is null.


