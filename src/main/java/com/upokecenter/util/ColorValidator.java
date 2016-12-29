package com.upokecenter.util;
/*
Written in 2012-2016 by Peter O.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://peteroupc.github.io/
 */

import java.util.*;

    /**
     * Contains methods to convert between different representations of HTML and
     * CSS colors.
     */
    public final class ColorValidator {
private ColorValidator() {
}
    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @return A 32-bit signed integer.
     */
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

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @return A 32-bit signed integer.
     */
        private static int ParseComma(String str, int index, int endIndex) {
            int indexStart = index;
            index = SkipWhite(str, index, endIndex);
            if (index < endIndex && (str.charAt(index) == 44)) {
                return SkipWhite(str, index + 1, endIndex);
            } else {
                return indexStart;
            }
        }

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @return A 32-bit signed integer.
     */
        private static int ParseEndparen(String str, int index, int endIndex) {
            int indexStart = index;
            index = SkipWhite(str, index, endIndex);
            if (index < endIndex && (str.charAt(index) == 41)) {
                return index + 1;
            } else {
                return indexStart;
            }
        }

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @param ret A 64-bit floating-point number.
     * @return A 32-bit signed integer.
     */
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
                    index = indexStart; break;
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

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @param ret The parameter {@code ret} is not documented yet.
     * @param retIndex The parameter {@code retIndex} is not documented yet.
     * @return A 32-bit signed integer.
     */
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

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @param ret The parameter {@code ret} is not documented yet.
     * @param retIndex The parameter {@code retIndex} is not documented yet.
     * @return A 32-bit signed integer.
     */
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

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @param ret The parameter {@code ret} is not documented yet.
     * @param retIndex The parameter {@code retIndex} is not documented yet.
     * @return A 32-bit signed integer.
     */
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

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @param ret The parameter {@code ret} is not documented yet.
     * @param retIndex The parameter {@code retIndex} is not documented yet.
     * @return A 32-bit signed integer.
     */
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

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @param ret The parameter {@code ret} is not documented yet.
     * @param retIndex The parameter {@code retIndex} is not documented yet.
     * @return A 32-bit signed integer.
     */
        private static int SepPct(
            String str,
            int index,
            int endIndex,
            double[] ret,
            int retIndex) {
            int tx2 = ParseComma(str, index, endIndex);
            return (tx2 != index) ?
              Pct(str, tx2, endIndex, ret, retIndex) : tx2;
        }

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @param ret The parameter {@code ret} is not documented yet.
     * @param retIndex The parameter {@code retIndex} is not documented yet.
     * @return A 32-bit signed integer.
     */
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

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @param ret A 64-bit floating-point number.
     * @return A 32-bit signed integer.
     */
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
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                indexTemp = index;
            } while (false);
            return indexTemp;
        }

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @param result A 64-bit floating-point number.
     * @return A 32-bit signed integer.
     */
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

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @param result The parameter {@code result} is not documented yet.
     * @return A 32-bit signed integer.
     */
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

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @return A 64-bit floating-point number.
     */
        private static double StringToNumber(
     String str,
     int index,
     int endIndex) {
            String str2 = str.substring(index, (index)+(endIndex - index));
            return
    Double.parseDouble(str2);
        }

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @return A 64-bit floating-point number.
     */
        private static double StringToPercent(
      String str,
      int index,
      int endIndex) {
            double num = StringToNumber(str, index, endIndex);
            return Double.isNaN(num) ? (-1) :((num < 0) ? 0 :((num > 100) ?
              100 : num));
        }

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @return A 64-bit floating-point number.
     */
        private static double StringToAlpha(
    String str,
    int index,
    int endIndex) {
            double num = StringToNumber(str, index, endIndex);
            return (num < 0) ? 0 : ((num > 1.0) ? 255 : num * 255.0);
        }

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @return A 64-bit floating-point number.
     */
        private static double StringToHue(
    String str,
    int index,
    int endIndex) {
            double num = StringToNumber(str, index, endIndex);
             return (Double.isNaN(num) || ((num) == Double.POSITIVE_INFINITY) ||
           ((num) == Double.NEGATIVE_INFINITY)) ? 0 : (((num % 360) + 360) %
           360);
        }

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @return A 64-bit floating-point number.
     */
        private static double StringToByte(
    String str,
    int index,
    int endIndex) {
            double num = StringToNumber(str, index, endIndex);
            return (num < 0) ? 0 : ((num > 255) ? 255 : num);
        }

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @param posneg A Boolean object.
     * @return A 32-bit signed integer.
     */
        private static int ParseInteger(
  String str,
  int index,
  int endIndex,
  boolean posneg) {
            boolean digits = false;
            int indexStart = index;
if (posneg && index < endIndex && ((str.charAt(index) == 43) || (str.charAt(index) == 45))) {
                ++index;
            }
            while (index < endIndex && (str.charAt(index) >= 48 && str.charAt(index) <=
                57)) {
                ++index;
                digits = true;
            }
            return digits ? index : indexStart;
        }

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param index The parameter {@code index} is not documented yet.
     * @param endIndex The parameter {@code endIndex} is not documented yet.
     * @return A 32-bit signed integer.
     */
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
       return (index < endIndex && (str.charAt(index) == 0x45 || str.charAt(index) ==
  0x65) && (tmp2 = ParseInteger(str, index + 1, endIndex, true)) != index +

                1) ? tmp2 : tmp;
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
       return (index < endIndex && (str.charAt(index) == 0x45 || str.charAt(index) ==
  0x65) && (tmp2 = ParseInteger(str, index + 1, endIndex, true)) != index +

                1) ? tmp2 : tmp;
                    } else {
                    return indexStart;
                    }
                }
                return indexStart;
            }
        }

    /**
     * Converts a color in the HLS color space to red/green/blue. Hue can range
     * from 0 to 360, and lightness and saturation can range from 0 to 255.
     * If lightness and saturation are out of range, those values are
     * clamped to fit that range.
     * @param hueval The parameter {@code hueval} is not documented yet.
     * @param lum The parameter {@code lum} is not documented yet.
     * @param sat The parameter {@code sat} is not documented yet.
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
        (bl < 0 ? 0 : (bl > 255 ? 255 : bl))
      };
        }

    /**
     * Not documented yet.
     * @param c The parameter {@code c} is not documented yet.
     * @return A 32-bit signed integer.
     */
        private static int dehexchar(int c) {
            if (c >= '0' && c <= '9') {
                return c - 0x30;
            }
            return (c >= 'A' && c <= 'F') ? (c + 10 - 0x41) : ((c >= 'a' && c
              <= 'f') ? (c + 10 - 0x61) : (-1));
        }

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @return A string object.
     */
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

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @return A string object.
     */
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

    /**
     * Not documented yet.
     * @param str The parameter {@code str} is not documented yet.
     * @param hexval The parameter {@code hexval} is not documented yet.
     * @param hash The parameter {@code hash} is not documented yet.
     * @return A Boolean object.
     */
        private static boolean RgbHex(String str, double[] hexval, boolean hash) {
            if (((str) == null || (str).length() == 0)) {
                return false;
            }
            int slen = str.length();
            int[] hexes = new int[8];
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
                int hex = dehexchar(str.charAt(i));
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

    /**
     * Converts an HTML or CSS color string to a 4-element RGB array.
     * @param x A string which names a color. The following lists the kinds of
     * colors accepted: <ul> <li>HTML colors with the syntax {@code
     * #RRGGBB}, where RR is the hexadecimal form of the red component
     * (00-FF), GG is the hexadecimal green component, and BB is the
     * hexadecimal blue component. Example: #88DFE0.</li> <li>HTML colors
     * with the syntax {@code #RGB}, where R is the hexadecimal form of the
     * red component (0-F), G is the hexadecimal green component, and B is
     * the hexadecimal blue component. Example: #8DE.</li> <li>CSS colors
     * with the syntax {@code rgb(red, green, blue)} or {@code rgba(red,
     * green, blue, alpha)} where {@code red}, {@code green}, and {@code
     * blue} are the red, green, and blue components, respectively, either
     * as a number (0-255) or as a percent, and {@code alpha} is a number
     * from 0-1 specifying the alpha component. Examples: {@code rgb(255, 0,
     * 0)}, {@code rgb(100%, 50%, 0%)}, {@code rgba(20, 255, 255,
     * 0.5)}.</li> <li>CSS colors with the syntax {@code hsl(hue, sat,
     * light)} or {@code hsla(hue, sat, light, alpha)} where {@code hue} is
     * the hue component in degrees (0-360), {@code sat} and {@code light}
     * are the saturation and lightness components, respectively, as
     * percents, and {@code alpha} is a number from 0-1 specifying the alpha
     * component. Examples: {@code rgb(255, 0, 0)}, {@code hsl(200, 50%,
     * 50%)}, {@code hsla(20, 80%, 90%, 0.5)}.</li> <li>CSS colors such as
     * {@code red}, {@code green}, {@code white}, {@code lemonchiffon},
     * {@code chocolate}, and so on, including the newly added {@code
     * rebeccapurple}.</li> <li>The value {@code transparent}, meaning
     * transparent black.</li></ul> <p>For more information:
     * https://peteroupc.github.io/html3dutil/tutorial-colors.html</p> .
     * @return An array containing four elements, with the red, green, blue, and
     * alpha components of the same color, each from 0 to 255. Returns null
     * if {@code x} is null, empty, or has invalid syntax.
     */
        public static double[] ColorToRgba(String x) {
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
            double[] ret = new double[4];
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

    /**
     * Not documented yet.
     */
        private static volatile HashMap<String, String>
              namedColorMap;

    /**
     * Not documented yet.
     */
        private static Object syncRoot = new Object();

    /**
     * Not documented yet.
     */
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
          "whitesmoke", "f5f5f5", "yellow", "ffff00", "yellowgreen", "9acd32"
        };

    /**
     * Not documented yet.
     * @return A Dictionary(string, string) object.
     */
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

    /**
     * Not documented yet.
     * @param r The parameter {@code r} is not documented yet.
     * @return A string object.
     */
        private static String RoundedString(double r) {
            r = StrictMath.round(r);
            return Double.toString((double)r);
        }

    /**
     * Converts an RGBA color to a string, either rgb(...) or rgba(...) as
     * applicable.
     * @param arrayRGB A 3- or 4-item array containing the intensity of red, green,
     * and blue (each from 0-255), with optional alpha (0-255).
     * @return A string object.
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
                    RoundedString(arrayRGB[1]) + ", " +
RoundedString(arrayRGB[2]) + ")" ; } else { double prec = StrictMath.round(
  (arrayRGB [3] / 255.0) * 100.0) / 100.0;
                return "rgba(" + RoundedString(arrayRGB[0]) + ", " +
                    RoundedString(arrayRGB[1]) + ", " +
                    RoundedString(arrayRGB[2]) + ", " +
                    Double.toString((double)prec) + ")";
            }
        }

    /**
     * Converts a red-green-blue-alpha color to a string in CSS format.
     * @param rgb An array containing three or four elements, with the red, green,
     * blue, and alpha components of the color, each from 0 to 255. Each
     * element's value is adjusted to 0 if it's less than 0 and to 255 if
     * it's greater than 255 (the array itself is not modified, though).
     * @return A string in HTML color format: "#RRGGBB", if there are three
     * elements or the fourth value in the array is 255, or a string in the
     * RGBA color format otherwise.
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

    /**
     * Not documented yet.
     */
        private static String valueHexArray = "0123456789abcdef";

    /**
     * Converts an RGBA color to an HTML color, (ex. #002233).&#x22;rgb&#x22; must
     * contain at least 3 elements: the red, green, and blue (each 0-255).
     * @param rgb A double[] object.
     * @return A string object.
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
