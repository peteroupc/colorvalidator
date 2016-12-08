/*
Written in 2012-2016 by Peter O.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://peteroupc.github.io/
 */
using System;
using System.Collections.Generic;
using System.Text;
namespace PeterO {
    /// <summary>Contains methods to convert between different
    /// representations of HTML and CSS colors.</summary>
    public static class ColorValidator {
    /// <summary>Not documented yet.</summary>
    /// <param name='str'>Not documented yet.</param>
    /// <param name='index'>Not documented yet.</param>
    /// <param name='endIndex'>Not documented yet. (3).</param>
    /// <returns>A 32-bit signed integer.</returns>
        private static int ParseComma (string str, int index, int endIndex) {
            int indexStart, indexTemp;
            indexStart = index;
            indexTemp = index;
            do {
      while (index < endIndex && ((str [index] == 32) || (str [index] == 13)||
                (str [index] >= 9 && str [index] <= 10))) {
                    ++index;
                }
                if (index < endIndex && (str [index] == 44)) {
                    ++index;
                } else {
                    index = indexStart; break;
                }
      while (index < endIndex && ((str [index] == 32) || (str [index] == 13)||
                (str [index] >= 9 && str [index] <= 10))) {
                    ++index;
                }
                indexTemp = index;
            } while (false);
            return indexTemp;
        }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>Not documented yet.</param>
    /// <param name='index'>Not documented yet.</param>
    /// <param name='endIndex'>Not documented yet. (3).</param>
    /// <returns>A 32-bit signed integer.</returns>
        private static int ParseEndparen (string str, int index, int endIndex) {
            int indexStart, indexTemp;
            indexStart = index;
            indexTemp = index;
            do {
      while (index < endIndex && ((str [index] == 32) || (str [index] == 13)||
                (str [index] >= 9 && str [index] <= 10))) {
                    ++index;
                }
                if (index < endIndex && (str [index] == 41)) {
                    ++index;
                } else {
                    index = indexStart; break;
                }
                indexTemp = index;
            } while (false);
            return indexTemp;
        }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>Not documented yet.</param>
    /// <param name='index'>Not documented yet.</param>
    /// <param name='endIndex'>Not documented yet. (3).</param>
    /// <param name='ret'>A 64-bit floating-point number.</param>
    /// <returns>A 32-bit signed integer.</returns>
        private static int ParseHeaderHsl (string str, int index, int
          endIndex, double [] ret) {
            int indexStart, indexTemp, tx2;
            indexStart = index;
            indexTemp = index;
            do {
                if (index + 3 < endIndex && (str [index] & ~32) == 72 &&
                  (str [index + 1] & ~32) == 83 && (str [index + 2] & ~32)
                  == 76 && str [index + 3] == 40) {
                    index += 4;
                } else {
                    break;
                }
      while (index < endIndex && ((str [index] == 32) || (str [index] == 13)||
                (str [index] >= 9 && str [index] <= 10))) {
                    ++index;
                }
                double hue = 0, sat = 0, lgt = 0, alpha = 0;
                tx2 = ParseNumber (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    hue = StringToHue (str, index, tx2);
                    index = tx2;
                }
                tx2 = ParseComma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseNumber (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    sat = StringToPercent (str, index, tx2) * 255.0 / 100.0;
                    index = tx2;
                }
                tx2 = ParsePctcomma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseNumber (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    lgt = StringToPercent (str, index, tx2) * 255.0 / 100.0;
                    index = tx2;
                }
                if (index < endIndex && (str [index] == 37)) {
                    ++index;
                } else {
                    index = indexStart; break;
                }
                tx2 = ParseEndparen (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                double [] rgb = HlsToRgb (hue, lgt, sat);
                ret [0] = rgb [0];
                ret [1] = rgb [1];
                ret [2] = rgb [2];
                ret [3] = 255.0;
                indexTemp = index;
            } while (false);
            return indexTemp;
        }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>Not documented yet.</param>
    /// <param name='index'>Not documented yet.</param>
    /// <param name='endIndex'>Not documented yet. (3).</param>
    /// <param name='ret'>A 64-bit floating-point number.</param>
    /// <returns>A 32-bit signed integer.</returns>
        private static int ParseHeaderHsla (
    string str,
    int index,
    int endIndex,
    double [] ret) {
            int indexStart, indexTemp, tx2;
            indexStart = index;
            indexTemp = index;
            do {
                if (index + 4 < endIndex && (str [index] & ~32) == 72 &&
                  (str [index + 1] & ~32) == 83 && (str [index + 2] & ~32)
             == 76 && (str [index + 3] & ~32) == 65 && str [index + 4] ==
                  40) {
                    index += 5;
                } else {
                    break;
                }
      while (index < endIndex && ((str [index] == 32) || (str [index] == 13)||
                (str [index] >= 9 && str [index] <= 10))) {
                    ++index;
                }
                double hue = 0, sat = 0, lgt = 0, alpha = 0;
                tx2 = ParseNumber (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    hue = StringToHue (str, index, tx2);
                    index = tx2;
                }
                tx2 = ParseComma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseNumber (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    sat = StringToPercent (str, index, tx2) * 255.0 / 100.0;
                    index = tx2;
                }
                tx2 = ParsePctcomma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseNumber (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    lgt = StringToPercent (str, index, tx2) * 255.0 / 100.0;
                    index = tx2;
                }
                tx2 = ParsePctcomma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseNumber (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseEndparen (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    alpha = StringToAlpha (str, index, tx2);
                    index = tx2;
                }
                double [] rgb = HlsToRgb (hue, lgt, sat);
                ret [0] = rgb [0];
                ret [1] = rgb [1];
                ret [2] = rgb [2];
                ret [3] = alpha;
                indexTemp = index;
            } while (false);
            return indexTemp;
        }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>Not documented yet.</param>
    /// <param name='index'>Not documented yet.</param>
    /// <param name='endIndex'>Not documented yet. (3).</param>
    /// <param name='result'>A 64-bit floating-point number.</param>
    /// <returns>A 32-bit signed integer.</returns>
        private static int ParseHeaderRgbanumber (
        string str,
        int index,
        int endIndex,
        double [] result) {
            int indexStart, indexTemp, tx2;
            indexStart = index;
            indexTemp = index;
            do {
                if (index + 4 < endIndex && (str [index] & ~32) == 82 &&
                  (str [index + 1] & ~32) == 71 && (str [index + 2] & ~32)
             == 66 && (str [index + 3] & ~32) == 65 && str [index + 4] ==
                  40) {
                    index += 5;
                } else {
                    break;
                }
      while (index < endIndex && ((str [index] == 32) || (str [index] == 13)||
                (str [index] >= 9 && str [index] <= 10))) {
                    ++index;
                }
                double red = 0, green = 0, blue = 0, alpha = 0;
                tx2 = ParseInteger (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    red = StringToByte (str, index, tx2);
                    index = tx2;
                }
                tx2 = ParseComma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseInteger (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    green = StringToByte (str, index, tx2);
                    index = tx2;
                }
                tx2 = ParseComma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseInteger (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    blue = StringToByte (str, index, tx2);
                    index = tx2;
                }
                tx2 = ParseComma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseNumber (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    alpha = StringToAlpha (str, index, tx2);
                    index = tx2;
                }
                tx2 = ParseEndparen (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                result [0] = red;
                result [1] = green;
                result [2] = blue;
                result [3] = alpha;
                indexTemp = index;
                indexTemp = index;
            } while (false);
            return indexTemp;
        }

        private static int ParseHeaderRgbapercent (
         string str,
         int index,
         int endIndex,
         double [] result) {
            int indexStart, indexTemp, tx2;
            indexStart = index;
            indexTemp = index;
            do {
                if (index + 4 < endIndex && (str [index] & ~32) == 82 &&
                  (str [index + 1] & ~32) == 71 && (str [index + 2] & ~32)
             == 66 && (str [index + 3] & ~32) == 65 && str [index + 4] ==
                  40) {
                    index += 5;
                } else {
                    break;
                }
      while (index < endIndex && ((str [index] == 32) || (str [index] == 13)||
                (str [index] >= 9 && str [index] <= 10))) {
                    ++index;
                }
                double red = 0, green = 0, blue = 0, alpha = 0;
                tx2 = ParseNumber (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    red = StringToPercentComponent (str, index, tx2);
                    index = tx2;
                }
                tx2 = ParsePctcomma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseNumber (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    green = StringToPercentComponent (str, index, tx2);
                    index = tx2;
                }
                tx2 = ParsePctcomma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseNumber (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    blue = StringToPercentComponent (str, index, tx2);
                    index = tx2;
                }
                tx2 = ParsePctcomma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseNumber (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    alpha = StringToAlpha (str, index, tx2);
                    index = tx2;
                }
                tx2 = ParseEndparen (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                result [0] = red;
                result [1] = green;
                result [2] = blue;
                result [3] = alpha;
                indexTemp = index;
            } while (false);
            return indexTemp;
        }

        private static int ParseHeaderRgbnumber (
       string str,
       int index,
       int endIndex,
       double [] result) {
            int indexStart, indexTemp, tx2;
            indexStart = index;
            indexTemp = index;
            do {
                int red = 0, green = 0, blue = 0;
                if (index + 3 < endIndex && (str [index] & ~32) == 82 &&
                  (str [index + 1] & ~32) == 71 && (str [index + 2] & ~32)
                  == 66 && str [index + 3] == 40) {
                    index += 4;
                } else {
                    break;
                }
      while (index < endIndex && ((str [index] == 32) || (str [index] == 13)||
                (str [index] >= 9 && str [index] <= 10))) {
                    ++index;
                }
                tx2 = ParseInteger (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    red = StringToByte (str, index, tx2);
                    index = tx2;
                }
                tx2 = ParseComma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseInteger (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    green = StringToByte (str, index, tx2);
                    index = tx2;
                }
                tx2 = ParseComma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseInteger (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    blue = StringToByte (str, index, tx2);
                    index = tx2;
                }
                tx2 = ParseEndparen (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                result [0] = red;
                result [1] = green;
                result [2] = blue;
                result [3] = 255.0;
                indexTemp = index;
            } while (false);
            return indexTemp;
        }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>Not documented yet.</param>
    /// <param name='index'>Not documented yet.</param>
    /// <param name='endIndex'>Not documented yet. (3).</param>
    /// <param name='result'>A 64-bit floating-point number.</param>
    /// <returns>A 32-bit signed integer.</returns>
        private static int ParseHeaderRgbpercent (
        string str,
        int index,
        int endIndex,
        double [] result) {
            int indexStart, indexTemp, tx2;
            indexStart = index;
            indexTemp = index;
            do {
                if (index + 3 < endIndex && (str [index] & ~32) == 82 &&
                  (str [index + 1] & ~32) == 71 && (str [index + 2] & ~32)
                  == 66 && str [index + 3] == 40) {
                    index += 4;
                } else {
                    break;
                }
      while (index < endIndex && ((str [index] == 32) || (str [index] == 13)||
                (str [index] >= 9 && str [index] <= 10))) {
                    ++index;
                }
                double red = 0, green = 0, blue = 0;
                tx2 = ParseNumber (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    red = StringToPercentComponent (str, index, tx2);
                    index = tx2;
                }
                tx2 = ParsePctcomma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseNumber (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    green = StringToPercentComponent (str, index, tx2);
                    index = tx2;
                }
                tx2 = ParsePctcomma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                tx2 = ParseNumber (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    blue = StringToPercentComponent (str, index, tx2);
                    index = tx2;
                }
                if (index < endIndex && (str [index] == 37)) {
                    ++index;
                } else {
                    index = indexStart; break;
                }
                tx2 = ParseEndparen (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                result [0] = red;
                result [1] = green;
                result [2] = blue;
                result [3] = 255.0;
                indexTemp = index;
            } while (false);
            return indexTemp;
        }

     private static double StringToNumber (string str, int index, int
          endIndex) {
            string str2 = str.Substring (index, endIndex - index);
            return
    Convert.ToDouble (str2,
          System.Globalization.CultureInfo.InvariantCulture);
        }

    private static double StringToPercent (string str, int index, int
          endIndex) {
            double num = StringToNumber (str, index, endIndex);
            return Double.IsNaN (num) ? (-1) : ((num < 0) ? 0 : ((num > 100) ?
              100 : num));
        }
      private static double StringToAlpha (string str, int index, int
          endIndex) {
            double num = StringToNumber (str, index, endIndex);
            return (Double.IsNaN (num)) ? (0) : ((num < 0) ? (0) : ((num >
              1.0) ? 255 : num * 255.0));
        }

  private static int StringToAlphaRounded (string str, int index, int
          endIndex) {
            return (int)Math.Round (StringToAlpha (str, index, endIndex),
              MidpointRounding.AwayFromZero);
        }

        private static double StringToPercentComponent (
      string str,
      int index,
      int endIndex) {
            double num = StringToPercent (str, index, endIndex);
            return (num < 0) ? (-1) : num * 255.0 / 100.0;
        }

      private static double StringToHue (string str, int index, int
          endIndex) {
            int fast = StringToHueFast (str, index, endIndex);
            if (fast >= 0) {
                return fast;
            }
            if (index == endIndex) {
                return -1;
            }
            if (str [index] == '+') {
                ++index;
                if (index == endIndex) {
                    return -1;
                }
            }
            double num = StringToNumber (str, index, endIndex);
            return (Double.IsNaN (num) || Double.IsPositiveInfinity (num) ||
              Double.IsNegativeInfinity (num)) ? (-1) : (((num % 360) + 360) %
              360);
        }

     private static int StringToHueFast (string str, int index, int
          endIndex) {
            if (index == endIndex) {
                return -1;
            }
            var i = index;
            if (str [i] == '-') {
                return -1;
            } else if (str [i] == '+') {
                ++i;
            }
            if (i == endIndex) {
                return -1;
            }
            var ret = 0;
            while (i < endIndex) {
                int c = str [i];
                ++i;
        if (c >= '0' && c <= '9') {
          int x = c - '0';
          ret *= 10;
          ret += x;
          if (ret > 360) {
            return -1;
          }
        } else {
          return -1;
        }
            }
            return ret == 360 ? 0 : ret;
        }

        private static int StringToByte (string str, int index, int endIndex) {
            if (index == endIndex) {
                return 0;
            }
            var i = index;
            if (str [i] == '-') {
                return 0;
            } else if (str [i] == '+') {
                ++i;
            }
            if (i == endIndex) {
                return 0;
            }
            var ret = 0;
            while (i < endIndex) {
                int c = str [i];
                ++i;
        if (c >= '0' && c <= '9') {
          int x = c - '0';
          ret *= 10;
          ret += x;
          if (ret > 255) {
            return 255;
          }
        } else {
          return 0;
        }
            }
            return ret;
        }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>Not documented yet.</param>
    /// <param name='index'>Not documented yet.</param>
    /// <param name='endIndex'>Not documented yet. (3).</param>
    /// <returns>A 32-bit signed integer.</returns>
        private static int ParseInteger (string str, int index, int endIndex) {
            int indexStart, indexTemp;
            indexStart = index;
            indexTemp = index;
            do {
                if (index < endIndex && ((str [index] == 43) || (str [index] ==
                    45))) {
                    ++index;
                }
                if (index < endIndex && (str [index] >= 48 && str [index] <=
                    57)) {
                    ++index;
                while (index < endIndex && (str [index] >= 48 && str [index]
                <= 57)) {
                    ++index;
                    }
                } else {
                    index = indexStart; break;
                }
                indexTemp = index;
            } while (false);
            return indexTemp;
        }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>Not documented yet.</param>
    /// <param name='index'>Not documented yet.</param>
    /// <param name='endIndex'>Not documented yet. (3).</param>
    /// <returns>A 32-bit signed integer.</returns>
        private static int ParseNumber (string str, int index, int endIndex) {
            int indexStart, indexStart3, indexStart4, indexTemp, indexTemp2,
                    indexTemp3,
                    indexTemp4;
            indexStart = index;
            indexTemp = index;
            do {
                if (index < endIndex && ((str [index] == 43) || (str [index] ==
                    45))) {
                    ++index;
                }
                do {
                    indexTemp2 = index;
                    do {
                    indexTemp3 = index;
                    do {
                    indexStart3 = index;
                    if (index < endIndex && (str [index] >= 48 && str [index] <=
                    57)) {
                    ++index;
                while (index < endIndex && (str [index] >= 48 && str [index]
                <= 57)) {
                    ++index;
                    }
                    } else {
                    break;
                    }
                    do {
                    indexTemp4 = index;
                    do {
                    indexStart4 = index;
                    if (index < endIndex && (str [index] == 46)) {
                    ++index;
                    } else {
                    break;
                    }
                    if (index < endIndex && (str [index] >= 48 && str [index] <=
                    57)) {
                    ++index;
                while (index < endIndex && (str [index] >= 48 && str [index]
                <= 57)) {
                    ++index;
                    }
                    } else {
                    index = indexStart4; break;
                    }
                    indexTemp4 = index;
                    index = indexStart4;
                    } while (false);
                    if (indexTemp4 != index) {
                    index = indexTemp4;
                    } else {
                    break;
                    }
                    } while (false);
                    indexTemp3 = index;
                    index = indexStart3;
                    } while (false);
                    if (indexTemp3 != index) {
                    indexTemp2 = indexTemp3; break;
                    }
                    indexTemp3 = index;
                    do {
                    indexStart3 = index;
                    if (index < endIndex && (str [index] == 46)) {
                    ++index;
                    } else {
                    break;
                    }
                    if (index < endIndex && (str [index] >= 48 && str [index] <=
                    57)) {
                    ++index;
                while (index < endIndex && (str [index] >= 48 && str [index]
                <= 57)) {
                    ++index;
                    }
                    } else {
                    index = indexStart3; break;
                    }
                    indexTemp3 = index;
                    index = indexStart3;
                    } while (false);
                    if (indexTemp3 != index) {
                    indexTemp2 = indexTemp3; break;
                    }
                    } while (false);
                    if (indexTemp2 != index) {
                    index = indexTemp2;
                    } else {
                    index = indexStart; break;
                    }
                } while (false);
                if (index == indexStart) {
                    break;
                }
                indexTemp = index;
            } while (false);
            return indexTemp;
        }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>Not documented yet.</param>
    /// <param name='index'>Not documented yet.</param>
    /// <param name='endIndex'>Not documented yet. (3).</param>
    /// <returns>A 32-bit signed integer.</returns>
        private static int ParsePctcomma (string str, int index, int endIndex) {
            int indexStart, indexTemp, tx2;
            indexStart = index;
            indexTemp = index;
            do {
                if (index < endIndex && (str [index] == 37)) {
                    ++index;
                } else {
                    break;
                }
                tx2 = ParseComma (str, index, endIndex);
                if (tx2 == index) {
                    index = indexStart; break;
                } else {
                    index = tx2;
                }
                indexTemp = index;
            } while (false);
            return indexTemp;
        }

    /// <summary>Converts a color in the HLS color space to red/green/blue.
    /// Hue can range from 0 to 360, and lightness and saturation can range
    /// from 0 to 255. If lightness and saturation are out of range, those
    /// values are clamped to fit that range.</summary>
    /// <returns>An array containing three elements, with the red, green,
    /// and blue components of the same color, each from 0 to
    /// 255.</returns>
    /// <exception cref='ArgumentNullException'>The parameter "hls" is
    /// null.</exception>
     public static double [] HlsToRgb (double hueval, double lum, double
          sat) {
            lum = lum < 0 ? 0 : (lum > 255 ? 255 : lum);
            sat = sat < 0 ? 0 : (sat > 255 ? 255 : sat);
            if (sat == 0) {
                return new double [] { lum, lum, lum };
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
            r = (hue < 60) ? (a + (b - a) * hue / 60) : ((hue < 180) ? b :
              ((hue < 240) ? (a + (b - a) * (240 - hue) / 60) : a));
            hue = hueval;
      g = (hue < 60) ? (a + (b - a) * hue / 60) : ((hue < 180) ? b :
              ((hue < 240) ? (a + (b - a) * (240 - hue) / 60) : a));
            hue = hueval - 120;
            if (hue < 0) {
                hue += 360;
            }
            bl = (hue < 60) ? (a + (b - a) * hue / 60) : ((hue < 180) ? b :
              ((hue < 240) ? (a + (b - a) * (240 - hue) / 60) : a));
            return new double [] {
                (r < 0 ? 0 : (r > 255 ? 255 : r)),
        (g < 0 ? 0 : (g > 255 ? 255 : g)),
        (bl < 0 ? 0 : (bl > 255 ? 255 : bl))};
        }

    /// <summary>Not documented yet.</summary>
    /// <param name='c'>Not documented yet.</param>
    /// <returns>A 32-bit signed integer.</returns>
        private static int dehexchar (int c) {
            if (c >= '0' && c <= '9') {
                return c - '0';
            }
            return (c >= 'A' && c <= 'F') ? (c + 10 - 'A') : ((c >= 'a' && c
              <= 'f') ? (c + 10 - 'a') : (-1));
        }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>Not documented yet.</param>
    /// <returns>A string object.</returns>
        private static string ToLowerCaseAscii (string str) {
            if (str == null) {
                return null;
            }
            var len = str.Length;
            var c = (char)0;
            var hasUpperCase = false;
            for (var i = 0; i < len; ++i) {
                c = str [i];
                if (c >= 'A' && c <= 'Z') {
                    hasUpperCase = true;
                    break;
                }
            }
            if (!hasUpperCase) {
                return str;
            }
            var builder = new StringBuilder();
            for (var i = 0; i < len; ++i) {
                c = str [i];
                if (c >= 'A' && c <= 'Z') {
                    builder.Append ((char)(c + 0x20));
                } else {
                    builder.Append (c);
                }
            }
            return builder.ToString();
        }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>Not documented yet.</param>
    /// <returns>A string object.</returns>
        private static string TrimAsciiWhite (string str) {
            if (String.IsNullOrEmpty (str)) {
                return str;
            }
            var index = 0;
            int valueSLength = str.Length;
            while (index < valueSLength) {
                char c = str [index];
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
                char c = str [index];
           if (c != 0x09 && c != 0x20 && c != 0x0c && c != 0x0d && c !=
                  0x0a) {
                    int indexEnd = index + 1;
                    if (indexEnd == indexStart) {
                    return String.Empty;
                    }
                    return (indexEnd == str.Length && indexStart == 0) ? str :
                    str.Substring (indexStart, indexEnd - indexStart);
                }
                --index;
            }
            return String.Empty;
        }

        private static bool RgbHex (string str, int [] hexval, bool hash) {
            if (String.IsNullOrEmpty (str)) {
                return false;
            }
            int slen = str.Length;
            var hexes = new int [8];
            var index = 0;
            var hexIndex = 0;
            if (str [0] == '#') {
                --slen;
                ++index;
            } else if (hash) {
                return false;
            }
            if (slen != 3 && slen != 4 && slen != 6 && slen != 8) {
                return false;
            }
            for (var i = index; i < str.Length; ++i) {
                int hex = dehexchar (str [i]);
                if (hex < 0) {
                    return false;
                }
                hexes [hexIndex++] = hex;
            }
            if (slen == 3) {
                hexval [0] = unchecked(hexes [0] | (hexes [0] << 4) |
       (hexes [1] << 8) | (hexes [1] << 12) | (hexes [2] << 16) | (hexes [2]<<
               20) | (int)0xff000000);
            } else if (slen == 4) {
                hexval [0] = unchecked(hexes [0] | (hexes [0] << 4) |
       (hexes [1] << 8) | (hexes [1] << 12) | (hexes [2] << 16) | (hexes [2]<<
               20) | (hexes [3] << 24) | (hexes [3] << 28));
            } else if (slen == 6) {
                hexval [0] = unchecked(hexes [1] | (hexes [0] << 4) |
       (hexes [3] << 8) | (hexes [2] << 12) | (hexes [5] << 16) | (hexes [4]<<
                20) | (int)0xff000000);
            } else if (slen == 8) {
                hexval [0] = unchecked(hexes [1] | (hexes [0] << 4) |
       (hexes [3] << 8) | (hexes [2] << 12) | (hexes [5] << 16) | (hexes [4]<<
               20) | (hexes [7] << 24) | (hexes [6] << 28));
            }
            return true;
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
    /// Returns null if "x" is null, empty, or has invalid
    /// syntax.</returns>
        public static double [] ColorToRgba (string x) {
            if (String.IsNullOrEmpty (x)) {
                return null;
            }
            x = TrimAsciiWhite (x);
            x = ToLowerCaseAscii (x);
            if (x.Equals ("transparent")) {
                return new double [] { 0, 0, 0, 0 };
            }
            if (String.IsNullOrEmpty (x)) {
                return null;
            }
            var hex = new int [1];
            double [] ret = new double [4];
            if (x [0] == '#') {
                if (RgbHex (x, hex, true)) {
                    return new double [] {
                    (double)(hex[0] & 0xff),
                    (double)((hex[0] >> 8) & 0xff),
                    (double)((hex[0] >> 16) & 0xff),
                (double)((hex[0] >> 24) & 0xff) };
                }
            }
            if (x.Length > 3 && x.Substring (0, 3).Equals ("rgb")) {
              return (ParseHeaderRgbnumber (x, 0, x.Length, ret) == x.Length||
                ParseHeaderRgbpercent (x, 0, x.Length, ret) == x.Length ||
                 ParseHeaderRgbanumber (x, 0, x.Length, ret) == x.Length ||
    ParseHeaderRgbapercent (x, 0, x.Length, ret) == x.Length) ? (ret) :
                   (null);
            }
            if (x.Length > 3 && x.Substring (0, 3).Equals ("hsl")) {
                return (ParseHeaderHsl (x, 0, x.Length, ret) == x.Length ||
           ParseHeaderHsla (x, 0, x.Length, ret) == x.Length) ? (ret) :
               (null);
            }
            Dictionary<string, string> colors = ColorToRgbaSetUpNamedColors();
            if (colors.ContainsKey (x)) {
                string colorValue = colors [x];
                if (colorValue != null) {
                    RgbHex (colorValue, hex, false);
                    return new double [] {
                    (double)(hex[0] & 0xff),
                    (double)((hex[0] >> 8) & 0xff),
                    (double)((hex[0] >> 16) & 0xff),
                (double)((hex[0] >> 24) & 0xff) };
                }
            }
            return null;
        }

    /// <summary>Not documented yet.</summary>
        private static volatile Dictionary<string, string>
              namedColorMap;

    /// <summary>Not documented yet.</summary>
        private static object syncRoot = new Object();

    /// <summary>Not documented yet.</summary>
        private static string [] nc = new string [] {
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

    /// <summary>Not documented yet.</summary>
    /// <returns>A Dictionary(string, string) object.</returns>
     private static Dictionary<string, string> ColorToRgbaSetUpNamedColors
          () {
            if (namedColorMap == null) {
                lock (syncRoot) {
                    if (namedColorMap == null) {
                    namedColorMap = new Dictionary<string, string>();
                    for (int i = 0; i < nc.Length; i += 2) {
                    namedColorMap.Add (nc [i], nc [i + 1]);
                    }
                    // "Grey" aliases for "gray" colors
                    namedColorMap.Add ("grey", namedColorMap ["gray"]);
                    namedColorMap.Add ("darkgrey", namedColorMap ["darkgray"]);
          namedColorMap.Add ("darkslategrey", namedColorMap
                    ["darkslategray"]);
                    namedColorMap.Add ("dimgrey", namedColorMap ["dimgray"]);
                  namedColorMap.Add ("lightgrey", namedColorMap
                    ["lightgray"]);
        {
string objectTemp = "lightslategrey";
string objectTemp2 = namedColorMap
                    ["lightslategray"];
namedColorMap.Add(objectTemp, objectTemp2);
}
                  {
string objectTemp = "slategrey";
string objectTemp2 = namedColorMap
                    ["slategray"];
namedColorMap.Add(objectTemp, objectTemp2);
}
                    }
                }
            }
            return namedColorMap;
        }

    /// <summary>Not documented yet.</summary>
    /// <param name='r'>Not documented yet.</param>
    /// <returns>A string object.</returns>
        private static string RoundedString (double r) {
            r = Math.Round (r, MidpointRounding.AwayFromZero);
            return Convert.ToString (
        (double)r,
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
        public static string RgbToColor (double [] arrayRGB) {
            if (arrayRGB == null) {
                throw new ArgumentNullException ("arrayRGB");
            }
            if (arrayRGB.Length < 3) {
       throw new ArgumentException ("3 more than " + arrayRGB.Length +
                  " (3)");
            }
            // we should include the spaces
     if ((arrayRGB.Length > 3 && (arrayRGB [3] == 255.0)) || arrayRGB.Length
              == 3) {
                return "rgb(" + RoundedString (arrayRGB [0]) + ", " +
                    RoundedString (arrayRGB [1]) + ", " +
                    RoundedString (arrayRGB [2]) + ")";
            } else {
                double prec = Math.Round (
          (arrayRGB [3] / 255.0) * 100.0,
          MidpointRounding.AwayFromZero) / 100.0;
                return "rgba(" + RoundedString (arrayRGB [0]) + ", " +
                    RoundedString (arrayRGB [1]) + ", " +
                    RoundedString (arrayRGB [2]) + ", " +
                    Convert.ToString (
          (double)prec,
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
        public static string RgbToColorDisplay (double [] rgb) {
            if (rgb == null) {
                throw new ArgumentNullException ("rgb");
            }
            if (rgb.Length < 3) {
            throw new ArgumentException ("3 more than " + rgb.Length +
                  " (3)");
            }
            if (rgb.Length == 3 || (rgb.Length > 3 && rgb [3] == 255)) {
                return RgbToColorHtml (rgb);
            } else {
                return RgbToColor (rgb).Replace (" ", String.Empty);
            }
        }

    /// <summary>Not documented yet.</summary>
        private static string valueHexArray = "0123456789abcdef";

    /// <summary>Converts an RGBA color to an HTML color, (ex.
    /// #002233).&#x22;rgb&#x22; must contain at least 3 elements: the red,
    /// green, and blue (each 0-255).</summary>
    /// <param name='rgb'>A double[] object.</param>
    /// <returns>A string object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='rgb'/> is null.</exception>
        public static string RgbToColorHtml (double [] rgb) {
            if (rgb == null) {
                throw new ArgumentNullException ("rgb");
            }
            if (rgb.Length < 3) {
             throw new ArgumentException ("3 more than " + rgb.Length +
                  "(3)");
            }
            var sb = new StringBuilder();
            int c;
          c = ((c = (int)Math.Round (rgb [0],
              MidpointRounding.AwayFromZero)) <
              0 ? 0 : (c > 255 ? 255 : c));
            sb.Append (valueHexArray [(c >> 4) & 15]);
            sb.Append (valueHexArray [c & 15]);
          c = ((c = (int)Math.Round (rgb [1],
              MidpointRounding.AwayFromZero)) < 0 ? 0 : (c > 255 ? 255 : c));
            sb.Append (valueHexArray [(c >> 4) & 15]);
            sb.Append (valueHexArray [c & 15]);
          c = ((c = (int)Math.Round (rgb [2],
              MidpointRounding.AwayFromZero)) < 0 ? 0 : (c > 255 ? 255 : c));
            sb.Append (valueHexArray [(c >> 4) & 15]);
            sb.Append (valueHexArray [c & 15]);
            return sb.ToString();
        }
    }
}
