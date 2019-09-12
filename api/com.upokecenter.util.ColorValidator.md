# com.upokecenter.util.ColorValidator

    public final class ColorValidator extends java.lang.Object

Contains utility methods for processing Uniform Resource Identifiers (URIs)
 and Internationalized Resource Identifiers (IRIs) under RFC3986 and
 RFC3987, respectively. In the following documentation, URIs and IRIs
 include URI references and IRI references, for convenience. <p>There
 are five components to a URI: scheme, authority, path, query, and
 fragment identifier. The generic syntax to these components is
 defined in RFC3986 and extended in RFC3987. According to RFC3986,
 different URI schemes can further restrict the syntax of the
 authority, path, and query component (see also RFC 7320). However,
 the syntax of fragment identifiers depends on the media type (also
 known as MIME type) of the resource a URI references (see also RFC
 3986 and RFC 7320). As of September 3, 2019, only the following
 media types specify a syntax for fragment identifiers:</p> <ul>
 <li>The following application/* media types: epub + zip, pdf, senml
 + cbor, senml + json, senml-exi, sensml + cbor, sensml + json,
 sensml-exi, smil, vnd.3gpp-v2x-local-service-information,
 vnd.3gpp.mcdata-signalling, vnd.collection.doc + json, vnd.hc +
 json, vnd.hyper + json, vnd.hyper-item + json, vnd.mason + json,
 vnd.microsoft.portable-executable, vnd.oma.bcast.sgdu,
 vnd.shootproof + json</li> <li>The following image/* media types:
 avci, avcs, heic, heic-sequence, heif, heif-sequence, hej2k, hsj2,
 jxra, jxrs, jxsi, jxss</li> <li>The XML media types:
 application/xml, application/xml-external-parsed-entity, text/xml,
 text/xml-external-parsed-entity, application/xml-dtd</li> <li>All
  media types with subtypes ending in "+xml" (see RFC 7303) use
 XPointer Framework syntax as fragment identifiers, except the
 following application/* media types: dicom + xml (syntax not
 defined), senml + xml (own syntax), sensml + xml (own syntax), ttml
 + xml (own syntax), xliff + xml (own syntax), yang-data + xml
 (syntax not defined)</li> <li>font/collection</li>
 <li>multipart/x-mixed-replace</li> <li>text/plain</li>
 <li>text/csv</li> <li>text/html</li> <li>text/markdown</li>
 <li>text/vnd.a</li></ul>

## Methods

* `static double[] ColorToRgba​(java.lang.String x)`<br>
 Converts an HTML or CSS color string to a 4-element RGB array.
* `static double[] HlsToRgb​(double hueval,
        double lum,
        double sat)`<br>
 Converts a color in the HLS color space to red/green/blue.
* `static java.lang.String RgbToColor​(double[] arrayRGB)`<br>
 Converts an RGBA color to a string, either rgb(...) or rgba(...) as
 applicable.
* `static java.lang.String RgbToColorDisplay​(double[] rgb)`<br>
 Converts a red-green-blue-alpha color to a string in CSS format.
* `static java.lang.String RgbToColorHtml​(double[] rgb)`<br>
 Converts an RGBA color to an HTML color, (ex.

## Method Details

### HlsToRgb
    public static double[] HlsToRgb​(double hueval, double lum, double sat)
Converts a color in the HLS color space to red/green/blue. Hue can range
 from 0 to 360, and lightness and saturation can range from 0 to 255.
 If lightness and saturation are out of range, those values are
 clamped to fit that range.

**Parameters:**

* <code>hueval</code> - The parameter <code>hueval</code> is a 64-bit floating-point
 number.

* <code>lum</code> - The parameter <code>lum</code> is a 64-bit floating-point number.

* <code>sat</code> - The parameter <code>sat</code> is a 64-bit floating-point number.

**Returns:**

* An array containing three elements, with the red, green, and blue
 components of the same color, each from 0 to 255.

**Throws:**

* <code>java.lang.NullPointerException</code> - The parameter "hls" is null.

### ColorToRgba
    public static double[] ColorToRgba​(java.lang.String x)
Converts an HTML or CSS color string to a 4-element RGB array.

**Parameters:**

* <code>x</code> - A string which names a color. The following lists the kinds of
 colors accepted: <ul> <li>HTML colors with the syntax <code>
 #RRGGBB</code>, where RR is the hexadecimal form of the red component
 (00-FF), GG is the hexadecimal green component, and BB is the
 hexadecimal blue component. Example: #88DFE0.</li> <li>HTML colors
 with the syntax <code>#RGB</code>, where R is the hexadecimal form of the
 red component (0-F), G is the hexadecimal green component, and B is
 the hexadecimal blue component. Example: #8DE.</li> <li>CSS colors
 with the syntax <code>rgb(red, green, blue)</code> or <code>rgba(red,
 green, blue, alpha)</code> where <code>red</code>, <code>green</code>, and <code>
 blue</code> are the red, green, and blue components, respectively, either
 as a number (0-255) or as a percent, and <code>alpha</code> is a number
 from 0-1 specifying the alpha component. Examples: <code>rgb(255,
 0, 0)</code>, <code>rgb(100%, 50%, 0%)</code>, <code>rgba(20, 255, 255,
 0.5)</code>.</li> <li>CSS colors with the syntax <code>hsl(hue, sat,
 light)</code> or <code>hsla(hue, sat, light, alpha)</code> where <code>hue</code> is
 the hue component in degrees (0-360), <code>sat</code> and <code>light</code>
 are the saturation and lightness components, respectively, as
 percents, and <code>alpha</code> is a number from 0-1 specifying the
 alpha component. Examples: <code>rgb(255, 0, 0)</code>, <code>hsl(200,
 50%, 50%)</code>, <code>hsla(20, 80%, 90%, 0.5)</code>.</li> <li>CSS colors
 such as <code>red</code>, <code>green</code>, <code>white</code>, <code>
 lemonchiffon</code>, <code>chocolate</code>, and so on, including the newly
 added <code>rebeccapurple</code>.</li> <li>The value <code>transparent</code>,
 meaning transparent black.</li></ul> <p>For more information:
 https://peteroupc.github.io/html3dutil/tutorial-colors.html</p> .

**Returns:**

* An array containing four elements, with the red, green, blue, and
 alpha components of the same color, each from 0 to 255. Returns null
 if <code>x</code> is null, empty, or has invalid syntax.

### RgbToColor
    public static java.lang.String RgbToColor​(double[] arrayRGB)
Converts an RGBA color to a string, either rgb(...) or rgba(...) as
 applicable.

**Parameters:**

* <code>arrayRGB</code> - A 3- or 4-item array containing the intensity of red, green,
 and blue (each from 0-255), with optional alpha (0-255).

**Returns:**

* A text string.

**Throws:**

* <code>java.lang.NullPointerException</code> - The parameter <code>arrayRGB</code> is null.

### RgbToColorDisplay
    public static java.lang.String RgbToColorDisplay​(double[] rgb)
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

* <code>java.lang.IllegalArgumentException</code> - The parameter <code>rgb</code> is null or contains
 fewer than three elements.

* <code>java.lang.NullPointerException</code> - The parameter <code>rgb</code> is null.

### RgbToColorHtml
    public static java.lang.String RgbToColorHtml​(double[] rgb)
Converts an RGBA color to an HTML color, (ex. #002233)."rgb" must
 contain at least 3 elements: the red, green, and blue (each 0-255).

**Parameters:**

* <code>rgb</code> - A double[] object.

**Returns:**

* A text string.

**Throws:**

* <code>java.lang.NullPointerException</code> - The parameter <code>rgb</code> is null.
