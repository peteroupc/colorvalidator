/*
Written in 2012-2016 by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under the Unlicense: https://unlicense.org/

 */
using System;
using System.Collections.Generic;
using System.Text;

namespace PeterO {
  /// <summary>Color validator.</summary>
  public static class ColorValidator {
    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int SkipWhite(string str, int index, int endIndex) {
      while (index < endIndex) {
        int c = str[index];
        if (c == 32 || c == 13 || c == 12 || c == 9 || c == 10) {
          ++index;
        } else {
          break;
        }
      }
      return index;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int ParseComma(string str, int index, int endIndex) {
      int indexStart = index;
      index = SkipWhite(str, index, endIndex);
      if (index < endIndex && (str[index] == 44)) {
        return SkipWhite(str, index + 1, endIndex);
      } else {
        return indexStart;
      }
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int ParseEndparen(string str, int index, int endIndex) {
      int indexStart = index;
      index = SkipWhite(str, index, endIndex);
      if (index < endIndex && (str[index] == 41)) {
        return index + 1;
      } else {
        return indexStart;
      }
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <param name='ret'>A 64-bit floating-point number.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int Hsl(
      string str,
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

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <param name='ret'>The parameter <paramref name='ret'/> is a
    /// Double[] object.</param>
    /// <param name='retIndex'>The parameter <paramref name='retIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int Pct(
      string str,
      int index,
      int endIndex,
      double[] ret,
      int retIndex) {
      int tx2 = ParseNumber(str, index, endIndex);
      if (tx2 != index) {
        if (tx2 >= endIndex || str[tx2] != 37) {
          return index;
        }
        ret[retIndex] = StringToPercent(str, index, tx2) * 255.0 /
          100.0;
        return tx2 + 1;
      }
      return tx2;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <param name='ret'>The parameter <paramref name='ret'/> is a
    /// Double[] object.</param>
    /// <param name='retIndex'>The parameter <paramref name='retIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int ParseByte(
      string str,
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

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <param name='ret'>The parameter <paramref name='ret'/> is a
    /// Double[] object.</param>
    /// <param name='retIndex'>The parameter <paramref name='retIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int ParseHue(
      string str,
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

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <param name='ret'>The parameter <paramref name='ret'/> is a
    /// Double[] object.</param>
    /// <param name='retIndex'>The parameter <paramref name='retIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int SepByte(
      string str,
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

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <param name='ret'>The parameter <paramref name='ret'/> is a
    /// Double[] object.</param>
    /// <param name='retIndex'>The parameter <paramref name='retIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int SepPct(
      string str,
      int index,
      int endIndex,
      double[] ret,
      int retIndex) {
      int tx2 = ParseComma(str, index, endIndex);
      return (tx2 != index) ? Pct(str, tx2, endIndex, ret, retIndex) : tx2;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <param name='ret'>The parameter <paramref name='ret'/> is a
    /// Double[] object.</param>
    /// <param name='retIndex'>The parameter <paramref name='retIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int SepAlpha(
      string str,
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

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <param name='ret'>A 64-bit floating-point number.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int Hsla(
      string str,
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

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <param name='result'>A 64-bit floating-point number.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int Rgba(
      string str,
      int index,
      int endIndex,
      double[] result) {
      int indexStart, tx2;
      indexStart = index;
      index = SkipWhite(str, index, endIndex);
      int st = index;
      var continuing = true;
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

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <param name='result'>The parameter <paramref name='result'/> is a
    /// Double[] object.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int Rgb(
      string str,
      int index,
      int endIndex,
      double[] result) {
      int indexStart, tx2;
      indexStart = index;
      index = SkipWhite(str, index, endIndex);
      int st = index;
      var continuing = true;
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

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>A 64-bit floating-point number.</returns>
    private static double StringToNumber(
      string str,
      int index,
      int endIndex) {
      string str2 = str.Substring(index, endIndex - index);
      return Convert.ToDouble(
        str2,
        System.Globalization.CultureInfo.InvariantCulture);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>A 64-bit floating-point number.</returns>
    private static double StringToPercent(
      string str,
      int index,
      int endIndex) {
      double num = StringToNumber(str, index, endIndex);
      return Double.IsNaN(num) ? (-1) : ((num < 0) ? 0 :
          ((num > 100) ? 100 : num));
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>A 64-bit floating-point number.</returns>
    private static double StringToAlpha(
      string str,
      int index,
      int endIndex) {
      double num = StringToNumber(str, index, endIndex);
      return (num < 0) ? 0 : ((num > 1.0) ? 255 : num * 255.0);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>A 64-bit floating-point number.</returns>
    private static double StringToHue(
      string str,
      int index,
      int endIndex) {
      double num = StringToNumber(str, index, endIndex);
      return (Double.IsNaN(num) || Double.IsPositiveInfinity(num) ||
          Double.IsNegativeInfinity(num)) ? 0 : (((num % 360) + 360) %
          360);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>A 64-bit floating-point number.</returns>
    private static double StringToByte(
      string str,
      int index,
      int endIndex) {
      double num = StringToNumber(str, index, endIndex);
      return (num < 0) ? 0 : ((num > 255) ? 255 : num);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <param name='posneg'>The parameter <paramref name='posneg'/> is
    /// either <c>true</c> or <c>false</c>.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int ParseInteger(
      string str,
      int index,
      int endIndex,
      bool posneg) {
      var digits = false;
      int indexStart = index;
      if (
        posneg && index < endIndex && ((str[index] == 43) ||
          (str[index] == 45))) {
        ++index;
      }
      while (index < endIndex && (str[index] >= 48 && str[index] <=
          57)) {
        ++index;
        digits = true;
      }
      return digits ? index : indexStart;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='endIndex'>The parameter <paramref name='endIndex'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int ParseNumber(string str, int index, int endIndex) {
      int indexStart = index;
      int tmp = index;
      if ((tmp = ParseInteger(str, index, endIndex, true)) !=
        indexStart) {
        index = tmp;
        if (index < endIndex && (str[index] == 46)) {
          // Dot is optional
          ++index;
          if ((tmp = ParseInteger(str, index, endIndex, false)) !=
            index) {
            var tmp2 = 0;
            return (
                index < endIndex && (str[index] == 0x45 || str[index] ==
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
        if (index < endIndex && ((str[index] == 43) || (str[index] ==
              45))) {
          ++index;
        }
        if (index < endIndex && (str[index] == 46)) {
          // Dot is required
          ++index;
          if ((tmp = ParseInteger(str, index, endIndex, false)) !=
            index) {
            var tmp2 = 0;
            return (
                index < endIndex && (str[index] == 0x45 || str[index] ==
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

    /// <summary>Converts a color in the HLS color space to red/green/blue.
    /// Hue can range from 0 to 360, and lightness and saturation can range
    /// from 0 to 255. If lightness and saturation are out of range, those
    /// values are clamped to fit that range.</summary>
    /// <param name='hueval'>The parameter <paramref name='hueval'/> is a
    /// 64-bit floating-point number.</param>
    /// <param name='lum'>The parameter <paramref name='lum'/> is a 64-bit
    /// floating-point number.</param>
    /// <param name='sat'>The parameter <paramref name='sat'/> is a 64-bit
    /// floating-point number.</param>
    /// <returns>An array containing three elements, with the red, green,
    /// and blue components of the same color, each from 0 to
    /// 255.</returns>
    /// <exception cref='ArgumentNullException'>The parameter "hls" is
    /// null.</exception>
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

    /// <summary>Not documented yet.</summary>
    /// <param name='c'>The parameter <paramref name='c'/> is a 32-bit
    /// signed integer.</param>
    /// <returns>A 32-bit signed integer.</returns>
    private static int Dehexchar(int c) {
      if (c >= '0' && c <= '9') {
        return c - 0x30;
      }
      return (c >= 'A' && c <= 'F') ? (c + 10 - 0x41) : ((c >= 'a' && c
            <= 'f') ? (c + 10 - 0x61) : (-1));
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <returns>A text string.</returns>
    private static string ToLowerCaseAscii(string str) {
      if (str == null) {
        return null;
      }
      var len = str.Length;
      var c = (char)0;
      var hasUpperCase = false;
      for (var i = 0; i < len; ++i) {
        c = str[i];
        if (c >= 0x41 && c <= 0x5a) {
          hasUpperCase = true;
          break;
        }
      }
      if (!hasUpperCase) {
        return str;
      }
      var builder = new StringBuilder();
      for (var i = 0; i < len; ++i) {
        c = str[i];
        if (c >= 0x41 && c <= 0x5a) {
          builder.Append((char)(c + 0x20));
        } else {
          builder.Append(c);
        }
      }
      return builder.ToString();
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <returns>A text string.</returns>
    private static string TrimAsciiWhite(string str) {
      if (String.IsNullOrEmpty(str)) {
        return str;
      }
      var index = 0;
      int valueSLength = str.Length;
      while (index < valueSLength) {
        char c = str[index];
        if (c != 0x09 && c != 0x20 && c != 0x0c && c != 0x0d && c !=
          0x0a) {
          break;
        }
        ++index;
      }
      if (index == valueSLength) {
        return String.Empty;
      }
      int indexStart = index;
      index = str.Length - 1;
      while (index >= 0) {
        char c = str[index];
        if (c != 0x09 && c != 0x20 && c != 0x0c && c != 0x0d && c !=
          0x0a) {
          int indexEnd = index + 1;
          if (indexEnd == indexStart) {
            return String.Empty;
          }
          return (indexEnd == str.Length && indexStart == 0) ? str :
            str.Substring(indexStart, indexEnd - indexStart);
        }
        --index;
      }
      return String.Empty;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    /// <param name='hexval'>The parameter <paramref name='hexval'/> is a
    /// Double[] object.</param>
    /// <param name='hash'>The parameter <paramref name='hash'/> is either
    /// <c>true</c> or <c>false</c>.</param>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
    private static bool RgbHex(string str, double[] hexval, bool hash) {
      if (String.IsNullOrEmpty(str)) {
        return false;
      }
      int slen = str.Length;
      var hexes = new int[8];
      var index = 0;
      var hexIndex = 0;
      if (str[0] == '#') {
        --slen;
        ++index;
      } else if (hash) {
        return false;
      }
      if (slen != 3 && slen != 4 && slen != 6 && slen != 8) {
        return false;
      }
      for (int i = index; i < str.Length; ++i) {
        int hex = Dehexchar(str[i]);
        if (hex < 0) {
          return false;
        }
        hexes[hexIndex++] = hex;
      }
      if (slen == 4) {
        hexval[3] = (double)(hexes[3] | (hexes[3] << 4));
      } else if (slen == 8) {
        hexval[3] = (double)(hexes[7] | (hexes[6] << 4));
      } else {
        hexval[3] = 255.0;
      }
      if (slen == 3 || slen == 4) {
        hexval[0] = (double)(hexes[0] | (hexes[0] << 4));
        hexval[1] = (double)(hexes[1] | (hexes[1] << 4));
        hexval[2] = (double)(hexes[2] | (hexes[2] << 4));
      } else if (slen >= 6) {
        hexval[0] = (double)(hexes[1] | (hexes[0] << 4));
        hexval[1] = (double)(hexes[3] | (hexes[2] << 4));
        hexval[2] = (double)(hexes[5] | (hexes[4] << 4));
      }
      return true;
    }

    /// <summary>Converts an HTML or CSS color string to a 4-element RGB
    /// array.</summary>
    /// <param name='x'>
    /// <para>A string which names a color. The letters in the string can
    /// be in any combination of basic upper-case letters A to Z (U+0041 to
    /// U+005A) and basic lower-case letters. The string can begin with any
    /// combination of white space characters (U+0009, U+000A, U+000C,
    /// U+000D, U+0020), can end with any combination of those characters,
    /// or both.</para>
    /// <para>**What colors can I use?** You can use values like the
    /// following as color strings.</para>
    /// <list><item>CSS color names (from the CSS3 Color Module):
    /// <c>red</c>
    ///  , <c>blue</c>
    ///  , <c>silver</c>
    ///  , <c>fuchsia</c>
    ///  ,
    /// <c>darkslateblue</c>
    /// .</item>
    ///  <item>HTML hexadecimal (base-16)
    /// colors: <c>#223344</c>
    ///  , <c>#234</c>
    ///  , <c>#234F</c>
    ///  , or
    /// <c>#223344FF</c>
    /// . (See _What is the syntax for HTML
    /// colors?_)</item>
    ///  <item>RGB notation: <c>rgb(20, 30, 40)</c>
    ///  or
    /// <c>rgba(20, 30, 40, 50%)</c>
    /// . (See _What is RGB notation?_,
    /// later.)</item>
    ///  <item>HSL notation: <c>hsl(200, 100%, 50%)</c>
    ///  or
    /// <c>hsla(200, 100%, 50%, 80%</c>
    /// . (See _What is HSL notation?_,
    /// later.)</item>
    ///  <item>The newly-added color name
    /// <c>rebeccapurple</c>
    /// .</item>
    ///  <item>The word <c>transparent</c>
    ///  ,
    /// meaning a fully-transparent color.</item>
    ///  </list>
    /// <para>**What do some colors look like?** Consult a [list of useful
    /// colors sorted by hue or color
    /// tone](https://peteroupc.github.io/html3dutil/websafe.svg). This
    /// particular list was historically called the "Web safe" colors or
    /// the "safety palette", and consists of 216 colors that are uniformly
    /// spaced in the red&#x2013;green&#x2013;blue color cube. Robert
    /// Hess's article "[The Safety
    /// Palette](https://learn.microsoft.com/en-us/previous-versions/ms976419(v=msdn.10))",
    /// 1996, described the advantage that images that use only colors in
    /// this palette won't dither when displayed by Web browsers on
    /// displays that can show up to 256 colors at once. (See also
    /// [**Wikipedia**](http://en.wikipedia.org/wiki/Web_colors). Dithering
    /// is the scattering of colors in a limited set to simulate colors
    /// outside that set.) Each entry in the list consists of a color
    /// swatch and the corresponding HTML name (see next question).</para>
    /// <para>A [second
    /// list](https://peteroupc.github.io/html3dutil/colornames.svg) shows
    /// the colors defined in the [**CSS3 Color Module section
    /// 4**](http://www.w3.org/TR/css3-color/#colorunits), as well as the
    /// newly-added name <c>rebeccapurple</c>
    ///  . Where <c>gray</c>
    ///  is part
    /// of a name, it can be replaced with <c>grey</c>
    ///  . Next to the name
    /// of each color in the list, the color's HTML notation is
    /// shown.</para>
    /// <para>**What is the syntax for HTML colors?** The notation employed
    /// in the "safety palette" in the preceding section is HTML's way to
    /// define colors. The notation expresses a hexadecimal (base-16)
    /// color. Take <c>#ff80cc</c>
    ///  as an example. The color defined is a
    /// carnation pink. There are four parts to this example:</para>
    /// <list><item>The <c>#</c>
    ///  identifies this code as a color.</item>
    /// <item>The <c>ff</c>
    ///  is two letters and/or digits that show the red
    /// component of the color. This is a so-called hexadecimal number, or
    /// base-16 number. Each digit of this number can range from 0-9 and
    /// from A-F, with 0 being the lowest digit, and F being the highest
    /// digit. The highest two-digit value is 00, and the lowest two-digit
    /// value is FF (256). (The digits A-F may appear in upper or lower
    /// case.)</item>
    ///  <item>The <c>80</c>
    ///  is a base-16 number showing the
    /// color&#8217;s green component.</item>
    ///  <item>The <c>cc</c>
    ///  is a
    /// base-16 number showing the color&#8217;s blue component.</item>
    /// </list>
    /// <para>The notation may also include an additional base-16 number,
    /// as in this example: <c>#ac80ccff</c>
    /// . Here, the last <c>ff</c>
    /// shows the color's alpha component (see _What is an alpha
    /// component?_, later). Two shortened notations are supported: colors
    /// with only three or four base-16 digits are the same as their
    /// expanded six-digit or eight-digit form, respectively. For example,
    /// <c>#f8c</c>
    ///  is the same as <c>#ff88cc</c>
    ///  ; and <c>#f8ce</c>
    ///  ,
    /// <c>#ff88ccee</c>
    /// .</para>
    /// <para>**How do I make HTML colors?** Look at the table below that
    /// shows some of the values possible for the red, green, and blue
    /// components of some colors.</para>
    /// <code>
    /// Red.. 00 10 20 30 40 50 60 70 80 90 A0 B0 C0 D0 E0 F0 FF
    /// Green 00 10 20 30 40 50 60 70 80 90 A0 B0 C0 D0 E0 F0 FF
    /// Blue. 00 10 20 30 40 50 60 70 80 90 A0 B0 C0 D0 E0 F0 FF</code>
    /// <para>Now, to make a custom color, you choose one value from the
    /// red row, one value from the green row, and one value from the blue
    /// row. Each value shows the intensity of the "light" that the color
    /// ideally reflects. For example, a red value of 00 means that,
    /// ideally, "red light" is not reflected, and a red value of FF, fully
    /// reflected.</para>
    /// <para>If you choose the same value in all three rows, the result is
    /// black (if you choose 00), white (if you choose FF) or a shade of
    /// gray. This shows that "red light", "green light", and "blue light"
    /// are ideally equally reflected.</para>
    /// <para>After you choose the three values, combine them by writing
    /// the <c>#</c>
    ///  , then the red value, then the green value, then the
    /// blue value. For example, if you choose <c>FF</c>
    ///  for red, <c>A0</c>
    /// for green, and <c>00</c>
    ///  for blue, write the resulting color
    /// (orange) like this: <c>#FFA000</c>
    /// .</para>
    /// <para>**How do I "darken" an HTML color?** To darken a color (make
    /// a * shade* of it), consult the table shown in the question _How do
    /// I make HTML colors?_, earlier, and move each component (red, green,
    /// and blue) the same number of steps to the left. If you can&#8217;t
    /// move a component that far to the left, that component becomes 00.
    /// For example, to make a "darker" sky blue, start with 00, FF, and FF
    /// for red, green, and blue. When we move these components ten steps
    /// to the left, we get 00, 60, and 60. The final color becomes
    /// #006060.</para>
    /// <para>**How do I "lighten" an HTML color?** "Lightening" a color
    /// (making a *tint* of it) is almost the same as "darkening" a color,
    /// except we move the same number of steps to the right rather than
    /// the left. If you can&#8217;t move a component that far to the
    /// right, that component becomes FF. For example, to make a "lighter"
    /// red, start with FF, 00, and 00 for red, green, and blue. When we
    /// move these components ten steps to the right, we get FF, A0, and
    /// A0. The final color becomes #FFA0A0.</para>
    /// <para>**How do I "desaturate" an HTML color?** To make a
    /// "desaturated" ("washed-out") version (or *tone*) of a color, move
    /// the color components closer to each other, in about the same
    /// proportion. (If they&#8217;re exactly the same, the result is a
    /// shade of gray.) For example, to make a "washed-out" red, start with
    /// FF, 00, and 00 for red, green, and blue. When we move these
    /// components closer to each other, we get C0, 40, and 40. The final
    /// color becomes #C04040.</para>
    /// <para>**What is RGB notation?** A color in RGB notation contains
    /// the same information as an HTML color, except that each value is
    /// shown in the familiar base-10 format. For example, the value
    /// <c>rgb(192, 64, 0)</c>
    ///  is the same as the HTML color value
    /// <c>#C04000</c>
    /// .</para>
    /// <para>The components of the RGB color (red, green, and blue, in
    /// that order) can range from <c>0</c>
    ///  to <c>255</c>
    ///  , or from
    /// <c>0%</c>
    ///  to <c>100%</c>
    ///  , but mixing ranges is not allowed. For
    /// example, <c>rgb(192, 64, 0)</c>
    ///  and <c>rgb(80%, 50%, 0%)</c>
    ///  are
    /// allowed, but not <c>rgb(192, 50%, 0%)</c>
    ///  . The steps for
    /// "darkening", "lightening", and "desaturating" RGB colors are pretty
    /// much the same as with HTML colors. Another syntax for RGB colors
    /// supports the alpha component (see _What is an alpha component?_,
    /// later): in the example <c>rgba(192, 64, 0, 0.5)</c>
    ///  , the
    /// <c>0.5</c>
    ///  is the alpha component. This component supports either
    /// range for RGB colors, either 0-255 or percentages. (Note that the
    /// example starts with <c>rgba</c>
    ///  , not just <c>rgb</c>
    ///  .)</para>
    /// <para>**What is HSL notation?** A color in HSL notation is made of
    /// the following three components:</para>
    /// <list><item>_Hue_ ranges from 0 to 360 degrees. Each angle on the
    /// color wheel (which looks more like a hexagon than like a circle in
    /// HSL) stands for a different hue: red, yellow, green, cyan
    /// (sky-blue), blue, and magenta correspond roughly to hue 0 (say, 12
    /// o&#8217;clock), 60, 120, 180, 240, and 300, respectively.</item>
    /// <item>"Saturation" and "lightness" range from 0% to 100%.
    /// "Saturation" is the distance of the color from gray (0% means gray;
    /// 100% means most distant from gray). "Lightness" is roughly the
    /// amount of black or white mixed with the color (0% means black; 100%
    /// means white; closer to 0% means closer to black; closer to 100%
    /// means closer to white).</item>
    ///  </list>
    /// <para>**Example:** The value <c>hsl(240, 100%, 50%)</c>
    ///  has a hue
    /// of 240 (blue), a "saturation" of 100% (fully saturated), and a
    /// "lightness" of 50% (as far from "black" as from "white"). It
    /// represents a vivid blue. If we lower "lightness" to 20%, we get a
    /// "darker" blue. If we also change the hue to 0, we get a "dark"
    /// red.</para>
    /// <para>An alternate syntax for HSL colors supports the alpha
    /// component (see next question): in the example <c>hsla(240, 100%,
    /// 50%, 80%)</c>
    ///  , the <c>80%</c>
    ///  is the alpha component.</para>
    /// <para>**What is an alpha component?** An alpha component shows how
    /// much the color is transparent (see-through) or opaque. The alpha
    /// component can range from <c>00</c>
    ///  / <c>0.0</c>
    ///  , or "fully
    /// transparent" (completely invisible), to <c>FF</c>
    ///  / <c>1.0</c>
    ///  , or
    /// "fully opaque" (letting nothing through it). If a color notation
    /// doesn't provide for an alpha component, the color is fully
    /// opaque.</para>
    ///  .
    /// </param>
    /// <returns>An array containing four elements, with the red, green,
    /// blue, and alpha components of the same color, each from 0 to 255.
    /// Returns null if <paramref name='x'/> is null, empty, or has invalid
    /// syntax.</returns>
    public static double[] ColorToRgba(string x) {
      if (String.IsNullOrEmpty(x)) {
        return null;
      }
      x = TrimAsciiWhite(x);
      x = ToLowerCaseAscii(x);
      if (x.Equals("transparent", StringComparison.Ordinal)) {
        return new double[] { 0, 0, 0, 0 };
      }
      if (String.IsNullOrEmpty(x)) {
        return null;
      }
      var ret = new double[4];
      if (x[0] == '#') {
        if (RgbHex(x, ret, true)) {
          return ret;
        }
      }
      if (x.Length > 4 && x.Substring(0, 4).Equals("rgb(",
          StringComparison.Ordinal)) {
        return (Rgb(x, 4, x.Length, ret) == x.Length) ?
          ret : null;
      }
      if (x.Length > 5 && x.Substring(0, 5).Equals("rgba(",
          StringComparison.Ordinal)) {
        return (Rgba(x, 5, x.Length, ret) == x.Length) ?
          ret : null;
      }
      if (x.Length > 4 && x.Substring(0, 4).Equals("hsl(",
          StringComparison.Ordinal)) {
        return (Hsl(x, 4, x.Length, ret) == x.Length) ?
          ret : null;
      }
      if (x.Length > 5 && x.Substring(0, 5).Equals("hsla(",
          StringComparison.Ordinal)) {
        return (Hsla(x, 5, x.Length, ret) == x.Length) ?
          ret : null;
      }
      Dictionary<string, string> colors = ColorToRgbaSetUpNamedColors();
      if (colors.ContainsKey(x)) {
        string colorValue = colors[x];
        RgbHex(colorValue, ret, false);
        return ret;
      }
      return null;
    }

    private static volatile Dictionary<string, string>
    namedColorMap;

    private static object syncRoot = new Object();

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

    private static Dictionary<string, string> ColorToRgbaSetUpNamedColors() {
      if (namedColorMap == null) {
        lock (syncRoot) {
          if (namedColorMap == null) {
            var ncm = new Dictionary<string, string>();
            for (int i = 0; i < nc.Length; i += 2) {
              ncm.Add(nc[i], nc[i + 1]);
            }
            // "Grey" aliases for "gray" colors
            ncm.Add("grey", ncm["gray"]);
            ncm.Add("darkgrey", ncm["darkgray"]);
            ncm.Add(
              "darkslategrey",
              ncm["darkslategray"]);

            ncm.Add("dimgrey", ncm["dimgray"]);
            ncm.Add(
              "lightgrey",
              ncm["lightgray"]);
            ncm.Add(
              "lightslategrey",
              ncm["lightslategray"]);
            ncm.Add(
              "slategrey",
              ncm["slategray"]);
            namedColorMap = ncm;
          }
        }
      }
      return namedColorMap;
    }

    private static string RoundedString(double r) {
      r = Math.Round(r, MidpointRounding.AwayFromZero);
      return Convert.ToString(
          (double)r,
          System.Globalization.CultureInfo.InvariantCulture);
    }

    /// <summary>Converts an RGBA color to a string, either rgb(...) or
    /// rgba(...) as applicable.</summary>
    /// <param name='arrayRGB'>A 3- or 4-item array containing the
    /// intensity of red, green, and blue (each from 0-255), with optional
    /// alpha (0-255).</param>
    /// <returns>A text string.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='arrayRGB'/> is null.</exception>
    public static string RgbToColor(double[] arrayRGB) {
      if (arrayRGB == null) {
        throw new ArgumentNullException(nameof(arrayRGB));
      }
      if (arrayRGB.Length < 3) {
        throw new ArgumentException("3 more than " + arrayRGB.Length +
          " (3)");
      }
      // we should include the spaces
      if ((arrayRGB.Length > 3 && (arrayRGB[3] == 255.0)) ||
        arrayRGB.Length == 3) {
        return "rgb(" + RoundedString(arrayRGB[0]) + ", " +
          RoundedString(arrayRGB[1]) + ", " + RoundedString(arrayRGB[2]) + ")";
      }
      double prec = Math.Round(
          (arrayRGB[3] / 255.0) * 100.0,
          MidpointRounding.AwayFromZero) / 100.0;
      return "rgba(" + RoundedString(arrayRGB[0]) + ", " +
        RoundedString(arrayRGB[1]) + ", " + RoundedString(arrayRGB[2]) + ", " +
        Convert.ToString(
          (double)prec,
          System.Globalization.CultureInfo.InvariantCulture) + ")";
    }

    /// <summary>Converts a red&#x2013;green&#x2013;blue-alpha color to a
    /// string in CSS format.</summary>
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
      if (rgb == null) {
        throw new ArgumentNullException(nameof(rgb));
      }
      if (rgb.Length < 3) {
        throw new ArgumentException("3 more than " + rgb.Length +
          " (3)");
      }
      if (rgb.Length == 3 || (rgb.Length > 3 && rgb[3] == 255)) {
        return RgbToColorHtml(rgb);
      } else {
        return RgbToColor(rgb).Replace(" ", String.Empty);
      }
    }

    /// <summary>Not documented yet.</summary>
    private static string valueHexArray = "0123456789abcdef";

    /// <summary>Converts an RGBA color to an HTML color, (ex.
    /// #002233).&#x22;rgb&#x22; must contain at least 3 elements: the red,
    /// green, and blue (each 0-255).</summary>
    /// <param name='rgb'>A double[] object.</param>
    /// <returns>A text string.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='rgb'/> is null.</exception>
    public static string RgbToColorHtml(double[] rgb) {
      if (rgb == null) {
        throw new ArgumentNullException(nameof(rgb));
      }
      if (rgb.Length < 3) {
        throw new ArgumentException("3 more than " + rgb.Length +
          "(3)");
      }
      var sb = new StringBuilder();
      int c, d;
      for (var i = 0; i < 3; ++i) {
        d = (int)Math.Round(rgb[i], MidpointRounding.AwayFromZero);
        c = d < 0 ? 0 : (d > 255 ? 255 : d);
        sb.Append(valueHexArray[(c >> 4) & 15]);
        sb.Append(valueHexArray[c & 15]);
      }
      return sb.ToString();
    }
  }
}
