## PeterO.ColorValidator

    public static class ColorValidator

Contains utility methods for processing Uniform Resource Identifiers (URIs) and Internationalized Resource Identifiers (IRIs) under RFC3986 and RFC3987, respectively. In the following documentation, URIs and IRIs include URI references and IRI references, for convenience. There are five components to a URI: scheme, authority, path, query, and fragment identifier. The generic syntax to these components is defined in RFC3986 and extended in RFC3987. According to RFC3986, different URI schemes can further restrict the syntax of the authority, path, and query component (see also RFC 7320). However, the syntax of fragment identifiers depends on the media type (also known as MIME type) of the resource a URI references (see also RFC 3986 and RFC 7320). As of September 3, 2019, only the following media types specify a syntax for fragment identifiers:

 * The following application/* media types: epub + zip, pdf, senml + cbor, senml + json, senml-exi, sensml + cbor, sensml + json, sensml-exi, smil, vnd.3gpp-v2x-local-service-information, vnd.3gpp.mcdata-signalling, vnd.collection.doc + json, vnd.hc + json, vnd.hyper + json, vnd.hyper-item + json, vnd.mason + json, vnd.microsoft.portable-executable, vnd.oma.bcast.sgdu, vnd.shootproof + json

 * The following image/* media types: avci, avcs, heic, heic-sequence, heif, heif-sequence, hej2k, hsj2, jxra, jxrs, jxsi, jxss

 * The XML media types: application/xml, application/xml-external-parsed-entity, text/xml, text/xml-external-parsed-entity, application/xml-dtd

 * All media types with subtypes ending in "+xml" (see RFC 7303) use XPointer Framework syntax as fragment identifiers, except the following application/* media types: dicom + xml (syntax not defined), senml + xml (own syntax), sensml + xml (own syntax), ttml + xml (own syntax), xliff + xml (own syntax), yang-data + xml (syntax not defined)

 * font/collection

 * multipart/x-mixed-replace

 * text/plain

 * text/csv

 * text/html

 * text/markdown

 * text/vnd.a

### Member Summary
* <code>[ColorToRgba(string)](#ColorToRgba_string)</code> - Converts an HTML or CSS color string to a 4-element RGB array.
* <code>[HlsToRgb(double, double, double)](#HlsToRgb_double_double_double)</code> - Converts a color in the HLS color space to red/green/blue.
* <code>[RgbToColor(double[])](#RgbToColor_double)</code> - Converts an RGBA color to a string, either rgb(.
* <code>[RgbToColorDisplay(double[])](#RgbToColorDisplay_double)</code> - Converts a red-green-blue-alpha color to a string in CSS format.
* <code>[RgbToColorHtml(double[])](#RgbToColorHtml_double)</code> - Converts an RGBA color to an HTML color, (ex.

<a id="ColorToRgba_string"></a>
### ColorToRgba

    public static double[] ColorToRgba(
        string x);

Converts an HTML or CSS color string to a 4-element RGB array.

<b>Parameters:</b>

 * <i>x</i>: A string which names a color. The following lists the kinds of colors accepted:

 * HTML colors with the syntax  `#RRGGBB` , where RR is the hexadecimal form of the red component (00-FF), GG is the hexadecimal green component, and BB is the hexadecimal blue component. Example: #88DFE0.

 * HTML colors with the syntax  `#RGB` , where R is the hexadecimal form of the red component (0-F), G is the hexadecimal green component, and B is the hexadecimal blue component. Example: #8DE.

 * CSS colors with the syntax  `rgb(red, green, blue)`  or  `rgba(red, green, blue, alpha)`  where  `red` ,  `green` , and  `blue`  are the red, green, and blue components, respectively, either as a number (0-255) or as a percent, and  `alpha`  is a number from 0-1 specifying the alpha component. Examples:  `rgb(255, 0, 0)` ,  `rgb(100%, 50%,
            0%)` ,  `rgba(20, 255, 255, 0.5)` .

 * CSS colors with the syntax  `hsl(hue, sat, light)`  or  `hsla(hue, sat, light, alpha)`  where  `hue`  is the hue component in degrees (0-360),  `sat`  and  `light`  are the saturation and lightness components, respectively, as percents, and  `alpha`  is a number from 0-1 specifying the alpha component. Examples:  `rgb(255, 0, 0)` ,  `hsl(200, 50%, 50%)` ,  `hsla(20, 80%, 90%, 0.5)` .

 * CSS colors such as  `red` ,  `green` ,  `white` ,  `lemonchiffon` ,  `chocolate` , and so on, including the newly added  `rebeccapurple` .

 * The value  `transparent` , meaning transparent black.

For more information: https://peteroupc.github.io/html3dutil/tutorial-colors.html.

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

Converts a red-green-blue-alpha color to a string in CSS format.

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
