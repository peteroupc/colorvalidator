package com.upokecenter.test;

import java.util.*;

import com.upokecenter.util.*;
import org.junit.Assert;
import org.junit.Test;

  public class ColorValidatorTest {
    @Test
    public void TestColorHtmlToRgba() {
    }
    @Test
    public void TestHlsToRgb() {
    }

    private void AssertCssColor(
  String str,
  double r,
  double g,
  double b,
  double a) {
      double[] rgba = ColorValidator.ColorToRgba(str);
      Assert.NotNull(rgba, str);
    String valueSMsg = str + "\n" + rgba[0] + ", " + rgba[1] + ", " +
      rgba[2] + ", " +
 rgba[3];
      Assert.assertEquals(r, rgba[0], 1.5, valueSMsg + ": red");
      Assert.assertEquals(g, rgba[1], 1.5, valueSMsg + ": green");
      Assert.assertEquals(b, rgba[2], 1.5, valueSMsg + ": blue");
      Assert.assertEquals(a, rgba[3], 1.5, valueSMsg + ": alpha");
    }

    @Test
    public void TestColorNames() {
      this.AssertCssColor("Red", 255, 0, 0, 255);
    }

    @Test
    public void TestColorToRgba() {
  this.AssertCssColor(
  "\t\t\tRGba(\n\r\r\r\r\n\r\n+3.3%\n\r,00041.7%\t\t \r\t \r\r,\r\n\r\r4%,000.8385969580)"
  ,

  8,
 106,
 10,
 214.2);

  this.AssertCssColor(
  "\t\t\n rGba(+0094.2%, 8%,+5.47672%\n\r,\t\t\t00.8\r\r \n \n)",
  240,
 20,
 14,
 204);
AssertCssColor(
  "\t\t\r\r\r\n\nHSl(\n-3800 ,\r\n\r+0009%,2.226907%)",
  5,
 6,
 5,
 255.0);
AssertCssColor(
  "\t\t\rRgB(45.24041986%\r \n\t\n\n ,\n\r19%,+0079.0610%)\r",
  115,
 48,
 202,
 255.0);

  this.AssertCssColor(
 "\t\t \n\n \n\n\r\n\rhSl(+5382.797,030%\n\r\r\r ,\n +0073%)\r\n\r\n\n \r\r\t",

  206,
 165,
 177,
 255.0);
AssertCssColor("\t\t#bAfcaccC\n\n\t",186,252,172,204);

  this.AssertCssColor(
  "\t\tRGB(+07.4835402% \n\t\r\t, \n \r\n\n\t\r\r14%,\n\n\t\r+048.860688797%\r\r\r \r) "
  ,

  19,
 36,
 125,
 255.0);
AssertCssColor("\t\n\t\nrGB(+7.9020%,\n 090%,0%)",20,230,0,255.0);

  this.AssertCssColor(
  "\t\n\t\r\rhsl(4434.63\n\t\r \r\r\t\r ,\n \t +5%,+46.078075%) \n\r\r ",
  112,
 123,
 111,
 255.0);
AssertCssColor(
  "\t\n\n\tHSL(\r\t \t\r\t\n8320,\n+61.7941%,\r\r19%)",
  78,
 58,
 18,
 255.0);
AssertCssColor(
  "\t\n\n\n rgB(49%,\n\r+1.92836%\r \t\r\n\r,+1.637%\n\r\r\r)",
  125,
 5,
 4,
 255.0);
AssertCssColor("\t\n\n\r\n\n\n \n\r\trgB(\t2%,1%\n,8%)\n",5,3,20,255.0);

  this.AssertCssColor(
  "\t\n\n \n\t\n\n\n\tHsL(\r\n\r\n\n-9448.6275 \r, \n\n\n\n81.64217472406%,93%)\t\r\r"
  ,

  237,
 222,
 251,
 255.0);

  this.AssertCssColor(
  "\t\n\nHsl(\r \n\n-5902.160989826\t \n,008.51%,000068.781593%)\n",
  168,
 173,
 182,
 255.0);
AssertCssColor("\t\n\r\n\r\r\r\t\n#bB78EA",187,120,234,255.0);

  this.AssertCssColor(
  "\t\n\r\r\nRgB(\n8.8554%\n\r,\n +0093.487472%\r ,\n\r\t\n\r\n\r\n\r\r\n\n+92.5% \n\n\t\n\n\n\r\n\n\r\r) "
  ,

  23,
 238,
 236,
 255.0);

  this.AssertCssColor(
  "\t\n\r\r\r hSL(\t\n 4103.371944,\r\n\n\n\r000061.696%\r\n\n,+21.9494%\n\r\n) \r\n\r\r"
  ,

  21,
 90,
 48,
 255.0);

  this.AssertCssColor(
  "\t\n\r\rRGba(+0012%\r\r \t\t\r\r\t, \r \n +9%,\t\r \r11.2110%,000.06\n)",
  31,
 23,
 29,
 15.299999999999999);
AssertCssColor("\t\n #cAbD",204,170,187,221.085);
AssertCssColor("\t\n#c1dE\t\r",204,17,221,237.91500000000002);
AssertCssColor(
  "\t\nHSL(\t+3628, \n\n088.13%,\t+37.20519%)\t\t\n\r\t",
  178,
 89,
 11,
 255.0);

  this.AssertCssColor(
  "\t\nHsL(+3673\n,\r\r\n\n\t \r\n\r\r\r041%,+4.68591678%) \n\r\t\r",
  14,
 16,
 7,
 255.0);

  this.AssertCssColor(
  "\t\nHsL(-2554.28784069\n\r\n \r\n\t\r\r\n,+5.4%, \n\n\r\t\n\n\t\t\n +1.4567%\r \t \n)\r\t\r\r\r"
  ,

  3,
 3,
 3,
 255.0);
AssertCssColor("\t\nRgb(\t\n \r \n \r\n54,255,17)\n",54,255,17,255.0);
AssertCssColor(
  "\t\nhSl(\n-6554.4536\t,\t\n\n1%,\n49.88%)\n\n\r",
  127,
 125,
 128,
 255.0);

  this.AssertCssColor(
  "\t\nrgBA(+87%, \t+77%,\r\t\r\t\n\r\r\r2.80231%,00.4\r\n\r \n)\r",
  222,
 196,
 7,
 102);
AssertCssColor(
  "\t\r\n\n\n\n\tRgbA(+121,+23,\n\r\t+255,.543\t\n)\t",
  121,
 23,
 255,
 137.70000000000002);

  this.AssertCssColor(
  "\t\r\n\n \n\n\nHSL(8120.1601,7.45% \t\n\n\r\t\n\n \n\t\t,+12.6%)",
  29,
 32,
 34,
 255.0);

  this.AssertCssColor(
  "\t\r\n\nHSL(4065.68446\n\n\t\r,00024.3575282%\r\t, \n\n+29%\r\t \n)",
  64,
 91,
 55,
 255.0);

  this.AssertCssColor(
  "\t\r\n\r\rHsl(6715\n\r ,9%,00035.373004929%)\t\r\r\n \r\r\r\t",
  82,
 83,
 98,
 255.0);

  this.AssertCssColor(
  "\t\r\n\r \rhSl(5619.5916,3%\r,\n\r\n\r \n\r \r+013.484808%)\n\t",
  33,
 34,
 35,
 255.0);
AssertCssColor(
  "\t\r\n RGb(+86.34%\r,+000084.000159%\t \n,24%\n)\n \t",
  220,
 214,
 61,
 255.0);
AssertCssColor("\t\r \rrgB(\t\t\n52%,95.5% ,\n+78%\n)",133,244,199,255.0);

  this.AssertCssColor(
  "\t\r RGba(\t\r\r7%\r\n,\r+050% \n ,\r20%,\n\t\r\t\r\r\t\n \r0.17062\t\r\r\r \r)\t"
  ,

  18,
 128,
 51,
 44.114999999999995);
AssertCssColor("\t\r#1Fc7 \r\n ",17,255,204,119.08500000000001);
AssertCssColor(
  "\t\rHSL(+0363,+2.1263%\t \t\n\r ,\r\n+0047%\n\r\r)\t",
  122,
 117,
 117,
 255.0);
AssertCssColor(
  "\t\rHSL(-8072.297\n\n,\r\n+98.950%, \t\t +80.730%\t)",
  157,
 209,
 254,
 255.0);
AssertCssColor("\t\rhSL(5856.7\n\r,\r\r\t \r +76%\n, 4%\n)",8,17,2,255.0);
AssertCssColor(
  "\t\rhsl(+7977\n\t \r\n \r,\n\r\n\t+12%,11% \n\t \n\r\r)",
  31,
 31,
 24,
 255.0);
AssertCssColor(
  "\t\rrgB(+09% \n\r \r,\n\r\t+0025.73347%,\r+2%\t\n \n\r\r)",
  23,
 66,
 5,
 255.0);

  this.AssertCssColor(
  "\t \n\n\r\t\n\tRgBA(53%,00057.3%, \n\n\r+5%,\t\r \n \t\n.87\r\n)\r\t",
  135,
 146,
 13,
 221.85);
AssertCssColor(
  "\t \n\r\nRgba(+73%,057%\n,+06%,\r\t\r\r\r+00.460001)",
  186,
 145,
 15,
 117.30000000000001);

  this.AssertCssColor(
  "\t \n \t rgBa(\r\r \n\n \r\n\r\r24%,\r\r02%\n\n\n\r,\n\n\n\n\r\r \t\r\n\n+22%\r\r, \t\n00.308)"
  ,

  61,
 5,
 56,
 79.05);
AssertCssColor("\t \r \n#bdefeDd3\n",189,239,237,210.885);
AssertCssColor("\t \n#ADAbfF\r",173,171,255,255.0);

  this.AssertCssColor(
  "\t HsL(\n\t0052.143544,\r\t\r\t\n+60.8605186018%,+69% \r \n \n)",
  224,
 211,
 127,
 255.0);
AssertCssColor("\t#AeeE",170,238,238,237.91500000000002);
AssertCssColor("\t#Bffb",187,255,255,186.915);
AssertCssColor("\t#cfFA2A7F",207,250,42,126.99);
AssertCssColor("\t#dFbAEE\r\r\r\r\t\r \r\n",223,186,238,255.0);
AssertCssColor("\t#dd8A",221,221,136,170.085);

  this.AssertCssColor(
  "\tHSL(\n\r\t\r\n \n+5442.222346546175\r\n\r,\r+081% ,\r\t\t\t7.8175280%)\n\r\t\t"
  ,

  36,
 26,
 3,
 255.0);
AssertCssColor("\tHSL(\r+3836,\t\r\n00073%\n \n,+7.654847309%)",5,7,33,255.0);

  this.AssertCssColor(
  "\tHSL(+6222,\r\n\r+040.7%,\n\r+9.1%\r\t \n\n\t\r\n\t \r)\r\n\n\t\r",
  19,
 32,
 13,
 255.0);
AssertCssColor("\tHsL(-3476 \r,+20%,0052.488%)\r\n\r\r \t\r",109,158,112,255.0);
AssertCssColor("\tHsL(9643.098,81%, +29%)",100,14,133,255.0);
AssertCssColor(
  "\tHsl(\n\n\n\n \r\n\r+1045.67858,+0.9633%\t, 78.857%\r\n)",
  201,
 200,
 201,
 255.0);

  this.AssertCssColor(
 "\tHsl(8679.62414,\r\t\n \r\n+2.30924% \r\n\r\n\r\r\n\r, \t+4.44505%) \n\n\r ",

  11,
 11,
 11,
 255.0);

  this.AssertCssColor(
  "\tRGbA(73.113729599%\n \t,2.9%,+6%\r\r\t\n \n\r\r\r\r ,+0.90003\n\r\n\n\r \r)\r\n\n\r \n"
  ,

  186,
 7,
 15,
 229.5);
AssertCssColor(
  "\tRGba(\t54.9%,\r+27%,+9.760%,00.3\r \t\n \n\n)\r\r\r ",
  140,
 69,
 25,
 76.5);
AssertCssColor("\tRgB(\n\t\t81.3%\r\t \r\n,+00%, 9.57%)\n",207,0,24,255.0);

  this.AssertCssColor(
  "\tRgB(\n\n \r\n5.17845%,\r\r+8%,7%\n\r\r\r\t)\t\r\t \r \n\n\r\t\t",
  13,
 20,
 18,
 255.0);

  this.AssertCssColor(
  "\tRgba(+0.58% \t\r\n\r\n\r,+8.99939% \t\r\r,\n\r\r\r\t\r+83%,000.430925 \n\t\r)\n"
  ,

  1,
 23,
 212,
 109.64999999999999);

  this.AssertCssColor(
  "\thSL(\n7652.2 \n\t \r,9.923%\n\r\r,\r\t \n00088.35%\n\n)\r\n\n\n\n\n\t\n",
  225,
 228,
 222,
 255.0);

  this.AssertCssColor(
  "\thSL(\r\t\t\n\r \t\r3862\t,\r \t\n\n\t\r\n8.222%\n,46.7582507%)\n\t\r \t",
  116,
 109,
 129,
 255.0);

  this.AssertCssColor(
  "\thSL(+4866.58821\r\n,+3.894370%, \r\t\t\t\t\n\t \r+00017.79%\n\n\t\t\n\r \t\n)\t"
  ,

  43,
 46,
 47,
 255.0);

  this.AssertCssColor(
  "\thsl(-7234.56130463\r\n \t ,+097.39% \n,\t\n \n\r \n+3%\n\n)",
  15,
 0,
 8,
 255.0);
AssertCssColor(
  "\trgB(\r\r\r+66% ,0041.98946302743%,9%)\t\r\n",
  168,
 107,
 23,
 255.0);
AssertCssColor("\trgB(+00092.5084563199%,+9%\t\r,+1%\r\n)",236,23,3,255.0);

  this.AssertCssColor(
  "\trgBa(\n\t\n\n\r\t00074.17%\n,14.676%\n,+056.4%,+000.6)\r\n\n",
  189,
 37,
 144,
 153);

  this.AssertCssColor(
  "\n\t\n\t\r \n\r \tRgBA(\t\r\t\r\n 2%\t,51%,+84%\n \r \n \n\n\n\t,\r00.6)\n\n\n"
  ,

  5,
 130,
 214,
 153);
AssertCssColor(
  "\n\t\n\n\n\r\r\rHsl(+9866,000052%\t\n\n\n,\n +8.5%)\n",
  10,
 32,
 20,
 255.0);

  this.AssertCssColor(
  "\n\t\n\rHsl(-6270.2,0032.6%\r\n\n\n\r\n \t,\r\t\n\n\t \n+9%)",
  15,
 22,
 30,
 255.0);

  this.AssertCssColor(
  "\n\t\n\rrgbA(\t\r6% \n\t\n\r\n\r,+66%,\n\n\n\t\n\n \t91.0%\r\n,00.4\n \n\n)\n\n\r\t\t"
  ,

  15,
 168,
 232,
 102);
AssertCssColor(
  "\n\t\n RGB(\n\n+3%\t\r\n,\r\t13.607% \n\r,+00018%\n\r\n)",
  8,
 35,
 46,
 255.0);

  this.AssertCssColor(
  "\n\t\n RGba(\t\r0061.1%,\n\t\t\r\n\n\n\n+057.409%,\n1.3%,\t.66\r \t)",
  156,
 146,
 3,
 168.3);
AssertCssColor("\n\t\n#7E8B",119,238,136,186.915);

  this.AssertCssColor(
  "\n\t\nHsL(8856.451681829,\r\r\n \t26%\r\r\t\n \r\n , \n \r093%)",
  232,
 236,
 241,
 255.0);
AssertCssColor(
  "\n\t\nhsl(3349\n,8%,\r+88.3294875286%\r\r\r\n\r\r) ",
  223,
 227,
 222,
 255.0);
AssertCssColor(
  "\n\t\r\tHSL(+0884.70221867,\r5% \n, \n78%\n\n\t)",
  196,
 201,
 200,
 255.0);

  this.AssertCssColor(
  "\n\t\r\r \rRgb(\n \r\n\r\n\r\n\n+0%\r \t\r, 51%, \r\r\r\n+000074.839875%\n\t\r\n\n\n)\r"
  ,

  0,
 130,
 191,
 255.0);
AssertCssColor("\n\t \n#a2cB\r\n\n",170,34,204,186.915);
AssertCssColor(
  "\n\t \r\r\r\r\r\t\r\n\rrGB(\n\n0022,\n 198\n\r\r\r ,\t 96) ",
  22,
 198,
 96,
 255.0);

  this.AssertCssColor(
  "\n\t hsL(\n\r7348 \r\n \r\n\r\n\n,\n\t\t \n \t3.38%,\n\n +23.35%\n\r\r \t)\r\n\n\r\n "
  ,

  57,
 61,
 59,
 255.0);
AssertCssColor("\n\t#beb",187,238,187,255.0);

  this.AssertCssColor(
  "\n\tHsL(9340\n\n\t\n \n\n\t, \r\n\r\n\r\r \r+1.3%\t\n,\n+18%)",
  46,
 45,
 45,
 255.0);
AssertCssColor(
  "\n\tHsl(\n\n \r\n\r+5262.4,\r0063.2%,00019.237%)",
  18,
 36,
 80,
 255.0);

  this.AssertCssColor(
  "\n\tRgb(\r\n\r\n\n\n+38,\n\n\n\r\n\r\n +210\n ,\r\r\r \r\r\r+66\n \r\r)\n\r\t\t\n\r\t"
  ,

  38,
 210,
 66,
 255.0);

  this.AssertCssColor(
  "\n\thSl(5779\n\n, \r+8.2%\n\r\n\r \n \r\r\n,\n\n\t\n+49.324%)\r\r\t \t\t\r\n\r"
  ,

  136,
 121,
 115,
 255.0);

  this.AssertCssColor(
  "\n\n\t\t\nrGBa(+00045.985427%\r\t \r\n ,+0%,\r \r18.0339%,\n+0.981 \n)",
  117,
 0,
 46,
 249.9);

  this.AssertCssColor(
  "\n\n\t\t\rRGb(\n\r\t\t\n \r\r\n\r81.066334%,\r33%,\r\n\n \t\r\t\n\r+32%\t)",
  207,
 84,
 82,
 255.0);

  this.AssertCssColor(
  "\n\n\t\nRGbA(\t\r\r60.6831860%,\n\t\n\t\n00082.683606%,+000063.09%,\r \r\n+0000.711)"
  ,

  155,
 211,
 161,
 181.04999999999998);
AssertCssColor("\n\n\t#eC1eac",236,30,172,255.0);
AssertCssColor(
  "\n\n\thsL(\r\r\n \r5500,0039.167%\r,70%\n\t\t)",
  168,
 208,
 148,
 255.0);

  this.AssertCssColor(
  "\n\n\n\t\t\r\r\rRGB(\n\n\n\t\r\n\t76%,\r+27%,+67%\n\r\n\r\n\n)\r ",
  194,
 69,
 171,
 255.0);

  this.AssertCssColor(
  "\n\n\n\t\nHSL(+0088,\n\r+7%\t\t\t\r \n\t\n\r\r\t,+000005.98631044%)",
  15,
 16,
 14,
 255.0);

  this.AssertCssColor(
  "\n\n\n\t\r\r rGBa(+09%\r,+86.2% \t \r\r,+00058.628%\n \r,\t\r\n0000.56)\r",
  23,
 220,
 150,
 142.8);

  this.AssertCssColor(
  "\n\n\n\trGB(00034%,\t \t\n\r\t+5.216869% \n\r\n\n ,\t+60.4%)",
  87,
 13,
 154,
 255.0);
AssertCssColor("\n\n\n\n#BeBe\n\n\r\r\t",187,238,187,237.91500000000002);

  this.AssertCssColor(
  "\n\n\n\nRgBA(\r\n\n0%,+7.9%\r,\r\r\t \r\r\r\t 024%\t\n\n\t\r\t\t \n\n,\t\t\r00.0)\r"
  ,

  0,
 20,
 61,
 0);

  this.AssertCssColor(
  "\n\n\n\r\t\r\tRgb(+75.968010%\t\n\r\n, \r\n\n+32.504289503% \r\r\r\n\n,\t+38%\n)\r"
  ,

  194,
 83,
 97,
 255.0);

  this.AssertCssColor(
  "\n\n\n\r\r\n\n\n\r\r\nrgb(+005%,\r\r\r\r\n0085%,+7.117% \n\n)\n\r\r\r\r\n\r\n "
  ,

  13,
 217,
 18,
 255.0);

  this.AssertCssColor(
  "\n\n\n\r\r\n\rrgbA(\n\r000076.267361%,000000% ,0.1645700%\n\r\r\t\r,\t\n\t\r\t\r+000.6479553)"
  ,

  194,
 0,
 0,
 164.985);

  this.AssertCssColor(
  "\n\n\n\rHSl(\n\r\n\r\r\n\n2322.806300984\r\n\n\n,\r\n\r+064%\t\t,\t \t \r \n\n \n+0028.00%\n\r\r\r\r \n)\r "
  ,

  25,
 117,
 90,
 255.0);

  this.AssertCssColor(
  "\n\n\n\rRGbA(+000093.0%,75.5065831302%\r \n,\n\r\t9.0378%,+000.966279464)\n",
  237,
 193,
 23,
 246.075);

  this.AssertCssColor(
  "\n\n\n HSL(\r\r\r \t\n\n\r+5914,\t+80.692%\r\t\r,\t000055%\n\t \n \r\n\n\r)\n",

  47,
 232,
 152,
 255.0);

  this.AssertCssColor(
  "\n\n\r\tRGb(\r\r\r\n\n\r0092.93%\n\n\n\n\t\n\r,\r+13.9%\r ,054%)",
  237,
 35,
 138,
 255.0);

  this.AssertCssColor(
  "\n\n\r\trGba(00007\t\r,1 \t\r\r\r\n\r,+253,\t\n00.246\r)\n\t",
  7,
 1,
 253,
 62.985);

  this.AssertCssColor(
  "\n\n\r\n\r\n\r\n\rrGb(\t \r+000085\n,+0077\r\t\r\r,124)\r\r\r\r \n\t\n",
  85,
 77,
 124,
 255.0);
AssertCssColor("\n\n\r\n\r #73C\t\t\n",119,51,204,255.0);
AssertCssColor("\n\n\r\nhSL(\n2403,+000019.2%,+9.1%)\r\n \n \r",19,18,27,255.0);
AssertCssColor("\n\n\r\r\n#dbcEaBEf\n",219,206,171,238.935);
AssertCssColor("\n\n\r\r\r#c22\r\n",204,34,34,255.0);

  this.AssertCssColor(
  "\n\n\r \nHsL(\r-7112.46\r\n,00065.3631%\r\r\r,\t\t\t\r\n+3.0% \n\t)",
  8,
 12,
 2,
 255.0);
AssertCssColor("\n\n\r#CBFdCD\n \r\n\r\r\r\n",203,253,205,255.0);
AssertCssColor(
  "\n\n\rHSl(+7187.038,+92.50587%\r,+8.0692006%\r\n\r)",
  39,
 1,
 9,
 255.0);

  this.AssertCssColor(
  "\n\n \n\r\r\t\r\rRGB(\t\r \n\r+00085%\n \t \n\n\n\r\r\r,\r\r\r+80%,\t\r\n\r\r+00021.1731%) "
  ,

  217,
 204,
 54,
 255.0);
AssertCssColor("\n\n \r\r\r#c8E",204,136,238,255.0);

  this.AssertCssColor(
  "\n\n \rRgB(\r\r00070%,\n \r+067.434%,+000059.768548656325%\n)\r",
  179,
 172,
 152,
 255.0);
AssertCssColor("\n\n#4CfF\n\n\n\n \t\n ",68,204,255,255.0);
AssertCssColor(
  "\n\nHSl(3631,+98.33%,\r\t\n00090.94%\r \n\r\t\n\t\n)",
  254,
 232,
 209,
 255.0);
AssertCssColor("\n\nHsl(2422,\r\t+00082.8856%,38%)",75,16,177,255.0);
AssertCssColor("\n\nhsL(-5539\t\n\n\n\r\r\r,\t\n+4%,6%)\n ",14,15,15,255.0);
AssertCssColor(
  "\n\r\t hSL(-2336.7,\t\n+2.932706%,\r +000063.1%)",
  158,
 163,
 163,
 255.0);

  this.AssertCssColor(
  "\n\r\thsl(+5623.29653616\r \r ,000088%,6.1209627% \r\n\r\n)",
  1,
 9,
 29,
 255.0);
AssertCssColor(
  "\n\r\n\t \nHSL(\n\r \r\n\n+8531.2,00019%\r\n\t \n\r ,17%)",
  38,
 35,
 51,
 255.0);

  this.AssertCssColor(
  "\n\r\n\n\t\r\n\rHsl(-1999.9\r\r\r,65%\r\r\r,\n\t\r \r\r0.1%)",
  0,
 0,
 0,
 255.0);
AssertCssColor("\n\r\n\r\r\r\r\r\n#bbdBcb\t\t\n\r\n",187,219,203,255.0);

  this.AssertCssColor(
  "\n\r\n\rHSL(9516.3\r\n\r\r\n,\n\r\n\r \t 5%,\n\n82% \r\r\t\r\r)",
  206,
 211,
 209,
 255.0);

  this.AssertCssColor(
  "\n\r\n\rhsL(7890,000032%, \n \t\n\n43.831%)\r\r\t\r\r\r \n ",
  147,
 76,
 111,
 255.0);
AssertCssColor(
  "\n\r\nHSL(2786.8059,\n+004%\r \t\r,14.07%) \r",
  35,
 34,
 37,
 255.0);

  this.AssertCssColor(
  "\n\r\nRGbA(12.8% \n \n\r\n\r \t, \r\n\n\n6.792%,\t\t58.1%\r \r,+.4548)",
  33,
 17,
 148,
 116.025);

  this.AssertCssColor(
 "\n\r\nhsl(\r8557\n\n\n\r\n\n\r\n\r\r\t,+0033%\r,\n\t+08%\r\n\n)\r\r \r\r\r\n",

  21,
 13,
 27,
 255.0);

  this.AssertCssColor(
  "\n\r\r\t\t \n\r\rRGBa(038%,\r\n\n\r1%,+8.716%\n\n\r\n\r,00.91253421\t\t)",
  97,
 3,
 22,
 233.07000000000002);
AssertCssColor("\n\r\r\t\r\n\n \n#BEdefb0C",190,222,251,11.985);
AssertCssColor(
  "\n\r\r\trGB(\n\r\n+0054.2%,\r\n\n0094%\r,+1%\n\n)\r\t\r",
  138,
 240,
 3,
 255.0);
AssertCssColor("\n\r\r\n\n#DCaA5cbA",220,170,92,186.15);

  this.AssertCssColor(
  "\n\r\r\n\rHSL(\n\n-1866\t\n\r\t \r,9.0%\n\t\t\t\n\t,\t11.8%)\r\n \r\r\t\n\n",
  32,
 27,
 32,
 255.0);

  this.AssertCssColor(
  "\n\r\rHsL(+5243.90198\n\r,22.1% \r\r\n\r,5%\t\r\r\r\n\r\n\r\n\n\r)\n\n \r\t",

  9,
 13,
 15,
 255.0);
AssertCssColor("\n\r \t#fDfFBD\r",253,255,189,255.0);

  this.AssertCssColor(
  "\n\r \n\r\n\nhSL(+4787,+75.56752%,\r\n\r\n \r\n 97.247541%\t\r\t\r\t\t\n\r\n)",

  244,
 253,
 242,
 255.0);

  this.AssertCssColor(
  "\n\r \n \r\tHsL(\r \n5262.7463,\n\t\n000009%,+39% \r\t\n\n)\r\t\n \r\n\t",
  90,
 95,
 108,
 255.0);

  this.AssertCssColor(
  "\n\r RGBa(\r\n\n\r+00042%\r,+19.3%\r\n \r\r ,+3%,+000.9\n\n\r)",
  107,
 49,
 8,
 229.5);
AssertCssColor("\n\rHSL(-1587.1074527,+054.4%,4.282%\t)\r",4,10,16,255.0);

  this.AssertCssColor(
  "\n\rRGba(37% \t \r,+17%\r \t, \r\n\n\n\r\t00084.6%,\r\r\n\n\r\n0.433)",
  94,
 43,
 216,
 109.64999999999999);

  this.AssertCssColor(
  "\n\rRgbA(021.21425%,+1.1%,\n\t\n+37.6%\n\r,+0000.2511\t\n\r \n\r\n\r\n \r)",
  54,
 3,
 96,
 63.75);
AssertCssColor(
  "\n\rhsL(+8457.838\n,+77.579%\n\t\n\r\n\t,7.42%\n\r\n)",
  4,
 33,
 32,
 255.0);

  this.AssertCssColor(
  "\n\rrgba(\r\n\r\n\n\n\r\r \t+46% ,89.45% \r,+00%,+0.5823\n \n)\n",
  117,
 228,
 0,
 147.89999999999998);
AssertCssColor(
  "\n \n\n\r\n\rRgBA(\n\r\t02.47%,019.5%,+1%,.2\r\r)\t\n",
  6,
 50,
 3,
 51);

  this.AssertCssColor(
  "\n \n\n\rHsl(\n \r\r\r\r\n\n8357\r\n\t,+0057%,\r\n\r\t\r\r 4%)",
  12,
 16,
 4,
 255.0);

  this.AssertCssColor(
  "\n \n\rhsl(\t \r\n\r5114\r,\t+0083.09921%\r\r\t ,\r \n\r000093.0662637222% \r\r\t\r\t)"
  ,

  245,
 252,
 222,
 255.0);
AssertCssColor(
  "\n \n\rrgb(028.4144616860% \r\r\t,+20% \r\t\r, 000032%)",
  72,
 51,
 82,
 255.0);
AssertCssColor(
  "\n \nhsl(\r\n\r \n\n-6368\r\n\r \r\r,+9%,+00055.77%\t\n)\r",
  134,
 152,
 132,
 255.0);
AssertCssColor("\n \r\t\nHsl(\n0747.6,21%,000077%\n)",208,195,184,255.0);

  this.AssertCssColor(
  "\n \r\n\n\nHsl(+2434,+0042.7888%\r\t\t\t\t,\t+51.09140554258%)\r",
  137,
 76,
 183,
 255.0);

  this.AssertCssColor(
  "\n \r\n\nHSl(\r+8475,\r\t12.3%\t,1.370473786758%\r\r \r\n)\t",
  3,
 3,
 3,
 255.0);

  this.AssertCssColor(
  "\n \r\n \r\rhsL(\n0667\t\r\n\r \t\r\r,000002%\r\r\r \n\r\n\r\r,\r\t\n\t\r\n+5%) \n\r\r\n\t\t\t\r\n"
  ,

  13,
 12,
 12,
 255.0);

  this.AssertCssColor(
  "\n \r\rRgb(\r\r\r90.7% \n\r\n\r\t\r,36%\n\t\t\r ,\n\r \t67%\r\r\n\r\r)",
  231,
 92,
 171,
 255.0);
AssertCssColor(
  "\n \r\rhsL(\n\r4172.302,\r\r+000010.62% ,10%) \n\r\n ",
  22,
 25,
 28,
 255.0);

  this.AssertCssColor(
  "\n \rrGBa(+041%,13.02% \r \r\r\r\t\t,\r\t000035.1105548%\r\n\r, \r \t \n\r\n+0.17)\t\r "
  ,

  105,
 33,
 90,
 43.35);

  this.AssertCssColor(
  "\n \t\n\r\r\n\rhSl(1405.44682\n\n,+7.1412428%\r\r, \r \r\r\n+08%\t)\r",
  21,
 18,
 20,
 255.0);

  this.AssertCssColor(
  "\n \n\r\rRgB(\t000004.0737604%\t\n\n,9.0855734687%,4%\n\t\r \n\r)\n\r\r\r\n\r\t\r\n\r"
  ,

  10,
 23,
 10,
 255.0);
AssertCssColor(
  "\n \r\nRGBA(255 \t\t,+229\r,58,\t 000.3336)\t\n",
  255,
 229,
 58,
 84.915);

  this.AssertCssColor(
  "\n \n\r \n\t\r\thsl(4753.788199\r\r\n,0069.882%,0075.6933453%)\n \n \t\n",
  216,
 236,
 149,
 255.0);
AssertCssColor("\n rgB(\n\r+7.63136% \n,\n+1.4%\r\r,2%)\r",19,4,5,255.0);
AssertCssColor("\n#ECC2 \t\n\r\r\r\n\n",238,204,204,33.915);
AssertCssColor("\n#FBcee2\t",251,206,226,255.0);
AssertCssColor("\n#Fbb",255,187,187,255.0);
AssertCssColor("\n#bFbBBE",191,187,190,255.0);
AssertCssColor("\n#fCBDADAb",252,189,173,170.85000000000002);

  this.AssertCssColor(
  "\nHsl(\r\n\t-6448.51,\n\n\n \n\n\n+29% \r\t\n\t \r,49.97422%)",
  164,
 129,
 90,
 255.0);
AssertCssColor(
  "\nHsl(+3455.8675\t\n\n,8%\t\n,\n\n\t\r \n\n\r\t90% \r\r\n)",
  227,
 229,
 231,
 255.0);
AssertCssColor("\nRGB(\n +1%,\n\t\r\t2%, +87%)\t",3,5,222,255.0);
AssertCssColor(
  "\nRGBA(\t\n\t\n164 \r \n\n,00018,+145\r,+000.48) ",
  164,
 18,
 145,
 122.39999999999999);

  this.AssertCssColor(
  "\nRGBa(+6%\n\t,\n\n\t64%\r,55%,\r\r \n\r+0000.1 \n \r\t\n\n)",
  15,
 163,
 140,
 25.5);
AssertCssColor("\nRgb(\t+24.8496%,63%, \t\t+9%)\r\n\r",63,161,23,255.0);

  this.AssertCssColor(
  "\nRgb(\r\t \t\r\r\n 40.064%,+00003.28714259%\r,\r\t\n\r\t\t\n0040.1%)\n\r\t\t",

  102,
 8,
 102,
 255.0);

  this.AssertCssColor(
  "\nRgbA(\t\n\t\n\r000083%,\n\t\n\n \n\t+00089%\n \r\t\t\t\n,+83%,0000.97)",
  212,
 227,
 212,
 247.35);

  this.AssertCssColor(
  "\nRgba(\r0084%\r\r, \r \n\r+00087.28%\t,\r\n\t \n+000053.5%\n\r,0000.4828248\n \n\n\r\n)"
  ,

  214,
 223,
 136,
 122.91);
AssertCssColor(
  "\nhSL(\r+4739.6140888\r \r\n\t,+20.2%\r\r\r,+39.2%\n)\r",
  120,
 119,
 79,
 255.0);
AssertCssColor(
  "\nhSl(\n\n\n\n\r7992.0743\r\r\r,\t+71.87%\n,+4%)",
  14,
 17,
 2,
 255.0);

  this.AssertCssColor(
  "\nhsL(\t\r 2230.43928 \n\n,+9%, \r\r+1.985948396%\t \r\n \n)",
  5,
 5,
 4,
 255.0);
AssertCssColor(
  "\nhsl(\t3445.3404\r,\t0074.7324%,+000042%\r\r\n)",
  27,
 119,
 187,
 255.0);

  this.AssertCssColor(
  "\nrGB(+079.17221842579%,\r\n\n\r\r\t\n\n\n\n+14%,\t62.0% \r\n\t\r)",
  202,
 36,
 158,
 255.0);
AssertCssColor("\nrGB(+217,246\n\r,206)",217,246,206,255.0);
AssertCssColor(
  "\nrGb(\t\r \r\t\t\n+5%\n,7%,+06.19%) \r\r \t\n\r",
  13,
 18,
 16,
 255.0);
AssertCssColor("\nrGb(00022, \r\t+01,239\r\r)",22,1,239,255.0);
AssertCssColor(
  "\r\t\t\r\n\n\rRGB(+5%,\n+000045%\n\n\r ,00023.747938%)",
  13,
 115,
 61,
 255.0);
AssertCssColor(
  "\r\t\n\n\nrgb(16.3%\r \r\n,085% ,082%\n \r\r)",
  42,
 217,
 209,
 255.0);

  this.AssertCssColor(
  "\r\t\n\n\rHsl(9632.98003,\r\r+7%\n\n \r,\n \n\t\r\r\r\n+1.5156934%)",
  3,
 3,
 4,
 255.0);
AssertCssColor("\r\t\nRgBa(\n15.8%\t\t,+25.93%,+7.7%, \n00.15)",40,66,20,38.25);

  this.AssertCssColor(
  "\r\t\r\t\n\r\r\t\t\t\n\thSl(\n\t 8181.561\r,+53%,\n\n\r\r+001%)",
  2,
 1,
 3,
 255.0);

  this.AssertCssColor(
  "\r\t\r\r \n \rrGB(8%,+0.9%,\t\n\n\t +75%\r\r)\n\r\r\n\r\n\t",
  20,
 2,
 191,
 255.0);
AssertCssColor("\r\t\r#FFEaABB6\n \r\n\r",255,234,171,182.07);
AssertCssColor(
  "\r\t\rrGba(+19.766% ,\r+5.56495%,+13.38233832%,\t0000.476)",
  50,
 14,
 34,
 121.125);
AssertCssColor(
  "\r\t \r\n \rhsl(6430.153,\n\n\r\n\t\n+070%,+32% \n) \r\r",
  138,
 24,
 119,
 255.0);
AssertCssColor("\r\t#BAe",187,170,238,255.0);
AssertCssColor(
  "\r\tHSl(\r5628.51049\r\r\n\n\n\n ,\r3%,+33%\n)\t\r\r",
  81,
 82,
 86,
 255.0);
AssertCssColor(
  "\r\tHsL(2929.4 \n,\n\t \n \t 7%\t\t\t\t ,\r\n\n1%)",
  2,
 2,
 2,
 255.0);
AssertCssColor(
  "\r\tRGbA(0084.1%\n\t\n\r\n \r ,+3.405567%,+00014%,\t.69)",
  214,
 9,
 36,
 175.95);
AssertCssColor(
  "\r\tRgba(\n\r\t\r20%,4%,+086.1%\t\t\r\r ,+0.129334\n)",
  51,
 10,
 220,
 33.15);
AssertCssColor("\r\thsl(0185,94.50%,+000049.163658506%)",6,224,243,255.0);
AssertCssColor("\r\n\t\t\t\r\n\n#cefb\t\n \r\n",204,238,255,186.915);

  this.AssertCssColor(
  "\r\n\t\nHsL(\r\r\r\n\n\n \r\n-8289.842947645,\r36%,0028%) \r\r ",
  97,
 45,
 54,
 255.0);

  this.AssertCssColor(
  "\r\n\t\r\n\n rgb(+80.126%\r\t\r\t\n\r,\n\r\n\n\t\n\r\r13.39859846%\r\r\n,\t +45.07604%)"
  ,

  204,
 34,
 115,
 255.0);
AssertCssColor(
  "\r\n\n\t\t\nhSL(-0949,\r00068.8%\r\r\t , \n3.60714633933%)",
  2,
 15,
 5,
 255.0);
AssertCssColor("\r\n\n\t\r\t#6fbADCcD",111,186,220,205.02);

  this.AssertCssColor(
  "\r\n\n\t hSl(-6064,\t\n\r \n\t\r\r+00096%,\r79%\r\r\n)\r \r\r",
  252,
 246,
 150,
 255.0);
AssertCssColor("\r\n\n\n\r\t\t#CCeaE9\n\n\n \r",204,234,233,255.0);

  this.AssertCssColor(
  "\r\n\n\n\rHSl(\n\r\n\r\t\r\n\r\n\n-2873,\r\n\n \n7%\t,+7%)\r ",
  19,
 16,
 16,
 255.0);
AssertCssColor(
  "\r\n\n\n\rhsL(\n\t \n\n \n \r 7168,+8%,\n\r+000066.84%)\n",
  177,
 163,
 170,
 255.0);
AssertCssColor("\r\n\n\n#baB6",187,170,187,102);

  this.AssertCssColor(
  "\r\n\r\t\t RGb(\n\r+0.1%\n\n,0% ,\n\r\n\n\n +36.950643%)\t \n\r ",
  0,
 0,
 94,
 255.0);
AssertCssColor("\r\n\r\t\nhSL(2724,+0048%\r,9.01%)\r",11,25,34,255.0);
AssertCssColor(
  "\r\n\r\t\r\n\nRGB(\t000051%\n , +5%\t,+00097.156%\r)\r\r\t",
  130,
 13,
 248,
 255.0);
AssertCssColor(
  "\r\n\r\t \r\n \r\rhSl(+8325.76\t,\t\r\n7%,\n89.983%)",
  231,
 230,
 227,
 255.0);
AssertCssColor(
  "\r\n\r\n\r\nhsl(\r\r+0455.8,\r\t\n\r\t\r4%, 015.22%\r\n)",
  38,
 40,
 37,
 255.0);
AssertCssColor("\r\n\r\n#aA0Dab\t",170,13,171,255.0);

  this.AssertCssColor(
  "\r\n\r\nhsl(\r\n-1224.76396,6.1594236%,95.67%\n\t\r\n\n\r\r)",
  243,
 243,
 244,
 255.0);
AssertCssColor(
  "\r\n\r \t\r \r\r\n HSL(0690\r \n \t,00057% \r,+54%\r)\n\n",
  204,
 70,
 137,
 255.0);
AssertCssColor("\r\n\r \n\t\r\r#c5cc",204,85,204,204);

  this.AssertCssColor(
  "\r\n\r \r\r\tRGb(0084%,\n\n\n\t+6.39%\t\r,\n+00021%\r\n)\n\r\r\n\n",
  214,
 16,
 54,
 255.0);
AssertCssColor("\r\n\r#aBbEfaeD\n",171,190,250,237.15);
AssertCssColor("\r\n\r#dfbA\r\t\n\n\r",221,255,187,170.085);

  this.AssertCssColor(
  "\r\n \thSl(\r\t-6782.63\r\t \n\n\r \n \t\n,8.6%,+000082.0695407%\r)\n",
  213,
 212,
 205,
 255.0);

  this.AssertCssColor(
  "\r\n \n\r \r\tRgBA(8.20% ,\t\r\n\n\r2.8%,\t\r\r5.3%\r\n\n\r \r\n,\r00.9)\r\n\n\t\r\n \t\r"
  ,

  21,
 7,
 14,
 229.5);
AssertCssColor(
  "\r\n RGB(\n\r\n\r+36.1082358%,\r+003% \r \t,025.3%)\n\r\r",
  92,
 8,
 65,
 255.0);

  this.AssertCssColor(
  "\r\n RgB(\n\t\n\r\t\r\t \r\n2.26849997%\r,00085.1%\r\r\n\n\t\t,+4%\t)\t\r \r\n\r"
  ,

  6,
 217,
 10,
 255.0);
AssertCssColor(
  "\r\n hsl(4605 , \t36.33%,\r \t094%\r\r\r\r \n)",
  242,
 234,
 245,
 255.0);
AssertCssColor("\r\n#7fd6FCda\n",127,214,252,218.025);
AssertCssColor("\r\n#eff",238,255,255,255.0);
AssertCssColor(
  "\r\nHsL(8445.733\t\n\n\n\n \r\t,\n\n\r\r58%,\n+5.66179%)",
  6,
 22,
 18,
 255.0);
AssertCssColor(
  "\r\nHsL(5471,000075%,\r \r\r\t+56%\r\n\r \r)\n\n\r \r",
  196,
 226,
 58,
 255.0);

  this.AssertCssColor(
  "\r\nRgbA(+36.899%,\r9.998%\t\r\r,00014% \r,\t\n\n\t\r+00.5797)",
  94,
 25,
 36,
 147.89999999999998);

  this.AssertCssColor(
  "\r\nhSL(\r-3099.281194078,\r\r\r\r+00084%,\n\r+0057.56%\n)\r\r",
  55,
 237,
 118,
 255.0);
AssertCssColor(
  "\r\nhSL(1813\n\n,00047.735802761%,\n\n80.53%\n)\t \n \n",
  229,
 191,
 181,
 255.0);
AssertCssColor("\r\nhsL(\n9072.72039,8%,96%)\n \t\n\n",245,245,243,255.0);
AssertCssColor(
  "\r\nrGB(\t\t+08.9310%,\r\r\r\n+6%,\n \n\n+0%\t)",
  23,
 15,
 0,
 255.0);

  this.AssertCssColor(
  "\r\nrgb(\n\n\t\t\r+60%,\n\r\r\n +55%\r\t\r\t\n,\t\t\n91.544%)",
  153,
 140,
 233,
 255.0);
AssertCssColor("\r\r\t\r\r #cD3\t\t\n",204,221,51,255.0);

  this.AssertCssColor(
  "\r\r\t \r \r\t\r\rRgba(78.83986404%\n\n\n\n,9%,+08.26%\r\n,00.1\n \r\r)\t",
  201,
 23,
 21,
 25.5);

  this.AssertCssColor(
  "\r\r\n\t \n\t\n\nRgb(70.194465936%, 26.532%\t\r,\t\r\t\r\r\r+029%)",
  179,
 68,
 74,
 255.0);
AssertCssColor("\r\r\n\n\n \n\n#BADF\t",187,170,221,255.0);

  this.AssertCssColor(
  "\r\r\n\r\t\r \t\r RGbA(88%, \r\r \r \n5%\r\t , \n+036.9351814%,\r \r.4877\n\t\r\t)\r\r\n\r\t\n\r\t\n"
  ,

  224,
 13,
 94,
 123.92999999999999);
AssertCssColor("\r\r\n #17FbfD\n\r\t",23,251,253,255.0);
AssertCssColor("\r\r\n#dDe6\r\t\r",221,221,238,102);
AssertCssColor("\r\r\r\t\t\r \r\r#bDbDDB\t\t\n",189,189,219,255.0);
AssertCssColor(
  "\r\r\r\n#Eb00BFEE\n\r\t\n\t\n\n\r\n",
  235,
  0,
  191,
  237.91500000000002);
AssertCssColor("\r\r\r\r\r\n#AD1B",170,221,17,186.915);
AssertCssColor(
  "\r\r\r\r\r\rrGb(+75%,+038.0%,+0044%\n\r \r\r\n\n)",
  191,
 97,
 112,
 255.0);

  this.AssertCssColor(
  "\r\r\r\rhsL(+9251.316 \r \n\n\n\n\n,+0023.976948%, +000093.373189060%\t)",
  235,
 234,
 242,
 255.0);
AssertCssColor(
  "\r\r \nhsL(\r\r\t6526,\n\t+61%,0051.9834%\r\t)",
  207,
 172,
 57,
 255.0);
AssertCssColor("\r\r \r\n#08c\r\n\n",0,136,204,255.0);

  this.AssertCssColor(
  "\r\r RgbA(\n\t+05%\t \r\n ,\r\n \r\n\n\r+3%,\n \t\r\n0.3%,\r0.1755)",
  13,
 8,
 1,
 44.879999999999995);
AssertCssColor("\r\r#Bfe4EEBb\r\n\r",191,228,238,186.915);
AssertCssColor("\r\r#Eaa\r\t\r\n\r\n\r \t",238,170,170,255.0);
AssertCssColor("\r\r#ffBb\r\t\n",255,255,187,186.915);
AssertCssColor(
  "\r\rHSL(+2205.6,42.299%,\r\n\t\n\n033.125221%)",
  120,
 103,
 48,
 255.0);
AssertCssColor(
  "\r\rRGB(5.97%\t\r\t\r\r\r\r\r\r\n\r\n,\r\r059%\n\n,8.020%)",
  15,
 150,
 20,
 255.0);
AssertCssColor(
  "\r\rRGbA(91.643%,\t \n00010%, \n\r+6.30%\t , \r0.217)",
  234,
 26,
 16,
 55.08);
AssertCssColor(
  "\r\rRgb(\n\n\r\r\t\n +3%,\t\n\n+0055.92%,+82.7067%)\r",
  8,
 143,
 211,
 255.0);

  this.AssertCssColor(
  "\r\rRgba(073.804156%,\n\n\t\t\r\n+89%,+00003.88587%\r\n,\t\n0000.37\r\t)",
  188,
 227,
 10,
 94.35);

  this.AssertCssColor(
  "\r \n\t\trGbA(3.9872330%,84.465875%\n \n ,+6.11%,\n\n+00.6)",
  10,
 215,
 16,
 153);

  this.AssertCssColor(
  "\r \n\r\n hSL(\r8038,\t+0047.320285%,9.9%\r\t \t\r) \n\n\r",
  14,
 37,
 13,
 255.0);
AssertCssColor(
  "\r \nRgB(\r00028%,\t\t\r\r\r\r057.13%,+04.839%)",
  71,
 146,
 12,
 255.0);

  this.AssertCssColor(
  "\r \nrGbA(\n\r\t\n\t\n+1%,+46%,\n\n\t\r\t\n0.5%,\n\n+.0\r\n)\n",
  3,
 117,
 1,
 0);
AssertCssColor(
  "\r \r\n#7bEEEe9c \r\r\n\t\n\t ",
  123,
  238,
  238,
  155.54999999999998);
AssertCssColor(
  "\r \r\nhSl(-9022.83 \r\r \r,\n3.447714% \r\r\r\n\n,+1%)",
  2,
 2,
 2,
 255.0);
AssertCssColor("\r \r \r #3Cc",51,204,204,255.0);
AssertCssColor(
  "\r \rHsL(6291.1\t\n\t\r \n\n \n,7%,\n\n\r +87%\r\n\n)",
  219,
 224,
 223,
 255.0);

  this.AssertCssColor(
  "\r \rRgbA(+172\n\r\t,\r \r+129,\r\r\r\t\r\t\r\n 157\t\r\n\n\n\n,000.3011\r\t \n)"
  ,

  172,
 129,
 157,
 76.5);
AssertCssColor("\r \n\t\t\r rGB(+000087%,+086%,90.8653%)",222,219,232,255.0);

  this.AssertCssColor(
  "\r \r\r \r\n\nrGba(000033%\n\n\n \n,\r\n\r\t+25.58628%,32.096%\n\n,\n000.815856\n)"
  ,

  84,
 65,
 82,
 208.07999999999998);

  this.AssertCssColor(
 "\r HSL(+4768.70607\n,4.896%,\n\r\t\r\n\r \r\n000034%\r\n\n)\n \n\n \n\t \t\n",

  86,
 90,
 82,
 255.0);

  this.AssertCssColor(
  "\r RGb(\r\n\r\n\n 27.740108539672%\r\r\n\n\t,\t\t\n 89.2%\n\n\r ,\r\r 0074.9%)\r\r"
  ,

  71,
 227,
 191,
 255.0);

  this.AssertCssColor(
  "\r RGba(\t\n\t \n +9.21854%,0027%\n,\t+6%\r\t \r,\r\r\r\r\n\n+0.1258813 \r) \t\n\n\n"
  ,

  24,
 69,
 15,
 31.875);
AssertCssColor(
  "\r hSl(\n8326,087.43332%, \t+000084.6726547%)",
  250,
 234,
 181,
 255.0);
AssertCssColor("\r#ABAfa5F7\r\n",171,175,165,247.35);
AssertCssColor("\r#AFbFDDE8\r\r\n\t\r\n\t",175,191,221,232.05);
AssertCssColor("\r#FDaa\r\n ",255,221,170,170.085);
AssertCssColor("\r#fAcd\n\r",255,170,204,221.085);
AssertCssColor(
  "\rHSL(\r\r \r\r\n6141,+4%,000095%)\r\n\r\r\r",
  242,
 242,
 241,
 255.0);

  this.AssertCssColor(
  "\rHsL(\r\r\r\r \t6554,+00096.51231690%\t\t \n,\n3%\n\n\r\n\r\n)",
  11,
 15,
 0,
 255.0);
AssertCssColor("\rHsl(\n\r\r \r9737\n\r\r,98.55698%,3.568%)\r\r",18,5,0,255.0);

  this.AssertCssColor(
  "\rHsl(+9989.77\r\r ,\r\n5.021513%, \r\r\r\t\r\t+99%\n\r \r\r\r) ",
  252,
 252,
 252,
 255.0);
AssertCssColor(
  "\rRGBa(\n\n\r\r\t\r+2.5%,+000006% ,+7.0%, .66)\n\t\r",
  6,
 15,
 18,
 168.3);
AssertCssColor("\rRgB(\r\n66\r ,+137,\r\n\n+000033)\r\n \r",66,137,33,255.0);

  this.AssertCssColor(
  "\rRgb(\r\t\r\n+00094.9949806326%\r \r \n\t \t,\r\n\r+5%\r\r\t\r\r,\r\r\r\n\r \n\r\r86.8%)\r\t"
  ,

  242,
 13,
 221,
 255.0);

  this.AssertCssColor(
  "\rRgb(+9.385%\n\r\r\t,\r2.786%,\n\r\r \r\n8%)\n\t\r\n\r\n\t\t\n\r",
  24,
 7,
 20,
 255.0);
AssertCssColor(
  "\rRgbA(\n\t12.3%,+87.11% \n,\r\r45.1614%,\r\t000.6887)",
  31,
 222,
 115,
 175.95);
AssertCssColor(
  "\rhSL(\n\n 5277.3,+75.4388%\n ,\r+73.4%\r)\t\r\r ",
  135,
 140,
 238,
 255.0);
AssertCssColor(
  "\rhSl(\n-8175.4\n\n\r \r,40.19505471%\n,\t 51%\r)",
  105,
 180,
 79,
 255.0);
AssertCssColor("\rhsL(-9334\r,\r \r37%,\t\r0086%\n)\n \t\n",232,217,206,255.0);
AssertCssColor(
  "\rhsl(\r\r+5311,\r\r3.6104% \n\r\n \r,\t\r\n \r28.3239%)",
  72,
 69,
 74,
 255.0);
AssertCssColor("\rhsl(2796\n,+1%\n, +004%)\r \n\t\n\n\n",10,10,10,255.0);

  this.AssertCssColor(
  "\rrGBA(+43%\r\r\r \n,+85.6036%\r\n\n,\n\n000011%\r,\r\n\t\n\n \n\n\r\n.119183238 \r)"
  ,

  110,
 218,
 28,
 30.09);
AssertCssColor(
  "\rrGBa(0089%\r\n,+0013%,32%, \r\n\n\t\n\n+.77007298)",
  227,
 33,
 82,
 196.35);
AssertCssColor(
  "\rrGb(\t 5.53%,\n\t\n+65.8930% \r\n,000042%)\t\r\r",
  14,
 168,
 107,
 255.0);

  this.AssertCssColor(
  "\rrGb(\n\r\n\n \r\r\r83%\r \r\r,+087%\n\n\n\n\n,\n\t\t\r\n\n\r\t\n070%)\r \r\n\r \n"
  ,

  212,
 222,
 179,
 255.0);

  this.AssertCssColor(
  "\rrGb(\r\n\n\n\n69%,6.84%\r\r\n ,+094.0%\n\r \r\t\r)\n\r\r\n \t \r",
  176,
 17,
 240,
 255.0);
AssertCssColor("\rrGb(134, 64\t\n,158 \r\t \n \n)\n",134,64,158,255.0);

  this.AssertCssColor(
  "\rrGbA(044.6% \n,\r+84.830%\t ,\r+00052%,\n\n\n\r00.77) \r\n\n",
  114,
 216,
 133,
 196.35);

  this.AssertCssColor(
  "\rrGbA(85%,\n\n\t \n\n\n+7.5%,\t\r\r\r\r\n\n\r\n\r74%\n\n\n\r\n ,+0.8 \n \n\r\n\t\n \n)"
  ,

  217,
 19,
 189,
 204);
AssertCssColor(
  "\rrgB(+76.9802647%\n\r,+9%\r,\n\t050.83%)\t\t \n\r ",
  196,
 23,
 130,
 255.0);
AssertCssColor("\rrgB(77%,\r051%\n,+14%)",196,130,36,255.0);
AssertCssColor("\rrgb(\t4,\n\t\r+101,+10\r\n)\n\r",4,101,10,255.0);

  this.AssertCssColor(
  "\rrgb(\r\r+00.1%\r,58%\r\r\t\t,\r \n\r\r\t\n 0029.43908%\n)\n\r",
  0,
 148,
 75,
 255.0);
AssertCssColor("\rrgb(16.018132865731%,+9%,00052%\t)\r",41,23,133,255.0);

  this.AssertCssColor(
  "\rrgba(\t\n \r\r\r\r\t5%\n\n\n,\r0038.7%\n ,\r\r\n000037%,\n\r\r\n.4925747045\n\r \r \r)"
  ,

  13,
 99,
 94,
 125.97);

  this.AssertCssColor(
  "\rrgba(\r\t00007.1871%\r,+07% \n\t\r ,+094%,\t\r \t\r\n\n0000.9444096) \n",
  18,
 18,
 240,
 240.975);
AssertCssColor(" \t\t\thsl(4352.005\r,\n\r\r6.4%,+5%)\n",13,12,11,255.0);
AssertCssColor(" \t\t#ebac1FcD",235,172,31,205.02);
AssertCssColor(
  " \t\nHsl(6910.2946,\n \n+7.903%\n\t\n\r\t ,\r24%)",
  64,
 66,
 56,
 255.0);

  this.AssertCssColor(
  " \t\nRgBA(\r\n\r+0%,\n\r\r\r000081%\t\n\r\n\r\t \t,27%,\r \n0000.2)",
  0,
 207,
 69,
 51);
AssertCssColor(" \t\r\t\n\r\r\rRgB(16%,+0%,+81%)",41,0,207,255.0);
AssertCssColor(
  " \t\r\t \r\n\trGbA(8%,3.66756%,62.9%,+0000.49) ",
  20,
 9,
 160,
 124.95);
AssertCssColor(
  " \t \n\r\r\r\nhSl(\t\n0493,\n\n\n+04.034679%,8%)",
  19,
 21,
 19,
 255.0);
AssertCssColor(" \t \r\r\n\r#ebDf",238,187,221,255.0);
AssertCssColor(
  " \tRgB(\r\n\r\r\n\r \r\r+1%,52%,22.3158228104%)",
  3,
 133,
 57,
 255.0);

  this.AssertCssColor(
  " \thSl(\t\r\n\r\r-8530 \n, \n\t \r+00057%,\n\t\n\r+9%\r\t)\n\r",
  14,
 36,
 9,
 255.0);
AssertCssColor(" \n\t\tHSl(-7671.9,+66.59%,+4%)",5,3,16,255.0);

  this.AssertCssColor(
  " \n\t\r \n\nHSL(\n\n\r\r+8509\n\r\r \t\r\n\n\n\n ,+5%\r\t \r,39.35840%)",
  95,
 97,
 105,
 255.0);

  this.AssertCssColor(
  " \n\n\t\n\r\n\r\n\nHsl(\n\n\r\r2476,\r\r\r+06.63%,\r\n\n\r\n\n54.8%\n\n\n\r \n\n \t\n)"
  ,

  147,
 132,
 143,
 255.0);

  this.AssertCssColor(
  " \n\n\nrgBA(\t +000074.75569185%\r\r,+022%\n\t\n\r\n\n\n,+4.7%\r\r \t\n\n\r,0.685705599)"
  ,

  191,
 56,
 12,
 174.93);
AssertCssColor(" \n\n \r\n\r\n\n\t#2EbB7A",46,187,122,255.0);
AssertCssColor(" \n\n#1AEAbCC7\t \n\t\r",26,234,188,198.9);

  this.AssertCssColor(
  " \n\nRgb(+000088.1107%\r\t\n\n\t\n\r\n\n\r\r,+53.1063% \r\n\n,+48%)",
  225,
 135,
 122,
 255.0);
AssertCssColor(" \n\r\n\n#bd27",187,221,34,119.08500000000001);

  this.AssertCssColor(
  " \n\r\n\r\n\n\t\r RGba(129\n\n\r , \r\n \r+3\n\t\r,+252, \r\n\n.9\n\r \n\n)\n",

  129,
 3,
 252,
 229.5);

  this.AssertCssColor(
  " \n\r\nRgbA(\r \r\n 00050%, 4.5%,\r\r\r54.1924%\t\n,000.36 \n)",
  128,
 11,
 138,
 91.8);

  this.AssertCssColor(
  " \n\r\r\t\r\r\rhSL(+9638.397\r\n,\r\r\r\t\r+95.9% \n\r \r\t\n ,\r\n\r000054.6698609121%\r\t\n)"
  ,

  170,
 28,
 250,
 255.0);

  this.AssertCssColor(
  " \n\r\rRgb(\r \r\r0.4794%,\n\n 000091.85438024%\t\n\r\r\r\r\r\r\r,\t+9%)",
  1,
 234,
 23,
 255.0);
AssertCssColor(" \n\rRgB(+06% \r\n,\r\t\t\n0%,\r\n\n+90.5%)",15,0,231,255.0);

  this.AssertCssColor(
  " \n\rhsL(+6532\r,\r\r\t9%\n \t \r\r\r\r\n,\n\n \r\t+00018.58%\t \r\r\n\n\r\r)",

  51,
 50,
 43,
 255.0);
AssertCssColor(
  " \n \n\n\r\n RGb(000046%\n\t,\t 52.4438%,+52.822%)",
  117,
 134,
 135,
 255.0);
AssertCssColor(" \n \n rGb(+62.6%, +8%\n\t \n\t\n\r,040%)",160,20,102,255.0);
AssertCssColor(" \n \r RGb(\n+197, +121\n,241)",197,121,241,255.0);

  this.AssertCssColor(
  " \n \n\t RGb(09.1641%,+9%\t\n\r\n\r \n ,\n \r\n\t\t \t+037.717455902%\n\r\n\n)\t \r\n\n\r\t"
  ,

  23,
 23,
 96,
 255.0);
AssertCssColor(" \n#b4e0 ",187,68,238,0);

  this.AssertCssColor(
  " \nRGb(\r\n\r\n 63%\r\t\t\n,\r\t\t\r \t\r\r000059%,\r+38.1587113%\t \r \t\r\t\t)"
  ,

  161,
 150,
 97,
 255.0);
AssertCssColor(
  " \nhsL(0266 \n\r\r,\t+6%\r\t, \r0097.899% \n\t\t\r)",
  249,
 249,
 249,
 255.0);

  this.AssertCssColor(
  " \nrGba(\n\r\n044%,\t\r \r\t+76.10695%,\n\n\t\r\r96.4%\r\t\r\n\t\n\n,\t \r000.7666\n)\t\r\r"
  ,

  112,
 194,
 246,
 195.07500000000002);

  this.AssertCssColor(
  " \r\t\r\r rgb(+00094% ,+26.020778%,\n\r\r\n+042.525283%\r\r)\r\n\r\n\n\t\r\r\n"
  ,

  240,
 66,
 108,
 255.0);
AssertCssColor(" \r\thsl(\r7368.75,+9%\n,\n44.588%\r)\t\r",103,123,120,255.0);

  this.AssertCssColor(
  " \r\n\t\t\n\n\n\tRgba(+55.7183876%\r\n\r\r\t\t\r\t,91.80%,\r \t\n 4.062%,+0.20153) "
  ,

  142,
 234,
 10,
 51);

  this.AssertCssColor(
  " \r\nhsL(3292.7\r\r\r\r,+024%\r\r\r\t\n\t \n,\t\r\r+56%) \n\r\r",
  169,
 163,
 115,
 255.0);
AssertCssColor(
  " \r\r\t\nRgB(0081%\r,\n\r\n\n\n\r43% ,+40.788494%\r\r)",
  207,
 110,
 104,
 255.0);
AssertCssColor(
  " \r\rRGb(\r+9% ,0086.4% ,\r\r\n\n\r \r\r\r0.4736%)\t\n\r\t",
  23,
 220,
 1,
 255.0);
AssertCssColor(
  " \r\rRGba(+064.7%,0070% \r\r,\n \r+23.6%\n,00.78)",
  165,
 179,
 60,
 198.9);
AssertCssColor(" \r#BeDFCA \n",190,223,202,255.0);
AssertCssColor(" \r#Cf6dEB",207,109,235,255.0);
AssertCssColor(
  " \rHSl(\n\r\r-3922.844\r\r \r,00045%,+33.2%\t\r)\r",
  122,
 93,
 46,
 255.0);
AssertCssColor(" \rhsl(+1699\r\t\r\n\n,0096%, \r2%\n\r\n) \n\n ",3,0,9,255.0);
AssertCssColor(" \rrgB(+00038.5787%,+008.564%,+95.904069422%)",98,22,245,255.0);

  this.AssertCssColor(
  " \n\trGB(00071.019996%\n\r,\t\n\r\n000054%\r ,\t\t00059.405%)",
  181,
 138,
 151,
 255.0);

  this.AssertCssColor(
  " \n\n\n\n\n\r hsl(\n3555.3\r\t,30.40% \r,\r+80.47657552% \t\r)\r\n\r \t\n\r\n \r"
  ,

  220,
 190,
 212,
 255.0);

  this.AssertCssColor(
  " \n\r\r\t\r\nrgBA(4.7%,\r\n\n \n+6.3% ,\r\n\r\n\r\n+36%,+00.128\r)\r",
  12,
 16,
 92,
 33.15);
AssertCssColor(" \n \n#FEC",255,238,204,255.0);
AssertCssColor(" \r\r\n \t\r\n#beAC\n",187,238,170,204);
AssertCssColor(" \r#8B90",136,187,153,0);
AssertCssColor(" \r\t#F7decc",247,222,204,255.0);
AssertCssColor(" #CedcaF",206,220,175,255.0);
AssertCssColor(" HSL(\r\r3496,8%\r \r,\r\n32.96%)\r \r\n\t\r ",80,77,90,255.0);
AssertCssColor(" rgB(\r\t\r\n3.4%\n\n\n,0088%,\n\r\n05%)",9,224,13,255.0);
AssertCssColor(" #9aEDbD",154,237,189,255.0);
AssertCssColor(" HSL(\r5776.237 \t,29.15%,+23.6367%)",77,52,42,255.0);
AssertCssColor(" Hsl(\r9595.1023029, 73%\n,8.870%\n)\t\r\t\r",6,8,39,255.0);

  this.AssertCssColor(
  " Hsl(+2609.724284295\n\t\r \n\n\r\t,+3.00144229606%,+0088.65%\n\n\r\r\r\r)\t\n\t\t\n"
  ,

  226,
 226,
 225,
 255.0);
AssertCssColor(" RGB(5\n,119\r\r\n,\r\n\r\n+3\r\t\r\n)",5,119,3,255.0);

  this.AssertCssColor(
  " RGbA(\t00072%,\n\r\r\r +3.45%, \r\n +19%\r,\r\r0.857\r\r \r)\r",
  184,
 9,
 48,
 219.29999999999998);
AssertCssColor(
  " RgB(+031%,\n\t\n\r+00072.60152475%,0054%)\r\r\n",
  79,
 185,
 138,
 255.0);

  this.AssertCssColor(
  " Rgb(\n\t081.5667%\n\n\t\r\n\t\n \r,\t\n+81.128%\r,\n3.477%\n\n) \n\r\t\n\t",
  208,
 207,
 9,
 255.0);

  this.AssertCssColor(
  " RgbA(\r\t\t\r\n 068%\r,029.54195529%,+93.3%,000.24593547808\r\t\n\r)",
  173,
 75,
 238,
 62.985);
AssertCssColor(" hSL(\r-3753.42,\r\r\t \t\n\t\r\n74%\n ,\n+2%)",1,5,8,255.0);
AssertCssColor(" hSL(+3156.26,\r\r9.186595%\r,\r40%)",103,92,111,255.0);
AssertCssColor(" hSL(1302,\t+2%\t,\n+004%)",9,10,10,255.0);
AssertCssColor(" hSl(\t \r \t\r\t\n6147,19%,3%)",9,7,6,255.0);

  this.AssertCssColor(
  " hsl(\r\n1455.04288 \n\t\r,\t+000048.003%\n\r\t\r\n \n,0.0%)\n\r",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  " rGb(0073.554772133%,+008%\r\r\t,\n\r\n \n+47.081862359%\n)",
  188,
 20,
 120,
 255.0);
AssertCssColor(
  " rgbA(18\n\n\r \n\r\n ,\r+138\t\n,+6\n\n\n , \r 00.4)\n\n",
  18,
 138,
 6,
 102);
AssertCssColor("#0BBa",0,187,187,170.085);
AssertCssColor("#0DeaBCfA",13,234,188,249.9);
AssertCssColor("#0daBDCFB\r",13,171,220,250.92);
AssertCssColor("#1Dd",17,221,221,255.0);
AssertCssColor("#1bEe",17,187,238,237.91500000000002);
AssertCssColor("#291b0Cef",41,27,12,238.935);
AssertCssColor("#2BBc\n",34,187,187,204);
AssertCssColor("#3BD",51,187,221,255.0);
AssertCssColor("#3fF4\r\r",51,255,255,68.08500000000001);
AssertCssColor("#4DCE0dDF",77,206,13,223.125);
AssertCssColor("#537",85,51,119,255.0);
AssertCssColor("#5cBA",85,204,187,170.085);
AssertCssColor("#6Dbc0c\r",109,188,12,255.0);
AssertCssColor("#6cb\t\n",102,204,187,255.0);
AssertCssColor("#77bc \n\r\n\t\n\n\n\r",119,119,187,204);
AssertCssColor("#7ADE\n",119,170,221,237.91500000000002);
AssertCssColor("#7Df\r\r\n\r\t\n\r\n",119,221,255,255.0);
AssertCssColor("#9dD",153,221,221,255.0);
AssertCssColor("#AB9baE",171,155,174,255.0);
AssertCssColor("#ABda",170,187,221,170.085);
AssertCssColor("#AEF4ba",174,244,186,255.0);
AssertCssColor("#AF5",170,255,85,255.0);
AssertCssColor("#AFE\t \r \n\n\r\n",170,255,238,255.0);
AssertCssColor("#AaEc\t",170,170,238,204);
AssertCssColor("#AeDB\r\n",170,238,221,186.915);
AssertCssColor("#AfCfFC",175,207,252,255.0);
AssertCssColor("#BAfdfaaE",186,253,250,173.91000000000003);
AssertCssColor("#BEc",187,238,204,255.0);
AssertCssColor("#BFDe",187,255,221,237.91500000000002);
AssertCssColor("#BbfaadFA\r\r",187,250,173,249.9);
AssertCssColor("#C0c",204,0,204,255.0);
AssertCssColor("#CBFcBb \r\n\n\n ",203,252,187,255.0);
AssertCssColor("#CCCBeda6",204,203,237,165.75);
AssertCssColor("#CCaabf \n\r",204,170,191,255.0);
AssertCssColor("#CEb16dF9\n \r",206,177,109,248.88);
AssertCssColor("#Cdd",204,221,221,255.0);
AssertCssColor("#CeD6EcE6\t\n",206,214,236,229.5);
AssertCssColor("#D0bd",221,0,187,221.085);
AssertCssColor("#DBb3\r\t\r\t \r",221,187,187,51);
AssertCssColor("#DFf7dF\r",223,247,223,255.0);
AssertCssColor("#DbFd\r\r\t\r",221,187,255,221.085);
AssertCssColor("#Dca",221,204,170,255.0);
AssertCssColor("#E8dD\n",238,136,221,221.085);
AssertCssColor("#EBEBCCAd\r\r\r\n\n\r",235,235,204,173.4);
AssertCssColor("#Ec9b \n \n\r\t",238,204,153,186.915);
AssertCssColor("#EffEBAEe \n\t\n",239,254,186,237.91500000000002);
AssertCssColor("#FEDB \n\n\t",255,238,221,186.915);
AssertCssColor("#FEca\r\t",255,238,204,170.085);
AssertCssColor("#Faf5Fbbe\n\n\r",250,245,251,189.975);
AssertCssColor("#FcfD",255,204,255,221.085);
AssertCssColor("#aACdff\r\r\t\r\t",170,205,255,255.0);
AssertCssColor("#aDbb9f",173,187,159,255.0);
AssertCssColor("#aEdb2F\n ",174,219,47,255.0);
AssertCssColor("#aF8DEa \n\r \t\n\r",175,141,234,255.0);
AssertCssColor("#ab9 \r\n\r",170,187,153,255.0);
AssertCssColor("#bBeBDBef\r\r",187,235,219,238.935);
AssertCssColor("#bCbA\r\t ",187,204,187,170.085);
AssertCssColor("#bdCDFF",189,205,255,255.0);
AssertCssColor("#cDcF\t\r\r",204,221,204,255.0);
AssertCssColor("#cac",204,170,204,255.0);
AssertCssColor("#cc9A\t",204,204,153,170.085);
AssertCssColor("#cdAe\n",204,221,170,237.91500000000002);
AssertCssColor("#d3E",221,51,238,255.0);
AssertCssColor("#dBc ",221,187,204,255.0);
AssertCssColor("#dd9ebC2F\t \t",221,158,188,46.92);
AssertCssColor("#e1C\t\t\r\n ",238,17,204,255.0);
AssertCssColor("#eFeE\r",238,255,238,237.91500000000002);
AssertCssColor("#ecFB",238,204,255,186.915);
AssertCssColor("#ece",238,204,238,255.0);
AssertCssColor("#f9d7",255,153,221,119.08500000000001);
AssertCssColor("#fAeA",255,170,238,170.085);
AssertCssColor("#fDe \r ",255,221,238,255.0);
AssertCssColor("#fb7 \t ",255,187,119,255.0);
AssertCssColor(
  "HSL(\n\r 2765.6609114\r ,34.33%,\r3%\r\t\r\t\n) ",
  5,
 5,
 10,
 255.0);

  this.AssertCssColor(
  "HSL(\r\r 3044\t,+65.09646%\r\t\r\t\t\n\t,\r\r+027%)\n\t\t\n\n\r\r\n ",
  24,
 113,
 89,
 255.0);

  this.AssertCssColor(
  "HSL(\r\r3633\n\n,\n\n\r\n\n+0025%\r\n\r\n\t\n\r,+06.368882149%)",
  20,
 16,
 12,
 255.0);

  this.AssertCssColor(
  "HSL(\r \r-2438.702236\r\t\n,\r\n \r\r\n\r\n00061%\n\r\r\r\r\n\r ,000.034159289%\r\t)"
  ,

  0,
 0,
 0,
 255.0);
AssertCssColor("HSL(+8638,\t\n \t\n\r\t\n\n+18%,58.60%)",168,130,131,255.0);
AssertCssColor("HSL(+0180,+40%\r\n\n\r\r\r\t\n\r\t,+08%)",12,28,28,255.0);
AssertCssColor(
  "HSL(+4869.841\r,0053%,+2.944650483%\t\n\r\t \r)\n\r\n \n\n",
  3,
 10,
 11,
 255.0);
AssertCssColor(
  "HSL(-4163.98250,\r\n\t\t\t\r48%,+013.287%\n)\t\r\r",
  17,
 50,
 37,
 255.0);
AssertCssColor(
  "HSL(-5692,+000063.9%\t\r\r\r\r\r\r\t\n,\n \n \t+49.5%)\r",
  185,
 206,
 45,
 255.0);
AssertCssColor(
  "HSL(0284\n\n\t,+1.8%\n\n\r,\n\r+3.7%\r\r)\r\n\t \n\t\t\r\n",
  9,
 9,
 9,
 255.0);

  this.AssertCssColor(
  "HSL(2926.94785683081,\n+074.217190%,+00039%\t\r\n\n\n \n\n)\n\r ",
  173,
 141,
 25,
 255.0);
AssertCssColor("HSL(3180,\n\n\r\r\r \r\r\n\r\t29%,9%)\r",29,16,29,255.0);
AssertCssColor("HSL(6831 \r,047%,\n\r \n\n\n\n+9%)",33,12,15,255.0);
AssertCssColor(
  "HSL(7702.98\n \n\r\t\r\r\n\r\n\n,9.01%\n\r,\r+8%)",
  18,
 22,
 19,
 255.0);
AssertCssColor(
  "HSl(\t\r\r\r\r\n+2219.415\r\r,\r34.285894132%, \r\n090%)\n",
  238,
 238,
 220,
 255.0);

  this.AssertCssColor(
  "HSl(\n\r \t\r7436.9\t \t,15.154885%\t\n ,\r\n\n0036%)\r\n\r\r",
  77,
 79,
 105,
 255.0);
AssertCssColor(
  "HSl(\r\t \r+5532.92852050\n,+09%\n\r,+92%\r)",
  232,
 236,
 233,
 255.0);

  this.AssertCssColor(
  "HSl(\r\n\t9439,\n\n\r \r\n+000097.826%, \r\n\n\n \r0.988063%)\n \n\r",
  3,
 4,
 0,
 255.0);
AssertCssColor(
  "HSl(\r\r4672,\r\r\n\r\r+000041.083%,3%)\r\t\r \n",
  10,
 4,
 5,
 255.0);

  this.AssertCssColor(
  "HSl(\r+6007.27\r\r\r\r \n,\n\n\n92%,\r\n10%\n\r\t\n\n\r\n\n\n\t) ",
  7,
 2,
 48,
 255.0);

  this.AssertCssColor(
  "HSl(\n\r\t3375.9837\t \r,\r+00029%\r\r\n, \r+50.1420471%\t)\r\t\n\n",
  90,
 164,
 110,
 255.0);
AssertCssColor("HSl(\r \t\n \n\n1380,+4.0%\r,\r\t+2%)",5,4,5,255.0);
AssertCssColor("HSl(+1087.670\n,\t\n\r+5.91191365575%,\r1%\r \n)",2,2,2,255.0);
AssertCssColor("HSl(+1683\n ,1%,\n 0%)\n\n\n",0,0,0,255.0);

  this.AssertCssColor(
  "HSl(+8902,+00045.02491776126%\r\t\r \n\r,68.607%\n \n\n \r \r)",
  165,
 138,
 210,
 255.0);
AssertCssColor(
  "HSl(+9723.8,+1%\r\n\t \t\t,+72.93521%)\t\r\r\r \n\n",
  186,
 185,
 185,
 255.0);

  this.AssertCssColor(
  "HSl(-4228.43712916600 \r,87.9032% \n \t, \r\n\r\r \r\n\r21%\r)\r\n \r",
  51,
 100,
 6,
 255.0);
AssertCssColor(
  "HSl(1523, \n\n0028.8241%\n\t\n \r\n,+0028%\t)\n",
  76,
 91,
 50,
 255.0);
AssertCssColor(
  "HSl(6170\n,+1%\n,\n\r+000095.6390%)\t\t\n\r\t\n\r\t",
  243,
 243,
 243,
 255.0);

  this.AssertCssColor(
  "HsL(\t \n\n\n\r \n-6235.303\t\t\r\t\n\r\r\r\t,\n\n+5%,\r\n\n\r8.99%)",
  21,
 21,
 24,
 255.0);
AssertCssColor(
  "HsL(\n\n-6622.100\r \r\n\r\r,34% \n\r\r\t,0064%)",
  131,
 154,
 194,
 255.0);

  this.AssertCssColor(
  "HsL(\r\n\r\t\n\n\n\n \n1668.988739\n\n\r\n \n\n\n,\n\r\n79.241%,+9%\r)\n\n",
  4,
 11,
 41,
 255.0);

  this.AssertCssColor(
  "HsL(-1015,\r+000065%\n ,\r\r\r\n\n\t\t\r +068%\n\r\r\r \r) \r\r\r\n\r ",
  217,
 226,
 120,
 255.0);
AssertCssColor(
  "HsL(-0144\n\n\r \n, \r\r \n\r000076%\t\r \r,+25%\t)\n",
  15,
 54,
 112,
 255.0);
AssertCssColor("HsL(-0394, \r\n\t\n+28.3682985247%\t,+0048%)",157,87,127,255.0);
AssertCssColor("HsL(3101,+058.46%\r\n, 0024.8%)",26,49,100,255.0);
AssertCssColor("HsL(3260,94.52805%\r,\r\t\r\n\r\n021.3873%)",106,37,2,255.0);
AssertCssColor(
  "HsL(3371\t,000075.6%\r\r,\r\t22.578861717%\t\t)\n\t \n",
  14,
 101,
 30,
 255.0);

  this.AssertCssColor(
  "HsL(6893\n\n\t\n\r\n\n ,\n\n\n\n+0088.5230%\t\n,\t \n+00040.092%\n\n)\n\r\r \t \r\n"
  ,

  192,
 171,
 11,
 255.0);

  this.AssertCssColor(
  "Hsl(\t\t\n-2236.1375630287,074.598% \n,\n\t\n\n\n \r\n\r\t 60%)",
  188,
 76,
 229,
 255.0);
AssertCssColor(
  "Hsl(\t\n\n 6246\n\r\r\r,+6%,\n +13.63295%\r\n\t\r\r)",
  32,
 36,
 33,
 255.0);

  this.AssertCssColor(
  "Hsl(\n\t\r\n\t-5884\t\r\n,\t\n\n\t\r\n\r+000044%,+077.62%\r) \n\t\n\t",
  172,
 176,
 223,
 255.0);
AssertCssColor("Hsl(\n\t6653,0031%,6.869489%\r\n\n)",12,22,21,255.0);

  this.AssertCssColor(
  "Hsl(\n\n \n\t \n \n \t8569\t\n,44%\n,\t\t\r\t\r \t\r3%\t\r)",
  9,
 4,
 11,
 255.0);
AssertCssColor(
  "Hsl(\n+5458\n\t\t\t\t \t\t ,\n\t+52%,+16.8212534801%\t)",
  65,
 63,
 20,
 255.0);
AssertCssColor(
  "Hsl(\n3522\n\n\t\n,+000083.23861583%,0074%)\n",
  210,
 133,
 243,
 255.0);
AssertCssColor(
  "Hsl(\r +5761.025,\n\n\r\t \n\t\n+0087%,+98%)",
  254,
 245,
 245,
 255.0);
AssertCssColor(
  "Hsl(\r+9026.33\r\t\n,44.7%\r\n,\r\n \n\t\r+70.10%)",
  212,
 174,
 144,
 255.0);

  this.AssertCssColor(
  "Hsl(\r4644\n\n\n\r\r \n\r \t\r,\n6%,0032.32657905%\t\r\r\n\t)",
  87,
 77,
 83,
 255.0);
AssertCssColor("Hsl(5691,0060% \t,000039.0%\r\n\t\r\r)",141,39,159,255.0);
AssertCssColor(
  "Hsl(-3128.947514,\r\r\t \r\r00091.0885%,0019%\r)\n",
  17,
 92,
 4,
 255.0);
AssertCssColor(
  "Hsl(-4722.5977507006,\t+7.564259080%,5.1%)\r \t \r\n",
  13,
 12,
 13,
 255.0);
AssertCssColor(
  "Hsl(1827.3304679,+16%\t\r\t ,\t\n\r\t \n\n\r\r+94%\n)",
  242,
 239,
 237,
 255.0);
AssertCssColor(
  "Hsl(3266, +00078% \r\n\r,+60.9756%\r \n\r)\r\t ",
  233,
 145,
 77,
 255.0);
AssertCssColor("Hsl(5441.2\r\n \r\t\n\n,3.1%,0.12%\r\r)\t\t\t",0,0,0,255.0);
AssertCssColor("Hsl(8541,4.4%,+0%\r \t\n)",0,0,0,255.0);

  this.AssertCssColor(
  "RGB(\t\r+8,\r \n \r\n\t\r\n\n\t+253\r\r\t\n\r \r,\r\r\r\r178)\t",
  8,
 253,
 178,
 255.0);

  this.AssertCssColor(
  "RGB(\n\n\r\n\r\r \r\r1.186% \n,\n\t \n45.51%\r\n\r \r,\r\r \r\r\r +000025.4% \n\t\r\r\r\r)"
  ,

  3,
 116,
 65,
 255.0);

  this.AssertCssColor(
  "RGB(\n\n0.941%\r,+00061.5540%\n\r\n\n \t\r\r,+000013% \t\r\n\r\t)\r\t",
  2,
 157,
 33,
 255.0);

  this.AssertCssColor(
  "RGB(\r\t+0057% \n\r\n\n\r\t\r\r,\n87%\r\t\t\n,\t\n\r\r\r\r\r \n\r\t+71.98496%\t \r\r)"
  ,

  145,
 222,
 184,
 255.0);
AssertCssColor(
  "RGB(\r\r\n\n\t\n\n\r035%,\r+69.50%,51.78% \n)",
  89,
 177,
 132,
 255.0);
AssertCssColor(
  "RGB(+0043.2158%,\n +0020.1%\t\r,+39% \r\r\n\n) \t",
  110,
 51,
 99,
 255.0);
AssertCssColor(
  "RGB(+085%\n,\n\t\r \r00035.8119%,9.3184%\n \t\r)",
  217,
 91,
 24,
 255.0);
AssertCssColor("RGB(+1.1414426907%,+14%\t,6.891%)",3,36,18,255.0);

  this.AssertCssColor(
  "RGB(+4%\t\t,+012% \n\n\r\n\t\t,\r\r\t\n\t\n\t\n\n7%\r\r \r\r\t)\n \n\r\t\n",
  10,
 31,
 18,
 255.0);
AssertCssColor(
  "RGB(+6%\n,\n \r\r\r12.8531917714%,\r\n\n+10.31%)\n\n\n\r\n",
  15,
 33,
 26,
 255.0);
AssertCssColor(
  "RGB(+8.66875632%,\r\r+000096%\r,\t\r\r+58.10%\t\r\r\r\n \r)",
  22,
 245,
 148,
 255.0);
AssertCssColor(
  "RGB(02.1%\r\n\t\n,85.43%,\t48%\r\t\r\r\r\t\n\t)\n",
  5,
 218,
 122,
 255.0);
AssertCssColor(
  "RGBA(\t\n19%,8.1%,000057%,000.2\t\r\n)\r\r\t\r\n\n\n\r",
  48,
 21,
 145,
 51);

  this.AssertCssColor(
  "RGBA(\t \r+9.63%,\t96.58237%,\r+017%\t\r, 0000.3547\n\n\r\r)\r",
  25,
 246,
 43,
 90.015);
AssertCssColor(
  "RGBA(\r\n\r\n7.750%,+06.63%,0%\r\r \n,+.8626791) \r\r\t\t",
  20,
 17,
 0,
 220.065);

  this.AssertCssColor(
  "RGBA(\r\r\n +060.186%\r\t,\r+0075%\n\n ,+0081%\n,\n\r\n\n +.3298820\t\r\r \n\n\n\t\t) "
  ,

  153,
 191,
 207,
 84.15);

  this.AssertCssColor(
  "RGBA(\r8%\n\r\n\n \n,\t\r\n\n\r\r \n 21.57163%,\n\r\r\n\n\n\r \r+8%\t\r\r,+0000.80723\n \t \t\t)\n"
  ,

  20,
 55,
 20,
 206.04000000000002);

  this.AssertCssColor(
  "RGBA(+071.68110278729%,+2.2201798%\n\t,\t\n\t\n\n\r\r\n \r\n+02.4%\n,\n\t\n00.397386540415)"
  ,

  183,
 6,
 6,
 100.98);
AssertCssColor("RGBA(+2%,+000007.898%,\t\t \n\t\n\r078%,0.0)",5,20,199,0);
AssertCssColor("RGBA(111,250\r\n,\n\n\t\t\r 191,\n+0000.5)",111,250,191,127.5);
AssertCssColor(
  "RGBA(2.25%\n\n\t,13%,69%,.11\t\r\r\r\n)\t\r\t\n\t\n\t\n\n",
  6,
 33,
 176,
 28.05);

  this.AssertCssColor(
  "RGBa(\n\n\n\r\n\t\t+039%\r\t\r\t\r\r ,+9.83305%\n,+00060.2979%,\n\r\n\n \n\n0000.29443\r)"
  ,

  99,
 25,
 154,
 74.97);

  this.AssertCssColor(
  "RGBa(\n\n\n +42.799%\t,\n\n\r\n\r+000006%\t,+97%\n\r\r,+0.27145901)",
  109,
 15,
 247,
 68.85000000000001);

  this.AssertCssColor(
  "RGBa(\r\n\r\r\n\n\r\n4%\t\t,\n3.02536%,\t+4.2462%\n\t\r\n\n\r,0.7\n\n\r\r\n\n \r\r)"
  ,

  10,
 8,
 11,
 178.5);

  this.AssertCssColor(
 "RGBa(\r\r\r 66.5157%\n\n ,\t\r+93.5%\t\n,\t\r\r+89%\r\n \n\r\t\n\n\n,\t .2)",

  170,
 238,
 227,
 51);
AssertCssColor(
  "RGBa(+255\r \r\t,189,\t+139, \n\r+0000.08843)\n\r\r",
  255,
 189,
 139,
 22.95);

  this.AssertCssColor(
  "RGb(\n+127\n\r\r\r\n\r\r\r\r,\n\r\t \r\r\n\t254\n\r\r\n,81\r\r\n\r)\t\t\n",
  127,
 254,
 81,
 255.0);
AssertCssColor("RGb(\r\t\n\n+76.2%,4%,4%)",194,10,10,255.0);
AssertCssColor("RGb(\r+0096%\r \n ,\n30%\t\n ,00019.9%\r)",245,77,51,255.0);

  this.AssertCssColor(
  "RGb(\r00095.4194435%,\t\r\n\n\n\n\r88%, \n\r\r\r83%\r\n\n\t)",
  243,
 224,
 212,
 255.0);

  this.AssertCssColor(
  "RGb(+18%\r\n\r\n,98.174658%\r\n\r\r\t ,+3.4220495%\n\n\t\r\t\r\r\n\r\r\n\r)",
  46,
 250,
 9,
 255.0);

  this.AssertCssColor(
  "RGb(+9.2366%\t\r\r\r\r\r\r\r\n\n,\r\n78.378%\t\t \n\r\n\t,\t76.0759%\n\r\r)\n\n"
  ,

  24,
 200,
 194,
 255.0);
AssertCssColor("RGb(+00009%\n,+1%,\n\t\t32%)",23,3,82,255.0);
AssertCssColor("RGb(+30%,7.7%\r,\r +00021%\n)\r\r\t",77,20,54,255.0);
AssertCssColor("RGb(000052%,051%,7%)\t\r\r\r\r\r\t",133,130,18,255.0);
AssertCssColor("RGb(09%,+021%,\r\r\n28%)\t\r",23,54,71,255.0);
AssertCssColor(
  "RGbA(\t+0075%,\n\n12%, \t\n\n \t000098%,000.2)\r\r",
  191,
 31,
 250,
 51);

  this.AssertCssColor(
  "RGbA(\n\n\r\t\t\r00070%\t\t\n\r\n\r \n\t,\t \n+5% \n\n,\t\r+8.40626437%,\r00.8140)\r\r\r \t\n"
  ,

  179,
 13,
 21,
 208.07999999999998);

  this.AssertCssColor(
  "RGbA(\r+97\n\n\r\t,0002\t,191\t\r, \r\t\r00.787028\n\r\r\n\r\t\r\t)",
  97,
 2,
 191,
 201.45000000000002);

  this.AssertCssColor(
  "RGbA(+00091% \t\t\r\n\n,+000014.22317082%,+2.03%,000.0\r \n\r\n)",
  232,
 36,
 5,
 0);

  this.AssertCssColor(
  "RGbA(+5.3281353619% \r ,\n \r+000011.02194%,\n\r\n\r\r\r\r0.26234%\r\n\n\n\n\t ,+0000.0\n\t\n\r\n\r\n\r\t\r\t)"
  ,

  14,
 28,
 1,
 0);

  this.AssertCssColor(
  "RGba(\n\n +229\n\n\r\n,+9,\r\r\r\r\n\r\r\n\n\t+8,\n\t\r\n\n\n\t +0000.3)",
  229,
 9,
 8,
 76.5);

  this.AssertCssColor(
  "RGba(000044%,\r\r\t\n\n+7%\t,\r\r\r\t6.377691%,\t0.6173426\r \n\r\r\n\t)\r\r\n\n\r "
  ,

  112,
 18,
 16,
 157.07999999999998);
AssertCssColor(
  "RGba(0082%,+46%,00016%,\r\r \r00.1) \r\n\r\n\t \n\n",
  209,
 117,
 41,
 25.5);
AssertCssColor(
  "RGba(17%,+029.7% \r,\t\r29%,+00.23\n\n)",
  43,
 76,
 74,
 58.650000000000006);

  this.AssertCssColor(
  "RgB(\t+6.9760%,\r\r00018.296519199%\r\n\n\r\n\t,\r\n+7%\n \r)\n\r\t\n\n\r\t",
  18,
 47,
 18,
 255.0);
AssertCssColor("RgB(\t000012%,+43.4839477%\n\n\n \n\n,+1.4%)",31,111,4,255.0);
AssertCssColor(
  "RgB(\r\t\n\r\r+80.67645394270%\t,\n\r\n\n\n \t2%,96%\r\t)",
  206,
 5,
 245,
 255.0);

  this.AssertCssColor(
  "RgB(\r6.077174732009%,+19.447181%\r\t\n\t\r,\r 17.233%)\r\r",
  15,
 50,
 44,
 255.0);
AssertCssColor("RgB(+2.546% ,\t0026.2%\n,\r9.519190%\n)",6,67,24,255.0);
AssertCssColor(
  "RgB(00079%\n\r\n \n,10.24221%,2.01%\n\n\r \n\n\n)",
  201,
 26,
 5,
 255.0);
AssertCssColor("RgB(5%,+9.8%\r\n\n\n\r\r \r,+0070.3585%\r)",13,25,179,255.0);

  this.AssertCssColor(
  "RgBA(\r\r\t\n\r54.59%,\r+6.86%\r\r\n\n\r,\r\r\n\r\n\t67.7%,\t 0000.9\n\t)\t\r\t"
  ,

  139,
 17,
 173,
 229.5);

  this.AssertCssColor(
  "RgBA(+3.673019%,\r\r\n\r\r\r +9%,+60%,\r+000.7\r\n\n\n \r\r)",
  9,
 23,
 153,
 178.5);
AssertCssColor(
  "RgBA(0042.4721%,6.156940077521% \t\n,5.3249%,+0.48691425)",
  108,
 16,
 14,
 123.92999999999999);

  this.AssertCssColor(
  "RgBA(2.462362646%\t,\r+00094%\t,23%,0000.45295 \r\n\t\n \n\n\r)",
  6,
 240,
 59,
 116.025);

  this.AssertCssColor(
  "RgBa(\n\r+000017.03% \n\r\n,\t\n+6.57%,+041.9017%\r\r\t,\n\t \n\r \t\r\t\n\n+.941\n\t)\r"
  ,

  43,
 17,
 107,
 239.7);

  this.AssertCssColor(
  "RgBa(\r\n\t\r\r+34.1473%\t,+058% ,\n +2.51614%,\t+0000.4\n\r\n\r \t\n)",
  87,
 148,
 6,
 102);
AssertCssColor(
  "RgBa(\r +7,60\r\t\n \n,38\t\n\r\r\n\n\n\n\t,0000.4313)",
  7,
 60,
 38,
 109.64999999999999);

  this.AssertCssColor(
  "RgBa(\n\r\n\r\t+27.09%\r\n\t\r \n,\n\r080.3%,+9%,+00.3)\r\t",
  69,
 205,
 23,
 76.5);

  this.AssertCssColor(
  "RgBa(+00063%\t,\n\n\n\n\r+43.68534%\t\t,3%,0000.36022850\r\n\r \n \r) \r\t \r\n\r\r\r\r "
  ,

  161,
 111,
 8,
 91.8);
AssertCssColor(
  "RgBa(+48%,\t\r+2.6%,\r\t+31%\t\r\r\r\t,\r +0.128178)",
  122,
 7,
 79,
 33.15);

  this.AssertCssColor(
  "RgBa(24%,\r \r+99.87%\n\t\r\n\n\t,4%,+00.6542673 \r \n \r)\t\r\n",
  61,
 255,
 10,
 167.025);
AssertCssColor(
  "Rgb(\n\r\n\t+8.021682544%\r\n\r\r,+7.338%,\r80.2247%)",
  20,
 19,
 205,
 255.0);
AssertCssColor(
  "Rgb(\n\r\r\n \n0006%\n \t\n\n\n\n,9%,\t070%)\n\n",
  15,
 23,
 179,
 255.0);
AssertCssColor("Rgb(\r\n+253\n,+000065,252) \n",253,65,252,255.0);
AssertCssColor(
  "Rgb(+08%,\n\r\n\n\n\r23%\r,+24.814%\n\n\r) \t\r\r\t",
  20,
 59,
 63,
 255.0);
AssertCssColor("Rgb(0%, \r6%,0024%\n\t\t\n)\n\n \r\r",0,15,61,255.0);
AssertCssColor(
  "Rgb(71.9029200281% ,+31%,+6.766%)\n \n \r\t\n\r",
  183,
 79,
 17,
 255.0);
AssertCssColor(
  "Rgb(97.5158%,\t\t0068%,\t+00034.50573300753%\n\n\n)",
  249,
 173,
 88,
 255.0);

  this.AssertCssColor(
  "RgbA(+000050.087225%\n\n, \r0.0%\n,\r+0052.60%\r, \n\r\r\r\n\t\n.8210063)",
  128,
 0,
 134,
 209.1);
AssertCssColor(
  "RgbA(+86%,74.5% \n\t\r\t\n\n,7% \n \t,\n\n+0000.1)",
  219,
 190,
 18,
 25.5);

  this.AssertCssColor(
  "Rgba(\t\t\n\r\r\r\r+37%\r\n\r\n,\r\t2%,00004.5%\r\t\r\r\r\r\n ,\t\r+0000.874718)"
  ,

  94,
 5,
 11,
 223.125);

  this.AssertCssColor(
  "Rgba(\t\r\r\n\n\t\n \t\r2 \n\n,+251\n \n\r\t,+0012,0.34\n\r\t)\t\n\n",
  2,
 251,
 12,
 86.7);

  this.AssertCssColor(
  "Rgba(\r\t\r\r\n000096%\n\n\r \t\r\r\r,6.9379%,\n+85%\t \t,\r\r\r\t0000.16\n\n\r)"
  ,

  245,
 18,
 217,
 40.800000000000004);
AssertCssColor(
  "Rgba(+000027%\t\r\n\t, \n\r059.2%,24.28780%,.6\r)\n\r\r\n",
  69,
 151,
 62,
 153);
AssertCssColor(
  "Rgba(+4%, 14.2%,\r\t\n\n\r9%,+00.05\n\r\n \r)\t\n\n \n",
  10,
 36,
 23,
 12.75);
AssertCssColor(
  "Rgba(12.441901480%,+3.596% ,+84%\r\n, \n\r00.774)",
  32,
 9,
 214,
 197.115);
AssertCssColor("hSL(\t\n\n \t\r\n\r7733,\t+96%\t\t,2%)",0,9,8,255.0);
AssertCssColor(
  "hSL(\t\r\t\t\r\r6484.9773,\n\r\n\n \t78%,\r\n000087%)",
  247,
 200,
 195,
 255.0);
AssertCssColor("hSL(\t +1088.9,+090.9%,98.154497619%)",254,247,246,255.0);

  this.AssertCssColor(
  "hSL(\n\t 2271,69.59464664%\n\t,\n\n\t\n0080%\n\n \r\n\r\r\r\n\t)",
  179,
 239,
 168,
 255.0);

  this.AssertCssColor(
  "hSL(\n \n-1289\n\r\n,\n\r\t \r\r\r00076.9%,+29.7%\r\t\r)\r\n\n\n",
  17,
 133,
 77,
 255.0);

  this.AssertCssColor(
  "hSL(\n+6748.992,\t\r\n\r\n\n\n\n+0.918%\t \r\r\r,\n \r+043%\n\r)",
  109,
 108,
 110,
 255.0);

  this.AssertCssColor(
  "hSL(\n7401,6.16%\n\n,\n\r\n\t \n\n\r\n\n+000058.135801%\n\r)",
  141,
 150,
 154,
 255.0);

  this.AssertCssColor(
  "hSL(\r\n\r\n\n \r\n\n\n-2234,\r6%\t\r\n\n\r,\t0073%)\t\n\n \r",
  188,
 182,
 190,
 255.0);
AssertCssColor("hSL(\r\n+6555,\t\r\n+74%\n,0074.94738%)",214,238,143,255.0);
AssertCssColor(
  "hSL(\r \n\r\n2225,\r\r\n\r\n\r070%,+2%\n\r)\r\r\r\t\t",
  8,
 8,
 1,
 255.0);
AssertCssColor(
  "hSL(\r5583 \t, \n9.52%\r\r\t \r\n\r \n\n\n,+5.1432258%)",
  11,
 14,
 14,
 255.0);
AssertCssColor("hSL(+0439\n,83%\n\r,6.351991304%)",21,29,2,255.0);
AssertCssColor(
  "hSL(+6044\n\t\r\n\r ,+5%\r\t,+80.030206836%) ",
  205,
 201,
 206,
 255.0);
AssertCssColor("hSL(+6544\n,019%\n,3.971%)",11,12,8,255.0);

  this.AssertCssColor(
  "hSL(-3610.4,\r\r+0093.341%\r,\r\n\t \n+69.72957389%\r\n\n)\r ",
  249,
 105,
 130,
 255.0);
AssertCssColor("hSL(-6981.0\t \r \n,70.6%\n\r\t \t\n,+5.70%)",4,11,24,255.0);
AssertCssColor(
  "hSL(-7558\n\n\r\r\t\n\n,\t+5%,07.0764599%)\r\n \n\n\n\n",
  18,
 17,
 17,
 255.0);
AssertCssColor("hSL(5518.9,88%,\n\t\n+00094.35%)\r\r \r\r",228,253,227,255.0);

  this.AssertCssColor(
  "hSL(5967.652\r\r, \t\n+41.40851043%,5%\r\r\n\n \t)\r\n\n \r\r\r\n\n ",
  7,
 13,
 18,
 255.0);

  this.AssertCssColor(
  "hSL(9105.1083327\r\n \n\t \r,+05.59% \r\r\n\r,0066.13%\r\r\n\n\n) \t\r\t ",
  166,
 173,
 163,
 255.0);

  this.AssertCssColor(
  "hSL(9655.30,\t\n \r\n\t\n\r\n+91.54%,\r\r\r\n+0%\n\r\n\n\n\n\r\r\r\t)",
  0,
 0,
 0,
 255.0);
AssertCssColor("hSL(9981.1,\n\r9%\n \r,+34% \t\n\r) \n\n",84,78,94,255.0);
AssertCssColor(
  "hSl(\n\n\r2804,\n 9%,\r\n\n+00043.8%\r \r\n) \r",
  116,
 101,
 121,
 255.0);

  this.AssertCssColor(
  "hSl(\n-4168\r\r\n\t\r, \r\n\n\n\r18.4%\n, \t \r\n 13.485877%)",
  28,
 40,
 34,
 255.0);
AssertCssColor(
  "hSl(\n1655.371440,010.786%\t\r\t\t\n ,+45.783%)",
  104,
 114,
 129,
 255.0);
AssertCssColor("hSl(\r\t\t-2259 \t,\r \n\n+000085.8%\n,49%)\r",92,17,232,255.0);
AssertCssColor("hSl(\r-4734.9092\n\n\n,92.60%\r ,6%)",29,1,27,255.0);

  this.AssertCssColor(
  "hSl(\r-7707.0,+16.4833232%\t\t\r\n\n\n ,+73%\n\n\t\n\n\r\t\n)\n\r\n",
  174,
 185,
 197,
 255.0);
AssertCssColor(
  "hSl(\r \r\t\t+8800\n,+000000%,\r\n\r +000047%)",
  119,
 119,
 119,
 255.0);

  this.AssertCssColor(
  "hSl(2290.242\r \r\r\n \r\r ,+4%,\n\n\n\r\n\n\n\t19.8%\r\r)",
  48,
 52,
 49,
 255.0);

  this.AssertCssColor(
  "hSl(-5200.81916,\n\t\r\r\n\r\n \r00035%\r\t\r,\t+9%) \r\r\n\n",
  14,
 25,
 30,
 255.0);

  this.AssertCssColor(
  "hSl(0144.84 \n\n\n,\n\r\t\n\r\n\r2.0657745%\n\t \r,0022.8%\t)",
  56,
 59,
 57,
 255.0);
AssertCssColor(
  "hSl(0381.217\n,\n\n\r \n\t \r42.103890%\r\n,9%)",
  32,
 20,
 13,
 255.0);

  this.AssertCssColor(
  "hSl(5537.593442255\t\r ,\t \r\n\n3.19027905%\n\n,00074%\n\n\t\r)\n\n",
  186,
 190,
 187,
 255.0);

  this.AssertCssColor(
  "hSl(5761.55644333\t,+070.9%\n\r\n\n ,\r\r\t\t \r\n\t\r\t+2.43%)",
  10,
 2,
 1,
 255.0);
AssertCssColor(
  "hSl(6021.71,\n\n\n\t\t\r\n\n\t \r +071% \r\t,+00010%) \n",
  20,
 7,
 43,
 255.0);
AssertCssColor("hSl(7501.2\n\r\n\r\n\n,\r+58.277%,\r\r+3% \t)",12,3,11,255.0);

  this.AssertCssColor(
  "hSl(7744\t,\n\n\r+0097.76887275500% \n\t\n,\n\r\n000016.47715702832%)",
  0,
 77,
 83,
 255.0);
AssertCssColor(
  "hsL(\n\n\t\n6341\r,\r00056.235960%,000.31299%)\r\n\n\t\r\n",
  0,
 0,
 1,
 255.0);
AssertCssColor("hsL(\n0736 ,06.2400% \t\n\r, +0025%\n\r\r)",67,61,59,255.0);

  this.AssertCssColor(
  "hsL(\n7227\n\r\n\r\n\n\r\n\r,\n\n\r\n\r\t+077.99750453%\n ,+00028%\r\r)\n",
  127,
 65,
 15,
 255.0);
AssertCssColor(
  "hsL(\n7790.2,\t\t \n\n\t\n 0017.1347900%, \t000015%)\r\r",
  31,
 33,
 44,
 255.0);

  this.AssertCssColor(
  "hsL(\r\r\n \n1480.893044,9.8%\r\r\n,\n\r\t\n\t\r\n\n\n\r+0057%\n\n)",
  156,
 149,
 134,
 255.0);

  this.AssertCssColor(
  "hsL(\r\t\n\r\n\t\r 6108\n,\r\n\r\r\r\r+4%,\t9.7769%)\n \n \r\r\r\n",
  25,
 23,
 24,
 255.0);

  this.AssertCssColor(
  "hsL(\r\r \n\t\t \n9805.97454267031\n,\t +0000%,+00.2149%\n\n\r \r)",
  0,
 0,
 0,
 255.0);
AssertCssColor("hsL(+0883,083%,031.3%)",13,146,108,255.0);
AssertCssColor(
  "hsL(+1165,+000092.3104%,\r\t6.22695894%) \n\r\t \r ",
  18,
 30,
 1,
 255.0);
AssertCssColor(
  "hsL(+5480.8\r\r\n\r\r\r ,\r\t\t\n \t74%\n, \r4.62%\t\t \n)",
  14,
 20,
 3,
 255.0);
AssertCssColor("hsL(-3998,+000050% \r\r\t\r\r\n ,23%)",87,29,66,255.0);
AssertCssColor(
  "hsL(-9011.96, \t\n\n\n\t\n\n\n+64%\r \n \n ,+79%\n\r \r\r)",
  235,
 167,
 180,
 255.0);
AssertCssColor(
  "hsL(0879.2849\r\r\r\r\r\r\r, \t+0051.2320%,\r\r9%\r)",
  11,
 34,
 26,
 255.0);
AssertCssColor(
  "hsL(2320,+084% \t\t,\n \r \r5.50224%\n\n\n\n\n\n\r\t \n)\n",
  2,
 25,
 17,
 255.0);

  this.AssertCssColor(
  "hsL(4292,\n\r\n \r \n\r\t45%\n\r\r\n\r\r\r \r\n,8.57010619%)",
  31,
 12,
 21,
 255.0);
AssertCssColor("hsL(4360,9.4%,\n+7%)\n",19,18,16,255.0);

  this.AssertCssColor(
  "hsL(7971.30251\n\t\t,\n\r 3%\n\r\r\r \r\r\r,\n \n\n\r\n\r\t\r+01%\t)",
  2,
 2,
 2,
 255.0);
AssertCssColor(
  "hsL(9127.59,\t\r\r\n\r \r3.7792668%\n\r\n,+0007.11%)",
  17,
 18,
 17,
 255.0);
AssertCssColor(
  "hsl(\n +4513,+91.4731065603%\r\n\r \t,52%) \t\n\n",
  20,
 196,
 244,
 255.0);

  this.AssertCssColor(
  "hsl(\r\t6975.049\n \n,+000074.605619699%\r\r\n, \t \t\r\n\r+2.9%)\r",
  1,
 12,
 4,
 255.0);

  this.AssertCssColor(
  "hsl(\r\n\r\t\r-9986,2.90467007438%,+9.847537%\r\n\t\t\n\n) ",
  25,
 25,
 24,
 255.0);

  this.AssertCssColor(
  "hsl(\r0336.089675438,\t062.601851%\n\t,0%\r\n\r \r\r \t)\n\n\t",
  0,
 0,
 0,
 255.0);
AssertCssColor("hsl(+0934,\n\t18.3%\r\n\r\r\r,8.0%)",16,19,24,255.0);
AssertCssColor(
  "hsl(+3925.61,+55.574315913729%\n,+00067.6%)\n\r\n \n\r\t",
  218,
 126,
 179,
 255.0);
AssertCssColor("hsl(+6896,012%\r \r\r ,18.516453%) \r",52,52,41,255.0);
AssertCssColor("hsl(+7414.944,\r+46%,\n43.95%\r\t)",60,103,163,255.0);

  this.AssertCssColor(
  "hsl(-0105\n\t\r\n \r\r,\r\t0.6%,+00049.87629%\r\n\n\r\n\r\r\r)",
  126,
 126,
 127,
 255.0);
AssertCssColor("hsl(-0567.36,\n+7%,028.662%)\r\r",67,78,73,255.0);
AssertCssColor("hsl(-1753.9,13%, \r\n+74%\r)\r\n ",197,193,180,255.0);
AssertCssColor(
  "hsl(-1824,\r\r\r+0027.388%\n\r\n,\r+99.69%\r \r\r\r\r\n\t)",
  254,
 253,
 254,
 255.0);
AssertCssColor("hsl(-3102 \n\t\t\n,79%,\t\n\r\n0010%)",5,45,17,255.0);
AssertCssColor(
  "hsl(-3287\r\n\r\r\r\n\r,\n\n\r\n\r\r\r\r+9%,\t \n\r44%)",
  122,
 102,
 117,
 255.0);
AssertCssColor("hsl(-5857 \r\n,\n58%,\r\r\n\n\r+8%\n\r\n)",17,8,32,255.0);
AssertCssColor(
  "hsl(1775,\r27%,\t\n\t0087%\r\t\n\r)\n \n\n\n",
  230,
 212,
 220,
 255.0);
AssertCssColor(
  "hsl(5320\n\r \n\r\n \t \n \n,\r \n26%\r,0071%)",
  187,
 161,
 200,
 255.0);
AssertCssColor("hsl(5612\n\n\r \r,3.427%,\n03%)",7,7,7,255.0);
AssertCssColor("hsl(6850.0,\r\r+28.524%,\t\r\r+00.921872681%)",3,1,1,255.0);
AssertCssColor(
  "rGB(\t\t\n\t\n \n +48%, \r+1.7%\r,7%\n)\n\t \n ",
  122,
 4,
 18,
 255.0);
AssertCssColor(
  "rGB(\t\t\n00040.9617%\r\n,\r63%\t\t\n ,+0.059%)",
  104,
 161,
 0,
 255.0);
AssertCssColor(
  "rGB(\r\r\r+9%\t\n, \n\r\r\t\t\r+00037.3367%,005%)\t\r\n\n",
  23,
 95,
 13,
 255.0);

  this.AssertCssColor(
  "rGB(\r\r 00013.542%\r\n\t,+0036.83%\r\n, 000074.753032%)\n\r \n\n\t\n",
  35,
 94,
 191,
 255.0);

  this.AssertCssColor(
  "rGB(\r+87.5992770%,000073.6%\n\n\r,\n\r\r\r2.0681%)\n\n\r\t \n\n ",
  223,
 188,
 5,
 255.0);
AssertCssColor(
  "rGB(+072%\n\n\n \t,\n\n\n\n\n+00081%,\n\n\r30.7%) ",
  184,
 207,
 78,
 255.0);
AssertCssColor("rGB(87.05570%\r,\r\r\n+0011%,+3.7% \t)\n\r\n",222,28,9,255.0);

  this.AssertCssColor(
  "rGBA(\r\r\t\n00012.9110290881%\n\t \n\n\r\n,00067%,\r\n\r\t\r\t\r\r \r70.0%\n\n\r\r ,\r+00.7561)"
  ,

  33,
 171,
 179,
 193.035);

  this.AssertCssColor(
  "rGBA(\n\n\n\r\n\n\n24.021%,+1%\r\n\t\r\t\n \n\n,\n\n\n+000005.63%\n\t,\n\r+0000.936036\t\n)"
  ,

  61,
 3,
 14,
 238.935);

  this.AssertCssColor(
  "rGBA(+14.41178%\n\t, 86%\r\n \r \t\n \n\r,84.335343%,+0.185)\r \t\n",
  37,
 219,
 215,
 46.92);

  this.AssertCssColor(
  "rGBA(+6%\n\t\r\r, \r\n \t4%,4.79%,\n\n \r \r+.3004 \n)\r\n\r",
  15,
 10,
 12,
 76.5);

  this.AssertCssColor(
  "rGBA(7%,\n\r\n \n \t \n17%\r \r,\r\t\t\t+3.8%\t\n\n\n\n\n\n\r,+0000.677\t\n\n\n\t\t)\n\r "
  ,

  18,
 43,
 10,
 173.4);
AssertCssColor(
  "rGBA(9%\t\r\n\r\r, \t\t\n\r\r000082%,98%,\r\t+.9\n)",
  23,
 209,
 250,
 229.5);

  this.AssertCssColor(
  "rGBa(\t \n+00061.219%,+0032.911324945%,\n\r\n000072%\r\n\n \n\r,\r\n+.8\n\n\r\r\n)\r\n\r\r\n"
  ,

  156,
 84,
 184,
 204);
AssertCssColor(
  "rGBa(\n\r +68.034%,93%,\t06.7%\r,+00.222)",
  173,
 237,
 17,
 57.120000000000005);

  this.AssertCssColor(
  "rGBa(\r\r5.17%,\t\r\n\r \n+9.86%,+00078.83953%\t\n\r\r \n,+00.579384\t\r\t)",
  13,
 25,
 201,
 147.89999999999998);
AssertCssColor(
  "rGBa(+6.70%\n,00007.6%,\t+5.57%,\r 0000.68773527)\t",
  17,
 19,
 14,
 174.93);

  this.AssertCssColor(
  "rGBa(0.1946446810%\t\r,2%\r,\n\n\n\n+00003.132%, \n\n+000.13957)\n",
  0,
 5,
 8,
 35.7);

  this.AssertCssColor(
  "rGBa(083%\n\r\n\n\r\r\r,\t\n060%\n, 00001%,\n\r\r\r\r+0000.4)",
  212,
 153,
 3,
 102);

  this.AssertCssColor(
  "rGBa(69.4%\n\n\t\t\n\r,\n\r+67.3405%\r ,\n+41.604%,\n \n\n\r\t\r\r+.8\t\r\n)\n\r\r\t \n"
  ,

  177,
 172,
 106,
 204);
AssertCssColor("rGb(\t\t\r\n\n8%,62.029%,\r+049%)",20,158,125,255.0);
AssertCssColor(
  "rGb(\t\r\r\n\r\t\n 092% ,3%,0.8530145%\r\r\n) \r",
  235,
 8,
 2,
 255.0);
AssertCssColor(
  "rGb(\t+7%\r\t \n\t\n,48.1079451415%,\r \n\n\r\r+0%)",
  18,
 123,
 0,
 255.0);
AssertCssColor(
  "rGb(\n\n\t+061%,0%,\n\r\n+0079%\r\t\n\t) \n\n \n\n\n",
  156,
 0,
 201,
 255.0);

  this.AssertCssColor(
  "rGb(\r\n\t\n+5.80%,\r\n \t\r \t+0%\r\n,\t\t\n\r \n\t +46.94%\r)\r\r \n\n",
  15,
 0,
 120,
 255.0);
AssertCssColor("rGb(\t\r\r+228\t\n,+0,176\r)",228,0,176,255.0);
AssertCssColor(
  "rGb(+00047.27%,\n +087.00%,\n55.8%\r \t\r)\n\n\n \n\n \n",
  121,
 222,
 142,
 255.0);
AssertCssColor(
  "rGb(+5%\r,\r\t\t\t\n\r\r \r\r\n+39% \n,\t\n+0012%)",
  13,
 99,
 31,
 255.0);
AssertCssColor("rGb(+78%,\n37.382350%,39%)\n",199,95,99,255.0);
AssertCssColor(
  "rGb(219\n\r\r\r\n\n,\t \t\n\t253,+198\n\n\r\r)\r\r\r\n",
  219,
 253,
 198,
 255.0);
AssertCssColor(
  "rGb(61.71409%, \r\n \t+8.6%,4%\r\r\t\t\n)\r\n\r",
  157,
 22,
 10,
 255.0);
AssertCssColor(
  "rGb(8%,00078.197209510%\t,\n\r\n \n\t\r\t\r1.8%\n\r\r)",
  20,
 199,
 5,
 255.0);

  this.AssertCssColor(
  "rGbA(\n+41%\n\r\r\r\t\r\r\r,\n000092%\t\r\n\n\r\n\t\r,\r\n\n+00046%,\n00.25900\n\t\r)\r"
  ,

  105,
 235,
 117,
 66.3);

  this.AssertCssColor(
  "rGbA(\n47%,86.461%\r\n\r \r\r\n \t,\r00022.06%,+0.736231)\r \t\n\t \r",
  120,
 220,
 56,
 187.935);

  this.AssertCssColor(
  "rGbA(\r \n\t \t+00031%\n\n\r\n\n\t\n,\r\n\n80%,\t\r \r\n85.4246845133%,\n+000.67263122448)"
  ,

  79,
 204,
 218,
 172.125);

  this.AssertCssColor(
  "rGbA(\r+0089%\t\r\n\n\n\r\n ,2.980%,7%,\t\r\r\n+.2\n\r \r)\r",
  227,
 8,
 18,
 51);
AssertCssColor(
  "rGbA(+63%,+002.7453%\n,+7.98772%\r\r,+0000.42\r\r \n)\r\n\n",
  161,
 7,
 20,
 107.1);

  this.AssertCssColor(
  "rGbA(9%\r\n\r\n\n,6.9833%,\n\n\t\n\r\r\n\n\t\n\n+005.77746%,000.43\n\t\n\r \t\n)\t\n\r\r\n"
  ,

  23,
 18,
 15,
 109.64999999999999);

  this.AssertCssColor(
  "rGba(+00021%\r\n\n\r\t\t\t\r\r,30.0%\n\n\n ,\n\r+5.5%,+000.5)",
  54,
 77,
 14,
 127.5);

  this.AssertCssColor(
  "rGba(+3%\r\t \n\n\n\n\n\r\t\r,0%\r\r\t\r\n,\r\n +039.8545%,+0000.0)\n\n",
  8,
 0,
 102,
 0);
AssertCssColor(
  "rGba(+3.4%\r\n\n,000069%,+3.69470%\r\r\n\n\r\r\n,0000.2385)",
  9,
 176,
 9,
 61.199999999999996);
AssertCssColor("rgB(\t \n00009%,+026.6%, \n+96.3034%)\n\t",23,68,246,255.0);
AssertCssColor(
  "rgB(\r\r\t+61.454%\n\n\r \r,00078.0488%, +000038%)",
  157,
 199,
 97,
 255.0);
AssertCssColor("rgB(+2.5%\n\t,2.709422%,38%)",6,7,97,255.0);
AssertCssColor(
  "rgB(+3.85232896%,0066.8%,\n\n\r 000060.845% \t\r\n)",
  10,
 170,
 155,
 255.0);
AssertCssColor("rgB(+7.0066%\n\n,7.500594%,+000058%)",18,19,148,255.0);
AssertCssColor(
  "rgB(000034\t,92\t\r\t,+228\n\r\r)\r\r\n\n\r\t\t\n\n",
  34,
 92,
 228,
 255.0);
AssertCssColor("rgB(06.84%\t\r\n \r\n, \r\t+14.417874%, 47%)",17,37,120,255.0);

  this.AssertCssColor(
  "rgBA(\r\n+1%, \r\n \n\n\r\r\n+2%,0011% \r ,\n\t\t\t\r\n\t0000.53\r \n\n \n \r \t) \n\n\n\n "
  ,

  3,
 5,
 28,
 135.15);

  this.AssertCssColor(
  "rgBA(+2.39355% \r\r\r,88%\n,\r+056%,\t\t\t\r\t\t\r\n+000.81143 \n\r\n)",
  6,
 224,
 143,
 206.55);

  this.AssertCssColor(
  "rgBA(3%,1%,\r\n\n\r\r+00048.9518624%,\r\r\r\t+0000.955102029 \r)",
  8,
 3,
 125,
 244.035);

  this.AssertCssColor(
  "rgBa(\n\r\t\n\t\r\t\r\n+0084%\n\n\t,+28.24%\n\t\n\r\n\n\r\r,98.482%,0.37\t)\n\r\n"
  ,

  214,
 72,
 251,
 94.35);
AssertCssColor(
  "rgBa(\n \r+32%, \r \t+032.4779410%, 9%\r\n,0.3\t)",
  82,
 83,
 23,
 76.5);
AssertCssColor(
  "rgBa(\n+00099%\n\n\n\r,\n\r\n\t+89%,\t\n\n+0051%,+000.65\t)",
  252,
 227,
 130,
 165.75);

  this.AssertCssColor(
  "rgBa(\n\n+60.9%, \r\n +9.2902512% \n\r,\r \r\r\r0022%\r\n\n,+0.54\n\t\r\r\n\r \r\n)\n\t"
  ,

  155,
 24,
 56,
 137.70000000000002);
AssertCssColor(
  "rgBa(+3%\n,\r+8.97246%,00035%\r\n\n,\t\t +00.7)",
  8,
 23,
 89,
 178.5);

  this.AssertCssColor(
  "rgBa(30%\r\n\r\r,0034%,\n\t\r\t\n\t\r\n+029.18%\r\t,+0000.86)",
  77,
 87,
 74,
 219.29999999999998);
AssertCssColor(
  "rgb(\t\r+53.1543524291%\r,\n\n\n00025%,096%\t)",
  136,
 64,
 245,
 255.0);
AssertCssColor("rgb(\r\t\r \t\n\r8%,\n\n082%\r,0%)",20,209,0,255.0);

  this.AssertCssColor(
  "rgb(\r \t\n4.57%, \n\n\t\t\r+012.774%\n \n\t\r\n\r\n\t\r\n,\n\t \n45%) ",
  12,
 33,
 115,
 255.0);
AssertCssColor("rgb(+2.93%,+35%\n\r ,00029%)",7,89,74,255.0);
AssertCssColor("rgb(+8%,49%\n,66%)",20,125,168,255.0);
AssertCssColor(
  "rgb(04%,65%\r\r \r\n\n\r\r\r\r\n\t,57%)\n\t \n ",
  10,
 166,
 145,
 255.0);

  this.AssertCssColor(
  "rgbA(\n\r\r\t83.149%,\t \r \n+098.201986780%,\r043%\r\n\r,+0000.97)",
  212,
 250,
 110,
 247.35);
AssertCssColor(
  "rgbA(+026%,\r79%,0053.721%\r ,.42340631\t\r)",
  66,
 201,
 137,
 108.11999999999999);
AssertCssColor("rgbA(+7%,\t\n\t007%,\n\r \r\n\n\n+4% \t\t,+.1)",18,18,10,25.5);

  this.AssertCssColor(
  "rgbA(2.3689835327%,+000028.4%,\n\n\n000058%\n\t,\r\r 00.386922057821\r\n \n)\t"
  ,

  6,
 72,
 148,
 99.45);
AssertCssColor(
  "rgbA(7.0613805%\t,\t\n\r0039%,80%\r\t\t\r,0000.916\r)\t\n\r",
  18,
 99,
 204,
 234.09);

  this.AssertCssColor(
  "rgba(\t\r128\r\r \n\r,\r\t\t\r \n \n\r\n\r+9,198,0.74119191)",
  128,
 9,
 198,
 188.7);
AssertCssColor("rgba(\n\n \r\r39,236,9 \r,\t\r\n+00.4 \t\n)",39,236,9,102);
AssertCssColor(
  "rgba(\n \t \t\n190\n\r,+003\n,7\t\t\r\r\r\r\r,00.42 \n\n)",
  190,
 3,
 7,
 107.1);

  this.AssertCssColor(
  "rgba(\n 00038.4%,\n\r\r \n\n\r 000015%,+6.420319%,\t\n+0.87\r\r\r)",
  98,
 38,
 16,
 221.85);

  this.AssertCssColor(
  "rgba(\r\n\t+12.5353405%,\t\r \t\r \r\r \r+7.784%\n\n\n,\n\n+000072%\n,+0000.81) \n"
  ,

  32,
 20,
 184,
 206.55);
AssertCssColor(
  "rgba(014%,00063.851%,\r \r+3.8%,\n\n\t\t0000.699871) ",
  36,
 163,
 10,
 177.98999999999998);
//---
  this.AssertCssColor(
  "\t\t\t \n\t\r\r rGBa(+42790396,\n\r\n\r2750,271, -218\r)\r\t",
  255,
 255,
 255,
 0);
AssertCssColor(
  "\t\t\n\t\r\nHSL(.48,.560656749%,-0569%) \r\n\n\n\t",
  0,
 0,
 0,
 255.0);
AssertCssColor("\t\t\n\n\n\r\t\t\r\t\r#CbefAA\r\n",203,239,170,255.0);

  this.AssertCssColor(
  "\t\t\n\n\rRGBA(\n\t\t\n \n\r+594\t\r\n\r\n\r,461,\r \t\n \t -8924,\t\r \n\n\r\t.369\r \n\n\r\t\n)\n "
  ,

  255,
 255,
 0,
 94.35);
AssertCssColor("\t\t\n\n \r\n\n\n#aFb4",170,255,187,68.08500000000001);
AssertCssColor("\t\t\n\r\n \r\n\n\n\n#cae\r\n",204,170,238,255.0);

  this.AssertCssColor(
  "\t\t\n rgba(46%\n\r \n\r\n,1%\n\r\r\r,\t\r\r\n \t\r49.9%\r\r\r\n\n,\n\t\t -3850.6797)\n\t "
  ,

  117,
 3,
 127,
 0);
AssertCssColor("\t\t\n#F3f31D\n\r\r\t\n\r \r",243,243,29,255.0);

  this.AssertCssColor(
  "\t\t\r\n\t\rrGBa(\r9%,.5%,424920.0180971%\r\r,\r \t \t\r\n\r\n.7\r\r)",
  23,
 1,
 255,
 178.5);
AssertCssColor(
  "\t\t\r\r\nRGb(69.14983%\r\r\t\r\n\r\n\n,+181.3%,.7%\r)\n",
  176,
 255,
 2,
 255.0);
AssertCssColor("\t\t \r#Bef",187,238,255,255.0);
AssertCssColor("\t\t#8bdEEF\n",139,222,239,255.0);
AssertCssColor(
  "\t\n\t\t\n\nRgb(2.8571001691%\t\n,47%\r\n\n\r\n\n,-5227%)",
  7,
 120,
 0,
 255.0);

  this.AssertCssColor(
  "\t\n\t\t\nRGb(\t.7%,\n\n\n\n\n\n\n\t-.9%,+.31% \t\n\n \r\r\n) \t",
  2,
 0,
 1,
 255.0);
AssertCssColor("\t\n\t\n\n\n\n#dEf",221,238,255,255.0);
AssertCssColor("\t\n\t\n\n\n#CEFC",204,238,255,204);
AssertCssColor("\t\n\t\n#EfEF4bFe",239,239,75,253.98);

  this.AssertCssColor(
  "\t\n\n\t\n\tRgbA(+.8787546404%,+.6207554%,-6127%\n ,\t\r225\n)\n",
  2,
 2,
 0,
 255.0);

  this.AssertCssColor(
  "\t\n\n\n\n \rrgBa(08,9329116,\r\n797981\n,50890\r \r \r \n\r\r)\r",
  8,
 255,
 255,
 255.0);

  this.AssertCssColor(
 "\t\n\n\n\rHsL(\r\r+.87853,\n\t\r \n\n \t\n\n\n+.4%,+3.3%\n\r \t \n) \r\r\n",

  8,
 8,
 8,
 255.0);

  this.AssertCssColor(
  "\t\n\n\n \r\t\rrgba(.14595%,\n7094750.3%\t\r\r,\n\n \n-5.3%,6620.7)\n",
  0,
 255,
 0,
 255.0);

  this.AssertCssColor(
  "\t\n\n\r\n\n\rRgba(\r\n\r\r\n\r-.0014830%,+.73%,.8984%,-0.4)\n\t\n",
  0,
 2,
 2,
 0);
AssertCssColor("\t\n\n\r#AdfFFc",173,255,252,255.0);

  this.AssertCssColor(
  "\t\n\nHSL(\n\r-.4,\t\r-442.66703%\n\t\r\n\r\r \n\n,\n\n\t 257.0802503673%\n\r\r\n\n\r) \r"
  ,

  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\t\n\nRgBa(153,-6811\t\n \n,\t\t \r\n \n\r \n-0201800 \r\n\r,-1)\r\r\r\r",
  153,
 0,
 0,
 0);
AssertCssColor(
  "\t\n\r\t\rHSL(\n\n\t.97,+.113%,\r\r\t+347.47087%\n\r)",
  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\t\n\r\trgbA(\n\n\r\n\t\r+68593.6618%\n\n\n,\t3836210035.18%,-.0087288589%\t\t,.7 \r)"
  ,

  255,
 255,
 0,
 178.5);

  this.AssertCssColor(
  "\t\n\r\r\n\t\r\n\nRGB(\t\r25%\n ,\n6.731%\n,\t\n \n\t\n\n\n\n\r2415151291%)\n\t\t\n \r\n "
  ,

  64,
 17,
 255,
 255.0);

  this.AssertCssColor(
  "\t\n\r \r rgBA(\n \r\n\n\r\t\n \n+.43068%\t,\n-.140013%,\r\r+.001% ,+.094\r)\n\n"
  ,

  1,
 0,
 0,
 23.97);
AssertCssColor("\t\n\r \r#2C3cabB6 \t\n\n\n ",44,60,171,182.07);
AssertCssColor(
  "\t\n\r RgB(701263576284.9%\n ,-6%\r\n\n\r ,-.097928%)",
  255,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\t\n\rrGBA(0%,\n\r956216034.8% \r\t, \n +331393.96%,\n\r\t\n\r \r\n\r+.3)",
  0,
 255,
 255,
 76.5);
AssertCssColor("\t\n \t \r\t\n\r#Fbbbbb",251,187,187,255.0);
AssertCssColor(
  "\t\n \n\r\nrgB(+7076,\n 68381\r\t \t\r\r \t,\t46)\n\n\t ",
  255,
 255,
 46,
 255.0);
AssertCssColor("\t\n \nRGB(.54023855%,.9018%,7%)\t\r \t\n ",1,2,18,255.0);
AssertCssColor("\t\n \n#AbDfeCDA",171,223,236,218.025);

  this.AssertCssColor(
  "\t\nHSl(\r\t \r\n1204196\r,-6836034093.1%\r\t\t\r\n\n\r \t\r,-.880341%\r)",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\t\nRGB(\n\r\n\t\r\t\t\n\r95%, \n\t\r6% \n\r\t,\r\t\n.6540% \t)",
  242,
 15,
 2,
 255.0);
AssertCssColor(
  "\t\nRGB(-467391%\n\r\r,99%\r \n,\r\n\n\n\r\n .07%)",
  0,
 252,
 0,
 255.0);
AssertCssColor(
  "\t\nrGB(\r \n.7%\r\r\r,\n\r\n\n-92094191%,+06%)\t \t\r\r",
  2,
 0,
 15,
 255.0);
AssertCssColor("\t\nrGb(.0%,9312%,\n\r+6%)\n\t\r \r\t\r \t",0,255,15,255.0);

  this.AssertCssColor(
  "\t\r\t\n\n\r\n\t\t\rHsL(\r \r \r\n\n\r\n+.5329\r \r,\t\r\r\n\n.18%\r\r\n,\t\n\r\n.91153%)"
  ,

  2,
 2,
 2,
 255.0);

  this.AssertCssColor(
  "\t\r\t\nRGB(\r\r \r\t-.8% ,\r\n\r-.9220864%,\t+7.56782447% \n)",
  0,
 0,
 19,
 255.0);
AssertCssColor("\t\r\t\r\r\n \rRgb(\n-93%,.6%\r,+.2%)\t \t \r\t",0,2,1,255.0);

  this.AssertCssColor(
  "\t\r\t\rhSl(-47.23\n,\t \r\n\t\r\n\t\r+.1%\n\r\n,\t\r\t\r.9775886%\n\r\n\r\t\n)\n\n\t\n \t\n"
  ,

  2,
 2,
 2,
 255.0);
AssertCssColor(
  "\t\r\trGb(\n\n12.9%\r,5% ,162260267%)\r\r\n\r\n",
  33,
 13,
 255,
 255.0);

  this.AssertCssColor(
  "\t\r\n\r\r \tRGb(\r\t\r\n\n-8% \n,\n\t\t \n\n\r +26295%\n \n \n,-.376830%\r) ",

  0,
 255,
 0,
 255.0);

  this.AssertCssColor(
  "\t\r\n \r\nrGB(-.298%\n\r\r\r\t,\n\n+.48%,\t\n\n\n\r\t\n\n 9.4689%) \n",
  0,
 1,
 24,
 255.0);

  this.AssertCssColor(
  "\t\r\nHsl(991212.19097476,\r\r\n\r1980389799.0422%\r\r\n,\n\r\r \t +.270%\r\t\n)"
  ,

  0,
 1,
 0,
 255.0);

  this.AssertCssColor(
  "\t\r\r\t\rhSL(-126\n \r ,\r\r\n \r-.2% \r\r\r,.2%\r\t \r)\r\r\t\t",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\t\r\r\t \r\t\r\n\n\rrGba(\r\t\t\t098472.8%,484.281549%, \t\n \n\n\r\n+.4%\n\n\n\r \t\n,\n\n\r-.16800699) "
  ,

  255,
 255,
 1,
 0);
AssertCssColor(
  "\t\r\r\r\n\r\t\r\n\r hsL(\r\r\n064,+.6%\r,288%)\r",
  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\t\r\r\r\n\r\n\n\rrGba(\r\n\t\t\n\n +.462%,\n.1%,\r\n\n.443618241%\n,\n\n\n \r\r\r92.89)"
  ,

  1,
 0,
 1,
 255.0);

  this.AssertCssColor(
  "\t\r\r\r\r\r\n\r\nRGba(\r+5\n\t\t\t,\n -77,8\r\r\t,\r\r\t\n\n+700 \t\t\n\n\r)",

  5,
 0,
 8,
 255.0);
AssertCssColor("\t\r\r#a4A9\n\n \n\n",170,68,170,153);
AssertCssColor("\t\r\rhsL(.1,-.97%,9505198.070599%)",255,255,255,255.0);

  this.AssertCssColor(
  "\t\r \t\n\rHsL(\t\n \t \t\n+.55\r\t\n\r\n,-.9%\n\r\t,+.8507% \n\n\r\n\r)",
  2,
 2,
 2,
 255.0);

  this.AssertCssColor(
  "\t\r \n\r\t\trGB(-.3250%\r,\t\t\t+180246%\r \r\n\r\n\n,5.07419874%)\n\n\n\r\r "
  ,

  0,
 255,
 13,
 255.0);
AssertCssColor("\t\r \n#2720",34,119,34,0);

  this.AssertCssColor(
  "\t\r \r\n\r\r\r\n\rHSl(-.916867246 \r, \r\t-.04601%,\t\n+.3%\t\r\n)\n\r\r\n\t "
  ,

  0,
 0,
 0,
 255.0);
AssertCssColor("\t\r rgb(\n168\r \n\t\t\r\r\r\t\n,\n -405,-412)",168,0,0,255.0);
AssertCssColor(
  "\t\rHSl(154\n,-4.456421%\t\r\r,1834176.88%)\n\r\r",
  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\t\rHsL(\n \n\r\n\t-591.8 \r,1390.3%\t\r\r ,\n\n.76%\r\t\r\r)",
  0,
 3,
 0,
 255.0);

  this.AssertCssColor(
  "\t\rRGb(.9%\r\n\n\t\r,\r\r\n\r\n90847097% \n \r\n,\r\r\n\n\n\r-.2%)",
  2,
 255,
 0,
 255.0);
AssertCssColor("\t\rhSL(\r.58\r\r,-4973655%\t,.960%)\r",2,2,2,255.0);
AssertCssColor(
  "\t\rhsl(\n\n-.5\n\n\n\t,-286853656%\n\n \n\n,-64.9422%)",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\t\rrgB(\t\r \t\n \r\n\n-895676.3%\n\t,-6906940916%,\t\n\r\n\n\r.6% \n\r)",
  0,
 0,
 2,
 255.0);
AssertCssColor(
  "\t \t\t\nrgBa(\r\r\n+.9%\n,\n\r0%,+8605%,38323.78025)",
  2,
 0,
 255,
 255.0);

  this.AssertCssColor(
  "\t \n \t rgB(-26\n\n\n\n\r ,6574223,-9\r) \n\t\r\n\n\n\r\n\n\n",
  0,
 255,
 0,
 255.0);
AssertCssColor(
  "\t \r\rHsl(\n45.78\t\n,\t\n\n\n\n \t 443.09%\n,.3%\r)",
  1,
 1,
 0,
 255.0);

  this.AssertCssColor(
  "\t RGbA(+.397% \n\n\r\t,44%,\t\n\r+.59145%,\n\t\n\n \n \r\r1828198\t)",
  1,
 112,
 2,
 255.0);
AssertCssColor(
  "\t HSl(\n\n\n\n \r+185\r\r \t\r\r,5%\r\n,\r-.12123%)",
  0,
 0,
 0,
 255.0);
AssertCssColor("\t RGB(.118%,.54%\t\n\t ,-.1%)\r",0,1,0,255.0);
AssertCssColor(
  "\t hSL(\n\r\r\r\r\r8.08\t,+.9%\r,1741%\n\r\r \r\n\r\n)\r",
  254,
 255,
 255,
 255.0);
AssertCssColor("\t hSL(\r\n\n\r+856\n\n\n\t,.0%,\r\r.392%\n\n\r)",0,0,0,255.0);
AssertCssColor("\t hSL(-79327.1,6564.540604%\r\n,+3.9491%\r)\r\n",0,2,20,255.0);

  this.AssertCssColor(
  "\t hsl(\t\n\t \n796262923\n\n\r,+.3432%\t\r\r\r\t\r \n\n,-.03% \r)\n\n\t \t\n \r\t"
  ,

  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\t hsl(+689288.83388080 \r\t\n,\n\r.2%,\r\t\n\n+3878.31741%)",
  255,
 255,
 255,
 255.0);
AssertCssColor("\t rgB(48\t\r\n\n\r\n,-5199\n\t\n ,\n34553)",48,0,255,255.0);
AssertCssColor(
  "\t rgBa(-84061%\n,+01%,.2%\n\t\r\n\r\n\r\r\n\r,\r-.740)",
  0,
 3,
 1,
 0);
AssertCssColor("\t#dcE\n\t\r",221,204,238,255.0);
AssertCssColor(
  "\tHSL(.611955\t \n,\t\r\r-86767%,0952126664.485940%)\n\r\t",
  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\tHSl(\r\t\n\r\r\r\n\r\n+.088783,\r \n\r -29869.7053477%,-590107.437%)",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\tHSl(-371600265278.810602,\t\n\n\n \r\r\n 302290.1%,-196.02%)",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "\tHSl(.91489858\r\n,\r\t+93163%,\r .0304%\t\r \n\t)",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "\tHsL(\r\t\n\n\n\n.6 \n,+71%\r,.339025226%)\r\r\r\n\n\r\n",
  1,
 0,
 0,
 255.0);
AssertCssColor("\tHsl(\r\n\r .7\n\r\n\n\n\t \r\n,.7072038%,-.9%)",0,0,0,255.0);

  this.AssertCssColor(
  "\tRGB(\t\n 4807\n,-699\r\r \n \n\n\t,\t\n\t\r\n\t\r\t\r\n12355\r\t\n)",
  255,
 0,
 255,
 255.0);
AssertCssColor(
  "\tRgb(+37 \t\r\t\n,\t\r\r\n\n\n\n+8,\n\r\n\n-89)",
  37,
 8,
 0,
 255.0);
AssertCssColor(
  "\tRgbA(\n-5331%\t\r\n\t\r,+7857%\r,\n8.9%\n \t,.91\n)",
  0,
 255,
 23,
 232.05);
AssertCssColor("\thSL(\t\n\n \n\r.520\r ,\t1%,-6%)\r\n \t\r\r",0,0,0,255.0);

  this.AssertCssColor(
  "\thsL(5387,544882238%,\r\r\t\r\r\n\r\r\r\n960%)\t\r\r\r\r\r ",
  255,
 255,
 255,
 255.0);
AssertCssColor("\thsl(\n+888,\t\r\n\n\r83.588561%,94%)\t",226,252,247,255.0);

  this.AssertCssColor(
  "\trGB(+40619 \t \n\r\n,07960503,\t-3829\r\r\t \r\r\n\r)\r ",
  255,
 255,
 0,
 255.0);
AssertCssColor("\trGB(2903576,87, \r\n\t\t\n -730)\r\r\n ",255,87,0,255.0);
AssertCssColor(
  "\trGBa(\r\n \r\r337.7%\n,+.23%,-.9%\t\n\n\t\t,-.23 \t)",
  255,
 1,
 0,
 0);

  this.AssertCssColor(
  "\trGBa(\r \r\n\r\t9230.96286936%\n,.983498%\n,-584126%\t,\n\r.5)\r",
  255,
 3,
 0,
 127.5);
AssertCssColor("\trGb(\n \r \r\r\t\t-31,\r\r\n2 \n,4 \r)",0,2,4,255.0);
AssertCssColor(
  "\trGb(\r6\n\r,-02344383\r\t,\r\r\r \n \n262)\t\r\t\r",
  6,
 0,
 255,
 255.0);
AssertCssColor(
  "\trgB(\n\r\n\r 0\r\r\r\n ,6970,+43142)\r\t\r\r\t",
  0,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\trgBA(-320536.5%,\n \t\r\r\n\n\r\r 2%,\t\n 1%\n\n \r\r\n\r\t\r,791\t\r\t\n\n\r \t\t\r)"
  ,

  0,
 5,
 3,
 255.0);

  this.AssertCssColor(
  "\trgb(\n\n\n-.46%, \t -2776788.8357% \t\n,\n\n\n\n\n\r-.331%\n\r \t\n\t)",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\trgba(+.31%,+1360%,19065%\n,\r\t\n\t\r\n\t +.8409\n\n)\t\t \t \n\n\n\n ",
  1,
 255,
 255,
 214.2);

  this.AssertCssColor(
  "\n\t\t \rrGBA(\n \n-6114,\n\t-8\t\n\t,+1068\r\t,\n\r.301\r)",
  0,
 0,
 255,
 76.5);

  this.AssertCssColor(
  "\n\t\n\t\nRgbA(41522 \r\n, \r\r\r\t\r\n+0,-3536 ,+54.2824273 \n\r)",
  255,
 0,
 0,
 255.0);
AssertCssColor("\n\t\n\tRgBa(\n -.554%,8%,.3%,.95334)",0,20,1,243.015);

  this.AssertCssColor(
  "\n\t\n\n\n\nHsl(.227480,\n-.1%\n,\r\r\r\n\r\n\t+.68889%) \r\n\r\r",
  1,
 1,
 1,
 255.0);

  this.AssertCssColor(
  "\n\t\n\r\n\r RGba(\r83 \t\t,\t\n\t95\r\n\n ,9984\r\t\n,\r-4.2730)\n\n\n\r",
  83,
 95,
 255,
 0);
AssertCssColor(
  "\n\t\n \t\n\t rGb(8\t,\n \n\r\t\r\t\r-71064\r,680\n\n\n\r)",
  8,
 0,
 255,
 255.0);
AssertCssColor(
  "\n\t\r\r\r\nhsl(+53682468,+.62%\r,\r \n\n8655648%)\r\r",
  254,
 255,
 255,
 255.0);
AssertCssColor("\n\t\r\r\r \r \r#Efe58a\t\t\r\n\r",239,229,138,255.0);

  this.AssertCssColor(
  "\n\t\rRGb(\n \t\n\t9,\t\n\n \r\r \r\t+5367,\n \r\n\t\n-825 \r)",
  9,
 255,
 0,
 255.0);

  this.AssertCssColor(
  "\n\t\rRgbA(\r-.5%\r\n\r\n \n,-.8%,.5537%,7148\r\r\r\r\r\r\r\r)",
  0,
 0,
 1,
 255.0);
AssertCssColor("\n\t#2f3FBC\t",47,63,188,255.0);
AssertCssColor(
  "\n\tHSL(50,\n\r\n\n\t\r\r\n398%\r\n\n,\r-.0%\t)\r\n\n ",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\n\tRGbA(+.10%,8.50367%\r\n \n \n,\r\r\n\n+70%\r\n,+76\t\t\r)",
  0,
 22,
 179,
 255.0);
AssertCssColor(
  "\n\tRgB(5,\r\n\r \t \n\t300\n,2838230\t) \n\r\n\r\n",
  5,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\n\thSl(\t.405672,\r \r\r\t \r \r\r +.3%\n,-.653519024%\n\n\n)",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\n\thsL(\t .2\r,\n\r\t\t\t\n\r\r\r\t\n+.312907% \t\r,28408446402.74843805%)\n",

  255,
 255,
 255,
 255.0);
AssertCssColor("\n\trGB(\t\r7%,-9% ,.0%\t\n)",18,0,0,255.0);
AssertCssColor(
  "\n\trGb(1415642471,\n\r\r 481604126976,4\r\r\t\n \n\n\n)",
  255,
 255,
 4,
 255.0);

  this.AssertCssColor(
 "\n\trGbA(\n7899% \n\t\n\r\r,\r \r\r.58%,\r2.050877%,-29067\r\n \n\n\t)\n\r ",

  255,
 1,
 5,
 0);
AssertCssColor(
  "\n\trGba(2627,74974,\r\n\n \r+00\n\n\r,\r\n-.11004)\n",
  255,
 255,
 0,
 0);

  this.AssertCssColor(
  "\n\trgb(16944,\n\n+9\r\n\r\r\r\r,\n\r\t\t\n-78959\n\r\n\r\r)\r\r\n",
  255,
 9,
 0,
 255.0);
AssertCssColor("\n\n\t\n \r\rhsL(\n8431638222.00330166,2%,\r.94%)",2,2,2,255.0);

  this.AssertCssColor(
  "\n\n\t \r\rhSl(\r\n\n-.08\r\t, \r\r 7.564219%,\r.420576%)\n\n\t",
  1,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\n\n\n\t\n \r\nRGbA(\t\r\n\r96037,\n \n+1992,+3648\t\n\n\r\n\t\r,+52538.479\n\n\r)\n\n\t\t"
  ,

  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\n\n\n\t\nrGb(36032500\n\n\t\n\n\n\n\n \n,\r\r-1\t\n\n,\r\n+362)\n",
  255,
 0,
 255,
 255.0);

  this.AssertCssColor(
  "\n\n\n\nRGBa(\t.0138%,\n \r\n\n\r.623863%,\r.406351%,9814.5)",
  0,
 2,
 1,
 255.0);

  this.AssertCssColor(
  "\n\n\n\nRGBa(-.370681228%,\n\r\n\n+.1%\r,\r+.331427897%,\r\t \n+2246.6855)\n\n\n "
  ,

  0,
 0,
 1,
 255.0);

  this.AssertCssColor(
  "\n\n\n\nrGBA(538633, \n\n\t\t\t\n2389716,\r31,-5889533.487883\n\t\r\n\r\n \r\n)\r"
  ,

  255,
 255,
 31,
 0);

  this.AssertCssColor(
  "\n\n\n\r\r HsL(\n3.896732\r \t\n\n\r\n\n\t\t,\r94.122051%\r,8076.541722% \r\r \t)"
  ,

  255,
 255,
 255,
 255.0);
AssertCssColor(
  "\n\n\nhsl(.5\t\n,\n\r-0%,628430.303498%) \n\r\r",
  255,
 255,
 255,
 255.0);
AssertCssColor("\n\n\nrgB(+.7801%\n\n,\t-0%,+458.58%\r)\n\r\r",2,0,255,255.0);
AssertCssColor(
  "\n\n\r\n\r\n\n\n\r hsl(.0,\r\n09%,\r+50618854%)",
  255,
 255,
 255,
 255.0);
AssertCssColor("\n\n\r\n\r #4BeDcEfe",75,237,206,253.98);

  this.AssertCssColor(
  "\n\n\r\n\rHSl(\n\n\r\n700, \n\r\r .28%\t\r\n\r,\r\n\n.612980385%)\r\t",
  1,
 1,
 1,
 255.0);
AssertCssColor(
  "\n\n\r\nHsL(\t\r+.00\r\t,-.99%,-.21%)\n\t\n\r\t\n",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\n\n\r\r\n \t\rRgBA(\n\n\r\n\t\n\r+4%\r\n\n,\r\r\t\r\r+442779973% \r\t,\n\r\t\r\r31%\r\n\r\r\n\r\r , \r\n\r-.4\n)\n\r\n\t\t\t"
  ,

  10,
 255,
 79,
 0);
AssertCssColor("\n\n\r\r\r#Bfc8\n",187,255,204,135.91500000000002);

  this.AssertCssColor(
  "\n\n\r\rRgbA(0315%\r\n \r,\t \n\t\n\r .13%,-.35869%\t, \n\n\n\n+0.666\r)",
  255,
 0,
 0,
 170.085);

  this.AssertCssColor(
  "\n\n\r\rrGBA(+.015%,\r\t\t\r\r3430535.10%\t\t,196%,.87\r)\n\n",
  0,
 255,
 255,
 221.85);
AssertCssColor(
  "\n\n\rRgB(\r-.5%\t,-2213040159%,54180%)\r\r \n\r\r\n",
  0,
 0,
 255,
 255.0);

  this.AssertCssColor(
  "\n\n\rRgb(\n\n 546.0%\r\n\r, 9478.311%\r,\n\r\r\n.05839077%)",
  255,
 255,
 0,
 255.0);
AssertCssColor("\n\n \t\n#a7DcbebD \n\n\n",167,220,190,188.7);
AssertCssColor("\n\n \nHSl(.99,-.90346%, \r\r\n \n .478%)\n",1,1,1,255.0);
AssertCssColor(
  "\n\n \r\n\nRGB(8293\t\t ,439471,\r\r\n\n 5\n\n)",
  255,
 255,
 5,
 255.0);

  this.AssertCssColor(
  "\n\n \t\n\rhSL(\r+.5170,3%\n \r\n\t,\r\t+6744308%\t\n\n)\t",
  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\n\nRGb(-.4% \r\n \r, \r\t\n\r-.37227%,\r\n\t\n\n\t\n\r\n\n323%)",
  0,
 0,
 255,
 255.0);

  this.AssertCssColor(
  "\n\nRgba(.216%,\t\t\r\r\r.001033%\n,5.865%\r\n \n,-.9034\r\n\r\r\r)",
  1,
 0,
 15,
 0);
AssertCssColor("\n\nrGb(\n029%,.1653% \n\t\n \n,+.8%\r)",74,0,2,255.0);
AssertCssColor(
  "\n\nrGba(008, 82,+7,\t+.3928636091\n\r) ",
  8,
 82,
 7,
 99.96000000000001);
AssertCssColor("\n\nrgb(.8%,7%,\t\n+132859.9%)",2,18,255,255.0);
AssertCssColor("\n\r\t\r\t \r\t\nRGB(-.1512%\n, -42%\n,-.541%)",0,0,0,255.0);

  this.AssertCssColor(
  "\n\r\t\r\r\r\nrGbA(\t \n\n\t\r\n-010.29621% ,+553784924%\n\r\r\r,\n\r\n\r\n\n95.2854483833%\n\t,\t64.5 \r\r\r\n\n\t\t)\t\n\r\t\n\t\t\r\n\r"
  ,

  0,
 255,
 243,
 255.0);
AssertCssColor(
  "\n\r\trGb(\t\n\n+1,92947202,+760436\t\r\t\r \t\n)",
  1,
 255,
 255,
 255.0);
AssertCssColor("\n\r\n\n\nRGBA(81,+3,00,\t\n\r+.9)",81,3,0,229.5);
AssertCssColor("\n\r\n\n\r\r\t#efF",238,255,255,255.0);
AssertCssColor("\n\r\n\r\n#ffFc",255,255,255,204);
AssertCssColor("\n\r\n\r\r\r\r\r#beFcb1\r ",190,252,177,255.0);

  this.AssertCssColor(
  "\n\r\n \r\t\n\r\nrGb(\n\n\r-29453.6%\t\r\r\r\r\t\n\r,\r\n\r\n\n \n\n.00509806%,\r\r\r\t-.0%)"
  ,

  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\n\r\n RGba(.3685%,\r\r+.246%\r,\r\t \n.8%\n\r\t\r \r\t\t,\n\t\n-.99951)",
  1,
 1,
 2,
 0);
AssertCssColor("\n\r\n rGb(2027, -60,+50)\n\n",255,0,50,255.0);
AssertCssColor(
  "\n\r\nHsl(\n\n.13 \n\r\n\r,\n\r-258903.02%\n\n,75497%)",
  255,
 255,
 255,
 255.0);
AssertCssColor("\n\r\nRgBA(-.34602%,\n\r.813%,+.82%,\n\r.3)",0,2,2,76.5);
AssertCssColor("\n\r\nrGB(\r+1,+79236969800\r \t,99222018)",1,255,255,255.0);

  this.AssertCssColor(
  "\n\r\nrGBA(\r\n\r .709%\t\r ,\n\r\n\t+.892%\n\t\t\r, -.004%,+.8)\r",
  2,
 2,
 0,
 204);

  this.AssertCssColor(
  "\n\r\r\t\n\r\n\r HsL(9,\n+566445386099% \n\n\n\r\n\n \r\n,\r\t8%)\r",
  40,
 6,
 0,
 255.0);
AssertCssColor(
  "\n\r\r\nrgBa(-8, -0\n\t\n\n ,\r \r \t+44,\r.72579)\r",
  0,
 0,
 44,
 184.875);
AssertCssColor(
  "\n\r\r\r\n\r\n\t \t\nhsl(01.338,\r535.9% \n,4%)\n\n\r\t \n",
  20,
 0,
 0,
 255.0);
AssertCssColor("\n\r\r\r\n\r\n\r\t\n #BDCd",187,221,204,221.085);
AssertCssColor(
  "\n\r\r\r\rrGb(-35456650645% \r,\t \n\n.6% \t\r\r,-957%) ",
  0,
 2,
 0,
 255.0);

  this.AssertCssColor(
  "\n\r\rRgb(\r\r\r\n\r.193469%,-5915437624%,\t\n\n\t\t\r\r\r\t\r.52%\n\r\r\t\r) "
  ,

  0,
 0,
 1,
 255.0);

  this.AssertCssColor(
  "\n\r\rrGbA(\t47464329\n ,7860,\n\r\t \t\r\n+8,\r\r+6544.691667\n)",
  255,
 255,
 8,
 255.0);

  this.AssertCssColor(
  "\n\r \t\n\tRgb(+0865902.7%,\t\t\n27736003277.01%\n\r\r\t\n\r,+4.785%\r)\t\n \t\n\n"
  ,

  255,
 255,
 12,
 255.0);
AssertCssColor(
  "\n\r \t\nrgba(-7 \t,\n-083\r\t,\r\r\r99,6.1705291143\t)",
  0,
 0,
 99,
 255.0);
AssertCssColor("\n\r \r\n\r\n\t#a0FE",170,0,255,237.91500000000002);
AssertCssColor("\n\r \rRgb(\r+114,50,\r \r\r47067)",114,50,255,255.0);

  this.AssertCssColor(
  "\n\r rgB(\n\t \n\n\t \t\n+0129478844%,-.127%,+3.26%\r\r\r\n\r)\r \r\n\n \n\r\r"
  ,

  255,
 0,
 8,
 255.0);
AssertCssColor(
  "\n\r hSl(\n\r\r\n\r\n\t\n\r\r-.54421080, \r3%\r,-0436839%)",
  0,
 0,
 0,
 255.0);
AssertCssColor("\n\r#EaaDccAa",234,173,204,170.085);
AssertCssColor("\n\r#ecEfFc",236,239,252,255.0);

  this.AssertCssColor(
  "\n\rHSl(\r\t.45650851,\r \t\n\t\n.90663%\n\r\r,704.9306%)\n \n \r",
  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\n\rRGBA(\r\t -9756548616\n, \t\n\n4\t\r\n\n\n\t\n,+2 ,\t83)",
  0,
 4,
 2,
 255.0);
AssertCssColor(
  "\n\rRGbA(6888506,85\r\r\n\t\t\t\t,\t-51,+.694\n\n)",
  255,
 85,
 0,
 176.97);
AssertCssColor(
  "\n\rRgB(\r\t\t\n069\n\n\n,\t\t\t\r8, \r\n81386530)",
  69,
 8,
 255,
 255.0);
AssertCssColor(
  "\n\rRgB(\n \n \n \t \t\n\n+.086%\t\n ,43.0%,9%)\r\n\r\n\t",
  0,
 110,
 23,
 255.0);
AssertCssColor("\n\rhSL(6.8852,.97%\r\n,+4948%)",255,255,255,255.0);
AssertCssColor("\n \t\thsL(+.8,+.19560318578%\r\r\n,-3%)",0,0,0,255.0);
AssertCssColor("\n \thSl(\r-5.450,.5%, \n+.477%)",1,1,1,255.0);
AssertCssColor("\n \n\t\r\n\r\r#bFbF1bE9",191,191,27,233.07000000000002);
AssertCssColor(
  "\n \n\n\n\nRgbA(89%\n\n\r,\n-.27747%,+.47365%,-7090952)",
  227,
 0,
 1,
 0);
AssertCssColor("\n \n \r#B6cF\n\r \n",187,102,204,255.0);

  this.AssertCssColor(
  "\n \r\t\n\rHsl(+.44\r\r\n\n \t\r\t\r\r,\t\n \t\n\n \r+7%\t\t\r\n\t\r\r\n,+2%\r\t \n)"
  ,

  5,
 4,
 4,
 255.0);
AssertCssColor("\n \r\n\n#EA7",238,170,119,255.0);
AssertCssColor("\n \r#bdf2\n\n ",187,221,255,33.915);
AssertCssColor("\n \t\t#efDC7A\n\t\n\n",239,220,122,255.0);
AssertCssColor("\n \nHsL(-309.256\n\n ,\n\n+4.3%,\t.9%)",2,2,2,255.0);
AssertCssColor("\n \r\r#aBBD",170,187,187,221.085);
AssertCssColor("\n #AEEAcc",174,234,204,255.0);
AssertCssColor("\n #Ff4",255,255,68,255.0);
AssertCssColor("\n #aaabbaDb\r",170,171,186,219.29999999999998);

  this.AssertCssColor(
  "\n RGbA(\t-1 ,\r\r49\r\t,\r+0073\t\r,\t\r\t\r\n+.49229\r\r) \n ",
  0,
 49,
 73,
 125.97);
AssertCssColor(
  "\n RgBA(\r\n\n\r\r\r-4038\r,+6121,4051,.055)",
  0,
 255,
 255,
 14.025);

  this.AssertCssColor(
  "\n RgBA(+6995384662%,-6.0508668620%,\r\r\r\n\r\n-.1731387%\n,\n\t\t-.7)\n\r \n\r\r\n"
  ,

  255,
 0,
 0,
 0);
AssertCssColor(
  "\n rgb(.0%\r\t\r,\n-.3239%,\r\t\t\n\r\r\t 1918%)",
  0,
 0,
 255,
 255.0);
AssertCssColor("\n#6b451c1d\t\r\n\r",107,69,28,29.07);
AssertCssColor("\n#C9aFDB",201,175,219,255.0);
AssertCssColor("\n#DAfa ",221,170,255,170.085);
AssertCssColor("\n#EDD\r\n",238,221,221,255.0);
AssertCssColor("\n#F9eadcfb \r\t\t \n\n\n",249,234,220,250.92);
AssertCssColor("\n#FEbA\t\n\n\r",255,238,187,170.085);
AssertCssColor("\nHSL(\r \r\r \r+.92,9.94%,+.95%\n\r\r\n\t) ",2,2,2,255.0);

  this.AssertCssColor(
  "\nHSL(\n\t3.4613 , \r\n\t\n\r\t\t-.58527852139%\r\n\n\n\t\r\r\r\t,-.5987%) \n\r \r"
  ,

  0,
 0,
 0,
 255.0);
AssertCssColor(
  "\nHSL(+6.340\t\t,\n\r\n\r9960201%,\r.9%)\n\n\n \r\r\n\t",
  4,
 0,
 0,
 255.0);
AssertCssColor("\nHSL(.13,+9.6%,+.30%)",0,0,0,255.0);
AssertCssColor("\nHsL(\t69911,.24%\t\r,358370%) \t\r\n",255,255,255,255.0);

  this.AssertCssColor(
  "\nHsl(\t 3\r,019022.236786564%\t\n\r\r\r\r\n\n ,\r\n\r\t\n\r\n-.7%)",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\nHsl(\r\n\n.6,.13205%\n\n \n\r\n\n \n\n\r\n,+.6596796087%) \t",
  1,
 1,
 1,
 255.0);

  this.AssertCssColor(
  "\nHsl(\n\r\r\t\n +.841,\n\t\t.6% \r\n ,\r\t\r291187661241.6%)\r",
  255,
 255,
 255,
 255.0);
AssertCssColor("\nHsl(+.8853,.5%\n\n\r\t,-.095502167%)",0,0,0,255.0);
AssertCssColor("\nHsl(-.647\r\n \n,75.4%, \r \n \n\n\r1%)",4,0,0,255.0);
AssertCssColor(
  "\nRGB(.4820%\t\n,-65204673%\r, \r\r-1201.5%)\r\t\n\n",
  1,
 0,
 0,
 255.0);
AssertCssColor("\nRGB(47%\n,\n8%\r \n\n\r\r\t\t,-.08%)",120,20,0,255.0);

  this.AssertCssColor(
  "\nRGBa(31.2333%, \r\r.7%,\n \r\r\n\t\r0.934701%,22.1206854)\n",
  80,
 2,
 2,
 255.0);
AssertCssColor(
  "\nRGb(\n\r2761857\r,\r\r\n \n\t\r \n7848494291\n,\t8)",
  255,
 255,
 8,
 255.0);

  this.AssertCssColor(
  "\nRGb(\n \n\t\r\t\n+8092046562%,\n\n\r-37486439%\t \n\t\t,.16%\r)",
  255,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\nRGbA(\r\r\r.1716779% \n \n,+7.11700275%\t\n\n\n ,\n \r \r0%,\r+9708\r)",
  0,
 18,
 0,
 255.0);
AssertCssColor("\nRgB(\n\n77\t\n \r,-294852\n\n,\n-84)",77,0,0,255.0);
AssertCssColor("\nRgB(312%,\n16711999%\r\t\n\t\n\t,.6%)",255,255,2,255.0);
AssertCssColor("\nRgB(499.0%,\n.1558%,.141%)",255,0,0,255.0);

  this.AssertCssColor(
  "\nRgb(\n\r\r\r\r\n\r+55373432807%\r\t\r\r\r\n\n,\r\n \r\r.5278%\n,\t+.5%\r\n \n\r\r\n\t \t\n)"
  ,

  255,
 1,
 1,
 255.0);

  this.AssertCssColor(
  "\nRgba(45,\r\n\n \n\r\t-276\t\n\r\t\n\t\n,\t\t3,+7\r\n\t\n)",
  45,
 0,
 3,
 255.0);
AssertCssColor("\nhSL(\t\n\r\t\t \n\r.8,878%\n\t\r \n \n, +.5%)",2,0,0,255.0);
AssertCssColor(
  "\nhSL(\r\t\r\n\r\r \r\r .6 \r\t, \n \r740%\r ,-8601%)",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "\nhSL(+7833\r ,\r\n\t+90822189.4%,-117.76%\n\r \n)\n\n",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\nhSL(-.3,\r\n+25929881.961643%\n\r\n\r ,\r\n\n-.6%\n\n\r)\n\n",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "\nhSl(\r\r .485,\t+3.4349%\n\n\n \r\r\t\r ,.573950%)",
  1,
 1,
 1,
 255.0);

  this.AssertCssColor(
  "\nhSl(-.2180\r\r\r, \n\n\r\n\r\t\n \n+.57529%\r \r\t,\t\n\r \r .82%\r\n \n)",

  2,
 2,
 2,
 255.0);
AssertCssColor("\nhSl(.87\r\r,9%,638175.636%\n\t)",255,255,255,255.0);
AssertCssColor(
  "\nhsL(-5,\r \r\n \r\n\t\r\n+35.9674131% ,\r\r+.626514008%)",
  2,
 1,
 1,
 255.0);
AssertCssColor(
  "\nrGB(\n\t\r -7360.1058%\n \r,2202.81%,-82278%\n)",
  0,
 255,
 0,
 255.0);
AssertCssColor("\nrGBa(7, -19377,\t \r\t\r\r81,\t\t \n3.097)",7,0,81,255.0);
AssertCssColor("\nrGb(.0%,.93074%\n,\n\t+14143%\r)",0,2,255,255.0);

  this.AssertCssColor(
  "\nrgBA(\t\n\n\r\r\r \r\n\n\n139389,+0 \r,+348569708\r,\n\n\t\n3.41524 \r)\r\r",

  255,
 0,
 255,
 255.0);
AssertCssColor(
  "\nrgb(\n7%\n \n\t\r\r\r\t ,\r\t.58%\r,-.6%\r \r\r\n)",
  18,
 1,
 0,
 255.0);
AssertCssColor(
  "\nrgb(\t\n-6561465073,\t\r21,\r\r\t\n \n\n\r\r\r+06)",
  0,
 21,
 6,
 255.0);

  this.AssertCssColor(
  "\nrgba(\n \n\n\r\n +.06%,+.710363%\r\r\r,\t\r\t\r\t\r\t -44360842% \r\n\t\r\r\n\n \n\r,-.8202)\r"
  ,

  0,
 2,
 0,
 0);
AssertCssColor(
  "\nrgba(0, \r \r+1,\n\n 929344\r\r \r ,+.9497\n)",
  0,
 1,
 255,
 242.25);

  this.AssertCssColor(
  "\r\t\t\n\nrGba(\r\t 223215,+80\r\n\r\r\r,-0645\n,\t.6646)\n\r\n",
  255,
 80,
 0,
 169.065);

  this.AssertCssColor(
  "\r\t\tRgb(+281\r\n,\r\r18013\n\r\r\n\n,-55037)\n\n\r\r\t\r\r\t",
  255,
 255,
 0,
 255.0);

  this.AssertCssColor(
  "\r\t\trGba(\r\n \t-72866631\r,\r\n\n\n\r\n \t\t\r+38\t\n\n\t \r,-140\r\r , \r\n\n-.5916905) \t\t\n\n\r"
  ,

  0,
 38,
 0,
 0);
AssertCssColor("\r\t\n \r\n\r\rRGbA(34314,+76\n,-132064,.18)",255,76,0,45.9);

  this.AssertCssColor(
  "\r\t\n \r Hsl(185,\t-153.41218151433%\n\n\t\n\t,\t\r\r\n\n\r\t\t\t\n\n\r30.327%\r\r)"
  ,

  77,
 77,
 77,
 255.0);

  this.AssertCssColor(
  "\r\t\n RGB(\r \r \n0444154778.0%\n\n\r,+193%, \r\t+67.72284%\t \t)\n\t\r\r\t\n\r\n\r"
  ,

  255,
 255,
 173,
 255.0);

  this.AssertCssColor(
  "\r\t\nhSl(\t\n\r\t\n 29802 \r\r\t,.70303735% ,\r-.083%\t\n \n\n\n\n \n)",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "\r\t\nhSl(37423 ,\t-.38119%,\n+.94996%\t\t\r\n\r\r\r)\r\n\n",
  2,
 2,
 2,
 255.0);
AssertCssColor(
  "\r\t \nRgBa(\t743\n\r,\n\r+5,-0\t\r\t\n,+.11708)\t",
  255,
 5,
 0,
 30.09);

  this.AssertCssColor(
  "\r\t \r\r\t\trGBA(+19932%,\r472144416.969513%\t\r\n\n \n\t\t \n,+90%\t,\n\r\r \n\n\r.4)"
  ,

  255,
 255,
 230,
 102);

  this.AssertCssColor(
  "\r\t \rRGb(\n \t\n\r\r-103593%,\r-.588542%,\n\n .58659%\n\r \n\n)\t",
  0,
 0,
 1,
 255.0);
AssertCssColor(
  "\r\t hsL(\r\t-.6\n\r\r,\n\n\n\r-1944%,\t\r\t+47%\n)",
  119,
 119,
 119,
 255.0);
AssertCssColor(
  "\r\t rgbA(-5700\r\n\t\r \t,\t \r\n7,-6,+.037834438)",
  0,
 7,
 0,
 10.200000000000001);

  this.AssertCssColor(
  "\r\trgb(14.2977%\t\r\t\r\n\t,\r+.0%\n \r\t,+.11830958664%\n)\t",
  36,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\r\n\t\n\t HSL(\r \n-81.6420832\r\t\r\t\t, \n\n\n-80%,\r \r\n-6.23% \t\n\n\n\r\r)"
  ,

  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\r\n\t\n\n\t\nHsl(\n\r\t+7.6625,+.4%\r \r\n\t\r\t,494.3%)\r\n",
  254,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\r\n\t\n\r\nRgBA(\t\r -353651039.0093%\n,.3%,-.16%\r\n \r ,\t\n0866.317707\n\n\r\r\n \r\t)"
  ,

  0,
 1,
 0,
 255.0);

  this.AssertCssColor(
  "\r\n\t\r\t\r\r\n \n\nRgBA(\r\r\r\t\n01%\r, \n\r\r+18492%,\r\r\r\t\t\n+4%\r \r,\n.6)\r\t \t"
  ,

  3,
 255,
 10,
 153);
AssertCssColor("\r\n\t rGB(-84.11%,\n\n+.62414%\t ,+.93%\r)",0,2,2,255.0);

  this.AssertCssColor(
  "\r\n\tHSL(\r +.072\n\n,\n\t\t\t\n\r\r\n03.475662564%\r\n, \n \r\n9.12600%\n\t\n\r)"
  ,

  24,
 22,
 22,
 255.0);

  this.AssertCssColor(
  "\r\n\trGb(\r\t\r\r\r \t-.87%,\n+27.19%\n\r\r,\r\r \r\r\r .605%\t)\r\r\r",
  0,
 69,
 2,
 255.0);

  this.AssertCssColor(
  "\r\n\n\t\n \r\nHSL(\t-.03009567, \n \r-396.258%,\r+.763449%)\n\r\r",
  1,
 1,
 1,
 255.0);
AssertCssColor("\r\n\n\t\r\n\r\n#FDBeAd4b",253,190,173,74.97);
AssertCssColor("\r\n\n\nrGba(-.3%,\n-.9299895%,\n+.365%,.854)",0,0,1,218.025);
AssertCssColor(
  "\r\n\n\nrgB(\n7894104\n,-18552\r,\r+166)\t\t \n\r\r",
  255,
 0,
 166,
 255.0);

  this.AssertCssColor(
  "\r\n\n\r\rRgB(38\t\t\t\n\n \r,50,\t\r\n\n9375) \n\r\r\n\r\n\t",
  38,
 50,
 255,
 255.0);
AssertCssColor("\r\n\n\r \r\n\nHSL(\r\r-8.1,+43.6177%,\n+.5%)",1,0,0,255.0);
AssertCssColor("\r\n\n\r#EeeA ",238,238,238,170.085);

  this.AssertCssColor(
  "\r\n\n\rhsL(-1737803,-207.41467453%,\n \r\n\t \r\n\r\r+.3%)\r\t\n\n\t",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "\r\n\n \rhsl(+.9696 ,.888554141%\n,75793.6886616%\r \r)",
  254,
 255,
 255,
 255.0);
AssertCssColor(
  "\r\n\nHsL(\n\r\n \r\n\t-.82, \r2960%, \n\r\r\t+3.038%)",
  15,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\r\n\r\t\r\nrgB(\r6169949%\r,\n \t\t\r \r\r +.6%,\n91.495526321%)\r\t\n\r\n\n "
  ,

  255,
 2,
 233,
 255.0);
AssertCssColor(
  "\r\n\r\n\r\n\nrgB(898, \n-56\r\n\t\n \n\r\n\t\n,+01068\r)",
  255,
 0,
 255,
 255.0);
AssertCssColor(
  "\r\n\r\n\r\n\r\n\n \nRgB(-.97039062%,-.97%\t\n,.6559%\n\n)",
  0,
 0,
 2,
 255.0);

  this.AssertCssColor(
  "\r\n\r\n\r\r\n\t\n\r\nRgBA(+049,\t27,\n84,\n\r.69\n\n\n\r\n)",
  49,
 27,
 84,
 175.95);

  this.AssertCssColor(
  "\r\n\r\n RGb(\r\r\r\n\n357618.61%\r\n\r,627787984.76185%\t\r\r\n\n\n\r\r\t\r,-7.151897%) \t"
  ,

  255,
 255,
 0,
 255.0);

  this.AssertCssColor(
 "\r\n\r\r\t\t\nHsL(.740\n\r\r,\r\n\n\n\r\r\n06%,\n\n-857.53552%\t\r\r\n)\n\r ",

  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\r\n\r\r \n\r\n\nhsL(+.377 \r\r,+35128.8%,\r-.458%)\r\r\r\n\t ",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "\r\n\r\rHsL(\n\n.941868,.35%,\n\n\t\r783%)\n\t\r\r\n\r\t ",
  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\r\n\r \trGB(\r\r\r\t\n -060%, \r\r\t.126551833%,\n.3423%)\r\n\r\n\r\r\n\r",
  0,
 0,
 1,
 255.0);
AssertCssColor("\r\n\r \nRGb(9\t,\n\t+4,854\n\n\r\r)",9,4,255,255.0);

  this.AssertCssColor(
  "\r\n\rRGbA(\n80.1015%\r \n\r\r,-.1%\r\n\r\n\r\t,\n\n.47%,77\r\t)\r\r",
  204,
 0,
 1,
 255.0);

  this.AssertCssColor(
  "\r\n\rRgB(\r \t.636%\r\r ,\n+2550993982.361730%,\n\r\n\r-05528%\r)",
  2,
 255,
 0,
 255.0);
AssertCssColor("\r\n \t\r\n\r#aaCc",170,170,204,204);
AssertCssColor(
  "\r\n \t\rRgBA(\r-6,\r\n \n\r \t+4909785768,98556,.779\n\r)",
  0,
 255,
 255,
 198.9);
AssertCssColor("\r\n \n\n\t\n\n\n\n#c10ccBfb",193,12,203,250.92);
AssertCssColor(
  "\r\n \n \n\rHsl(\n\n-.19,\n\r\n\r\r\r\r8151%\t ,.3%)\r \n ",
  1,
 0,
 0,
 255.0);
AssertCssColor("\r\n \r#c2d",204,34,221,255.0);
AssertCssColor("\r\n RgB(58890,-179,\n\n86\r\n\r\t)\n",255,0,86,255.0);
AssertCssColor(
  "\r\n hSl(\t \r\n\n\n\r .0,\n2096.2%,818.531%\n)",
  255,
 255,
 255,
 255.0);
AssertCssColor("\r\n#BBFfdead\t\r",187,255,222,173.4);
AssertCssColor("\r\n#CBaCBc\n\r",203,172,188,255.0);
AssertCssColor("\r\n#Fdaabf",253,170,191,255.0);

  this.AssertCssColor(
  "\r\nHSL(69.176671\t \r\t, \n\t\t55528%\r,\r\t\n\n\r\n8326%\r\n)",
  255,
 255,
 255,
 255.0);
AssertCssColor(
  "\r\nHSl(\n.93902243551 ,.477100%\r,121257271%)\r",
  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\r\nHSl(\r\n\t\r\n\n02.783961\n\t\n\n ,-.938318616%,-.72638987%)",
  0,
 0,
 0,
 255.0);
AssertCssColor("\r\nRgb(+7,-8869 \r\n\n\n\r\r, \n \n+7)",7,0,7,255.0);
AssertCssColor(
  "\r\nhSL(\r-.001626754\t,.74%\n\n\n\t\n \n\n,-.699903%) \n",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\r\nhsL(\n \r\r-.1532622952\n\r\n,+662.61%\r\t\n\n\n,.5256541%) \r",
  2,
 0,
 0,
 255.0);
AssertCssColor(
  "\r\nrgB(177140%\n\n,\n.641%\n\t\n\n,+827%\n\n\t\n)\r\t\t ",
  255,
 2,
 255,
 255.0);

  this.AssertCssColor(
  "\r\nrgBA(\r \r500 \n\r\n\t\n\n\r,341 \r,2 ,\r.938580045\n\n)",
  255,
 255,
 2,
 238.935);
AssertCssColor("\r\r\t\r\t\n\r\t\n\n\r\r#cad ",204,170,221,255.0);

  this.AssertCssColor(
  "\r\r\t\r\t \n\nRGbA(\n\r\t \t\r\r\n 360%\r\r \r,\r\t\r-.25527%\r\n \r, \n\r\r\r\t\r +.57103%\t,\t +.6)\r\r\n\t"
  ,

  255,
 0,
 1,
 153);
AssertCssColor("\r\r\n\t\n\r\n\r\t\n\r rGB(52,33,+71)",52,33,71,255.0);

  this.AssertCssColor(
  "\r\r\n\n\r\r\tHSl(\r\t8874496\r, \r 9746.4%, 70% \n\n\r\n) \r",
  101,
 255,
 142,
 255.0);
AssertCssColor("\r\r\n\r\n\nRgb(74739798,1\n,\t\r-369) \t\r ",255,1,0,255.0);
AssertCssColor(
  "\r\r\n\r\rhSL(\t\r.47\n\n\r,99229747.8582%,.328%\r\t\r)",
  1,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\r\r\n \rrGB(\t.3%\t \t\n,\t\t\n\t\r\r\t\n\t+9211%\r\r\t\n\n, -.69%)",
  1,
 255,
 0,
 255.0);
AssertCssColor(
  "\r\r\nrGB(51301628,-39,\r\r\t-400685864\r\r \t\t\n)\n\n",
  255,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\r\r\nrGBA(.038899%\n \t \t\n\r\r,\n\n170%\r\r\t \t,\n\n-.28%,+.52403\r\t\t\r\n\n\r)"
  ,

  0,
 255,
 0,
 133.875);
AssertCssColor("\r\r\r\t\trgb(+01%,\n.6%,+426%)",3,2,255,255.0);

  this.AssertCssColor(
  "\r\r\r\t \n\nrgBa(\t\n0852066\n\r\r\n\n,-4\n,+07263947774\t, \n \r\t \n\t\n .6518)\r\r\r"
  ,

  255,
 0,
 255,
 165.75);

  this.AssertCssColor(
  "\r\r\r\n\n\n\r\trGbA(\n \n\r\n\r+712373278%,-.1484%,\t\n \r \n\r\n\t\r-.327248210372%\t\n \n\n,+.2\t \n)"
  ,

  255,
 0,
 0,
 51);
AssertCssColor(
  "\r\r\r\n\n\r\rRGBa(58085\n,\t\r\n+33673,\r\n-778, \r138459)",
  255,
 255,
 0,
 255.0);
AssertCssColor("\r\r\r\n\n\r#eCfDC2ea",236,253,194,234.09);
AssertCssColor(
  "\r\r\r\n\r\rHsl(\r-.1662,\n \n\r-9761%\n\t\r,\n.961%)\n",
  2,
 2,
 2,
 255.0);

  this.AssertCssColor(
  "\r\r\r\n \n\n\nrgbA(\n\n\n\t\r-18111085637,26076,-02390420 \r\r\n\t,-0938.4\n \t\r\r\r \n\n)"
  ,

  0,
 255,
 0,
 0);
AssertCssColor("\r\r\r\n \n#FCebBEcf",252,235,190,206.55);

  this.AssertCssColor(
  "\r\r\r\nHsL(+.577\r \t\r\r \n,-.3368631395%,\t\n\n\r\n\n\n.9%)\t\n",
  2,
 2,
 2,
 255.0);
AssertCssColor("\r\r\r\r\t#BF4BeA",191,75,234,255.0);
AssertCssColor("\r\r\r\r\n#DAEd\n ",221,170,238,221.085);
AssertCssColor(
  "\r\r\r\r\r\nrGb(56062,+0\n\r\r,22963498\n\n\r\n)\t\t\r",
  255,
 0,
 255,
 255.0);
AssertCssColor("\r\r\r\r#dfABF2bF",223,171,242,191.25);
AssertCssColor(
  "\r\r\r\rRgb(\n \r\r\n+8%\r \n ,+8%, \n\r\n\r\n\n530%)",
  20,
 20,
 255,
 255.0);

  this.AssertCssColor(
  "\r\r\r\rhsL(.9749,\r\r.137949%\r\n\n\r\n\r,\r \t\n\t\n\t.6%\r\n\r)",
  1,
 1,
 1,
 255.0);
AssertCssColor("\r\r\r#CBaB",204,187,170,186.915);
AssertCssColor("\r\r\r#c0d7C5ae\n\r\t",192,215,197,173.91000000000003);
AssertCssColor(
  "\r\r\rRGb(\r\r.97597%\n\t\n\t\n\t\r,249573.3%,.02%\n)",
  2,
 255,
 0,
 255.0);

  this.AssertCssColor(
  "\r\r \nrGb(\r\r \r\t\t \n\n+433.871723380394%,4317.102%\r,+.10%\n\r\n)",
  255,
 255,
 0,
 255.0);
AssertCssColor("\r\r \t#C9dbAE",201,219,174,255.0);

  this.AssertCssColor(
  "\r\r \r\r\r\nRGbA(-751973,\n600287\t\n\t\r ,2,\n\t\n\r\n\n \n-41.5\n)",
  0,
 255,
 2,
 0);

  this.AssertCssColor(
  "\r\r \rhsL(-.56\r\r\n \r\r\r,.4021933408%\t\n\r,\t\n\n\n\r \n\r-96.6748%\t\n\n\n\n\r\r \r\r)"
  ,

  0,
 0,
 0,
 255.0);
AssertCssColor("\r\r #a0F3",170,0,255,51);

  this.AssertCssColor(
  "\r\rHSl(+399712996957.63,-183.19%\r,\n\r\n-.8%\n\r\n\n\r\r)\r",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "\r\rHsL(\r\r\r\r76305775522 \n, +9%\r \r,\n \n9684277%)",
  255,
 255,
 255,
 255.0);
AssertCssColor(
  "\r\rHsL(+24517129.51,\n\n\r\r\r\r4.737%\r\t,-.5%)",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "\r\rHsl(\r.7\t,+.8%\r\r\n\r ,\n\r \n\n\n \n37%)",
  95,
 93,
 93,
 255.0);

  this.AssertCssColor(
  "\r\rHsl(\t\r\t\n \t\n+8494108.06,\r\r\n\n\n\n\n\r.563%,.2178%\n\t)\r\n",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "\r\rRGBA(\t\t+919%\r \n\t ,-4.917%\n\n,\t\r-.9%,\n+51162)\r",
  255,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "\r \t\n\nhsl(\r\r\n\n \n\n \r+2.710\n\r\t\r,\n\n\r\r-87.2684352%,\r\r044595684.6334%\n\r\r \n\r\r \r)"
  ,

  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\r \t\r \t \r\nRGBA(008 \r\r,\t\n\n\r\t\n\n\n\t-597,530057428,.01713)",
  8,
 0,
 255,
 4.08);

  this.AssertCssColor(
  "\r \tRgb(\r\n\t\t\r4768630\n \t\t\n, \n\n85606 \r,667\t\r \n\n\n\r)",
  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\r \n\n Hsl(\t\n +35,\t\r +.3871%\r\n\n,-93.49015543%) \n \r\n",
  0,
 0,
 0,
 255.0);
AssertCssColor("\r \n\r\n\rRgb(93%,.847077%,-57.9%)",237,2,0,255.0);

  this.AssertCssColor(
  "\r \n \r\nrGbA(\r\n\n\r\n\r\t+.5%,\r\t\n\n \r\t\t\n\r.9% \n,+.659%,6108\n\r\n\r\r\n\n\t\n\n\r)\t"
  ,

  1,
 2,
 2,
 255.0);

  this.AssertCssColor(
  "\r \r\n\n\n\t\tRgB(2100,-00,\t\t\n\r\r727\t\r)\n\r\r\n\t\r\n\n\n \r",
  255,
 0,
 255,
 255.0);
AssertCssColor("\r \r\nrGB(\n97% \n\r,+80.1% \t ,\r\n+.1%)",247,204,0,255.0);

  this.AssertCssColor(
  "\r \r \r\r\n\r\n\trGBA(\n\n\r\r\r\r 623, \n\t+739,\r\t\r\t\n\t\r\t\n1,\n\t\r.34605)\t\n "
  ,

  255,
 255,
 1,
 87.975);

  this.AssertCssColor(
  "\r \rrGb(\t\n-.384940594%,\r\n\t\r\n95212.5%,-.119820927% \t)",
  0,
 255,
 0,
 255.0);
AssertCssColor(
  "\r \n \r\nRGb(\r\n \n \r\r\r46162,-0, \n5\r\t)\r",
  255,
 0,
 5,
 255.0);
AssertCssColor(
  "\r \nhsL(.8,\n\r \r\n\r\n\n\n-.88%,-.629%)\r\r\n\t\r\r\n\n",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "\r \rHSl(-.577941,51%\n\r\n ,.5768%)\t\n\n\r\r\r\n \t",
  2,
 0,
 0,
 255.0);
AssertCssColor("\r rGb(4,\r+65578\r\n,\t\t\n\t\n+3\n\n\r\n\r)",4,255,3,255.0);
AssertCssColor(
  "\r rgBa(\n535145,0258045,946\n\r,+668\n\n\t\t\t \n)",
  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "\r HSl(\t+8.47910\n\n\r \r\r,\r\n \n\r\t8326%\n\n\r\t\r\n\n \r ,\r\r\r -8.253%\n\n\t)\t\n "
  ,

  0,
 0,
 0,
 255.0);
AssertCssColor(
  "\r HSl(\n\r \r\n.929,\r\r\r \r\r\t+3532790%\t,+.7910%)",
  4,
 0,
 0,
 255.0);
AssertCssColor("\r RgB(\r\n\n\n \r25,\r35\t\t\r\n, -36000556)",25,35,0,255.0);

  this.AssertCssColor(
 "\r rGbA(+5301%\r\t\t\r\n\t , \n\r\n\r\t\r-290307618%,15605%,+48525417\n\n\n)",

  255,
 0,
 255,
 255.0);

  this.AssertCssColor(
  "\r rGba(\n\n\n0,+6999,\r\n\t \t\t+5, \n\n\n\n\n\t\r\n+16327\r\r\r \n\r\n\n\r)",

  0,
 255,
 5,
 255.0);

  this.AssertCssColor(
  "\r rGba(.991%,\n\t\r\r \r\r\n+.07%,\n\r\n\n\r\n\t\n\n-.0%, +.32622)\n\t\n ",
  3,
 0,
 0,
 82.875);

  this.AssertCssColor(
  "\r rgBa(\n\n38, \r428\r\n\r\n\n\n\n\n\r\t,\n+7\n \t\r\t ,47369.8\n)",
  38,
 255,
 7,
 255.0);
AssertCssColor("\r#4dC\r",68,221,204,255.0);
AssertCssColor("\r#c3aAbEbe",195,170,190,189.975);
AssertCssColor("\r#cEEaDbfC\r",206,234,219,252.45);

  this.AssertCssColor(
  "\rHSl(\t\r -166173035.4931273364 \t\r ,-6.5%\r\r\r,\t\r\t-.3%)",
  0,
 0,
 0,
 255.0);
AssertCssColor("\rHsl(\n+3.209,\n\n+.056%,-.7%\n)\t\n\t \t\r",0,0,0,255.0);
AssertCssColor(
  "\rHsl(7\r\t,\n\t \t\r.647%,\n\r\t\r+3588.3710628%)",
  254,
 255,
 255,
 255.0);
AssertCssColor(
  "\rRGB(\r\n \r\r\n\r\n\t1\n\n\n\n,-03,-41\r\r\r\n)\n \r\t",
  1,
 0,
 0,
 255.0);
AssertCssColor(
  "\rRGB(\r\r\r207%,\n\n5230%\n\n\n\r\r\t\t\n\r,.97%\r\r \r)",
  255,
 255,
 2,
 255.0);

  this.AssertCssColor(
  "\rRGb(\n\n\r\n\r\r +11.987128909795%,\t\n\n\t\n\n.625122%,\r1012%\r)",
  31,
 2,
 255,
 255.0);
AssertCssColor("\rRGb(\n+7284\n\t\r\n,503648,-34\n)",255,255,0,255.0);
AssertCssColor("\rRGb(\r46334,+947923\t\n\t \r,-1985)",255,255,0,255.0);
AssertCssColor("\rRGb(-.91089%,45.3161933%,.0768620630%)",0,116,0,255.0);
AssertCssColor(
  "\rRGb(-6541.6791005114%\r\n\r\n, .6%,\r \n -89339374125.4%)",
  0,
 2,
 0,
 255.0);

  this.AssertCssColor(
  "\rRGb(0,\r\n\r\r\n\r-33286\r\n\n,\r+09\n\n)\n\r\n\t\n\n\t\t\r\r\n",
  0,
 0,
 9,
 255.0);

  this.AssertCssColor(
  "\rRGba(-9092\n\n \t\t\r\r\n,\n\n\t\r09,\n \n \r\r606,.4889\n \n\n\r\r)\r\t\n\r\n"
  ,

  0,
 9,
 255,
 124.95);
AssertCssColor(
  "\rRgB(\n\n\t \r\t \r\n7.826304%,+6601007575.7%,547.48%)\n",
  20,
 255,
 255,
 255.0);
AssertCssColor("\rRgB(+3445,\r+868\n\n ,+8 \n\n\t)",255,255,8,255.0);

  this.AssertCssColor(
  "\rRgb(\t\r\n2062.9%, \r\r\n +61.461935907969%\n\n\n ,.5%) \t \n",
  255,
 157,
 1,
 255.0);
AssertCssColor("\rRgb(\r \r330043,\n+59, 9)\t\t \r\n\r\r\r",255,59,9,255.0);
AssertCssColor(
  "\rRgb(\r08.9131%\n\t\n\n \r\n\n,\r\n\r\r\n.4%,.3%)",
  23,
 1,
 1,
 255.0);
AssertCssColor(
  "\rRgba(654\t\r\n,+5902330,89\r, \n\t\n-70087.721)",
  255,
 255,
 89,
 0);
AssertCssColor("\rhSl(\n-056965.82053,75%,.5%\t\n\t\r\t\n\r)\r\r",1,0,2,255.0);
AssertCssColor("\rhSl(.235\t\r\r\r ,+.12%\n\n\n\r\t,.2546%)",0,0,0,255.0);
AssertCssColor("\rhsL(+.3,+0%\n,-.085%)",0,0,0,255.0);

  this.AssertCssColor(
  "\rhsl(+.650\n\n,\t\r4412732%,-709.751%\r\t\t\t \r\t\r)\t\n\r\r\n\r\t\r\n\n\t\t"
  ,

  0,
 0,
 0,
 255.0);
AssertCssColor("\rhsl(-972, \n\t\n38%\n,+0.99%\t\n\n\r\r)",1,3,1,255.0);
AssertCssColor("\rhsl(.866435\r,\t\n\r\n24712%,+44%)\r\t",224,3,0,255.0);

  this.AssertCssColor(
  "\rrGBa(.48%\t\t\n\n\t\r, \n\r\n\n \n\r+55240% ,.514%\r\n\r\n\n\t,-51904.5\r)\t"
  ,

  1,
 255,
 1,
 0);

  this.AssertCssColor(
  "\rrGb(\n 8\r,\r\n\t\r\r\n+424 \r,-119405)\n\t\n\n\r\n\r\n\r\n\r",
  8,
 255,
 0,
 255.0);
AssertCssColor("\rrGb(048 \r ,+0\r, \n\n+974)",48,0,255,255.0);

  this.AssertCssColor(
  "\rrGbA(+180429\n\r\n\r,\r\t \n\r\r+3248,\r\n72943\n \n\r \n\t ,6307548446)",
  255,
 255,
 255,
 255.0);
AssertCssColor("\rrgB(+96,-8\n,-833675034\r)",96,0,0,255.0);
AssertCssColor(
  "\rrgBA(\t 131 \r \n\r\n,\n\r +01984 \t\r,+0594\n\n,+.37) ",
  131,
 255,
 255,
 94.35);
AssertCssColor(" \t\t\r\t\nrgB(-6491,17 \t\r\n\t\n \t\r,-4)",0,17,0,255.0);
AssertCssColor(
  " \t\t\rHSl(\n-.5, \n\n \r\t.0%,07.4804314%\r\r \r\n\t)\r\r",
  19,
 19,
 19,
 255.0);

  this.AssertCssColor(
  " \t\trGbA(.71179169531%\r\n,\n +28%,\r\r\t 36898555053%\r\r\r,87)\r\t\t\r",
  2,
 71,
 255,
 255.0);

  this.AssertCssColor(
  " \t\n\tRGBA(-734362\n\n\r, \n\t15135\n\n \t,+003,\n\n\n-6368464354\r\r\n\t\r)",

  0,
 255,
 3,
 0);

  this.AssertCssColor(
  " \t\n\n\r\trGbA(\t\n-7250\t,-93315364\r ,629\r\r\r\t\t,.135)",
  0,
 0,
 255,
 33.915);

  this.AssertCssColor(
  " \t\n \rRGbA(\n8746.4453%\n\r \n,-.482560%\r\t\r\r , \n5%\r\n,\r\n .3)\r",
  255,
 0,
 13,
 76.5);
AssertCssColor(" \t\n #B1dE1c\n \n\r \r \t\n",177,222,28,255.0);
AssertCssColor(" \t\n#Ea90cA\n\r\n",234,144,202,255.0);

  this.AssertCssColor(
  " \t\r\r\r \r\rrgbA(58847\n\t\n\r\r, \n\r+6,\r \r\r\r-8795512480\r\n,69\t)",
  255,
 6,
 0,
 255.0);

  this.AssertCssColor(
  " \t\r \r\rRGba(\t\r\r.28% \n\t,+87916%,.0433%\r\n,-4879\n\n\r\n\n\r\t\n)",
  1,
 255,
 0,
 0);
AssertCssColor(
  " \t rGB(+43696, \n\n\r\r-14\n\r\r,\n\r\n554322057\n \r)",
  255,
 0,
 255,
 255.0);
AssertCssColor(" \t#F9c7",255,153,204,119.08500000000001);
AssertCssColor(" \tHsL(\n\t\r\r.880, .09%\r ,\n.46052885%)",1,1,1,255.0);
AssertCssColor(
  " \n\t\r\t\r\n \rhsl(\r+.654,-.983%\t\r\r\n\n \r\r,-.71%)",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  " \n\n\t rGb(\r\n-.23%\r\r \r\n \n\n\n,+4%\n\r\n ,\r\n.335609%\t\r)\r\r\n\n\r\n\r"
  ,

  0,
 10,
 1,
 255.0);
AssertCssColor(
  " \n\n\n\n\rrGba(4\t,+6\n,7\t\r,9052104437.3\n \r)\n ",
  4,
 6,
 7,
 255.0);

  this.AssertCssColor(
  " \n\n \nRGbA(\n\n\t \n \t\t\t\n.2273%,\r+799%,\t\r+.89%\r,\t\r\r\r\t\r\t5.1\r\r \n)"
  ,

  1,
 255,
 2,
 255.0);
AssertCssColor(
  " \n\r\t\r\n\r\rRgb(\t+4,\t+2 \n\t\n\n\n\n\r,9320)",
  4,
 2,
 255,
 255.0);

  this.AssertCssColor(
  " \n\r\n\r\r\n \rhsl(-4422395.943149\r\r \r\n\r,\n\r\r\n.02%\n\n\r\r \n\t,\r\r \r\n\n+.91059388%) "
  ,

  2,
 2,
 2,
 255.0);

  this.AssertCssColor(
  " \n\r\r\trgb(\n\t\n\r \r\t81103982.9747475872%,\n\n\r519762305232.9%\n,\n\n\r+.2%)"
  ,

  255,
 255,
 1,
 255.0);

  this.AssertCssColor(
  " \n\r\r\n \thSL(\n\t\r \r\r\n\n\r574.2105,+993151.642% \r\n\r\r\t,49.71753561%\t\t\t\t\r\n\r\r\n) \n"
  ,

  0,
 108,
 253,
 255.0);
AssertCssColor(
  " \n\rRGBA(6555%\n\r\t,\t+00%,\n+.5%,\r\r\r.55006\t\n\t\n)",
  255,
 0,
 1,
 140.25);
AssertCssColor(" \n \n\n#Dfcad7FB\n",223,202,215,250.92);
AssertCssColor(" \n#EA70Eb6e\n",234,112,235,109.64999999999999);
AssertCssColor(" \nRGb(-460\t\n\r\n,\t+64945\n,\r-79447)",0,255,0,255.0);
AssertCssColor(" \nhSl(-.32\n\r ,-.7%\r\t\t\n\r\t ,-95.296%\n)",0,0,0,255.0);
AssertCssColor(
  " \nhsl(\n\t\n+2662.19,.4113%,\r-85744843.61411%\t\n)\n",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  " \nhsl(.6\t,\n\n-681018.1851%\r,\t\n\n+89.1930785%\t)\r\n\r\r\t\t\t",
  227,
 227,
 227,
 255.0);

  this.AssertCssColor(
  " \nrGBa(\r-.23396%\n,\r\n\n\t\n\t+02%\r\n ,.68%,\t \t-78120)",
  0,
 5,
 2,
 0);
AssertCssColor(
  " \nrGba(26209451071,53 \n,\r -4547\r\n,+542589649\n\t)\r\t",
  255,
 53,
 0,
 255.0);
AssertCssColor(
  " \r\t\t \n \n\t\n\n\nhSL(361,\r\n\t\n-.321%,.0%\r)",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  " \r\t \n\n\nhsL(45916,.34691297%\t\r\r\r,\r\n+.1%\t\t \r\n\r\r\t\n\t)",
  0,
 0,
 0,
 255.0);
AssertCssColor(" \r\n\r\n hsl(\r\n\n+6,\r\r\t.5%,.7%) \r \n\n",1,1,1,255.0);
AssertCssColor(" \r\n\r\n#DfecdC",223,236,220,255.0);
AssertCssColor(
  " \r\nrgBA(\n\r \t-03,+91\r,\n\n-1188\r,\r\n\r2\r)\r\t",
  0,
 91,
 0,
 255.0);
AssertCssColor(
  " \r\r\t \r\r\r\rRgb(\r 8720,\t \t\r\n-2\n\t\n\t\r,5\t)",
  255,
 0,
 5,
 255.0);

  this.AssertCssColor(
  " \r\r\n\n\r rGbA(+49186818,-98\n,\r\n0,-3163\r\r\r\r\t\r)\r\t ",
  255,
 0,
 0,
 0);
AssertCssColor(" \r\r\n\r\n\n #5cAEdFbE",92,174,223,189.975);
AssertCssColor(
  " \r\r\n\rRGb(-16.523%,\t.3%\r\r,+.781500032%)\r\n\r",
  0,
 1,
 2,
 255.0);
AssertCssColor(" \r\r\nHSL(.77677,.429%,-.600%\n\n\r\t\n\r) \r ",0,0,0,255.0);
AssertCssColor(
  " \r \n\r\rRgb(1464\n\n\n,9\n\n \n\t,51167\n\t\t\n) \n\n",
  255,
 9,
 255,
 255.0);
AssertCssColor(
  " \r rgB(\n+74106,+928144\r\t \n \t\t, \t\n \n-3646373348)",
  255,
 255,
 0,
 255.0);
AssertCssColor(" \r rGB(3756324\r\r\n,387,+8)",255,255,8,255.0);
AssertCssColor(
  " \r rgb(-41,39788,\r\n\n-7173606\r \t \n)\n\n \n \t\n\n",
  0,
 255,
 0,
 255.0);

  this.AssertCssColor(
  " \rHsL(\n\t\r\n -.33489921 \n\r\t\r \n\r,49%\r\t,\t\n\n\n\n\n.5%\n)",
  1,
 0,
 0,
 255.0);

  this.AssertCssColor(
  " \rRGB(\n\t\r678112196828%\t, \r\n\r \t\r-.0104%\r\t\r\r\n,-97744%\r)",
  255,
 0,
 0,
 255.0);

  this.AssertCssColor(
  " \rRGb(\t\t\n \t\t\r\t\r-.3%\r\n\r\n,-5204.613% \r \n,998.3%\r\r\n)",
  0,
 0,
 255,
 255.0);
AssertCssColor(" \rrGBA(-.9467554340%,+6%,+.84%,-.7000)\t \n",0,15,2,0);
AssertCssColor(" \rrGbA(-96\n,38, +6127,-893110.741)",0,38,255,0);

  this.AssertCssColor(
  " \rrgB(+24726891.948% , \n\r\t .26162%, \r\n \t \t.388% \n\r\n\r\n\t\r\r)\n\n",

  255,
 1,
 1,
 255.0);
AssertCssColor(" \n\n\rRgb(\r 66,+5949\n,+22)\n",66,255,22,255.0);

  this.AssertCssColor(
  " \n\r\n\n \n\rRGbA(2,\n\n\n04\r \r\r \r \n\n,-600017\n \r\t,.0307483)",
  2,
 4,
 0,
 7.6499999999999995);

  this.AssertCssColor(
  " \n\r\n\r\rrgBA(\r.9629%\n\r\n\r\r\r,\t +89%\t \r\t,+2%\n\n \n \n,69770.50\r\n)"
  ,

  2,
 227,
 5,
 255.0);

  this.AssertCssColor(
  " \n \n\rRGb(\n\t\r\n\n-991009,\t \n\r\r\n\t\r\r\r\r6,\r\n\t-6444)",
  0,
 6,
 0,
 255.0);

  this.AssertCssColor(
  " \r\nrGb(1027\r,71 \t\r\r \r\r,\t-672013\r\n\r\n\r\r\r\n) \n\n\r\t\r\t\r",
  255,
 71,
 0,
 255.0);

  this.AssertCssColor(
  " \r\r\t\nHSl(\r-.1,+4.23%\t\t\n\r\r,\n\r0774.94801%\n\n)\n\n",
  255,
 255,
 255,
 255.0);
AssertCssColor(
  " \r\r\n\nRgb(+.9% \n,9.07857%\n\n\n\n,\r+.333% \r\r \r)",
  2,
 23,
 1,
 255.0);
AssertCssColor(
  " \r\r\n \trgb(\r\t\n\r 5,+2\n,61\t\r\n\n\t\n \n\r)",
  5,
 2,
 61,
 255.0);

  this.AssertCssColor(
 " \r\r\nhsl(\r\r\r\t \n\r\r91028 ,\r.7182%\t,\r+9052616802%\r\t\t \n\n\n\t\r)",

  255,
 255,
 255,
 255.0);
AssertCssColor(
  " \r \n\r\nHsl(-857\n\r\t,.6%,\r\r+.69973%\n)\r\n\n",
  1,
 1,
 1,
 255.0);
AssertCssColor(" \r #3ab3\t",51,170,187,51);
AssertCssColor(" \t\t#fCaccD",252,172,205,255.0);

  this.AssertCssColor(
 " \n\r \rHsl(\n\r\r \r\n\r\t\r\r.954,-44747499276%\r \r\r\t \n,\r\n -.37472%)",

  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  " RgBa(\r\r\t\n\r-0686.1463514%\n\t,.1%\n\n\n,9%,\n\n.465982703) \r\n",
  0,
 0,
 23,
 119.08500000000001);
AssertCssColor(" hsl(\n \t\n7 ,-.39668%,.925% \n\t\t\r\n\n)",2,2,2,255.0);

  this.AssertCssColor(
  " rGBA(960,1682609\t,67 \n\r\n\r\r\t ,\r\r6.8400581858\t\r\t\n\r\r\r \r)",
  255,
 255,
 67,
 255.0);
AssertCssColor(" #BcCdd0",188,205,208,255.0);
AssertCssColor(" #EADa\t\r\n\t\n",238,170,221,170.085);
AssertCssColor(" #aDf",170,221,255,255.0);
AssertCssColor(
  " HSL(+.4270411971,\r-.5248418%\r ,\r\n\n\n\n\n\n.47% \n\t)",
  1,
 1,
 1,
 255.0);
AssertCssColor(
  " HsL(+.6\t\r\n ,\r\n \n\t\t94%, -2166052.172439960%\t)\n\r",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  " HsL(-7.25\r,\r\r\n360171%\t\r,+81299%)\t \t",
  255,
 255,
 255,
 255.0);
AssertCssColor(
  " RGb(+.2%\t ,\n.2049%,\t44.2155812%\n\r\n\t\n)\n\r\t\t\n\n",
  1,
 1,
 113,
 255.0);
AssertCssColor(" RGb(+.664% ,+.569123%,.001974%)",2,1,0,255.0);
AssertCssColor(
  " RGb(+8821\r,\r\t\r\t\n\n\n\r\r\n-2159825,+394\n)",
  255,
 0,
 255,
 255.0);

  this.AssertCssColor(
  " RGba(\n+.0595%\n\n,\t \r \r-.47646%,\n\r \t\n\r \r+97.3%\n\r,\r\n\t\r00962.008778)\r\r"
  ,

  0,
 0,
 248,
 255.0);
AssertCssColor(
  " RgB(\n-58871\n\r\t,+887976052434 \r\n,-3590659)\r\t\t\r",
  0,
 255,
 0,
 255.0);
AssertCssColor(" Rgb(6 \n\n,-6,\n-01\n\r\n \r\r\n\n)",6,0,0,255.0);

  this.AssertCssColor(
 " hSL(\n+2406\t\n\r\t\t\t\n \n\r,+659% \r\r\t\n\t\r,\n\n\n\t.745%\r\n\r)\r\r ",

  0,
 0,
 3,
 255.0);

  this.AssertCssColor(
  " hSL(\r\n\n\r \r\r\n42,\n\t\r\r\n\n\r\n+.5%,.3205%\r\r\n)\r\n\n ",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  " hSL(.8\r,+1830305.115085205%\t\n\n,\n\r \t\n -7%)",
  0,
 0,
 0,
 255.0);
AssertCssColor(" hsL(39.0, \n4%\r\r \n,-77675%\n\n\r\t)",0,0,0,255.0);

  this.AssertCssColor(
  " rGB(\t\r \n1317176.8218345737%,\r\r\n \t\r\r\r-5110%,\t\r\n\n \r-394487690940.53%\n\r\n\n)"
  ,

  255,
 0,
 0,
 255.0);
AssertCssColor(" rGB(5%\n\t, +.9164%,\n\n\r-643271%)",13,2,0,255.0);

  this.AssertCssColor(
  " rGBA(-749941215\r\r \t\r\t\r \t\t\t\t,\r\n -86 \n ,\r-85845\r \n\r ,\n\n\r.440)\r\r\r\n"
  ,

  0,
 0,
 0,
 112.2);
AssertCssColor(
  " rGbA(9695527\r,+27236015,\r\n12258,.62\t)\r\r\t \r\r",
  255,
 255,
 255,
 158.1);
AssertCssColor(" rgB(\t\t.21%,\n\r\r\r-34.863650%\n\r,-.29%)",1,0,0,255.0);
AssertCssColor(
  " rgB(\n\n\n\t\r+3257476983%\n\n\r\t\r ,\n.6%\n,1852.8%)\r",
  255,
 2,
 255,
 255.0);
AssertCssColor(" rgB(9536609\n\r \t\r\r\t,+5\n\n,57)",255,5,57,255.0);
AssertCssColor(" rgb(-0\r\r,669 \t\n\r\r\n,+0\t)",0,255,0,255.0);

  this.AssertCssColor(
  " rgbA(\n\r\r\r\r\r-7043084, \r\r-3013 ,\n\r\n\n75497419\r\n\n\r\r,\r+.3\r \n\n\t) \n"
  ,

  0,
 0,
 255,
 76.5);
AssertCssColor("#0Bc7b64A",11,199,182,73.94999999999999);
AssertCssColor("#1aAfFB",26,175,251,255.0);
AssertCssColor("#1dCA\r\n",17,221,204,170.085);
AssertCssColor("#27EDcD\n\t\r",39,237,205,255.0);
AssertCssColor("#2ae\r\t\r\n\n",34,170,238,255.0);
AssertCssColor("#3FcBfcca",63,203,252,201.96);
AssertCssColor("#3bEf",51,187,238,255.0);
AssertCssColor("#4ABcAB\n\n",74,188,171,255.0);
AssertCssColor("#4CA \r\r",68,204,170,255.0);
AssertCssColor("#4Ee0ACc9",78,224,172,201.45000000000002);
AssertCssColor("#4bA \r",68,187,170,255.0);
AssertCssColor("#6eAbCb5a\r\r\n\r \t\t\r\r",110,171,203,90.015);
AssertCssColor("#8aaF",136,170,170,255.0);
AssertCssColor("#8f4ccB\r",143,76,203,255.0);
AssertCssColor("#9c6Fa6",156,111,166,255.0);
AssertCssColor("#9cea",153,204,238,170.085);
AssertCssColor("#ABDCBFdB",171,220,191,219.29999999999998);
AssertCssColor("#AFa0dDdF\n ",175,160,221,223.125);
AssertCssColor("#AdC ",170,221,204,255.0);
AssertCssColor("#B84CEc",184,76,236,255.0);
AssertCssColor("#BB7E8B\r ",187,126,139,255.0);
AssertCssColor("#BCcE",187,204,204,237.91500000000002);
AssertCssColor("#BEB",187,238,187,255.0);
AssertCssColor("#BEdaD8 \t\n \r",190,218,216,255.0);
AssertCssColor("#BEfDda",190,253,218,255.0);
AssertCssColor("#BFEadCb1",191,234,220,176.97);
AssertCssColor("#Bc8",187,204,136,255.0);
AssertCssColor("#BdBFeBf2\r\n\r\t\n\n",189,191,235,242.25);
AssertCssColor("#BdaE",187,221,170,237.91500000000002);
AssertCssColor("#BfBAFfdB\n",191,186,255,219.29999999999998);
AssertCssColor("#C0dcdA\n\r",192,220,218,255.0);
AssertCssColor("#CAAB6F\t\r\t",202,171,111,255.0);
AssertCssColor("#CAaf",204,170,170,255.0);
AssertCssColor("#CCF5de\r\n \r",204,245,222,255.0);
AssertCssColor("#CEBccBdD",206,188,203,221.085);
AssertCssColor("#CFA\r \t\n \n",204,255,170,255.0);
AssertCssColor("#CFB9\n\r\n",204,255,187,153);
AssertCssColor("#Cb3Ebe\t",203,62,190,255.0);
AssertCssColor("#CdA",204,221,170,255.0);
AssertCssColor("#CeB",204,238,187,255.0);
AssertCssColor("#DE2FbB\r \n \r\r\t\r\r\t\n\t",222,47,187,255.0);
AssertCssColor("#EB8afbeb",235,138,251,234.60000000000002);
AssertCssColor("#EBdFff\r\n\r \n",235,223,255,255.0);
AssertCssColor("#ECC ",238,204,204,255.0);
AssertCssColor("#ECf1b18e",236,241,177,142.03500000000003);
AssertCssColor("#EDBcaBFA ",237,188,171,249.9);
AssertCssColor("#EF9b\r\r ",238,255,153,186.915);
AssertCssColor("#EFE\r \t\n\n\t\r",238,255,238,255.0);
AssertCssColor("#Ebe\r\n\n\r\r\t\r",238,187,238,255.0);
AssertCssColor("#Efc48f",239,196,143,255.0);
AssertCssColor("#Eff",238,255,255,255.0);
AssertCssColor("#FBcde2EB",251,205,226,234.60000000000002);
AssertCssColor("#FDdCbE",253,220,190,255.0);
AssertCssColor("#FFd3bDA1\n",255,211,189,160.65);
AssertCssColor("#FbCCFf",251,204,255,255.0);
AssertCssColor("#Fdc",255,221,204,255.0);
AssertCssColor("#aD3CBA",173,60,186,255.0);
AssertCssColor("#aDce6edb",173,206,110,219.29999999999998);
AssertCssColor("#acD",170,204,221,255.0);
AssertCssColor("#adf",170,221,255,255.0);
AssertCssColor("#afedfac3",175,237,250,195.07500000000002);
AssertCssColor("#b5bDfbaB ",181,189,251,170.85000000000002);
AssertCssColor("#bAb",187,170,187,255.0);
AssertCssColor("#bAf",187,170,255,255.0);
AssertCssColor("#bB0f",187,187,0,255.0);
AssertCssColor("#bCBD",187,204,187,221.085);
AssertCssColor("#bDe",187,221,238,255.0);
AssertCssColor("#bEb",187,238,187,255.0);
AssertCssColor("#bddfCD",189,223,205,255.0);
AssertCssColor("#cCd",204,204,221,255.0);
AssertCssColor("#cc6BAE",204,107,174,255.0);
AssertCssColor("#cdeC",204,221,238,204);
AssertCssColor("#cfec \n",204,255,238,204);
AssertCssColor("#d9BbBFFb\r\n\r",217,187,191,250.92);
AssertCssColor("#dCD5ec",220,213,236,255.0);
AssertCssColor("#dFAeCede\r\t\r\t\t\t\t \n",223,174,206,221.85);
AssertCssColor("#dab\r ",221,170,187,255.0);
AssertCssColor("#dbEe",221,187,238,237.91500000000002);
AssertCssColor("#ddCBC9Eb\t\r\t\r\t\n\t",221,203,201,234.60000000000002);
AssertCssColor("#e9ecFF",233,236,255,255.0);
AssertCssColor("#eAA3",238,170,170,51);
AssertCssColor("#eaBA\t\n\t",238,170,187,170.085);
AssertCssColor("#fEEAEE",254,234,238,255.0);
AssertCssColor("#fEfd",255,238,255,221.085);
AssertCssColor("#fFF5Dd2F\r",255,245,221,46.92);
AssertCssColor("#fa8C\r\r\r",255,170,136,204);
AssertCssColor("#faAFF3eF \n",250,175,243,238.935);
AssertCssColor(
  "HSL(\t\r.54105662098 \t\r\n ,1%\r\r\n,.733591%)\n\n",
  1,
 1,
 1,
 255.0);
AssertCssColor(
  "HSL(\t \n \n-.8880,-72.09678%\r\r,\t\t\n.9%\r \r)",
  2,
 2,
 2,
 255.0);
AssertCssColor(
  "HSL(\n\n\t-25.6570\r\t ,168.0309%\t\n\r \r ,-26.83%\t\n)",
  0,
 0,
 0,
 255.0);
AssertCssColor("HSL(\n.3\n\t,\n\t4.7857800460%,.8%\t\r \r)",2,1,1,255.0);

  this.AssertCssColor(
  "HSL(\r\n\n\n-.96,\r\t\r-42762860.378904%\t\t \r\r \r\t\n\r,.9%)",
  2,
 2,
 2,
 255.0);
AssertCssColor("HSL(\r\r \n\n+.805\n\r\n \r ,-.4183%\r,7%\n)",17,17,17,255.0);
AssertCssColor(
  "HSL(\r+.892893086\n\t\t\n,\r.3105%\n,\n\n-8513068284.24%\n)",
  0,
 0,
 0,
 255.0);
AssertCssColor("HSL(\t971,\r \n\r6.683%, \n\r\r \t\r\n\t3%)",7,7,8,255.0);

  this.AssertCssColor(
  "HSL(\n\r \t-34.64 \n\t,+.991%,\r \r\n\n\r.2625%\n\n\t\r\n\n \t)",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "HSL(+.62\n \r,\n\r\r.5%\r\r \t\r\t\n\t,\r\r\r\n \r\t\n\r+.65141% \r\t\r\r)",
  1,
 1,
 1,
 255.0);
AssertCssColor("HSL(+212,-6837%,-2.91%)",0,0,0,255.0);
AssertCssColor("HSL(.1749469\r\n,\r\r-.680%,9726%)",255,255,255,255.0);
AssertCssColor("HSL(.44,\r \t\n+5%,-28.61%)",0,0,0,255.0);
AssertCssColor("HSL(.5601 ,-44470.4%,-16.14297%)",0,0,0,255.0);
AssertCssColor("HSL(.8,099633.946%\n\t\r,\r+.8088%)\n\r\t",4,0,0,255.0);
AssertCssColor(
  "HSL(6,-8190135%,34293927%\r\n)\n\n\n\n\n\t\r \r\n",
  255,
 255,
 255,
 255.0);
AssertCssColor(
  "HSl(\t\t\r\t\n\t-.9\t\r ,.37%\t\n\r\n\t\n,\r+72%)",
  183,
 183,
 183,
 255.0);

  this.AssertCssColor(
  "HSl(\t\n\r\r\t\t-.4433724,-5.26980%\n ,\n \n\r\n.0932395%\t)",
  0,
 0,
 0,
 255.0);
AssertCssColor("HSl(\t\n\r-01897.3,094187%,+.3%)",0,0,1,255.0);
AssertCssColor(
  "HSl(\t 679.3160015,\n\n\r +7.7302%,\n\r\r \t+8611.27%\t)\r",
  255,
 255,
 255,
 255.0);
AssertCssColor(
  "HSl(\n\r\t \n\r24.6,.795%,\r \r\t.04297851%\r\r\n\r\r)",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "HSl(\n.334,\r\t\n\t\n3%,\n\n\r54419841.579274%\n\t\n\t)",
  255,
 255,
 255,
 255.0);
AssertCssColor(
  "HSl(\n.95\n\r\r\n\r\r\r\r\n\r,74%\t\t,\r.41%\r\t\r)\r\n\n",
  1,
 0,
 0,
 255.0);
AssertCssColor(
  "HSl(\r\t\t\r \n.17,-9960218%,1.7200%\t\n\r\t\n\r\t\n\r)",
  4,
 4,
 4,
 255.0);

  this.AssertCssColor(
  "HSl(\r\n\t\r\r\n\r\n\n\n.806504761,-68695%\n\r ,+.2220%\r\n)\t",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "HSl(\r\r\t\t619,\r\r\r.57%,-.5675%\t\t \r \r\r\t)\n\n",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "HSl(\r \t\n\n\t\t\r \r \r-.1997859,.3675%\n\n\n\t \t,\r\r\t\t531.58935%\t\r\n\n\r\r\n\n)\n"
  ,

  255,
 255,
 255,
 255.0);
AssertCssColor("HSl(\r9957.3101,-.12741347108%\n,.6%\r\r)",1,1,1,255.0);
AssertCssColor("HSl(\t\t \r\r\n68.94,+927%\n\t\r\r,+.29281%) ",1,1,0,255.0);
AssertCssColor("HSl(\t \t \r\r.9,8.98356195988%,.1%\t\n\r)",0,0,0,255.0);

  this.AssertCssColor(
  "HSl(-.1633815,+9045954%\n\r\r,\r9947%\n\t\r\n\t\n\n)\r\n\r\r \n",
  255,
 255,
 255,
 255.0);
AssertCssColor(
  "HSl(+649.0,-903435015%\n,\r\n\n\r\r\n\n7872.9777%)\r\r\t\n",
  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "HSl(11\t\t\n\n\n\n\t,+91695.1% \n\r \t\n,\n \r\r702656.794%)",
  255,
 255,
 255,
 255.0);
AssertCssColor("HSl(1411.158,+.8566%\r\t\r,9375.67769740%)",255,255,255,255.0);
AssertCssColor("HSl(317\n\n ,\r9.26574%,\n\t\n+17%\r\r\r\n)\r",47,39,45,255.0);
AssertCssColor("HSl(55160662.2590,582.361%,+97%)\t \n \n",255,245,239,255.0);

  this.AssertCssColor(
  "HsL(\t\n\t\r\t\r\r\r\t806145111090\n\t\r,-379.07920% \n\n\n, \r\r.60423%)\t\n",

  1,
 1,
 1,
 255.0);

  this.AssertCssColor(
  "HsL(\t\n\t\r \n.677 \r\n\r \n ,\n\n786.4% \r\r\r\n\r,+60209.210024373%)\r",
  255,
 255,
 255,
 255.0);
AssertCssColor("HsL(\t\r\r\n\r\r.6\n\n\r\n,-.272853%,\t\n\n\n.3%)",0,0,0,255.0);

  this.AssertCssColor(
  "HsL(\n\t\t\r 601801829840,\n\r\r\n \r\t\t+.800849%\r,-2.3823%\n\r)",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "HsL(\n\n\n\r\n\n\t579.67425,-32%,752.2430%) ",
  255,
 255,
 255,
 255.0);
AssertCssColor(
  "HsL(\n\n+04.25132835\r\t,\r\n\r.31%,-.17%)\n \n\r\t\n\t\r",
  0,
 0,
 0,
 255.0);
AssertCssColor("HsL(\n\r+.0508444,\r \r \t3%, 34%)\t",89,84,84,255.0);

  this.AssertCssColor(
  "HsL(\r\t\n\n\t\t\r\n\r\n\n-.7966,\t\r\r\n\n .29% \t\n \n\n\n ,+80%\r\r\r\t)",
  204,
 203,
 203,
 255.0);

  this.AssertCssColor(
  "HsL(\r\t2355\r\t\r\r\r\r\r,-.15030%\t\r\r\r\n\t,.6%\n)\n\n \r\n",
  1,
 1,
 1,
 255.0);

  this.AssertCssColor(
  "HsL(\r\n\t\t\r8.974\r,\r\r \r\n\r722.49% \r\t,\n\n6403460.740435500% \t\n\r\n\r\t\r)\r \r\r\r\r\n"
  ,

  255,
 255,
 255,
 255.0);
AssertCssColor("HsL(\r\n862,+.0%,7%)",17,17,17,255.0);
AssertCssColor("HsL(\r\r\r\n +95536.16952 , -05018%, -.572%)\t",0,0,0,255.0);
AssertCssColor("HsL(\r.52\t,+.4%,\n\t\n\r\r\r-5%)\n",0,0,0,255.0);
AssertCssColor(
  "HsL(-.1\n\r\r\r \n\n\n\r, \r+87247528.386% ,-.3%)",
  0,
 0,
 0,
 255.0);
AssertCssColor("HsL(+.4539386,+0.860%,+.61%\t\n\n\r\r\n)",1,1,1,255.0);
AssertCssColor("HsL(+.8\r\n \r,.5%,-.63369% \r\n \n)\r\n",0,0,0,255.0);
AssertCssColor("HsL(+.815,\r\n\n\r\n\t\n\t+.1819%,9%\r)\n",22,22,22,255.0);
AssertCssColor("HsL(+799.5 ,\r\n\r\n5308599850%, \n.4153371043%) ",1,2,0,255.0);
AssertCssColor("HsL(-.2327353\r\n,+432.1%,\n .85417%)",4,0,0,255.0);
AssertCssColor("HsL(.4512218,07964%\r,\t.218% \n\n \n\t\n\n\r)",1,0,0,255.0);
AssertCssColor(
  "HsL(.865\n,\n \n\r.9%\r\r\r\n\n\n\n,\n+.7%)\n\n \r\r",
  1,
 1,
 1,
 255.0);
AssertCssColor("HsL(0.3937078,.8%,\r\r-.58%\r) \t",0,0,0,255.0);

  this.AssertCssColor(
  "HsL(3839410.6 \r\r\r\n,\t\r\n \t .98539%\n\n,2447.9890758%)",
  255,
 255,
 255,
 255.0);
AssertCssColor(
  "HsL(4293.3923726761,\r\r\r\t+.9789363281%,\n\n\r\n\t502.5%)",
  255,
 255,
 255,
 255.0);
AssertCssColor("Hsl(\t \t-9590.9677754,613258239%,6%)\t",0,30,4,255.0);

  this.AssertCssColor(
  "Hsl(\n\n-2.2715817450\n\n\r,\t\r\n\n\r.7469%\r,.73%\r\n\n\t)",
  1,
 1,
 1,
 255.0);
AssertCssColor("Hsl(\n\r\n\n +2\r\t \n,3618.14%\r ,6%\n\n)\t",30,1,0,255.0);

  this.AssertCssColor(
  "Hsl(\n\r\r\r\r\t.569\r\r\r\t\r\n\t ,-28.05%,9062703% \r\t\t\n)",
  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "Hsl(\r\r\n\r49663.913865\t\n \t\r\r,30%\r\r ,\n+.097377739%\r \r\t \n\n)\n\n\n\r"
  ,

  0,
 0,
 0,
 255.0);
AssertCssColor(
  "Hsl(\t\r\n\t\r756.8062839,.857%,\t\n\n\n\n14%\n\n\t)\n\n\r",
  36,
 35,
 35,
 255.0);
AssertCssColor("Hsl(\n6\n\n,-.16065%,\r\n\r\n\n\r-1733%)",0,0,0,255.0);
AssertCssColor("Hsl(-.11,\n\r2299892.3043%,\t\t-0481%)",0,0,0,255.0);
AssertCssColor("Hsl(+.1,76485.6% \t\r\r\n\r \r\n\r\n,.0465384%)",0,0,0,255.0);
AssertCssColor("Hsl(+.2,83352.7%\n\n\n,.0%)",0,0,0,255.0);
AssertCssColor("Hsl(+.6424795939,-97524.1493%,.08018%\r)",0,0,0,255.0);
AssertCssColor("Hsl(+.771612\t \r\n \r\t\n,+0.5463368%,-.1%\n\n)",0,0,0,255.0);
AssertCssColor(
  "Hsl(+1810534,+.6842542%\t\r\r\n\n\n\r\r\t ,\r+0%) \r",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "Hsl(+24\r\r\n,\t\r\r\r+7.4726%\r \n\r,64%\t)",
  170,
 161,
 156,
 255.0);

  this.AssertCssColor(
  "Hsl(-.76 \r\r \t,\r\r\r\r\r\r\n\n\r+8.8%\t\r\n \r\t,-.64821647%)",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "Hsl(-3620.122097\r\n,\r \n \n\n\r\n30%,+0407%\r)",
  254,
 255,
 255,
 255.0);
AssertCssColor("Hsl(-57031,\n6%,+.154462%\r\t\n\r\n\r\n)",0,0,0,255.0);
AssertCssColor("Hsl(-996.707,\t\t24.93%\r\n\r,+05%)\n",13,15,9,255.0);
AssertCssColor(
  "Hsl(.73,\r\r\n \n\t\t3054460.47686213355%,-94%\r)\r\n ",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "Hsl(.96210,64%\r \n\n\t\n\r\r,3888%\n\t\n\r\n)\n",
  255,
 255,
 255,
 255.0);
AssertCssColor("Hsl(89003,\r\r\r-21871660%,+79429040%)",255,255,255,255.0);

  this.AssertCssColor(
  "RGB(\n\n\n\r\r\r\n\n\n\n.68070%\r\t,\r\n\n+.78%\n,3.81%\r\t\r\n\n)\n",
  2,
 2,
 10,
 255.0);

  this.AssertCssColor(
  "RGB(\n\r\n\r\r\r \t\t-69098830,\t\r\n\r\t+5\r \n\n\r ,\r\n\t\n-64\n\t \n)\r\t\t\r"
  ,

  0,
 5,
 0,
 255.0);
AssertCssColor("RGB(\n\r.64022%,\t-.258%\n\t\n\n\t,-51%)",2,0,0,255.0);
AssertCssColor("RGB(\n \r \r.32573%,.07%,\t \n-.65621%\n\t\n)",1,0,0,255.0);

  this.AssertCssColor(
  "RGB(\n+8, \n \t\r900766255,\r \n \t\r\r\n \r\r-7395192\r\n\n\r)\t\t\n",
  8,
 255,
 0,
 255.0);
AssertCssColor("RGB(\n-43284670\r\n ,\n+1201,7)",0,255,7,255.0);
AssertCssColor("RGB(\r-3,96511043\r\r\n\n\t\r\n\n,81713067)",0,255,255,255.0);
AssertCssColor("RGB(\r.4%\r\r,.6% \n\t,.3479%)",1,2,1,255.0);

  this.AssertCssColor(
  "RGB(\r709% \n \r\t\n\r\n\r,\n\r\r\t.26317378%\t\n\n\n\t\n\n\n\n,-.97239236939%)\t "
  ,

  255,
 1,
 0,
 255.0);
AssertCssColor("RGB(\r \n \n-928311804505, -3,+95\t\t\n)\n",0,0,95,255.0);
AssertCssColor(
  "RGB(+.731142216%\n\n\r\r,+65542% \r,.0%)\n\r\r\r\n\t",
  2,
 255,
 0,
 255.0);
AssertCssColor("RGB(+1,\t\n\t\t\r\n\n\n-737,\n12\n \r)\r\n",1,0,12,255.0);

  this.AssertCssColor(
  "RGB(.4524188%,.53%, \t \n\r\t\t\r\r\n\n-429% \t\n)\r\r\t\r\r ",
  1,
 1,
 0,
 255.0);
AssertCssColor("RGB(.52%,\n6%\t \n\r\r,\n6%\r)\n",1,15,15,255.0);
AssertCssColor(
  "RGB(.674%\r\t,\n\n\n\n\r \r\n\r\r+33%,\n+.75097%\n\t\t)",
  2,
 84,
 2,
 255.0);
AssertCssColor("RGB(942\n,-30,\t\r\t\n\r\n\n\t\n\r-83)\r",255,0,0,255.0);

  this.AssertCssColor(
 "RGBA(\n\t\n\r\r-.496%\r,.9659%,+.3554%\t ,\n\r-.066567\n \t)\n \t\t\n\n \r\r",

  0,
 2,
 1,
 0);

  this.AssertCssColor(
  "RGBA(+.3905%\n,.577607597%,812%\t\n \n\r\t\r\t ,.351\t \t\r\t\r\n\n\t\n)",
  1,
 1,
 255,
 90.015);

  this.AssertCssColor(
  "RGBA(-.09% \t\t\n\t\t,5079.89%,\n \n\n \r \n\r\n.10%\n\t,\n.9714659)\n\r\r\r\n\r\n\r\n\r"
  ,

  0,
 255,
 0,
 248.11499999999998);
AssertCssColor(
  "RGBA(39418\n\t\r \n\t\n,+4,\r\n\t591\t \n,.990372045)",
  255,
 4,
 255,
 252.96);
AssertCssColor("RGBA(7.90%\r,950%, 396.56%,\n\r-20.9862698)",20,255,255,0);

  this.AssertCssColor(
  "RGBa(\n\n\t\n\t\r\r\r \n-2\n\n\n\r\n, \n\n5446613\r\t,7122\r\t\t\t,.5)\n",
  0,
 255,
 255,
 127.5);

  this.AssertCssColor(
  "RGBa(\n\r\n\n\n\n\n +635\t\n,\r-535085013\t\t\t,\t91\n\n\r\n,\r\n\n\n 2922.4292006 \r)"
  ,

  255,
 0,
 91,
 255.0);

  this.AssertCssColor(
  "RGBa(\n\r \t\t7 \r\r\r\t\r\t,50160763\t\n\r,\r\r\r\n\r\r\n\r\t1\n\n\n\n,+.302525)"
  ,

  7,
 255,
 1,
 76.5);

  this.AssertCssColor(
  "RGBa(\n\r.3052386815%\n\r\r\r,\t\t+.7692%, \n\n \r+.3%,.58621\r\t)",
  1,
 2,
 1,
 148.92);

  this.AssertCssColor(
  "RGBa(+.495%\n\r ,\t\n.7%\n\n,\t\n211%,-.1243\n)\n \n \n\n\n\r\r \t\r",
  1,
 2,
 255,
 0);

  this.AssertCssColor(
  "RGBa(+428%\r \t\n\r ,-.5712%\r\r\n\t\r ,\r407611.237368%\n \r,\t-.01884\t)\r ",

  255,
 0,
 255,
 0);

  this.AssertCssColor(
  "RGBa(-.994%,-83982.2947%,+49% \r\r\n\t \r \r,\n\r-159.003\r)",
  0,
 0,
 125,
 0);
AssertCssColor(
  "RGBa(275,+89\r\r,98710 \n,\r\r-.6)\n\r \n\r\r\r\r",
  255,
 89,
 255,
 0);
AssertCssColor("RGBa(8\r,6\r,\n-415,+402)",8,6,0,255.0);

  this.AssertCssColor(
  "RGb(\t\n\n.3%,+.4167%\r,\n \t\r\t\n\n\t-4000%\r\t\n)\r\r\n\n \n\r\r\n\n\r",
  1,
 1,
 0,
 255.0);
AssertCssColor("RGb(\t-.07%,-4%\n \n\n,\t+024%)",0,0,61,255.0);

  this.AssertCssColor(
  "RGb(\n\t-85\r\r\r\r\r\n,\n\n\r\n\t+54509\r\r \n\n\n \n\r, \n\r \n\r\n\n-6 \n\n)\r\n\t\n\t\n\n\r\r\t"
  ,

  0,
 255,
 0,
 255.0);
AssertCssColor(
  "RGb(\r\r\n\n\n\t\t632,\n\t08 \r,\r+85005\r\r\n)",
  255,
 8,
 255,
 255.0);
AssertCssColor("RGb(\r+068%,\r\r\n5.3%,\t\n .53931%\t \r)",173,14,1,255.0);
AssertCssColor("RGb(\r\r8%,\t-.627535%, .4%)",20,0,1,255.0);
AssertCssColor(
  "RGb(+8934514, \r \n\n+88931543 ,-6 \n)\n\r\t\r",
  255,
 255,
 0,
 255.0);
AssertCssColor("RGb(-4%\n ,.7878%, \n\r \n+9%)",0,2,23,255.0);
AssertCssColor("RGb(-64\n\n\n\t \r, 4,+10)",0,4,10,255.0);
AssertCssColor("RGb(13859002%,+.072%,\r\n+.2683636%\t)\n",255,0,1,255.0);
AssertCssColor("RGb(155 \t,-90,\r\n\n245)\t",155,0,245,255.0);
AssertCssColor("RGb(929,\r\r\n2\t\n\n,7)",255,2,7,255.0);

  this.AssertCssColor(
  "RGbA(\n\t\t\n\r+0033222.5104015517%,+3.576806% \r\t,.2695%,\n\t\t\n\r \r.53360321\r\r\t\t)\n \r\r \t"
  ,

  255,
 9,
 1,
 135.91500000000002);
AssertCssColor(
  "RGbA(260608848264,7,-263\r\r,\n\t\t\n\r+.4)\r\r\t\r\n \r\n",
  255,
 7,
 0,
 102);
AssertCssColor(
  "RGbA(48%,\t\n\t\t1.133098%,-.4%\n \r\n,\n084617)\n",
  122,
 3,
 0,
 255.0);

  this.AssertCssColor(
  "RGbA(5%\r\r\r,\r\n\n\r\r+.4610%\n\t\n\r,\t \n \n02.20%\r\t\t\n\r,\r\r\t \n\r5595.93)\n\n \n\t"
  ,

  13,
 1,
 6,
 255.0);
AssertCssColor("RGbA(72\n\n\t ,+03,-07,+.95\n\n \n \n\n)\n",72,3,0,242.25);
AssertCssColor(
  "RGba(\n-.1894315% \r\t\r \n,6.1%,\n9%,-750\n \n\t\t\t)\r",
  0,
 16,
 23,
 0);

  this.AssertCssColor(
  "RGba(\r\n\t \n \r\r 4782 \n \n\n\r\r\r,\r\n4,\n\r\t22036,\n\r\r \r \n .302421\r)"
  ,

  255,
 4,
 255,
 76.5);

  this.AssertCssColor(
  "RGba(\n\n\t-3\r\r,\n\n974\r\r\n \n\n\r\r,\r-48092,\t\r \n\n\n\n \r.99)\n\n",
  0,
 255,
 0,
 252.45);

  this.AssertCssColor(
  "RGba(+21092\r\n,+31594,3 \r\n ,.95420226882\t\r\n\r\r\t\t\n)",
  255,
 255,
 3,
 243.015);
AssertCssColor(
  "RGba(+7917800\t\n\t\t\n\n,-01717,\n\r\n9, +.4\t) \n\n",
  255,
 0,
 9,
 102);

  this.AssertCssColor(
  "RGba(054\r\r,\r\r\n55,\r\n\r\r\n\n641697358, \n\n\n\t+9.3962532\r)\n\r",
  54,
 55,
 255,
 255.0);

  this.AssertCssColor(
  "RGba(20861386%\n\r\r,.4%,54457.776%\r,\r\n\t.67351\n\r\r\r\t\n\r)",
  255,
 1,
 255,
 172.125);
AssertCssColor(
  "RgB(\t\n\t\r231503538,\t\n\r\r +7971 \r\n\t\r ,93837\n)",
  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "RgB(\t\r\n.6990002715%,+.728042181457% \r\t\n\n\r,+.311375%)",
  2,
 2,
 1,
 255.0);
AssertCssColor(
  "RgB(\t\r\r43.6738%,2960673521.16%,.0%)\r\t\n\n",
  111,
 255,
 0,
 255.0);
AssertCssColor("RgB(\n\t\r\t-.4%,-7%, \t\n\t1771%)\r\n",0,0,255,255.0);
AssertCssColor("RgB(\n\n.978% \r,0%\t,.0% \n\r\n)",2,0,0,255.0);
AssertCssColor("RgB(\n\r\n.08%\n\n\r\n\t,.346%\n ,4%)",0,1,10,255.0);
AssertCssColor(
  "RgB(\n \r \n95693.89907706179%,\r+2756704228%,+13705%)",
  255,
 255,
 255,
 255.0);
AssertCssColor("RgB(\n.938%,095594711%\r ,\r3622608.63309%)",2,255,255,255.0);
AssertCssColor(
  "RgB(\n43584.595843950%,+7% \r\n\t\n\n\r\t\n\n\r,-.4%)",
  255,
 18,
 0,
 255.0);
AssertCssColor("RgB(\r \t\n75%,-97874%,-.0025158%)",191,0,0,255.0);
AssertCssColor(
  "RgB(\n\n+78084%\t\t\n\t\n \r\r,\n1.3%,\n3249.96%)",
  255,
 3,
 255,
 255.0);
AssertCssColor("RgB(+8,\r\n\r 93813,-21)",8,255,0,255.0);
AssertCssColor("RgB(+2.99%,\r\t811%,\r\t\r\n-5541.4% \r)",8,255,0,255.0);
AssertCssColor("RgB(+9\n\n\n\n\n\r\t ,\t\r57583,-61968441916)",9,255,0,255.0);
AssertCssColor("RgB(-3998352878,\n+172\r,03\t\r\t)\r",0,172,3,255.0);

  this.AssertCssColor(
  "RgB(-50\r\n\r, 975420541\n\r\r \n\n\r,\r64554405\n \t)\n\n\n",
  0,
 255,
 255,
 255.0);
AssertCssColor("RgB(-64,\t903,+0351)",0,255,255,255.0);

  this.AssertCssColor(
  "RgB(-95125633435\r\t\r\n , \t \r\r60426236,1\n \t\r\r)\n\n\r\n\t\t ",
  0,
 255,
 1,
 255.0);
AssertCssColor("RgB(.2136101%,572667.9%\n,\t\n\n\n\n.06710%\t)",1,255,0,255.0);

  this.AssertCssColor(
  "RgBA(\t-042311983\n\n\t \n\t\r,\r11351,2\t ,\r\n\n\n\n+.80 \n\r \r\n\t\n\n) \r\r\r\n"
  ,

  0,
 255,
 2,
 204);

  this.AssertCssColor(
  "RgBA(\n\r\n82491,8, \n6887468\t,.083 \n\t \n)\r\r\r\t\r\r\r\t \r\r ",
  255,
 8,
 255,
 20.91);

  this.AssertCssColor(
  "RgBA(\n 7 \n,\t\t\n\n-7,\t\n\n-4\r\n\n,\r \n\r1616.491\n\n \n\r\n\n)\t\r\r\n\r\n\r"
  ,

  7,
 0,
 0,
 255.0);
AssertCssColor("RgBA(\n-2624,-7 ,-7,3256437\r\t\n)",0,0,0,255.0);
AssertCssColor("RgBA(\r\n\r\n\r\t10\r\r,\n-70,-50177,\r \r.894)",10,0,0,227.97);
AssertCssColor(
  "RgBA(\r\r\n\n\n.53%,\n\t\r+4.7% ,.09%,.407460958)",
  1,
 12,
 0,
 104.03999999999999);
AssertCssColor(
  "RgBA(\r6%\r,\n +008.10%,-.6%\r\t,\r\n\r\n38\n\n\n) \r",
  15,
 21,
 0,
 255.0);
AssertCssColor("RgBA(\r \r\r\r\t2,\r\r\n\r+5\t,1,1408\t\n\r)\n",2,5,1,255.0);

  this.AssertCssColor(
  "RgBA(+18920.263%, +30%\r\n,\r\r+.14585%\n\r\n\n\t\n,\t\n-.396)",
  255,
 77,
 0,
 0);
AssertCssColor(
  "RgBA(+8%\r ,-093726.8%,\r\r\t\t\r\t\r06.99%\r,.11\r)\n\t",
  20,
 0,
 18,
 28.05);

  this.AssertCssColor(
  "RgBA(-3\t\r ,\r +425087\n\t \r\n\t\n\t\t ,31120, \n +0.6587\r\r\n\n \n\t)",
  0,
 255,
 255,
 168.3);

  this.AssertCssColor(
 "RgBA(.6%,\r8048336.681272483%,\n\r\r+.13855%\r\t\r\n\r ,\n\r\n\n\r .5)\r\r\r",

  2,
 255,
 0,
 127.5);

  this.AssertCssColor(
  "RgBA(.778848%\t,\n\r\r\r\t\n\r\n\r.9232%\n\r,\n\n\n\t-355% \t,.949300546\r)\n "
  ,

  2,
 2,
 0,
 242.25);
AssertCssColor("RgBA(3\t,5\n\r ,1837,\n\r\r44)",3,5,255,255.0);
AssertCssColor("RgBA(405,757825,\n 035\n\r,-.13)\n\n \r\r",255,255,35,0);

  this.AssertCssColor(
  "RgBA(637\r\r\t\r\n\n,-3649826,\t\n+84,\r.22157174 \r\n)\t\r\n\n \t",
  255,
 0,
 84,
 57.120000000000005);
AssertCssColor(
  "RgBA(66\n\r,11\r,79143625\n,\t-8\t\r\n)\r\n\r\n\t ",
  66,
 11,
 255,
 0);
AssertCssColor("RgBa(\t\r\r\r\r03562112,+6,-676,\r-.2)\r \n\n\n\r",255,6,0,0);

  this.AssertCssColor(
  "RgBa(\r\n\t\n\n033245824\t\r\t\r\n, +099,4\t\n\r,62611.59\t\n\t)",
  255,
 99,
 4,
 255.0);
AssertCssColor(
  "RgBa(\r +34,\n3,\n9493409,\n+.699)",
  34,
 3,
 255,
 177.98999999999998);

  this.AssertCssColor(
  "RgBa(\t\r\n011359, 97,\t-2895393\r\n\r \t\r\r\n\n,\r.4129)\n \n\n \n\n\n",
  255,
 97,
 0,
 104.55);

  this.AssertCssColor(
  "RgBa(\n\t\n\r\n\r-67778024151\r\r,\t+831436050\r\r \n,\r5,\t\r\r\r\n\r.005277018073)\n"
  ,

  0,
 255,
 5,
 1.02);

  this.AssertCssColor(
  "RgBa(\n\r +566.6%\n \n\r\r\r,\t\r\n.982422%\r,-.9%, \n\r\n\n\n\r\t .33063)\r\r\r\t\n \t"
  ,

  255,
 3,
 0,
 84.15);
AssertCssColor("RgBa(-.4%,\n+19%\n,\r+61999663.4%,\t94689.8)",0,48,255,255.0);

  this.AssertCssColor(
  "Rgb(\n\n\t \n\r\n\n+99.118159%\r\t\t,-.17539332274%,\n \t\n\n+.78093574%\n \r\n\t \r)"
  ,

  253,
 0,
 2,
 255.0);
AssertCssColor("Rgb(\r\t-4\n, \r\t+7\t \r \n \t,+8119 \t\r)",0,7,255,255.0);

  this.AssertCssColor(
  "Rgb(\r\n \r\n \r\n +869478790,\n\t +923,\t\n \n\r\r+216\r\r)",
  255,
 255,
 216,
 255.0);
AssertCssColor(
  "Rgb(\r\r\n\n1936394 ,5058157041\r\r\n\n,\n\n\t\r+155)\t",
  255,
 255,
 155,
 255.0);

  this.AssertCssColor(
  "Rgb(+1330900.4782599372%\n\t\n\n\n\n\t\r ,.274182%,+796069%\r\r\n\r\n \t)",
  255,
 1,
 255,
 255.0);
AssertCssColor("Rgb(+764\t\n,-10,806)",255,0,255,255.0);
AssertCssColor(
  "Rgb(-.56%,+.82% ,\t-1422877.618%\n\n\r\n\r\r\r\t\n)",
  0,
 2,
 0,
 255.0);
AssertCssColor("Rgb(-4,+217739\n\n,8)",0,255,8,255.0);
AssertCssColor("Rgb(-49114,7941,+231898949)\r",0,255,255,255.0);
AssertCssColor("Rgb(-5, \r+59,-4477)",0,59,0,255.0);
AssertCssColor("Rgb(.1892%, .766%,\t\n\n 579.3%\n)",0,2,255,255.0);
AssertCssColor("Rgb(252\n,\n36\r,538\n)",252,36,255,255.0);
AssertCssColor("Rgb(3\r\n\r\r\r\t\n\r\r,8795\r\n\n\r\n ,+4)",3,255,4,255.0);
AssertCssColor("Rgb(3%\n\n,\t\n .32054%,\t\r\r.10322%)\r\r \t\r\t",8,1,0,255.0);

  this.AssertCssColor(
  "Rgb(8\n\t\n\n\n\r\t,\n\t\r\t\r\t\n 696749027,-3886 \r\n\n\r)",
  8,
 255,
 0,
 255.0);
AssertCssColor("Rgb(922.20%,-338% ,19.1%)",255,0,49,255.0);

  this.AssertCssColor(
  "RgbA(\t\n\t23053514,\t+7824\n\r\r\r\r,\n\n\n \r \r\n\r-82,-.4292\n\r \n)",
  255,
 255,
 0,
 0);

  this.AssertCssColor(
  "RgbA(\n338435 ,-387537,\t\n\n534\t,\n\r+.077585985\r\r\r\r\r)\n\r \t\r\r",
  255,
 0,
 255,
 20.400000000000002);

  this.AssertCssColor(
 "RgbA(\r\n\t\n\t\n\r39182.555%,\r \n\r\n.91%,-.63738238% \n,\r\t\n \r-.40) \n",

  255,
 2,
 0,
 0);

  this.AssertCssColor(
  "RgbA(\r\n\n\n\n\t\r\n\r\n+.511%, \n\r .3%\r\n\n\r,\r058%\r\r\t,.7)\r \r",
  1,
 1,
 148,
 178.5);

  this.AssertCssColor(
  "RgbA(\r\r-3370562643\t\r\r,\r\t+71\n\t\n \r ,42\n,-1.1\n\n\r\r\t)\r ",
  0,
 71,
 42,
 0);

  this.AssertCssColor(
  "RgbA(\r\t\r\r\n \r \n+6\n\r,\r\r\t \r\n\r\r\n+24738,\r57,\n-59.2)",
  6,
 255,
 57,
 0);
AssertCssColor(
  "RgbA(+.03%\n\r \n\r\n\n,\r\t\n\n\t .1%,.8% \r,-61.4\n)",
  0,
 0,
 2,
 0);

  this.AssertCssColor(
  "RgbA(-063,\r\t\r\r\r\n\t\n\r 23814933,838\r\n\t ,+44652961) \n\n",
  0,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "RgbA(-68855,\n\n\n \n+801741,+141\n\n\n \t\r ,-.03383\r\n) \n",
  0,
 255,
 141,
 0);
AssertCssColor(
  "RgbA(1640415%\n\n\n\t\n,588.4%\n,\t\r \r\n\n\t -68113%,-8)",
  255,
 255,
 0,
 0);
AssertCssColor("RgbA(36.5%,+7.3%,-.506% \t \n,\t\t+.6)",93,19,0,153);

  this.AssertCssColor(
  "Rgba(\t1.007541400%\t\n\t \r\t\r\r\r\r\n\t,.800%\r ,+.961%,5\r)\n",
  3,
 2,
 2,
 255.0);

  this.AssertCssColor(
  "Rgba(\r\r\n \r \n\r9.8%\n\n,\n\t\r-.860756%,4.452% \t\t\n ,.4618\r\n\r) \r",
  25,
 0,
 11,
 118.06500000000001);
AssertCssColor(
  "Rgba(+7391.527%,-.6%,+9123999010.00%\n\r\n,-9)\n\n \n\r\n",
  255,
 0,
 255,
 0);
AssertCssColor("Rgba(+9,\n\n\n\r44\t,\n4 \n,9\t\r\t)\n\n",9,44,4,255.0);
AssertCssColor("Rgba(-8964,\t\n\r \n+478,-2,\n.1)\t\n\r\n\r\n\r",0,255,0,25.5);
AssertCssColor("Rgba(-9.41%,-9%\r\r \t\r,.2545743%\n \t\n\r,4.6)",0,0,1,255.0);

  this.AssertCssColor(
  "Rgba(0,\n498182674, \n\n\t\n\t374\t\n \r\n\r,.622\r\t\n\r\n\r)",
  0,
 255,
 255,
 159.12);
AssertCssColor(
  "Rgba(24496,\n\t\t\r +205,327\t\t\n\r\r\r,-6934211\r)",
  255,
 205,
 255,
 0);
AssertCssColor(
  "Rgba(3\n\n \r\n,+7 \n,\r\r \r\r\t\t\r-0,\r.1 \n)\n",
  3,
 7,
 0,
 25.5);
AssertCssColor(
  "hSL(\t \n\n\t\r+8504\r\r\n,-.77%\n, \n \n\n-.31266%)",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
 "hSL(\n \n\t +673680.0238\r\t \r\n\n\t\n,\r\t\n\n.38%\r\n\t\n\r\n,\t\t\r.14%)",

  0,
 0,
 0,
 255.0);
AssertCssColor("hSL(\r\n\n\t\t+.161,\n.044%\r\r,\t.6143%)",1,1,1,255.0);
AssertCssColor("hSL(\r\r\n591,\n.3%,\t\t\r\r-23187%\t\r)\r",0,0,0,255.0);

  this.AssertCssColor(
  "hSL(\r 059.3957128\r , \t+.05%,7333842%\n\r\n \t \n\t\t\t\r)",
  254,
 254,
 255,
 255.0);

  this.AssertCssColor(
  "hSL(\n\r \r\n+.04219,\r\n\r\t\n\r\r\n\t\r-23546.34400%,\t\n\r\r\n\r-7%)",
  0,
 0,
 0,
 255.0);
AssertCssColor("hSL(+.01\n,+.3%,.2%)",0,0,0,255.0);
AssertCssColor("hSL(-2746,.042%,3%)\n",7,7,7,255.0);
AssertCssColor("hSL(.71,+6.229%\t,\t\r +21%)\n",56,50,50,255.0);
AssertCssColor(
  "hSL(.8333431\r\n\n\n,\r\r\t\r \n-.12%\n, \r.8615% \r\t\r\n)",
  2,
 2,
 2,
 255.0);
AssertCssColor("hSL(16617 \t,\r\n.39%\r,+927%)\r\n\r\r\n",255,255,255,255.0);
AssertCssColor("hSL(8.012,\n\t1000286.0%\t,.712631548%)",3,0,0,255.0);
AssertCssColor("hSL(82.521 \r,-.1%\r, \n\n\r+64740306%)",255,255,255,255.0);
AssertCssColor("hSl(\t\n\r 31,.921418187%,.0681%)\n\r",0,0,0,255.0);
AssertCssColor("hSl(\t \t\r53,.1969%,-1.92%)",0,0,0,255.0);
AssertCssColor("hSl(\n\t.32595726,8.547785%\r\t\r\n,.48%\r\t\n\n)",1,1,1,255.0);
AssertCssColor("hSl(\n\n5.19, \n+03704.092662%,+.84%)",4,0,0,255.0);
AssertCssColor("hSl(\r\r\r\r\r\n \r+20126658,.794%,.6%\r)",1,1,1,255.0);

  this.AssertCssColor(
  "hSl(\r+96177.58,\t\r\r +558568.484%,\t\n \n +.281288% \n\n\n)",
  1,
 1,
 0,
 255.0);
AssertCssColor("hSl(\t\t \n\n-774.9,\t +.050506%\r,.0093020%)",0,0,0,255.0);
AssertCssColor("hSl(\n+75,\t\t1789%,\r\r.299854408%\r\r)\n\n",1,1,0,255.0);
AssertCssColor("hSl(+.64\r\r,374%\n\r \r\n\t,.77710751%) \t\r\r ",3,0,0,255.0);
AssertCssColor(
  "hSl(-.1\n\n\r\r ,\t\r\r.285714385% \n\n,34.3574%)",
  87,
 87,
 87,
 255.0);

  this.AssertCssColor(
  "hSl(-.641407 \n\r\r \r\r,-.4730% \n\r\n\r\r\t\t\n \r,060%)\t",
  153,
 153,
 153,
 255.0);
AssertCssColor(
  "hSl(-2,+1.0% \r\r\n\n,\t\r\t\n\n\r\r\r\t-.7434014%\n)\t",
  0,
 0,
 0,
 255.0);
AssertCssColor("hSl(-744922 \r,44217623.663%\t,-.772%) \n",0,0,0,255.0);
AssertCssColor("hSl(.416\t\n\n \r\r\n,-.2%\n,\t\n-8.2364230%\n)",0,0,0,255.0);
AssertCssColor("hSl(.43\n\r\n\n,92%\r\t \n\n , \n89.5%)",252,203,203,255.0);

  this.AssertCssColor(
  "hSl(.5792274\n\r\r\r\n\r\t\t,\r\r\n\n\n\t\n\t\r\r9% \t,\n\n \n \r \n 6%)",
  16,
 13,
 13,
 255.0);
AssertCssColor(
  "hSl(.734857578\r,\r-81068455% \t,69.7033%)\t",
  177,
 177,
 177,
 255.0);

  this.AssertCssColor(
  "hsL(\n\r\r\t\n \r +.14\r\t \n,\t\t\r\r-55868.66%,\t\n\t\n \n-.884%)\r",
  0,
 0,
 0,
 255.0);
AssertCssColor("hsL(\n 58.67,\n-08.6%,-5.9%)",0,0,0,255.0);
AssertCssColor(
  "hsL(\n+825606.79529657,+1%\n\n\t\n\n\r,-9.1%)\t\t\t \n\r",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "hsL(\r\r\t\t\n\n\r \n+3.784,+1112%\t,\t\r\t\n.3%\n\r\t\r \n\n\r)\r",
  1,
 0,
 0,
 255.0);
AssertCssColor(
  "hsL(\r.298\n\r\n\r\n\t\n, .0299108% \r\r,-.6431%)\t\n",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "hsL(+4615706.11\r\n\t\n\n\r \r,\r\t+879%,\n\r\r\n\n \r\r\r\r-2412.83867%)\r\t\n "
  ,

  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
  "hsL(-5887.6811444056\r\r\n\r\r\t,\n-.1341844%,-8610765%)\r\t\r\t",
  0,
 0,
 0,
 255.0);
AssertCssColor("hsL(-8,\t\r+98.026664%\t,.9069%)\t\n\n \n\n\n\r\n",4,0,0,255.0);
AssertCssColor("hsL(.1\r,\t+1841226.5357% ,+720664%\t)",255,255,255,255.0);
AssertCssColor(
  "hsL(.211327,\r \t\n -.2%,\n\r\t\n\r \r\t-9%)\n\n\n\t",
  0,
 0,
 0,
 255.0);
AssertCssColor("hsL(.3948,-.4927247747%\n\r \n\n\r\r,\t2.46%)",6,6,6,255.0);

  this.AssertCssColor(
  "hsL(0460.279\n ,\r -.4%,\t\t\r\r\r\r\r\r\r1562.03%\r\n\r\r \n)",
  255,
 255,
 255,
 255.0);
AssertCssColor(
  "hsL(2341.125\r,\t\t.3852%,\n 37.8%\t\r\r)\r \t ",
  96,
 96,
 96,
 255.0);
AssertCssColor("hsL(3,\n\r\r.93%\n\r\n \r\t,.2597190%)",0,0,0,255.0);
AssertCssColor(
  "hsl(\t-.8,\r\t.150%,\r\n\t\n\r\n\t\r0350%\t \t\n)",
  255,
 255,
 255,
 255.0);
AssertCssColor("hsl(\n\n +.325393971,+4%,.663%\n)",1,1,1,255.0);
AssertCssColor("hsl(\r\n\t\r\n\n\r\t\t\n+.788,.0%,-2%\r\n \t)",0,0,0,255.0);

  this.AssertCssColor(
  "hsl(\r\r\n\t\r \n\n.45157,.69%\n\r\r, \t\r\r66.9% \t)\n\t\r\n\t\t \n\r",
  171,
 170,
 170,
 255.0);

  this.AssertCssColor(
  "hsl(\r \t\n-31281337,-.4594883% ,\r\t\t \r \r-994.046642006725%\r\n) ",
  0,
 0,
 0,
 255.0);
AssertCssColor("hsl(\r \r.2,-.31%,\r-7.357370240%)\r",0,0,0,255.0);
AssertCssColor(
  "hsl(-1\r\n\r \r,+.482%\n,\r2926158.4502%\n\r\n)",
  255,
 255,
 255,
 255.0);
AssertCssColor(
  "hsl(+.4,\n\t\r\r\n-2.68%,\t67.96%)\n\r\r\r\r\n",
  173,
 173,
 173,
 255.0);
AssertCssColor("hsl(+8.7\n \r,+082%\n \r,\n\t\r+971522.1%)",254,255,255,255.0);
AssertCssColor(
  "hsl(-1502183,\r\n\n\r\r \t0324%\r,.3%\n\n\r\n\n\n\n \r\r)",
  0,
 1,
 0,
 255.0);

  this.AssertCssColor(
  "hsl(71274866\r\r\n, \r\n\n\n\n-.72%,+440531663.3531756%)\n\r\r\n\r\t\r\r",
  255,
 255,
 255,
 255.0);
AssertCssColor("rGB(\t\n\r\n-13084 \n,10276013\r \r,\n+96\r)",0,255,96,255.0);
AssertCssColor(
  "rGB(\t\r\r\n \n256 \t\n\r \r, 71\r\n,\r\r+60 \n\n\r \r)\t",
  255,
 71,
 60,
 255.0);

  this.AssertCssColor(
  "rGB(\n\t\r-7\r\n\n\n\r\r\n\n \t,\r\n+0\t\r,88076015281)\r\r\r\n",
  0,
 0,
 255,
 255.0);
AssertCssColor(
  "rGB(\n \r\n\t50626\n\n, -34045\t\r\r\n\t\r\n,\t12) \r",
  255,
 0,
 12,
 255.0);
AssertCssColor(
  "rGB(\r\t\n\r\r\n\r\r +1 \r\r ,357,\t34852300\r) \n",
  1,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "rGB(-2659681%\t\r,\n\r\r\t-.3%\n\n\r\n\t\t,.3514848%\r\t\n\n\n\r\n\n\n\n\t)",
  0,
 0,
 1,
 255.0);

  this.AssertCssColor(
  "rGB(+32767%, \n \r\n\r\r\n7%\n\r\r\n\n\r\r\t\r\n\n\n,982%\r)\n\r\r\n\n\n \r",
  255,
 18,
 255,
 255.0);
AssertCssColor("rGB(+5,03537121,+52)",5,255,52,255.0);
AssertCssColor("rGB(+66047240,1\r\t\n,\r\r\r+641291)",255,1,255,255.0);
AssertCssColor(
  "rGB(-2219824727.1110370%\t,+0711.2507691388%,.108712392%)",
  0,
 255,
 0,
 255.0);
AssertCssColor("rGB(.644%\n\n\t\t,424.86182%\n \r,.1%)\t",2,255,0,255.0);
AssertCssColor(
  "rGB(14\r\n,\r+686\r\n\t,\r\r\r\r\t\t\n\r\t-1542605157)",
  14,
 255,
 0,
 255.0);
AssertCssColor(
  "rGB(190.7%,60977.678%\t ,9271434.8%\r\n\n\n \t\n)",
  255,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "rGBA(\n\n+125868.911313%\t\n\n,\n7.3% ,\t\n\r-777340244.48% \r \t\n\t\n\r \r,-.93723\n\r\n\t \n\n)\n\t\r"
  ,

  255,
 19,
 0,
 0);

  this.AssertCssColor(
  "rGBA(\n\r\r\n\r-908%\r\r\t\n\r,\r \r\r\n.5%,.50%\t,\r.193926314027)\r\r\t\r\n",

  0,
 1,
 1,
 48.96);

  this.AssertCssColor(
  "rGBA(\r\t\n\n\r\n\r \r\r\n+498%\r\t\n,.4%,\r.5244%\n,\n.198066\r\r\n \r\t\r\r)\n\r\t\t"
  ,

  255,
 1,
 1,
 51);
AssertCssColor("rGBA(\r6044873\t\r\t,+5\n,\r3,.1138)",255,5,3,29.07);

  this.AssertCssColor(
  "rGBA(\t\n\r\r \r+3\r,855 \n\n\t\n\n,\r+7865,\n\r\n\r\t0.577\t)",
  3,
 255,
 255,
 146.88);

  this.AssertCssColor(
  "rGBA(\n\n 129\t,\r\r\n\n0622187026,-48624933,91026\r\n\r\r\n\t)",
  129,
 255,
 0,
 255.0);
AssertCssColor(
  "rGBA(+.80916%,\r \n-8.67268%\n \n,.60% ,.40777)",
  2,
 0,
 2,
 104.03999999999999);
AssertCssColor("rGBA(-.800%\n \n \r,\r\n+.021922%,\t.83778%,-45)",0,0,2,0);
AssertCssColor("rGBA(.48879455967%\n,+51%\t,+.38%\t,.3)",1,130,1,76.5);
AssertCssColor(
  "rGBA(180, \r4\n\n\n\r\r\r,+5040\n,\n.0983116870)\t\n\r",
  180,
 4,
 255,
 24.990000000000002);

  this.AssertCssColor(
  "rGBA(463897660,\n\t\n\t95\n\t\n\r\n\r,\n \t46570\r\t \n,\t\r\n528099323.0956\t)\r\n\r\r\r\t\n \r \r"
  ,

  255,
 95,
 255,
 255.0);
AssertCssColor("rGBa(\t \n\n\r5, \n7295,-2,\n\n\r \n\r-105.8\n)\n\r",5,255,0,0);

  this.AssertCssColor(
  "rGBa(\n+.0%,-.626%,\n\n\t\n\n\t\n\n-.7522%\r\n\n\n\t,\r807)\n",
  0,
 0,
 0,
 255.0);

  this.AssertCssColor(
 "rGBa(\r\r84699088.1605%\r\r,.7714079%\n,.173335031%\r \r,\t-21.890372)\n\n\n",

  255,
 2,
 0,
 0);

  this.AssertCssColor(
  "rGBa(-0282\r\n\r,+40,\r\r\r\r\n\n\t\n\r+01123, \r\r +187.47)",
  0,
 40,
 255,
 255.0);
AssertCssColor(
  "rGBa(+051001\t,-9217\n ,-41074769\r\n\r \n,-.3)\n \r ",
  255,
 0,
 0,
 0);

  this.AssertCssColor(
  "rGBa(-91.2332%,.25%\n\r\n\r ,\n\r\r \r.1%\n\r\n\r\r\r\r\t,\n\n\r08.6086\r \t\r)"
  ,

  0,
 1,
 0,
 255.0);

  this.AssertCssColor(
  "rGBa(.11%,\t \r178559%,\t\r\n\n+770988.93%\n\r\n\t\n\n\r,0.2908494\n \t\n\n\t\t\r)"
  ,

  0,
 255,
 255,
 73.94999999999999);
AssertCssColor(
  "rGBa(0\r\n\n,\n -6\r,31,+84134)\r\r\r\t\t\t\n\n\n",
  0,
 0,
 31,
 255.0);
AssertCssColor(
  "rGb(\t53%\n \n \n \r\n,\r\r +.0%\n\n,.099%\n\n\t)",
  135,
 0,
 0,
 255.0);
AssertCssColor(
  "rGb(\n \r\t+0773,+28\r, \r\n\r\r\r97309\t\n\r\n)",
  255,
 28,
 255,
 255.0);
AssertCssColor(
  "rGb(\n+6% ,\n\r \n16092098%,\n\n\n\n\n8143715%\n\r)\r\n\t",
  15,
 255,
 255,
 255.0);
AssertCssColor("rGb(\r \r7,\t\t\n2599\t \n, +79)\t\r \n\n",7,255,79,255.0);
AssertCssColor("rGb(16653%,1333%,9194.531%) \r\r \r\n \r",255,255,255,255.0);

  this.AssertCssColor(
  "rGb(+.00%\r,+34558.975594%\r ,\r\n\n\t\r\n\r354.55%)\t\r\t \t\n\n\t\n\n",
  0,
 255,
 255,
 255.0);
AssertCssColor("rGb(+.7%, .0%,+42950%)\r\r",2,0,255,255.0);
AssertCssColor("rGb(+3543 \r\r\n\n\t\r,28,-1) \n ",255,28,0,255.0);
AssertCssColor(
  "rGb(-3104,\r\n\r\t\r-126,+11\r \n\r\n)\n\t\r\n\n\n",
  0,
 0,
 11,
 255.0);
AssertCssColor(
  "rGb(.3963%\n \r\r\n\t\t\r\r ,.4%,\n\n\n\t\t.2582%\r\r\n)",
  1,
 1,
 1,
 255.0);
AssertCssColor(
  "rGb(69646\r\t\t\r,\n\t\t\r\n62,\r2893)\t\t\n \n\n",
  255,
 62,
 255,
 255.0);
AssertCssColor("rGb(9870.6066%,.271813%,\t\t.8081281%\n\r)",255,1,2,255.0);

  this.AssertCssColor(
  "rGbA(\n\r\t+.38636%,\r-0%,+402565%\n\n\n\r\n\n,8\r)\r\n\n\n\t ",
  1,
 0,
 255,
 255.0);

  this.AssertCssColor(
  "rGbA(\r\n.092%,+06987%\r\n\r\n,90.9%\n\n\n,87.029960362\r\r\r\r\n \n\r)\n\r\t\n\r"
  ,

  0,
 255,
 232,
 255.0);
AssertCssColor(
  "rGbA(\r.535%,78822799933.3%\r\r,-7.5%,.16908893)",
  1,
 255,
 0,
 43.35);
AssertCssColor("rGbA(+907,3 \t\n\r\n\r,6521442,+.7)\r",255,3,255,178.5);
AssertCssColor("rGbA(-10025% \r\t,+1.83420%,.475% \t\r\n\n\t,-.733)",0,5,1,0);
AssertCssColor(
  "rGbA(-4581457848\r\n\t\t\r\n\n\r,277288,233,.782)",
  0,
 255,
 233,
 198.9);
AssertCssColor("rGbA(157842\r,+1\r,065,\t\r\t\t37.23)",255,1,65,255.0);
AssertCssColor(
  "rGbA(3\r,-98,\r\n\n191925701\n\n,.9730\r\n)",
  3,
 0,
 255,
 248.11499999999998);

  this.AssertCssColor(
  "rGba(\t \t +47,\r\n\r\r-274\r\r\n\r\n,11, \r\t\n\n \r+003\n)",
  47,
 0,
 11,
 255.0);

  this.AssertCssColor(
  "rGba(\t+3.3%\n\r\n\r,+9.4058% \n\t\n,\t\t\r \r\r+0.5%,-.49222\n\t\t\n\r)",
  8,
 24,
 1,
 0);
AssertCssColor(
  "rGba(\n\r-5069499299,\r \n\n3\r,47,\t \t -.091\n\n\r)",
  0,
 3,
 47,
 0);

  this.AssertCssColor(
  "rGba(\n-3532321,\n\r\n\n\n\t\r\r58687,\r\n-93183\r\n\r\r,596772.1\n\r)",
  0,
 255,
 0,
 255.0);

  this.AssertCssColor(
  "rGba(\r\n\n\n\n\n-664710855,9\n\r\r\r,\r\r\n 2701894\r\n\r\n\t\r\t,\r\t\t \n\t-8948206.6316436)\r\n\n "
  ,

  0,
 9,
 255,
 0);

  this.AssertCssColor(
  "rGba(\r\r\n \r\n\n\r539214%\r,6628.65822%\n, +07.601318%\r\r\n \n\r,-0699472.39\r\t\n\r\n\n)\r\r\r"
  ,

  255,
 255,
 19,
 0);
AssertCssColor("rGba(+7.173%\n\t\t,-.6%,76628%,\t-.054)\n \r",18,0,255,0);

  this.AssertCssColor(
  "rGba(-.9%\r,\n\r\t\r\t\r.3%,\r-6.60%\r\t,+377.0001\n \r\t\t\t)",
  0,
 1,
 0,
 255.0);

  this.AssertCssColor(
  "rGba(-23\n,\n\n05\r\r,\t\r\n\t\r\r\n\n76353 \r\n\r\r\n\t,089633)",
  0,
 5,
 255,
 255.0);

  this.AssertCssColor(
  "rGba(-288,-555,\t \r\r \n\r\n\t29661\n\t\n\r\n\n\t\r,\n \t\r\n\t+5.50)",
  0,
 0,
 255,
 255.0);
AssertCssColor(
  "rGba(3.729%\r\n\n,6.790% \n\n\r\r\r,+.57098%\n,.436)\t\n ",
  10,
 17,
 1,
 110.925);

  this.AssertCssColor(
  "rgB(\t\n\r\r\t -4.265886881%,+.24%\r,\n\n\n \t\t+068959031227.2619%\r)",
  0,
 1,
 255,
 255.0);
AssertCssColor(
  "rgB(\t\n \r\r.04%\r\r\t\n\r,.5592573%\t\r,-78087944.49%)",
  0,
 1,
 0,
 255.0);

  this.AssertCssColor(
  "rgB(\t.03775%\r,.25%\r\r\n\t\n\n\n\t,\n\n .3%\t\t\t\t\r\n)\r\t",
  0,
 1,
 1,
 255.0);
AssertCssColor(
  "rgB(\n\r\t+56508%\r\r\n\n,\n.20%\r\t\n\t\r,+.7221%)",
  255,
 1,
 2,
 255.0);
AssertCssColor(
  "rgB(\n\r6\r\r\r\n\r,5836237\n\n ,\n\t\n7\r\r\r) \n",
  6,
 255,
 7,
 255.0);
AssertCssColor(
  "rgB(\n -7528,\t\n+64091781,30929) \r\n \t\r\n\t\r\r",
  0,
 255,
 255,
 255.0);

  this.AssertCssColor(
  "rgB(\r\t +6.93%,\r\t\r\t \r\n\r\r+.19013818%,\r\r.77%)\n\n\n",
  18,
 0,
 2,
 255.0);

  this.AssertCssColor(
  "rgB(\r\r\r\t\n.55826725063% \r\r\t\n\r\n,\n\r +.0672%\n\r,\r\r\n .28%\n\t)\n\r\r\n "
  ,

  1,
 0,
 1,
 255.0);
AssertCssColor("rgB(\r-32409,+3,8783\n \r\r)",0,3,255,255.0);
AssertCssColor("rgB(\r7338,58779\n ,-859)",255,255,0,255.0);

  this.AssertCssColor(
  "rgB(\n\r\r.2%,+372206281.0280% \r \t \n,\t\n +747073%\t\n\t)\n\n\n \t\n\r\t",
  1,
 255,
 255,
 255.0);
AssertCssColor(
  "rgB(+.0%,-.86699133108% ,+0%\r\r\n\r\n\n\r\r\n \n)",
  0,
 0,
 0,
 255.0);
AssertCssColor(
  "rgB(+.4%\n\t\r\r\r,\n \n\n-.0% \n\r\r\r\r\r\r\n\r\t,.34%)",
  1,
 0,
 1,
 255.0);
AssertCssColor("rgB(+.6%,\n-.3551%\r,\t 4%)\n\r\t",2,0,10,255.0);
AssertCssColor("rgB(+3\t\t\r\r \r,7890,18312128)\r \r\n\r\n",3,255,255,255.0);
AssertCssColor("rgB(+575,\t-970,\r43)",255,0,43,255.0);
AssertCssColor(
  "rgB(+60481230782%\n\r\r\n\n\n,-7.5%,-738880942%)",
  255,
 0,
 0,
 255.0);
AssertCssColor("rgB(-059457\t\r\t\r\r,-23,011\n)",0,0,11,255.0);
AssertCssColor("rgB(.36%\n,+08010.86%,-.9%)",1,255,0,255.0);
AssertCssColor("rgB(0\n\n\t \r \r,-8\r\n,21\n)\r\t \r\r\r\r\r",0,0,21,255.0);
AssertCssColor("rgB(3,764622998 ,-7)",3,255,0,255.0);

  this.AssertCssColor(
  "rgB(633%\t\n \r \n,-.6175%\n\t,\n\n\r\t\r\r\t\n\r\n.6%\n\n\r) \t\r\n",
  255,
 0,
 2,
 255.0);
AssertCssColor("rgBA(\n\r \r\t-.93%,\n\r \r \t8%,.1%,\r.5)",0,20,0,127.5);

  this.AssertCssColor(
  "rgBA(\r\r\n\n\r\r\r2,\n\r\n\n\t\r\n2\r\r\t,62\n\t\r\r,.62\n \r\r\r\r\n)\r\t\r\t\r \t\n\t"
  ,

  2,
 2,
 62,
 158.1);
AssertCssColor("rgBA(\t\r\r\r 44, -31,\n\r\r+72\n \n\r\r\n, \r-4)",44,0,72,0);

  this.AssertCssColor(
  "rgBA(\r+.283690994429%\r,\n\n\t\t\t\n.31496%,\n\r\r\n\n\r.51294%,\r\t\r\n+.202)\r\t\r\n\r"
  ,

  1,
 1,
 1,
 52.019999999999996);

  this.AssertCssColor(
  "rgBA(-91913.5656177372%\n\r \r\n,.13886%,\r \r+.5% \r, \n\r\t \t-.28543)",
  0,
 0,
 1,
 0);

  this.AssertCssColor(
  "rgBA(+180675,\r \n \r\t\r\t \t\r-5056505,\r\n\n 7394,51705\n\n)",
  255,
 0,
 255,
 255.0);
AssertCssColor(
  "rgBA(+41\r\n\r ,\n \t+9\n\n\n\n\r\n \r\r ,2\r,+.1)\n",
  41,
 9,
 2,
 25.5);
AssertCssColor("rgBA(-3,+0, \r2,+1.8846\n\n\r)",0,0,2,255.0);

  this.AssertCssColor(
  "rgBA(-813%,\n\r\n\t\t\n\n \t\t5525.11064%,\r.78765287%,\t+.743)",
  0,
 255,
 2,
 188.7);

  this.AssertCssColor(
  "rgBA(.10%\t\r\n\n \r,\n\t\r \n\r\r 70%\r\t\t \n,-.33%,.4\t\r\n)",
  0,
 179,
 0,
 102);
AssertCssColor(
  "rgBA(4\n\n\r,-31,-12969, +.9193076\r \n\n\n\t\t\t)\r",
  4,
 0,
 0,
 234.09);
AssertCssColor(
  "rgBA(7,\n\r-7481\n \r\r\n\r\n\r,+3\r ,.99)\r\r\n\t\n\n\t ",
  7,
 0,
 3,
 252.45);

  this.AssertCssColor(
  "rgBa(\t\n\n\r\n\n\r \t\n5%\r \r\t\n \n ,\r \n\r\t\n9%\t,.4%,\r\t \n\r\n\r\n874605\n)\n\r\n"
  ,

  13,
 23,
 1,
 255.0);

  this.AssertCssColor(
  "rgBa(\n\t\t.4934805%,489%\n\n\n\r,\n\n.4%,-264\r\t\n\r\t\r \r\t\r\n)\n",
  1,
 255,
 1,
 0);
AssertCssColor(
  "rgBa(\n\n\n469%,\r\t\n\t.1%\r ,\r\r863.3442%,+6\n)",
  255,
 0,
 255,
 255.0);

  this.AssertCssColor(
  "rgBa(\n\r\t-32.79307%\n\t, \r\n\n-.75%,-74098238082%,+.11963664426)\t\t\r",
  0,
 0,
 0,
 30.599999999999998);

  this.AssertCssColor(
  "rgBa(\n\r\n\r -86.53%,+.5%\r\t\n\n\n\n\r\n\r,\r \n \r\t-.63%\t\t\r\n\r \n\r ,\n\r007.14\r\n\r)"
  ,

  0,
 1,
 0,
 255.0);
AssertCssColor(
  "rgBa(\n\r\n 916,\r\r\n684 \r\t\t\r \r,88967,+94) ",
  255,
 255,
 255,
 255.0);
AssertCssColor(
  "rgBa(+0\r\n\t,5\n\n\r,\n\n\n\r\r 52,\n\r.76470)\r\n\n",
  0,
 5,
 52,
 195.07500000000002);

  this.AssertCssColor(
  "rgBa(+4.4%, .699%,-.058247%\n\r\n\r\n,\n\r \r+.6\t\r\r)\r\n\t\n",
  11,
 2,
 0,
 153);

  this.AssertCssColor(
  "rgBa(-34524414715\n\r\n\t \r\t\t\n\t\t,\n 5735\t\r\n\r\r\t,+48655\r \t\n,+0)\r"
  ,

  0,
 255,
 255,
 0);
AssertCssColor("rgBa(-7,-34333,8,\r+.7305)\n",0,0,8,186.15);
AssertCssColor(
  "rgBa(19719\r\r ,\r+30\n\n,\r\n+21, \t\n \n.1341173)",
  255,
 30,
 21,
 33.915);
AssertCssColor("rgb(\t\t\t\r\n627947.1%,\n\n\n-.069096%,.78%)",255,0,2,255.0);
AssertCssColor(
  "rgb(\t\t\n\r\r\t\r651920\n\n\n\n\t\n\r,69,+6\r)\t\t\t ",
  255,
 69,
 6,
 255.0);
AssertCssColor(
  "rgb(\t\r\r\t \r\n+8, \t\n\n30\t,\n\t\r\t764\n\r\r \n\n)\n",
  8,
 30,
 255,
 255.0);
AssertCssColor("rgb(\t\r-.4%,\n\r.546% \r\n \n\r \n\n,.177%\t)",0,1,0,255.0);
AssertCssColor("rgb(\t \r\r\r\r 353,+7,-580\n\n \n\r\r)",255,7,0,255.0);
AssertCssColor("rgb(\t -72\n\r\t\t\r\r,+7\t\n, 47)",0,7,47,255.0);
AssertCssColor("rgb(\t\n\r\t0807\t,+765,-9653\r\t)\n \n",255,255,0,255.0);
AssertCssColor("rgb(\r-.7%,-67%,\r\n \r \r\r+83%\n)\n\n\t\r",0,0,212,255.0);
AssertCssColor("rgb(+.2%,\r\r \r\n 7%,-7256343.795%\n)",1,18,0,255.0);
AssertCssColor("rgb(+.3%,\r\t\r\n\r\r .00%,\t\r62%)",1,0,158,255.0);
AssertCssColor("rgb(-768610783,1877,\r \n\r\n +881)",0,255,255,255.0);
AssertCssColor(
  "rgb(.84%,\r+.563576%,\r \n\n\n\n.24%\r\r\n\t\r\n)\r",
  2,
 1,
 1,
 255.0);

  this.AssertCssColor(
  "rgb(.99717%, \r\t\r\n\t\r\r+13.35752%\r\t\r\r\r\t\n \n\r\n\r,-68704113%) ",
  3,
 34,
 0,
 255.0);
AssertCssColor("rgb(2,+86624\t ,6) ",2,255,6,255.0);
AssertCssColor(
  "rgb(23.9%,-.9%\r,\r\t685129904535% \r\n\t\r\n\n)",
  61,
 0,
 255,
 255.0);
AssertCssColor(
  "rgb(75926,\r\t-26,\r\r\t \n \r\n\n\t\t 7394071146)\t",
  255,
 0,
 255,
 255.0);

  this.AssertCssColor(
  "rgbA(\r\r \n\n\n\n\r \r-3831406540.471%,.621702%,.605%, \n-.7280\n)\r\n",
  0,
 2,
 2,
 0);

  this.AssertCssColor(
  "rgbA(\r\r-689878,\t\n\n\r \r46499697\n\r\r\r\r\n ,\n\r+65\r\n\r\t\r,-.1)",
  0,
 255,
 65,
 0);

  this.AssertCssColor(
  "rgbA(\r36180927%\n\r \n\r\n\r,\n.932%,\t\n\r-.532173%,-.3)\t",
  255,
 2,
 0,
 0);
AssertCssColor(
  "rgbA(+010.0025%,+25%,\r.06%\r\n\r \r,-.8\t)\r \t\r\n\n",
  26,
 64,
 0,
 0);
AssertCssColor(
  "rgbA(+6\r \r ,\r \n-2,\t\n\n \n\n\r +803,85533719)\r ",
  6,
 0,
 255,
 255.0);
AssertCssColor("rgbA(+6\r,-6,+6\r ,.091\r\n\n\n)",6,0,6,22.95);
AssertCssColor("rgbA(-33\n\r\n\n\r,\n\t\n-6 \r\t\r\r\t\t,\t\r85,+.0)",0,0,85,0);
AssertCssColor(
  "rgbA(-505,2\r\n,\n\n\r\n28\n\r\r\r,+.891756)\r\n\n\t\r",
  0,
 2,
 28,
 226.95000000000002);
AssertCssColor(
  "rgbA(-915,\n262 ,\r+56,9876\n)\n\n\r\r\r\r \n\n\r\n",
  0,
 255,
 56,
 255.0);
AssertCssColor("rgbA(-97,\n\n \t+3,\t\r -94\r\n\r\r\t,34\n \r)",0,3,0,255.0);

  this.AssertCssColor(
  "rgbA(.89586%,\t\r\n\n\r\r .8738%,\r.97%\r\n,\r\r\r\n +831 \r\n)",
  2,
 2,
 2,
 255.0);
AssertCssColor(
  "rgbA(.971970013%\r,-4.217%,-.6%\n, \n\n\t.946660567082)\n",
  2,
 0,
 0,
 240.975);
AssertCssColor("rgbA(270456,1,\t\n\n30116,+9419488627)\t",255,1,255,255.0);
AssertCssColor(
  "rgbA(4004,\n\r +947,\r\t\r\r\r\t0,+.255577506\t\n)",
  255,
 255,
 0,
 65.025);

  this.AssertCssColor(
  "rgbA(5459708\r\r,\r\n\r0401975\r\n\n,+7630,-.7428753\n\n\r \n)\r\n\r\r\n\n\n\r\r "
  ,

  255,
 255,
 255,
 0);

  this.AssertCssColor(
  "rgbA(9\n \n\r\n\r\n\n \n\r\r,2,07,\r +.24 \r\n)\n\n\t\r\r\n\r\n ",
  9,
 2,
 7,
 61.199999999999996);

  this.AssertCssColor(
  "rgba(\n\n\t\n\n+975038.829%\n\r ,\r\n\r307.27%,\n2172532%,+.87\n\t)\n\n\n\r\t\n"
  ,

  255,
 255,
 255,
 221.85);
AssertCssColor("rgba(\n9,-9\t\t\n\r,055\r\n\r\n\r,+358)",9,0,55,255.0);
AssertCssColor(
  "rgba(\r+592017\t\r, \t-8913738,\n \n+694,\r\t\n\r -54\r \r)",
  255,
 0,
 255,
 0);
AssertCssColor(
  "rgba(\r4976743,\r\r95\t\n\t\r,\n\n\n\r\n38880,.77)",
  255,
 95,
 255,
 196.35);

  this.AssertCssColor(
  "rgba(+.0439936%\n\r,\n\n\t+.50121610%,-1.8%,7634.2112\r \r)",
  0,
 1,
 0,
 255.0);

  this.AssertCssColor(
  "rgba(+.4899%\r\t\n\r\t\n ,\n\n\t\r\r0422874054%\n\n,+13.5%,\n7119806.2\n)",
  1,
 255,
 34,
 255.0);

  this.AssertCssColor(
  "rgba(-55%,\t\t\t\t-710.240074%,.61274383560% \r\r\n\n,\n\r\n.746401607) \t\n ",

  0,
 0,
 2,
 189.975);

  this.AssertCssColor(
  "rgba(-6614488 \r\t\t\r,5 \r \n\r\t,+1\r\t\r\r \r\n\t\t\n ,\t\t\t\r\n\r\r11811\n)"
  ,

  0,
 5,
 1,
 255.0);
AssertCssColor("rgba(9602,+452,\n\t\t+25,\r\n\t14442\r \n\r)",255,255,25,255.0);
    }
    @Test
    public void TestRgbToColorDisplay() {
      try {
        ColorValidator.RgbToColorDisplay(null);
        Assert.fail("Should have failed");
      } catch (NullPointerException ex) {
new Object();
} catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
    }
    @Test
    public void TestRgbToColorHtml() {
      try {
        ColorValidator.RgbToColorHtml(null);
        Assert.fail("Should have failed");
      } catch (NullPointerException ex) {
new Object();
} catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
    }
  }
