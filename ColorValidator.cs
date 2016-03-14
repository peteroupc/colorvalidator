/*
 * This file is in the public domain. Peter O., 2012.
   http://upokecenter.dreamhosters.com
    Public domain dedication: http://creativecommons.org/publicdomain/zero/1.0/
 This file converts between different representations of HTML and CSS colors.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace PeterO {
    /// <summary>Contains methods to convert between different
    /// representations of HTML and CSS colors.</summary>
  public static class ColorValidator {
    /// <summary>Converts a color in the HLS color space to
    /// red/green/blue.</summary>
    /// <param name='hls'>An array containing three elements. This is a
    /// color in the form of hue, lightness, and saturation in that order.
    /// Hue can range from 0 to 360, and lightness and saturation can range
    /// from 0 to 255. If lightness and saturation are out of range, those
    /// values are clamped to fit that range (the array itself is not
    /// modified, though).</param>
    /// <returns>An array containing three elements, with the red, green,
    /// and blue components of the same color, each from 0 to
    /// 255.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='hls'/> is null.</exception>
    public static double[] HlsToRgb(double[] hls) {
      if ((hls) == null) {
        throw new ArgumentNullException("hls");
      }
      if (3 > hls.Length) {
        throw new ArgumentException("3 more than " + hls.Length + " (3)");
      }
      double hueval = hls[0] * 1.0;  // [0-360)
      double lum = hls[1] * 1.0;  // [0-255]
      double sat = hls[2] * 1.0;  // [0-255]
      lum = (lum < 0 ? 0 : (lum > 255 ? 255 : lum));
      sat = (sat < 0 ? 0 : (sat > 255 ? 255 : sat));
      if (sat == 0) {
        return new double[] { lum, lum, lum };
      }
      double b = 0;
      if (lum <= 127.5) {
        b = (lum * (255.0 + sat)) / 255.0;
      } else {
        b = lum * sat;
        b /= 255.0;
        b = lum + sat - b;
      }
      double a = (lum * 2) - b;
      double r, g, bl;
      if (hueval < 0 || hueval >= 360) {
        hueval = (((hueval % 360) + 360) % 360);
      }
      double hue = hueval + 120;
      if (hue >= 360) {
        hue -= 360;
      }
      r = (hue < 60) ? (a + (b - a) * hue / 60) : ((hue < 180) ? (b) :
        ((hue < 240) ? (a + (b - a) * (240 - hue) / 60) : (a)));
      hue = hueval;
      g = (hue < 60) ? (a + (b - a) * hue / 60) : ((hue < 180) ? (b) :
        ((hue < 240) ? (a + (b - a) * (240 - hue) / 60) : (a)));
      hue = hueval - 120;
      if (hue < 0) {
        hue += 360;
      }
      if (hue < 60) {
        bl = (a + (b - a) * hue / 60);
      } else {
     bl = (hue < 180) ? (b) : ((hue < 240) ? (a + (b - a) * (240 - hue) / 60) :
          (a));
      }
      return new double[] {
                (r<0 ? 0 : (r>255 ? 255 : r)),
        (g<0 ? 0 : (g>255 ? 255 : g)),
        (bl<0 ? 0 : (bl>255 ? 255 : bl))};
    }

    /// <summary>Converts HTML colors to Red/Green/Blue colors.</summary>
    /// <param name='x'>A string object naming an HTML color. This can be a
    /// named color or a color in the form "#RRGGBB".</param>
    /// <returns>An array containing four elements, with the red, green,
    /// blue, and alpha components of the same color, each from 0 to 255.
    /// Returns (0,0,0,0) if <paramref name='x'/> is null or
    /// empty.</returns>
    public static double[] ColorHtmlToRgba(string x) {
      ColorToRgbaSetUpNamedColors();
      x = x.ToLower(System.Globalization.CultureInfo.InvariantCulture);
      if (x.IndexOf("grey") >= 0) {
        x = x.Replace("grey", "gray");  // support "grey" variants
      }
      if (ColorToRgbaNamedColors.ContainsKey(x)) {
        string ret = ColorToRgbaNamedColors[x];
        if (ret != null) {
          return ColorToRgba(ret);
        }
      }
      var arr = new int[x.Length];
      for (int i = (x[0] == '#') ? 1 : 0; i < x.Length; i++) {
        int c = x[i];
        var hex = 0;
        if (c >= 0x30 && c <= 0x39) {
          hex = c - 0x30;
        }
        if (c >= 0x61 && c <= 0x66) {
          hex = c - 0x61 + 10;
        }
        arr[arr.Length] = hex;
      }
      int sublength = ((arr.Length + 2) / 3);
      while (arr.Length < sublength * 3) {
        arr[arr.Length] = 0;
      }
      int currlength = sublength;
      var offset = 0;
      while (currlength > 2) {
        if (arr[offset] == 0 && arr[sublength + offset] == 0 &&
           arr[sublength * 2 + offset] == 0) {
          --currlength; offset++;
        } else {
          break;
        }
      }
      return new double[] {
        arr[offset]*16 + arr[offset + 1],
        arr[sublength + offset]*16 + arr[sublength + offset + 1],
        arr[sublength*2 + offset]*16 + arr[sublength*2 + offset + 1],
        255 };
    }
    private static Regex[] patterns = new Regex[] {
      new Regex("^#([A-Fa-f0-9]{2})([A-Fa-f0-9]{2})([A-Fa-f0-9]{2})$"),
      new

  Regex(
  "^rgb\\(\\s*([\\+\\-]?\\d+(?:\\.\\d+)?%)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?%)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?%)\\s*\\)$"
),
      new

  Regex(
  "^rgb\\(\\s*([\\+\\-]?\\d+)\\s*,\\s*([\\+\\-]?\\d+)\\s*,\\s*([\\+\\-]?\\d+)\\s*\\)$"
),
      new

  Regex(
  "^rgba\\(\\s*([\\+\\-]?\\d+(?:\\.\\d+)?%)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?%)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?%)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)\\s*\\)$"
),
      new

  Regex(
  "^rgba\\(\\s*([\\+\\-]?\\d+)\\s*,\\s*([\\+\\-]?\\d+)\\s*,\\s*([\\+\\-]?\\d+)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)\\s*\\)$"
),
      new Regex("^#([A-Fa-f0-9]{1})([A-Fa-f0-9]{1})([A-Fa-f0-9]{1})$"),
      new

  Regex(
  "^hsl\\(\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)%\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)%\\s*\\)$"
),
      new

  Regex(
  "^hsla\\(\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)%\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)%\\s*,\\s*([\\+\\-]?\\d+(?:\\.\\d+)?)\\s*\\)$"
)
    };
    private static Match execPattern(Regex p, string s) {
      Match m = p.Match(s);
      return (m.Success) ? m : null;
    }
    private static double parseHue(string value) {
      try {
        double c = Convert.ToDouble(value,
          System.Globalization.CultureInfo.InvariantCulture);
        if (c < 0 || c >= 360) {
          c = (((c % 360) + 360) % 360);
        }
        return c;
      } catch (FormatException) {
        return Double.NaN;
      } catch (OverflowException) {
        return Double.NaN;
      }
    }
    private static double parseByte(string value) {
      try {
        double c = Convert.ToDouble(value,
          System.Globalization.CultureInfo.InvariantCulture);
        return (c < 0 ? 0 : (c > 255 ? 255 : c));
      } catch (FormatException) {
        return Double.NaN;
      } catch (OverflowException) {
        return Double.NaN;
      }
    }
    private static double parseUnit(string value) {
      try {
        double c = Convert.ToDouble(value,
          System.Globalization.CultureInfo.InvariantCulture);
        return (c < 0 ? 0 : (c > 1.0 ? 1.0 : c)) * 255.0;
      } catch (FormatException) {
        return Double.NaN;
      } catch (OverflowException) {
        return Double.NaN;
      }
    }
    private static double parsePercent(string value) {
      try {
        double c = Convert.ToDouble(value,
          System.Globalization.CultureInfo.InvariantCulture);
        return (c < 0 ? 0 : (c > 100 ? 100 : c)) * 255.0 / 100.0;
      } catch (FormatException) {
        return Double.NaN;
      } catch (OverflowException) {
        return Double.NaN;
      }
    }
    private static int dehexchar(int c) {
      if (c >= '0' && c <= '9') {
        return c - '0';
      }
      return (c >= 'A' && c <= 'F') ? (c + 10 - 'A') : ((c >= 'a' && c
        <= 'f') ? (c + 10 - 'a') : (-1));
    }
    private static int GetHex(string str) {
      if ((str) == null) {
        throw new ArgumentNullException("s");
      }
      if (str.Length == 0) {
        throw new ArgumentException("s is empty");
      }
      int h = dehexchar(str[0]);
      if (h < 0) {
        return 0;
      }
      if (str.Length > 1) {
        h = (h * 16) + dehexchar(str[1]);
        if (h < 0) {
          return 0;
        }
      }
      if (str.Length > 2) {
        h = (h * 16) + dehexchar(str[2]);
        if (h < 0) {
          return 0;
        }
      }
      if (str.Length > 3) {
        h = (h * 16) + dehexchar(str[3]);
        if (h < 0) {
          return 0;
        }
      }
      return h;
    }

    /// <summary>Converts an HTML or CSS color string to a 4-element RGB
    /// array.</summary>
    /// <param name='x'>A string which names a color. The following lists
    /// the kinds of colors accepted:
    /// <list>
    /// <item>HTML colors with the syntax <c>#RRGGBB</c>, where RR is the
    /// hexadecimal form of the red component (00-FF), GG is the
    /// hexadecimal green component, and BB is the hexadecimal blue
    /// component. Example: #88DFE0.</item>
    /// <item>HTML colors with the syntax <c>#RGB</c>, where R is the
    /// hexadecimal form of the red component (0-F), G is the hexadecimal
    /// green component, and B is the hexadecimal blue component. Example:
    /// #8DE.</item>
    /// <item>CSS colors with the syntax <c>rgb(red, green, blue)</c> or
    /// <c>rgba(red, green, blue, alpha)</c> where <c>red</c>,
    /// <c>green</c>, and <c>blue</c> are the red, green, and blue
    /// components, respectively, either as a number (0-255) or as a
    /// percent, and <c>alpha</c> is a number from 0-1 specifying the alpha
    /// component. Examples: <c>rgb(255, 0, 0)</c>, <c>rgb(100%, 50%,
    /// 0%)</c>, <c>rgba(20, 255, 255, 0.5)</c>.</item>
    /// <item>CSS colors with the syntax <c>hsl(hue, sat, light)</c> or
    /// <c>hsla(hue, sat, light, alpha)</c> where <c>hue</c> is the hue
    /// component in degrees (0-360), <c>sat</c> and <c>light</c> are the
    /// saturation and lightness components, respectively, as percents, and
    /// <c>alpha</c> is a number from 0-1 specifying the alpha component.
    /// Examples: <c>rgb(255, 0, 0)</c>, <c>hsl(200, 50%, 50%)</c>,
    /// <c>hsla(20, 80%, 90%, 0.5)</c>.</item>
    /// <item>CSS colors such as <c>red</c>, <c>green</c>, <c>white</c>,
    /// <c>lemonchiffon</c>, <c>chocolate</c>, and so on, including the
    /// newly added <c>rebeccapurple</c>.</item>
    /// <item>The value <c>transparent</c>, meaning transparent
    /// black.</item></list>
    /// <para>For more information: Colors in HTML and How to Enter Them,
    /// http://upokecenter.dreamhosters.com/articles/miscellaneous/how-to-enter-colors/</para>
    /// .</param>
    /// <returns>An array containing four elements, with the red, green,
    /// blue, and alpha components of the same color, each from 0 to 255.
    /// Returns (0, 0, 0, 0) if <paramref name='x'/> is null, empty, or has
    /// invalid syntax.</returns>
    public static double[] ColorToRgba(string x) {
      Match e = null;
      if (x == null) {
        return new double[] { 0, 0, 0, 0 };
      }
      if ((e = execPattern(patterns[0], x)) != null) {
        return new double[] {
          GetHex(e.Groups[1].ToString()),
          GetHex(e.Groups[2].ToString()),
          GetHex(e.Groups[3].ToString()),
          255 };
      } else if ((e = execPattern(patterns[1], x)) != null) {
        double r1 = parsePercent(e.Groups[1].ToString());
        double r2 = parsePercent(e.Groups[2].ToString());
        double r3 = parsePercent(e.Groups[3].ToString());
        return (Double.IsNaN(r1) || Double.IsNaN(r2) ||
          Double.IsNaN(r3)) ? (new double[] { 0, 0, 0, 0 }) : (new double[] { r1, r2, r3, 255
                  });
      } else if ((e = execPattern(patterns[2], x)) != null) {
        double r1 = parseByte(e.Groups[1].ToString());
        double r2 = parseByte(e.Groups[2].ToString());
        double r3 = parseByte(e.Groups[3].ToString());
        return (Double.IsNaN(r1) || Double.IsNaN(r2) ||
          Double.IsNaN(r3)) ? (new double[] { 0, 0, 0, 0 }) : (new double[] { r1, r2, r3, 255
                  });
      } else if ((e = execPattern(patterns[3], x)) != null) {
        double r1 = parsePercent(e.Groups[1].ToString());
        double r2 = parsePercent(e.Groups[2].ToString());
        double r3 = parsePercent(e.Groups[3].ToString());
        double r4 = parseUnit(e.Groups[4].ToString());
        return (Double.IsNaN(r1) || Double.IsNaN(r2) || Double.IsNaN(r3) ||
             Double.IsNaN(r4)) ? (new double[] { 0, 0, 0, 0 }) : (new
               double[] { r1, r2, r3, r4 });
      } else if ((e = execPattern(patterns[4], x)) != null) {
        double r1 = parseByte(e.Groups[1].ToString());
        double r2 = parseByte(e.Groups[2].ToString());
        double r3 = parseByte(e.Groups[3].ToString());
        double r4 = parseUnit(e.Groups[4].ToString());
        return (Double.IsNaN(r1) || Double.IsNaN(r2) || Double.IsNaN(r3) ||
             Double.IsNaN(r4)) ? (new double[] { 0, 0, 0, 0 }) : (new
               double[] { r1, r2, r3, r4 });
      } else if ((e = execPattern(patterns[5], x)) != null) {
        int a = GetHex(e.Groups[1].ToString());
        int b = GetHex(e.Groups[2].ToString());
        int c = GetHex(e.Groups[3].ToString());
        return new double[] { a + (a << 4), b + (b << 4), c + (c << 4), 255 };
      } else if ((e = execPattern(patterns[6], x)) != null) {  // hsl
        double r1 = parseHue(e.Groups[1].ToString());
        double r2 = parsePercent(e.Groups[3].ToString());
        double r3 = parsePercent(e.Groups[2].ToString());
        if (Double.IsNaN(r1) || Double.IsNaN(r2) || Double.IsNaN(r3)) {
          return (new double[] { 0, 0, 0, 0 });
        }
        double[] rgb = HlsToRgb(new double[] { r1, r2, r3 });
        return new double[] { rgb[0], rgb[1], rgb[2], 255 };
      } else if ((e = execPattern(patterns[7], x)) != null) {  // hsla
        double r1 = parseHue(e.Groups[1].ToString());
        double r2 = parsePercent(e.Groups[3].ToString());
        double r3 = parsePercent(e.Groups[2].ToString());
        double r4 = parseUnit(e.Groups[4].ToString());
        if (Double.IsNaN(r1) || Double.IsNaN(r2) || Double.IsNaN(r3) ||
          Double.IsNaN(r4)) {
          return (new double[] { 0, 0, 0, 0 });
        }
        double[] rgb = HlsToRgb(new double[] { r1, r2, r3 });
        return new double[] { rgb[0], rgb[1], rgb[2], r4 };
      } else {
        x = x.ToLower(System.Globalization.CultureInfo.InvariantCulture);
        if (x.IndexOf("grey") >= 0) {
          x = x.Replace("grey", "gray");  // support "grey" variants
        }
        if (ColorToRgbaNamedColors.ContainsKey(x)) {
          string ret = ColorToRgbaNamedColors[x];
          if (ret != null) {
            return ColorToRgba(ret);
          }
        }
        return (x.Equals("transparent")) ? (new double[] { 0, 0, 0, 0
                  }) : (new double[] { 0, 0, 0, 0 });
      }
    }
    private static Dictionary<string, string> ColorToRgbaNamedColors =
      ColorToRgbaSetUpNamedColors();
    private static string[] nc = new string[] {
            "aliceblue", "f0f8ff", "antiquewhite", "faebd7", "aqua",
              "00ffff", "aquamarine", "7fffd4", "azure", "f0ffff", "beige",
"f5f5dc",
        "bisque", "ffe4c4", "black", "000000", "blanchedalmond",
            "ffebcd",
"blue", "0000ff", "blueviolet", "8a2be2", "brown",
          "a52a2a", "burlywood", "deb887", "cadetblue", "5f9ea0",
          "chartreuse", "7fff00", "chocolate", "d2691e", "coral", "ff7f50",
"cornflowerblue", "6495ed", "cornsilk", "fff8dc", "crimson",
          "dc143c", "cyan", "00ffff", "darkblue", "00008b", "darkcyan",
            "008b8b", "darkgoldenrod", "b8860b", "darkgray", "a9a9a9",
          "darkgreen", "006400", "darkkhaki", "bdb76b", "darkmagenta",
          "8b008b", "darkolivegreen", "556b2f", "darkorange", "ff8c00",
            "darkorchid", "9932cc", "darkred", "8b0000", "darksalmon",
          "e9967a", "darkseagreen", "8fbc8f", "darkslateblue", "483d8b",
            "darkslategray", "2f4f4f", "darkturquoise", "00ced1",
          "darkviolet", "9400d3", "deeppink", "ff1493",
          "deepskyblue", "00bfff", "dimgray", "696969", "dodgerblue",
            "1e90ff", "firebrick", "b22222", "floralwhite", "fffaf0",
          "forestgreen", "228b22", "fuchsia", "ff00ff", "gainsboro", "dcdcdc",
          "ghostwhite", "f8f8ff", "gold", "ffd700", "goldenrod", "daa520",
            "gray", "808080", "green", "008000", "greenyellow", "adff2f",
          "honeydew", "f0fff0", "hotpink", "ff69b4", "indianred", "cd5c5c",
"indigo", "4b0082", "ivory", "fffff0", "khaki", "f0e68c",
          "lavender", "e6e6fa", "lavenderblush", "fff0f5", "lawngreen",
          "7cfc00", "lemonchiffon", "fffacd", "lightblue", "add8e6",
            "lightcoral", "f08080", "lightcyan", "e0ffff",
            "lightgoldenrodyellow",
          "fafad2", "lightgray", "d3d3d3", "lightgreen",
          "90ee90", "lightpink", "ffb6c1", "lightsalmon", "ffa07a",
            "lightseagreen", "20b2aa", "lightskyblue", "87cefa",
            "lightslategray",
          "778899", "lightsteelblue", "b0c4de", "lightyellow", "ffffe0",
            "lime", "00ff00", "limegreen", "32cd32", "linen", "faf0e6",
            "magenta",
          "ff00ff", "maroon", "800000", "mediumaquamarine",
          "66cdaa", "mediumblue", "0000cd", "mediumorchid", "ba55d3",
            "mediumpurple", "9370d8", "mediumseagreen", "3cb371",
          "mediumslateblue", "7b68ee", "mediumspringgreen",
        "00fa9a", "mediumturquoise", "48d1cc", "mediumvioletred",
            "c71585",
"midnightblue", "191970", "mintcream", "f5fffa", "mistyrose",
          "ffe4e1", "moccasin", "ffe4b5", "navajowhite", "ffdead", "navy",
            "000080", "oldlace", "fdf5e6", "olive", "808000", "olivedrab",
            "6b8e23",
          "orange", "ffa500", "orangered",
          "ff4500", "orchid", "da70d6", "palegoldenrod", "eee8aa",
            "palegreen", "98fb98", "paleturquoise", "afeeee",
            "palevioletred", "d87093",
          "papayawhip", "ffefd5", "peachpuff",
          "ffdab9", "peru", "cd853f", "pink", "ffc0cb", "plum", "dda0dd",
            "powderblue", "b0e0e6", "purple", "800080", "rebeccapurple"
              ,"663399" ,"red", "ff0000",
          "rosybrown", "bc8f8f", "royalblue", "4169e1",
          "saddlebrown", "8b4513", "salmon", "fa8072", "sandybrown",
            "f4a460", "seagreen", "2e8b57", "seashell", "fff5ee", "sienna"
            ,
          "a0522d", "silver", "c0c0c0", "skyblue", "87ceeb", "slateblue",
            "6a5acd", "slategray", "708090", "snow", "fffafa",
            "springgreen",
          "00ff7f", "steelblue", "4682b4", "tan", "d2b48c", "teal",
          "008080", "thistle", "d8bfd8", "tomato", "ff6347", "turquoise",
            "40e0d0", "violet", "ee82ee", "wheat", "f5deb3", "white",
            "ffffff",
          "whitesmoke", "f5f5f5", "yellow", "ffff00", "yellowgreen", "9acd32"
        };
    private static Dictionary<string, string> ColorToRgbaSetUpNamedColors() {
      Dictionary<string, string> ColorToRgbaNamedColors = new
        Dictionary<string, string>();
      for (int i = 0; i < nc.Length; i += 2) {
        ColorToRgbaNamedColors.Add(nc[i], "#" + nc[i + 1]);
      }
      return ColorToRgbaNamedColors;
    }

    /// <summary>Converts HTML and CSS colors to Red/Green/Blue colors. Use
    /// this function to parse colors from normal color picker controls:
    /// http://peteroupc.github.com/colorpicker/.</summary>
    /// <param name='x'>A string which names a color. The following lists
    /// the kinds of colors accepted:
    /// <list>
    /// <item>HTML colors with the syntax <c>#RRGGBB</c>, where RR is the
    /// hexadecimal form of the red component (00-FF), GG is the
    /// hexadecimal green component, and BB is the hexadecimal blue
    /// component. Example: #88DFE0.</item>
    /// <item>HTML colors with the syntax <c>#RGB</c>, where R is the
    /// hexadecimal form of the red component (0-F), G is the hexadecimal
    /// green component, and B is the hexadecimal blue component. Example:
    /// #8DE.</item>
    /// <item>CSS colors with the syntax <c>rgb(red, green, blue)</c>,
    /// where <c>red</c>, <c>green</c>, and <c>blue</c> are the red,
    /// green, and blue components, respectively, either as a number
    /// (0-255) or as a percent. Examples: <c>rgb(255, 0, 0)</c>,
    /// <c>rgb(100%, 50%, 0%)</c>.</item>
    /// <item>CSS colors with the syntax <c>hsl(hue, sat, light)</c>,
    /// where <c>hue</c> is the hue component in degrees (0-360), and
    /// <c>sat</c> and <c>light</c> are the saturation and lightness
    /// components, respectively, as percents. Examples: <c>rgb(255, 0,
    /// 0)</c>, <c>hsl(200, 50%, 50%)</c>.</item>
    /// <item>CSS colors such as <c>red</c>, <c>green</c>, <c>white</c>,
    /// <c>lemonchiffon</c>, <c>chocolate</c>, and so on, including the
    /// newly added <c>rebeccapurple</c>.</item></list>
    /// <para>For more information: Colors in HTML and How to Enter Them,
    /// http://upokecenter.dreamhosters.com/articles/miscellaneous/how-to-enter-colors/</para>
    /// .</param>
    /// <returns>Returns a 4-element array containing the red, green, blue,
    /// and alpha(each 0-255); the alpha is always 255. Returns null if the
    /// string is not a valid color.</returns>
    public static double[] ColorToRgb(string x) {
      if (x == null) {
        return null;
      }
      // don't include rgba or hsla
      if (x.IndexOf("rgba") == 0 || x.IndexOf("hsla") == 0) {
        return null;
      }
      double[] rgba = ColorToRgba(x);
      if (rgba == null || rgba[3] == 0) {
        return null;  // transparent
      }
      return new double[] { rgba[0], rgba[1], rgba[2], 255 };
    }
    private static string RoundedString(double r) {
      r = Math.Round(r, MidpointRounding.AwayFromZero);
      return Convert.ToString((double)r,
        System.Globalization.CultureInfo.InvariantCulture);
    }

    /// <summary>Converts an RGBA color to a string, either rgb(...) or
    /// rgba(...) as applicable.</summary>
    /// <param name='arrayRGB'>A 3- or 4-item array containing the
    /// intensity of red, green, and blue (each from 0-255), with optional
    /// alpha (0-255).</param>
    /// <returns>A string object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='arrayRGB'/> is null.</exception>
    public static string RgbToColor(double[] arrayRGB) {
      if ((arrayRGB) == null) {
        throw new ArgumentNullException("arrayRGB");
      }
      if (3 > arrayRGB.Length) {
        throw new ArgumentException("3 more than " + arrayRGB.Length + " (3)");
      }
      // we should include the spaces
   if ((arrayRGB.Length > 3 && (arrayRGB[3] == 255)) || arrayRGB.Length == 3) {
        return "rgb(" + RoundedString(arrayRGB[0]) + ", " +
            RoundedString(arrayRGB[1]) + ", " +
            RoundedString(arrayRGB[2]) + ")";
      } else {
        double prec = Math.Round((arrayRGB[3] / 255.0) * 100.0,
          MidpointRounding.AwayFromZero) / 100.0;
        return "rgba(" + RoundedString(arrayRGB[0]) + ", " +
            RoundedString(arrayRGB[1]) + ", " +
            RoundedString(arrayRGB[2]) + ", " +
            Convert.ToString((double)prec,
            System.Globalization.CultureInfo.InvariantCulture) + ")";
      }
    }

    /// <summary>Converts a red-green-blue-alpha color to a string in CSS
    /// format.</summary>
    /// <param name='rgb'>An array containing three or four elements, with
    /// the red, green, blue, and alpha components of the color, each from
    /// 0 to 255. Each element's value is adjusted to 0 if it's less than 0
    /// and to 255 if it's greater than 255 (the array itself is not
    /// modified, though).</param>
    /// <returns>A string in HTML color format: "#RRGGBB", if there are
    /// three elements or the fourth value in the array is 255, or a string
    /// in the RGBA color format otherwise.</returns>
    /// <exception cref='ArgumentException'>The parameter <paramref
    /// name='rgb'/> is null or contains fewer than three
    /// elements.</exception>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='rgb'/> is null.</exception>
    public static string RgbToColorDisplay(double[] rgb) {
      if ((rgb) == null) {
        throw new ArgumentNullException("rgb");
      }
      if (3 > rgb.Length) {
        throw new ArgumentException("3 more than " + rgb.Length + " (3)");
      }
      if (rgb.Length == 3 || (rgb.Length > 3 && rgb[3] == 255)) {
        return RgbToColorHtml(rgb);
      } else {
        return RgbToColor(rgb).Replace(" ", "");
      }
    }
    private static string HexArray = "0123456789abcdef";

    /// <summary>Converts an RGBA color to an HTML color, (ex.
    /// #002233).&#x22;rgb&#x22; must contain at least 3 elements: the red,
    /// green, and blue (each 0-255).</summary>
    /// <param name='rgb'>A double[] object.</param>
    /// <returns>A string object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='rgb'/> is null.</exception>
    public static string RgbToColorHtml(double[] rgb) {
      if ((rgb) == null) {
        throw new ArgumentNullException("rgb");
      }
      if (3 > rgb.Length) {
        throw new ArgumentException("3 more than " + rgb.Length + " (3)");
      }
      var sb = new StringBuilder();
      int c;
      c = ((c = (int)Math.Round(rgb[0], MidpointRounding.AwayFromZero)) <
        0 ? 0 : (c > 255 ? 255 : c));
      sb.Append(HexArray[(c >> 4) & 15]);
      sb.Append(HexArray[(c) & 15]);
      c = ((c = (int)Math.Round(rgb[1], MidpointRounding.AwayFromZero)) <
        0 ? 0 : (c > 255 ? 255 : c));
      sb.Append(HexArray[(c >> 4) & 15]);
      sb.Append(HexArray[(c) & 15]);
      c = ((c = (int)Math.Round(rgb[2], MidpointRounding.AwayFromZero)) <
        0 ? 0 : (c > 255 ? 255 : c));
      sb.Append(HexArray[(c >> 4) & 15]);
      sb.Append(HexArray[(c) & 15]);
      return sb.ToString();
    }

    /// <summary>Converts a red-green-blue color to a string in HTML
    /// format.</summary>
    /// <param name='r'>The red component of the color, from 0 to 255. As
    /// with "g" and "b", this value is adjusted to 0 if it's less than 0
    /// and to 255 if it's greater than 255.</param>
    /// <param name='g'>The green component of the color, from 0 to
    /// 255.</param>
    /// <param name='b'>The blue component of the color, from 0 to
    /// 255.</param>
    /// <returns>A string in HTML color format: "#RRGGBB".</returns>
    public static string RgbToColorHtml(double r, double g, double b) {
      var sb = new StringBuilder();
      int c;
      c = ((c = (int)Math.Round(r, MidpointRounding.AwayFromZero)) < 0 ? 0 :
          (c > 255 ? 255 : c));
      sb.Append(HexArray[(c >> 4) & 15]);
      sb.Append(HexArray[(c) & 15]);
      c = ((c = (int)Math.Round(g, MidpointRounding.AwayFromZero)) < 0 ? 0 :
          (c > 255 ? 255 : c));
      sb.Append(HexArray[(c >> 4) & 15]);
      sb.Append(HexArray[(c) & 15]);
      c = ((c = (int)Math.Round(b, MidpointRounding.AwayFromZero)) < 0 ? 0 :
          (c > 255 ? 255 : c));
      sb.Append(HexArray[(c >> 4) & 15]);
      sb.Append(HexArray[(c) & 15]);
      return sb.ToString();
    }
  }
}
