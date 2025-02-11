package com.upokecenter.util;
/*
Written in 2012-2016 by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under the Unlicense: https://unlicense.org/

 */

import java.util.*;

  /**
   * Color validator.
   */
  public final class ColorValidator {
private ColorValidator() {
}
    private static int SkipWhite(String str, int index, int endIndex) {
      while (index < endIndex) {
        int c = str.charAt(index);
        if (c == 32 || c == 13 || c == 12 || c == 9 || c == 10) {
          ++index;
        } else {
          break;
        }
      }
      return index;
    }

    private static int ParseComma(String str, int index, int endIndex) {
      int indexStart = index;
      index = SkipWhite(str, index, endIndex);
      if (index < endIndex && (str.charAt(index) == 44)) {
        return SkipWhite(str, index + 1, endIndex);
      } else {
        return indexStart;
      }
    }

    private static int ParseEndparen(String str, int index, int endIndex) {
      int indexStart = index;
      index = SkipWhite(str, index, endIndex);
      if (index < endIndex && (str.charAt(index) == 41)) {
        return index + 1;
      } else {
        return indexStart;
      }
    }

    private static int Hsl(
      String str,
      int index,
      int endIndex,
      double[] ret) {
      int indexStart, indexTemp, tx2;
      indexStart = index;
      indexTemp = index;
      do {
        if ((tx2 = ParseHue(str, index, endIndex, ret, 0)) == index) {
          return indexStart;
        }
        index = tx2;
        if ((
            tx2 = SepPct(
              str,
              index,
              endIndex,
              ret,
              1)) == index) {
          return indexStart;
        }
        index = tx2;
        if ((
            tx2 = SepPct(
              str,
              index,
              endIndex,
              ret,
              2)) == index) {
          return indexStart;
        }
        index = tx2;
        tx2 = ParseEndparen(str, index, endIndex);
        if (tx2 == index) {
          index = indexStart;
          break;
        } else {
          index = tx2;
        }
        double[] rgb = HlsToRgb(ret[0], ret[2], ret[1]);
        ret[0] = rgb[0];
        ret[1] = rgb[1];
        ret[2] = rgb[2];
        ret[3] = 255.0;
        indexTemp = index;
      } while (false);
      return indexTemp;
    }

    private static int Pct(
      String str,
      int index,
      int endIndex,
      double[] ret,
      int retIndex) {
      int tx2 = ParseNumber(str, index, endIndex);
      if (tx2 != index) {
        if (tx2 >= endIndex || str.charAt(tx2) != 37) {
          return index;
        }
        ret[retIndex] = StringToPercent(str, index, tx2) * 255.0 /
          100.0;
        return tx2 + 1;
      }
      return tx2;
    }

    private static int ParseByte(
      String str,
      int index,
      int endIndex,
      double[] ret,
      int retIndex) {
      int tx2 = ParseInteger(str, index, endIndex, true);
      if (tx2 != index) {
        ret[retIndex] = StringToByte(str, index, tx2);
      }
      return tx2;
    }

    private static int ParseHue(
      String str,
      int index,
      int endIndex,
      double[] ret,
      int retIndex) {
      int start = index;
      index = SkipWhite(str, index, endIndex);
      int tx2 = ParseNumber(str, index, endIndex);
      if (tx2 != index) {
        ret[retIndex] = StringToHue(str, index, tx2);
        return tx2;
      } else {
        return start;
      }
    }

    private static int SepByte(
      String str,
      int index,
      int endIndex,
      double[] ret,
      int retIndex) {
      int tx2 = ParseComma(str, index, endIndex);
      return (tx2 != index) ? ParseByte(
        str,
        tx2,
        endIndex,
        ret,
        retIndex) : tx2;
    }

    private static int SepPct(
      String str,
      int index,
      int endIndex,
      double[] ret,
      int retIndex) {
      int tx2 = ParseComma(str, index, endIndex);
      return (tx2 != index) ? Pct(str, tx2, endIndex, ret, retIndex) : tx2;
    }

    private static int SepAlpha(
      String str,
      int index,
      int endIndex,
      double[] ret,
      int retIndex) {
      int tx2 = ParseComma(str, index, endIndex);
      if (tx2 != index) {
        index = tx2;
        tx2 = ParseNumber(str, index, endIndex);
        if (tx2 != index) {
          ret[retIndex] = StringToAlpha(str, index, tx2);
        }
      }
      return tx2;
    }

    private static int Hsla(
      String str,
      int index,
      int endIndex,
      double[] ret) {
      int indexStart, indexTemp, tx2;
      indexStart = index;
      indexTemp = index;
      do {
        if ((tx2 = ParseHue(str, index, endIndex, ret, 0)) == index) {
          return indexStart;
        }
        index = tx2;
        if ((
            tx2 = SepPct(
              str,
              index,
              endIndex,
              ret,
              1)) == index) {
          return indexStart;
        }
        index = tx2;
        if ((
            tx2 = SepPct(
              str,
              index,
              endIndex,
              ret,
              2)) == index) {
          return indexStart;
        }
        index = tx2;
        if ((tx2 = SepAlpha(str, index, endIndex, ret, 3)) ==
          index) {
          return indexStart;
        }
        index = tx2;
        double[] rgb = HlsToRgb(ret[0], ret[2], ret[1]);
        ret[0] = rgb[0];
        ret[1] = rgb[1];
        ret[2] = rgb[2];
        tx2 = ParseEndparen(str, index, endIndex);
        if (tx2 == index) {
          index = indexStart;
          break;
        } else {
          index = tx2;
        }
        indexTemp = index;
      } while (false);
      return indexTemp;
    }

    private static int Rgba(
      String str,
      int index,
      int endIndex,
      double[] result) {
      int indexStart, tx2;
      indexStart = index;
      index = SkipWhite(str, index, endIndex);
      int st = index;
      boolean continuing = true;
      if ((tx2 = Pct(str, index, endIndex, result, 0)) ==
        index) {
        continuing = false;
      } else {
        index = tx2;
      }
      if (
        continuing && (
          tx2 = SepPct(
            str,
            index,
            endIndex,
            result,
            1)) == index) {
        continuing = false;
      } else {
        index = tx2;
      }
      if (
        continuing && (
          tx2 = SepPct(
            str,
            index,
            endIndex,
            result,
            2)) == index) {
        continuing = false;
      } else {
        index = tx2;
      }
      if (
        continuing && (
          tx2 = SepAlpha(
            str,
            index,
            endIndex,
            result,
            3)) == index) {
        continuing = false;
      } else {
        index = tx2;
      }
      if (!continuing) {
        index = st;
        continuing = true;
        if ((tx2 = ParseByte(str, index, endIndex, result, 0)) ==
          index) {
          continuing = false;
        } else {
          index = tx2;
        }
        if (
          continuing && (
            tx2 = SepByte(
              str,
              index,
              endIndex,
              result,
              1)) == index) {
          continuing = false;
        } else {
          index = tx2;
        }
        if (
          continuing && (
            tx2 = SepByte(
              str,
              index,
              endIndex,
              result,
              2)) == index) {
          continuing = false;
        } else {
          index = tx2;
        }
        if (
          continuing && (
            tx2 = SepAlpha(
              str,
              index,
              endIndex,
              result,
              3)) == index) {
          continuing = false;
        } else {
          index = tx2;
        }
      }
      if (!continuing) {
        return indexStart;
      }
      tx2 = ParseEndparen(str, index, endIndex);
      index = (tx2 == index) ? indexStart : tx2;
      return index;
    }

    private static int Rgb(
      String str,
      int index,
      int endIndex,
      double[] result) {
      int indexStart, tx2;
      indexStart = index;
      index = SkipWhite(str, index, endIndex);
      int st = index;
      boolean continuing = true;
      if ((tx2 = Pct(str, index, endIndex, result, 0)) ==
        index) {
        continuing = false;
      } else {
        index = tx2;
      }
      if (
        continuing && (
          tx2 = SepPct(
            str,
            index,
            endIndex,
            result,
            1)) == index) {
        continuing = false;
      } else {
        index = tx2;
      }
      if (
        continuing && (
          tx2 = SepPct(
            str,
            index,
            endIndex,
            result,
            2)) == index) {
        continuing = false;
      } else {
        index = tx2;
      }
      if (!continuing) {
        index = st;
        continuing = true;
        if ((tx2 = ParseByte(str, index, endIndex, result, 0)) ==
          index) {
          continuing = false;
        } else {
          index = tx2;
        }
        if (
          continuing && (
            tx2 = SepByte(
              str,
              index,
              endIndex,
              result,
              1)) == index) {
          continuing = false;
        } else {
          index = tx2;
        }
        if (
          continuing && (
            tx2 = SepByte(
              str,
              index,
              endIndex,
              result,
              2)) == index) {
          continuing = false;
        } else {
          index = tx2;
        }
      }
      if (!continuing) {
        return indexStart;
      }
      result[3] = 255.0;
      tx2 = ParseEndparen(str, index, endIndex);
      if (tx2 == index) {
        return indexStart;
      } else {
        return tx2;
      }
    }

    private static double StringToNumber(
      String str,
      int index,
      int endIndex) {
      String str2 = str.substring(index, (index)+(endIndex - index));
      return Double.parseDouble(str2);
    }

    private static double StringToPercent(
      String str,
      int index,
      int endIndex) {
      double num = StringToNumber(str, index, endIndex);
      return Double.isNaN(num) ? (-1) : ((num < 0) ? 0 :
          ((num > 100) ? 100 : num));
    }

    private static double StringToAlpha(
      String str,
      int index,
      int endIndex) {
      double num = StringToNumber(str, index, endIndex);
      return (num < 0) ? 0 : ((num > 1.0) ? 255 : num * 255.0);
    }

    private static double StringToHue(
      String str,
      int index,
      int endIndex) {
      double num = StringToNumber(str, index, endIndex);
      return (Double.isNaN(num) || ((num) == Double.POSITIVE_INFINITY) ||
          ((num) == Double.NEGATIVE_INFINITY)) ? 0 : (((num % 360) + 360) %
          360);
    }

    private static double StringToByte(
      String str,
      int index,
      int endIndex) {
      double num = StringToNumber(str, index, endIndex);
      return (num < 0) ? 0 : ((num > 255) ? 255 : num);
    }

    private static int ParseInteger(
      String str,
      int index,
      int endIndex,
      boolean posneg) {
      boolean digits = false;
      int indexStart = index;
      if (
        posneg && index < endIndex && ((str.charAt(index) == 43) ||
          (str.charAt(index) == 45))) {
        ++index;
      }
      while (index < endIndex && (str.charAt(index) >= 48 && str.charAt(index) <=
          57)) {
        ++index;
        digits = true;
      }
      return digits ? index : indexStart;
    }

    private static int ParseNumber(String str, int index, int endIndex) {
      int indexStart = index;
      int tmp = index;
      if ((tmp = ParseInteger(str, index, endIndex, true)) !=
        indexStart) {
        index = tmp;
        if (index < endIndex && (str.charAt(index) == 46)) {
          // Dot is optional
          ++index;
          if ((tmp = ParseInteger(str, index, endIndex, false)) !=
            index) {
            int tmp2 = 0;
            return (
                index < endIndex && (str.charAt(index) == 0x45 || str.charAt(index) ==
                  0x65) && (tmp2 = ParseInteger(
                    str,
                    index + 1,
                    endIndex,
                    true)) != index + 1) ? tmp2 : tmp;
          } else {
            return index - 1;
          }
        }
        return index;
      } else {
        if (index < endIndex && ((str.charAt(index) == 43) || (str.charAt(index) ==
              45))) {
          ++index;
        }
        if (index < endIndex && (str.charAt(index) == 46)) {
          // Dot is required
          ++index;
          if ((tmp = ParseInteger(str, index, endIndex, false)) !=
            index) {
            int tmp2 = 0;
            return (
                index < endIndex && (str.charAt(index) == 0x45 || str.charAt(index) ==
                  0x65) && (tmp2 = ParseInteger(
                    str,
                    index + 1,
                    endIndex,
                    true)) != index + 1) ? tmp2 : tmp;
          } else {
            return indexStart;
          }
        }
        return indexStart;
      }
    }

    /**
     * Converts a color in the HLS color space to red/green/blue. Hue can range
     * from 0 to 360, and lightness and saturation can range from 0 to 255. If
     * lightness and saturation are out of range, those values are clamped to fit
     * that range.
     * @param hueval The parameter {@code hueval} is a 64-bit floating-point
     * number.
     * @param lum The parameter {@code lum} is a 64-bit floating-point number.
     * @param sat The parameter {@code sat} is a 64-bit floating-point number.
     * @return An array containing three elements, with the red, green, and blue
     * components of the same color, each from 0 to 255.
     * @throws NullPointerException The parameter "hls" is null.
     */
    public static double[] HlsToRgb(
      double hueval,
      double lum,
      double sat) {
      lum = lum < 0 ? 0 : (lum > 255 ? 255 : lum);
      sat = sat < 0 ? 0 : (sat > 255 ? 255 : sat);
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
        hueval = ((hueval % 360) + 360) % 360;
      }
      double hue = hueval + 120;
      if (hue >= 360) {
        hue -= 360;
      }
      r = (hue < 60) ? (a + ((b - a) * hue / 60)) : ((hue < 180) ? b :
          ((hue < 240) ? (a + ((b - a) * (240 - hue) / 60)) : a));
      hue = hueval;
      g = (hue < 60) ? (a + ((b - a) * hue / 60)) : ((hue < 180) ? b :
          ((hue < 240) ? (a + ((b - a) * (240 - hue) / 60)) : a));
      hue = hueval - 120;
      if (hue < 0) {
        hue += 360;
      }
      bl = (hue < 60) ? (a + ((b - a) * hue / 60)) : ((hue < 180) ? b :
          ((hue < 240) ? (a + ((b - a) * (240 - hue) / 60)) : a));
      return new double[] {
        (r < 0 ? 0 : (r > 255 ? 255 : r)),
        (g < 0 ? 0 : (g > 255 ? 255 : g)),
        (bl < 0 ? 0 : (bl > 255 ? 255 : bl)),
      };
    }

    private static int Dehexchar(int c) {
      if (c >= '0' && c <= '9') {
        return c - 0x30;
      }
      return (c >= 'A' && c <= 'F') ? (c + 10 - 0x41) : ((c >= 'a' && c
            <= 'f') ? (c + 10 - 0x61) : (-1));
    }

    private static String ToLowerCaseAscii(String str) {
      if (str == null) {
        return null;
      }
      int len = str.length();
      char c = (char)0;
      boolean hasUpperCase = false;
      for (int i = 0; i < len; ++i) {
        c = str.charAt(i);
        if (c >= 0x41 && c <= 0x5a) {
          hasUpperCase = true;
          break;
        }
      }
      if (!hasUpperCase) {
        return str;
      }
      StringBuilder builder = new StringBuilder();
      for (int i = 0; i < len; ++i) {
        c = str.charAt(i);
        if (c >= 0x41 && c <= 0x5a) {
          builder.append((char)(c + 0x20));
        } else {
          builder.append(c);
        }
      }
      return builder.toString();
    }

    private static String TrimAsciiWhite(String str) {
      if (((str) == null || (str).length() == 0)) {
        return str;
      }
      int index = 0;
      int valueSLength = str.length();
      while (index < valueSLength) {
        char c = str.charAt(index);
        if (c != 0x09 && c != 0x20 && c != 0x0c && c != 0x0d && c !=
          0x0a) {
          break;
        }
        ++index;
      }
      if (index == valueSLength) {
        return "";
      }
      int indexStart = index;
      index = str.length() - 1;
      while (index >= 0) {
        char c = str.charAt(index);
        if (c != 0x09 && c != 0x20 && c != 0x0c && c != 0x0d && c !=
          0x0a) {
          int indexEnd = index + 1;
          if (indexEnd == indexStart) {
            return "";
          }
          return (indexEnd == str.length() && indexStart == 0) ? str :
            str.substring(indexStart, (indexStart)+(indexEnd - indexStart));
        }
        --index;
      }
      return "";
    }

    private static boolean RgbHex(String str, double[] hexval, boolean hash) {
      if (((str) == null || (str).length() == 0)) {
        return false;
      }
      int slen = str.length();
      int hexes = new int[8];
      int index = 0;
      int hexIndex = 0;
      if (str.charAt(0) == '#') {
        --slen;
        ++index;
      } else if (hash) {
        return false;
      }
      if (slen != 3 && slen != 4 && slen != 6 && slen != 8) {
        return false;
      }
      for (int i = index; i < str.length(); ++i) {
        int hex = Dehexchar(str.charAt(i));
        if (hex < 0) {
          return false;
        }
        hexes.set(hexIndex++, hex);
      }
      if (slen == 4) {
        hexval[3] = (double)(hexes.get(3) | (hexes.get(3) << 4));
      } else if (slen == 8) {
        hexval[3] = (double)(hexes.get(7) | (hexes.get(6) << 4));
      } else {
        hexval[3] = 255.0;
      }
      if (slen == 3 || slen == 4) {
        hexval[0] = (double)(hexes.get(0) | (hexes.get(0) << 4));
        hexval[1] = (double)(hexes.get(1) | (hexes.get(1) << 4));
        hexval[2] = (double)(hexes.get(2) | (hexes.get(2) << 4));
      } else if (slen >= 6) {
        hexval[0] = (double)(hexes.get(1) | (hexes.get(0) << 4));
        hexval[1] = (double)(hexes.get(3) | (hexes.get(2) << 4));
        hexval[2] = (double)(hexes.get(5) | (hexes.get(4) << 4));
      }
      return true;
    }

    /**
     * Converts an HTML or CSS color string to a 4-element RGB array.
     * @param colorString <p>A string that names a color. The letters in the string
     * can be in any combination of basic uppercase letters A to Z (U+0041 to
     * U+005A) and basic lowercase letters. The string can begin with any
     * combination of white space characters (U+0009, U+000A, U+000C, U+000D,
     * U+0020), can end with any combination of those characters, or both.</p>
     * <p>**What colors can I use?** You can use values like the following as color
     * strings.</p> <p>1. CSS color names (from the CSS3 Color Module): {@code
     * red}, {@code blue}, {@code silver}, {@code fuchsia}, {@code
     * darkslateblue}.</p> <p>2. HTML hexadecimal (base-16) colors: {@code
     * #223344}, {@code #234}, {@code #234F}, or {@code #223344FF} (See _What is
     * the syntax for HTML colors?_).</p> <p>3. RGB notation: {@code rgb(20, 30,
     * 40)} or {@code rgba(20, 30, 40, 50%)}. (See _What is RGB notation?_,
     * later.)</p> <p>4. HSL notation: {@code hsl(200, 100%, 50%)} or {@code
     * hsla(200, 100%, 50%, 80%}. (See _What is HSL notation?_, later.)</p> <p>5.
     * The newly-added color name {@code rebeccapurple}.</p> <p>6. The word {@code
     * transparent}, meaning a fully-transparent color.</p> <p>**What do some
     * colors look like?** Consult a.get(list of useful colors sorted by hue or
     * color tone)(https://peteroupc.github.io/html3dutil/websafe.svg). This
     * particular list was historically called the "Web safe" colors or the "safety
     * palette", and consists of 216 colors that are uniformly spaced in the
     * red–green–blue color cube. Robert Hess's article "[The Safety
     *   Palette](https://learn.microsoft.com/en-us/previous-versions/ms976419(v=msdn.10))",
     * 1996, described the advantage that images that use only colors in this
     * palette won't dither when displayed by Web browsers on displays that can
     * show up to 256 colors at once. (See also
     * [**Wikipedia**](http://en.wikipedia.org/wiki/Web_colors). Dithering is the
     * scattering of colors in a limited set to simulate colors outside that set.)
     * Each entry in the list consists of a color swatch and the corresponding HTML
     * name (see next question).</p> <p>A.get(second
     * list)(https://peteroupc.github.io/html3dutil/colornames.svg) shows the
     * colors defined in the.get(**CSS3 Color Module section
     * 4**)(https://www.w3.org/TR/css3-color/#colorunits), as well as the
     * newly-added name {@code rebeccapurple}. Where {@code gray} is part of a
     * name, it can be replaced with {@code grey}. Next to the name of each color
     * in the list, the color's HTML notation is shown.</p> <p>**What is the syntax
     * for HTML colors?** The notation employed in the "safety palette" in the
     * preceding section is HTML's way to define colors. The notation expresses a
     * hexadecimal (base-16) color. Take {@code #ff80cc} as an example. The color
     * defined is a carnation pink. There are four parts to this example:</p> <p>1.
     * The {@code #} identifies this code as a color.</p> <p>2. The {@code ff} is
     * two letters and/or digits that show the red component of the color. This is
     * a so-called hexadecimal number, or base-16 number. Each digit of this number
     * can range from 0 to 9 and from A to F, with 0 being the lowest digit, and F
     * being the highest digit. The highest two-digit value is 00, and the lowest
     * two-digit value is FF (255). (The digits A-F may appear in uppercase or
     * lowercase.)</p> <p>3. The {@code 80} is a base-16 number showing the color’s
     * green component.</p> <p>4. The {@code cc} is a base-16 number showing the
     * color’s blue component.</p> <p>The notation may also include an additional
     * base-16 number, as in this example: {@code #ac80ccff}. Here, the last {@code
     * ff} shows the color's alpha component (see _What is an alpha component?_,
     * later). Two shortened notations are supported: colors with only three or
     * four base-16 digits are the same as their expanded six-digit or eight-digit
     * form, respectively. For example, {@code #f8c} is the same as {@code #ff88cc}
     * ; and {@code #f8ce}, {@code #ff88ccee}.</p> <p>**How do I make HTML
     * colors?** Look at the following table that shows some of the values possible
     * for the red, green, and blue components of some colors.</p> <p>Red.. 00 10
     * 20 30 40 50 60 70 80 90 A0 B0 C0 D0 E0 F0 FF.</p> <p>Green 00 10 20 30 40 50
     * 60 70 80 90 A0 B0 C0 D0 E0 F0 FF.</p> <p>Blue. 00 10 20 30 40 50 60 70 80 90
     * A0 B0 C0 D0 E0 F0 FF.</p> <p>Now, to make a custom color, you choose one
     * value from the red row, one value from the green row, and one value from the
     * blue row. Each value shows the intensity of the "light" that the color
     * ideally reflects. For example, a red value of 00 means that, ideally, "red
     * light" is not reflected, and a red value of FF, fully reflected.</p> <p>If
     * you choose the same value in all three rows, the result is black (if you
     * choose 00), white (if you choose FF) or a shade of gray. This shows that
     * "red light", "green light", and "blue light" are ideally equally
     * reflected.</p> <p>After you choose the three values, combine them by writing
     * the {@code #}, then the red value, then the green value, then the blue
     * value. For example, if you choose {@code FF} for red, {@code A0} for green,
     * and {@code 00} for blue, write the resulting color (orange) like this:
     * {@code #FFA000}.</p> <p>**How do I "darken" an HTML color?** To "darken" a
     * color (make a _shade_ of it), consult the table shown in the question _How
     * do I make HTML colors?_, earlier, and move each component (red, green, and
     * blue) the same number of steps to the left. If you can’t move a component
     * that far to the left, that component becomes 00. For example, to make a
     * "darker" sky blue, start with 00, FF, and FF for red, green, and blue. When
     * we move these components ten steps to the left, we get 00, 60, and 60. The
     * final color becomes #006060.</p> <p>**How do I "lighten" an HTML color?**
     * "Lightening" a color (making a _tint_ of it) is almost the same as
     * "darkening" a color, except we move the same number of steps to the right
     * rather than the left. If you can’t move a component that far to the right,
     * that component becomes FF. For example, to make a "lighter" red, start with
     * FF, 00, and 00 for red, green, and blue. When we move these components ten
     * steps to the right, we get FF, A0, and A0. The final color becomes
     * #FFA0A0.</p> <p>**How do I "desaturate" an HTML color?** To make a
     * "desaturated" ("washed-out") version (or *tone*) of a color, move the color
     * components closer to each other, in about the same proportion. (If they’re
     * exactly the same, the result is a shade of gray.) For example, to make a
     * "washed-out" red, start with FF, 00, and 00 for red, green, and blue. When
     * we move these components closer to each other, we get C0, 40, and 40. The
     * final color becomes #C04040.</p> <p>**What is RGB notation?** A color in RGB
     * notation contains the same information as an HTML color, except that each
     * value is shown in the familiar base-10 format. For example, the value {@code
     * rgb(192, 64, 0)} is the same as the HTML color value {@code #C04000}.</p>
     * <p>The components of the RGB color (red, green, and blue, in that order) can
     * range from {@code 0} to {@code 255}, or from {@code 0%} to {@code 100%}, but
     * mixing ranges is not allowed. For example, {@code rgb(192, 64, 0)} and
     * {@code rgb(80%, 50%, 0%)} are allowed, but not {@code rgb(192, 50%, 0%)}.
     * The steps for "darkening", "lightening", and "desaturating" RGB colors are
     * largely the same as with HTML colors. Another syntax for RGB colors supports
     * the alpha component (see _What is an alpha component?_, later): in the
     * example {@code rgba(192, 64, 0, 0.5)}, the {@code 0.5} is the alpha
     * component. This component supports either range for RGB colors, either 0-255
     * or percentages. (Note that the example starts with {@code rgba}, not just
     * {@code rgb}.)</p> <p>**What is HSL notation?** A color in HSL notation is
     * made of the following three components:</p> <p>1. _Hue_ ranges from 0 to 360
     * degrees. Each angle on the color wheel (which looks more like a hexagon than
     * like a circle in HSL) stands for a different hue: red, yellow, green, cyan
     * (sky-blue), blue, and magenta correspond roughly to hue 0 (say, 12 o’clock),
     * 60, 120, 180, 240, and 300, respectively.</p> <p>2. "Saturation", which
     * ranges from 0% to 100%, is the distance of the color from gray (0% means
     * gray; 100% means most distant from gray).</p> <p>3. "Lightness", which
     * likewise ranges from 0% to 100%, is roughly the amount of black or white
     * mixed with the color (0% means black; 100% means white; closer to 0% means
     * closer to black; closer to 100% means closer to white).</p> <p>**Example:**
     * The value {@code hsl(240, 100%, 50%)} has a hue of 240 (blue), a
     * "saturation" of 100% ("fully saturated"), and a "lightness" of 50% (as far
     * from "black" as from "white"). It represents a vivid blue. If we lower
     * "lightness" to 20%, we get a "darker" blue. If we also change the hue to 0,
     * we get a "dark" red.</p> <p>An alternative syntax for HSL colors supports
     * the alpha component (see next question): in the example {@code hsla(240,
     * 100%, 50%, 80%)}, the {@code 80%} is the alpha component.</p> <p>**What is
     * an alpha component?** An alpha component shows how much the color is
     * transparent (see-through) or opaque. The alpha component can range from
     * {@code 00} / {@code 0.0}, or "fully transparent" (completely invisible), to
     * {@code FF} / {@code 1.0}, or "fully opaque" (letting nothing through it). If
     * a color notation doesn't provide for an alpha component, the color is fully
     * opaque.</p>
     * @return An array containing four elements, with the red, green, blue, and
     * alpha components of the same color, each from 0 to 255. Returns null if
     * {@code colorString} is null, empty, or has invalid syntax.
     */
    public static double[] ColorToRgba(String colorString) {
      String x = colorString;
      if (((x) == null || (x).length() == 0)) {
        return null;
      }
      x = TrimAsciiWhite(x);
      x = ToLowerCaseAscii(x);
      if (x.equals("transparent")) {
        return new double[] { 0, 0, 0, 0 };
      }
      if (((x) == null || (x).length() == 0)) {
        return null;
      }
      double ret = new double[4];
      if (x.charAt(0) == '#') {
        if (RgbHex(x, ret, true)) {
          return ret;
        }
      }
      if (x.length() > 4 && x.substring(0,4).equals("rgb(")) {
        return (Rgb(x, 4, x.length(), ret) == x.length()) ?
          ret : null;
      }
      if (x.length() > 5 && x.substring(0,5).equals("rgba(")) {
        return (Rgba(x, 5, x.length(), ret) == x.length()) ?
          ret : null;
      }
      if (x.length() > 4 && x.substring(0,4).equals("hsl(")) {
        return (Hsl(x, 4, x.length(), ret) == x.length()) ?
          ret : null;
      }
      if (x.length() > 5 && x.substring(0,5).equals("hsla(")) {
        return (Hsla(x, 5, x.length(), ret) == x.length()) ?
          ret : null;
      }
      HashMap<String, String> colors = ColorToRgbaSetUpNamedColors();
      if (colors.containsKey(x)) {
        String colorValue = colors.get(x);
        RgbHex(colorValue, ret, false);
        return ret;
      }
      return null;
    }

    private static volatile HashMap<String, String>
    namedColorMap;

    private static Object syncRoot = new Object();

    private static String[] nc = new String[] {
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
      "powderblue", "b0e0e6", "purple", "800080", "rebeccapurple",
      "663399", "red", "ff0000",
      "rosybrown", "bc8f8f", "royalblue", "4169e1",
      "saddlebrown", "8b4513", "salmon", "fa8072", "sandybrown",
      "f4a460", "seagreen", "2e8b57", "seashell", "fff5ee", "sienna",
      "a0522d", "silver", "c0c0c0", "skyblue", "87ceeb", "slateblue",
      "6a5acd", "slategray", "708090", "snow", "fffafa",
      "springgreen",
      "00ff7f", "steelblue", "4682b4", "tan", "d2b48c", "teal",
      "008080", "thistle", "d8bfd8", "tomato", "ff6347", "turquoise",
      "40e0d0", "violet", "ee82ee", "wheat", "f5deb3", "white",
      "ffffff",
      "whitesmoke", "f5f5f5", "yellow", "ffff00", "yellowgreen", "9acd32",
    };

    private static HashMap<String, String> ColorToRgbaSetUpNamedColors() {
      if (namedColorMap == null) {
        synchronized (syncRoot) {
          if (namedColorMap == null) {
            HashMap<String, String> ncm = new HashMap<String, String>();
            for (int i = 0; i < nc.length; i += 2) {
              ncm.put(nc[i], nc[i + 1]);
            }
            // "Grey" aliases for "gray" colors
            ncm.put("grey", ncm.get("gray"));
            ncm.put("darkgrey", ncm.get("darkgray"));
            ncm.put(
              "darkslategrey",
              ncm.get("darkslategray"));

            ncm.put("dimgrey", ncm.get("dimgray"));
            ncm.put(
              "lightgrey",
              ncm.get("lightgray"));
            ncm.put(
              "lightslategrey",
              ncm.get("lightslategray"));
            ncm.put(
              "slategrey",
              ncm.get("slategray"));
            namedColorMap = ncm;
          }
        }
      }
      return namedColorMap;
    }

    private static String RoundedString(double r) {
      r = StrictMath.round(r);
      return Double.toString((double)r);
    }

    /**
     * Converts an RGBA color to a string, either rgb(...) or rgba(...) as
     * applicable.
     * @param arrayRGB A 3- or 4-item array containing the intensity of red, green,
     * and blue (each from 0-255), with optional alpha (0-255).
     * @return A text string.
     * @throws NullPointerException The parameter {@code arrayRGB} is null.
     */
    public static String RgbToColor(double[] arrayRGB) {
      if (arrayRGB == null) {
        throw new NullPointerException("arrayRGB");
      }
      if (arrayRGB.length < 3) {
        throw new IllegalArgumentException("3 more than " + arrayRGB.length +
          " (3)");
      }
      // we should include the spaces
      if ((arrayRGB.length > 3 && (arrayRGB[3] == 255.0)) ||
        arrayRGB.length == 3) {
        return "rgb(" + RoundedString(arrayRGB[0]) + ", " +
          RoundedString(arrayRGB[1]) + ", " + RoundedString(arrayRGB[2]) + ")";
      }
      double prec = StrictMath.round(
          (arrayRGB[3] / 255.0) * 100.0) / 100.0;
      return "rgba(" + RoundedString(arrayRGB[0]) + ", " +
        RoundedString(arrayRGB[1]) + ", " + RoundedString(arrayRGB[2]) + ", " +
        Double.toString((double)prec) + ")";
    }

    /**
     * Converts a red–green–blue-alpha color to a string in CSS format.
     * @param rgb An array containing three or four elements, with the red, green,
     * blue, and alpha components of the color, each from 0 to 255. Each element's
     * value is adjusted to 0 if it's less than 0 and to 255 if it's greater than
     * 255 (the array itself is not modified, though).
     * @return A string in HTML color format: "#RRGGBB", if there are three
     * elements or the fourth value in the array is 255, or a string in the RGBA
     * color format otherwise.
     * @throws IllegalArgumentException The parameter {@code rgb} is null or contains
     * fewer than three elements.
     * @throws NullPointerException The parameter {@code rgb} is null.
     */
    public static String RgbToColorDisplay(double[] rgb) {
      if (rgb == null) {
        throw new NullPointerException("rgb");
      }
      if (rgb.length < 3) {
        throw new IllegalArgumentException("3 more than " + rgb.length +
          " (3)");
      }
      if (rgb.length == 3 || (rgb.length > 3 && rgb[3] == 255)) {
        return RgbToColorHtml(rgb);
      } else {
        return RgbToColor(rgb).replace(" ", "");
      }
    }

    private static String valueHexArray = "0123456789abcdef";

    /**
     * Converts an RGBA color to an HTML color, (ex. #002233)."rgb" must contain at
     * least 3 elements: the red, green, and blue (each 0-255).
     * @param rgb A double[] object.
     * @return A text string.
     * @throws NullPointerException The parameter {@code rgb} is null.
     */
    public static String RgbToColorHtml(double[] rgb) {
      if (rgb == null) {
        throw new NullPointerException("rgb");
      }
      if (rgb.length < 3) {
        throw new IllegalArgumentException("3 more than " + rgb.length +
          "(3)");
      }
      StringBuilder sb = new StringBuilder();
      int c, d;
      for (int i = 0; i < 3; ++i) {
        d = (int)StrictMath.round(rgb[i]);
        c = d < 0 ? 0 : (d > 255 ? 255 : d);
        sb.append(valueHexArray.charAt((c >> 4) & 15));
        sb.append(valueHexArray.charAt(c & 15));
      }
      return sb.toString();
    }
  }
