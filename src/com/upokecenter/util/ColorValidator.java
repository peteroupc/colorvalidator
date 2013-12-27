package com.upokecenter.util;
/*
 * This file is in the public domain. Peter O., 2012. http://upokecenter.dreamhosters.com
    Public domain dedication: http://creativecommons.org/publicdomain/zero/1.0/
 This file converts between different representations of HTML and CSS colors.
 */

import java.util.*;

import java.util.regex.*;

    /**
     * Contains methods to convert between different representations
     * of HTML and CSS colors.
     * @param hls A double[] object.
     * @return A double[] object.
     */
    public final class ColorValidator {
private ColorValidator(){}
        public static double[] HlsToRgb(double[] hls) {
            if ((hls) == null) throw new NullPointerException("hls");
            if ((3) > hls.length) throw new IllegalArgumentException("3" + " not less or equal to " + Long.toString((long)(hls.length)) + " (" + "3" + ")");
            double hueval = hls[0] * 1.0;//[0-360)
            double lum = hls[1] * 1.0;//[0-255]
            double sat = hls[2] * 1.0;//[0-255]
            lum = (lum < 0 ? 0 : (lum > 255 ? 255 : lum));
            sat = (sat < 0 ? 0 : (sat > 255 ? 255 : sat));
            if (sat == 0)
            {
                return new double[] { lum, lum, lum };
            }
            double b = 0;
            if (lum <= 127.5)
            {
                b = (lum * (255.0 + sat)) / 255.0;
            }
            else
            {
                b = lum * sat;
                b = b / 255.0;
                b = lum + sat - b;
            }
            double a = (lum * 2) - b;
            double r, g, bl;
            if (hueval < 0 || hueval >= 360) hueval = (((hueval % 360) + 360) % 360);
            double hue = hueval + 120;
            if (hue >= 360) hue -= 360;
            if (hue < 60) r = (a + (b - a) * hue / 60);
            else if (hue < 180) r = b;
            else if (hue < 240) r = (a + (b - a) * (240 - hue) / 60);
            else r = a;
            hue = hueval;
            if (hue < 60) g = (a + (b - a) * hue / 60);
            else if (hue < 180) g = b;
            else if (hue < 240) g = (a + (b - a) * (240 - hue) / 60);
            else g = a;
            hue = hueval - 120;
            if (hue < 0) hue += 360;
            if (hue < 60) bl = (a + (b - a) * hue / 60);
            else if (hue < 180) bl = b;
            else if (hue < 240) bl = (a + (b - a) * (240 - hue) / 60);
            else bl = a;
            return new double[]{
                (r<0 ? 0 : (r>255 ? 255 : r)),
        (g<0 ? 0 : (g>255 ? 255 : g)),
        (bl<0 ? 0 : (bl>255 ? 255 : bl))};
        }
    /**
     * Converts HTML colors to Red/Green/Blue colors."color" is an HTML
     * color or color name (ex. #223344, #234, or royalblue).All strings
     * are treated as valid.Returns a 4-element array containing the red,
     * green, blue, and alpha(each 0-255); the alpha is always 255.
     * @param x A string object.
     * @return A double[] object.
     */
        public static double[] ColorHtmlToRgba(String x) {
            if ((x) == null) throw new NullPointerException("x");
            ColorToRgbaSetUpNamedColors();
            if (x == null || x.length() == 0) return new double[] { 0, 0, 0, 255 };
            x = x.toLowerCase(java.util.Locale.US);
            if (x.indexOf("grey") >= 0) x = x.replace("grey", "gray");// support "grey" variants
            if (ColorToRgbaNamedColors.containsKey(x))
            {
                String ret = ColorToRgbaNamedColors.get(x);
                if (ret != null) return ColorToRgba(ret);
            }
            int[] arr = new int[x.length()];
            for (int i = (x.charAt(0) == '#') ? 1 : 0; i < x.length(); i++)
            {
                int c = x.charAt(i);
                int hex = 0;
                if (c >= 0x30 && c <= 0x39) hex = c - 0x30;
                if (c >= 0x61 && c <= 0x66) hex = c - 0x61 + 10;
                arr[arr.length] = hex;
            }
            int sublength = ((arr.length + 2) / 3);
            while (arr.length < sublength * 3)
            {
                arr[arr.length] = 0;
            }
            int currlength = sublength;
            int offset = 0;
            while (currlength > 2)
            {
                if (arr[offset] == 0 && arr[sublength + offset] == 0 &&
                   arr[sublength * 2 + offset] == 0)
                {
                    currlength--; offset++;
                }
                else break;
            }
            return new double[]{
        arr[offset]*16+arr[offset+1],
        arr[sublength+offset]*16+arr[sublength+offset+1],
        arr[sublength*2+offset]*16+arr[sublength*2+offset+1],
        255
      };
        }
        private static Pattern[] patterns = new Pattern[]{
      Pattern.compile("^#([A-Fa-f0-9]{2})([A-Fa-f0-9]{2})([A-Fa-f0-9]{2})$"),
      Pattern.compile("^rgb\\(\\s*([\\+\\-]?\\d+(?:\\.\\d+)?%)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?%)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?%)\\s*\\)$"),
      Pattern.compile("^rgb\\(\\s*([\\+\\-]?\\d+)\\s*,\\s*([\\+\\-]?\\d+)\\s*,\\s*([\\+\\-]?\\d+)\\s*\\)$"),
      Pattern.compile("^rgba\\(\\s*([\\+\\-]?\\d+(?:\\.\\d+)?%)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?%)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?%)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)\\s*\\)$"),
      Pattern.compile("^rgba\\(\\s*([\\+\\-]?\\d+)\\s*,\\s*([\\+\\-]?\\d+)\\s*,\\s*([\\+\\-]?\\d+)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)\\s*\\)$"),
      Pattern.compile("^#([A-Fa-f0-9]{1})([A-Fa-f0-9]{1})([A-Fa-f0-9]{1})$"),
      Pattern.compile("^hsl\\(\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)%\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)%\\s*\\)$"),
      Pattern.compile("^hsla\\(\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)%\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)%\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)\\s*\\)$")
    };
        private static Matcher execPattern(Pattern p, String s) {
            Matcher m = p.matcher(s);
            return (m.matches()) ? m : null;
        }
        private static double parseHue(String value) {
            try
            {
                double c = Double.parseDouble(value);
                if (c < 0 || c >= 360) c = (((c % 360) + 360) % 360);
                return c;
            }
            catch(NumberFormatException ex)
            {
                return Double.NaN;
            }
            catch(ArithmeticException ex)
            {
                return Double.NaN;
            }
        }
        private static double parseByte(String value) {
            try
            {
                double c = Double.parseDouble(value);
                return (c < 0 ? 0 : (c > 255 ? 255 : c));
            }
            catch(NumberFormatException ex)
            {
                return Double.NaN;
            }
            catch(ArithmeticException ex)
            {
                return Double.NaN;
            }
        }
        private static double parseUnit(String value) {
            try
            {
                double c = Double.parseDouble(value);
                return (c < 0 ? 0 : (c > 1.0 ? 1.0 : c)) * 255.0;
            }
            catch(NumberFormatException ex)
            {
                return Double.NaN;
            }
            catch(ArithmeticException ex)
            {
                return Double.NaN;
            }
        }
        private static double parsePercent(String value) {
            try
            {
                double c = Double.parseDouble(value);
                return (c < 0 ? 0 : (c > 100 ? 100 : c)) * 255.0 / 100.0;
            }
            catch(NumberFormatException ex)
            {
                return Double.NaN;
            }
            catch(ArithmeticException ex)
            {
                return Double.NaN;
            }
        }
        private static int dehexchar(int c) {
            if (c >= '0' && c <= '9')
                return c - '0';
            if (c >= 'A' && c <= 'F')
                return c + 10 - 'A';
            if (c >= 'a' && c <= 'f')
                return c + 10 - 'a';
            return -1;
        }
        private static int GetHex(String str) {
            if ((str) == null) throw new NullPointerException("s");
            if (str.length() == 0) throw new IllegalArgumentException("s is empty");
            int h = dehexchar(str.charAt(0));
            if (h < 0) return 0;
            if (str.length() > 1)
            {
                h = h * 16 + dehexchar(str.charAt(1));
                if (h < 0) return 0;
            }
            if (str.length() > 2)
            {
                h = h * 16 + dehexchar(str.charAt(2));
                if (h < 0) return 0;
            }
            if (str.length() > 3)
            {
                h = h * 16 + dehexchar(str.charAt(3));
                if (h < 0) return 0;
            }
            return h;
        }
        public static double[] ColorToRgba(String x) {
            Matcher e = null;
            if (x == null) return new double[] { 0, 0, 0, 0 };
            if ((e = execPattern(patterns[0], x)) != null)
            {
                return new double[]{
          GetHex(e.group(1)),
          GetHex(e.group(2)),
          GetHex(e.group(3)),
          255
        };
            }
            else if ((e = execPattern(patterns[1], x)) != null)
            {
                double r1 = parsePercent(e.group(1));
                double r2 = parsePercent(e.group(2));
                double r3 = parsePercent(e.group(3));
                if (Double.isNaN(r1) || Double.isNaN(r2) || Double.isNaN(r3)) return null;
                return new double[] { r1, r2, r3, 255 };
            }
            else if ((e = execPattern(patterns[2], x)) != null)
            {
                double r1 = parseByte(e.group(1));
                double r2 = parseByte(e.group(2));
                double r3 = parseByte(e.group(3));
                if (Double.isNaN(r1) || Double.isNaN(r2) || Double.isNaN(r3)) return null;
                return new double[] { r1, r2, r3, 255 };
            }
            else if ((e = execPattern(patterns[3], x)) != null)
            {
                double r1 = parsePercent(e.group(1));
                double r2 = parsePercent(e.group(2));
                double r3 = parsePercent(e.group(3));
                double r4 = parseUnit(e.group(4));
                if (Double.isNaN(r1) || Double.isNaN(r2) || Double.isNaN(r3) || Double.isNaN(r4)) return null;
                return new double[] { r1, r2, r3, r4 };
            }
            else if ((e = execPattern(patterns[4], x)) != null)
            {
                double r1 = parseByte(e.group(1));
                double r2 = parseByte(e.group(2));
                double r3 = parseByte(e.group(3));
                double r4 = parseUnit(e.group(4));
                if (Double.isNaN(r1) || Double.isNaN(r2) || Double.isNaN(r3) || Double.isNaN(r4)) return null;
                return new double[] { r1, r2, r3, r4 };
            }
            else if ((e = execPattern(patterns[5], x)) != null)
            {
                int a = GetHex(e.group(1));
                int b = GetHex(e.group(2));
                int c = GetHex(e.group(3));
                return new double[] { a + (a << 4), b + (b << 4), c + (c << 4), 255 };
            }
            else if ((e = execPattern(patterns[6], x)) != null)
            { // hsl
                double r1 = parseHue(e.group(1));
                double r2 = parsePercent(e.group(3));
                double r3 = parsePercent(e.group(2));
                if (Double.isNaN(r1) || Double.isNaN(r2) || Double.isNaN(r3)) return null;
                double[] rgb = HlsToRgb(new double[] { r1, r2, r3 });
                return new double[] { rgb[0], rgb[1], rgb[2], 255 };
            }
            else if ((e = execPattern(patterns[7], x)) != null)
            { // hsla
                double r1 = parseHue(e.group(1));
                double r2 = parsePercent(e.group(3));
                double r3 = parsePercent(e.group(2));
                double r4 = parseUnit(e.group(4));
                if (Double.isNaN(r1) || Double.isNaN(r2) || Double.isNaN(r3) || Double.isNaN(r4)) return null;
                double[] rgb = HlsToRgb(new double[] { r1, r2, r3 });
                return new double[] { rgb[0], rgb[1], rgb[2], r4 };
            }
            else
            {
                x = x.toLowerCase(java.util.Locale.US);
                if (x.indexOf("grey") >= 0) x = x.replace("grey", "gray");// support "grey" variants
                if (ColorToRgbaNamedColors.containsKey(x))
                {
                    String ret = ColorToRgbaNamedColors.get(x);
                    if (ret != null) return ColorToRgba(ret);
                }
                if (x.equals("transparent")) return new double[] { 0, 0, 0, 0 };
                return new double[] { 0, 0, 0, 0 };
            }
        }
        private static HashMap<String, String> ColorToRgbaNamedColors = ColorToRgbaSetUpNamedColors();
        private static String[] nc = new String[]{
            "aliceblue", "f0f8ff", "antiquewhite", "faebd7", "aqua", "00ffff", "aquamarine", "7fffd4", "azure", "f0ffff", "beige", "f5f5dc",
          "bisque", "ffe4c4", "black", "000000", "blanchedalmond", "ffebcd", "blue", "0000ff", "blueviolet", "8a2be2", "brown",
          "a52a2a", "burlywood", "deb887", "cadetblue", "5f9ea0",
          "chartreuse", "7fff00", "chocolate", "d2691e", "coral", "ff7f50", "cornflowerblue", "6495ed", "cornsilk", "fff8dc", "crimson",
          "dc143c", "cyan", "00ffff", "darkblue", "00008b", "darkcyan", "008b8b", "darkgoldenrod", "b8860b", "darkgray", "a9a9a9",
          "darkgreen", "006400", "darkkhaki", "bdb76b", "darkmagenta",
          "8b008b", "darkolivegreen", "556b2f", "darkorange", "ff8c00", "darkorchid", "9932cc", "darkred", "8b0000", "darksalmon",
          "e9967a", "darkseagreen", "8fbc8f", "darkslateblue", "483d8b", "darkslategray", "2f4f4f", "darkturquoise", "00ced1",
          "darkviolet", "9400d3", "deeppink", "ff1493",
          "deepskyblue", "00bfff", "dimgray", "696969", "dodgerblue", "1e90ff", "firebrick", "b22222", "floralwhite", "fffaf0",
          "forestgreen", "228b22", "fuchsia", "ff00ff", "gainsboro", "dcdcdc",
          "ghostwhite", "f8f8ff", "gold", "ffd700", "goldenrod", "daa520", "gray", "808080", "green", "008000", "greenyellow", "adff2f",
          "honeydew", "f0fff0", "hotpink", "ff69b4", "indianred", "cd5c5c", "indigo", "4b0082", "ivory", "fffff0", "khaki", "f0e68c",
          "lavender", "e6e6fa", "lavenderblush", "fff0f5", "lawngreen",
          "7cfc00", "lemonchiffon", "fffacd", "lightblue", "add8e6", "lightcoral", "f08080", "lightcyan", "e0ffff", "lightgoldenrodyellow",
          "fafad2", "lightgray", "d3d3d3", "lightgreen",
          "90ee90", "lightpink", "ffb6c1", "lightsalmon", "ffa07a", "lightseagreen", "20b2aa", "lightskyblue", "87cefa", "lightslategray",
          "778899", "lightsteelblue", "b0c4de", "lightyellow", "ffffe0", "lime", "00ff00", "limegreen", "32cd32", "linen", "faf0e6", "magenta",
          "ff00ff", "maroon", "800000", "mediumaquamarine",
          "66cdaa", "mediumblue", "0000cd", "mediumorchid", "ba55d3", "mediumpurple", "9370d8", "mediumseagreen", "3cb371",
          "mediumslateblue", "7b68ee", "mediumspringgreen",
          "00fa9a", "mediumturquoise", "48d1cc", "mediumvioletred", "c71585", "midnightblue", "191970", "mintcream", "f5fffa", "mistyrose",
          "ffe4e1", "moccasin", "ffe4b5", "navajowhite", "ffdead", "navy", "000080", "oldlace", "fdf5e6", "olive", "808000", "olivedrab", "6b8e23",
          "orange", "ffa500", "orangered",
          "ff4500", "orchid", "da70d6", "palegoldenrod", "eee8aa", "palegreen", "98fb98", "paleturquoise", "afeeee", "palevioletred", "d87093",
          "papayawhip", "ffefd5", "peachpuff",
          "ffdab9", "peru", "cd853f", "pink", "ffc0cb", "plum", "dda0dd", "powderblue", "b0e0e6", "purple", "800080", "red", "ff0000",
          "rosybrown", "bc8f8f", "royalblue", "4169e1",
          "saddlebrown", "8b4513", "salmon", "fa8072", "sandybrown", "f4a460", "seagreen", "2e8b57", "seashell", "fff5ee", "sienna",
          "a0522d", "silver", "c0c0c0", "skyblue", "87ceeb", "slateblue", "6a5acd", "slategray", "708090", "snow", "fffafa", "springgreen",
          "00ff7f", "steelblue", "4682b4", "tan", "d2b48c", "teal",
          "008080", "thistle", "d8bfd8", "tomato", "ff6347", "turquoise", "40e0d0", "violet", "ee82ee", "wheat", "f5deb3", "white", "ffffff",
          "whitesmoke", "f5f5f5", "yellow", "ffff00", "yellowgreen", "9acd32"
        };
        private static HashMap<String, String> ColorToRgbaSetUpNamedColors() {
            HashMap<String, String> ColorToRgbaNamedColors = new HashMap<String, String>();
            for (int i = 0; i < nc.length; i += 2)
            {
                ColorToRgbaNamedColors.put(nc[i], "#" + nc[i + 1]);
            }
            return ColorToRgbaNamedColors;
        }
    /**
     * Converts HTML colors to Red/Green/Blue colors. Use this function
     * to parse colors from normal color picker controls: http://peteroupc.github.com/colorpicker/
     * @param x A CSS color, HTML color, or color name, but not including RGBA
     * or HSLA (ex. #223344 or #234 or royalblue or rgb(20,20,20) or hsl(100,100%,50%)).
     * @return Returns a 4-element array containing the red, green, blue,
     * and alpha(each 0-255); the alpha is always 255. Returns null if the
     * string is nota valid color.
     */
        public static double[] ColorToRgb(String x) {
            if (x == null) return null;
            // don't include rgba or hsla
            if (x.indexOf("rgba") == 0 || x.indexOf("hsla") == 0) return null;
            double[] rgba = ColorToRgba(x);
            if (rgba == null || rgba[3] == 0) return null; // transparent
            return new double[] { rgba[0], rgba[1], rgba[2], 255 };
        }
        private static String RoundedString(double r) {
            r = StrictMath.round(r);
            return Double.toString((double)r);
        }
    /**
     * Converts an RGBA color to a string, either rgb(...) or rgba(...) as
     * applicable.
     * @param arrayRGB a 3- or 4-item array containing the intensity of red,
     * green, and blue (each from 0-255), with optional alpha (0-255)
     * @return A string object.
     */
        public static String RgbToColor(double[] arrayRGB) {
            if ((arrayRGB) == null) throw new NullPointerException("arrayRGB");
            if ((3) > arrayRGB.length) throw new IllegalArgumentException("3" + " not less or equal to " + Long.toString((long)(arrayRGB.length)) + " (" + "3" + ")");
            // we should include the spaces
            if ((arrayRGB.length > 3 && (arrayRGB[3] == 255)) || arrayRGB.length == 3)
            {
                return "rgb(" + RoundedString(arrayRGB[0]) + ", " +
                    RoundedString(arrayRGB[1]) + ", " +
                    RoundedString(arrayRGB[2]) + ")";
            }
            else
            {
                double prec = StrictMath.round((arrayRGB[3] / 255.0) * 100.0) / 100.0;
                return "rgba(" + RoundedString(arrayRGB[0]) + ", " +
                    RoundedString(arrayRGB[1]) + ", " +
                    RoundedString(arrayRGB[2]) + ", " +
                    Double.toString((double)prec) + ")";
            }
        }
    /**
     * Converts a red-green-blue-alpha color to a string in CSS format.
     * @param rgb An array containing three or four elements, with the red,
     * green, blue, and alpha components of the color, each from 0 to 255.
     * Each element&apos;s value is adjusted to 0 if it&apos;s less than
     * 0 and to 255 if it&apos;s greater than 255 (the array itself is not modified,
     * though).
     * @return A string in HTML color format: &quot;#RRGGBB&quot;, if there
     * are three elements or the fourth value in the array is 255, or a string
     * in the RGBA color format otherwise.
     * @throws java.lang.IllegalArgumentException "rgb" is null or contains fewer
     * than three elements.
     */
        public static String RgbToColorDisplay(double[] rgb) {
            if ((rgb) == null) throw new NullPointerException("rgb");
            if ((3) > rgb.length) throw new IllegalArgumentException("3" + " not less or equal to " + Long.toString((long)(rgb.length)) + " (" + "3" + ")");
            if (rgb.length == 3 || (rgb.length > 3 && rgb[3] == 255))
            {
                return RgbToColorHtml(rgb);
            }
            else
            {
                return RgbToColor(rgb).replace(" ", "");
            }
        }
        private static String HexArray = "0123456789abcdef";
    /**
     * Converts an RGBA color to an HTML color, (ex. #002233)."rgb" must
     * contain at least 3 elements: the red, green, and blue (each 0-255).
     * @param rgb A double[] object.
     * @return A string object.
     */
        public static String RgbToColorHtml(double[] rgb) {
            if ((rgb) == null) throw new NullPointerException("rgb");
            if ((3) > rgb.length) throw new IllegalArgumentException("3" + " not less or equal to " + Long.toString((long)(rgb.length)) + " (" + "3" + ")");
            StringBuilder sb = new StringBuilder();
            int c;
            c = ((c = (int)StrictMath.round(rgb[0])) < 0 ? 0 : (c > 255 ? 255 : c));
            sb.append(HexArray.charAt((c >> 4) & 15));
            sb.append(HexArray.charAt((c) & 15));
            c = ((c = (int)StrictMath.round(rgb[1])) < 0 ? 0 : (c > 255 ? 255 : c));
            sb.append(HexArray.charAt((c >> 4) & 15));
            sb.append(HexArray.charAt((c) & 15));
            c = ((c = (int)StrictMath.round(rgb[2])) < 0 ? 0 : (c > 255 ? 255 : c));
            sb.append(HexArray.charAt((c >> 4) & 15));
            sb.append(HexArray.charAt((c) & 15));
            return sb.toString();
        }
    /**
     * Converts a red-green-blue color to a string in HTML format.
     * @param r The red component of the color, from 0 to 255. As with &quot;g&quot;
     * and &quot;b&quot;, this value is adjusted to 0 if it&apos;s less than
     * 0 and to 255 if it&apos;s greater than 255.
     * @param g The green component of the color, from 0 to 255.
     * @param b The blue component of the color, from 0 to 255.
     * @return A string in HTML color format: &quot;#RRGGBB&quot;.
     */
        public static String RgbToColorHtml(double r, double g, double b) {
            StringBuilder sb = new StringBuilder();
            int c;
            c = ((c = (int)StrictMath.round(r)) < 0 ? 0 : (c > 255 ? 255 : c));
            sb.append(HexArray.charAt((c >> 4) & 15));
            sb.append(HexArray.charAt((c) & 15));
            c = ((c = (int)StrictMath.round(g)) < 0 ? 0 : (c > 255 ? 255 : c));
            sb.append(HexArray.charAt((c >> 4) & 15));
            sb.append(HexArray.charAt((c) & 15));
            c = ((c = (int)StrictMath.round(b)) < 0 ? 0 : (c > 255 ? 255 : c));
            sb.append(HexArray.charAt((c >> 4) & 15));
            sb.append(HexArray.charAt((c) & 15));
            return sb.toString();
        }
        /*
        public static void MainTest(String[] args) {
            System.out.println(RgbToColorDisplay(ColorToRgba("#abc")));
            System.out.println(RgbToColorDisplay(ColorToRgba("#aebece")));
            System.out.println(RgbToColorDisplay(ColorToRgba("rgb(20,30,40)")));
            System.out.println(RgbToColorDisplay(ColorToRgba("rgb(20,30%,40)")));
            System.out.println(RgbToColorDisplay(ColorToRgba("rgba(20,30,40,0.5)")));
            System.out.println(RgbToColorDisplay(ColorToRgba("rgba(20,30%,40,0.5)")));
            System.out.println(RgbToColorDisplay(ColorToRgba("hsl(20,30%,40%)")));
            System.out.println(RgbToColorDisplay(ColorToRgba("hsl(20,30%,40)")));
            System.out.println(RgbToColorDisplay(ColorToRgba("hsla(20,30%,40%,0.5)")));
            System.out.println(RgbToColorDisplay(ColorToRgba("hsla(20,30%,40,0.5)")));
            System.out.println(RgbToColorDisplay(ColorToRgba("green")));
            System.out.println(RgbToColorDisplay(ColorToRgba("greenish")));
            System.out.println(RgbToColorDisplay(ColorToRgba("transparent")));
            System.out.println(RgbToColorDisplay(ColorToRgba("gray")));
            System.out.println(RgbToColorDisplay(ColorToRgba("grey")));
            System.out.println(RgbToColorDisplay(ColorToRgba("aliceblue")));
            System.out.println(RgbToColorDisplay(ColorToRgba("#aebece")));
        }
         */
    }

