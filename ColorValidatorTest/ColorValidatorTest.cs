using System;
using System.Collections.Generic;
using System.Text;
using PeterO;
using NUnit.Framework;

namespace Test {
  [TestFixture]
  public partial class ColorValidatorTest {
    [Test]
    public void TestColorHtmlToRgba() {
    }
    [Test]
    public void TestHlsToRgb() {
    }

    private void AssertCssColor(
  string str,
  double r,
  double g,
  double b,
  double a) {
      double[] rgba = ColorValidator.ColorToRgba(str);
      Assert.NotNull(rgba, str);
    string valueSMsg = str + "\n" + rgba[0] + ", " + rgba[1] + ", " +
      rgba[2] + ", " +
 rgba[3];
      Assert.AreEqual(r, rgba[0], 1.5, valueSMsg + ": red");
      Assert.AreEqual(g, rgba[1], 1.5, valueSMsg + ": green");
      Assert.AreEqual(b, rgba[2], 1.5, valueSMsg + ": blue");
      Assert.AreEqual(a, rgba[3], 1.5, valueSMsg + ": alpha");
    }

    [Test]
    public void TestColorNames() {
      this.AssertCssColor("Red", 255, 0, 0, 255);
    }

    [Test]
    public void TestColorToRgbaNegative() {
string item;
item = "Hsl(2A8.38\r\r\n,\f\n\f\n\r\t\n97E018108577(%,153224+\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t\nrGB(-4%\r\t,\nP\n\r .213773u+47419+1%\n\r\n \r,\n\f\r\f \n \f48)2.2.5e+80%\n\r)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rgb(+4646539,5\f2,+659469)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\rL\n\f \r\fh6Sl(\f\f \f3568.8e7ol47\n,.78e7%,-66286762A8%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgB(-.8e309480108972%\f\n\r,+.7802e-39199i16%,\r\n%\f\f.4%\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGba(.5L8e+37b87.415r#0%\n\t,\t\n-67%,4.893851I+01\r\n\r\n)\n\t\f\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "6\f\r\tRgBA(+468 \r\f\t\f\r\r\f,\t\n\t\n\r\te95\r\t \ta\t+35 \n,+39.5e+H7C2 \t\n\r\n\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " 8\fRgbA(\f++06 \r9\n7,\n\n\r\f-5\f,-6)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgBA(\t38.639e-980077%,.003%,+.990E4%o\n \t ,-.%0885)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "co,MLOWEr7le";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "-mbI E";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\r\r\fhsl(.\r677928E+1891\r\nI\f\r\n\f\f\r\n \t,.35467%\t\n\f\f,-467188542En%)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "R.Bg(\f\t\n \r+.9008%\n\f,+8964e3034%,-735255570.99e,67%, \n \r\r\t\f.7275)\n\f\r\r\f\f\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rgbo(60\r\n\r,+58 ,\n-19)\rf\n\r\n\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "HsL(\r\tc\f\n\r-2\t,\n\r.0016715E-7153%\r \t\r+\n\f\n\f\r 142.9373)3E+404%310%)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \n\nrGb(\t%\n\f\f-.728E2840205%,\n\r38705872413.80405%\r,3+.4E3%B)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGB(h\f \f -61.4441lBE6956d0h359%\nE\f\n,\r\nS2351564523%(51%\r\t)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\fRGbA(8359%\r\n\f,6890S0.3%\t\f\r,\n\t\t \n\f\f\r.945%\r\r,\t+740.187146\r\t\f\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " de3N";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\frgb(\nM\n \f\n\r\f\f+a.7%\t\n,\f+.15%a,.7e+02632%i)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "K6u";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\r\n\fHSL(-8465798836)e03 \n\n,-.092%,617.71035643)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hsL(\ti \n\n34\f\f\f\f\r\r\r,\t.2e+8%,+C467C94349.2s5sK4821E830609%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "r5gB(301e5%,\f\r-6e118730%\r,+.68194L304E52539%\n \f \tl\r \r\n)\t\n\r\f\f\r\n\n\f\f\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgbA(8921L3828,\f\t\f+6352u3g7699, \f \t-92\r\n,\r\f373.90)\f\n\r ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "ruba(\t\f\r\t034\n \f\f\t\n\f\n\r\n,1563\t\n8,i5\t\t G\n.2c";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\nrGrbA(-551\r,3,\r \r-767,+.6ems428300\f)\f\n\f\r\f\r\f\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Hsl(\f\f\n\f\f+060601.146392e+527, \f.9+7289%,\n\t5.8E402526%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "Hsl(\f0.153e6h254\tc\n\n\r \re\f \t\r\f0l89\f,52447.332e155138%)\t\r\f\rk\f\n\n\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgb(-.7530e+4075%\n, \n\f\t\t\n-.20746090U4E-8%,\r+71.2608%\t\r\t\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGBA(33s83898\f,0\n\r\r\n859,-5,+33075-6e+671965712\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "O\f\r\nSFl(n\f.6,\r\n\t\r\n-6%,\n\n\r\n\r\f-83547E34%\f\f\f ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rgBa(\f\t\f\n\t-06261\t\t \r\n\n\t\r1+011007,b\n\r\t\r\r\f\r\f-26l.16)\n\n\r\f\n\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  " \rRGbA(\r\f\r+.5%,\r\n\r\f\f\f\t\r-08725515.42%,\f\r\f\f2%\r\n\f\nl,\r\r\r+.32692804E+53\f\r\n\n\f\t\t\f\f)\n\r\r\n\n \t\n\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rB(-H754l87\t,\f\f+5\r\nL\n\f\r\f,-2255)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rGba(751\n,302R37-323\f\f\t\r\f,\nI\rh\r\r\r+16(.709m065E9264867\r\f\n\n\f\t\f \r\r\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

"\nPrGBA(\fu\f\r\r V\r9g8\n \f \r\r\r\r\r\f,-70101l18,4\f\f,1E+900472\n\n)\r\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\n\fRgBA(0,\t\n\n\f\f\n\r\r 6\n\f\n\n\n\r,\n 30590,-.3181E61809O)\t\n\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\thSL(.988n80\n\tK,.06%,+.H9348E-1\r\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fHsL(-V5499u230,+.0% \f\f\t\f\r\t-.09%\fV \r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "sL(98rE-59\n\n,\f-11e-11188751%,\n9I698.E4U8%\n \r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RbA(\r\f-0,-002585\r,\f\f+61#6\n\r\n ,-.99E+9\n)\f\f\n\f\f\n\t ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgBA(816356%\r\t ,sh2E-013D67%,-252E481%\r\f,.66937m9)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\tHS(\r\n.24475\r \t,\n+.2%\f\f\n\nD\r,-7%\f \t\r\f+\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RGBa(\r\t\n\n\f\r\n\t\r\f477,\n-112171145,\t-25,\n-9647007753e+69342)\r\t\n\n7\f\n\n\f\f\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\ns.\twHATT";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \nhSL(.937 0,.0%,\f\t\n2\r\r\n\f5%)%h\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGBNA(4\r\t\n+326,N\f\n\r\r\r \n82,\t\t\f\f-.)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "dHSL(\fu\t1.20\r,601323.775.70308E286%,807851% \t\n\n) \f\r\f \n\f\f\n\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\nRgba(658.60%,\n\n\r\t\n\f 8-.3443E62%\f\n\n,+.91246676114E-65213714%,-.3e59\f\n\r)\t\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r\f\f\rlrGc ba.(\n\f\n2,\n\r9,\r\r\f\f\f\n\n\n\r\r\r\n-388,\r\r+.931081e2)\f\f\f\n\t\f \f\n \r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "dukRaDil\n\r\f\f\tD\r\t \r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "AInO1O";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGbA(-.628e#%,965M609828E392%4-8000.9814L7%,440E5107\f\n\t%\r\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "C6";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\tS1in9GReEN D O\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "ARbdrod";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "N\t\n\f\f\nrGBa(+1.1%\f\r,+.890%\f\n\rH\f\nb\f\r\r\t,\f\f.73e9692719\n\n\f3\r\r \f\f\r,\t\t 7.253E+7681 \r\n\n\n)\nV\r\t\f\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "d\n\t\r\nRgB)A(+.1E+491219%,4K7E%,.2156f3%,0.7864881) ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "rgBA(+.01312505I342%,\f%\f\f\f\fFD+.05128581682e952%,-837.58388\t64526)8";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgB(\n\t\n .3E479(5913\n5T\r \r\n\n,.681427 9E+8%,\r\f\f\t55%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "1\f\tg6#AA";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rFba(\r \t\t \t\t4842384E+62797%\n\f \t,-.6% \f\t\r\t\r\r\f\n\fN,+R2189879G9.6275%,\r-.6811E-4S\n)\ro \f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "44OONmE";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rrgbO(I\n18,V\r\rf\n\r\f\r8,2\r\r\r\f\r\f\n) G\f\f\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Ho3SWhiTe\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r \r\f \rrgBa(\r10H1\n\n\rn \f ,9196259\f, \r\r\n\f40 \f\n,\n\n\f\t\nf.978119535)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "TRGb(l\r634524,3,\r\n\ng \r\r154)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HOn10dH\fSb\r\r\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RGB(7.576+E2%\r\t\r\n\n\r\rH\rm\t\fT,a0732612.1537%\n\r\f\r,\n\f \f\f.0e-41162%)\r\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "R2gBa-0.3%,.1% ,.8E+87O75G\r\f\t\f9\fK,\t1eL2-500909)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rh,sl(14.40357e-12263,\n\r\f77E632%,\f\r3%\t\f\r\r\n\n\n)\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\nrgbA(-.88353%,\n\n\n\f \f -2404E088762%,+8.5389i7223284% ,\t\n\f-.137e+040796P3\f)\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "cs1hfrefe";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "BhSL(.L1F+G41d0e264915\rB\n,-8%\n\f\r\f\f\f\r\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\frGB(.06907%,\t\f\tP\n \n583344156669E1% \n\r\t\r,\r\r+.58241%\rU\r\f\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RB\n(\r\r+6555\r0,E7\t\r\f\f\fH\f7\f\f,\n63.B";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGb-6205336508F,)\r\f-860(11e4891,+1\rU\n\rA)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f\f\f\r\nrGBA(\r\r \r\r-.77%,847.921E8%\t,-.76E821461%,\f\n\n\t\r\n.t8536E1478327\r\r \n\n\r)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RGBA(\r\f.33364221E1785596069%\f \r\f\t\f,\f\f\n\f R-327.57E+25%,\n\n\r\f\f\f 6179%\f \r\r,\r\r\f\n\f\n\r\f\n\f5570233009N-95169\r\f)\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Ru35E)D41t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rRGba(48096646\n,\f1395,56-0354\n,a034.8\r\n\n \n\r\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n \t \f\r\r\f\f\t\fRgB(07%,\n\f\n\n4 \r\n\r.57%,\r+340e64524%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "vI";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rrGB(+955%\n\r\f\f\n\f,+881B64e-2I0o819%\f,\n\r\f-.s96370%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\r\t \n\f HsL(05\n \t,\t\r\f\r.42C-9%,+.189236%\f\r)\f\r\r\n\r\f\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
 "RGA(\f\f\r1542.7e881% \t,f+565.90E-278%\f\f.\r\n,\f08E275%,7877.3\t\t\r\n\n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rgbA(.%\r\n\t,+.72%,.8635efB,2L70%\r\t\nA,\f\t\n\f\n \f,\n \r\r+.068349924E80\n\t)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#o9\n7b-";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rCGBA(.23195%\f\nu,-.74%\r\tc \n\t\r\f\n\t,\f.185835%\r\f \t\f\f\n\t\r,\f\r\n57C+58566\t)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGbA(-g5837\n\f,\r\r\f\n \t\n\r\r\r\r\f+6508R4,+0,\f\rb\r\r\r4G9e15)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\f\f\rhSL(\r\f\n\r.51213e567E68\t\r\n\t,306.1354%\n\r\f.47C09%\f\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rsL(\f \r .724831\n\f\t,+19E+T%,.46894L86%)\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\tiBRgb(\rT74B6122121E153S93%\r\nH\f \n\r\n \r,\f\f\n \r+4R237752336.2%,\f\n\n R77341.43-9c808%\n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "rGba(+717.4E73%\r\f,+.95T6e-4%\n\f\r,+041.927421E14274+5%,+.5)D\n\f\r,\n\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\r\fh0sL(\t\n\r\f\t\f\f\f\n\n-40ei-77\t,794n57%,.6b86%\t\n\n)\f \t\n\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\r\r\r \n\rSsc(-17 \t\t,\r6\t\f\r533%,-4.08i2%e \f\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\f\f\n\f\nRgBa(\n\r.12027%,\r\f\r\n.9925E-0(0660965,c4E19375489% o, \t+.519)\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgb(-03%,07E-8446084%\r P\n\n\f\f)\n2E5l5d%)\r\f\r\r\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "h l(-.633)886385,\t\r\nH\f\t\n\n\t\f\t\f-07342A651%,4318702.1%\n\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r \r\t\nHs-\nn2,.7e5%,+.2e09%";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\r5d,AGcb";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "aLIDe4Lu\n\r PN\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgBa(\r\r+32330849\r,-1237,+77597496\r ,-.6e088750k74993\r\n)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "B\nAcdDE";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rg(\n.1145%,+646e8%,.4E+9729\n039%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\n\rrGBD\t\r\r36,04473499,+10901\n\nT \f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGbPD7T,\n\n50173,017F41)G";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hS(a-84.R47724,\r\f\rb802647.3927973-9,.430e-2897(%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rg(BdA(\n\r\nN30,4S\r,\n\r\f\n\n\f\t N947\to.8)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RgbA(.9e-05%\f\t\r\f\f\r\n\n\f,\r\n9\r\t+.7288b36%\n ,+.8%,+.5310076435E+00152)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\n\n\tHsnl(.59,27311.8895505E-70%,67746181%)\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "M\rDi,2urpsflE\f\tml\r ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f\n\f\tRgbA(0,\r 72591984\f\f\r\r,\f\f\r\n5527\n\r\r\t\n,T\r\f-46.28550733E39\t)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#b4\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#P67D1adA";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rMMncRe6m";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rGbA(\r\n\r\r \f\n\f\f-.238e6%\r\f\n\t\f\r\f,75.0749147E049%4,\r \r+57.607E-9475%\f\n\f\f\t, \r\n\r\t\t\n\r.54)\n\n\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "1 \n\f\n\f\nRGbA(36\r\n\f,\n\n\f\f\n5\r8664257T99\n\t\r,R0759U+2,\n4)\f\t\f\r\n ";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "Hsl(\t\n\t\rr\t\t\t+985.60E2335E39\t\f,+\f 7\n\f\n\f+07o54.0e6%,.6e-390153681Po()\t\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "IhSl(.8E21,\n.7e-B5k0%,.9\rE+1%\n\n\r\n\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGBA(-3,326I147\n,\t-290,98.06798284\t\tP";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Gb(-04C100,27\n\n4,\n\r0b61477783)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fN\r\fFt\f \n2hIHOmoD\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\na\r\r\rR7GBa(\tN\n-2\n\r\n\t\r,L\nR09,Kk04,\f\n83)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\t\f\r\f\f\fRgb(\r\r98046322 ,344\f\f\n\f\t\n9,V+4 8573183\t\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "KhsL(.+28733e+6070 \r,\r\r\t k\n\f\r\f #\n-.3e+00%,+.1e2915m7%\n\r\t\n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t\r\f\f\n\r\r\r\r\r\fRlGBa(+.5e9398%\te \t\n\n\n \n,\f\n\r\r\n\fP6285.0n989%,.279\r694E79979%3715\r)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f1\t\nhSL(\f \n292418.703288E-0394,\n8979e788%\r\r\f\f\f\n \t,\f\r\n\n\t \n\f0.14e+088471%f\n \r\fB)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f \r\n\r\t\n\r\r\nHgb(\f\n\f\f\t c51.32E2066P66%,u5.8%\n,+31.0E56 789357)85%\n\r)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "hSl(\t\n\r\f\r\f\f.040893\n\n\n \rE\t\f \n\r\fs\r502977172.0%\r\n,)553195E-5%)\f\t\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r\f\fHsl(\r\r\f\n\t\t\n .42689D\n\n\f\n\f,\f\n\n\t +.642893387378E2%,-340011%\t\n\r\n\r)\f6";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#kB1";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "rGbA(.69%,.470%\f\n\r,\f\f\r\f\r\t+.44%\r\f, \f\f\f\r\t\f\r\r B.403\n\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t\f\r\f \rrGBA(\t\t\r0.6E1%\r,83.1e7%\f\n ,+95926e-8%,\f\n\f\n+410243\r)4\n\t\t\r\r\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\f eFaPks3EF\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "HSL(\t62E-62\f\n\n\r,8\r\n\n \f\f\fK9e12\r\t7\tV\r ,\n,\f\t\r\f\f413.98re-677343% \n\t)\f\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
 "rgB(-9.2%\n\r\r\r\f\n ,\r\r\f\n\n\f\r\n-2.05K\r-733%\t\f\nHk\t\f\r, 50041%)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\t\n\n\n\r \tRgIB,\fe899934.2E537277121%\t\n2 \r,45.4%\f\r\n,\f-13%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "VIn";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgbA(4,+6,A4482947\r6\n\f \t,+\n \r-.185O5915A321)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGBa(-326,000717\f\r\f\f,+99,\n -.1+8g781\r\f\n \f\n\f) \f \r\r\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\r\f\nCornsCk";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fRGbA(.2000%,\n\r\t\n\n\f-21.9447E-4981%,89667E038828%,8.M6S6155\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  " \f\fhsl(-661488.54295818E-1350,\r\f \tO +.775633%,\t-16.143217V514k2E+28%\r\n\n9\n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r,RGb(\r\f\n\f\r \t\n1d,\r\t.1010,+3825";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\n9\fDRKSLAteiLUe";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  " \t\r\f4\f\f\nhSL1\r.\t6 \f\f\t\fO\n\fi\n\f,\n\nS6e94855%\rR\n \f\n,\f\r\t\n220%)\r\r\n\f\t\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\t5\ndmkgolDeFnROE\n\f\f\f\r\t \f\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rgB(+5D238%\n\r\n\f\t\t\t\r\n,\f ,\f .8e+72482870%,+.40337.5%\rK \r\r)\r\r\r\t \f\r\f ";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGBA(-9243\t\r\r\t\n\n\t, 76G2403016\r\n\f#\t\f\n\f\n,-482,5254.-1)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "r3Oga(-92f4189K\f,\r\n\n\f\n \n 0\f,+89\n\t\n\f\r,.9636503221 \n\f\t\f)\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f a\fcrInGgE";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nM3niaHd\t1";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

" \n \frMgbA(\t\f.78(2757%,-0.0007%,\f\n\f.57%\f\r\n,\r\f.1882283)\n\n\f\t\r\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\t\n\t\rrgBa9+\n0,-2 \f\f,-0,\r.4323393850\n\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "lHsl(\r \r.776,\r\n\r\t .2304486% 9,\f923.443750697%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Aab4Eae\nP\f\t8\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "n\n\f\rHsL0(\t\r\f\r\t-.95e574(,\t+.2E06%,.7306004%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\r\r9rrGB(6a3+67A\f\f,\n+9276662\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "-KHa";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HSL(+.4E%571+3,0260026e7% ,\f-2,E6241437%\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hRgA(-2,+\r\n \n\r564059542,\f\n+8,(9L18ar4e69A\t\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgB(-590\n\r\r\nE9180\n+67) \nt\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
 "rgba(\f.6%\r\f ,a-.478860\r\r\n\r\n,.E0E-0876%\n ,\r\f.2e-473388\fl\fb \f\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGba(\t-1849324379 ,64\t,87105950187,\f\f8\t +775.3811312723E795)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rhBe(SS\f76.0496%\t\n,36%\fK\r#\tU-.6074787E%)\r \r\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fRGb(01E-089168%\r,\f\fa \f\f\r\r\n+84%\r\n\t\r,\n23632223.8%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t\trgB(8e490788187833%\r\f\f\t\t\r\n \r,\f \r-69e3756909%\t\r\n\r\n,-.0997%R)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f\tRGbA(\n\r\n81.634%\t\r\t\r\f,2084568135e847%,\n\f\n\t\r-95571756294973%\n \rA \t b-.14\f\f)\r\n\n\f\f\f\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "1n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\tSalMN ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\t(\r\n\f\frgB(72,O \r\r\n90,+6\f\n\n\n \n\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "GRgb(\f\r9\r\f\n\t+7A0C,gb\ttH,-2)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

"\f\f rgBaL(+.57885e5e030e-%,+6e92373702I86%\t\f\r\r\r\t\r\f\f,\fN 448%\r(9\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSl(936597.m7E-%94,954O2e99%,\r\n\t\r-1E2%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSL(\n\f\n\n5eP \r\n,+.9cr1e69165%\f\n\f,\f-.92%)\f\r \n \ne\n\n\n\f\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Ds(\rU.9,8327188746.%504%\r\rA\r\r,\f\r\n7054%)\n\f ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r+\n\f%k4 \rHsL(52730,\f+.497E+32043%,.86%) \n\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RG(\r h4H,174P5,.e86,-86) ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "cgb-P4%\f,864E7l%\fK85409337%\t,)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

"rGB(8\nB\r\n-62%,\n\f(.77E-a787821257068%\n\n\r,\n \n\f\r\n.3E-2\f68656%\f\t)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\r\rRGBa(108\r\f,3155d \f\t\n\r \r\n\rF,\n99,461133.6E5\n\t\f\f \f\f\r)\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\fRgB(\n \f\n\t\f595#u\r\rC,+ 2,\n\r\f\t-7+07)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "hSl(t\t\n\n\t\n\rn\f\r\r\t.40\n\f\f\t, \fs.6515925545%\n ,\nV+F2n%d\n\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rHgBaN(F\r-)86, \t\r\r\r\f,\t\r-86383, \n\r-81,86+.4095\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "hsL(\r\r \f\f\r\r1885492\f\r\n\n \t\f\n\n\r,\t\r\t\r\f+8671E-43601%\r,\f+46O362201600K2E60721%)\t\n\n ";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\r\f\n\r\f\r\nhsl(-5e-73l32\t742663\f\n\r\r\n\f\n\f\f\r9\r.7%,\f.313m%k";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "l\nAhbcU";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " (\f2\r\f\t RmBa(.E9, \f-.478%,-.7287%A,-542#3e1\t)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "h\f kHaki,\f\r \n\f\r ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "rgb(\n\r\f\f\r 5780.02I03%,\n1.32906E+054%%,)55\n \r\r498299819%) \t\r\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGB s(-9839G\n\n8UhF \n\f\f,-7\n\tH,36\n\f\f\f\f\r\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rGb(\f\f\f\n\t\rh\nIf\r\f\r606\t\r\t\t\fm +3613888169\n\r,1\n-P12s6\f\n\n\nH\r6\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\r\tsD(.6e9689\t\n\n,\rI,\r+36083.1%,-g07327966.4E+027%\r\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\t\n\f\fT \r a\f\r#ED69e3f6E\f\r\fB\f\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "h8D#2orY";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f \f\r\r3\n\f\f\r#Ae3CF\t\r\n\t \n\r\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgba(\n+330090.06O,\t\r\f-.7%\r,+.c416496E-9%,\f\t03.8)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "u";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgba(4,-11 \tU\f\r\n\f ,\n\t \f\r\t-P5608977\n\r\f%.\r1527e-8115)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "mi6l4mO\tNcH\rfo\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "R0ba(+4408% \n \f8\n,.109679e+528348518050%,\n\n.6a0E-201%\r ,\t72E+816,\t\f\n\f\r\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#Ti0ciFE";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "k2\nRGb(49517E5u0215455%i,\f\r\nh-.61F1610EL+9%, -.07%\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "OrK\teagREE\t\fn";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HSl(6,.9K1275496E+7%i,+0059.192148EO037%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\t %LBmEmen";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "BF(KLBC";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "NaRKs)EATeNRy";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGBa(\n\f\r)\f\f\n,O\r+7\n,5#23,\n\n.76110)t\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\fS\r\r\n\n\f\f\n\n\t\nrgbA(\n-.1e+20%\r,6.1E+4648266%,-90E-250%,\t5.39)\f\f\n\n\f\f \n\n\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGB(562\f\nV\f,\f\n\f\r\f\t9585,-1R243u\rh\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "ob";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "MEDIumS\nLaTebLuEi\r\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\nrGb0s1\fS81\n-2\f92t\r\r\n\n\f9t\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \nuRGB(.444U(e-662280%\f5\t\r\t,\n50e51E6f%, +601%\f\r) ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hsl(\t\t\t\r\f5.5 E-8\n\r\r\t\t\t\f,.71E459%\f\n\n\n\t\n\n\t\r,+41%\rd";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f %GB(0849141\n,\n3385474)u\n\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "HSl(\r-.33e519\f \f\n\n,#\n\f\n\f\r \n\t+993721.9812E-63%, \f(.584231%)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#dB\f\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGB(\f\r8 \f 4-7259.7,6667,-1248\r38 \n\n\r()";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\r\nRGNBA(\t\r\n+1\n,\re\n\f k0\t156\n\n\r+64\f\fd\f\n6\r1265.057e-9\r\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rG4b\r3\t\f-56\n\f,\n\r 41";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "7\nLL(, \f\n\t\f\f\n\t+39205E5785110\n \n\f\r,.83008821l,\f.1692220E+41%)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "fbcblADb\r\n\f5 ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgba4\r\r ,51940\tn\f\f9K73427\f\t,\f\f50847574\n\r\n\f\t\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\tV\n\n\tRg%(\f\n\n+T3690,\n+060,\t\f5)\f\n\r\n\f\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\n\n\n\n\f\f \frGB(.6U%\r\fA, .c53E45b459%\f\n\n\f\r,.4830E0598%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGb(+0.fN,3Sr)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "8Kahk";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\n\t\n \n\rRgBa(2\f\r,\f+21\r\t,1\t\r,+.59019749D";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#cc\fOM6\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "mDiUROrCid\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n \rS\fda\rrKRAnBGK\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "fA ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "gba(-36,84,\n\r\r9137,.9e36254\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nRGBA(23uS\n-9\n,+533ad\rm,\f\f\t\f\t\f \t\f\f48\f)\fB\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r\r\t\r\n\rRgboaR7%k\n-\f\n\t\n\r\n\rm,m\t\n\f-.81%\r,\r\r\r\f \n\f\n+.158900156e+3%,\rP\r9.4898E89)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGb(m23%,H-.8M,\r\n\f ,\fa78124604e68%)\f5 \r\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nrgba1(\n\f\n\r846\f\n \r\f\t67741P998\f,\f18808Pr07,-.26204)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\t\nMsLO(\t\t\n7.76092 \t,11.7U062272029e+0%,+.661997%D \n\n \f\r ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#tE5\t\r \rB \r\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "R\rAmT";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f \n\trgbm(42\n\n\r,\fg\fK\ns\r3363\f\f,8n61149\n\t\n5)\r \f\f\r\r\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RGb(\f\r.235534E94782%,\f\n \r\r +.101%\n\f\n\f\f,\r776085671e39G61592%)\rl\n\n\n\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\r\nrGs(\r\f\r\t\f\r\nf3 I54\n,\f \t+3,\nS69k)\n\r\f\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgb5,+362\r, \f\rl\f\n2)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGb8(\n\n\f\n\r\n 37,30\f,+9)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rA4\f\f\r \nh\r\nALmoN.\n\tn\r\t\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\ngdl)64T02,1\f\t\r,9m623,5.580e+93)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "KSAR-KVrEemN";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HsL(\f\f\n\r \f)79E-987094634,9.64E-85%,\r.070g053801)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

"rGB(32084454.57491208%,+)%\r,\t(\f ,+.98674e+485c43117% \f\r\r\f\r\n\t\n)\r\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n e\n\t\fRBGb(\f\f\r\r\n8..9,.94eE008S\r\n,\r+94D5a7%\r)\n\n\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "Rgba(\t\r\r\n\r\r\f\n\n41,\t\n\n\t\n-08,\f\f\r+314237 ,+P1335.6e93466r53\n) \n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\fHsL(\f\r \n\f\f1.4795\n\n\r \n\n.8%,\f\r\r\f\r-982163%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hsM5s30-5\t\f\r,5E49\n,.0%\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\n\nrGB(\n\n\t\t\f \t+4434484698\f ,\r\f\t\f \f \f421157h5,9815\n\n\f\f0)\t ";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hsl(1\t\f\rr, \n\f\f\t\t380862447.928982418%,-.36e154%\t\t)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\nHsL (\r\f\f \r-881910T09#1.33030e-52,\f-791253,\f-.0i6% \f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "d\f\f\n\n\n S\f\rHsL(833701.5-11,\r.1e-181%,3\r55346K%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HsL(.57E+1\t,+.2% 7 ,+43V97.279314%)g\f \r\n\r\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f#535aCBBf\r.8\f\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGbK9.48622%\n\n.533e%\rb\r\r,\r\n\rs\f\f.0B5%\n\f\r)\n\r\n \r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\thV(\n\t\r\f\r +.285\f,-A9527392498.8%,.99N67591e+8720628)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nrgB(\f\f-1,A\f\f\f\t\fFV\nh\r06\r\r\n,-8)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \f\r\r\f\n\f%\r#Cba9PAAEb";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rGbk(+349,3289\f\r\t\f\f,06\f \r\t\t\n\r \t,\r\t\f\t\r\f+.326)\r\r\n \r\f\r\r\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t\n\n\fRgbA(-.48582300E-62%\r\f,-8245e96%\r,\r\n\f+1.711K%,+4.8e122445896809)\r\n ";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "0ihG\tgrE3";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\tT\r\r\t#MB7P\f\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "GBD-660,\r\f7O\n3619,-.9N1006\f)\rF\f \n(h\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGB(.82642g%r,.It449865e6037%\r,(20540%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSL(.,-.26e7%\n\f\r\r\t,\nC.64159\th1%)\n\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fd2ec \f ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "B\n\r\f\f\nrgbA63,\n \r \f71,+5M6U,+1\r ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t\rHsL-.83E-22235521\f30\r\r\f\t\n\f\f R,-.07924e6781660666%,\r \t6E16133017%\n\f)\n\n\t\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RG0ba(\r\r+88.967e10881%\n\r,+24%\r\r\r.\r\nV\t\r,72%\f\f,\r\r\n\f\f.2E2\f\t)\t\n\r\r\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "r\fGbA(\n\f\f\n\r0673255,72,-2U,\r\r\f84513)\r\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "h%L(\n\nn09727E4M6.357%-.4E-5997%\r\r)\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgb(-8Ae+3%F,D#\r\n\n+09I33.998%\r\r\f\n \n\f\f\n\t,-917% \t\tm)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgB(\t\f\n\r\r\n\f\f +267,-3\nF\n\r\n,c7794)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fHsL(-.913215e19\t\n\f ,-.92t15720%,,+69g257%\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\rrbA(\n+73\t\r \n\r\r,-22-\f, 42031\rI\n,+80305.709a0217";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rhgBa(\f\n%#916540,622\f\t,+721,+5u77930488E55669\f)\n\r \r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rub(33\f\f4,3)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "EA\tCH#CN4";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgBa(1%,B40e1%,+5D4.7E966d%\f\f\n,\f-.28)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGb(\t-3043,9\t\n,\n\t\f\n \r\r\re-41909014\n)\n\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\trGB(\n\t\f\n\n\n\t\t\t\r-4658 \t\n\t\r\f,77\f\t\f\n\r,\r\n+6692k734)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\t\fligHTGfLdnRodYELLoW";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "R-b(\r-5127 ,5\r\rb\r ,+0)5\f\f\f\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f3lCS\fU\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\rkdGrGeAG(N-8018\f+7\f\n\r,8\n,\n\f\r.0\r)\r\r\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  " \tRGba)(1h8e9%,\r\r\r4623.4%,\n\n\r\f\r\t\f224 %,\n\r\t\n\r\r8\r\n29999)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\r\r\frgb(49\f,2081816\fP\f\f\n\r\f,-749189\n)\r\ra\r\n\r \r\f\f\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nrg(m1644570,\f\n\r-74\r\n\r\r\r\fNHcs,6+645889P\n\f\t\n\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "taD9I9f\n\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "H6L(-0,\nUa\nC180m3%-97.4\t%\r\ne\f \t)N";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
 "\rhSl(\r\t\t\n\n\f+G6903\f9362486.197E+739s+.68%,\r\r \f \f\fT70.92e+03134%)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r\rD\r\n\f\nf\r\n\rHsl(\n \f\r\f\r\r+\n\f\t\r+.000,.6A-2%\t,0992570e-2162015%)\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nakfE";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\frGBA(+2e+8%,\r+.8544879%\n\n\n\f \r,111E-67136621%,+7.8108k6852)\r\f\r\r\n\n \t \f\f\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rgba(7\n9\t\r\ti\f,\t282,45\r\fg.6f7566e6263\n\f %)\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nRgBa(+8g9+083e+)520256,8e+00508%,+51%, +4e+3t1\f\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RGbA(\f\r\f\t\f\n\t\f\t-u.22957%\r\f\t\f\f\f,0.70912E+68615%,\n\f\r\r\n\n\n-1T713710E-69332132893%,-.73e-52\r\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rSGb(\r\n,+.\n\f98136105ui)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\nHsl(\f.235730894555me+301\t,\n\r\f\t30.M6689273e091732%\r \r \r\f,R.567e45%\r\r\f\t\r\n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
 "Rgb(\t\r\r\f\n\f \r-395,\f\f\r\r21\n \r\n \f \f\n,\r\f\r\n+698C2)\f\t\f\r\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Nf.\rc";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\f\t\r8rgb(\r\r\f\t-39,1\n,324245I35)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

"\fHSL(\n\n-.320337\t,\n \r\n\t\f\n\n\f\f\r-)119454.01E+8%,\r-.2538kE68587%\n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\t RgBa(\r\t\n\r.13%\t\n\t\n\n \n \n\t,\r-5)%,\n-E50%,\r\r\n\r\t+.803E+1)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "A8mrG9";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rRGb(\tV7,M19t084R7627\f,\f\t\f\r+279";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "rgBA(,\r.504Ho7028e-7906%\t,\t\n.24% ,+.1\nE-65%\n2\t)\f\f2N\n\r\n\f \r\n\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "1lIcMeb,BLuE";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\nrGB(+4131A\r\f\f-7224Uo30984\n\n,+6\r\t\n\f\r\r\r\f)\f\r\f\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RB(\fE C375E02820,u+4,A\f\n\f \n270C)\f\f\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\tHSL(3.23306134733e-45471243917\n\r7,\f\f-.3180E8841701%\r\r\f\n\r\r, \r\r+F292058e+14143%) \r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hsLc(+.o660P4S,-1e-6%,.8e+357O%\f\r)\t\f\r\fB\n\n\f\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\tWU Eco\nT";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGba(\f9420\n,02\f\r\f\n\r\n\f-40\r\t,+0E79.5563327989)\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "b\t\toI%DAe";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "K#A-A\t.cVU\fn\r\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rHsL(\r +123e0108\n,\t\rf\r.89460901E+3%,\n\f\f\f35.8477%\n\f\n\r\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\nHslP(\n\r\f\t-.\f0259E-35M18\f0E2%,+i.56e+937%)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HSL(\r\f+.4,\f\r%090%,+3E02rV14A97521%)\f\f\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\riSl(\f-B5+885\r\f\r,.9%\ng\r,\r+5E-0151S%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
 "\r\n\nHSl(u-804638P84127E+0138,-.538576400%\r,\t\r\f\f-70583779e-334573869%)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f\f\f3\rrG6A(\t-265501\r\r \f2t \t\f,\n,\f4 \f\n+4\f\n\n\f,-0E10,\n\t\r\f\r\f\t\fA5000)\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nfaRsKV\nOLBT5\t\n\r \f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGba(\r\r\f\n+3E1%,\n726%\f\f\n \f\n,\r\t-.253217e728%K,.3e+1\n\t)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r\trgBA(\f-92299\f \n\f\r\f\r\r\f+3\f\n\n\nT56\t,\n3t74656590.1e5399\f\t\r\n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "darKOBLIV#EEcN";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "6\rm DFBMc";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "RfGB(\r\f.1%,\r\f693363886.9025%\t\n \f\rG,\n \r\f859e8383%S)\f\n7 \n\r\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HsLP-U.03H110G6a3760145,-77807u.9E98%\t\f\f,71146.5e398%\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\f\r\n\t\n \f\n\nRgB(98417582\n\r,2813645,t)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\n\f\n\n\t Hsl(\f\f\f\f\f\f-.601002E+171\f,\nK\t\f\f\r\r.273%,87F9.689%\f)\n\r\n\n\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\f\n\f\rHPSL(-+8iE098683,\n\f\n\r\r\r\n\r\n.3l586% \t,%3633N1.4%)\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "argbA(\t\n\n.53%b\f\r\n,.9%A.90868E+2%\n\f,+00 \f\n\r)\n \t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "PgHsPPO5cYBLuF";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "sHSl(-.623e+8470754,2 \t \n-5E-9%,74343r3%F0\r\r\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\f\t\n\n\tRgB(\f+.7\r0lE2%\r\r,k+.6 988HE+760711832%\r\n,+17% \t\n\r\f\f\f\n)\f\tf";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nCoR7nFle5mb2ilUE";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSL(.8354E-1\r,-.383615Be5% \r \f\f\n\n,\t+.1e+46881604%\r\rC \t\r\r ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "s-EBDUe";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Vgb8a6030910948E6726%,\f-.515837%,\nn\n\f07.5%,+8K72e109\r)\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGB(\t-\r492,+99MM\r7b48 \n\r\n\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSG(\t\r\t \r\n \f7\n9616,\fD663.3%,\r\t\r\n\n\n-.5%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\r\rhSl(.22164538E-3,+.0837e\r980%,.F6684e2641449748%\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rSl(\f\f\n\n \n-.47S-4590\r\n\f\fU,.3E75%\r\t\r\f\n-863%()";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\fHSL(\f\n\n.668867e-3254,3%\fg\n\r\r\f\t\r\n,\n \f D\f\f\n\f+.4596E-38%\f\f\n\f)\n ";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

"\n \t\f\n\n\rrGbA\r \n\f\r\f\n07\r,\r\n\t\n\n \n\f3,\r-03,\n\n\n+807.13178oF)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " 3#BS";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\f \t\r\f\f\r\rRgBa(5395833177+5 \f,\r1\n\t+7\f,87841 ,.9352e-277)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rHs9(-3,.+809E+811V99605%G\f -3%\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgC(\f5710N75758%,\t\f\f\r\f\t\n\f\r5 77A9%\n,084%) \n\n\f\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rgba(+.43e85%\t\f\r,\f \f\n\f\r\r\n\n\n824.01305A90e+91%\r, \n561809.1762716E3656%\n\n\r,\f \f \rH\n\n\r\f\f\r-.1\f\r\f\t\t \r\r\n\f\n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  " \tHsL(\r\f.015127E+469942m51\f\r\n\n\r,+5E545180%\nd,+.7E+6%)\r\n\n\r \r\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "6db\nPSKYlU";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "Rlba(+11130006830,\f \n\t\t\r\t\f\f+90F-0172,3865267t,9.25034e-1581338\r)\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Gb(+3\r\f\f\rf,(5018736L,\fE74106K526)\f \n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
 "B \r \rhsl(+.5976288884\n \f\n \r, \f\n\n\f\f7.868E-9603%,.2811%\n\n\r\n) \f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\rRBn(\n\n\f \f+1274\r \t\f ,-.99G85%H \r\t\f+,-469395693%,+.5723\n\f\f\n\r\n\f\f\r)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "m3eDOmTUEQVuOi\fSRaE";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \n\n% medIumturQuoIsE\r7\f\t\r\r\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RGbA(+135563.4591eF8543A507%\f\n\n\t,\r\f\f \f\n\n1502B81E-3%\f%,k\n\f \r\r\n\r \f8.79l8435.526%6,\n-86)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rrGb(2,1340\r615,\n0822M094\n 8 \n\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RIB(-633\r74760s98,\n\n\n\f\f\r\nO\t\t\t\no,\n\r\n\n\r 8\f 3)\r \n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\t\f\t \f\r\n rgmB(\f\n76012,0,g\n+3\r)\r\f\r\n\f\r \n\f ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\r\r\f\r\f7\r\frGB \fk6%\t\t .782%\f,\n\t\n\f-.61909E507055%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RG(\n+6\r\f,0\f2,09186k)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGB(\r+\f\n\r,\r5\r \f+50o,\n\f-+42R37)cC)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Hsl(90.l097119)\ri(,+7654E337(,.17933%)\r\n\n\n\n\r\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "f#kDesD";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "3-K";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "FBnFf\t g4\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\n\t\nRnG5(\n\n\n\r\f\n\f3o1.8E+75585%,\r847.176e73%\r.4\t66aE072%,.9\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "DHS5L(8\n\f\f73339124,-.6142%\f\f\fk\f,27E60%";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGAB((\nO\r45975,336,-604\r\n\t\r\r) ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n2\n\r\n\nmaGEinTa";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "b\nCo\nRNsIeO+k\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "V\r\n\f\r\r\f\ru\f\n(-.716023072%,235.1F.%\n\n\t\f,\t +4k%)\r\n \t\f\t\tP";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " RgB(A\r\f\t\r0,39,D\t\n94617\r\f\t\r\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Dre";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSl(-.516+934)O2\r,u\n \n\n\t+.4E85\t,\t\f.05%)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "R7B(\f\n1,\f\r\f\r-3686\fHm--l5)\r\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "di(uMVHD";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\ng\f\rRgbA(844)\t\n\f4\r\n\f,,83073\r\t\r,\n\f\f\f\t \r \n+837,\f \r\f\t .40)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\t\f\tHSl(1,\f\n\n-01132%,6.78E-29%-\f\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\tHrg8b(\f\r\r\r3+98850961\r \r ,R5)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  " Hsl(\t\t\n.9\r\f \r\r\n\f,\f-R6B76%\n \r\f\r\fS\f,\r1338.7885597%)\t\n\n\t\t\r\r\r \f\r\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "u+s";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "RgA(.76L0e+9%,8891.3652135360%,o084651e254662%\r \r\f\r,+085.6E24T \r\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\f\r\f\r\fRGba(\f\n\r1946,6n\n\f\t\r,\n\f+f\r,-.3d6\n\n \r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\trFgb(+6\f4,\t\n(9,47\f\f\r\f\n)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rgb(06487849E02929bk0778%,\f\f\r\r,L\f.4%\n\n,\r+.19%)\nl\n)R\f\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGb(\f\r\f02376,85h0047,\t \n\r\r \n6973932527)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\nRG+7680732142%,.536%U,+.179921% \n\r\r\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGba(0 \f,\t \n68,e\f +363,759.9589u56668E+9)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f Ol(-.481602,+.777175\n ,.879053913%K\f)\r\tT6";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\tOldLaC";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\r \r \f#T(bEA28 0B\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "6Uw\fEl";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "GlD5,9L\r,\f-t4403r\n\t\f \r\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  " \nhSl(\t\n\n9\n\r8224e-8\n\r\t\f\r\n\f\r,+.9882e2%\r\f ,\f-7e-2%)\f\r\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "aQUamPrH-nE";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "daRKlOltNta";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r\f\n\n\n\f\f\f\n\fhSl9(\t289E483842480420,\r\r\n\n\f+9397989%,\r\f\f\f\n-.V510174e+858+n2%\n\n\n\r)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGB%(\n+41,67025,3u19,.77963\r)\t\n AO\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f\frgbAL\r\f\r \f\f\t\f.35E+42894737%,\n\n\n\f\f-.145%,H\n\r\f24179E+2%,8N3.3E+6939B897)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  " hSL(+.1591270000E-62\t(T ,+56.1187025n3+98466371%\r\n\n\t\n\n\f\r\t,V0.e685e605927%)\f\r \r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgb(\r\f \f0 -.50e+55%,10s3976.67eI3%\f ,#86-7E88%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Hsl(\f\n\r\t\n.8731282e2e+2,77e6D+38%\n\r\r \f,\r\n2%)\f\f\rS \n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGBa(\f\r\n\n 6\r\f\t\f\r\n,\r+5,\r8,\r.b06U m)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f\f\t\fRGBa(\t+0461997E-0%l\tR\n\r,\ni\n+15k2.7%,\r -3E64782330M0%\t\r\t\t\n,.67\t \r\t) \n\n\f\f\r\r\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fsRDKc";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\f\fRGba(5\r \fI\r ,5s+81,N ,+.52456\n\r\t\n\n\r0)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hS(8688601.2ne2\f\r,6.24\t97%,-.4\rO835e5%) ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f sTl(\f\f \r\t-.84\te-186-.342702\r5%,\f+.79%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "L#9ELFMfFaUB,ab";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "ggb(\t\f-.285 \t\n\f ,.4E+87232%,\f+..19%c";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\fHdsl(-5\r,-9.577%,\t32\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "PghtsyBLUe\nT\t\f\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGb(54,46547\f\rV\t\fc,)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = ")Gba(\n\f-452285238\t\t\f\r\r \f\f,04991r\f\r,5307\r,\f\r \f\f+.94e1K)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RFB(561RV83 \r\fk\rI734\f\n\f\r\f\t+8)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n#cFc\f)\n\tV";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\r\r \r\r\n\n\f\frba(-N4069e5%,\f\r\t\t\r.9%,\f-29.5020e1171m\r\n\n\r,36.4351e9o \r\n\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Gba(1753\r\f\n\n\n\fu\n169398+3,\fg\r\r-.39)P\n\t\n%\r\r\f\fo\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "0gb(\n+9\f\t\r\r\n\f \r,\f\ni-7, \n\n8";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r\n\n\f\n\f\fRgb(\t-.5E+8%,\f\t\fl.5\f9% \n\r\f \r\f,.3053E%-98%\f\fC\f\n\f\n\r2 \r\ru0";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "sl(\n-.6I39-+707N50\n,95.4998652280%\f,.2S2599g3%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGBA(T \f\f\t8,-808,+2U\f,\f\r\r.47353632%0E18)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\n\n\fLIGhtS aSLmON";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "H-\f\fr G#db";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "r#DGB";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGB(61.24084654)3%\r\n\n\f-.348+k60969A%\f\n,\n\r\r\n-.69e-06%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HASL(+.8846394931e-31,\f-2554%,-.5058287%3\r\n \nP\n)\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "mb) D";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#o\fkger 7";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RGB(3338.537e0781% ,\r\r\r\f \n\f -4957.6614E(85676\f\n\r\r,\r\f\r+5567930313.8E18%)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hsL(\n\r\f\r hu5,e7,13%,8.V.n9281a6924%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\t\r\nRGBa(563097903E9%\n,5.98e82524%\n\f\r\r\t\f\t\t7,-.75155+189%,\n 3-2\r \f\f\r\r\f)\n\n\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgbR(.5%,.9772e9%,863R28i3e2%";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "SLATegr\r7AY\r\rR \rd ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\f\n\f\fRSgB(\n\r\f98\f\fe,\f\f\f\r\n\f\f\f\f +46,\r-964A08G)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n RrGB(L-.73646%\n\n,\r951023c8%\n\t,\r+08557%\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n2rGBa(\t\n\r\no\n137500588r2,610\r\f \f,\n\n(\t\f\r\n+474236Nh\n\n \r,\f\r\f-.252609)\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "H\f\r\t\n\f\t\ru\f1Sl(H\t\f\n\f\t\f.75A,d -52%,+41-5%)\n\r\n\f\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fD)AorA\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  " HSl(\n\f\t05229560422\n\r\f\t\t\f ,.4L145r9e 8676702%\n\r ,.10882%\r\f\t\f8)\n\r\t\n\n\f\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\fRB(64\t\f\n\n\n\n(\r\n,+88125\r\f,\te\r\t92\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nRgB(\n73233.3%,-5\t32491%\t,080655E+2g88%\t\f\f\r\f\t)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = ",\fmOw6N";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgBB290\f\r\n\n\f\t, \t\n\t\t3435,\f\r\r\n\n\t\r147) \fD\t7";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\f\f\r\f rhSL(B\n.7e\t36,-.3E80%\r\r\f\n,+.7532002E)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\f\f\f\n \f\t\nrgB(,4581244254l%\f,-.5E8t68%37.8 \n)\r)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgB(+.557%,.7699e-15%h\r\n\r \f,-.5a%,69667e59712 F) ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#\ndcf76%9mLd9";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "HSl(\r3\f \n\r\f \f+.4000e0\f ,.63696730036E%\n\t\r\f\r\n,\n\f+.4412E+78831%\n\r\r\n\n\r)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "edeHUMOrc\nHVD\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgBa(\t+21,95352357,82021,+60204451.e8e-6\n\fS)\n\f\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\t\n\fH.sL(.2510\r5-7% \t h\r\f\n\r\n\n,0510%)\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\r\t\t\n+sLAtELUE ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t\t\tHsL(\f\n.173e6958150d62\n\r\t\f\n,\n\f.m25800572,+2941%\f ,\f-7438756431188665622%)\r\n\f ";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\t\f\n\rbrdb(\f\n\n\f L1 \r472\f\f\f\n\f\n,\n\rB\f-62\n\n7\n\n\r,05 \t)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\n\r\r\fHSl(738.84521\n\n\n\r\t\f\t\f,+.3E141%,\n\f\f\fR+.95%)\f\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "hSL\r\n\f \f\f\n\r\f+97254933.0E910554864\t,\f -T.57RCg24%,\n\r\f\r\r\r\fr\n94.17478%\r\rSl\r\f\f)\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\rrgBa(\r3902788099.27044l\f-5a86%,E -9.2O2%\n,\n\n\r\r\n-.s8134E+020%,\t\r\r583.14743)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f\fgBAU\n\f\n\f\n-1802.%\r \r,\n\r\n\t \f\t5k1634249.4e4(51508%\n\n,.2331PS899e73599%\r\n\f\tP\f\f \f,\t -.273e+82053\n165)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGB0a(\n\t\f\f\t3 3363,\f0T1351L73\n\t ,-26,\r-60e23870\r \r\n%()";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

"\f\r\n\f\n rgB(\r\n\n\r+3,\n\r\t \n\n\t\r\f+u035770421,#\r38\rd\rN,\n \n\r27)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\tRgba(-4358\f,301495L\n\t\n\r\r-4\r,8\f \r)\f\r\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\fRgBa(\r\r\f8658\t,-1\r1,2909,-2)\n\f\n\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rMbA(\n \r\r\r936284572%\r\t \f,\n4\n\t\n\t\f\nRK+28.092%,\t\n\f\r\f16.0e-0123781\f%,5036)\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGba(\r\r-55499859,\r\f \n\f\r+\t+3,\t18\rm1,.8)\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Oi(8eLIrB";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "hfSL(\rb\f\t\r\r\n\r5E19 \f\n \f\r,\n\r40971933E-0%,\f\r93.85973El%\f\r\t)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n \n\tI\n\rrLBA(-0%,B36.8367%\r ,\t.2%, \n.0)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\r\r\fRgBA(1504,96598,741501448,8745314\f\t\fGO\r\t\t\r\f,+.7E-722";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  " \r\t\nRgiB(2978F194345e+6%\r\f,\r2896%\r\r \r\f\t,\t\r \t+002F847o933%\t)\t\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\fS\t\fhSL(\r\r.41407 ,\n\r4193%\t\n4,\r\n.C2PE77863%)\f\f\rS\r\f\n\f\f\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgGam(9L,\r\n\n-r1\f,9698\t,-0359.295)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r \tdO+SYbR5WN\fL8\n)b ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "+\f\f\nrgB (\f\f\r-+047%,73%\f\r,\t \f\f\n\r\r055\f23135\f,.4362e+9)\f\tn\f\r\f\f\f\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "2LOEeRNenF";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Sl(--5.8\n\n\t,+4.061Ke-8%,-35761.0s%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "KdoSl(-76135.89e-896,K23e154%\f\r \r21.3066h82064%\t\rC\f\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f\n\r\t\f\n\frGB(+89038.80E+2029%\f\f\f\t\f,-545449.5e+568%,-.64787eN-8%\f\f\f\t\f\n)\r\f\r\f\n\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\f\nhsl(-.35E+998-877341,.8926814726ee8s020865%,\r-.24088%\t\f\t)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "%DI-GMSa\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "OLIvDAb\f\r\r ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HSL(\r\t\r\r\ro.14564435\t\f \rt,-.6%\r\t\n ,\n\rf\r8.1%\r\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Lobav9NdEBlUsH\r\f\r\f\fc\n\r\r\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgB(\f\n\t\n+.\f071254%h\n+2002%\r\n\t,+1E-255571%\n)\f ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGBa(\rb\t,+74\f,0,\f \fO\t\r\f+31620322Ea5939927\n\f\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\f \r\fhSL(+.0\f407625,\n\n1%\t\r+D.65%\f\f\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nR2Be78,\n\f\f0,837";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rGb(\r\f\r\n\t\t\f\t3t9.4e+0542607280%,\n91340)141201E+66(133922%,\n\r\n+\t\r43031735129.1204E0%\n ,\r\n \f\n\r)\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nHSL(\n\f\f\f\f\f\nV\r-56.61,G7126884e98380\fr\n\r,.7EF2%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#\rDN6\n1cBA";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\r\rrgbA(48 \tc\n -62\r\t\t\r,3053,.01973146603.+26)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rgba(\r+84.449S02\r\f\f\n\r\f, \t\f\n+.408e33%,9\n\n-78.17838E20809\r,\f \r\f\n.10145474)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\nDcDBHAc\fn\f\f\ri\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t\t\r\rrgBA(\f\fV665o479\n\t,-3647H0\r\t\r,-9\t\r(\r\f\r\f\nbm,r.03uE+3500133\t\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSL(-.7033e654713768 ,\f\f\f1\r\n\f\f\r.21%,\n \f+940%\n\f\f)\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "L\f\r\fDTbaTl";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\frGba(-96\t,0d\t\n,-9 \t,.2C1e580\r\nr)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RGba(\r\f\f -.2E976783%A\f\r\r+.LE+608%\r\r \n\r\r\t\f,17.2724P49384%R52e-44)f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rBa(f\f,+06779420,3817,591218, \f896991\n\rm\n\n\r\r\n\t)\f\t\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r\n\f\n\t\t\n\t\nRGBa.3%\ru,\r\n+.0600E,\r+74I53.85e971,\t\f\f.1E-5)\f\f\n \n ";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#Bdo8braa.\f\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "g\n\t\rrGba(.33a7557743%,.29e-73%,\t\n 24o64576.1e-1\t915f\t\r,\r+.089271\f\r\fN\n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \fRgb(G\f\r\t.719441\t92%,\n\r7t7156252%,\n\rkI+.549e922%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \r \f\r#dFB1FE9\n\f\n\t \r ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgB(1f.S85126%,0.73535E30%,498717B547.05%\f\f\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "gbA(\n5\f.O84K,V\n\n.0E-0(%5\t \r\n\fK\ne-8%\f,\t+.2\t\f) \t\r\f\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\n\n\f\n\frGBa(-1%,\r\t\f\r \n \t-910.4Go%,+.04708e9694%\t \n \f\n,.1424449b55e-41 \n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RgBA(-64457176.4oE+82814442%\r\r,\r\t\t\n\f\n.2e151)%\r\r\f\t\ne\t \t\n,4506707e11151734%\f\r\t,.4e-562\f\f\f\f\n\r) \r\f\ta";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RgBA(\f \t\n \f\f\n\f94-6.94446982341E647%\t \t,\f\f\n\n\t-71.8E51\t624%,\f\f.42301e4%\t\f\n\t\r\n, \f\n+.2\f\n\r\n\r\f\r\f\r\nS)\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RGbA(\t\t .2%\f,3451731177% ,\t\n\n\r\f+443282e-\r5%\f\t\t\t\r \n+32629E+714 \r)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r#+1FGDF";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "hsl(\n\r\f\n\f\f\t\f688E-88\fu\r\t,\n\t\n\f\r+1%,\t I\n\t\n \n1786.8%\t\r\n\f\t\n\f \f)\n\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fEGB(+NS53,597\f,O+85\r\fu-)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "4 VrGB(26O\f9,N\f\tk\f\n\n\n\n\f 4r94,\f\rC\f\t\n\f+1644%23)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgB(1\f,+98,\n\t\n\r.\n\f\t0\t88)\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGb(\r\t\r\t\r+7412.6%\r\t\f\t,+k.021354e45673%6,946.10h%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "-SL(\n\t+mE+938223\r\nm,\r\n -106.1%,64e+30745%";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\fRB(\t\nB+8\t\r,g25\f34567,+22";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
 "\t\t\t\rhu\f\rsl\fU t\t\r .641\n\t \fR\r A\r,\f\r\ro\n\n\n\n\f0746.7%,.9%)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rgb(c+.GG4%,Pk\r-3%R\n,N5\n\f5\n\t\f60e-8%)\r\f\n\f\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "0VP52";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

"\f\f\r\r\rRgcA(\r \r\f\n9219691.773864e89%,\nn-.6%,\n\r.es398%,--19K8h2e+\t6)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f\thsL(+.67\n\r\n\fP\t \t,..1149044I%\f\r,\n-4792.0946084E732356034%\r\f)\r\n\rh\n\r\f \r\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "r\fpurPL5e";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r\f\n \n \f\r\f\fRgB(-11204Ti4.0313.46210442E652312%,\f\r\n\n+.9113417e065541%\r ,\t+116.2647E86%)\f\f\n\f\f\n\r\f\n\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Hl(\f+98950,13\n6d07#390383%\r\r,.B509)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "F \flI7Ntse\rGreNo\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fFEce5ccA53C";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\n\n\nRgB(-8192635E+M30122%,+.01187711mD-255%,\n\r\r\r\f\n\n\t .708655777%)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nmdiUmORcHIdS\r\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n#m8sbFt\n\r O \r\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RFcn\fA-3378)+-7,-7,\f.5e53B39)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGIBa7(1795e-7g6%,\n+4(.2e63%,-75E-44%,\t\rf\r\r\r.4e+2\r)\f\r ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "nhSL\t(506.89+171231\n,-0Eh2603 ,\n\t+)\r\f-46315393E-12%\t\t\r\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HS (\n\rc\t\fN\t.752,\n-.67E+0%, \f\r\t.3038842728m)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " r\tGbAH+6183781%,643.589e0%,8760%,+.02t6E18\t\r\n\r\r\t)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "V-6\rk.I#,9%";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r5U.bBdAFhDb";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RADPc9\t\rP ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\f\f\t\frGb(\t.307800P77131%,\f\t-2e-7%,-6.0%)\n\n \f\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\r 9Sl(.22I\r\t\f\r\n\r\f93.18%,\t\f\f\f\n-.02917E01g%)\f\n\t\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSL(\t\n2 -0,\f\r.2F%C-\r,.99%\n\r\rF\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r.\n8H%\r\r\fRfgB(\r\n\n\f#-3472\f\n\f\n \n,\f259401S56,89)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "g0B(2376,22,\r93\n\rk)\f\f\r\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "GB(\r\t\r\n\n 5925N5\n ,-14Ms-192)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgb(\r-6374%9,\n.7%\t, \f\fS-.0854%\r\f\f\f\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fAk1Aei";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\rrgbA(\t\r\n \f8, \t\f+669\n\r \n3733652l71231,\f\f\f\t-9e+68 \n\t\r\n\r\n\f\r)\f \f\f\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgSA(\n\f\f1\f,\n+D5309,\f372\r\n\f\r\n\r,-.21719)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\rrgbas\f594\n\f \f,+70, \r\n\n99,\r\f4.77e+1582)\tL\r\r\t\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "CDaeknL";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\rrgb(6e912%,\f\f\f-2e7%\t, \f+.51839274ee680 62C%-\r\f\n\f\f)\f\r\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rgBa(\f\f\f\r\f\r\r 81\fV\f,3,(\f\t\r\f\r+871,+1H178639188e98993\f\r\r \f\n\r\f\f\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgb(\f\r\f\t9-98\rrmP,9\t\t\t\f\nO\r,\n655\t+\n\r\t))\t\t\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fh \t\r\rRgBA(-9,g\f\r\f,+4\n\r\f\f\r\t\f,9\f,\r H\f\r\r.2";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rGbA(\n\t\n\r\r\t\t8355383909E+9% \r \r\n\f\rc,.3395ea%,929.3%, .122993E-3\r\f \fi\r\f)\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nh\rHSL(\t\f\n-784,48037e+)29d97%,+.4e1\n)\r\t\n\n\n\f\r ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \r\na\t\r\n9Efffcb55\f\r\t\t\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RNGB(-41665652\r\n\n\n -51t73-43826\f,O \n\f\f\r+672598)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\r\r\f \nHSl#(\r\f+.7118R82531,.9h\f,\r\t22Eg-26031%\f)\r \n ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "saNdybLoWNE\r\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "fb0g";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#l\taffFAL";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  " \f\r\f\rrgb(+.1399548E+041t%,5465%e-3%\r7\r\r\n\r,-.53877e57%\t\n\t\r\r \f)\n\t\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HSL(237es2862,\t+9753R\t\r\f\n\f\f\r\r,g \t \f\r\t\f\n71441e8d8%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "gbA(49i68a.44E%l,\r\f\n\t\r\ts+9.3%M\n\r ,\t\n\t.2%\r,-.1453)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgB(u-.57E-834%,O\r\n\f\r\r \r04.63e5%,\f\r\r\rh\n+9286.4039980E-u%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "Rgba(.82824Ae35%\r\f\r\n,\t\r\f.7532%,\n\f+54652885E-500%\r\t,\n\t\f\r\nH\r\t231785.9e667)\f\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "gsL(\r\r\r-.453le0\n40\n\n(\f\r\r,+T1%\n\f\f,\n\f.0e76e8861%)c\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r0\f\f\n\n\f\rsIeLverI\f\f\r\r\r\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGb(+08809274,30S\t\n\t\n\n\n\f\n,8 \r\n\r65535)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\n\ti\r\n\n9%\rBa\rh#eP0";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "-trGL(\n\n\n\t\t\n\n7I9804420,0,\f\f2\r\r\rE\f\t)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RGba(\t\f\r\n.78161e-8C1 903% \r\r,\n1.755824%\r \t\r\t,\fT-10a78E+48277296%u\r\t\r\f\r\r ,.3e-2287\n\f\t)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "F+S\fRGBA+4\n\n\n\f\f,\r 522,2, .4e-51\t11386)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\thSl(2.179. (0kSEN3\f.27O7%\n\f,.30e-0%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " rgB(.20%\f,\n\r\f%\r\n\f\r \f\f+.756e593%\n,\t\f\f9E+41% \rm";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\r HK)(\r.0,\t\n\n\n\r\r\f\r41.4024E128B%\nc3859%\r\n\n\r) \t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#OBfeSeLe";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGBat874,\n4,+0305,+440CE+9873 \r) \r\r\f\na\r\f\t\f\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r\nrGBA6.g848%\r\t\n,+k) .19%,\n\n+.68903(g404E\n95%\f\r\n\t,\t\n\n\n-493509e1)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nSl1tBl7\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#cfT\rM\f\f\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

"\nhl(\n\r\r87.95E1\n,\t96059.4929e857FD%\n\f\t\f\r,-34150355.211487226%) \f\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rrgB(\t\f\r+7e39\f\n\n,5\r\f,\f\f-366+46536)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "8joaWmU\fcE";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "V\n0PoSul7M";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " 1UL(.66,\t03.8G0e-18%\f\fF-22%6\rl";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "RGBA(\fT\f\f\rF +.53b33e28%,97g375376148\n17e+45266%, -.74%4,\r+.9\n\n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGBA(\f-6\n ,+9000\r\r\r\f, \f \f\r-6+719GE3)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "hSl(\r \n\f\r\r+3533569.8156 284912,.9% K\f40.20156ue+% \n\n\r\n)\t\n\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\n\rrgb(\r \f-45239%6\n9\n8765)29292\f,5)\f\f\n\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nBI\rmP4E\fu";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rgBa(\n\n .7%,\n\n\r\r\r\n\n\n\n\r-.59422493E-47519%\f\f \f\n\r\f\f\f\f,-.96e513643%\t\n\f\t\n\n\f\f\n,015.6138E2548\f\r\t\t\t\r\n)f\r\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\t\ryeblw\f\n\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\f\r\n\r\r\nhSL(\f\n\f-.3\n\r\f\f\f\t\f,\n\n\n\tc\r-.5M38484250%\f\n\t\n \f\t\t,-.3e0286\t08%)\r\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = ",\rt#Ad2 \f\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "daRkeD\f\n\f\r\t\f\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rRGB(-98\f\n+%327, \f\r+0)\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "a\n\r\n\t\frggBP(89s22Lt\r\r\r, \nu80,60)\n\n\n\r\n\f\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HSL(-.60r919\r\r\r,93f6684%,.3178854e+39424%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f9 #Skac\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "T lNIHtSAGRe+ekN\f\f \f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " isbcB4\f5dtfu- ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \t\f\fr#CeOe";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\rEV\f+8\r\r\t\t\nF8b2\t\f\f#";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "U\t \n c\f\n\f\nlIGhtgOlDENRodyEllOw\n ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rgb(96192e+3%,133e+2\f0\fF\n\t,7 -.812%)3\f\r\t\n\f \n\f\t\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rGB(\n-.5088144557063%\n\r\n\r,\f-.16K184\rue+73%\f\n\n \n\n\r,.738039167%\n \n\n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nrGB(\r +8-0 8\fE\f3\r\n\r\n\t\f,\n-6E99i64,-420)\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\trga(\t.)2e4505%,\f\t\r-.69297917e5+58427% \r \r\f\n\f\n,\r+.9%\n,\f\tR -.89\f\t\fR\n\n\n)\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\frgdb(\n\tf\f+.5e+81%,+.559%\r %\r,4107\n.5%\r\f\f\r\f\r ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r \r\fDL\n\rhsL(+1e-4\n\f\t,\n4.54%,3%b\f\f\t\n)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RGba(.d2399903r3%\t\r\n\n\f,\t2\n\f\f\r\t\r\r\n\f\r\na.35%,-.91\f99%\f\r\f\r\t-5B9.90e864)\n\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f,b(t8m653i556.0%\r\t\tk\f\r ,9m,\t27ceS965%\t\r\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\n\f\r HSlh(\n\t\n\n\rF87253E6911,+739\f-60%\f,6440.9e-9073MB)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#CfiCadk4r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "StEeBluE\r\r\f\f\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\n\r\f\r\n\f\f\fHsl(-.1..%89848E714%,\n\f\f-.76E+210%\f\r\n\f\r) \n\n\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "# Aac\f \n\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\f\f\rhseL(k\r.8EG59,\r 7g\f-.T5A7239E65% \r\f\r,-.3e6k89574%-";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rf7sAlP";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGb(\rO4.n543c695\r,530\f\t\n\r,+9883458)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "n \r\tHSL(4-7028T54\t,-9K\n\r,\f \f\n\t\r+.7768E+8%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "dHSl(3e862\f,+82214%\t\r\r\r,\r\t\n\f\n\n\r\r 4\f\f-.43E5914)\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#u\fE5D";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \r\f\r\n\r\t\f\t\rRgb(2\n\r\f\r24\r,\r \f21\r\t\n\r\rm,5)\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hsl(\n\n\n\r\t\n\f\f.76Em45,\n\n\n +955870%,-T40D368.521R2rE-23%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\t \t,%\f \f\frgB(78261,-171F\f\f\r\t,3511)\t \t\f\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HSLHF-5.4E9165824,190f,5858E+%)\n\f\t\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hs-L(+92.60\n\r\n \f,.9540530%\t\f\n\t,\r\n\n\f\r\r\r\r+U697498%)\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgb-.1\f%\t \t\r,+.00-8%\f,-.869205E19357e889%\n\r\f\n\r\f \r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rosrsho ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
 "\f\f\nHsl(.6287094e57085\f\f\n,.\r\r\r.47e129%,+3K.57259e+6361999326%)\t\f\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#fBBAFB\r\no\f\r\ne\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSl(u.0709,12.g3Gd%,\r0.743-5fe+6%\t\tm\fP)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgbA(\f.5,+78,\n\n1316705,\f\r9\f\n\nV+.499395E-4578.7)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Sl(\r\f \r\t\n1.215344e+88g300\t,7e-59%,\f.386676700943%)1\f\n\f \r ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RbA(2K6341\f,\r 7\n\n54,2,-V55.5e53681s) ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\n\f\f.2B(+2\t,-27,+2#65031)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n \ff\fRGBA(+.82e-57869%.\f,\nT9e24154313%4-0E8%,4E+6)\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r\rHsl(+.45505385E+27\r\f\n ,.06C3a0e-2O7%\r\nE ,\r-462K6e+2u\f\t\f\t\tl\fM\t)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RG-.33K%,\t1\f\f \r\n .79%,.3F7E82%F)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rb(+80m2%,b3132.0h%F,.1fe+l-586%\f\n\n\n\r\t\t-)\t\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\n\f\f\f\nhsL(+615.649s2 \n\t\f,\n\n\f\f\f\r\f\f\t\f329.6%\n\r,\n\f88.5E-5721378)446%\n\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Slb(F \n\n96.4,-9d.u721%,002633%)\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\n k\t\t\f#34FaACf \f\f\f\r\n\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rGBN(\n\r \t\n\t+954,498166M\t\r\n)\t\r\f\n\r,\n9 \n,+68\n \n\n)\f\f\n\n\r\r\f\r\n\f\f\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\t D c\t\fI4CEdoAb\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#RGbA(.V3752u8H%,04574%,7.\r88E6\t\n\f,\r8.4\f\r1)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "HL(\n174-7e43406U719\r\n\n\n\n\r,\f\r\n\n\n -.376795E100107%\f\t\n\n,04541.1898%)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "1GBAi\f 890GH97g\r\r,662566)31\f,\f+0,\r\f\n\t--.8 \n)\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rB\r.FOB";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "H\r\r\fLVpsLrklE";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgb(.88316976690e+6%\tC-12175.8%\f\f\rl\f\n\n\r\n\r\rV, -8.6%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\ra\fmBedbIuHSeaGrN";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\rRGBA(\f\t\r 7.0663E0,\n\r\n\n+.87e-6%,0I276e-4440%\t\t,+.34\r\r\r\r\r\f ";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\thS3(\r\n\f+222.3)e-4368141\n,1.0%\n\n\r m,49705%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rgba(\n\f\f\f+.971103%)\f ,.358%\t\f,-0.022710%,\n\r\r\n\r+.560e84798L\f\f\f)\r\f\n\r\f-";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f)\r\n TSL(612216.1e9846\f\r\r\n,+254896.94%\r, \r\n\n\n\f\n \rg\n\n1e6509726%\t)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGba(r-55516f059-\f,+8\f\n\f,+4%\f,\n\f \f\f\n\r\r\f\t-8)37m-";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " CdbEkkdfVe\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "e\n\r\nO\f\n \t rgBA(-17l\t\n\n\n,47B\r,d\n \r\r\f \t\r\f314247E\f\r\f,.18)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "+s(a-813\n \n\f \f-8B.162%\n\r,I\f\t\n3213%\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RbaU-22,\f \t\r\ft2,197G322462671 \f,.4)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "5\f\t\frGbr(+7,M\f\t\f\r-14\n\n\n\f\n\n,\n\f\f2\n\f\t)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "ORnfLow)rBLe \f-\n\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r2\flIg\fGTgGRAy";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "d3RKkhaKi9\f (I\f\fg\f ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\r-M\f\f\t 6\tRGB(-0580563,-576461594,T\n \n+5653 \f\t)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rg(\r99\f\f\r\f\f\r \f,6,789)\r\r \f\f\t\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\tT\r#NB";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgB\n\r6 \n\f\n \rh\t\n\n\r\f2\f5)4)9u17-68258\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "pTO\r\f\f\tm\r3.Rd\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rgba(\f\r\n\f\r\n\r\f+.30974% i,684e2433\r\r\n,\t\r.2E4%\r \f \r\r,\f.48690)769\t\n\f\f\f n\fS";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\t\n\nRGb\r\f +28009\n,-585,\f7,.920345E6737\r\r\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HSl(\f-7-76\f\r,9a75e+79%,N\r\f\t\nc\t \t\f\f7648%)\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t \n\rRGB(.1E-549%,\f\f\n\n -.b4651%,\f \t\r\r C\f-.958425E+89%3865%\n\f)\f\f\nI";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "3s\rL6";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HSiF(-30862e5916,861e6%,\f+s0043E+7188t73867m)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSl(-C8f\t+O.3o8E-08%,\f\t4l13%\rA\r\r\r\n)\f\t\r ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rGba\f\f\r\f\f \f\t\r\t\f-17217.37954e+5%,\f\f\t\t+67722379.943e-77394%\r,\r\n\r\n\f\tE305351439%, .6e+8)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\tkgbt3172,\n\t \r\f\rL\te\n\f\n\r+2\t7-\t) ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rg(-40,ef-6138\fL-2CT";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
 "rgbA(8.45%,+01.836%\t\f\r\r\n\r\f,D+8962444E-78295% \f\n\n\r\f\r\t,7786k.4)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rgb(\r\t\f\r\t\t.38+F762785%,.9E58%,\r66E+394104681%\n\r\n\f3\f\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "VgbA(5\n\rk2%,+.43359e-250% 8)\n \f \f,6987K420.743896E-99%\r\f\r\r\f84E9\n\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r\f\r \f\r\r\rrba(+80499%\f\n,\n\f\f\f\n-.64911e94095%,+7541322.43\t5e15%\n ,.220e-4847 \r\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\nHsl(\r\t\f\f\n\f -51333202872, +.47848300E-576294%\f\n\r\r\rg\n\r9%\r\f\n\f\r\rH\n\f\r)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgBa(\t\r\f3,\t2479\r71,-7 M\f\f\r\r\r\r\r,4516DC79E+646 \f\r\r\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\t\rBLaNheDalMONdd\r\n ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rRGB(8\n\t1\r\f\r\f,12495U6,. O8\n)\r\f\n\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgB(\r\f\n-2\n\f\f,\n-.5991554%\n ,P\n+.33054020E5%\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rgb(#.5223136\r94PF1754%,\f\f\t\f\n\n g.99%\f,. 3%) ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HSEsL(\f\f-.76499E-06,\n\r+.3% \r,T591e+7986%)\f\f\t\n\f\fr\f\r\r ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  " \n\n\frgb(.3e4%\t%\f\r \n,\n\f\f\n\rk\r \r\n\r-.0484%,85998.2D508E7610273% \r\r\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
 "HsL()\r T\r\t\r\t\t+.6R\r\r\f\n+.21198E080%\f\n \r\r\n,\r\f\r-8.44.60%\n \t)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "H(\fn\r\r\f\f\r.14C406+6\n\f\f,+.8%\r\t\r\f,LO\f\f\n\f+7.24%)7\n\r\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hsL0(\r\f \r3\fr\n.2345\t,\r\f\f +99.2092%,.84E758%)\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\n#D2f5-2G";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\r\r\r\n\rRGB(\t\f\n\t54,\f\t\nu\r\n+,3220, -72H8)\t\f\r\r\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\t\f\fhaAsL(747401,708812709%I\r\fe.3E20%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "lLaV)n4EHRE\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGb(.875%\n\n\nHr.%,607%\t\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\r\r\r\r\n\n\n\nRlgb(.2e-50057%\f\r\n\r\n\t\r\t,\f-06.97786e-3%,-.5g8%)\n\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t\f \t\n\r\f\t\rrGBA(-651809758%H,.462o\n\f\r\r\f\r\f\r\f\f\t,+6837%,\f\n\f#\t\r.4E32211)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "4D arKSlAaTEue";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \f\f#0cBnEkAd\r\n\r\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " 6\r\t\r\t\r Rg#(54,\r\f\f2\r\n\n\fF\r\f\n\fm6\r\f\ta\r) 9, \t\t\r\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "hSL(B\r\f\f\r\r\r)869935T089.709,\f\r\t-.5 +00%,\r\f\f\t\n\f2179621E.7222%7)\t\n\n\f\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\f\n\r\n \fRGBA(\n\f\r-2%,\r7E-1%\t\t\r\n,39703e-495%\f\nL\n\t ,\r-.541E48)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\thSL(-.840,4111576\r94.2e57911(7%,\r.4%)\n\r\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "gb(+.872312%,-e824631m4810B8484%,+76449 6(40757369%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\n\fHSL(\n+.H2E223 \t\f,340Hl135d76MC8E4270s1%, \f\t-.P3815129t%\r)\n\t \n\r\t\r\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\t- \t\rnURu0E";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HsRL(\r\t\n\r\f\r-9e-\r0 ,Ul-.5S5894432bBe+7%,d\f-.686956%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rn\n\f\r\f\fa\f#efFC4E1hB\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\ft\r\t\fRgBa(\f3\n\n\t#\f\n\tL\n3.9870E+74%,-23576.96%\f\f3,S44E-6,\t\r\n\f\f,\r\f \f\n.97%46)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rGBA(\n \f\t\rm\f\r-80 , \f\r\r\f+185182222,-00\f\n\f\r3s\t\f\f ,.0206\r\r \n\r)\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "hsL(\t\r\f.186e375\r\f\t\n\n \t\n\r\r,261.4E+86555343%\t\t\t\f\r5\r,\n\r\f 2.1k71E51243%)\f \r\n\r\r\n\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nrGB(c\r\n.32668%\r,74865eRA%\t\f\t\f(\r\f,d9Im%\n\n\f\n\n\f\f\r \f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rhSl(\r-9858E-53\f\n.6651+0209%,+0305A4)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgb92\n- \n65371550 \n\r\r\n\n\r\n,\nU\n\t445+)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "hsL(\n\t\t+9653E+486,\r \n\f\fT\n\f\r+5.54628ER+3i334168%c\r\f\r\r-.e5E-82U \r\r)\n\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rgba(.6%,.511e-97093735%\r\n\r\r\n\t\n\f\f,+7E65%,\r\r\f\n\f-8250ce2)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HkSL(\n\t4e-8752N8E\r\n,8\n\nhn\n+.740%\n\r \n\n,\f\r\f\r -G88872P)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSL(-.68E-0, \n \n.139766664B76E979844%\n\r,82.77E0975557507976%\n)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "gHVfslTwT";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgB(-988R7\r\n\t\r\f\f I\t ,\n\f\n\n-345\t.\t\f\f14146599V\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t7\fGBB(80.9067,l \n\f\f+8E-6742r0%\f\n\t\f\f \r\n\f\r\t,\n\n\r\n \r47318.6470e82972%,.26)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGB#A5T\f\n\r ,\n\r\n-069925H.64%,-146946%,\r\t9.70)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "u\nRGB(\f\t\r\n\n0,+6, \t\n-22)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\r\n \rgb(\fk561250079\f\n \r\n5g,G\f\f936,-8)\n\f\t\n\f\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

"HSl(\r\na-46397268757,\f\r \r+.28%\f\t\n\f\f\f\f\f\r\r\n\r,-.3968%\f\f\r)\n\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rgb(\r\to5616m \f \n\n\r,255,\f\f\r-32.3I1\n\f\t\n\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSL(.3EiB108\f,.65%D\n\n,\f -.6%\f\t\r)\fe\t \n\n\f\r\r\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\n\r\frGba(\r5,62707\n\t g\r\ra\f\f ,-05,-2s1282e5396)\f\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

"\n\f\r \nrg(\f\f\n\r\f\n\r\n\r\r\f+89\r,\n-8068093,7\r\r\nO\rk\r8\f\n\f)\t b";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\r \t\t\nrB(+D15H% \r\r\n\n,9656.n1E-15%,+7092%\r\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

"%RGbA(\n0.070%\n\r\t\r, \t \t-67e-1%,9e+08116429 %\r\f\f\r\n\r,42315.8e-2) \n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "cEVC4 F\n\fF\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#Mc1u\tH\f\nF";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\n\f \t\r\r K\t\nhsl%3Oo45\r\n\f\n,-N734498f13%\t\r, \t-1M7.0764E8248%)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "1# \n#DEEF1 \r\n\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hsL(7E333045.565E254563061+057\n,-.1296e-i42261%,\r\t+.80%) \r\f\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "WhicM";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "ntIReWH3i#n \t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\f\t\fRB(.36363E-6%\f\n,\t92C0.01cu5%,.6-55%\f)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "RgB((\n\n\n\r\r \t 4\f,87374S 17598,566876\t\f\r\r\f\r\f\f\t\t,\f +.le6)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rg\rRGb(-46I0495547,82\r\r\rH\r\n\f\n\f2\f\r974371\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "pAlevirlbtrLLd";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\fRG(+4159\t\f\f,\n\t+5\f\r\n\tr,\r\n%\r\r\t-S44382\f)\f\n n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\rLgb(\n32968M561.A00E7),.567446)6e8751922402%\f\f9\f\f\t\n \n \r,\r\f\r \r88267%)\f\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RGbA(\f \f\r\r\f-18661456968\tU\r\n\f\n \f\f\r,\f\f\r\r15742,\f\f9,U\r082e0)t\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGba(+651,\f\r\r\r\n\t(82\r,39428,\n\n\f6\n36T(6257576e-330)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \n\n\r\n\r\rrgB(\n\r4717N\n, \t \r0+1159414\f \n\r \f\r\f,7\f)\f\f\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGb(\r\f \tRh00884e-90%\r\f\n\r,+.sL2e 0%,\n\n \f2+7.180E98%#\rS";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rgBA(\f753\f\n\f\f\f,\n\n\r\f\n56 \f\f\r\f\t\f\r,+136\f\f \n\f -.43681654662)\r\r\f \f\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \tDOS\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\fhsL(.4I,.09i2563943%\f\t\n\r\n,60125.6151555%9204%\n\fo8\r\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\n\rHSl(\f-1O264,-.7E+923%,+.4%)\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "PtHS#L+\n\r\f\to.3\n,-1907%\n,-m9882%";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgba(\n20820064\n \r\f \r\n,+89a726227,+1145700\r,-.10\f\t) \n\r\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Rb(+.2P29g%,.5e-29%6\r\n,s9848387E34%)\f\f\f\f \n\r\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "SL(\n\n\f\r\r\n\r+9.4919e6 ,\f\r\f\t-.720106E-058%\r\n)\r \f,9\r.8E110%)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \tHsl(a80.2,.655227S%\f\f,.93751e+021832%) \n ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\ncRGBA(-1,523794\f,\r\n 00204, +86145030091.46)9";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fa\r#EEC1dD9\nrhE%2D";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGkA(44SR2,-792802,\n\f\f\rk\f\t-00899)\n\t\f\r\r\ns\n\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\nHSl(.1\t1\n)\r,\n379357496%,+436703037.23% \f\r\n\f\f\n\r\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r\n\n\rRgb(\r\n-2\t%\f\f\n\n\n,.8537E\n596%,\n\tE\f\n\f\n\r\f\t\r\r19896t97.55564e+9731074% \ti\f\n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \r\n \r\r9\nRgB(-.238e37% \r\f\f,.932%\f,\r\r\f150%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rhL(4E827, \r,\r+0.160E59%\fCS, -5R750457%)\r\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  " \frgBA(\n\n\r\t+8621G628,\f\n\f83 \f \n\r,2001302\n\f,\t\t5H9\r\t\r)\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\frgB(132h941\f7\r,g81053416c82,21)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RGBA(7 .291E30195%,\n.\r\n\f\r\f\n-070152038625E1%,-668e-71%,\n\n\r\r\f\f\n6295.2u+156395)\t\f ";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\ntFFSDfeA\n\n\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGB(.6\f\r,\r.5e90%\f\f\rM\r542635EK13702%\f tF";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgB(+A8%\t,\f\f\n% .911%,# .42%\n\r\f\f\n) \f\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGB(159097%V2182U%,7E71%\r\f\r\t,827.0E08257%\r \n\r\n\r\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\n\tk.gb(.72560+06A%,\f\t\f\n\f\n53.5s-20% \tL7\n-840%\t\r)\n\r\r\f\n\f\r\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "IgHts-lMon\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "k\rRgBA(+I2692,\r\r#\f\f\rf+7G07336\n\t \r\n\r,+73h0r14 ,\n\n+548,42)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "k\t\r\f\frg (+S.8S8%\r\r\r \f,N\f\n\n\r751E-49998%\n,\n\n#.5g9E5%\r\t)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\frGBA(\f+3I69,\r\r00,523\r\f,7Ou.0)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGb)\f \n4\t\r\f\f,\f\r\r\f\n\fd7,+94315\r\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGb(-C2,-3n,\r\f\n114643)C\tm\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "1\t\f \n\fGCCASsH";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rRGbA(+7,\f \n\r \n46U+86\n5\f\f\rH\r,\t\f21F \n\n\f ,.2\n\nV\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "G(+.9686C5133%\n ,-.7e-81M,+2o9e-40s228%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Hsl(671.9704E+97417259436,6349.1E642%,+N7esrB50 \n\r\n\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "PceIToFtred\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "s53gd7D";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rGba(\nT85d8E5760310%\f,+.046935E6%\n\n\r\n\tG\t\f\n,-.7110E-9%,\r-63.62e9\n\f\f\n\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
 "RGBa(-8h\r\fE\te,\r\r8\n\t\n\t\r\f\rR , \f\f\t\n \f\t10167178\rt\n2\n\rg.00)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "HSL(\n\r\f\n -65e+28 ,91698(71.560e5N%\r \f , \r\f\rT \r\r\f-.7\f\t\r\n\f)\f\fd\n\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\fRg2\t(\n\t\r\n\f\f \r \f\r-56215i1, \f+6190264\r\t\r,\n\f\n \f\f-5270796140\r)\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGcA(69503,73\f\f\t\f\r\n\r\n5,+\f,.6ei558898)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSl.1S498,\n338801n81%\n \n,.E814259E+83%\f\t \n\n)R\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgB(-.2e487%,-.5-64507632%C\t\n\n,t7601%)\n\n\f\r\n\n\n\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \n\t\n\f\tFMArEooN";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#21\fge2";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RIGbA(211,1564069\t\nh\r\r\f\f\f,\r\f\f\n\f \n\n\f\t+4,-9\f\f\n,\tF7099.62945672\r\n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "bB";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r1\n \r\r\f\t Rgb.%,K.494073%,\f+.,5-1925924%)\f \r\n\t\f8\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f\f\nGB(+7.445e+02% \r\n\f\f\f,\n\r\n\n \f\f\f.269047E55534822%\t,\f\n\f\n\n\f\r\n\n\t\n1.6e3%)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HSl(-.099106\tK,\n-564b29%,3E01l75803%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fSlTGrAY";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nB\n\f\f \r\frGb(2460581824,2093\r\t, \t\rg\r\t\f\f \f1\f\f)\f\t\f\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\tEF\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgB(.9\f \r\r \n\f\f \n76E-7%2,+K458U044e-4%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " #Cd%bk\flB";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\t \n\r0#EdBbcf";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#8+f#b9\r\f\f\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RgBA,(-.3%,3585746.66777E9% \f\t,951.1642887%\r\n\r F,\n\n.1192670eU+41829727 \f\t\n\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "DRk\roRmh";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\n\trGK(63,-58\n\r\r \r2,#5\f\r\r)\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HsL(\t\n\t .627-1362,(\r-.156%\n\t\n\n,\f\f\f \f+.33%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\t#56Fkad\t \n\r\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\fP\t\n\nhslA(.7198297GE77.,876183.42E.13G372652%,+52508.9S09Ne678%\t)\r\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rIba(\n\n\n\t-.77832658% \n,\t\n\f+244697642e9980548698%.,.6141%\n\n\n+,.8\n\r\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\t\n\r \r\nN\rhsLO(\f\r -.353945e+252\n\r\f\t\r\r,\f\t\r\n\f\f\r-.03c24666933%\f\f,-.7%)\n\n\f\fu\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\rgBa(\n\r \nV\f+88.8040%,-g445E6%\t\r\n\f\n\n,\n\f\n-.0E+0%\f,\t\r-21\r\r\n\r\n)\n\n\r\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\t\t\n\nHsil(\n+46088414915.902508E-2152 ,\r\f\r\f\n\n \r,\f\n\n\t.4M17550E-41%,\f.156077112%)\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\f\f\rRGa(+6479894,-8715,-80,2E06c\t\f\n\n\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\f\f\r\t \r\r\nrgb(32--79854%\r\n\r ++7352%\n\r,\n-.9ES01172)\t\t\f\n\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGB(224215L\t\t\t,77r\n\fm \f\f\n\f,-2)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSL\n\f0620.8,\f.G60 \r,\r\t-0ne6%\f\t)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\fRgBA(\f\r\f\f03f0562,\n9\t+967,\f\r 78\n\ng\n\f\f\rD\t\n,+.0)\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "Hsl(36\f\r L\f\t\f,77492.65% ,\n\t.3791570e4b9188178527%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rhOS\tHeYd1W";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t\r\n \f\n\t\t\nGbA(\t\n\f\f\t\f\r\f.819e-7e695.9H851%\r\f ,\f\f\r\rN\t\r.096%\n,\t.33847%,\f\n\n\r\f+S83857733\r\f\f\f\n)\f)\r \f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\n\fr1gb(\t\f\n\f.5%L25177E9%, \f-\r1n59%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
 "\fhSL(-91500E8670423o,551E-7%,\n\r\r\fo\n\f \r5243H37336.4693644%\r)\r\n%\r ";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSl(.07818E-84825 , \f\r\t\n+.0486 \r\r\t\r\n , \f.5%)\t\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n#FK2\f\r\ns \n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r\f \n\f\t1 \f\t\rrgBA(369381788\n\r\n\n\f \f\tg,87447\r\r\n,\r \t-4,+.7441701e-5\r\n \f\n)\n\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\f\t\n\f\tHoSTwHITe";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSl(+.9602E0,\r\f\t920519546(29%010e5c31%,.44%)\n\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nRgBa(\t\r\t\t\f1203\t\r,+26, -90\f\t\r \n\r,-.367452e-937E)\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\nIn#ml09RaD\f R\r\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " rgBA(\r.85%,.26E+5i08%,\n+.7E7%,+.A557349\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\f\n#k..HItfeSmOk";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n RGgb(-U73P75728 \tg \t\n\f\f\f\t\r\f\f\r\f\t\r\tK4588\f\t\r,3)\r\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \t\f\rhhL(.81\t\n,\n\n.5104%\f\n\t,\r\n\n\f% \f\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "%gb(E\n +9\r\r,\n\r\f\t+03,951c42341\n\n3\t\rI\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t\r\r\f\n\n\f\f \nRgBas\r\n\n\n-746195% 2\f\n\t,. 58531e+6t42556%,k 1\r\r \n 3%\fh-.23e680)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "HSl(\f.86835450E4r2\n\n\f\r\f\r,+.2592E370515% \n\r\f\n, \r\f+54.3E+04765%)\r\n\n\r(\n\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\t\n\t\r\r\fn\n\n#BDEh";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rGB(\n-.54799395%\n\f\n ,\f\n\f\r\n\f .14001119e+3% \n\n \r\r\f,\n\n\n\r\r\r\n\rF3%\n\n\n\f)\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "8fd2RC9BPl\ne\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\nHSL(\f2.695793mC,s\r\r\n\t\r +.K2E-7%\n,.55G348EU%\r\n\f\r \f\t)\t\r\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "S(936.+77f581\n,\n1E-6%, \f.40EI1%\f \f\n)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "Rgb(-.321689101% ,\r\fo\t\n\f\n\t\r +.352196e+3%B \t \t\f\f\n\n,-1EB+5606920%\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "hsl(0873.15E+1724734593 \n\t\t,\n\t\n\r\r\n\f\r.)27E196%\n \f\r\n\r \n,\r\n\tBi79e+6I5215%)\t ";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\fRGbA(\n\f\n\f\n \t \n \r 9e+72693%\r,\t\f\r\f7%P,490%,296D8345.11E0\n\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#bfDe7#EFDe\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "%RgLBa(\r\r-57563756\f,343e\t\f\f \n\r\fk\r,+28\r, \n9\r+6.5,)\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\f\n\fRgBA(+M72%,-.3E8%\r\f\t,-29.6274)5%,.F00\n\t\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\tHsL(\t-29.76 \f.3d87265+E-13\f54%,+59E1625%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hsl(\fm\f\f\f\f.9C5,.78eV79409%,\ts\f\n\r\r\r -.46E651%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rSD7e";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "AQlamoARInGE\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "dYaLBlUE";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "RG+Ba(-420m12029\r52\t\n\f\rh\n\t,7849, \r\r\na+0\r \r\t\f,\rK40)\n\t\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "rgBA(91600922967.083e-K%\r\r,\ru12E)8633%,-.69%,\rP\n\n0633.9630e-17D\n)\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fhs(\f\r0P99E-794,-0(56593%,.7E7e%)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "DA7(G";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\nrgB(7570e522%,t2883760910%,\t\t\n\f\t\f\n+18785.7130780%)\f\n\f\n\t\f\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#\nrgbA(+,\r%+\fG\n \r,82i,.03\n ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\nHsl(+.70307e+6,\n83K.659S294%\t\r\f\n\n\r,\r\f\r-5%)\n\r\n\n\t\r\r\r\n\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " bg-b(\n\f\f-.6%\n,\f \f\r16.9.28773602614\f,.73%)\r#\f\t\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r \f\n\t\r\n \tRgbPa(342\n,-8093\n\f,\r\r\n\f\f +1\t\n\r\f\f,\t.002125326026\f\t\r\n\r)\r\f\r\r\n\t\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fSL(\n-.33,\f\n\nn.585%\fD,bb.20% a\r\f\f \n\f\n\r\fdi)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rGBA(-326023819\t\f\f\f\r\n\n\t,65543\n, \r \n\n+11\n\f\n\f\r \f9\r\t,\f\r\r-.216885E285B)\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\tHS,l(\f)8E+\r,243297%,\n\n 7\t\n\t\rS15%)\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\t\r\n 6\f\f1bC7C6Cc\f\n ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t\r\r\nrGba(\n+4Ef \n\r ,\n.524099E-9u57%\f\ff\f\f\n ,7534%,9.21+50 o\r)\r\n \t\na\n\r\n\n\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \fRgb(\n\r31208A \f,G3\f\f\nC\n7434\f\nd\r\n Pd\t\f\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\r\tmIntrEa\r%\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \r\f\n\n\nRgBa(\f25709\n,-49\r, \r46023638\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\n6\flLaVEnVErBPLUSh";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f\f\r\n\r\r\f\r\nrgba(\n\r-.8%,\t+.08\t\r\f\n\n,\f\n\f368.96E257956%,\f\r\r\n+29.1e51194508M14)\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSL(\n\n\t\n\f2841975.8e+%8G2\f,-0E9010%,0407618e5%) \r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\t\n\rH6sL(\f\n\r\r\f\f+.l73E-8862479669\r,0eu45% ,.3%)\n\r\n\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fHsl(\f\r\f\r-U.43\f\n\nF\rU\t\f\r\f.36%,9E+6-%\r\tG\f\n3\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t \fRgBa(\f\n\nS\r\f\f\n .4\f674e4% ,\f\n\f+.29%,850E2%\f\n\f\nU\n \f \f\r-7.9737E9\n\n)\nC\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "d+a4rkkSLAtEuBLE";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\t\fFoRsToNG\nn";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\f\fDorcHd";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\r\ftRgb(\f-0.2335231e05907%\t,\f\t\f\r\f +.2244e424%,\f\r\r \r1697E18%\r\n\r)\t\n\t\r\f\n\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#adE#P";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "bab\f\n\fK ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "ff91Uc,d";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#O\nG0cCS\r\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "MEdIUM.VnOlRND";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgb(5,,\n \r\r\n-0052449\t\f\t \t\tU\t\r.13\n r\r\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r hsL(\f 873E+507777 \r \t\n,+.56628831OE+0%, 356V%\r\r)\r\n\r\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\frgb(\r\f1,-59i664,15\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\f\n#bPoFC3\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fhSl(26.3543327\f\r,\n\r\n\f\f\n\n\f\r.1%,+.5)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t\fhgba(\f+4\t\ng\n\r\f,\f\t\t\r35862, \r\t\r\n\r-7741994\t\r\t\r,+75.73522636e+4967) \t\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n\f\n \r\rrgBa(-2440991812,\n\r+3078938\r\r \n\f\r\f,k9358\n\r\t\r\f\n \n\r,-0.6)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "\r rgB(\f 3D55%\n\t,-62.582821e+2%,\r\r\f .68214E+8%\r\t\t\r\f\f\r\r\r)\f\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "2IFl0iGdtpInk";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\f \nI#adTKedF\f\r\fH\n\f\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \r\frg(+.85446e+%,c93625.33%\r,.538982d60%\f\f\t\n\f\r\n\f)k\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSL(.3001e+60158240\f\r\t\t\n,754,74.61%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGba(+79 ,-87322339,\r+H6\f\n\n\r,+8i6219E7700)\nd\f \n\r\f\t\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rgbAs0\te76703662\r\t\r61\f,903,-.V83048348e9377r600k)\f\n\n\r\r\n\f\r\f\n\f\r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rRg(+5475546.7166464e-288335%,\f446.29E07%\n\f\t,\r22351334.2%\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\n HSl(\r\f-0V92224Ek0+7,\t\n\n\n\n\n \f\f\n+6eH646080% \n\r\n,4476G5E+017090613t4%\n% \f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgbA(14B7k25-4,913\n,-01(380 ,\n\r\n.07e99255H4)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\t4\f\r\n#eAAbBe9dg";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fAgBa(\r\t+03,)6775114,-172,-.#i7937\f\n\n\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGB-29908)F\fK\t 2\rb\r,\rfU\r+80\f)\t\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\nRGb9e8,5\rR\f\n\n\f,\t L\f\rK\nf\rC60)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hhl(P,07326.2E+182%\r\t\n\f,\f-17800DE+8%\n\f\n)\r\r \t\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGB(\f+.6%\r\t,\f\n\f\t\n\r#\n\f\t\n383474%\n\f\n\r,l0%g\r\r\f\r\n)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\n\n\n HSl(O\r S4.0955775g \rA\n5.61%\t,.O4e296o4%)\f \n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "g\frgbA(\n\n\fd3%.29806e+839597(20% ,\r\n-.0803e-70978%\n\r\n,-.902)\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "sL(\n\t020eFK32F,7411.4M6607aE-3957%,9.7%\f\f\r\r\n\t)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\fhsL(3e+84927995258,e14(l.91%\n,+011%E)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

"HSOL(\f\n \r\r\n-.4269E4075,\n\f\r\nN7e-19%\r\r\f\n\t\r,\n.354792446%\f\n\n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " #%dAEDf";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "rgBa(7.4519\fe43%\t\t\f\r,\t\n \t\r+2e17901E%,\f\rm+.73056%\r ,\f+.e1e3)\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "KEc.VA";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HsLn(-.70848b4P8,-.91e5%,-212110e110698%\n\r\r\f)\r\r\n\n\f\t\r\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f\rrgBa(.3E+813M9%\n\n\n,+.030E+57954%,+34321E308916%\n\r\f\n\f\r\f\n\f\n,\n254E81106D785)\f\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#Il5";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "d\t\fFChiD\r\f\f\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  "H#l(\n\r\tO178I55462e563\f\r,+31801.34%,-.6E+7374386Bn8%\n\t\r\n \r\n\r)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \r\r%\n#cBi1e \r\t ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n9\f\f\nN\n\f%\nGAiN7SblO\f\r\f\r\tD\n\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\r\t\r\ri\f \n\f\tHsL(\r\f\r\r\n\t\f-05.4\r,7.5%\r,-.265%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "urlywO\roD\n\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\f\f E\r\n\rHSl(.6E-6003,\t.00723(15E2%,-0.156EF96%\t\f)\f";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "a";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "C9\tb";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RGA(0344,50m563955B3,+o63\n\r\r\r,.642272fe-14o\r\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\f\t\rku\n4\nb\n\f\n\rYellOw6geEN";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rrO,C%A";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgFB(\f +503E551%,.501597%,.K7%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =
  " \n hL(+.0,R8E+04002719535 \n\r,\r%7128202%\f\n \f\fUUP)\r\nN\f\n\f \r\f\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "RgBa(\r97580\n\f\rS\f\t\n\r \t,\r955\t,\n\n\n\r\f\f00c,\n\n\f\n\n\r\f\f\r\r\r45.32158827e098007\n \r\n)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rgbEA(\f\t.%,\n\r651.24559455571%,.064435%\r\f-.064329)\n8\r\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "#)#Becd7";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = " \n\n\f\n\t\nhsL(+719.22202E17\r0\r229,\t-0e-9F204%,\t6.834%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f\fRGBA(\t\r\r\t \t-0,\r\t 3 \n\f \f \n\f ,\rK\r\f\r\t4775\f\f,\f V+.66\r0\n)\t,\f ";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f\r\t\fT\f\f\t\rrgB(\n+9708e\f\f\r \r\n\f ,\n\f\f5a \f\r\n,\r\r\t\r\f7056\r\t\f\r (\r\n\t)\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f0\t\f\nrgba(M D +23\r9952848,750846063\n \r,\r\n\n\n\n\r\r+7,\fi\f\n\r\f-8785+788\f\n\r)\t";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "4s(fS4-2";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RgB(+1642217E613022%,-4177\r9.7684e+4%\t\f\n\n\t\n,+6E11539126%\f)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "hSl(\n\n\r\r\r126\rm8537A\t\n\t \r \f,\f\r\n\n.648e+73\f\n\f\f,\r+71990.47779037%\f\f)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "gba(+6+821,C\t74732,U+7544, \n.0092697412)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "RBa(+.4322792%,-5.96%\n\t,-584469%\n\f\r\f\t,\r.52598863\r)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HSl(\n\t\n\f37235Ec6577,01e4184577%\f\n\n\f\f,.4h4E457994818%\rm)\n";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGB(\n+195D652+,#\f\r,4i3)\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\t\t\n\n\n\r\rrgB(+41\n\f\f\t\f\r\r\r\f\f7,\f\n\r3694 \t18\n\n\r\n\f\r\t)\r\t\n";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\rRGBaf6g\t\r,-08r95\t6\f\f,E4e-4928\t%)\r\n\n \t \r\r\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "1I#A(bffAa";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\f\n\r\tsl(5685e0237.560032\r\r\f\t\t\rm\t4\n\n-8.9E-617392%,\n\r2ec063971%)\f\r\f\n\n% \r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "9\fargbA(-c2\f,-031\r\n,1R3,\r\n\r \r \f255081)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "rGba(-4306%,1E2%,\f\r-I1789137%\n\f,\nl\n\f\f\t0248-E+0142)\f\fI\n ";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\t\t 4\r\n 6aD\f\f\nd\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "\rrGba(\t\f+74123\n\r,\n\f \t\n\t7639276\f\r,2c-36 , \f\n\n\f\t\t\n\f2.712370E+7)\n\n \t\n\f";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "D\r\f\tHS(\f\f.4\r71F96ne+L71, 74344117%\f\t\n\r \n\n\n\t,.54948%)\t\r\f\f\r \r";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "\n\r\fRgBA(-34\f\f \r\t\t\r5204215618,21.0\t \f) \n\n\n\r\n\r";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "HsL(+V.I83962PE-088,\n-.67e312%\r\nL\f4\n\f,-.1%)\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = ",\n\f\f\t\r\nHst(.9070628771839,.1%\te,-.7E43%)";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item = "hSl(6627.94+5512E-8885346992\f,\n\r\n\r-.%,-152168362(5.64%)\t";
if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
item =

  "rGBA(.dl67%\n\t\n \r\t\f\f\r,+.F-43733e+66603598%\t\nS\t\n\f\n\r\t,\r\f+.82%\r\n,978e20994\f \f\r)";

if (ColorValidator.ColorToRgba(item) == null) {
 Assert.Fail(item);
}
}

    [Test]
    public void TestColorToRgba() {
string item;

item =

  "\t\t\t\n\n\n\r\rrgB(+41\n\f\f\t\f\r\r\r\f\f,\f\n\r3694 ,\t18\n\n\r\n\f\r\t)\r\t\n";

this.AssertCssColor(item, 41, 255, 18, 255.0);
item = "\t\t\t\rhsl(\f\n \t\r .641\n\t \f\r \r,\f\r\r\n\n\n\n\f0746.7%,.9%)";
this.AssertCssColor(item, 4, 0, 0, 255.0);

item =

  "\t\t\tHsL(\f\n.173e695815062\n\r\t\f\n,\n\f.258700572E+2981%\f ,\f-743875643.1586656220%)\r\n\f ";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\t\t\n\n\tRgb(\f\n\n+3690,\n+060,\t\f56)\f\n\r\n\f\f";
this.AssertCssColor(item, 255, 60, 56, 255.0);
item = "\t\t\n\f#bEbD";
this.AssertCssColor(item, 187, 238, 187, 221.085);

item =

  "\t\t\r\rrgBA(\f\f76658479\n\t,-36473\r\t\r,-9\t\r\r\f\r\f\n\n,\r.032E+3500133\t)\t";

this.AssertCssColor(item, 255, 0, 0, 255.0);
item = "\t\t \r\n #6aD\f\f\n\t\r";
this.AssertCssColor(item, 102, 170, 221, 255.0);

item =

  "\t\trgB(8e490788187833%\r\f\f\t\t\r\n \r,\n\f \r-69e3756909%\t\r\n\r\n,-.0997%)";

this.AssertCssColor(item, 255, 0, 0, 255.0);
item = "\t\n\t\rrgBa(+0,-2 \f\f,-0,\r.4323393850\n\r)";
this.AssertCssColor(item, 0, 0, 0, 109.64999999999999);
item = "\t\n\n\n\r \tRgB(\f899934.2E5533277121%\n\t\n \r,45.4%\f\r\n,\f-13%)";
this.AssertCssColor(item, 255, 116, 0, 255.0);

item =

  "\t\n\n\fRgbA(-.48582300E-62%\t\r\f,-8245e96%\r,\r\n\f+1.7111%,+4.8e122445896809)\r\n ";

this.AssertCssColor(item, 0, 0, 4, 0);
item = "\t\n\nrgb(\f\r\r\t\r \r+988509,1\r \r ,-5)";
this.AssertCssColor(item, 255, 1, 0, 255.0);

item =

  "\t\n\f\f\nrGBa(+1.1%\f\r,+.80%\f\r\n\r\r\f\n\f\r\r\t,\f\f.73e9692719%\n\n\f\n\r\r \f\f\r,\t\t .213E+7681 \r\n\n\n)\n\n\r\t\f\f";

this.AssertCssColor(item, 3, 2, 255, 255.0);
item = "\t\n\f\f\f \r \f\r#ED69e3eE\f\r\f\f\f\r\n";
this.AssertCssColor(item, 237, 105, 227, 237.91500000000002);
item = "\t\n\rRGba(\r\f +28009\n,-585\f,\f7,\r.920345E7677\r\r\r)";
this.AssertCssColor(item, 255, 0, 7, 255.0);

item =

  "\t\nrGB(-.4%\r\t,\n\n\r .213773E+474191%\n\r\n \r,\n\f\t\r\f \n \f482.25e+80%\n\r)";

this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "\t\f\tHSl(1,\f\n\n\f-01132%,6.78E-29%\f\f)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =
  "\t\f\n\r\frgb(\f\n\n\f \f \r472\f\f\f\n\f\n,\n\r\f-62\n\n\f\n\t\n\r,-05 \t)";

this.AssertCssColor(item, 255, 0, 0, 255.0);
item = "\t\f\fhsL(7047401,-708812709%\f\r\f,.3E20%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "\t\f\frgbA(\r\f\r \f\f\t\f.35E+42894737%,\n\n\n\f\f-.145%,\r\n\r\f\t24179E+2%,83.3E+6939897)";

this.AssertCssColor(item, 255, 0, 255, 255.0);
item = "\t\f\r\f\nHSl(\f.6,\r\n\t\r\r\n-6%, \n\n\r\n\r\f-83547E34%\f)\f\f\t ";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "\t\f\r\f \r\frGBA(\t\t\r0.6E1%\r,83.1e7%\f\n ,+95926e-8%,\f\n\f\n+410243\r)\n\n\t\t\r\r\n";

this.AssertCssColor(item, 15, 255, 0, 255.0);

item =

  "\t\f \t\n\r\f\t\rrGBA(-651809758%,.462%\n\f\r\r\f\r\f\r\f\f\t,+6837%,\f\n\f\n\t\r.4E342211)";

this.AssertCssColor(item, 0, 1, 255, 255.0);

item =

  "\t\fRgba(\f+4\t\n\r\r\f,\f\t\t\r35862, \r\t\r\n\r-7741994\t\r\t\r,+75.73522636e+4967) \t\r";

this.AssertCssColor(item, 4, 255, 0, 255.0);

item =

  "\t\frGBA(80.9067%, \n\f\f+8E-67420%\f\n\t\f\f \r\n\f\r\t,\n\n\r\n \r47318.64705e82972%,.26)";

this.AssertCssColor(item, 206, 0, 255, 66.3);

item =

  "\t\r\n \f\n\t\t\nRGbA(\n\t\n\f\f\t\f\r\f.819e-76959851%\r\f ,\f\f\r\r\t\r.096%\n,\t.33847%,\f\n\n\r\f+83857733\r\f\f\f\n\f)\r \f";

this.AssertCssColor(item, 0, 0, 1, 255.0);

item =

  "\t\r\f\f\n\r\r\r\r\r\fRGBa(+.5e-998%\t \t\n\n\n \n,\f\n\r\r\n\f+6285.0989%,.2796946E79976%,3715\r)";

this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "\t\r\r\t#cBB\n\f\r";
this.AssertCssColor(item, 204, 187, 187, 255.0);

item =

  "\t\r\r\nrGba(\n+4E+6%\n\r ,\n.5240499E-957%\f\f\f\f\n ,7534%,9.21e+50 \r)\r\n\t\t\n\n\r\n\n\n";

this.AssertCssColor(item, 255, 0, 255, 255.0);

item =

  "\t\r\r\f\n\n\f\f \nRgBa(\r\n\n\t\n-746195% \f\n\t,.458531e+64142556%,\n \n\r\r \n 3%\f\r,-.23e680)";

this.AssertCssColor(item, 0, 255, 8, 0);
item = "\t\r \f\frgb(+.88%\r\r\r \f,\f\n\n\r751E-499978%\n,\n\n.579E-5%\r\t)";
this.AssertCssColor(item, 2, 0, 0, 255.0);

item =

  "\t\rHsL(-.83E-2223552130\r\r\f\t\n\f\f \n,-.07924e6781660666%,\r\t \t6E16133017%\n\f)\n\n\t\n";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\t\rRGB(\n40,24899\r\f\r\n \r\f\r\r\n,\n\r \f9221\t \f\r)\r";
this.AssertCssColor(item, 40, 255, 255, 255.0);
item = "\t\rhSl(28179.10E3,\f.277%\n\f,-.370e-0%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "\t \tRgb(\r.746122121E15393%\r\n\f \n\r\n \r,\f\f\n \r+4237752336.2%,\f\n 77341.43E-9808%\n)";

this.AssertCssColor(item, 255, 255, 0, 255.0);

item =

  "\t \n\rRGB(.1E-549%,\f\f\f\n\n -.94651%,\f \t\r\r \f-.958425E+8938655%\n\f)\f\f\n\f";

this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "\t \fRgBa(\f\n\n\r\f\f\n .44674e4% ,\f\n\f+.29%,850E2%\f\n\f\n,\n \f \f\r-.9737E9\n\n)\n\f";

this.AssertCssColor(item, 255, 1, 255, 0);
item = "\t \t\f\f#4CEdAb\r";
this.AssertCssColor(item, 76, 237, 171, 255.0);

item =
  "\t RgBa(\r\t \n\r.13%\t\n\t\n\n \n \n\t,\r-5%,\n-3E50%,\r\r\n\r\t+.803E+1)";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\t#50FAad\t \n\r\r";
this.AssertCssColor(item, 80, 250, 173, 255.0);
item = "\t#BaFE\f ";
this.AssertCssColor(item, 187, 170, 255, 237.91500000000002);

item =

  "\tHSL(3.23306134733e-454715243917\n\r\f,\f\f-.3180E+8841701%\r\r\f\n\r\r, \r\r+.292058e+14143%) \r";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\tHSl(\f+8E+4,+4372e97%,\n\n \t\n\t\r\r15%)\n";
this.AssertCssColor(item, 50, 76, 0, 255.0);
item = "\tRgb(3172,\t\n12 \r\f\r\t\t\n\f\n\r,+5297\t) ";
this.AssertCssColor(item, 255, 12, 255, 255.0);
item = "\tRgba(-4358\f,301849581\n\t\n,\r\r-4\r,8\f \r)\f\r\n\f";
this.AssertCssColor(item, 0, 255, 0, 255.0);
item = "\thSL(\n\t\r\f\r +.286\f,-39527392498.8%,.99967591e+8720628%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\thSL(\r\n\f+9222.3e-4368141\n,1.0%\n\n\r ,49e0%)";
this.AssertCssColor(item, 126, 123, 123, 255.0);
item = "\thSL(.988880\n\t,.06%,+.49348E-31%\r\f)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\thsL(+.6604 ,-1e-6%,.8e+3575%\f\r)\t\f\r\f\n\n\f\t";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\trGB(\n\t\f\n\n\n\t\t\t\r-4658 \t\n\t\r\f,77\f\t\f\n\r,\r\n+66926734)";
this.AssertCssColor(item, 0, 77, 255, 255.0);
item = "\trgb(+6\f,\t\n\r 9\n,47\f\f\r\f\n)\n\f\r";
this.AssertCssColor(item, 6, 9, 47, 255.0);

item =

  "\trgba(\t.42e4505%,\f\t\f\r-.69297917e+528427% \r \r\f\n\f\n,\r+.9%\n,\f\t -.089\f\t\f\n\n\n\n)\n\r";

this.AssertCssColor(item, 255, 0, 2, 0);

item =

  "\n\t\t\n\nHsl(\n+46088414915.902508E-2152 ,\r\f\r\f\n\n \r\f\n\n\t.417550E-41%,\f.156077112%)\r";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\n\t\t\r\nRgBA(+.1E+49121%,47E1%,.2145663%,0.2864881) ";
this.AssertCssColor(item, 255, 255, 1, 72.92999999999999);
item = "\n\t\n\f\f \r\frGb(2460581824,-2093\r\t, \t\r\r\t\f\f \f1\f\f)\f\t\f\n";
this.AssertCssColor(item, 255, 0, 1, 255.0);

item =

  "\n\t\n\r \r\n\rhsL(\f\r -.353945e+252\n\r\f\t\r\r,\f\t\r\n\f\f\r-.03724666933%\f\f,-.7%)\n\n\f\f\n";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\n\t\n \t\f \f\frgB(78261,-01715\f\f\r\t,\t511)\t \t\f\r";
this.AssertCssColor(item, 255, 0, 255, 255.0);
item =
  "\n\t\nRGBA(\n\n\n\r\f\n\r\f361.8E+75585%,\r847.176e73%,.4666E0728%,.9\f)";

this.AssertCssColor(item, 255, 255, 255, 229.5);
item = "\n\t\nhsL(\t\t\n7.76092 \t,11.73062272029e+0%,+.661997%) \n\n \f\r ";
this.AssertCssColor(item, 1, 1, 1, 255.0);

item =

  "\n\t\r\nRGBa(563097903E9%\n,5.98e82524%\n\f\r\r\t\f\t\t,-.75155E+189%,\n -2\r \f\f\r\r\f)\n\n\f";

this.AssertCssColor(item, 255, 255, 0, 0);
item = "\n\t\r#AB6";
this.AssertCssColor(item, 170, 187, 102, 255.0);
item = "\n\tHsL(\t-29.76, \f.387265E-131654%,+59E1625%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =
  "\n\tRgb(.72560e+06%,\f\t\f\n\f\n53.5e-20% \t\r,\n-840%\f\r)\n\r\r\f\n\f\r\n";

this.AssertCssColor(item, 255, 0, 0, 255.0);

item =

  "\n\n\t\f\r\rrGba(.33675577423%,.29e-73%,\t\n 2464576.1e-16915%\t\r,\r+.089271\f\r\f\n)";

this.AssertCssColor(item, 1, 0, 0, 22.95);
item = "\n\n\n\tHsl(.59,27311.8895505E-70%,67746E181%)\r";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "\n\n\n\f\n\frGBa(-1%,\r\t\f\r \n \r-910.4%,+.04708e9694%\t \n \f\n,.1424449955e-41 \n)";

this.AssertCssColor(item, 0, 0, 255, 0);

item =
  "\n\n\nRgB(-8192635E+730122%,+.011877112E-255%,\n\r\r\r\f\n\n\t .70865577%)";

this.AssertCssColor(item, 0, 0, 2, 255.0);

item =

  "\n\n\nrGB(\n\n\t\t\f\f \t+4434484698\f ,\r\f\f\t\f \f \f42115725,9815\n\n\f\f)\t ";

this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "\n\n\f\n\n\t Hsl(\f\f\f\f\f\f-.601002E+171\f,\n\t\f\f\r\r.273%,879.69%\f)\n\r\n\n\f";

this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "\n\n\f\f\f\nhsL(+5615.6492 \n\t\f,\n\n\f\n\f\f\r\f\f\t\f329.6%\n\r,\n\f888.5E-572178446%\n\n\f)";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\n\n\f\f\r HSl(\r\n\t\n\n\r87253E60901,+739e-602%\f,6440.9e-9073%)\f";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\n\n\f\fRgB(+2\t,-2,+236531)";
this.AssertCssColor(item, 2, 0, 255, 255.0);

item =

  "\n\n\fHSL(\n+.2E223 \t\f,340131357618E42701%\n, \f\t-.238151296%\r)\n\t \n\r\t\r\r\f";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item =
  "\n\n\fRgBA(0,\t\n\n\f\f\n\r\r 6\n\f\n\n\n\r,\n 305950,-.311E61809)\t\n\n";

this.AssertCssColor(item, 0, 6, 255, 0);

item =

  "\n\n\fhSL(\r \f\n\t\f\f\n\t+39205E57851109\n \n\n\f\r,.830088216%,\f\f.1692220E+41%)";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\n\n\r\frGba(\r5,62707\n\t \t\r\r\f\f ,-05,-281282e5396)\f\n";
this.AssertCssColor(item, 5, 255, 0, 0);
item = "\n\n\r\r\fHSl(+38.84521\n\n\n\r\t\f\t\f,+.3E141%,\n\f\f\f+9.95%)\f\n";
this.AssertCssColor(item, 50, 32, 0, 255.0);
item = "\n\n\r\r\rRGBa(\t\r\n-2\n\r\n\t\r,\r\n709,504,\f\n83)";
this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "\n\n \f\t\t\f#3FaACf \f\f\f\r\n\r";
this.AssertCssColor(item, 63, 170, 207, 255.0);

item =

  "\n\nHsl(\r\t\f\f\n\f -51333202872, +.47848300E-576294%\f\n\r\r\r,\n\r9%\r\f\n\f\r\r\t\n\f\r)";

this.AssertCssColor(item, 22, 22, 22, 255.0);

item =
 "\n\nrGBA(\f\f\r\r \r98\n \f \r\t\r\r\r\f,-7010118,4\r\f\f,1E+900472\n\n)\r\n";

this.AssertCssColor(item, 98, 0, 4, 255.0);
item = "\n\nrGb(-10781,\n-2192,\r\r\n\n\f90)\f";
this.AssertCssColor(item, 0, 0, 90, 255.0);
item = "\n\nrGbA(-551\r,3,\r \r-767,+.156e4428300\f)\f\n\f\r\f\r\f\n";
this.AssertCssColor(item, 0, 3, 0, 255.0);
item =
  "\n\nrgB(\t\r\r\n\f\f\t\f\r\n-1.8% \r,\t\r .828468%\r\f\t\f\r,+.8739e4%)";

this.AssertCssColor(item, 0, 2, 255, 255.0);

item =

  "\n\f\t\n\n\tRgB(\f+.70E2%\r\r,+.6988E+760711832%\r\n,+17% \t\n\r\f\f\f\n)\f\t\r";

this.AssertCssColor(item, 179, 255, 43, 255.0);

item =

  "\n\f\n\r\t\fRgBa(\f\n\n\t\f\n\t\n3.9870E+74%,-23576.96%\f\f,44E-6%\t\r\n\t\f\f,\r\f \f\n.987446)";

this.AssertCssColor(item, 255, 0, 0, 252.45);

item =

  "\n\f\n \r\rrgBa(-2440991812,\n\r+30789698\r\r \n\f\r\f,+9358\n\r\t\r\f\n \n\r,-0.6)";

this.AssertCssColor(item, 0, 255, 255, 0);
item = "\n\f\f\t\r\n\fHsL(.907062E8771839,.1%\t,-.7E43%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "\n\f\f\n\f\t\nRgBa(\n\r.12027%,\r\f\r\n.9925E-00660965%,4E193757489% , \t+.519)\n";

this.AssertCssColor(item, 0, 0, 255, 132.09);

item =
  "\n\f\f\rhSL(\r\f\n\r.512133567E+8\t\r\n\t,306.1354%\n\t\t\r\f,.4709%\f\f)";

this.AssertCssColor(item, 0, 2, 0, 255.0);
item = "\n\f\f \n\r\n\rHSl(.6E-960403,\t.0072341572%,-0.156E96%\t\f)\f";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\n\f\r\n\t \n \f\n\nRgB(98417822\n\r,2813645,3)";
this.AssertCssColor(item, 255, 255, 3, 255.0);

item =

  "\n\f\r\n\r\r\n\nhSL(\f\n\f-.3\n\r\f\f\f\t\f,\n\n\n\t\f\r-.5838484250%\f\n\t\n \f\t\t,-.3e028608%)\r\r\t";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\n\f\rHsL(\t\r\f\r\t-.95e574,\t+.2E06%,.73060e04%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "\n\f\rRgbA(844 \t\n\f\r\n\f\n,83073\r\t\r,\n\f\f\f\f\t \r \n+837,\f \r\f\t .40)";

this.AssertCssColor(item, 255, 255, 255, 102);
item = "\n\f \t\r\r \t\nhsl(\f3e045\n\f\n,-.734498813%\t\r, \t-17.0764E8248%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\n\f \fRGba(5\r \f\r ,95,+81, +.52456\n\r\t\n\n\r\n)";
this.AssertCssColor(item, 5, 95, 81, 133.875);
item = "\n\f#cFcB\t\f\n\t\r\r";
this.AssertCssColor(item, 204, 255, 204, 186.915);
item = "\n\fHsl(-5\r,-9.577%,\t32%\r\f)";
this.AssertCssColor(item, 81, 81, 81, 255.0);
item = "\n\fRGB(\t\n+8\r,25534567,+2)";
this.AssertCssColor(item, 8, 255, 2, 255.0);
item = "\n\fRGBA(-1,52943794\f,\r\n 00204, +86145030091.46)\t";
this.AssertCssColor(item, 0, 255, 204, 255.0);
item =
  "\n\fRgBA(\f\r\f\f030562,\n\f\n\t+967,\f\r \f84\n\n\f\n\f\f\r\t\n,+.50)\t";

this.AssertCssColor(item, 255, 255, 84, 127.5);
item = "\n\fhsL(.4,.092563943%\f\t\n\r\n,60125.61515559204%\n\f\t\r\f)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\n\r\thsL(.6e9689\t\n\n\r\r\n,\r+36083.1%,-0732966.4E+027%\r\r)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\n\r\n\t\frgB(89322\r\r\r,\f \n80,+60)\n\n\n\r\n\f\r";
this.AssertCssColor(item, 255, 80, 60, 255.0);
item = "\n\r\n\n\f\f\t \tRGB(-058206563,-576461594,\f\n \n+5653 \f\t)";
this.AssertCssColor(item, 0, 0, 255, 255.0);
item = "\n\r\f\f\nrgbA(63,\n \r\f71,+564,+1\r) ";
this.AssertCssColor(item, 63, 71, 255, 255.0);

item =
  "\n\r\f\r\n\f\f\f\fHsl(-.1\t,.989848E714%,\n\f\f-.76E+210%\f\r\n\f\r) \n\n\f";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\n\r\fRgBA(-34\f\f \r\t,\t\r5204,215618,21.07\t \f) \n\n\n\r\n\r";
this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "\n\r\r\f\r\f\f\r\r\t\t\n#F8b2\t\f\f ";
this.AssertCssColor(item, 255, 136, 187, 33.915);

item =
"\n\r\r\fhsl(.677928E+1891\r\n\f\r\n\f\f\r\n \t,.35467%\t\n\f\f,-467188542E6%)";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\n\r\r\frgb(49\f,2081816\f\f\f\n\r\f,-749189\n)\r\r\r\n\r \r\f\f\t";
this.AssertCssColor(item, 49, 255, 0, 255.0);

item =

  "\n\r\r \r\r\n\n\f\frGba(-4069e5%,\f\r\t\t\r.9%,\f-29.5020e1171%\r\n\n\r,36.4351e9) \r\n\r";

this.AssertCssColor(item, 0, 2, 0, 255.0);
item = "\n\r \n\r\f#EdcBbcfF";
this.AssertCssColor(item, 237, 203, 188, 255.0);
item = "\n\rHSL(\t\f\n-784,48037e+529297%,+.4e1%\n)\r\t\n\n\n\f\r ";
this.AssertCssColor(item, 19, 0, 20, 255.0);

item =

  "\n\rRgBa(\n\r \n\f\f+88.8040%,-445E6%\t\r\n\f\n\n,\n\f\n-.0E+0%\f,\t\r-21\r\f\r\n\r\n)\n\n\r\r";

this.AssertCssColor(item, 226, 0, 0, 0);

item =

  "\n\rrGBa(\t\n\r\n\n337505882,610\r\f \f,\n\n\f\t\f\r\n+4742368\n\n \f\r,\f\r\f\f-.252609)\f";

this.AssertCssColor(item, 255, 255, 255, 0);
item = "\n\rrGbA(-80148\f,\f+7\f\n\r,8\n,\n\f\r.0\r)\r\r\f";
this.AssertCssColor(item, 0, 7, 8, 0);

item =

  "\n\rrgb(\n32968561.04E70%,+.56744656e8751922402%\f\f\r\f\f\t\n \n \r,\r\r\f\r \r88267%)\f\n";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item =
  "\n\rrgb(6e-912%,\f\f\f-2e7%\t, \f+.51839274e6807626%\r\r\f\n\f\f)\f\r\t";

this.AssertCssColor(item, 0, 0, 255, 255.0);

item =
 "\n \t\f\n\n\rrGbA(\r \n\f\r\f\n07\r,\r\n\t\n\n \n\f3,\r-03,\n\n\n+807.13178)";

this.AssertCssColor(item, 7, 3, 0, 255.0);
item = "\n \t \f\r\r\f\f\t\fRgB(07%,\n\f \n\n \r\n\r.57%,\r+340e64524%)";
this.AssertCssColor(item, 18, 1, 255, 255.0);
item = "\n \n\t\f\n\rrGBA(-0%,36.83617%\r ,\t.2%, \n.0)";
this.AssertCssColor(item, 0, 94, 1, 0);
item = "\n \f\n\t\fRGb(\f\f\r\r\n8.29%,.9467E008%\r\n,\r+94.517%\r)\n\n\t";
this.AssertCssColor(item, 21, 255, 241, 255.0);
item = "\n \f\f\nRGBA(+.82e-57869%\f\f,\n.9e24154913%,-0E83%,4E+6)\t\r";
this.AssertCssColor(item, 0, 255, 0, 255.0);
item = "\n #bbCDDC\r\f\r";
this.AssertCssColor(item, 187, 205, 220, 255.0);

item =

  "\n HSl(\r\f-.012224E+07,\t\n\n\n\n\n \r\f\f\n+6e-646080% \n\r\n,4476.5E+017090661324%\n \f)";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\n RGB(\n-.73E646%\n\n,\r9510238%\n\t,\r\t+08557%)";
this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "\n RGb(-479375728 \t \t\n\f\f\f\t\r,\f\f\r\r\f\t\r\t35882\f\t\r,3)\r\f";
this.AssertCssColor(item, 0, 255, 3, 255.0);
item = "\n#8bF1\n\r \r \r\f";
this.AssertCssColor(item, 136, 187, 255, 17.085);
item = "\n#AccDcD\f\r\f";
this.AssertCssColor(item, 172, 205, 205, 255.0);
item = "\n#BcfFBC";
this.AssertCssColor(item, 188, 255, 188, 255.0);
item = "\n#FFDfeA\n\n\r";
this.AssertCssColor(item, 255, 223, 234, 255.0);

item =
  "\nHSL(\f2.6957932,\r\r\n\t\r +.2E-87%\n,.5052348E2%\r\n\f\r \f\t)\t\r\r\f";

this.AssertCssColor(item, 128, 128, 128, 255.0);
item = "\nHSL(\r\n\f\n\f\f\f\f\n\r-56.661,271726884e98380%\f\n\r,.67E-20%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "\nHsl(\t\n\t\r\t\t\t+985.60E2335439\t\f,\f \n\f\n\f+07754.0e6%,.6e-3901536814%)\t\n";

this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "\nHsl(\f.235730894555e+301\t,\n\r\f \t30.63689273e091732%\r \r \r\f,-.567e45%\r\r\f\t\r\n)";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item =
  "\nHsl(+.70307e+6,\n83.659294%\t\r\f\n\n\r,\r\f\r-5%)\n\r\n\n\t\r\r\r\n\t";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\nRGB(\f\t\r\n\n0,+6, \t\n\t2221)";
this.AssertCssColor(item, 0, 6, 255, 255.0);
item = "\nRGB(-78,\r\n\n\f\f0,-38371)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\nRGBA(723,\n-9\n,+533\r\r\r,\f\f\t\f\r\t\f \t\f\f48\f)\f\f";
this.AssertCssColor(item, 255, 0, 255, 255.0);
item = "\nRGb(-978,5\r\f\n\f\n\f,\t \f\r\n\r60)";
this.AssertCssColor(item, 0, 5, 60, 255.0);
item = "\nRGb(459517E50215455%,\f\r\n\r-.6121610E+9%, -.07%\f)";
this.AssertCssColor(item, 255, 0, 0, 255.0);
item = "\nRgB(\n73233.3%,-5E32491%\t,080655E+2588%\t\f\f\r\f\t)";
this.AssertCssColor(item, 255, 0, 255, 255.0);
item = "\nRgBa(\t\r\t\t\f1203\t\r,+26, -90\f\t\r\r\n\r,-.367452e-937)\r";
this.AssertCssColor(item, 255, 26, 0, 0);
item = "\nRgBa(+89683e+52029156%,8e+00508%,+51%, +4e+321\f\f)";
this.AssertCssColor(item, 255, 255, 130, 255.0);

item =

  "\nRgba(658.60%,\n\n\r\t\n\f -.3443E62%\f\n\n,+.912463676114E-65213714%,-.3e59\f\n\n\r)\t\n";

this.AssertCssColor(item, 255, 0, 0, 0);

item =
 "\nhSl(\r\r87.95E1\n,\t96059.49297e857%\n\f\t\f\r,-341510355.211487226%) \f\t";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\nrGB(\r\n.326618%\r,7485e02%\t\f\t\f\r\f,.96%\n\n\f\n\n\f\f\r \f)";
this.AssertCssColor(item, 1, 255, 2, 255.0);
item = "\nrGB(\r\r\n +80 \f\n\r\n\r\n\t\f,\n-69929164,-420)\n";
this.AssertCssColor(item, 80, 0, 0, 255.0);
item = "\nrgB(71644570,\f\n\r-74\r\n\r\r\r\f\r,+645889\n\f\t\n\n)";
this.AssertCssColor(item, 255, 0, 255, 255.0);
item = "\nrgbA(+8\f,+7\f\n \r,82,.03\n)";
this.AssertCssColor(item, 8, 7, 82, 7.6499999999999995);

item =

  "\nrgbA(-.88353%,\n\n\n\f \f -2404E088762%,+8.53897223284% ,\t\n\f-.137e+07407963\f)\n";

this.AssertCssColor(item, 0, 0, 22, 0);
item = "\nrgba(\n\f\n\r846\f\n \r\f\t,67741998\f,\f188081707,-.2604)";
this.AssertCssColor(item, 255, 255, 255, 0);
item = "\f\t\t\r\n\f\frgB(72, \r\r\n90,+6\f\n\n\n \n)";
this.AssertCssColor(item, 72, 90, 6, 255.0);
item = "\f\t\n\t\r\r\f \n\n#BDED";
this.AssertCssColor(item, 187, 221, 238, 221.085);
item = "\f\t\n\n\f\r\n#eAAbBeFd\r";
this.AssertCssColor(item, 234, 171, 190, 252.96);
item = "\f\t\n\nhsl(.7198297E77\f,876183.42E13372652%,+52508.9809e678%\t)\r\f";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\f\t\n\fHsL(.2E510\r,-7% \t \r\f\n\r\n\n,.0510%)\r";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "\f\t\nhSL(\f \n292418.7103288E-0394,\n8979e6788%\r\r\f\f\n\f\n \t,\f\r\n\n\t \n\f0.14e+088471%\r\n \r\n)";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\f\t\f\t \f\r\n rgB(\f\n76012,0,\t\n+3\r)\r\f\r\n\f\r \n\f ";
this.AssertCssColor(item, 255, 0, 3, 255.0);

item =

  "\f\t\f\nrgba(\f +237792952848,7508460663\n \r,\r\n\n\n\n\r\r+7,\f\n\f\n\r\f-8785e788\f\n\r\t)\t";

this.AssertCssColor(item, 255, 255, 7, 0);
item = "\f\t\f\r\f\f\fRgb(\r\r\n98046322 ,344\f\f\n\f\t\n,+438573183\t\n)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\f\t\frGb(+7, \f\t\f\r-14\n\n\n\f\n\n,\n\f\f2\f\n\n\f\t)";
this.AssertCssColor(item, 7, 0, 2, 255.0);
item = "\f\t\r\n \t\f\f#C7C6Cc\f\n \r\n\n\n";
this.AssertCssColor(item, 199, 198, 204, 255.0);
item = "\f\t hSl(-.48e602,+.777175% ,.879053913%\f)\r\r\t\n";
this.AssertCssColor(item, 2, 2, 2, 255.0);

item =

  "\f\tRGbA(\n\r\n81.634%\t\r\t\r\f,2084568135e847%,\r\n\f\n\t\r-9557175629.8973%\n \r \t ,-.14\f\f)\r\n\n\f\f\f\r";

this.AssertCssColor(item, 208, 255, 0, 0);
item = "\f\thSL(-.840,417115768294.2e5791173%,\r-44%)\n\r\r";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "\f\thsL(+.67\n\r\n\f\t \t,+.11490440%\f\r,\n-4792.09460984E732356034%\r\f)\r\n\r\r\n\r\f \r\n";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\f\n\t\t\f RGBA(9,+415842368\f\f,-7\n\r\r,\r+90.6E-117783867)\t \f\n\f";
this.AssertCssColor(item, 9, 255, 0, 0);
item = "\f\n\n#eDcDBBAc \f\r\f\r\f\r\r";
this.AssertCssColor(item, 237, 205, 187, 172.125);

item =

  "\f\n\f\tRgbA(0,\f\r 72591984\f\f\r\r,\f\f\r\n5527\n\r\r\t\n,\r\r\f-46.28550733E39\t)";

this.AssertCssColor(item, 0, 255, 255, 0);
item = "\f\n\f\r\fhSL(+.0e407625,\n.1%,\t\r+.65%\f\f\n)";
this.AssertCssColor(item, 1, 1, 1, 255.0);
item = "\f\n\frgb(\t\f\n\f.5%,25177E+9%, \f-619%)";
this.AssertCssColor(item, 1, 255, 0, 255.0);

item =

  "\f\n\r\tHsl(5685101237.560032\r\t\r\f\n\t\t\r\t,\n\n-8.9E-617392%,\n\r2e063971%)\f\r\f\n\n \r";

this.AssertCssColor(item, 255, 255, 255, 255.0);

item =
 "\f\n\r\n \fRGBA(\n\f\r-2%,\r7E-1%\t\t\r\n,-9703e-495%\f\n\r\n\t ,\r-.541E48)";

this.AssertCssColor(item, 0, 2, 0, 0);

item =

  "\f\n\r\r\t\f\n\frGB(+89038.80E+2029%\f\f\f\t\f,-545449.5e+568%,-.64787e-8%\f\f\f\t\f\n)\r\f\r\f\n\t";

this.AssertCssColor(item, 255, 0, 0, 255.0);
item = "\f\n\rHSl(\f-1.2642,-.7E+9283%,+.4%)\r";
this.AssertCssColor(item, 1, 1, 1, 255.0);
item = "\f\n \r\nrgb(\r \f-452396,\n987656329292\f,5)\f\f\n\r";
this.AssertCssColor(item, 0, 255, 5, 255.0);
item = "\f\n #Aac\f\f";
this.AssertCssColor(item, 170, 170, 204, 255.0);
item = "\f\n#Ad29ec \f ";
this.AssertCssColor(item, 173, 41, 236, 255.0);
item = "\f\nHSl(.11\n \r,\n379357496%,+436703037.23% \f\r\n\f\f\n\r\r)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\f\nHsL(\r\f\f \r-8819104091.33030e-52,\f-79125%,\f-.086% \f)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\f\nHsl(\n\r\f\t-.10259E-35,180.2%,+.56e+937%)\f";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\f\nhsL(\f\r0099E-794,-407.565943%,.7E7%)\f";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\f\nrGB(+131,\r\f\f-722430984\f\n\n,+6\r\t\n\f\r\r\r\f)\f\r\f\n";
this.AssertCssColor(item, 131, 0, 6, 255.0);

item =
  "\f\nrgB(7570e522%,.2883760910%,\t\t\n\f\t\f\n+18785.7130780%)\f\n\f\n\t\f\n";

this.AssertCssColor(item, 255, 1, 255, 255.0);
item = "\f\f\t\n\r#dAAcEE";
this.AssertCssColor(item, 218, 172, 238, 255.0);

item =

  "\f\f\t\fRGBa(\t+0461997E-0%\t\n\r,\n\n+152.7%,\r -3E6478233010%\t\r\r\t\t\n,.67\t \r\t) \r\n\n\f\f\r\r\f";

this.AssertCssColor(item, 255, 255, 0, 170.85000000000002);
item = "\f\f\t\rrgb(\r\r\f\t-39,1\n,324245735)";
this.AssertCssColor(item, 0, 1, 255, 255.0);
item = "\f\f\n\n\n \f\rHsL(89335701.5511,\r.1e-181%,3553460%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\f\f\n\f\fRgB(\n\r\f98\f\f\n,\f\f\f\r\n\f\f\f\f +46,\r-9564708)";
this.AssertCssColor(item, 98, 46, 0, 255.0);

item =
"\f\f\nHsl(.6287094e57085\f\f\n,\n\r\r\r.47e129%,+36.57259e+6361999326%)\t\f\n";

this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "\f\f\nRGB(+7.445e+02% \r\r\n\f\f\f,\n\r\n\n \f\f\f.8269047E55534822%\t,\f\n\f\n\n\f\r\n\n\t\n1.6e3%)";

this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "\f\f\nrgBA(\f\f\r+047%,73%\f\r,\t \f\f\n\r\r505523135%\f,.46362e+9)\f\t\t\f\r\f\f\f\f";

this.AssertCssColor(item, 120, 186, 255, 255.0);
item = "\f\f\f\t\frGb(\t.30780077131%,\f\t-2e-7%,-6.07%)\n\n \f\f";
this.AssertCssColor(item, 1, 0, 0, 255.0);

item =

  "\f\f\f\n\r\nrGBA(\r\r \r\r-.78%,847.921E8%\t,-.76E821461%,\f\n\n\t\r\n.88536E1478327\r\r \n\n\r)";

this.AssertCssColor(item, 0, 255, 0, 255.0);
item = "\f\f\f\f\n \f\t\nrgB(645812442e456%\f,-.5E868%,37.8% \n\r\r)\f";
this.AssertCssColor(item, 255, 0, 96, 255.0);
item = "\f\f\f\r\f hSL(\n.7e-636,\r-.3E80%\r\r\f\n,+.7532002%)";
this.AssertCssColor(item, 1, 1, 1, 255.0);
item = "\f\f\f\rRGba(+0479894,-8715,-80,2E066\t\f\n\n\n\f)";
this.AssertCssColor(item, 255, 0, 0, 255.0);
item = "\f\f\f\rhsL(\f\r.8E8759,\r \n\f-.587239E65% \r\f\r,-.3e689574%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "\f\f\f\rrGBA(\t-8265501\r\r \f\f \t\f,\n\f\r \f\n+4\f\n\n\f,-0510,\n\t\r\f\r\f\t\f.5000)\f";

this.AssertCssColor(item, 0, 4, 0, 127.5);
item = "\f\f\r\t\n\f\t\r\f\tHSl(\t\f\n\f\t\f.7\n\n,\f -52%,+41E-05%)\n\r\n\f\f";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item =
  "\f\f\r\t \r\r\nrgb(32e-79854%\r\n\r\t ,+7352%\n\r,\n-.9E0172%)\t\t\f\n\t";

this.AssertCssColor(item, 0, 255, 0, 255.0);

item =

  "\f\f\r\n\r\r\f\r\nrgba(\n\r-.8%,\t+.08% \t\r\f\n\r\n,\f\n\t\f368.96E6257956%,\f\r\r\n\r\n+29.1e51194580814)\r";

this.AssertCssColor(item, 0, 0, 255, 0);

item =
  "\f\f\r \r\rRgbA(\r \r\f\n9219691.77864e89%,\n-.6%,\n\r-.2e398%,-19.832e+6)";

this.AssertCssColor(item, 255, 0, 0, 0);
item = "\f\f \t\r\f\f\r\rRgBa(\f539583317775 \f,\r\n\t+7\f,87841 ,.9352e-2767)";
this.AssertCssColor(item, 255, 7, 255, 0);
item = "\f\f \f\r#EEd90E2D";
this.AssertCssColor(item, 238, 217, 14, 44.879999999999995);
item = "\f\f #FaBcEF\r";
this.AssertCssColor(item, 250, 188, 239, 255.0);

item =
 "\f\f rgBa(+.57885e5403099%,+6e92373702786%\t\f\r\r\r\t\r\f\f,\f 448%\r, 9\f)";

this.AssertCssColor(item, 255, 0, 255, 255.0);
item = "\f\fHSL(\n-.33,\f\n\n-.0585%\f,\f+.20% \r\f\f \n\f\n\r\f\t\r)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "\f\fRGBA(\t\r\r\t \t-0,\r\t-3 \n\f \f \n\f ,\r\r\t\r\r\t+477585\f\f,\f\r \n+.66\r\r\n)\t\t\f ";

this.AssertCssColor(item, 0, 0, 255, 168.3);
item = "\f\fRgB(\n \f\n\t\n\f595\r\r,+462,\n\r\f\t-7907)";
this.AssertCssColor(item, 255, 255, 0, 255.0);

item =

  "\f\fRgBA(\n\f\n\f\n-1802.1%\r \r,\n\r\n\t \f\t51634249.4e4551508%\n\n,.2331089099e73599%\r\n\f\t\t\f\f \f,\t -.273e+82053165)";

this.AssertCssColor(item, 0, 255, 255, 0);
item = "\f\frgb(\r\f1,-593664,75\r)";
this.AssertCssColor(item, 1, 0, 75, 255.0);

item =

  "\f\r\t\f\f\f\f\t\rrgB(\n+9708\f\f\f\r \r\n\f ,\n\f\f5\r \f\r\n,\r\r\t\r0705\f\r\t\f\r \r\n\t)\f";

this.AssertCssColor(item, 255, 5, 255, 255.0);
item =
  "\f\r\t \n\f HsL(05\n \t,\t\r\f\r\r.42E-9%,+.189236%\f\r)\f \r\r\n\r\f\r";

this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "\f\r\tRgBA(+468 \r\f\t\f\r\r\f,\t\n\t \n\r\t\r+95\r,\t \t\r\t+35 \n,+39.5e+72)\f \t\n\r\n\t";

this.AssertCssColor(item, 255, 95, 35, 255.0);

item =

  "\f\r\n\f\n rgBa(\r\n\n\r+3,\n\r\t \n\n\t\r\f+6035770421,\n\n\r38\r\r\r\t,\n \n\r.27)";

this.AssertCssColor(item, 3, 255, 38, 68.85000000000001);
item = "\f\r\n\fHSL(-84657988365e03 \t \n\n,-.092%,6217.71035643%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\f\r\n \rRgb(\f561250079\f\n \r\n,\f\f936,-8)\n\f\t\n\f\t";
this.AssertCssColor(item, 255, 255, 0, 255.0);

item =

  "\f\r\n HSL(612216.1e+9846\n\f\r\r\n,+2544896.94%\r, \r\n\n\n\n\f \r\n\n1e6505797326%\t)";

this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "\f\r\f\tHsL(\f\f.437196e+771, 713344117%\f\t\n\r \n\n\n\t,.54948%)\t\r\f\f\r \r";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\f\r\f#dEaAcb";
this.AssertCssColor(item, 222, 170, 203, 255.0);
item = "\f\r\fRgBa(\r\r\f-8658\t,-1\r,2909,-2)\n\f\n\n";
this.AssertCssColor(item, 0, 0, 255, 0);

item =
  "\f\r\fhSL(\r\r.41407 \f,\n\r4193%\t\n\f,\r\n.22E77863%)\r\f\f\r\r\f\n\f\f\f";

this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "\f\r\r\n\n\f\f\n\n\t\nrgbA(\n-.1e+20%\r,6.1E+4648266%,-90E-250%,\t5.39)\f\f\n\n\f\f \n\r\n\n";

this.AssertCssColor(item, 0, 255, 0, 255.0);
item = "\f\r\r\f\r\f\r\frGB(\f6%,\t .782%\f,\n\t\n\f-.61909E507055%)";
this.AssertCssColor(item, 15, 2, 0, 255.0);
item = "\f\r\r\f \nHSl(\r\f+.711882531,.9%\f\t,\r\t22E-267031%\f)\r \n ";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item =
  "\f\r\r\fRgBA(150496598,741501448,8745314\f\t\f\n\f\r\t\t \r\f,+.7E-722)";

this.AssertCssColor(item, 255, 255, 255, 0);
item = "\f\r\r\r \n\rHsl(-17 \t\t,\r\r\t\f\r533%,-4.70822% \f\f)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\f\r\rrgbA(48 \t,\n -62\r\t\t\r,\r3053,-.01973146603E+26)\t";
this.AssertCssColor(item, 48, 0, 255, 0);

item =
"\f\r \f\r\fRgb(7563534\t,\r \r\f\f\r\n\f-56765\n\t\r\r,789484)\r\n\f\t\n\r \t";

this.AssertCssColor(item, 255, 0, 255, 255.0);
item = "\f\r \r \f#AbAD0B\n\n\f";
this.AssertCssColor(item, 171, 173, 11, 255.0);

item =
  "\f\r \nrgb(\f\f\n\r\f\n\r\n\r\r\f+89\r,\n-80836093,7\r\r\n\r\r\f\n\f)\t \f";

this.AssertCssColor(item, 89, 0, 7, 255.0);
item = "\f\r HSl(.0,\t\n\n\n\r\r\f\r 481.4024E128%\n,3859%\r\n\n\r\n) \t";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "\f\rrgBa(.3E+81339%\n\n\n,+.030E+57954%,+.4321E308916%\n\r\f\n \f\r\f\n\f\n,\n254E81106785)\f\f";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\f\rrgba(\f594\n \f,+70, \r\n\n99,\r\f4.77e+1582)\t\r\r\t\n";
this.AssertCssColor(item, 255, 70, 99, 255.0);
item = "\f \t\r\f\rRgBA(-9\r\f\r\f,+94\n\r\f\f\r\t\f,9\f,\r\n \f\n\r\r.2)";
this.AssertCssColor(item, 0, 94, 9, 51);
item = "\f \n\trgb(42\n \n\r,\f\f\n\r3363\f\f\f,86561149\n\t\n)\r\n \f\f\r\r\t";
this.AssertCssColor(item, 42, 255, 255, 255.0);
item = "\f \n#DEEF \r\f\n\t";
this.AssertCssColor(item, 221, 238, 238, 255.0);
item = "\f \f\r\r\n\f\f\r#Ae3F\t\r\n\t \n\r\f";
this.AssertCssColor(item, 170, 238, 51, 255.0);

item =

  "\f \r\n\r\t\n\r\r\nrgb(\f\n\f\f\t \r851.32E206666%,+5.8%\n\r,+31.0E567893578855%\n\r\t)";

this.AssertCssColor(item, 255, 15, 255, 255.0);
item = "\f rGB(0849141\n,\n+3384,74)\r\n\n";
this.AssertCssColor(item, 255, 255, 74, 255.0);
item = "\f rGB(269,\f\t\f\n\n\n\n\f \t494,\f\r\f\t\n\n\f+1644823)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\f#20ac";
this.AssertCssColor(item, 34, 0, 170, 204);
item = "\f#535aCBBf\r\t\t\f\f";
this.AssertCssColor(item, 83, 90, 203, 191.25);
item = "\f#BdE";
this.AssertCssColor(item, 187, 221, 238, 255.0);
item = "\f#EFfFabBb";
this.AssertCssColor(item, 239, 255, 171, 186.915);
item = "\f#d43c";
this.AssertCssColor(item, 221, 68, 51, 204);
item = "\f#dcfdcF";
this.AssertCssColor(item, 220, 253, 207, 255.0);
item = "\f#f6Ed";
this.AssertCssColor(item, 255, 102, 238, 221.085);

item =

  "\fHSL(\n\n-.3230337\t,\n \r\r\n\t\f\n\n\f\f\r-1519454.01E+8%,\r-.25380E68587%\n)";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\fHSL(\n\f\f73339124,-.6142%\f\f\f\f,27E60%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "\fHSL(\f\n\n.668867e-3254,3%\f\n\r\r\f\t\r\n,\n \f \r\f\f\n\f+.4596E-38%\f\f\n\f)\n ";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\fHsL(-.91315e159\t\t\n\r\f ,-.92105708%,+692578%\f)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\fHsL(-254993230,+.0% \f\f\t\f\r,-.09%\f \r)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\fHsl(\f\r\f\r-.43\f\n\n\r\f\t\f\r,\f.36%,9E+866%\r\t\r\f\n\r)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\fHsl(\f \r\t-.84e-1876,-.2342702605%,\f+.79%)";
this.AssertCssColor(item, 2, 2, 2, 255.0);
item = "\fRGB(+53,5407\f,+85\t\r\f\f)";
this.AssertCssColor(item, 53, 255, 85, 255.0);
item = "\fRGb(01E-089168%\f\r,\f\f \f\f\r\r\n+84%\r\n\r,\n23632223.8%)";
this.AssertCssColor(item, 0, 214, 255, 255.0);

item =
"\fRGbA(\n\f\n\f\n \t \n \r 9e+72693%\n\r,\t\f\r\f7%,490%,296583145.411E0)\n\n";

this.AssertCssColor(item, 255, 18, 255, 255.0);
item = "\fRGbA(.2000%,\n\r\t\n\n\f-21.9447E-4981%,89667E088828%,8.636155\f)";
this.AssertCssColor(item, 1, 0, 255, 255.0);

item =

  "\fRGbA(8359%\r\n\f,689040.3%\t\f\r,\n\t\t \n\f\t\f\r.945%\r\r,\t+740.187146\r\t\f\f)";

this.AssertCssColor(item, 255, 255, 2, 255.0);
item = "\fRgB(+72931583\r,+2\t\f\f\r\f\f,\f\t\n\n\t\r\n\f\n\f02574\f\r)\f\t";
this.AssertCssColor(item, 255, 2, 255, 255.0);

item =

  "\fRgb(\n\t\r\n\f\f \r \f\r-5621591, \f+0190264\r\t\f\r,\n\f\n \f\f-5270796140\r)\r";

this.AssertCssColor(item, 0, 255, 0, 255.0);

item =
"\fhSL(-91500E8670423,551E-7%,\n\r\r\f\n\n\f \r5243373936.4693644%\r)\r\n\n\r ";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\fhSl(26.354327\f\r,\n\r\n\f\f\n\n\f\r.1%,+.5%)";
this.AssertCssColor(item, 1, 1, 1, 255.0);
item = "\fhsL(3e+8927995258,+145.91%\n,+0111%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "\frGB(.0690e+7%,\t\f\t\n\n \n5833441756.669E1% \n\r \t\r,\r\r+.58241%\r)\r\f\r";

this.AssertCssColor(item, 255, 255, 1, 255.0);
item = "\frGBA(\f+369,\r\r00,55253\r\f,735.0)";
this.AssertCssColor(item, 255, 0, 255, 255.0);

item =

  "\frGBA(+2e+8%,\r+.8544879%\n\n\t\n\f \r,111E-67136621%,+7.81086852)\r\f\r\r\n\n \t \f\f\f";

this.AssertCssColor(item, 255, 2, 0, 255.0);
item = "\frGba(-96\t,05\t\n,-9 \t,.201e580 \r\n)";
this.AssertCssColor(item, 0, 5, 0, 255.0);
item = "\frgB(1329417\r,81053416282,21)";
this.AssertCssColor(item, 255, 255, 21, 255.0);
item = "\frgBa(\r\t+03,86775114,-172,-.75937\f \n\n\n)";
this.AssertCssColor(item, 3, 255, 0, 0);
item = "\frgb(\n\n\f\t\t\f+.5e+81%,+.559%\n\r \r,4107.2%\r\f\f\n\r\f\r)";
this.AssertCssColor(item, 255, 1, 255, 255.0);
item = "\frgb(\n\n \f\n\r\f\f+.7%\t\n,\f+.15%,.7e+02632%)";
this.AssertCssColor(item, 2, 0, 255, 255.0);
item = "\frgb(-8653556.0%\r\t\t\f\r ,29%,\t27e965%\t\r\f)";
this.AssertCssColor(item, 0, 74, 255, 255.0);
item = "\frgbA(-2\f,-031\r\n,134,\r\n\r \r \f255081)";
this.AssertCssColor(item, 0, 0, 134, 255.0);
item = "\r\t\n\f\r\f\f\f#efFCE1 \n";
this.AssertCssColor(item, 239, 252, 225, 255.0);
item = "\r\t\n\rHsL(\f\n\r\r\f\f+.73E-8862479669\r,0e+45% ,.3%)\n\r\n\n";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "\r\trgBA(\f-92299,\f \n\f\r\f \r\r\f+3\f,\n\n\n\r456\t,\n+3074656590.1e53993\f\t\r\n)";

this.AssertCssColor(item, 0, 3, 255, 255.0);
item = "\r\n\t\n\n\f\f\n \f#ddb";
this.AssertCssColor(item, 221, 221, 187, 255.0);
item = "\r\n\t\n \n\rRgBa(-1\r,\f+21\r\t,1\t\r,+.59019789\f)";
this.AssertCssColor(item, 0, 21, 1, 150.95999999999998);

item =

  "\r\n\t\n HSl(\t-80463884127E+0138,-.538576400%\r,\t\r\f\f-70583779e-334573869%)";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\r\n\trGB(63,-58\n\r\r \r,\r\f5\f\r\r)\r";
this.AssertCssColor(item, 63, 0, 5, 255.0);
item = "\r\n\n\n\n\f\f \frGB(+.6%\r\f, .53E345459%\f\n\n\f\r,.4830E0598%)";
this.AssertCssColor(item, 2, 255, 255, 255.0);
item = "\r\n\n\n HSl(\n\r 4.09557475, \r\n\n.61%\t,+.4e29264%)\f \n";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "\r\n\n\f\n\f\fRgb(\t-.5E+8%,\f\t\f.59% \n\r\f \r\f,.3053E-98% \f\f\f\n\f\n\r \r)\r\r";

this.AssertCssColor(item, 0, 2, 0, 255.0);

item =

  "\r\n\n\rRgb(\r\n-2%\f\f\n\n\n,.85370596%,\n\t\f\n\f\n\r\f\t\r\r1989697.55564e+9731074% \t\n\f\n\n)";

this.AssertCssColor(item, 0, 2, 255, 255.0);
item =
  "\r\n\f\r\r\f\rrgB(-.7160230742%,235.1%\n\n\t\f,\t +4%)\r\n \t\f\t\f\r\r";

this.AssertCssColor(item, 0, 255, 10, 255.0);
item = "\r\n\f \rHsL(52.730,\f+.497E+32043%,.86%) \n\r";
this.AssertCssColor(item, 4, 3, 0, 255.0);
item = "\r\n\f#DFe2\f\r\n\f \n";
this.AssertCssColor(item, 221, 255, 238, 33.915);

item =

  "\r\n\r\n\f\n \t rgBA(-179\t\n\n\n,47\r\r,\r\n \r\r\f \t\r\f317247\n\f\r\f,+.18)";

this.AssertCssColor(item, 0, 47, 255, 45.9);
item = "\r\n\r\n\rrGb(\r\f\r\t\f\r\n838754\n,\f \t+3,\f\n169\t)\n\r\f\n\f";
this.AssertCssColor(item, 255, 3, 169, 255.0);

item =

  "\r\n\r\f\n\t\t\n\t\nRGBa(.3%\r,\r\n+.0600%,\r+77453.85e971%,\t\f\f.1E-5)\f\f\n \n ";

this.AssertCssColor(item, 1, 0, 255, 0);
item = "\r\n\r\r\r\n\rRGB(\t\f\n\t5,\f\t\n\r\n+33220, -728)\t\f\r\r\n";
this.AssertCssColor(item, 5, 255, 0, 255.0);
item = "\r\n\r#8bA";
this.AssertCssColor(item, 136, 187, 170, 255.0);
item = "\r\n\rrGB(\t\r\r361,-074473499,+1091\n\r \f)";
this.AssertCssColor(item, 255, 0, 255, 255.0);
item = "\r\n \r\n\n\f\r\f \r#eFf";
this.AssertCssColor(item, 238, 255, 255, 255.0);
item = "\r\n#0aD\f\n \r\t";
this.AssertCssColor(item, 0, 170, 221, 255.0);
item = "\r\n#Dafd59fF";
this.AssertCssColor(item, 218, 253, 89, 255.0);

item =
"\r\nRGBA(\t\r\n+1\n,\r\f\n\f \r\t\t156\n\n\r,+964\f\f\f,\n691265.057e-59\r\f)";

this.AssertCssColor(item, 1, 156, 255, 0);
item = "\r\nRGb(+76807321.42%,.536%,+.179592% \n\r\r\n\f)";
this.AssertCssColor(item, 255, 1, 0, 255.0);

item =
 "\r\nrGBA(.848%\r\t\n,+336.19%,\n\n+.68903004E95%\f\r\n \t,\t\n\n\n-493509e1)";

this.AssertCssColor(item, 2, 255, 255, 0);
item = "\r\f\t\fRgB(.36363E-6%\f\n,\t+920.0165%,.56e-55%\f)\f";
this.AssertCssColor(item, 0, 255, 0, 255.0);
item = "\r\f\tHSL(\r\n\f.24475\r \t,\f\n+.2%\f\f\n\n\r,-7%\f) \t\r\f\t\t";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "\r\f\n\n\n\f\f\f\n\fhSl(\t289E48384248040,\r\r\n\n\f+9397989%,\r\f\f\f\n-.3510174e+85832%\n\n\n\r)";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\r\f\n\f\rHSL(-.983E098683,\n\f\n\r\r\r\n\r\n.3586% \t,-36331.4%)\n";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\r\f\n\fRgBA(+.72%,-.3E8%\r\f\t,-29.62745%,.003\n\t\r)";
this.AssertCssColor(item, 2, 0, 0, 1.02);
item = "\r\f\n\r\f\r\nhsl(-5e-73322742663\f\n\r\r\n\f\n\f\f\r,.7%,\f+.313%\r)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\r\f\n\r\r\r\fRgB(\r\n\n\f\t-342\f\n\f\n \n,\f2594015,89)";
this.AssertCssColor(item, 0, 255, 89, 255.0);

item =

  "\r\f\n \n \f\r\f\fRgB(-1120440313.46210442E652312%,\f\r\n\n+.9113417e065541%\r ,\t+116.2647E86%)\f\f\n\f\f\n\r\f\n\n";

this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "\r\f\n \r\r\f\t Rgb(.9%,-.4947073%,\f+.25e-1925924%)\f \r\n\t\f\t\f";
this.AssertCssColor(item, 2, 0, 0, 255.0);

item =

  "\r\f\nRgb(\f-0.235231e05907%\t,\f\t\f\r\f +.2244e424%,\f\r\r \r1697E18%\r\n\r)\t\n\t\r\f\n\t";

this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "\r\f\nhsl(-.35E+998877341,.8926814726e88020865%,\r-.24088%\t\f\t)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "\r\f\f\rrGba(\n\f\n2,\n\r9,\r\r\f\f\f\n\n\n\r\r\r\n-388,\r\r+.931081e2)\f\f\f\n\t\f \f\n \r";

this.AssertCssColor(item, 2, 9, 0, 255.0);

item =

  "\r\f\fHsl(\r\r\f\n\t\t\n .42689\n\n\f\n\f,\f\n\n\n\t +.642893387378E2%,-348011%\t\n\r\n\r)\f ";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\r\f\r\f\f\r\fRGba(\f\n\r1946,6\n\f\t\r,\n\f+9\r,-.36\n\n \r)";
this.AssertCssColor(item, 255, 6, 9, 0);
item = "\r\f\r\rrGB(6,+067 \f\f,\n+9276662\r)";
this.AssertCssColor(item, 6, 67, 255, 255.0);

item =

  "\r\f\r \f\r\r\rrgba(+80499%\f\n,\n\f\f\f\n-.64911e94095%,+7541322.435e15%\n ,.220e-4847 \r\f)";

this.AssertCssColor(item, 255, 0, 255, 0);

item =

  "\r\f \n\f\t\f \f\t\rrgBA(369381788\n\r\n\n\f \f\t\r,87447\r\r\n,\r \t-4,+.7441701e-5\r\n \f\n)\n\f";

this.AssertCssColor(item, 255, 255, 0, 0);
item = "\r\f \n\f#afe2dF\f\r\f\n\f\f";
this.AssertCssColor(item, 175, 226, 223, 255.0);
item = "\r\f \n#bddFC3\f \t";
this.AssertCssColor(item, 189, 223, 195, 255.0);
item = "\r\fHSL(\n\r\t\n.3\n,-.907%\n,-.9882%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\r\fHsL(\f\r \n\f\f1.4795,\n\n\r \n\n.8%,\f\r\r\f\r-.9832163%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\r\fRGB(64\t\f\n\n\n\n\r\n,+8825\r\f,\t\n\r\t\r92\f)";
this.AssertCssColor(item, 64, 255, 92, 255.0);
item = "\r\fRGb(+4159\t\f\f,\n\t+5\f\r\n\t\r,\r\n\r\r\t-9443082\f)\f\n \f";
this.AssertCssColor(item, 255, 5, 0, 255.0);
item = "\r\fhsL(\t\n\r\f\t\f\f\f\n\n-940e-77\t,\f94257%,.6986%\t\n\n)\f \t\n\t";
this.AssertCssColor(item, 3, 0, 0, 255.0);

item =

  "\r\r\t\r\n\rRgba(.73%\n\f\n\t\n\r\r ,\r\t\n\f-.81%\r,\r\r\r\f \n\f\n+.1588900156e+3%,\r\r9.4898E89)";

this.AssertCssColor(item, 2, 0, 255, 255.0);

item =

  "\r\r\t\r\r\n\n\n\nRgb(.2e-50057%\f\r\f\t\n\r\n\t\r\t,\f-06.97786e-3%,\f-.58%)\n\f";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\r\r\n\r\f#fbc\n";
this.AssertCssColor(item, 255, 187, 204, 255.0);

item =

  "\r\r\f\r\n\f\n\n\r\n\rHsl(\n \f\r\f\r\r\n\n\f\t\r+.000,.6E-2%\t,0992570e-2162015%)\f";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\r\r\fRGBA(+4\n\n\n\f\f,\r 522,2, .4e-51811386)";
this.AssertCssColor(item, 4, 255, 2, 0);
item = "\r\r\r\t\r\r\f \n\f\tHsL(\r\f\r\r\n\t\f-05.4\r,7.5%\r,-.265%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\r\r\r \n\f \r\fhSl(\f\f \f5068.8e79147\n,.78e7%,-662867628%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\r\r\rhSl(.22164538E-3,+.0837e980%,.36684e2641449748%\f)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\r\r \t\t\nrgB(\n+.15% \r\r\n\n,9656.1E-15%,+7092%\r\n)";
this.AssertCssColor(item, 0, 0, 255, 255.0);
item = "\r\r hSl(.22,\r\t\f\r \n\r\f93.18%,\t\f\f\f\t\n-.02917E01%)\f\n\t\f";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\r\r#7Be9aF";
this.AssertCssColor(item, 123, 233, 175, 255.0);
item = "\r\r#aAd2 \f\f";
this.AssertCssColor(item, 170, 170, 221, 33.915);
item = "\r\r#bBd5Ab";
this.AssertCssColor(item, 187, 213, 171, 255.0);

item =
 "\r\rHsl(+.455053185E+27\r\f\n ,.06030e-27%\r\n ,\r-46286e+12%\f\t\f\t\t\f\t)";

this.AssertCssColor(item, 0, 0, 0, 255.0);

item =
  "\r\rRGBa(101\r\f,3155\f \f\t\n\r \r\n\r,\n99,461133.6E5\n\t\f\f \f\f\r)\n";

this.AssertCssColor(item, 101, 255, 99, 255.0);
item = "\r\rRGb(-4604595447,82\f\r\r\r\n\r\n\f\n\f\f,\r974371\r\n)";
this.AssertCssColor(item, 0, 82, 255, 255.0);
item = "\r\rrGbA(\n+73\n\t\r \t\n\r\r,-221\f, 42031\r\n,+80305.709902417)";
this.AssertCssColor(item, 73, 0, 255, 255.0);

item =
 "\r \n\f\n\f\nRGbA(36\r\n\f,\n\n\f\f\n866425799\n\t\r,0575972,\n4)\f\t\f\r\n ";

this.AssertCssColor(item, 36, 255, 255, 255.0);
item = "\r \n\r\f\n\rhsL(+1e-4\n\f\t,\n4.54%,3%\f\f\t\n\f)\f\t";
this.AssertCssColor(item, 7, 7, 7, 255.0);
item = "\r \r\t \nHsL(\n.2,+.7e5%,+.2e049%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "\r \r\f \rrgBa(\r101\n\n\r\f \f ,91696259\f, \r\r\n\f40 \f\n,\n\n\f\t\n-.9718119535)";

this.AssertCssColor(item, 101, 255, 40, 0);

item =

  "\r \f\n\t\f\n \tRgba(342\n,-8093\n\f,\r\r\n\f\f +1\t\n\r\f\f,\t.002125326026\f\t\r\n\r)\r\f\r\r\n\t\n";

this.AssertCssColor(item, 255, 0, 1, 1.02);
item = "\r #DFEfcD";
this.AssertCssColor(item, 223, 239, 205, 255.0);
item = "\r hsL(\f 873E+9507777 \r \t\n,+.56628831E+0%, 356%\r\r)\r\n\r\f";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =
"\r rgB(\f 3655%\n\t,-62.582821e+2%,\r\r\f .68214E+8%\r\t\t\r\n\f\f\r\r\r)\f\t";

this.AssertCssColor(item, 255, 0, 255, 255.0);
item = "\r#CbF7DF";
this.AssertCssColor(item, 203, 247, 223, 255.0);
item = "\r#bBCB";
this.AssertCssColor(item, 187, 187, 204, 186.915);
item = "\r#bb4b\f";
this.AssertCssColor(item, 187, 187, 68, 186.915);
item = "\r#d2CFE9Be\f";
this.AssertCssColor(item, 210, 207, 233, 189.975);
item = "\r#e90d";
this.AssertCssColor(item, 238, 153, 0, 221.085);
item = "\rHSl(\f\f\n\n \n-.7E-4590\r\n\f\f,.3E75%\r\t\r\f\n,-863%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\rHsL(\f \r .772481\n\f\t,+19E+4%,.46894E86%)\r";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\rHsL(\r +13e0108\n,\t\r\f\r.89460901E+3%,\n\f\f\f35.8477%\n\f\n\r\f)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\rHsl(-3,+809E+811799960%,\f -.3%\n)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\rRGB(\t\r\n\t1\r\f\r\f,1424957\n, +8\n)\r\f\f\n\n";
this.AssertCssColor(item, 1, 255, 8, 255.0);
item = "\rRGB(-98\f\n,+327, \r\f\r+0)\t";
this.AssertCssColor(item, 0, 255, 0, 255.0);

item =
"\rRGBA(\f\t\r 7.0663E0%,\n\r\n\n+.87e-6%,0.2786e-4440%\t\t,+.34)\r\r\r\r\r\f ";

this.AssertCssColor(item, 18, 0, 0, 86.7);
item = "\rRGBa(6\t\t\r,-08495\t,\f\f5,14e-4928\t)\r\n\n \t \r\r\t";
this.AssertCssColor(item, 6, 0, 5, 0);
item = "\rRGb(\t72,190847627\f,\f\t\f\r+2379)";
this.AssertCssColor(item, 72, 255, 255, 255.0);
item = "\rRGb(\r\f\n\f\r \t\n17,\r\t41010,+3825)";
this.AssertCssColor(item, 17, 255, 255, 255.0);
item = "\rRGbA(+7,\f \n\r\t\n\n+86\n \f\f\r\f\r,\t\f215 \n\n\f ,.2\n\n\n)";
this.AssertCssColor(item, 7, 86, 215, 51);
item = "\rRGba(48096646\n,\f1395,5640354\n,+034.8\r\n\n\n \n\r\n\n)";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "\rRgBa(\n\n\f \f+1274%\r \t\f ,-.99855% \r\t\f\f,-469395693%,+.5723\n\f\f\n\r\n\f\f\r)";

this.AssertCssColor(item, 255, 0, 0, 146.11499999999998);
item = "\rRgb(+5475546.7166464e-288335%,\f446.29E07%\n\f\t,\r223513340.2%\r)";
this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "\rhSL(4E827\r \r,\r+0.160E59%\f\r, -5.7540457%)\r\f";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\rhSl(\f-35e+885\r\f\r,.9%\n\t\r\f,\r+5E-01511%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =
  "\rhSl(\r\t\t\n\n\f+69033932486.197E+739,+.68%,\r\r \f\f \f\f774.92e+03134%)";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\rhSl(\r-9858E53,\n.6641e+0209%,+03505E0%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\rhSl(.8E21,\n.7e-50%,.9E+1%\n\n\n\f)";
this.AssertCssColor(item, 22, 22, 22, 255.0);
item = "\rhsl(\n14.40357e-212263,\n\r\f77E632%,\f\r3%\t\f\r\r\n\n\n)\r";
this.AssertCssColor(item, 15, 0, 0, 255.0);
item = "\rrGB(+955%\n\r\f\f\n\f, +880164e-208159%,\n\r\f-.396370%)";
this.AssertCssColor(item, 255, 0, 0, 255.0);
item = "\rrGb(2,340615,\n082220494\f\n \n\n)";
this.AssertCssColor(item, 2, 255, 255, 255.0);

item =

  "\rrGba(\t\f+74123\n\r,\n\f \t\n\t7639276\f\r,222736 , \f\n\n\f\t\t\n\f+2.712370E+7)\n\n\r \t\n\f";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "\rrgB(\t\f\r+7539\f\n\n,5\r\f,\f\f-36646536)";
this.AssertCssColor(item, 255, 5, 0, 255.0);
item = "\rrgB(-590\r\n,\r\r\n91809,\n+67)\f \t\n\n";
this.AssertCssColor(item, 0, 255, 67, 255.0);

item =

  "\rrgBa(\r3902788099.270446E-5486%, -9.22%\n,\n\n\r\n\r\n-.358134E+020%,\t \r\r583.14743)";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "\rrgb(+18,\r\r\n\r\f\r8,2\n\r\r\r\f\r\f\n) \n\f\f\r";
this.AssertCssColor(item, 18, 8, 2, 255.0);

item =

  "\rrgbA(\t\r\n \f8, \t\f+669,\n\r \n373365271231,\f\f\f\t-9e+68 \n\t\r\n\r\n\f\r)\f \f\f\n";

this.AssertCssColor(item, 8, 255, 255, 0);
item = " \t\f\f#CA1e";
this.AssertCssColor(item, 204, 170, 17, 237.91500000000002);
item = " \t\f\r\thsL(.81\t\n,\n\n.5104%\f\n\t,\r\n\n\f3% \f\r)";
this.AssertCssColor(item, 7, 7, 7, 255.0);
item = " \t\r\t\r\t\r RgB(594,\f\r\f\f2\r\n\n\f\r\f\n\f,6\r\f\t\r) \t\t\r\f";
this.AssertCssColor(item, 255, 2, 6, 255.0);

item =

  " \t\r\f\f\f\n\rhSL(\r.6 \f\f\t\f\n\n\f\n\f,\n\n6e94855%\r\n \f\n,\f\r\t\n220%)\r\r\n\f\t\f";

this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  " \tHsL(\r\f.0151427E+4069942851\f\r\n\n\r,+5E545180%\n\r,+.27E+6%)\r\n\n\r \r\n";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = " \tHsl(\r80.2,.655027%\f\f,.913751e+021832%) \n ";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item =
  " \tRGba(108e9%,\r\r\r+4623.4%,\n\n\r\f\r\t\f2274%,\n\r\t\n\r\r\r\n29999)";

this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  " \n\n\frgb(.3e4%\t\f\r \n,\n\f\f\n\r\r \r\n\r-.0484%,85998.2508E7610273% \r\r\f)";

this.AssertCssColor(item, 255, 0, 255, 255.0);
item = " \n\n\r\n\r\rrgB(\n\r47172\n, \t \r0155415\f \n\r \f\r\f,97\f)\f\f\r ";
this.AssertCssColor(item, 255, 255, 97, 255.0);
item = " \n\nrGb(\t \n\f\f-.728E2840205%,\n\r38705872413.80405%\r,+.4E3%)";
this.AssertCssColor(item, 0, 255, 255, 255.0);

item =
 " \n \frgbA(\t\f.7822757%,-0.0007%,\f\n\f.57%\f\r\n,\r\f.1882283)\n\n\f\t\r\n";

this.AssertCssColor(item, 2, 0, 1, 48.45);

item =
" \n hSL(+.0,+8E+0400271953% \n\r,\r.67128e202%\f\n \f\f\f)\r\n\f\f\n\f \r\f\f";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = " \nhSL(.9370,.0%,\f\t\n\t\r\n\f.5%)\t\t\r";
this.AssertCssColor(item, 1, 1, 1, 255.0);

item =
  " \nhSl(\t\n\n\n\r8224e-8\n\r\t\f\r\n\f\r,+.9882e2%\f\r\f ,\f-7e-2%)\f\r\t";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = " \f\nRgb(\f\r\t.7194492%,\n\r727156252%,\n\r\f\f+.549e922%)";
this.AssertCssColor(item, 2, 255, 255, 255.0);
item = " \f\f#cBb2EAAd\r\r\n\r\n";
this.AssertCssColor(item, 203, 178, 234, 173.4);

item =

  " \f\fhsl(-6671488.54295818E-1350,\r\f \t +.7751633%,\t-16.14321751412E+28%\r\n\n\n\n)";

this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  " \f\r\t\f\rrgb(+.1399548E+0416%\t,54657e-3%\r\r\r\n\r,-.53877e57%\t\n\t\r\r \f)\n\t\f";

this.AssertCssColor(item, 255, 139, 0, 255.0);
item = " \f\r\r\f\n\f\f\r#Cb29bAEb";
this.AssertCssColor(item, 203, 41, 186, 234.60000000000002);
item = " \fRgb(\n\r312081 \f,\n3,\f\f\n\n7434\f\n\r\r\n \t\f\f)";
this.AssertCssColor(item, 255, 3, 255, 255.0);
item = " \fRgbA(\f+06 \r,\n7,\n\n\r\f-5\f,-6)";
this.AssertCssColor(item, 6, 7, 0, 0);

item =

  " \frgBA(\n\n\r\t+806210628,\f \n\f783 \f \n\r,2001303\n\f,\t\f\t5.9\r\t\r\r)\f";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item =
  " \frgbA(\n\n\f\f3%,.929806e+83959720% ,\r\n-.0803e-70978%\n\r\n,-.902)\r";

this.AssertCssColor(item, 8, 255, 0, 0);

item =

  " \r\t\n\rRgB(29785194345e+6%\r\f,\r28.96%\r\r \r\f\t,\t\r \t+002247.933%\t)\t\r";

this.AssertCssColor(item, 255, 74, 255, 255.0);
item = " \r\tHSL(-7028.54\t,-9%\n\r,\f \f\n\t\r+.7768E+8%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = " \r\n\t \r\n#EffCcb5c\f\r\r\t\t\n";
this.AssertCssColor(item, 239, 252, 203, 91.8);
item = " \r\n\f\n\n\nRgBa(\f25709\n\f,-4,91\r, .346023638\n)";
this.AssertCssColor(item, 255, 0, 91, 87.975);
item = " \r\n \r\r \nRgB(-.238e37% \r\f\f,.932%,\r\r150%)";
this.AssertCssColor(item, 0, 2, 255, 255.0);

item =

  " \r\f \rhsl(+.5976288884\n \f\n \r\r, \f\n\n\f\f7.868E-9603%,.2811%\n\n\r\n) \f";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = " \r\frgB(+.85446e+8%,793625.33%\r,.853898260%\f\f\t\n\f\r\n\f)\r";
this.AssertCssColor(item, 255, 255, 2, 255.0);
item = " \r\r\r\n#cB1e \r\t ";
this.AssertCssColor(item, 204, 187, 17, 237.91500000000002);
item = " \r \f\r#dFB21FE9\f\n\f\n\t \r ";
this.AssertCssColor(item, 223, 178, 31, 233.07000000000002);
item = " \r#dADf";
this.AssertCssColor(item, 221, 170, 221, 255.0);

item =

  " \rRGbA(\r\f\r+.5%,\r\n\r\f\f\f\t\r-08725515.42%,\f\r\f\f2%\r\n\f\n\n,\r\r\r+.326928064E+53\f\r\n\n\f\t\t\r\f\f)\n\r\r\n\n \t\n\t";

this.AssertCssColor(item, 1, 0, 5, 255.0);
item = " \rRgBA(+12692,\r\r\n\f\f\r+707336\n\t \r\n\r,+730514 ,\n\n+5488E42)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = " \n\n\f\n\t\nhsL(+71.22202E1702229,\t-0e-9204%,\t6.834%)";
this.AssertCssColor(item, 17, 17, 17, 255.0);
item = " \f\n\r\f\t RgBa(.9E9%, \f-.478%,-.7287%,-54203e1\t)";
this.AssertCssColor(item, 255, 0, 0, 0);
item = " \r\f\r\n\r\t\f\t\rRgb(\f\n\r\f\r24\r,\r \f21\r\t\n\r\r,5)\n";
this.AssertCssColor(item, 24, 21, 5, 255.0);
item = " RGB(.94444e-662280%\f\t\r\t,-5.0951E6%, +601%\f\r) ";
this.AssertCssColor(item, 0, 0, 255, 255.0);
item = " #A1dcdc";
this.AssertCssColor(item, 161, 220, 220, 255.0);
item = " #CdDdAbBB";
this.AssertCssColor(item, 205, 221, 171, 186.915);
item = " #DFBA";
this.AssertCssColor(item, 221, 255, 187, 170.085);
item = " HSL(.66,\t03.8e-18%,\f\f\f-22%\r)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  " HSl(\n\f\t05229560422\n\r\f\t\t\f ,.1459e98676702%\n\r ,.10882%\r\f\t\f\n)\n\r\t\n\n\f\f\t";

this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  " Hsl(\t\t\n.9\r\f \r\r\n\f,\f-6676%\n \r\f\r\f\f\f,\r1338.78855967%)\t\n\n\t\t\r\r\r \f\r\f";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = " RGbA(.375278%,4574%,70.88E6%\n\f,\r8.4\f\r)";
this.AssertCssColor(item, 1, 255, 255, 255.0);
item = " RgB(6\r\f\t\r\r,39,\t\n94617)\r\f\t\r\r";
this.AssertCssColor(item, 6, 39, 255, 255.0);
item = " Rgb(\n\f\r\f\f-.6%\n,\f \f\r1669.28773602614%\f\r,.73%)\r\r\f\t\t";
this.AssertCssColor(item, 0, 255, 2, 255.0);

item =

  " hSL(+.15912707000E-62\t\n ,+56.1187025039E+98466371%\r\n\n\t\n\n\f\r\t,6002685e605927%)\f\r \r\r";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = " rGbA(+61383781%,6432.59e0%,871610%,+.0226E18\t\r\n\r\r\t)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = " rgB(.20%\f\f,\n\r\f\r\n\f\r \f\f+.7586e593%\n,\t\f\f9E+41% \r)";
this.AssertCssColor(item, 1, 255, 255, 255.0);
item = " rgBA(\r.85%,.26E+5708%,\n+.7E7%,+.5573494\n)";
this.AssertCssColor(item, 2, 255, 255, 142.03500000000003);
item = "#1BB\f ";
this.AssertCssColor(item, 17, 187, 187, 255.0);
item = "#3Ec6";
this.AssertCssColor(item, 51, 238, 204, 102);
item = "#4c14\t\f\n\r";
this.AssertCssColor(item, 68, 204, 17, 68.08500000000001);
item = "#5C9b\r";
this.AssertCssColor(item, 85, 204, 153, 186.915);
item = "#6A7D1dAB";
this.AssertCssColor(item, 106, 125, 29, 170.85000000000002);
item = "#96bE7Abf";
this.AssertCssColor(item, 150, 190, 122, 191.25);
item = "#A3bffAaa";
this.AssertCssColor(item, 163, 191, 250, 170.085);
item = "#ABB017ad";
this.AssertCssColor(item, 171, 176, 23, 173.4);
item = "#AD04Efc9\t\r\f ";
this.AssertCssColor(item, 173, 4, 239, 201.45000000000002);
item = "#AD83FB9B";
this.AssertCssColor(item, 173, 131, 251, 155.04);
item = "#AaC";
this.AssertCssColor(item, 170, 170, 204, 255.0);
item = "#AfEd\t\r \r \r\r";
this.AssertCssColor(item, 170, 255, 238, 221.085);
item = "#Afee";
this.AssertCssColor(item, 170, 255, 238, 237.91500000000002);
item = "#BafFAd";
this.AssertCssColor(item, 186, 255, 173, 255.0);
item = "#BdB8baa5\f\f";
this.AssertCssColor(item, 189, 184, 186, 164.985);
item = "#BdDE";
this.AssertCssColor(item, 187, 221, 221, 237.91500000000002);
item = "#Bef";
this.AssertCssColor(item, 187, 238, 255, 255.0);
item = "#C0ccFE";
this.AssertCssColor(item, 192, 204, 254, 255.0);
item = "#C1C";
this.AssertCssColor(item, 204, 17, 204, 255.0);
item = "#CEdcc56C";
this.AssertCssColor(item, 206, 220, 197, 108.11999999999999);
item = "#Cd3CE52e";
this.AssertCssColor(item, 205, 60, 229, 45.9);
item = "#CfBaecdB";
this.AssertCssColor(item, 207, 186, 236, 219.29999999999998);
item = "#CfCadA4B";
this.AssertCssColor(item, 207, 202, 218, 74.97);
item = "#DADFb4cA";
this.AssertCssColor(item, 218, 223, 180, 201.96);
item = "#DBfbee";
this.AssertCssColor(item, 219, 251, 238, 255.0);
item = "#DD5";
this.AssertCssColor(item, 221, 221, 85, 255.0);
item = "#DdAfea";
this.AssertCssColor(item, 221, 175, 234, 255.0);
item = "#Ddcf69d9";
this.AssertCssColor(item, 221, 207, 105, 216.75);
item = "#E5D";
this.AssertCssColor(item, 238, 85, 221, 255.0);
item = "#EA7ACCAa";
this.AssertCssColor(item, 234, 122, 204, 170.085);
item = "#EFE\n";
this.AssertCssColor(item, 238, 255, 238, 255.0);
item = "#FBeFCf\t \n";
this.AssertCssColor(item, 251, 239, 207, 255.0);
item = "#FdDeBD";
this.AssertCssColor(item, 253, 222, 189, 255.0);
item = "#FdbEdf0e\f";
this.AssertCssColor(item, 253, 190, 223, 14.025);
item = "#a7fF\r\f\r\f\f";
this.AssertCssColor(item, 170, 119, 255, 255.0);
item = "#aBD";
this.AssertCssColor(item, 170, 187, 221, 255.0);
item = "#ab4Eae\n\f\t\t\n";
this.AssertCssColor(item, 171, 78, 174, 255.0);
item = "#aceA";
this.AssertCssColor(item, 170, 204, 238, 170.085);
item = "#af8E";
this.AssertCssColor(item, 170, 255, 136, 237.91500000000002);
item = "#bAAc\f \f\n\f";
this.AssertCssColor(item, 187, 170, 170, 204);
item = "#bB4d4f ";
this.AssertCssColor(item, 187, 77, 79, 255.0);
item = "#bab\r\f\n\f\f\f\n\f ";
this.AssertCssColor(item, 187, 170, 187, 255.0);
item = "#bcfcbC\r\t\n";
this.AssertCssColor(item, 188, 252, 188, 255.0);
item = "#bfDecEDe\r";
this.AssertCssColor(item, 191, 222, 206, 221.85);
item = "#c2b8 ";
this.AssertCssColor(item, 204, 34, 187, 135.91500000000002);
item = "#cEC\f \f\r";
this.AssertCssColor(item, 204, 238, 204, 255.0);
item = "#cc0\f\f\n\f";
this.AssertCssColor(item, 204, 204, 0, 255.0);
item = "#cfa\f\r\r\r\r\t\r\f\f\t";
this.AssertCssColor(item, 204, 255, 170, 255.0);
item = "#d5bB";
this.AssertCssColor(item, 221, 85, 187, 186.915);
item = "#dB2\f \t";
this.AssertCssColor(item, 221, 187, 34, 255.0);
item = "#e5E4D107";
this.AssertCssColor(item, 229, 228, 209, 6.885);
item = "#eDFfbf\n\r";
this.AssertCssColor(item, 237, 255, 191, 255.0);
item = "#ecc";
this.AssertCssColor(item, 238, 204, 204, 255.0);
item = "#fBBAFB\r\n \t\r\n\r\n\f";
this.AssertCssColor(item, 251, 186, 251, 255.0);
item = "#fEf";
this.AssertCssColor(item, 255, 238, 255, 255.0);
item = "#fbcb0ACD\r\t\n\f\f ";
this.AssertCssColor(item, 251, 203, 10, 205.02);
item = "#feEe";
this.AssertCssColor(item, 255, 238, 238, 237.91500000000002);

item =

  "HSL(\t+2E-62\f\n\n\r,\f\n\r\n\n \f\f\f9e12%\r\t\r\t\f\r ,\n\f\t\r\f\f-13.985e-677343% \n\t)\f\n";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "HSL(\n\t+1E+2048223\r\n\n,\r\n -106.1%,64e+3075%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HSL(\n\t4e-875286\r\n,\n\n\n\n\n+.7540%\n\r \n\n,\f\r\f\r -.88872%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =
  "HSL(\n\n\f\r\r\n\r+9.4919e6 ,\f\r\f\t-.720106E-058%\r\n \r \f,\r+.8E110%)";

this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "HSL(\n\r\f\n -65e+28 ,91698710590e50%\r \f , \r\f\r \r\r\f-.7%\t\r \n\f)\f\f\f\n\f";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "HSL(\n\r\r\t\f\f\t .752,\n-.67E+0%, \f\r\t.3038842728%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =
"HSL(\f\n \r\r\n-.44269E4075,\n\n\f\r\n.7e-19%\r\r\f\n\t\r,\n.35479246%\f\n\n)";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "HSL(\f\f\f-.76499E-06,\n\r+.3% \r,.591e+7986%)\f\f\t\n\f\f\f\r\r ";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item =
  "HSL(\f\r\t1.20\r,601323775.70308E286%,807858% \t\n\n) \f\r\f \n\f\f\n\r";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HSL(\r\t\r\r\r+.124564435\t\f \r,-.6%\r\t\n,\n\r\r8.1%\r\r)";
this.AssertCssColor(item, 20, 20, 20, 255.0);
item = "HSL(\r\f+.47,\f\r.0901%,+3E021497521%)\f\f\r";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HSL(+.8846394931e-31,\f\f25654%,-.5058287%\r\n \n\n)\t";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "HSL(+.4E857,+30.60026e7% ,\f-2E6241437%\n)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "HSL(-.30862e5916,861e-6%,\f+00433E+718873867%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HSL(-.60919\r\r\r,93666854%,.3178854e+394274%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HSL(-0,\f\n\n180.3%,-97.40%\r\f\f \t) ";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "HSL(-5.4E9165824,190%,588.84E+0%)\n\f\t\f\n";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HSL(237e-2862,\t+.753%\t\r\f\n\f\f\r\r, \t \f\r\t\f\n71441e+88%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HSl(\n\t\n\f37235E-657\n,01e4184577%\f\n\n\f\f,.474E9457994818%\r\f)\n";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HSl(\n \n\n\n-6.4,-9.72371%,0026343%)\n";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HSl(\f-.7e-76\f\r,98075e+79%,\f\r\f\t\n\t\f \t\f\f7648%\f)\r";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "HSl(\f.86835450E42\n\n\f\r\f\r,+.2592E3705153% \n\r\f\n, \r\f+54.3E+04765%)\r\n\n\r\n\n";

this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "HSl(\r\n-46397268757,\f\r \t\r+.28%\f\t\n\f\f\f\f\f\r\r\n\r,-.3968%\f\f\r)\n\r";

this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "HSl(\r\f \n\r\f \f+.3000e0\f ,.63696730036E1%\n\t\r\f\r\n,\n\f+.4412E+78831%\n\r\r\n\n\r)";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HSl(\r\f \r\t\n1.215344e+88300\t,7e-59%,\f.386676700943%)\f\f\n\f \r ";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "HSl(\r-.33e519\f \f\n\n,\n\n\f\r \n\t+993721.9812E-63%, \f.584231%)";
this.AssertCssColor(item, 1, 1, 1, 255.0);
item = "HSl(-.623e+8470754, \n\t \n-.5E-09%,7434303%)\r\r\r";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HSl(-.099156\t,\n-56429%,+13E175803%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HSl(3e862\f,+82214%\t\r\r\r,\r\t\n\f\n\n\r\r \f\f-.43E5914%)\n\f";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "HSl(6,.91275496E+7%,+0059.1921486E037%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HSl(9436.77581\n,\n1E-6%, \f\f.440E11%\f \f\n)\f";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HsL(\t\n\t .627E-1362,\r-.156%\n\t\n\n,\f\f\f \f+.33%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "HsL(\n\n\t020e-327,7411.66078E-3957%,-.78%\f\f\r\r\n\t)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =
  "HsL(\n\r \r\r\t\t+.62\r\r\f\n,+.21198E0800%\f\n \r\r\n,\r\f\r-8.4460%\n \t)";

this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "HsL(\n-174457e43406719\r\n\n\n\n\r,\f\r\n\n\n -.376795E100107%\f\t\n\n,04541.1898%)";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HsL(\f\f\n\r \f\r-79E-987094634,9.64E-85%,\r.070053801%)\f";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "HsL(\f\r\r\f\f\r.14406e+6\n\f\f,+.8%\r\t\r\f,\f\f\f\n\f+7.24%) \n\r\n";
this.AssertCssColor(item, 18, 18, 18, 255.0);

item =

  "HsL(\r\t\n\f\n\r-27\t,\n\r.0016715E-7153%\r \t\r,\n\f\f\n\n\f\r 42.9373553E+40456310%)";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HsL(\r\t\n\r\f\r-9e-0 ,-.5894432e+7%,\f-.686956%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "HsL(\r\f-.9,-8327188746.504%\r\r\r\r,\f\r\n7054%)\n\f ";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HsL(\r\r\r-.453e0640\n\n\f\r\r,+.31%\n\f\f,\n\f+.0e768861%)\f";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "HsL(+.517E+1\t,+.42% \f ,+43097.6279314%)\f \n\r\r";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HsL(+.83962E-1088,\n-.67e1312%\r\n\f\f\n\r\f,-.1%)\t";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "HsL(-.03511506e760145,-778077.9E98%\t\f\f,71146.5e398%)\n";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "HsL(-.70848948,-.91e5%,-.121140e11036098%\n\r\r\f\n)\r\r\n\n\f\t\r\n";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "HsL(98E-59\n\n,\f-.11e-11188751%,\n9698.3E478%\n\n\r)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item =
  "Hsl(\n\r\t.1787455462e563 \r,+318041.34%,-.6E+737438638%\n\t\r\n \r\n\r)";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "Hsl(\f\n\r\t\n.873128232e+2,77e6638%\n\r\r \f,\r\n2%)\f\f\r \n";
this.AssertCssColor(item, 5, 10, 0, 255.0);
item = "Hsl(\f\f\n\f\f+060601.146392e+527, \f.29e+7281%,\n\t5.8E402526%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "Hsl(\f0.53e6254\t\n\n\r \r,\f \t\r\f0789%,512447.332e155138%)\t\r\f\r\f\f\n\n\r";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "Hsl(\r \r.776,\r\n\r\t .2304486% \t,\f923.4467506997%)";
this.AssertCssColor(item, 254, 255, 255, 255.0);
item = "Hsl(\r+98959.0,13.6607390383%\r\r,.50%)";
this.AssertCssColor(item, 1, 1, 1, 255.0);
item = "Hsl(228.38\r\r\n,\f\n\f\n\r\t\n97E018108577%,1532.24%\f)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "Hsl(36\f\r \f\f\t\f,77492.65% ,\n\t.3791570e489188178527%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "Hsl(61.9704E+17417259436,63439.1E6842%,+.7e3350% \n\r\n\n)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "Hsl(90.4097119\r\t\r,+.765E337%,.1733%)\r\n\n\n\n\r\r";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "RGB(\n\f \f -61.4441E69560359%\n\f\n,\r\n.2351564523%,.51%\r\t)\f";
this.AssertCssColor(item, 0, 1, 1, 255.0);
item = "RGB(\n+41657025,36819, 77963\r)\t\n \t\n\r";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "RGB(\n+6\r\f,\t\f2,09186)";
this.AssertCssColor(item, 6, 2, 255, 255.0);
item = "RGB(\f\r \f -372597,6667,-11248938 \n\n\r\r)";
this.AssertCssColor(item, 0, 255, 0, 255.0);
item = "RGB(\f+.6%\r\t,\f\n\f\t\n\r\r \n\f\t\n33474%\n\f\n\r\t,0%\r\r\f\r\n)";
this.AssertCssColor(item, 2, 255, 0, 255.0);
item = "RGB(\r\t\r\n859255\n ,-14,-192)";
this.AssertCssColor(item, 255, 0, 0, 255.0);

item =
  "RGB(\r\f.1%,\r\f6936363886.9025%\t\n \f\r,\n \r\f8.9e8383%\r)\f\n\r \n\r\n";

this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "RGB(\r +40,+1745986,-86) ";
this.AssertCssColor(item, 40, 255, 0, 255.0);
item = "RGB(+.9686E5133%\n ,-.7e-81%,+29e-40228%)";
this.AssertCssColor(item, 255, 0, 0, 255.0);
item = "RGB(-299089,\f\r\t 2\r\r,\r\r+80\r\f)\t\f ";
this.AssertCssColor(item, 0, 2, 80, 255.0);
item = "RGB(-41665969352,\r\n\n\n -5170343826\f, \n\f\f\r+6372598)";
this.AssertCssColor(item, 0, 0, 255, 255.0);
item = "RGB(-6337476098, \n4\n\n\f\f\r\n\t\t\t\n,\n\r\n\n\r \f 3)\r \n\n";
this.AssertCssColor(item, 0, 4, 3, 255.0);
item = "RGB(-9839\n\n\r\n\n \n\f\f,-7\n\r\t,36\n\f\f\f\f\r\r\n)";
this.AssertCssColor(item, 0, 0, 36, 255.0);
item = "RGB(.6%\f\r,\r+.5e90%\f\f\r\n,\r5426.5E+13702%\f \n)";
this.AssertCssColor(item, 2, 255, 255, 255.0);

item =

  "RGB(3338.537e0781% ,\r\r\r\f \n\f -4957.66134E85676%\f\n\r\r,\r\f\r+5567930313.8E18%)";

this.AssertCssColor(item, 255, 0, 255, 255.0);
item = "RGB(562\f\n\f,\f\n\f\r\f\t695585,\f-1243\r\n)";
this.AssertCssColor(item, 255, 255, 0, 255.0);
item = "RGB(61.240846543%\r\n,\n\f\r-.348E60969%\f\n,\n\r\r\n-.469e-06%)";
this.AssertCssColor(item, 156, 0, 0, 255.0);

item =

  "RGB(7.5767E2%\r\t\r\n\f\n\r\r\f\r\t\f,-0732612.1537%\n\r\f\r,\n\f \f\f.0e-41162%)\r\n";

this.AssertCssColor(item, 255, 0, 0, 255.0);
item = "RGBA(\f\f\f\r +.53733e28%,97.37537614817e+455266%, -.74%\r,\r+.9\n\n)";
this.AssertCssColor(item, 255, 255, 0, 229.5);

item =
"RGBA(\f\f\r1542.7e881% \t,+565.90E-278%\f\f\r\n,\f0182E275%,7877.3\t\t\r\n\n)";

this.AssertCssColor(item, 255, 0, 255, 255.0);
item = "RGBA(\f-6\n\r ,+9000\n\r\r\r\f, \f\n \f\r-6,+7199E3)\f";
this.AssertCssColor(item, 0, 255, 0, 255.0);

item =

  "RGBA(\r\f.33364221E1785596069%\f \r\f\t\f,\f\f\n\f \r-327.57E+25%,\n\n\r\f\f\f 6179%\f \r\r,\r\r\f\n\f\n\r\f\n\f5570233009E-95169\r\f)\f";

this.AssertCssColor(item, 255, 0, 255, 0);
item =
  "RGBA(-92483\t\r\r\t\n\n\t, 7622403016\r\n\f\f\t\n\f\n\f\n,-482,5254E-1)";

this.AssertCssColor(item, 0, 255, 0, 255.0);
item = "RGBA(0344,5056395533,+163\n\r\r\r,.642272e-142\r\f)";
this.AssertCssColor(item, 255, 255, 163, 0);
item = "RGBA(33831898\n\f,\n\r\t\r\n859,-5,+83307526e+671965712\f)";
this.AssertCssColor(item, 255, 255, 0, 255.0);
item = "RGBA(69503,73\f\f\t\f\r\n\r\n\r,+6\f,.6e-5558898)";
this.AssertCssColor(item, 255, 73, 6, 0);

item =

  "RGBA(74.291E30195%,\n\r\r\n\f\r\f\n-070115.2038685E1%,-668e-71%,\n\n\r\r\f\f\n62995.2E+156395)\t\f ";

this.AssertCssColor(item, 255, 0, 0, 255.0);
item = "RGBa(\n\t\f\f\t 3363,\f01315173\n\t ,-26,\r-60e234370\r \r\n\r)";
this.AssertCssColor(item, 255, 255, 0, 0);
item = "RGBa(\f\r\n\n 6\r\f\t\f\r\n,\r+5,\r8,\r.868)";
this.AssertCssColor(item, 6, 5, 8, 221.085);

item =

  "RGBa(\r\t\n\n\f\r\n\t\r\f477,\n-112171145,\t-25,\n-9647007753e+69342)\r\t\n\n\f\n\n\f\f\n\t";

this.AssertCssColor(item, 255, 0, 0, 0);

item =
 "RGBa(-8\r\f\t,\r\r\r8\n\t\n\t\r\t\f\r , \f\f\t\n \f\t10167178\f\r\n\n\r,.00)";

this.AssertCssColor(item, 0, 8, 255, 0);
item = "RGBa(-326,000717\f\r\f\f,+969,\n -.1E+28781\r\f\n \f\n\f) \f \r\r\f";
this.AssertCssColor(item, 0, 255, 255, 0);
item =
  "RGBa(-420512029252\t\n\f\r\n\t,-7849, \r\r\n+0\r \r\t\f,\r.480)\n\t\r\t";

this.AssertCssColor(item, 0, 0, 0, 122.39999999999999);
item = "RGBa(1.795e-7160%,\n+4.2e163%,-75E-44%\f,\t\r\r\r\r.4e+2\r\f)\f\r ";
this.AssertCssColor(item, 0, 255, 0, 255.0);
item = "RGb(\t\f\f\t3,\t\r\r-0\f\r,+5626\t\r\r\r\t\r\n\n)\r\f\n";
this.AssertCssColor(item, 3, 0, 255, 255.0);
item = "RGb(\n\n\f\n\r\n 37,3\f,+9)";
this.AssertCssColor(item, 37, 3, 9, 255.0);
item = "RGb(\n\r67345284,3,\n\n \r\r-154)";
this.AssertCssColor(item, 255, 3, 0, 255.0);

item =

  "RGb(\f\n\r\f+9881683.77992%\f, \r\r \n\t\n \n+0e67%,\n\t \f\t\f\f\n \n.610E397%\r\t\f)";

this.AssertCssColor(item, 255, 0, 255, 255.0);

item =

  "RGb(\f\r.235534E94782%,\f\n \r\r +.101%\n\f\n\f\f,\r776085671e39361592%)\r \n\n\n\f";

this.AssertCssColor(item, 255, 0, 255, 255.0);
item = "RGb(+08809274,30\n\t\n\t\n\n\n\f\n, \r\n\n\r865535)";
this.AssertCssColor(item, 255, 30, 255, 255.0);
item = "RGb(+3\r\f\f\r\t,750918736,\f74106526)\f \n";
this.AssertCssColor(item, 3, 255, 255, 255.0);
item = "RGb(+8042%,-3132.0%,.12e+1586%\f\n\n\n\r\n\t\t\n)\t\r";
this.AssertCssColor(item, 255, 0, 255, 255.0);
item = "RGb(-.33%,\t\f\f \r\n .7E9%,.37E82%)";
this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "RGb(-04100,27\n\n\t,\n\r1061477783)";
this.AssertCssColor(item, 0, 27, 255, 255.0);
item = "RGb(-2,-1,\r\f\n114643)\t \n";
this.AssertCssColor(item, 0, 0, 255, 255.0);
item = "RGb(.875%,\n\t \n\n\n\n.8%,.607%\t\r)";
this.AssertCssColor(item, 2, 2, 2, 255.0);
item = "RGb(5,9\r,\f-4403) \n\t\f \r\t";
this.AssertCssColor(item, 5, 9, 0, 255.0);
item = "RGb(7,\n\n5290173,017641)\r";
this.AssertCssColor(item, 7, 255, 255, 255.0);
item = "RGb(9.485622%\n,\n.533%\r\n\r\r,\r\n\r\r\f\f.05%\n\f\r)\n\r\n \r";
this.AssertCssColor(item, 24, 1, 0, 255.0);

item =

  "RGbA(\t\t .2%\n\f,3451731177% ,\t\n\n\r\f+443282e-55%,\f\t\t\t\r \n+32629E+714 \r)";

this.AssertCssColor(item, 1, 255, 0, 255.0);

item =

  "RGbA(\n0.070%\n\r\t\t\r, \t \t-67e-1%,9e+081164293%\r\f\f\r\n\r,42315.8e-2) \n";

this.AssertCssColor(item, 0, 0, 255, 255.0);

item =

  "RGbA(\f\r\f\t\f\n\t\f\t-.22957%\r\f\t\f\f\f,0.70912E+8615%,\n\f\r\r\n\n-1713710E-693532132893%,-.736e-552\r\f)";

this.AssertCssColor(item, 0, 255, 0, 0);

item =

  "RGbA(\f \f\r\r\f-18661456968 \f\r\n\f\n \f\f\r,\f\f\r\r195742,\f\f9,57082e0)\r";

this.AssertCssColor(item, 0, 255, 9, 255.0);
item = "RGbA(\r\f-0,-002585\r,\f\f+616\n\r\n ,-.989E+9\n)\f\f\n\f\f\n\t ";
this.AssertCssColor(item, 0, 0, 255, 0);

item =

  "RGbA(+135563.34591e854335070%\f\n\n\t,\r\f\f \f\n\n1502981E-3%\f\r,\n\f \r\r\n\r \f87968435.526%,\n-86)";

this.AssertCssColor(item, 255, 255, 255, 0);
item = "RGbA(-.628e3%,9658.609828E392%,-8000.9814047%,.4340E5107\f\n\t\r\f)";
this.AssertCssColor(item, 0, 255, 0, 255.0);

item =

  "RGbA(21151564069\t\n\r\r\f\f\f,\r\f\f\n\f \n\n\f\t+4,-9\f\f\n,\t\t7099.062945672\r\n)";

this.AssertCssColor(item, 255, 4, 0, 255.0);
item = "RGbA(25630\n\f,\r \n\n54,2,-0155.5e53681) \n";
this.AssertCssColor(item, 255, 54, 2, 0);

item =

  "RGba(\t\f\r\n.78161e-8165903% \r\r,\n1.75858324%\r \t\r\t,\f-10.78E+48277290% \r\t\r\f\r\r ,.3e-2287\n\f\t)";

this.AssertCssColor(item, 0, 4, 0, 0);
item = "RGba(\n\f-452285238\t\t\f\r\r \f\f,04991\r\f\r,5307\r,\f\r \f\f+.94e1)";
this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "RGba(\f920\n,02\f\r\f\n\r\n,\f-40\r\t,+079.5563327989)\r";
this.AssertCssColor(item, 255, 2, 0, 255.0);

item =

  "RGba(\r\f\f -.2E976783%,\f\r\r+.3E+608%\r\r \n\r\r\t\f,17.272449384%,52e-44)\r";

this.AssertCssColor(item, 0, 255, 44, 0);

item =

  "RGba(\r\r+868.967e10881%\n\r,+.24%\r\r\r\r\n\t\r,72%\f\f,\r\r\n\f\f.2E2\f)\t\n\r\r\r";

this.AssertCssColor(item, 255, 1, 184, 255.0);
item = "RGba(\r\r\f\n+031%,\n726%\f\f\n \f\n,\r\t-.253217e728%,.3e+1\n\t)";
this.AssertCssColor(item, 79, 255, 0, 255.0);

item =

  "RGba(.239990383%\t\r\n\n\f,\t\n\f\f\r\t\r\r\f\r\n.35%,-.9199%\f\r,\f\r\t-59.905e864)\n\r";

this.AssertCssColor(item, 1, 1, 0, 0);
item = "RGba(0 \t \f,\t\r\n68,\r\f \r+363,759.9589856668E+9)";
this.AssertCssColor(item, 0, 68, 255, 255.0);
item =
  "RGba(1753\r\f\n\n\n\f ,\n1697398,+3,\f\r\r\r-.39)\f\n\t\n\f\r\r\r\f\f \f";

this.AssertCssColor(item, 255, 255, 3, 0);
item = "RgB(\n\r6 \n\f\n \r,\t\n\n\r\f2549617,-68258\n)";
this.AssertCssColor(item, 6, 255, 0, 255.0);
item = "RgB(\n.1145%,+646e8%,.4E+9712939%)";
this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "RgB(\f\n\t\n+.5071254%,\f\n+2002%\r\n\t,+1E-255571%\n)\f ";
this.AssertCssColor(item, 1, 255, 0, 255.0);
item = "RgB(\f\n51,\f\r\f\r-3686,\f-85)\r\r";
this.AssertCssColor(item, 51, 0, 0, 255.0);
item = "RgB(\f 37502820\n,\f+4,\f\n\f \n270)\f\f\f";
this.AssertCssColor(item, 255, 4, 255, 255.0);
item = "RgB(\f +5030E551%,.501597%,-.7%)";
this.AssertCssColor(item, 255, 1, 0, 255.0);
item = "RgB(\r\f\n-2%\n\f\f,\n-.5991554%\n ,\n\n+.33054020E5%\n)";
this.AssertCssColor(item, 0, 0, 255, 255.0);
item = "RgB(\r\r+6555\r,7\t\r\f\f\f\f\f\f,\n63)";
this.AssertCssColor(item, 255, 7, 63, 255.0);
item = "RgB(+.8%\t,\f\f\n.911%, .42%\n\r\f\f\n) \f\f";
this.AssertCssColor(item, 2, 2, 1, 255.0);
item = "RgB(+.85126%,0.73535E30%,498717547.05%\f\f\f)";
this.AssertCssColor(item, 2, 255, 255, 255.0);
item = "RgB(+164.217E6430422%,-417759.7684e+4%\f\t\f\n\n\t\n,+96E11539126%\f)";
this.AssertCssColor(item, 255, 0, 255, 255.0);
item = "RgB(-.2e487%,-.54e-645057632%\n\t\n\n,.760E1%)\n\n\f\r\n\n\n\n";
this.AssertCssColor(item, 0, 0, 19, 255.0);
item = "RgB(-.8e309480108972%\f\n\r,+.7802e-391991%,\r\n\f\f.4%\r)";
this.AssertCssColor(item, 0, 0, 1, 255.0);
item = "RgB(-40, -6138,\f\n-252)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "RgB(2376,22,\r93\n\r)\f\f\r\n";
this.AssertCssColor(item, 255, 22, 93, 255.0);
item = "RgB(56193836 ,\r\r\f\r 7343\f\n\f\r\f,\t+8)";
this.AssertCssColor(item, 255, 255, 8, 255.0);
item = "RgB(71\f,+98,\n\t\n\r\n\f\t\f\t88)\n\f";
this.AssertCssColor(item, 71, 98, 88, 255.0);
item = "RgBA(\t\t\r\r\n+1,57340690 , \t\t857967\f,2200.2e600973\n\r)\t\f";
this.AssertCssColor(item, 1, 255, 255, 255.0);
item = "RgBA(\t38.639e-980077%,.003%,+.9490E4%\n \t ,-.0885)";
this.AssertCssColor(item, 0, 0, 255, 0);
item = "RgBA(\n\n\n\r\r \t-4\f,8737417598,566876\t\f\r\r\f\r\f\f\t\t,\f +.0e6)";
this.AssertCssColor(item, 0, 255, 255, 0);
item = "RgBA(\n\r\n330,+4 \r,\n\r\f\n\n\f\t 9479,\t-.8)";
this.AssertCssColor(item, 255, 4, 255, 0);

item =

  "RgBA(\f \t\n \f\f\n\f946.94446982341E6470%\t \t,\f\f\n\n\t-71.8E511624%,\f\f.42301e4%\t\f\n\t\r\n, \f+.2\f\n\r\n\r\f\r\f\r\n)\f";

this.AssertCssColor(item, 255, 0, 255, 51);

item =

  "RgBA(-.3%,3585746.66777E9% \f\t,951.1642887%\r\n\r \f,\n\n.1192670e+41829727 \f\t\n\f)";

this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "RgBA(-2,\r\n\r \n\r9564059542,\n+8,29189.4e691\t\f)";
this.AssertCssColor(item, 0, 255, 8, 255.0);

item =

  "RgBA(-64457176.43E+82814442%\r\r,\r\t\t\n\n\f\n.2e1514%\r\r\f\t\n\f\t \t\n,4506707e11151734%\f\r\t,.4e-562\f\f\f\f\n\r) \r\f\t ";

this.AssertCssColor(item, 0, 255, 255, 0);
item =
  "RgBA(.760e+9%,8891.3652135360%,-084651e254662%\r \r\f\r,+085.6E24) \r\n";

this.AssertCssColor(item, 255, 255, 0, 255.0);
item = "RgBa(\t\r\f63,\t247971,-7 \r\f\f\r\r\r\r\r,4516679E+8646 \f\r\r\t)";
this.AssertCssColor(item, 63, 255, 0, 255.0);

item =

  "RgBa(\f\t\n \r+.9008%\n\f,+8964e3034%,-735255570.999e67%, \n \r\r\t\f.7275)\n\f\r\r\f\f\f";

this.AssertCssColor(item, 2, 255, 0, 186.15);
item = "RgBa(\r\r-857563756\f,349318\t\f\f \n\r\f\r\r,+28\r, \n\n\r+6.5)\t";
this.AssertCssColor(item, 0, 255, 28, 255.0);

item =

  "RgBa(\r-979580\n\f\r\f\t\n\r \t,\r955\t,\n\n\n\r\f\f00,\n\n\f\n\n\r\f\f\r\r\r45.32158827e098007\n \r\n)";

this.AssertCssColor(item, 0, 255, 0, 255.0);
item = "RgBa(\r\r+32330849\r,-1237,+77597496\r ,-.6e088750724993\r\n)\f";
this.AssertCssColor(item, 255, 0, 255, 0);
item = "RgBa(1%,.400e1%,+54.7E966%\f\f\n,\f-.285)\f";
this.AssertCssColor(item, 3, 10, 255, 0);
item = "RgBa(+.4322792%,-5.96%\n\t,-584469%\n\f\r\f\t,\r\t.52598863\r)";
this.AssertCssColor(item, 1, 0, 0, 133.875);
item = "RgBa(-.3%,.1% ,.8E+87675%\r\f\t\f\f\r,\t1e+2500909)";
this.AssertCssColor(item, 0, 0, 255, 255.0);
item = "RgBa(6405,17\f\r\t\r,92623,5.580e+93)";
this.AssertCssColor(item, 255, 17, 255, 255.0);
item = "Rgb(\t\f-.285% \t \t\n\f ,.54E+87232%,\f+.19%\t)";
this.AssertCssColor(item, 0, 255, 0, 255.0);

item =

  "Rgb(\t\r\r\f\n\f \r-3795,\f\f\r\r21\n\n \f\r\n \f \f\n,\r\f\r\n+69825)\n\f\t\f\r\f";

this.AssertCssColor(item, 0, 21, 255, 255.0);
item = "Rgb(\f\r\r\f\n\t+70,\t6,-2)";
this.AssertCssColor(item, 70, 6, 0, 255.0);
item = "Rgb(\f-710795758%,\t\f\f\r\f\t\n\f\r\r 779%\n,-0.4%) \n\n\f\n";
this.AssertCssColor(item, 0, 255, 0, 255.0);

item =
  "Rgb(\r\t\f\r\t\t.3e+7962785%,.9E58%,\r\n606E+3941074681%\n\r\n\f\f\f\f\f)";

this.AssertCssColor(item, 255, 255, 0, 255.0);
item = "Rgb(\r\t-56163 \f \n\n\r,255,\f\f\r-3231\n\f\t\n\f)";
this.AssertCssColor(item, 0, 255, 0, 255.0);
item = "Rgb(\r-75127 ,95\r\r\r ,+0)\f\f\f\r";
this.AssertCssColor(item, 0, 95, 0, 255.0);

item =

  "Rgb(\n-.3216891081% ,\r\f\t\n\f\n\t\r +.352196e+3% \t \t\f\f\n\n,-1E+566920%\n\f)";

this.AssertCssColor(item, 0, 255, 0, 255.0);
item = "Rgb(+.29%,.5e-29%\r\n,9848387E34%)\f\f\f\f \n\r\f";
this.AssertCssColor(item, 1, 0, 255, 255.0);
item = "Rgb(+.34%, \t\r-3%\n,\t\f\n\f\n\t\f60e-8%)\r\f\n\f\t";
this.AssertCssColor(item, 1, 0, 0, 255.0);
item = "Rgb(+4646539,52,+6596469)";
this.AssertCssColor(item, 255, 52, 255, 255.0);
item = "Rgb(-339,\f\f\r4,393)";
this.AssertCssColor(item, 0, 4, 255, 255.0);
item = "Rgb(.5%,.9772e6%,.632803e2%)";
this.AssertCssColor(item, 1, 255, 161, 255.0);
item = "Rgb(.5223136394e1754%,\f\n\f\n\n \n.99%\f,.3%) ";
this.AssertCssColor(item, 255, 3, 1, 255.0);
item = "Rgb(06487849E029290778%\n\f\f\r\r,\t\t\f.4%\n\n,\r+.19%)\n\r\n\f\t";
this.AssertCssColor(item, 255, 1, 0, 255.0);
item = "Rgb(603\r\n\r,+558 ,\n-19)\r\n\r\n\r";
this.AssertCssColor(item, 255, 255, 0, 255.0);
item = "Rgb(96192e+3%,133e+2%\f\t\f\n, -.812%)\t\f\r\t\n\f \n\f\t\t";
this.AssertCssColor(item, 255, 255, 0, 255.0);
item = "RgbA(\n\f\f.83%,\r\n\n.0E-01%,\t \r\n\n\f\n4e-8%\f,\t+.2\t\f) \t\r\f\f";
this.AssertCssColor(item, 2, 0, 0, 51);
item = "RgbA(\n\f\f1\f,\n+5309,\f372\r\n\f\r\n\r,-.21719)";
this.AssertCssColor(item, 1, 255, 255, 0);

item =

  "RgbA(\n\r.2%,+.43359e-250% \n\n \f \f\t,69876420.743896E-99%\r\f\r,\f84E9\n\f)";

this.AssertCssColor(item, 1, 0, 0, 255.0);

item =

  "RgbA(.9e-05%\f\t\r\f\f\r\n\n\f,\r\n\r\t+.7288E36%\n ,+.8%,+.5310076435E+00152)";

this.AssertCssColor(item, 0, 255, 2, 255.0);
item = "RgbA(4,+6,34482947\r\n\f \t,\n \r-.18565915321)";
this.AssertCssColor(item, 4, 6, 255, 0);

item =
  "Rgba(\r\r\n\r\r\f\n\n4,\t\n\n\t\n-08,\f\f\r+314237 ,+1335.6e93466353\n) \n";

this.AssertCssColor(item, 4, 0, 255, 255.0);

item =
 "Rgba(+11130006830,\f \n\t\t\r\t\f\f+90201729,386526738,9.25034e-1581338\r)\f";

this.AssertCssColor(item, 255, 255, 255, 0);

item =

  "Rgba(+440.8% \n \f\n,.909679e+528348518050%,\n\n.60E-201%\r ,\t728E+816)\t\f\n\f\r\n";

this.AssertCssColor(item, 255, 255, 0, 255.0);
item = "Rgba(+6821,\t74732,+7544, \n+.00921697412)";
this.AssertCssColor(item, 255, 255, 255, 2.04);
item = "Rgba(-22,\f \t\r\f02,197322462671 \f,.4)";
this.AssertCssColor(item, 0, 2, 255, 102);
item = "Rgba(.6%,+.511e-97093735%\r\n\r\r\n\t\n\f\f,+7E65%,\r\r\f\n\f-8250e2)";
this.AssertCssColor(item, 2, 0, 255, 0);

item =

  "Rgba(.828324e35%\r\f\f\r\n,\t\r\f.7532%,\n\f+54652885E-500%\r\t,\n\t\f\r\n\r\r\t231785.93e667)\f\n";

this.AssertCssColor(item, 255, 2, 0, 255.0);
item = "Rgba(603091048E6726%,\f-.515837%,\n \n\f2017.5%,+817.2e109\r)\n";
this.AssertCssColor(item, 255, 0, 255, 255.0);
item = "Rgba(7\n\t\t\r\t\f,\t282,45\r\f\r,.67566e263\n\f \r)\t";
this.AssertCssColor(item, 7, 255, 45, 255.0);
item = "hSL(\t\n\f0620.8,\f.460% \r,\r\t-0e6%\f\t)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hSL(\n\n\t\n\f\f28441975.8e+82\f,-0E9010%,0407618e5%) \r";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hSL(\n\f\n\n5e5 \r\n,+.951e69165%\f\n\f,\f-.92%)\f\r \n \n\t\n\n\n\f\r";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "hSL(\n\f \f\f\n\r\f+97254933.0E910554864\t,\f -.5724%,\n\r\f\r\r\r\f\n94.17478%\r\r\r\f\f)\r";

this.AssertCssColor(item, 240, 240, 240, 255.0);

item =

  "hSL(\n\r\f\f\r\r\r869935089.709,\r\r\r\t-.5e+00%,\r\f\f\f\t\n\f2179621.7222%\r)\t\n\n\f\n";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "hSL(\f\t\n\r -0,\f\r.2%\r,.993%)\n\r\r\f";
this.AssertCssColor(item, 2, 2, 2, 255.0);

item =
  "hSL(\r\f\t\r\r\n\r5E-9 \f\n \f\r,\n\r40971933E-0%,\f\r93.85973E40%\f\r\t)";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "hSL(+.1,+541.0e2664915%\r\n,-8%\n\f\r\f\f\f)\r\t";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hSL(-.68E-0, \n \n.13976666476E979844%\n\r,812.77E097555507976%\n)\f";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hSL(-.7033e654713768 ,\f\f\f\f\r\n\f\f\r.21%,\n \f+9403%\n\f\f)\r";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "hSL(-84.847724,\r\f\r4802647.3927973E-9%,.8430e-2897%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hSL(.3,-.2e57%\n\f\r\r\t,\n+1.624159301%)\n\r";
this.AssertCssColor(item, 4, 4, 4, 255.0);
item = "hSL(.3001e+60158240\f\n\r\t\t\n,754%,74.61%)";
this.AssertCssColor(item, 125, 125, 125, 255.0);
item = "hSL(.3E+108\f,-.5%\n\n,\f -.6%\f\t\r)\f \t \n\n\f\r\r\n";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hSL(.8354E-1\r,-.383615e5% \r \f\f\n\n,\t+.1e+46881604%\r\r) \t\r\r ";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "hSL(506.89e+171231\n,-90E2603% ,\n\t\n\f-463153793E-12%\t\t\r\f)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hSL(86878601.2e2\f\r,6.24797%,-.42835e5%) ";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "hSl(\t\n\r\f\r\f\f.040893\n\n\n \r\n\t\f \n\r\f,\r502977172.0%\r\n,.553195E-5%)\f\t\f";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item =
  "hSl(\t\f\n\n\t\n\r\f\r\r\t.40\n\f\f\t, \f.6515925545%\n ,\n\r+.29%)\n\r";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hSl(\t\r\t \r\n\f \f\n9616,\f3663.3%,\r\t\r\n\n\n-.5%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "hSl(\n\n\r\r\r\r12600853\r\t\n\t \f\r \f,\f\r\n\n.648e+73%\f\n\f\f,\r+71990.477E79037%\f\f)";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "hSl(\r \n\f\r\r+3533569.8156528412,.9%, \f40.20156e+8% \n\n\r\n)\t\n\r";
this.AssertCssColor(item, 255, 254, 254, 255.0);
item = "hSl(+.9602E0,\r\f\t920599546.29010e531%,.44%)\n\t";
this.AssertCssColor(item, 2, 0, 0, 255.0);
item = "hSl(-.05169342e2\r,\n\n \n\n\t+.4E+85%,\t\f.05%)\f";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hSl(-.633886385,\n\r\n\f\t\n\n\t\f\t\f-0734265.1%,43187025.1%)\n\r";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "hSl(-.8,\r\t+.398E-0%,\f\t4413%\r\r\r\r\n)\f\t\r ";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "hSl(-5.8\n\n\t,+4.061e-8%,-35761.00%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hSl(-76135.89e-896,-23e154%\f\r,\r \r21.306682064%\t) \f\n";
this.AssertCssColor(item, 54, 54, 54, 255.0);
item = "hSl(.07818E-8482\n , \f\r\t\n+.0486% \r\r\t\r\n , \f.5%)\t\f";
this.AssertCssColor(item, 1, 1, 1, 255.0);
item = "hSl(.1498,\n338801.81%\n \n,.814259E+83%\f\t \n\n)\r";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "hSl(2,-7326.2E+182%\r\t\n\f,\f-17800E+8%\n\f\n)\r\r\r \t\r";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hSl(2.0709,192.83%,\r0.794357e+6%\t\t\n\f\f)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "hSl(6627.945512E-48885346992\f,\n\r\n\r-.5%,-1521683625.64%)\t";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hSl(936597.07E-094,954.2e99%,\r\n\n\t\r-1E2%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "hsL(\t\r\f.186e375\r\f\t\n\n \t\n\r\r,261.4E+86555343%\t\t\t\n\f\r\r,\n\r\f 2.1171E51243%)\f \r\n\r\r\n\f";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "hsL(\t \n\n-34\f\f\f\f\r\r\r,\t.2e+8%,+646794349.235224821E830609%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "hsL(\n\t\t+9653E+486,\r \n\f\f\n\f\r+5.754628E+334168%,\r\f\r\r-.115E-82% \r\r)\n\f";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hsL(\n\n+9727E4,6.357%,-.4E-59927%\r\r)\r\n";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hsL(\n\r\f\r .5e+7,13%,8.4e92816924%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "hsL(\r\f \r\f\f\n.2345\t,\f\r\f\f +99.2092%,.84E758%)\n";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "hsL(\r\r \f\f\r\r1885492\f\r\n\n \t\f\n\n\r,\t\r\t\r\f+8671E-43601%\r,\f+466362201600.2E60726%)\t\n\n ";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "hsL(+92.60\n\r\n \f,.9540530%\t\f\n\t,\r\n\n\f\r\r\r\r+.697498%)\r";
this.AssertCssColor(item, 1, 1, 1, 255.0);
item = "hsL(.528733e+6070 \r,\r\r\t \n\f\r\f \n-.33e00%,+.1e29157%\n\r\t\n)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "hsL(70333045.565E254563061057\n,-.1296e-42261%,\r\t+.80%) \r\f\n";
this.AssertCssColor(item, 2, 2, 2, 255.0);
item = "hsl(\t\t\t\r\f5.5E-8\n\r\r\t\t\t\f,.71E459%\f\n\n\n\t\n\n\t\r,+.41%\r)";
this.AssertCssColor(item, 2, 0, 0, 255.0);
item = "hsl(\n-.639e-707150\n,95.49986542280%\f,.202591903%)";
this.AssertCssColor(item, 1, 0, 0, 255.0);
item = "hsl(\f\r\f\f\f\f.495,.78e379409%,\t\r\f\n\r\r\r -.4276E651%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hsl(\n\n\n\r\t\n\f\f76E-45,\n\n\n +955870%,-400368.52192E-23%)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "hsl(\n\r\f\n\f\f\t\f688E-88\f\r\t,\n\t\n\f\r+1%,\t \r\n\t\n \n1786.8%\t\r\n\f\n\t\n\f\n\f\f)\n\r";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "hsl(-8193\n \n\n\f, \f-84162%\n\r,\n\f\t \n.213%\f)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "hsl(.5930E-5\t\f\r\r,5E492%\n,.03%\n)";
this.AssertCssColor(item, 0, 0, 0, 255.0);

item =

  "hsl(0873.15E+1724734593 \n\t\t,\n\t\n\r\r\n\f\r.27E196%\n \f\r\n\r \n,\r\n\t+.79e+655215%)\t ";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "hsl(1\t\f\r\n, \n\f\f\t\t380862447.928982418%,-.36e15%\t\t)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "rGB(\t\r\r492,+99,\r748) \n\r\f\n\t";
this.AssertCssColor(item, 255, 99, 255, 255.0);
item = "rGB(\n\n\r4975,336,-60\r\n\t\r\r) ";
this.AssertCssColor(item, 255, 255, 0, 255.0);
item = "rGB(\n+19566528,6\f\r,2\n)\t";
this.AssertCssColor(item, 255, 6, 2, 255.0);

item =
"rGB(\n-.508814455706%\n\r\n\r,\f-.169108485e+73%\f\n \n\n\r,.738039167%\n \n)";

this.AssertCssColor(item, 0, 0, 2, 255.0);

item =

  "rGB(\n-.5479939E5%\n\f\n ,\f\n\f\r\n\f .14001119e+3% \n\n \r\r\f,\n\n\n\r\r\r\n\r.3%\n\n\n\f)\t";

this.AssertCssColor(item, 0, 255, 1, 255.0);
item = "rGB(\f224215\t\t\r\t,77\n\f \f\f\n\f,-2\f)";
this.AssertCssColor(item, 255, 77, 0, 255.0);

item =
  "rGB(\r\n\r\n-62%,\n\f.77E-787821257068%\n\n\r,\n \n\f\r\n.3E-268656%\f\t)";

this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "rGB(\r9\f\n\r,\r\r\r \f+5,\n\f+423730)";
this.AssertCssColor(item, 9, 5, 255, 255.0);
item = "rGB(.82642%,.3449865e6037%\r,-.20540%)";
this.AssertCssColor(item, 2, 255, 0, 255.0);
item = "rGB(1594097.2182%,7E71%\r\f\r\t,827.008257%\r \n\r\n\r\r)";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =
"rGB(32084454.57491208%,+7%\r,\t\f \r+.9874e+48594311% \f\r\r\r\f\r\n\t\n)\r\n";

this.AssertCssColor(item, 255, 18, 255, 255.0);
item = "rGBA(\t \f\f\t8,-808,+20\f,\f\r\r.5473536320E18)\f";
this.AssertCssColor(item, 8, 0, 20, 255.0);

item =

  "rGBA(\n \f\t\r\f\r-80 , \f\r\r\f+3185182222,-030\f\n\f\r\t\f\f ,.0206 \r\r \n\r)\r";

this.AssertCssColor(item, 0, 255, 0, 5.1000000000000005);
item = "rGBA(\f 89097\n\r\r,66256631 \f,\f+0,\r\f\n\t-.8 \n)\n";
this.AssertCssColor(item, 255, 255, 0, 0);
item = "rGBA(-3,326147\n,\t-290,98.06798284\t\t)\n";
this.AssertCssColor(item, 0, 255, 0, 255.0);

item =

  "rGBA(-326023819\t\f\f\f\r\n\n\t,65543\n, \r \n\n+11\n\f\n\f\r \f\n\r\t,\f\r\r-.216885E285\n)\n";

this.AssertCssColor(item, 0, 255, 11, 0);
item = "rGBA(-660,\r\f7,\n3619,-.91006\f)\r\n\f \n\n\f";
this.AssertCssColor(item, 0, 7, 255, 0);

item =

  "rGBA(.23195%\f\n\r,-.74%\r\t\n \n\t\r\f\n\t,\f.185835%\r\f \t\f\f\n\t\r,\f\r\n57e+58566\t)";

this.AssertCssColor(item, 1, 0, 0, 255.0);

item =

  "rGBA(.5767%\n\t\n \r\t\f\f\r,+.143733e+66603598%\t\n\f\t\n\f\n\r\t,\r\f+.82%\r\n,.978e20994\f \f\r)";

this.AssertCssColor(item, 1, 255, 2, 255.0);
item = "rGBA(4,\r\t\n+326\f,\f\n\r\r\r \n82,\t\t\f\f-.0)";
this.AssertCssColor(item, 4, 255, 82, 0);
item = "rGBA(5%\f\n\r ,\n\r\n-069925.64%,-1.46946%,\r\t9.70)";
this.AssertCssColor(item, 13, 0, 0, 255.0);
item = "rGBa(\n\f\r\f\f\n+4,\r\r+7\n,+095523,\n\n+.76110)\n";
this.AssertCssColor(item, 4, 7, 255, 193.8);

item =

  "rGBa(\n\r \t\n\t+954,498166\t\t\r\n\n\t\r\f\n\r,\n-9 \n,+68\n \n\n)\f\f\n\n\r\r\f\r\n\f\f\r";

this.AssertCssColor(item, 255, 255, 0, 255.0);
item = "rGBa(\r\n8,+74\f,0,\f \f\t\r\f+3162.0322E5939927)\n\f\f";
this.AssertCssColor(item, 8, 74, 0, 255.0);
item = "rGBa(2,-872397\t,-24705070\t,.38)";
this.AssertCssColor(item, 2, 0, 0, 96.9);
item = "rGBa(874,\n4,+0505,+4409E+9873 \r) \r\r\f\n\t\r\f\t\f\n";
this.AssertCssColor(item, 255, 4, 255, 255.0);
item = "rGb(\t-3043,9\t\n,\n\t\f\n \r\r\r-431909014\n)\n\n\f";
this.AssertCssColor(item, 0, 9, 0, 255.0);
item = "rGb(\n\r3\t,\f-5\f\n\f,\n\r 14)";
this.AssertCssColor(item, 3, 0, 14, 255.0);

item =
 "rGb(\f\f\f\n\t\r\n\r\f\r606,\r\t\t\f\n +3613888169\n\r,\n\n-126\f\n\n\n\r\f)";

this.AssertCssColor(item, 255, 255, 0, 255.0);
item = "rGb(\f\f \n4\t\r\f\f,\f\r\r\f\n\n\f7,+94315\r\r)";
this.AssertCssColor(item, 4, 7, 255, 255.0);
item = "rGb(\f\r\f02376,8500479,\t \n\r\r \n6973932527)\f";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "rGb(\r\t\r\r+79412.6%\r\t\f\t,+.021354e456703%\r,946.102%)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "rGb(\r\f \t6800884e-90%\r\f\n\r,+.42e+5%,\n\n \f+7.180E98% \r)";
this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "rGb(\r\f405430695\r,530\f\t\n\r,+98834578)";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "rGb(\r\r3\n\n,+0\n,\f-98361051)";
this.AssertCssColor(item, 3, 0, 0, 255.0);
item = "rGb(\n\t\n \n\t\t\n\n77980420,0,\r\f\f2\r\r\r\f\t)";
this.AssertCssColor(item, 255, 0, 2, 255.0);

item =

  "rGb(\r\f\r\n\t\t\f\t39.4e+054260280%,\n913404.141201E+66133922%,\n\r\n \t\r-43031735129.124E0%\n \r\n \f\n\r)\f";

this.AssertCssColor(item, 255, 255, 0, 255.0);
item = "rGb(+0,9\f,350)";
this.AssertCssColor(item, 0, 9, 255, 255.0);
item = "rGb(-62053636508,\r\f-86014891,+1\r\n\r)";
this.AssertCssColor(item, 0, 0, 1, 255.0);
item = "rGb(23%,-.8%,\r\n\f \r\f\r.758124604e68%)\f\r \r\f";
this.AssertCssColor(item, 59, 0, 255, 255.0);
item = "rGb(54,246537\f\r\n\t\f ,2)";
this.AssertCssColor(item, 54, 255, 2, 255.0);

item =

  "rGbA(\n\t\n\r\r\t\t8355383909E+9% \r \r\n\f\r\f,.33935e2%,929.3%, .122993E-3\r\f \f\r\f)\r";

this.AssertCssColor(item, 255, 87, 255, 0);
item = "rGbA(\n\f\f\n\r0673255,72,-2,\r\r\f84513)\r\t";
this.AssertCssColor(item, 255, 72, 0, 255.0);

item =

  "rGbA(\r\n\r\r \f\n\f\f-.2378e6%\r\f\n\t\f\r\f,+75.0749147E0492%,\r \r+57.607E-9475%\f\n\f\f\t, \r\n\r\t\t\n\r.54)\n\n\t";

this.AssertCssColor(item, 0, 255, 0, 137.70000000000002);
item = "rGbA(-95837\n\f,\r\r\f\n \t\n\r\r\r\r\f+65084,+0,\f\r\t\r\r\r469e15)";
this.AssertCssColor(item, 0, 255, 0, 255.0);
item =
  "rGbA(.69%,.470%\f\n\r,\f\f\r\f \r\t+.44%\r\f, \f\f\f\r\r\f\r\r .403\n)\n";

this.AssertCssColor(item, 2, 1, 1, 103.02000000000001);
item = "rGbA(8448,2,-792802,\n\f\f\r\f\f\t-0E089)\n\t\f\r\r\n\r\n\r";
this.AssertCssColor(item, 255, 2, 0, 0);
item = "rGba(\t\f\r\t034\n\f \f\f\t\n\f\n\r\n,+1563\t\n\t,15\t\t \n,\n.2)";
this.AssertCssColor(item, 34, 255, 15, 51);
item = "rGba(\t-1849324379 ,684\t,87105950187,\f\f\n\t +775.3811012723E7595)";
this.AssertCssColor(item, 0, 255, 255, 255.0);

item =

  "rGba(\n.8538E5760310%\f,+.046935E6%\n\n\r\n\t\t\f\n,-.7110E-091%,\r-63.62e-9\n\f\f\n\f)";

this.AssertCssColor(item, 255, 255, 0, 0);

item =

  "rGba(\f\r\f\f \f\t\r\t\f-17217.37954e+5%,\f\f\t\t+67722379.94e-77394%\r,\r\n\r\n\f\t.305351439%, .6e+8)";

this.AssertCssColor(item, 0, 0, 1, 255.0);
item = "rGba(\r\r-55499859,\r\f \n\f\r\t+6,1801,.8)\r";
this.AssertCssColor(item, 0, 6, 255, 204);

item =

  "rGba(\r \t\t \f\t\t48424E+62797%\n\f \t\f,-.6% \f\t\r\t\r\r\f\n\f\f,+221898799.6275%,\r-.6811E-47\n)\r\t \f";

this.AssertCssColor(item, 255, 0, 255, 0);
item = "rGba(+651,\f\r\r\r\n\t82\r,39428\n,\n\n\f\r\n36856257576e-330)";
this.AssertCssColor(item, 255, 82, 255, 0);

item =

  "rGba(+349,3289\f\r\t\f\f,06\f \r\t\t\n\n \t,\r\t\f\t\r\f+.326)\r\r\n \r\f\r\r\f";

this.AssertCssColor(item, 255, 255, 6, 82.875);

item =
  "rGba(+717.4E73%\r\f,+.956e-4%\n\f\r,+041.927421E20427435%,+.5)\r\n\f\r\n\f";

this.AssertCssColor(item, 255, 0, 255, 127.5);
item = "rGba(+79 \f,-87322339,\r+6\f\n\n\r,+862119E7700)\n\f \n\r\f\t\r";
this.AssertCssColor(item, 79, 0, 6, 255.0);
item = "rGba(-4306%,1E2%,\f\r-31789137%\n\f,\n\n\f\f\t82486E+0142)\f\f\n ";
this.AssertCssColor(item, 0, 255, 0, 255.0);
item = "rGba(-5551560598\f,+8\f\n\f\r,+4\f,\n\f \f\f\n\r\r\f\t-883879)";
this.AssertCssColor(item, 0, 8, 4, 0);

item =

  "rGba(-751\n,302,937323\f\f\t\r\f,\n\f\r\r\r\r+16.7094065E9264867\r\f\n\n\f)\t\f \r\r\f";

this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "rGba(.58e+37%,87.415580%\n\t,\t\n-67%,4.893851e+01\r\n\r\n\n)\n\t\f\r";
this.AssertCssColor(item, 255, 223, 0, 255.0);
item = "rgB(\n\t\n .3E47959135%\r \r\n\n,.6814279E+8%,\r\f\f\t.955%)";
this.AssertCssColor(item, 255, 255, 2, 255.0);
item = "rgB(\n\r\f76.0496%\t\n,36%\f\r\t,-.6074787E5%)\r \r\t";
this.AssertCssColor(item, 194, 92, 0, 255.0);
item = "rgB(\f\f-1,\f\f\f\t\f\n\r-06\r\r\n,-8)";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "rgB(\r99\f\f\r\f\f\r \f,6,789)\r\r \f\f\f\t\n";
this.AssertCssColor(item, 99, 6, 255, 255.0);
item = "rgB(\t\f\n\r\r\n\f\f +267,-3\n\n\r\n,27794)";
this.AssertCssColor(item, 255, 0, 255, 255.0);

item =

  "rgB(+5238%\n\r\n\f\t\t\t\r\n,\f \f\f .8e+72482870%,+.403375%\r\n \r\r)\r\r\r\t \f\r\f ";

this.AssertCssColor(item, 255, 255, 1, 255.0);

item =
  "rgB(-.2%\n\r\r\r\f\n ,\r\r\r\f\n\n\f\r\n-2.053e-733%\t\f\n\r\t\f\r, 50041%)";

this.AssertCssColor(item, 0, 0, 255, 255.0);
item = "rgB(-.57E-84%,\r\n\f\r\r \r04.63e5%,\f\r\r\r\f\t+9286.4039980E-0%)";
this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "rgB(-75487\t,\f\f+5\r\n \n\f\r\f,-2255)";
this.AssertCssColor(item, 0, 5, 0, 255.0);
item = "rgB(-9887\r\n\t\t\r\f\f \t ,\n\f\n\n-345,\t\t\t\f\f14140693599\n)";
this.AssertCssColor(item, 0, 0, 255, 255.0);
item = "rgB(.9%\f \r\r \n\f\f \n,76E-7%,+84508.044e-4%)";
this.AssertCssColor(item, 2, 0, 22, 255.0);
item = "rgB(2910\f\r\n\n\f\t \t\n,\t\t3435,\f\r\r\n\n\t\r\n187) \f\t\n";
this.AssertCssColor(item, 255, 255, 187, 255.0);

item =

  "rgB(301e5%,\f\r-6e118730%\r,+.6813941304E52539%\n \f \t \r \r\n)\t\n\r\f\f\r\n\n\f\f\f";

this.AssertCssColor(item, 255, 0, 255, 255.0);

item =

  "rgBA(\f753\f\n\f\f\f,\n\n\r\f\n56 \f\f\r\f\t\f\r,+136\f\f \n\f,-.43681654662)\r\r\f \f\r";

this.AssertCssColor(item, 255, 56, 136, 0);

item =
  "rgBA(\r.50477028e-7906%\t,\t\n-.24%,+.184E-65%\n,2\t)\f\f\n\n\r\n\f \r\n\f";

this.AssertCssColor(item, 0, 0, 0, 255.0);

item =
  "rgBA(91600922967.083e-3%\r\r,\r.12E+8633%,-.69%,\r \n\n0633.9630e-176\n)\r";

this.AssertCssColor(item, 255, 255, 0, 0);

item =
"rgBA(+.013125053342%,\f\f3%\f\f\f\f\f, +.05128581682e1952%,-837.58388864526) ";

this.AssertCssColor(item, 0, 8, 255, 0);
item = "rgBA(816356%\t\f ,+42E-013637%,-2527E481%\r\f,.6693759)";
this.AssertCssColor(item, 255, 0, 0, 170.85000000000002);
item = "rgBa(\t+21,95352357,-582021,+60204451.78e-6 \n\f)\n\f\n\r";
this.AssertCssColor(item, 21, 255, 0, 255.0);

item =

  "rgBa(\n\n .7%,\n\n\r\r\r\n\n\n\n\r-.59422493E-47519%\f\f \f\n\r\f\f\f\f,-.96e+513643%\t\n\f\t\n\n\f\f\n,015.6138E2548\f\r\t\t\t\r\n)\r\n";

this.AssertCssColor(item, 2, 0, 0, 255.0);

item =

  "rgBa(\f\t\f\n\t-062671\t\t \r\n\n\t\r,+01007,\n\n\r\t\r\r\f\r\f-26,.16)\n\n\r\f\n\r";

this.AssertCssColor(item, 0, 255, 0, 40.800000000000004);
item = "rgBa(\f\n916540,622\f\t,+721,+5477930488E+5569\f)\n\r \r";
this.AssertCssColor(item, 255, 255, 255, 255.0);

item =

  "rgBa(\f\f\f\r\f\r\r \r81\f\f,3,\r\f\t\r\f\r+81,+11786239188e98993)\f\r\r \f\n\r\f\f\f";

this.AssertCssColor(item, 81, 3, 81, 255.0);
item = "rgBa(\f\f+0677942705,3817,5912518, \f3896991\n\r\n\n\r\r\n\t)\f\t\f";
this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "rgBa(\r-86,\r \t\r\r\r\f\t\r-86383, \n\r-8186,+.4095\f)";
this.AssertCssColor(item, 0, 0, 0, 104.03999999999999);
item = "rgBa(+.457%,.7699e-10%\r\n\r \f,-.5%,69667e597125 \r) ";
this.AssertCssColor(item, 1, 0, 0, 255.0);

item =
  "rgBa(-9214189\n\f,\r\n\n\f\n \n 0\f,+89 \n\t\n\f\r,.9636503221 \n\f\t\f)\n";

this.AssertCssColor(item, 0, 0, 89, 246.075);
item =
  "rgBa(7.4519e43%\t\t\f\r,\t\n \t\r+2e1769901%,\f\r\f+.730e56%\r ,+.1e3)\f";

this.AssertCssColor(item, 255, 255, 255, 255.0);

item =
  "rgb(\n\r\f\f\r 57810.02703%,\n.329206E+054%,\r\n\n \r\r7498299819%) \t\r\t";

this.AssertCssColor(item, 255, 255, 255, 255.0);
item = "rgb(\n\r9\f\f\r\r,\f\t\f\f 1,501692\f\r) \r";
this.AssertCssColor(item, 9, 1, 255, 255.0);
item = "rgb(\n +9\r\r,\n\r\f\t+03,9111428341\n\n\r\t\r\f\r)";
this.AssertCssColor(item, 9, 3, 255, 255.0);
item = "rgb(\n+9\f\t\r\r\n\f \r,\f\n-27, \n8)";
this.AssertCssColor(item, 9, 0, 8, 255.0);
item = "rgb(\f\r\f\t-98\r,-9\t\f\t\t\f\n\n\r,\n-655\t\n\r\t)\t\t\n\f";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "rgb(\r\f \f\t -.50e+5%,103976.67e3%\f ,.81677E886%)";
this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "rgb(\r-6374%,\n.7%\t, \f\f-.0854%\r\f\f\f\r)";
this.AssertCssColor(item, 0, 2, 0, 255.0);
item = "rgb(+.8723125%,-6824631.48108484%,+764496.540757369%)";
this.AssertCssColor(item, 2, 0, 255, 255.0);
item = "rgb(-.12%\t \t\r,+.0e-8%\f,-.869295E193571889%)\n\r\f\n\r\f\f \r";
this.AssertCssColor(item, 0, 0, 0, 255.0);
item = "rgb(-.2e+3%,\n\t\r\n\n+0933.998%\r\r\f\n \n\f\f\n\t,-997% \t\t\n)";
this.AssertCssColor(item, 0, 255, 0, 255.0);
item = "rgb(-.4%\f,864E7%\f,854093E37%\t)";
this.AssertCssColor(item, 0, 255, 255, 255.0);
item = "rgb(-.7530e+4075%\n, \n\f\t\t\n-.20974609034E-8%,\r+713.2608%\t\r\t\f)";
this.AssertCssColor(item, 0, 0, 255, 255.0);
item = "rgb(-03%,07E-48446084%\r \r\n\n,\f\f\f\n.2E55%)\r\f\r\r\n\f";
this.AssertCssColor(item, 0, 0, 255, 255.0);
item = "rgb(.8836976690e+6%\t,-12175.8%\f\f\r\n\f\n\n\r\n\r\r\t, -.6%)";
this.AssertCssColor(item, 255, 0, 0, 255.0);
item = "rgb(5,+362\r\r\n, \f\r\f\n2)";
this.AssertCssColor(item, 5, 255, 2, 255.0);
item = "rgb(9,\n \r \n6653731550 \n\r\r\f\n\n\r\n,\f\n\t\n\t445)";
this.AssertCssColor(item, 9, 255, 255, 255.0);
item = "rgbA(\t\n\n.53%\f\n\r\n,.9%,.990868E+2%\n\f,+00 \f\n\r)\n \t";
this.AssertCssColor(item, 1, 2, 253, 0);

item =
  "rgbA(\t76703662\r\t\r,61\f,903,-.683048348e9377600)\f\n\n\r\r\n\f\r\f\n\f\r";

this.AssertCssColor(item, 255, 61, 255, 0);
item = "rgbA(\f5,+78,\n\n1318705,\f\r\n\f\n\n\n\f+.499395E-45787)";
this.AssertCssColor(item, 5, 78, 255, 0);
item = "rgbA(\f\t6%,\n\r651.4559455571%,.064435%\r\f,-.064329)\n\r\r\r";
this.AssertCssColor(item, 15, 255, 0, 0);

item =

  "rgbA(\r\r\r9362845792%\r\t \f,\n\n\t\n\t\f\n\r+28.0929%,\t\n\f\r\f16.0e-01237817%,5036)\n";

this.AssertCssColor(item, 255, 72, 0, 255.0);

item =

  "rgbA(.9%\r\n\t,+.72%,.8635e67270%\r\t\n,\f\t\n\f\n \f\n \r\r+.068349924E860\n\t)";

this.AssertCssColor(item, 2, 2, 255, 255.0);
item = "rgbA(1472254,9132\n,-01380 ,\n\r\n.07e992554)";
this.AssertCssColor(item, 255, 255, 0, 255.0);
item = "rgbA(49268.4451%,\r\f\n\t\r\t+9.3%\n\r ,\t\n\t.2%\r,-.14534) ";
this.AssertCssColor(item, 255, 24, 1, 0);
item =
  "rgbA(6\n\t\f\f\f\t\r\r\r\f\n\r,\t\n190409867604,\f44,.2e+69209\r\t\n \f)";

this.AssertCssColor(item, 6, 255, 44, 255.0);

item =
  "rgbA(8.45%,+01.836%\t\f\r\r\n\r\f,+8962444E-78295% \f\n\n\r\f\r\t,77863.4)";

this.AssertCssColor(item, 22, 5, 0, 255.0);
item = "rgbA(89213828,\f\t\f+635237699, \f \t-92\n\r\r\n,\r\f373.90)\f\n \r ";
this.AssertCssColor(item, 255, 255, 0, 255.0);

item =

  "rgba(\n\n\n\t-.77832658% \n,\t\n\f+244697642e9980548698%,.6141%\n\n\n\n\f,.8\n\r\f)";

this.AssertCssColor(item, 0, 255, 2, 204);

item =

  "rgba(\n\f\f\f+.971103%\r\f ,.9358%\t\f,-0.022710%,\n\r\r\n\r+.560e8478\f\f\f)\r\f\n\r\f ";

this.AssertCssColor(item, 2, 2, 0, 255.0);
item = "rgba(\n+330090.06%,\t\r\f-.7%\r,+.6416496E-9%,\f\t-063.8)";
this.AssertCssColor(item, 255, 0, 0, 0);
item = "rgba(\n20820064\n \r\f \r\n,+894726227,+1145700\r,-.10\f\t) \n\n\r\n\f";
this.AssertCssColor(item, 255, 255, 255, 0);

item =

  "rgba(\f\r\f\n\f\r\n\f\r\f+.30974% \n,684e24330%\r\r\n,\t\r-.2E4%\r \f \r\r,\f.486904769\t\n\f\f\f \f)";

this.AssertCssColor(item, 1, 255, 0, 123.92999999999999);

item =
"rgba(\f.46%\r\f ,-.47886%\r\r\n\r\n,.30E-0876%\n ,\r\f.12e-473388\f\n\f \f\f)";

this.AssertCssColor(item, 1, 0, 0, 0);

item =

  "rgba(\r+84.4490%\r\f\f\n\r\f, \t\f\n+.408e33%,\r\n\n\n-78.17838E20809%\r,\f \r\f\n.101474)";

this.AssertCssColor(item, 215, 255, 0, 25.5);

item =

  "rgba(+.493e85%\t\f\r,\f \f\n\f\r\r\n\n\n824.0130590e+91%\n, \n3561809.1762716E3656%\n\n\r,\f \f \r \n\n\r\f\f\r-.1\f\r\f\t\t \r\r\n\f\n)";

this.AssertCssColor(item, 255, 255, 255, 0);
item = "rgba(-36,84,\n\r\r9137,.9e6636256\f)";
this.AssertCssColor(item, 0, 84, 255, 255.0);
item = "rgba(-4\r\r ,51940\t,\f\f9173427\f\t,\f\f-50875074\n\r\t\f\f\t\f\f)";
this.AssertCssColor(item, 0, 255, 255, 0);
item = "rgba(2897,\r\r\n\n-1\f,1698\t,-03595.295)";
this.AssertCssColor(item, 255, 0, 255, 0);
item = "rgba(4,-11 \t\f\r\n\f ,\n\t \f\r\t-856089778\n\r\f,.1527e-8115)";
this.AssertCssColor(item, 4, 0, 0, 0);
item = "rgba(5,2,\n \r\r\n\t-2052449\t\f\t ,\t\t\t\t\r.13\n) \r\r\r\t";
this.AssertCssColor(item, 5, 2, 0, 33.15);
    }
    [Test]
    public void TestRgbToColorDisplay() {
      try {
        ColorValidator.RgbToColorDisplay(null);
        Assert.Fail("Should have failed");
      } catch (ArgumentNullException) {
new Object();
} catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
    }
    [Test]
    public void TestRgbToColorHtml() {
      try {
        ColorValidator.RgbToColorHtml(null);
        Assert.Fail("Should have failed");
      } catch (ArgumentNullException) {
new Object();
} catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
    }
  }
}
