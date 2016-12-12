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
item = "4 \nHstWhiTkE";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "MGbO\f\f\n\n-5907-,.#\n+709%\f,+2, 1";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nR\rrgba(-456140528,%,\t\f\f\r\r\t\n\r\n+842657R463I9.39%\t\f\f,\r.0% \r\n\f\f\f\f\nn\t,\r\f\n\f.6O";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSL(L%\f+13\r4R43 \f,\f7%,p.8%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\f\f\n\n\nHs-(\t\f\n\f\r \n\f\t\n +.472042122\f\f,24143.1\f5%,\f\n\r\f\f\t-.55968070498%)\r\r\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nRGB(\n184820.152H%%\t\r\f\r\n\rD\n\r\fP-.672872%,\r.890011O\f\t\n\n\f\f\t)\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = ".RwsLsAAtm)egreY\n\f \f\n\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgbA(\r K-q1  ,302G5\t72\t, 13";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " c\f\rR\tB\fPm\n\n\t289,N\f-4  ,-9611605762k)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Hsl(\t\n \rD\n\r \n\n\r+5.43K0e9\n,\r\f9%\r,.121887%\n \r\t\r\n\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgbA(\r\r+20\f\r,\n\n208,-\n62362,+57\fO\r\n\n)\f\n\f\r\r \n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#CEac)(6a";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "qhSl(079t19\n\t,.84b,\f\f\n\f\t\f.4795229%)\t\t\f ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \r\n\r\f\rrGB(7b5.40%\f\n\tE\n\n\ns,\n\r \n90214%,+7249.9%\f)\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "gbaI(5k,\f-65141.8n76469%,\n-.490368%\rm\t\r\n\f\r,\r\n\f +192\n8 \n\f\t\t \f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGbA(+.9101946%\r# \n,\t2.9337%\n,-470175%\t\t,\t\f\t \n\r\r\r8.13370 \n \f\r\f  )\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "T\r4PFd ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \f hsl(.mt253\r\n\r,03%\n\f,+2% \t\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nOhSl(\n\r-12144.7902520,\r-020140281.f24%,\t+.7P3570%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgb(\r+.2240n9o\n\r\tB\n,\t .70%\n\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "EhSCsl(.6\f\n,\n3315Ka,3\r-.0007 01%)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsL(.11095t4\n\r\n5\n\n\n,.29b415%\t\r\r\n,\r\nN\t\n.37%\f\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "LRB(\fK++-216659,-854\f\f,1)\f\n\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "26Ga(\f7+6,\n\f\r\n\f\f+G\n,T2,\n03Y793)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Cffa,c\n\r G \f\f\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Lcsh (\n\t\n 4.51612,P\f-.49%,\f\r6.269%\r)\n\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "cHl(.35109l \t\f,  \n\t\n+735g3%\n\n\n\n,2\r017s3%U\f\t\n\f\n\n8\f\t )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Pu\nP \t\f7";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\r  \t 8InilGo ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\nrgbH+943.F14%\n\fH\r\f\n\f,.s3,.261753%\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r HsBL(-O88.2376\f110684n61\f88%,  o0647L%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\fgBd(+5,+p8,\n,175qN\t- .N1120o95\r\n\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "cHPcHCC\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nRC%B\f.4G587\t\tw,\n\r\f\r\t\r\f\n-.61%, \r\t\f\n\t01.28%\f\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "He(\r\t \t\f\r9393,+885389.4325%,\n\t+\r\f\f \r7m)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rHsL( \t+.8250529687t0\n \f\tUI,\n\r 4.609471745%,+.216%\f\r\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\rSklaTegRY";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGb(\r\f\n+U+s,.,\n\f+04p\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsY(7.63885925\f\f)\f\f\n,-.88%,.468%\r)\n\r\f\r\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#ab1 \n\nr";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nrGBA(+9#44887276,-8394#1,\r-062833\t\r\r\n \r\n\n,-1332.50FS47)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGB(-05%f,-2635\f\n \t,\rqT9838r35691%\t\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rrgB(\r\t \n+046 \f\t,\t\f\r\n-820845246w\n\t+\f\t\t ,\n\f\f\f\r\t+6)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n 9sL(\n\f\f\n\n \n+51t\n\r\n\n\n,h-5%\r.4%)\r\f\n\f\r\rq\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "c+ADFnOtAAf)Mf2";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rRSB(\r\t\f\r\n\r\t\r\f\t\r+.166%\f\t\r\t,.60%\f,\n\t\n\r-0n\t)\n\n6 F\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \frgbA\n\r\n\t\f\n\n\n-40, \f\r\t\t\fE\r\t53224\r\r ,+032,3714N)G";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "p\tu#eqlBc";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \n\rhsL(\f\n\f\f\f\r0\t\r \t\n\t,-.21546978147%\np\f \f,\f\n-.29%\n)\r\n\t\t\nt\r\n\f\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSL(\n\n32.4,\n   \f\t\n5%,\f.15%)\t4";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "ro(567688,+ 605,+u)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nh1(+.738%,A-767.3%\f\f\n.40L)\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rHSL(\n\f+3E842\t,\r\n.10025\fN845%,5331.74740.950%\n\t\r \f\r)\t\f\f\r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n \n\frGA(\f+563\t\f\r\r\n\t+5,0,\n\r\n\r\r\n.60)\t\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\tmHSh(D \n\r-2,\f\t23o80%\n2\n976%\f\f\tE\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\tA)vECdLuH";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " FcCL2K";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsl(+.159H51417\fc\n\n\f\f\r\r,\f\r\f\n .77963h%\f\n\n\n\n\n,+.25021%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "-\rhonydGR\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t9a 7#Fr50c\r\n\f\n\t-8#";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGNB(\f\t19998s30u5% \f\f\t,-92.7F95368129196G%25%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Hs\r(+14U g\r\t\f-.8%,Y070%)\n\n ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGKUa(L   \r\f-574U,\fA76872L5b\t\n \n\f\f\r\r,\f\n\n\r\f\f\r2)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rRGBa\r(+.5%,\fh.9775%\f\f\f,-.115311398%O,.5)\f\r\t\f\n\r\t\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgBe-0,\r\n\t\n\n\t+95,\n\r07402294694\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rh4L(q8n7\r\n,-.872%,+50.84) \r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGBa(-4\nf\n,+144,\f-2526646662,\f\t\f\n\r\r \r-157.41942\t\r)\n\f\f\r\t\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r3#)8qq6e3a";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "nSsl(8\t\f\n+.63\r,-.29%\r,\f.0819%fm";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\f \rrgb(91,-968\r p,\f\r\r \n\r9+16\n\f\t)\nC\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f \n\rrgA( \n\r\r\n-72h5%\f\r\r\r \r\f\n,.956526%,-.4%,59883.1)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "IghtmyrU\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgbA(\n-.2%\n\f\n74% \f\n\n ,.9890%\r\t  \n,\t\r\n\n\nf\n  \r\r\n.8\t)\n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgB(756866732.2r100%,2136572.%,\n\n5\nl861%\n \r \f\t\f\r\f)\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "1\n\r\f\tRGBa(\n\n\r +.0781b6100%,..54%\f\n \r\r\t,\t-\r.2222020503a%\r\r,0\f\n\f\n) ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "E\rD\f\f\nDbumIOlTrce.D\n\fb";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#piE-";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Srgba(+43,\t \r\r\n\n\n-88\n,\n\n\r\t\r\r\n-74,+57c79c0\t)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Eb\t\f\r\n\f\f RED\r2L\r\r\n\f\n\r\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r)rgB(-575  \t\t \f,Fq\t\rU2,30\t\f)bf\fu";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\r n\f\n 7\r\r\r\n\r\tDrkSamOn\n\t\r\n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "%\r\t5ello(W";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nrGBaN(+323%\r\r\n\f \t,-.36105%,H\r\r\ff-91S0%,-238603\n  \f\f\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \t\fTlignetYEELLW\ri\r\r  \n\r\f\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\r\rRGB-A( \f\t5,2\f\f\r\r \r,f6\r\n\n\r\r\r\r\n\n \r-04643934822)\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgA(+025096.9921%, -.8801064413%%, \r\f\n\t\r \n\n\r+504.4%,\f\n\nM\n\n8)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGba(\n\r -10,\n\f\n\f\r\f\t0\n\n \t\r \r\t\r\r \f,+0\n2\t ,\f\n\r\r \n\t\r-95071\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgB(95340\n\ro,t\n  \r\n 30255,\n\t\nCB\f\r\r36 )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rG 6\f\r\n\n\f867,\f\n 238,\f\n\n-6K8)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nq\fRG-B( \f \n \t\r\t+516,\r\r\f \n \r+1e,-4l443781\t\n\f\r\f\t\t\n\f\n\r) ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGBa(\r\r49391% \r\f7\r-1024661M7.890991%,.27250%\f\f,\f\f\n \f6111866L11160.58610\r\f)\n\ra\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\rhSl(\r86Y.34931344\tI\n\t\r,\f\t\n\n\r\r\n86762.85956506977%\f\f\f\n\f\r\r\n\r,\r\n\r466417547%\t\r\n\r\t\t\r\n\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGba80960,\f0397\r,+2107s\n,\f\n\r U.40258710L28 \f\r \fN\t)\n \r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rb\n\ntMaTom\f#\r\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rRg5(740%,2631.481%,.8%\t\r9hM\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGb9795F1,\t\r\f\n\n+575\f\n,\t\t\r\f\n\n-1R3\r\n\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGB(+29,\t\n\n\f\t\r\r+,\r-U)\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "IgB(+n97,\f\f\r8580, \r0(\f\t\nD\t\r992\f)\tO\t\r\f\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgb(\n.9a613%\n,\r.0%\f,\r\n \r3459%c\n\r\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "a2EtARoIsE";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n1ED";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\f\f\n#FeE#ND";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rHSl1\n\r\f \r\r+.78di594\f,F1.4412739723%k.4%";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fe\fREgba(\r .5%b,5\f\t\n \t)\n\t+.853%\f\n\r\r,\r\n\r\f\n .7%\r\r97.055BA3\f\n\f\f\t)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGb(94P\n\n\r,\n55.6%,\f\r\n\r\r+91\f725.4%\r\n\t)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGeB0(-2,B%4-1\nM\n\r\r\r\t\r\t,\f +6k5)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "nSL(\n   \f\n\rl98u,F25%,G \r\n\n\t+9.4\t)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgB(-6 \f\rf\r,+727\n \n-290271)\f \r\nOe \nl,\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\nm#frA6eD";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "BIG9";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " orRongerD";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\rhiL(.965,\n t\t\r\rO-.t87568%,.8750)\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\nsAddEROwN";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgba(\n\n\n-2r2.687h730442%\f\t\f \t,21.5%\n,\n\r .8192%p,\r\fl+.2261P9\n\f \n\f)\f\n7\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "gb(-U4801,\r\t0\f\n,+2d0F";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "liGhpsK,YbLUE";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "YeP%s7KBn6mB";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBA(\f-.0%\n\n\r\n,-.8%,.7%\rh\f\r\r\n,98c050820.8)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\f \r\r\r\rrGBAn-.204137%,\f\r5.29%\f,-F4793O% -1)\n\t\r\r\n\r \f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\n\r\r\r+rgBa(\n\nB\f\t50s202688.3%,638%,2725636Ku\n\n ,\n\t81Gw82)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rB(\r1140,Y\no\n\r\f-8\r\r\r,\rh5978) \t\f\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "qGba(\t\r\r\r\t\f\n\f\n\r\rB\f.4%p,\f  \f\r\n.28%\r\n\f \t\r\r\f,-.01n\t740%,.3)s\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGbA(\n\f\f\f+.249630708%,\f \n\n\r \r .8%,\r\r\f\n--.86%,\r\r \f.834955)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#mEFc\t.\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\r\no\rHsL(\f\f\n\f\r -2.8434721704\n\f ,847598635.575%\f\n\t\f\f,\r\r\n  \r27576063%)\r\n \n\t\f\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "r9O(60395D\f\n5C\n338.\t\r,\t\f812h8988F\n\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSlGr\r83#0\r\f\f\f\n0R5967%\r \f\f\n\r\n\n ,.63%\n\n\f)\r \t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "PEDPiuMssacGRD";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "R\rrgba(9\nw,\n18469o+0,.9)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "R%\r\tgB(\n-1046146\n,\t81,943718  \r\f\r\n\t\t\f)\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGB(\f6D1230\f\t\f\n.\t,-35\r,\f\f  \n\t6)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "pHsL(-Y4,\f,\f\r \f\t-.973884%\r8\n,\n23864\t\f\n)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rSl(\f-573\f6.3071%\f\f,\f0.C+.8851101%)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "%#FFN6";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGB(92%\r\r,2%\r\n\r\r\r ,56)\r\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\thsL(P-6219N7145\t\f\n,-.050234207%\f\f\n\r,+34.5%)\f \f\r\n\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rrgb(\f734752928d23,\r\n\f\n \t\r +10760,-5337)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "F.osSgGRReEN \r\n\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsL(\n\ro\n\r\n.09,-F0.%,\n S142055.4%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\f \t\r\nRGYA(C63416743s\n\n\r\n\r\t,\t036\r\n\n\f\rf\fS,\t\f-3(, \r\r +,088\r\f\r\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r \fB5(\t\r+9%,\f \n\r\r\r P\f \n+.pm9511%,.3869%\t\n) ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\r \rhs((\n \t\r \n\f\f\ff\r\t6.098,\r\r\f\n \r\r\f+.60391402%\f\t\f,9.2%\n\f \f)\n\f\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "gb(+52225,C\tK,\n\f \t3\n\n\r\tK\nS";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "edIuS\fno\rfeeN";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "daRK-lAt-bLUmE";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Hs\n(19,.G%\f\t\n,+085t773M9%\r )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "r%bA3-.%21426512 \r,i4986.4a%,\f\r+.977051%\f,\rU-.042\f\f )\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Hssl(+5,-47823767872%P\f\t\f\n\f\t#\t\n\r-.5H752%";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\frGBa(.00%,U\t\n\f\t\r\r-.240013%\t\r, 1%,H.8906\n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgb3(dg5037%\f-71w%,p\f \t+51h85%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsL(\f-.08,\t\tO.939%D,652669712.3%\r )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HS(+88276\fR\f\t\fn-0%,+59\r602%2)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\nrg(\n-36.582075838%,50%\t+7.394%\r\f \f\r )\t\t  \f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "lIpGc#tpK6In\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBA(\n -6% ,.1%\r0\r\n\f,-.494B207%\n\f+2375.86148\n\r\n\t\t)0\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "(\n3\r\f\f-83vY";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\ttRGba(-nc+\r9,\f\r\r\f\r\r\r\ri7q1-4\r\f)\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HS,-.6,(20E\n\na\n)\r,\r\f+.D9148\nd7%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RG(\t\t\n\t03%,+33219.7306389855%\nr\n,R938%) \r\t ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f rGBA(1k,\f\n\rU31120712.1835)\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "q 3\n \t\r \f#bCeaeEef\t\t ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "BAb%Ca\n \rG\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB(\n\r\r\f\r\t\f.9\t,+.8%,\r\fs\n11174.5%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgBa(32112.377608\f64362%,-94310567430.7% \r\f \r  \n+.D404781%,\n\r\r\r\r\f\f-292\n83\n\n\f)b";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\r#EAMD6#Df1C";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgB( \r\r56i6640%\n \n\r\n\n\rS,\r\f\n-3%\n,525%\f\fw)\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSL(602364, \n\r\f\n\n\n\r +.2459%\r\n\n\t\fP\nM\n\nI,.57%)\r\f\fr\n\n\t\f\r\r\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "dkCa60C";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fAngB(69,2799,g4\r \n)\n\t\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "cKF";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rrba(\n\f\n+050377\t\t\r\r\n\nC\f\r\f\n\r,8t,+707\r\f,\r\r  \f-.498s0\n\t\t\f) \f ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "i\fL \f\tEE";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\r\n\t\n\n\r\ndArKrqeD\ro\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGB\f9%,46907.0612359%\r\r\n,\f-.6% \n\fwM\n-.5\f\n\t)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\f\n \n\r olDLAMCE";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f \rrGbA(23313330%\r \t\r\r,\r\n\n+3460\ri1%,-.9%,.29 \n\f\f\n)\n8\f\r\f \t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HLig2HTbluepH\r\r\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nFi+eBrFcK";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\rSl(.475,-35739.165%,-94)\n\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\n\f9hSl(\r\n\f\r\n+.0720,.3538,\r\f\n\n\n+19794.531556615%S\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\ndARkimLeT\r\n \n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r \f\n+\t.P\r\n\n\f\rrGiba(\rT \r\r325A095871079,+9,\n\r38633,\r\n\f\r\n 927-94\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r rgB(+.19%,\n 870645511.74172239U7%-Y.64100823850%2 \r\r\n,\f-596.G3\r\f\f\f\t\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\n \t \f\trGba(\n\r\f\t317.19% u\f\r\n#\r,\f\t\n\n\n\rr.958786%\n\r\r\t,-.%K+.i83\n7)\r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "+6eBB";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "sL(w\r-.6\r0\f\n\f,.3%,+.6%\r\r\n)\f\r\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \f\f\r \f\fRGB(U6Y4\t\f ,661233198,\n9257266\f)l\f\f\n\fm\f\t\n\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\f\n\t\n\rRgBA\n\f .K60%\f\f\n\r\n,\f\f7\nw.55135G2644%g\r\r,8\f \r\t 208556,\n0685700.1)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSl.0n49\f\f,.01240%,-58.10%)\n\r \r\r\n\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\r\f \n\r\r\fHsL8(008 \rR\r,\r+5%\r\f\f\r\n\n\t\r\n\r\r\f,\t.63%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#feYCDFfa\f \f\r\n \r\t\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RDGBa(\n\r24, -9070\f  \n \n,5 + \n\n,082E94219573\r\f) ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\f rGB\t( -1796\n\r\f#\f-5\t,\r1 \n  \f\n\f\r,+5.7)\r\r\t\f\t\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\n\n#s5#1blc\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgb(\n\n\t 3269866, -85658\n\f\r\r ,\r\f\n\f \f\n \f+8423 Y\r\f\f\r\f#8\f\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgqB(+.3%\n\fD\n.4D7% D\rw\r\f\f ,.0%";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Hsl(\r\f\r\f\f-7.89s4,\n\r\f\t\n\f\f\n\f78%,+.9%\r\n\t)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\trgb(-.43%,f\r\r\twP8c3914%\t E\r,92%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\n\f\n\rrG#A(\n \f\n+37(71,-37139185,78768\n\r,93)\r\r\f\r  ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\f\f\t\f\f\fb\tHsl(.i725,-43.27%,7%)\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "eGBa(\f\f\r-53a573\f\r\n\f\n\r\f \t,\t9\f -0\n\f,\r\t\rh\tn+4%0\r1k\r\f\r ,.Mb07)\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "h \r\r\r \rhl(+.753,.1%\t\fK,\r6\nu73201%)\r\f\f\r\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgb(+50457.2754%I5\r\f\r,\n51702.%,\r98769.060%)\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "T\n\rDa %kBLqU\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t \n\nSdKow ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "3sSL(\f\n\f2\f\r\fF885G37B.17,\f.7Y%,37741%\n )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f  \t\r\fhs0hL(\n+8\f\r ,\t\f\t\t\f,856555(0% \r\r\n\f\r\r\r ,+5\f\n\f\t\r\r\n\f)\r\f \f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = ",\r0,fcFB\r , \t7";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSl(.533881\r\n\r\f\f\r+29516%, \t-.6\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#raBO,E\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\r\r\f\rRGa(\r\r\r -6,85\f11,\n\n\r\r+41\r\t \f-0\n,-.593)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "FrGb(D\n\r\t.\r\n.233%\f,\r\t\n\n\f\tG508L,+.8%\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgba(-411,-0237\n96R9ld+16b.2\r\n\n \n\f\r\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\r#hSL(\r9.58814-971\f\r,-45.4o\fi,R\r\f.0u5%\r\f\r )   \t\r \f\nd";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgba(\t\f 37%m\r\r\n\n,\r\f\r\n\r\r\f\f-.4243%\r,\n9 \n\n\r.846% \n,7N )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "sl#61\r\r\f\r\t\t,\t-961r,4.7754\r\f\tA\r,-5%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSlAq(+347542915.6526,+084%\f\f,94155n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "(sl#-b4\n\r \r,g\f\nD\n\f.5827819%\r,\n.7%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\tsL(.483o623\f\r\tR\n\f\t\n.\r\t\r.9%1d7P02%\rC\f \r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBA(\r-7,965\f\t,\n0 \n,\r+.9499T998 )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\r\t\r\n\n\f\f\rhSlSu(2r183u44f\r, \t\n\f\n+2411%,\f .H02%\t\f\nL)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\tp\tHL(797.C240344H+.212%,\f\tP\f\f \n\r4101.G%s)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGB(\n\f+06645f\n,-8 \r\f.\n\nk\f\rd\f\f,1\n\f\r\n)\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nc\n\r \f\n\tt\r\n \rhsl(-5624\f\t\r\f\f\n\n\t\n\r,-M8%,.2708%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rHsl(\r.74,\n \t\n\n\r\f2292%,.9825822,940%\t)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HB(\t3\n.2,8\t\tD\r-.277%K";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fHsl(\f599n,+0575.822564%,24%\r )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "pYGb(\n709.2135%\n\n ,\f\r.2%\n\r\f ,\r-98%\t,f +.5384\ff\t\r\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n \n\fhsl(+484355 Y\rs\r\f,35%\rN\n \t\t6\r\r,N.14%\f)\f\n \r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = ")Hs(K21,p%,\t\n\f\fA.6%)\f\f\r  \f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSL(\r-.1038745\f\t\r\r\t\f,940N33.99482%,\n\t\r+.7%)\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGA(+1%\t\t\f,\r-.98Y9544%,pU \n\n\n\r\n.32%,\r.28\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rHsl8(\n.0,.920465P35%,.4474%\r8\f \n\r\f\r)\n\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\r\r rB(\t  G0 \r-.298%\t,\r     .3302S15% ,4%S\r\n)\r\f\n\f\r\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\r\n\f\n\n\r\f\f\frgba(\n\f\t+223.7%,\t\t\r\n+9%,.57%\f\t\f\t,\r \r\n\t\r+s14+0)\f\n \r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\r\f\n\nhK5L(\f\t\r \r\f\n+.94897Go154\t\r\n\r\f,.13%,\f\t+.4522%t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\r\rRGba(.7805175%\r-\r\n \r\t.863408%\r\fS,\r\t\r\r\f  \r.0D93%\f \n,+.370682)\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "D%\t2bEY";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgba(\f\n+.1806799%\r, \n\r\r\n\f\t\n\f\r+4022.076%,.0%\r\t ,+.239268g.4833\r)\r \ndm\n\f\t\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Hsd(0.8o0F\r,34g.9%,.22\n%\r) \r\r\t( ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#B7bOnABR2F\n \t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\r rGa\f798G%\n \n\r,.7%\n,\f+.6%  ,B\t+.58\t\n\t\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fRCGBA(\r\n\r\f-3%,S\n\t\t\f\r-7333.9212%\f\f\n\t,\r\t \r\n \f+.-1% ,.963634139\f)\n\n \t\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\rH\t\r\fhsl(.27\f ,0.43%\rc,s2.9%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "-\nRb(\rIt  \n.6934475h,+.0%,3%\r\n\f\r\n\f) \r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "bgMm6\nsaquA";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \r8\r\fb\f mIvoRY";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgbA(P\n\f\r\rD+.3%\n7  \n\f\n2726.0%,.8%\t\t\fN,+0)\r\r\n \n\r\t\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f \nRBa(9072361\f\r\t\f\r,\f\r\n1636570,7,048089E)\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RoA(\n-.08974379%P\t,826813%n,\r\f\f\f\f\r3286217%,\t\f\r \r+.46\n9\r)A\t\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r#2abL8acAf\r\r\f ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgB(\n\f\r  \t\fg\n-417,+89\r\f\n\n\r,+\t8611\n\rd\f+";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "N\thsL(\n \f.n,.042%N\f\r\f\t\r\f\n,2O3%\n\t\r\r\n\f\r) \f\f\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgb(\f\f\r\r\f.4782539Mcd4304.37+004,%,.n7%\rG\f\nt\f)\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "DimgrA ioLK\r9\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "OrB,(\t.686%\r l,\r\f\t+.73448%,\f\r\f\f.0%\n\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#\nd-EEE7\fi\n\f\n\n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rBt-\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nrgb(\r8\r\rs,\t 20553058\n\r\n-748271075)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "M#o6B7A)p";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\f\r\r\t\rrgb(o+11% \f,\n\f\n\n\n\r \f95531%,\r\t+8700.8%\f\f\r\f\f \n\nd\f\n) ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSL(+.7\f,\r\r \r\f612.7624%\r\r\r\n\f\r69-438731%)\n\r \n\r \f\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n \r\n \rrGB(+4663088.18k%,.75845554275L%,-.605%\r\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "s\n\r\n\r%.  B\rL\r#Dt";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\f\n\r \frgB(+0315360.0%\f\t\n\f\t\f\r\n\fg\t\r\t-392.c495f83330.625%,311%o\n\t\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgb(\t 3F,+2p6855\r\t\r\f\rB\n\f\t\n),2\r \n+d88\r\n)  ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsL( 3+.49(06673,G540439%\fb,\f2982.C2,w3934%\n\t \n \t\f\f\n\n\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "o0%im";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgB(\n\r\f\f\n\f4,+24446\n,+w535U31\f\t\f\n) ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSL(\f\n\n\r\n-.4378731,\r\r\f\r+.4%,66.1339%p)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgB(+615.h00%\n \n\n\nY\n,\t+.2329311692%,\r\n\f\n\n\n\n\r\r\t+.49h20695% \t\n \r\r\r\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r%\r\r\n+HSL(L7.3,-26G392(2568% \r\f,\f\f \n\n\n\n+.p91%) ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hL)(7D5967\t\f\n\r\r,\rb\n\r +360211%\n\n  7.%\n\n\fg\r#)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGbA(+80666527%,\t\f86.7%,\n\r-9.0%\n\r,\f\n\tg\f\f\f+9304306.547385\f\r\n\t)t \t\r\n \n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgb(\rr\f\r\n+8,25\fe\f\f\n\n\f\n\t\f ,-371,-1599 \n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n hS\t(.662,+.03552I915%\r,40%\t\n)l";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "mcdifGULOOrcd";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\n\frgB(F\r\r950.298625039%\f\r9#\f\r\r\n9\r,\n%n\t\r\r\n\f\t.4%\f\n\rn,.3%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsL(\n\nq+396\n\r \f\r-264115h1\t3.M2%\nF,.G9%)3\r\n\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "UGB\t\f-8255p,\r.804257%+,\r487825B96%)\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rg6B(  +.558,, .F67263R%,3651.2026868%\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGBa(+.2556%\n6\n\f\n\f,\n\n-566461229O55%, \r+3524.59067228%,.2703\t\t\r)\tO\nC\r\n\f ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\t3\n\r\frGB(\r\n\r\r\r\f\n\n\n\f+.43%,9.3Y482%\r\t\t\n\f\f\n\f\n\n\t-915042476%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\r \nOpALEGeeN";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGbA(-F71\r\t,d\r9m3,+5,-35522dD8.1687)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n \r\r\r\nhSL(\n\f\r\r \t.499491,\r\r+.6%,\t7602O9584%)\n\fu\f\f\t\f ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgA+ 04\f\n ,03111803,\n\n\f \f\f\f \n\n+378\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "GiD";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\f%\t+\fRgba( 6901 ,\f o\f\r5,+7064,\r.11\f\t\t)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSL(.07378 ,\n \r 4-\r.q%\fw,\f4,%\f\f)\n\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "l PowERblueC\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "NRgb(d356,B,32O)\r6\r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "KRG(\n\n512q1828559.2%)t8057s888345%,\f\n\n\n\t+0910562%\f\n\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "5  \r\f\n\thSL(-.3,31%\n\f\t\r\rR \r\r,\r\f\t-.56%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nRob+.695%\f\t\n,\r\r\r\r\t\f-833676\n.1087154% \r\r\f\r\f,.668%\f \f )\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSL(.66+80.6u88%,+.7%\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSL(6\f.3 \fh -\f +.41a%\f,0q384621,894-019%\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGba(-3294%,\n\n \f \n\nA1237%\r\n\n\f\f, \f\na\r\n\r4.027\t74351%,.5# \r\r\f\f\f)\r\na\r\f \r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HS5( -1,i25%\r,.4403%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBA(4781.74%\t\n)\t,,\t20680u4.9%,o8777%,\t-.D5\t\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rA(r .071%,\t\n.6 08k8746%\r\t\t\n\f,\r+80022%\fN,-.1)\f\t\r\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\frgfb(\r+5\t,7\f,\r\t\r\n \n\t-1l\r \n\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\nf\nrGbA(L\t\f\t\r8\f\f\t\r\f\n,27u7453L4,\r+43384,\n6198)\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBA(\f\r\r\r 5m65364729%\t,65.1%k\tw,\n.6634%,7.08851 8\r\fm) \f\f \t\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nHS(\f\n \f\r\r\r\f\t-062O5\r\r\f\t\f9 ,\n\r\r.0%\r\r\n,\t\t+.13%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \f\r\r\f\f\rRgb(-517,+3 \r\f\n\f \r\f,P\r-5\r\r\f\r )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\rrgA(\t+.46%,\n\t \n-.3579434k8% \f, \f\t63.n52%,\r63.75586)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\f\nRqBH2S0629 \t\r\t, N+3771483,47925\n)\n\r\n\n\r\f\r \n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rrgB( \r\f)-\f\f\t\r\f\f\t+4685-84744P4,\f\r\f+516)t\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "E\f\rhs((g\f\r\r\r.63946m \n9207595%,\r\f#407%) ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\f\r\n\r\rRB(\r\r\n\r\r\t\f\t\n+2223813\f\r\r\t\f\f,\n\f\n805749459,-699056420597)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HsL(+s7,.19L,.26+%\n\n\t\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBal+147103926272\f\r,\rSf\f\f\f-13419 \t,-96749545,\f\r+3.579)\f \r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "%%RgB(+9088%,+19c,l.o061214) ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\t\r\r HsL(+.9hu4w5\f\n\n\f\n\r\r\n\nG\t,\t\f\f\n56.2%\n,1089.75%\f)\n\n\t7\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n#fDAD \n3\n\r\nm\r rY\f\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "GB(\n\n.708945%\t \r\n\t\r\r \t,-1.24769%,\n-4c99.555559%)\n\r\f\n\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB(\t7.%\n,\n\r.4951510528%,07%9)\f\n\t\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "G5RkN";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgb(E+K8\tut,\f2710\f  \f\fg\t\rIO01)\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGB5(\f\n\f.72A721%,20.359740568%,5856646083%c\f\fs\n+9009068 \ti\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fRgBA(\f3h3661638%,\f.107 %,\n4%,\t\n\t\f+.792548U28)\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGba(54e161\f\fM \n\t \f\f,\n\n \t\r\f\r\f\f\t\n\t-1606541i27, \t\fY-1, \r\r\n+.1\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\rrgbA(-1%\r,-.3%\f\t\t\t\f\f,\f\f#9.3%\r,\t\r\r\r\r\r\n\t.7T)\f\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "1gB(1737U80%, \n+.823316M637%\n\r\f\f \f\nB\r\f,.4B5%\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\r+  h\tl(\tF\n\r\r\r-.326,89N5597%\r8,+348.11130%)\n\r\nh\nb\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSL(-.\n,\r-.25%\r\r\t\r\n\r,\n\t\n748%\f\r\n\n) ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nrGba(-43656 ,\r\f\r\rh\n\n\n \ni\f2920\t,+3002\r \n\f\tH\n,799607.8034)\n\n\t\n\fE\n\t\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\r RGBA(\n+92453529 O,2\r\t\n\f\r\n\t\n \f\r+054194\f\f\r\r\n\n\t \r\t,+31\n\r\t,R61\f\f\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rB(182%,\t,\t-24%,+.%\r,f9nb8\f \n\t\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "r\rh";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "i#a5cA\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\n \n\t\fRGBA(\f27d71123\n\n\t\f\nd\r\f\n,+4, \n\f\r\n\r\tT\f-s84,.596927)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\f\t \r\t\r\rA\tS6l-.8,+.p0e28%\r\n.,220T0%c)\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSlw.m570,\f+e.4\r,\f\f\n.623%\t\t\t\f\f\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "olIEdRAO-b";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#bEfbb";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\trgba(n\t.5l34%,\r\r\r912142%\f, -96.84584\r032%,.80170381) \n\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "9\f7\n\t\ngfrUcYiA\r1";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGba(\t\f .8585%,H.30542008228%, \f\n\r \r2%\f\r\r\f\n\f\r,+1d95.3)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "L\frgB7A(#.202p00%\r2\f\rC .279%\n,\r\n\r.0%,\n+N4617)\t\f\n\f ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\t#ada8E\r\t\f\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGb(M53\f, \n\r\f\f9qK9ee71924\f,\t\n a\f9 \r-07S18691\f \t \t)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "  \nrGbu\n\t\n\n\t\n.4%,.4%\t\n,\n.2%\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n \tHSD(004.9\r\n\t,\r\nU\n\f +67551\n,#.37%K)\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "NN\f3LIeUt";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "FUc2, ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB(\fC\f\n\r\r\t\f5G-08.9%\rN\n, \f \r4.17%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fTrgb(\n\n\t\r\f\f73,\f \t\f\f\f89r521976-5735417772)\r\r ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSl(.62L\r\r\n\r0\r \r\f\f\n ,+0.116%,85076.3D044261%\nk\n\ne\r\n\r\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "4b(9\f\f\t\f\r,\t50338207,252)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rHsL(\f\n\r\t+0.7H,-08043a%\f\n,0%\f+)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGBa(.216515%,\tI 26978I.8N41\rp,\n-.198%,\n\n\n\n\n.275976\f\f\t\r\t\r\n\t\r \t \t)\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "p\t\r\n Glq-28,47392,\t\n\f\r-0u87142)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HsL(\n\f\f\n\r\f+.9\r,\f\n\n\r\t\fp\r\n\t+.8%\f+.8w%\n\t  6)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \f\r  G\t\r8Y\fhsL(\f+5C5, \f330%\n\r\n,-.27)\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rrgBa(+781 \f\t\f\n \r\r-sd619e\f\t\t\f\f\r\f\r\n\t,D\t\n-%684028\f\f,\f\ts\n.34 )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#NsgL\ft";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "FS64c";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\n\r\n\n\r\nHSl(\r\r\n\rh\r\n+4637.330,\r\n\rt-.412475%\r\n\f\r\n,\r\fL\f\f+23c1H.7082%)\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGb(2%\n\r,\n5-.2l\f\r-.48186H%\t\n\n\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \t\t\rHSL(-8\f\f\f,.o695%E \r ,\r\n \r\f.9%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "DArLkSEaUgreEn\n\f9\r\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nHs(.34,+7.41A62%\n,p+L664%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgba(\t\n\n\n\f-58(04473(,\r\n\r \f\r\r-C2690,-43214,.481m\f\t\rH";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "u)rgb(.6% ,-683 2650809%,.1%\n \r\f) \f \n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "w,R9BA(72.74,K41.0(%\r,w.2%\r\n\f\f\n\f\r\r,.3\r\r\f\n \rT)\f\r\r ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSl(.5T\r33,\f.b6%\r\r\r,\fhK8%\ng)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rgBa6,\n\f+1.90105D1208674,+03\n\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rg,(\f\t\t\n6+01\rh m\f\fm\t\n\f +1\r \n,035)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "gGlEudN";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\n \r HSl(.M0,+\r3%,-.2%";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rka(\rC%01\f\fdB7\f\r\t\t\n\f, \f\r\t\r\f\f3181183\r\n\n\n,2,-.7)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsL(L-.8D7,.0602%,\r+.2840814\f\r\t\f\f )\f\n\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "bDC1\f\t aG\r\f\n\r )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = ")Io";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\fRgb(-6362192817U\f9\f-893\r\n,w6528159+304\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\trGb(\f\n \r 7,\f\f\n52616373633+C0587\f\r\n\r)\f\r\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\f\rRGB(\n \t\r-4A\n,\n\r\n\f660\f\r, 064399786)b \n\t\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HL(\r \n \fsd1\r.276\r\f\f\f\n\t\n,\r\r\r \f+.5144284%,+33876D826%)\f\n \f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "h.gb(+188510\r\f\r,H\r\r \n\f\t\n\r+29\r,5309)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgba(65%\f\f\t\t\n ,\n\f\r\f\f\f\r+128883079% \t\t\r\f\t\t\n\n,p\t\f -4%,81.8\f \r\r\f\n\t\r\f \t )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBa(394280652032\n,\t\t \t \t5\r\r u,5\r\t,\f\r\f-.2131\f) \f\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rMGBA(\t \r\r\n\n.716686%H+462309Lr664.809%  ,\n-.\r862%h7#44.62737) \r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#2 \r\r\r\tbIQuE\n \n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rlrgbA(764,+8\f,-085n49500981 \t\r\f\r\n\n,\r\f \t\r\t4-601737)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\f\t\f\n\rRg(\n\f-5\n%,-N54,\r\f\f 652o2\f0888\r\n\f\n)\r\r\f\n\n\f\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgba(l\f \n\r-.6495%,+.94092%,B\n#\f.6940%\f\t\r\r\n\n\f\n\t\n7,+47587)\ft\f\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "R\r\f\neacBFD";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "arrSElGEoEN";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HsL(R\t.3567756,\f\n-755%,.88%\n\r)\f\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "-D,arKORANg\n\n\rd \t\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\tBRgb(00.687#7%0,-.861155,\t \f\n\n\f \r+.9i772)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB%(\n+4231084392\t\n\r\f ,40,\f\t516\f\r\r,\r\f\f\t\f\r.04\f\r\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " otDbR\fF";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Sl(\rs+.2765071,-439485432.58%.07q% \f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\nRGBa(\n.010902,+.810812%,\n.N4%\n ,+.1206\r\t\n  )\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fA\rAGDrB+d\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rRGB(.47w8%,\r\t\f\r\r\f\f\f5.66357\f\r\n\n ,\f\n8+.7%)\t\f\r\t\ft\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\r\t\n\r#Ee6A\n\r\f\f\t4\fu\ra\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgBa(+7\f\f,654Td,3,\n\n +.8i6610p8)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "D\n\n\t\rrGb(-07%,.24785%\n \n\f\f,  \f-.9%\r)\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\f \tRgBA(1\r+2I2808\n\f\f,44,-0\t\f\r\f\t(\n\fU\r.40539123)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\t4cd(\n ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "1\n\f\r(rCGB(\rqF\td+0,+5,459\r\n\r\f,-.76O156\t)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSL(.-3\f\r\n\r\r\f\f  \f   \n\f-.4N0\t\fn\n\n\n\f\f\r,2.5%)\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "srgB(35%\f7\t\t\n\t,319435988.61%,\n-0567l.60 \f %\n\r)\r\r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB( .744211%\r \r\f,3.4um900e60%\t\t\f\f\t\nC,2R24%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGh)A(.8,9%c\fq\f\r\n004%\f\f\n\n\r,\r.8%,\n.898453)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\f\tRg.bA(412126\f\n\t0\r,\f\f\t8\r\t\r,\f \r\n-58,+.99383\t\t )\t\r\n\f\f\fu";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f4sl(+7#7.0186\r,13.4%\f\rN\n533.5823H)\n ah";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HsL(-.298905\r, .05%\f\t\n\f,\ff\r\n\n.A49847a1F2%\t)\t ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsL(+2.4\r\n\t \r\t \f 72%.,518.30915278%\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\te G\t#fAFcS5d8cP \r2p2b\r \r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgba(-4 I\r\r\n\f\r3\n\r ,\r\n7,+222,\r\r p\r\f\n\f.3618426 )\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgB(4S71\f\r, 084L93\n\r\n\r\r\n\r,+98\t0\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = ".#+bc";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rDaRgREe";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\r \r\t\n\r\rRgBA(\f.8%\r,+.02%\fi\rd\r\n\r,\r\n\n..3U2%6,\t+.384d76 \f\f\n\n)\f\n\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsL(8170.14\n\f,N06\n\rF\r,\n\f 7\r-.132464%fl\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fL\r\rsl(3,-.45O482,\t\f-153254811.I7%\n)\f\r\n\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RNgA( \r\t\f\r+4D%(,+9499%,7 5194%,1\n\t\n)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\f\r\f\fr%E\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\fSLc\f+.00\n,\t112186.7%,\f\f\n\n+506%\n\fHu\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rB\t04698,129404485-488) \r\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGbA(2113.28113f\r\r\t ,-6911.549%\r,2%  \f\f,Y-B539-23.49\r)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#DaC\f\r\n\rY(\f\r\r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HsL(U\r01.9252971\n,+-.83565%,l39f\f#\t\r\nr\r)\t\n\r\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGB(\n817b,8852%,-15%qp";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsL(-1,71D83308962%,b0%\n\r\r\n\f)\r\n\t \n\t\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Isl(\r-.51,.0M,-a%\n\f\fR\t)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\f\f \n\r\n\f\f\n hSLo(\r\n\r\r\f\rr8.1795\n\r\f\r,\t 5\r-.4%\f,\f\n\n P.70% )\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\n\f\f\n\f\nhl(\t-.141,.6Y239%\r\f\t,.o9s8%\n\n \n)\f\f\n\f\t\r\f\r\f\r\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGb(\r\f8,-c8235352B83\f\fc\t,\r\r\n\r\n\n+4\f\fN \t\r,)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#HbeB6cah2";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB(06649,+3662907\t,-G+4.2\r\n  F";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HKdsL \n\n\r-79546,-1105948f9.6499%I,\r\t\n\n-482e)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "sK\tbL,B2ue";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "shA%a6t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "wh.6ttE";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Aqua\rL 1\r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "pRBa\n(.0%\f,\th\f\n\r\n-.3,.+%#+82.2145\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fk\r\r\n\f\t\t\nGB-\r\f\r0D086,+0 \f\n,1000945)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "9Yd\f\r\r\t\frgB(597,19\f\r\n\n\n\r\f\fm\r\t\n\n\t \tL3\f\n  f\n\r\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " Sr  \n\nrgBa(m\rS\f\n2,\f\n  96374\t\tc\n\r\n9\tCL-33,.5)\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \n\f\r\rHSa(\rw\r\r4+.677u54,+.6%.,+.3472%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\f\t\n\t\r\n\f\n\nrGba+169430\t\r\f\r\t\tK,+28890\n \r,\n U\n\n\r-854\f\t\n\r,\f-.40346)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGB+845%,\n\r490971i619\n\r,\f\r\f\n-0C625630.205% \r\f \t\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\tRgBA(8950%,\f.d59\n\f \f\nl\r\r\f -7%,\r\f\f\t\n \n\nl.852)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB(\n S\f\n\f\t-10557698\n \r\f\n,H\r\f9u\f,37 \r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\nhSL(\f\f\t\r \f\r\r\t\r+73F2 8547.811N250470,\n\n\f\n63.699%\r\n\r\n\f\n \n,\f\f.64\t\t\n\t)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rHsli5,\n-637281182%,\n755.u0%)\fI\t\n\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "-RTF6eqsE";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "t5\r\fhsl(-.6\nC\t\n\f\r,1.92%\r\n\r\r\rP\r\n,-6%\r\t\t\f\n \n A\r\n)\r\t \r\t\f \n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "##AadbF0Bc";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "q#C1Fe0\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgB(-43\f,e\t\f\nR \f\r\r+2L512\f\r\f\f ,\nn1)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n h\f\f\r\t\r\r\rHsI(\n\f\r \r-21\f\nf\n\f\n,\r \r\f.74n,654.9275%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgba( \r\r\r+.22561%,.19%A,f%\r \n\n\t\r\r\r\n02880371277.985.%,\r\n\r\r\f\n \t5528.0952178 \f  \n\f \n\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t \n \rhSl(\n\n\n\f\f\r\r4190938.5,4\t.9397%,.G218\n)\n\t\r\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HDL(+.9Kk\nE7q,2278G,\n\n\r\n\f\re\f\t\r.7%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\t\n\rRGBa(04980.73%,-332%,\t \rt\t\n\t\f\t\n\r.\n250.5% ,\n-t.52)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nRGba(\n\r\r\r3\n\fT\f\r\t\r\r,72101538\t \t\r\n\n,\n\r\t\f-49995\f,+3449860.315\r\r\f\n\f\tO)\nc\t e\r\ff\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f7\r\n\n\r#3Pb";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\nd\r\f\t\r\t\f \t HLsl(+46,\r\n \r67357888g%,R2\f+0762884.267%  )\f\n\r\t\f\n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgBA( \n.7175%,\t\t\r\n\f\f\r\f5%,-.48050%Y\f\n\r\f\f\r\t,G\t\r\f\n\f\r-i264)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Sgub-56,\n\n\f9\f.\n \nS\n6\r\f,4m88\f\f \t\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "F+4De";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\rRba(74316,\t\t\f\n3\t,-2,\f+.907)\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "G8bp(.84096%, +43.a\t0%\f\r\n\f,+8215410.4823%)\n\t\rw5\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rG (278, P5180.a2356,\f89)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSl5-5049u,9I0q42%\fo,4.m3827%\fL )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\tHslIN6.6\r\f\ra,-803.09783R%,\f \n-.70%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgb(7 \r2K\r-p292626,\n\t\r\f\nP81\r\r\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "R\riS2AlMN#R";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rnba(\r\t\n\n\n\f9\f,\r\t6766\n\f,\f \n-o55\f\f,\r\r\n\r\n\f\n+09\r\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGB(23,\n\r\n)\t\n\n1327Y2\f,8\f87978\nHT \t\f \f\f\t) \r \n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " hsL(.63,+13677e3%,43845S6G9452.740%\f\fg\r\r)\nn\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \f\r\n\f\f\t \rRgBa(\n44,B\t\t4k59,t-9\r ,\fY635.953)\nw\r\n\n \r\r\r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HsL(+519SK347.23\t,\n\f7g%\r\fB\n\f\r\n,\r\f\f1.8%\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "VeneR";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RCgB(+.73L7902288-%,\n\r\f\t\r96.G76%r,-1146r492089%\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rnba(985092\r\r \f\r,\f\n\r\r7894,\t\f\t%\t-8185I8 \f \f\f\r,+45)\n\r\t\t\r\n\n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Sl(+.2,\t\f.62713%\f\f\n\f,\r3\f\f\t\f\t\n \f-.5%)\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "tEr8\r\n #\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgbA(64s5550\n\n  ,20D234309TF,\n\n \f\r\r\f,M\r1.r16\r\n\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGBA(+54321\f\r\t,\f\f\n\r20274n, \n+21272M,+80.4F83462k\r)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rb(\f\r-0%,%+.771258% s\t\f\r\n,\n\fe.Y3%\f\f\f\n\t\r)\f\r\f ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGBa(-0923404t2,  \r\f\f+61269\r\r\r,-190M ,+.425A42394)\f\f\f\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "TrgB7\rc\t\t+.3%\r \f  \n\r\r\r\f,Y.4%,\n\t\r8%)\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB(\f221.30196567%,-.5%\t ,\r\r13657832.05%)\ft\n\rH \r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#s3\n\rY\f\n\f\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\nLiGGhTCOarAl";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgBA(+69,7255\f\f,9u9\f,A71)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\thsl(.97105440\n\f\n\t\ro\n\t.5,%\f\n\n7,\f\r\r\f-1q37.3%) \r\f\f\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGAbA(0\n8\rg-7%D228,\t\n \n9\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#DbffbCB0g\rq\fU6,\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgb(\r\t\rO 0\r.485841%,+.6%,\t\n\n-.9910%\r )\n\f\r\f\n\rU";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGBA(-..0%,\r-.09%,\r\t\nh S\n28392466%\n\r\f\f,252)D\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\r-PqL\fEtUsTqUOiwa\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\n \r\rBB\tAlC8";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgbAOK \n14)50o,\n425605,108\f,.8T)\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSC,(+1I6104n.85,.2%   \f,u07050.49%) ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSL(\r\n\t.85S2\n,.2,5d,#R.4\rG";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f#9%ECgA\twE";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \r\t\f\f\n Rg(\n\n-30.4%,-13997727731.74%L,3042.3%)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGba(\r\f\t684\f\n \r,0l4h6558,46755\n\t(,\f.018996L";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " frgba\n\f.1135029\r\f\n,.6741%6,\f 2%,\n\f\n\n-17.918820)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "sRGbc8(.132408531%,.4c,-74%\f\n\r \r\t\t\n\f)\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBA(+w0,53H,\f+93504048r\nh38\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\rrgb(+949991L3,+1264,\f7356793)m)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgb(r8.,-,\n-697)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\tRgY (.076487,\t\t\n-8K95%,.3%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGb(3\f0984%\t,\t\n\r \r\n   80%\f\r\f\r,.00t61u%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Hsl5 \n \n7\f\f\f +.\t,R84.8%,\r\n\f-0%\f \n\n\n)2";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBA(\r\r\rd\n\r\f+.33%\t,\f0\r\fo+.%,\n\f\f+145292% ,.8)\r\n\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#9ccC 6Bdb\f\t\n\r\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " hSl(-H1287,\f\f\r\f\r38.2%M\t\n-8149.1% )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGB(\f\r\f\r \r\t\r\r.36819513%,-.2b,o.849% \f\r\t\n\n\f\t\t)\f  ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "ROGb(7  n\n6\nU394E,22,\f\t \f\f3\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\n\t\f\tHSL(\r5,020s%\rE\n,\f\r\t  \f\f04658179e)\r\n\r\f \r\n\r\r\f\n ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "UhNadkFDa";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \r\t\f n \r\nMaRkgRaY\r\f ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f8C\t\t\rROyaLBlU\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "C\n\n\n#lAg";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "N3\r\r\t\n\f\f\f\nRgBA(\r+.806360%,\r+98f784% 5 \n\n,\f+.96%,\r \f\n\r.76857990813\n)\n\n\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " mintc3RAEAm D \r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGba(3882C98% ,\f \r \r8%\n\t\t,\r\t\t\f+.519025%e \r\f\f,92894\r\r\n\n\n\t\t \r\f )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\r\rU\n\n\trGD(\r\f\n\n\nd\n\fE\t\n-9408F\n\r\n\t\th\f\n+p5,\t\r \t\f\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\nh(2931287.310997 ,\fr.Y6%\n\n,.00b%\n)\tE\f\r\n\f\n\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rHq#1-a";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGba(\n53556\n\n\n\r , \r\f9 \f\t\f\r\r\f\f\n\t\r\f\n\f\r\f\f\f\f6, \f\r \r\n6g1)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hs(\r\f\r-5,5.1%,57%\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\t \fcsL(+4.3\n\n\f,\t\t \r\r\r\r-82hm.6)62%-%)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "R8BA(+7.f1\n\t\t\r\f\n,\n\r\r\t#+86%\r \r,.4773416%sA\t\f8\n)\f\n\r\n\f\t\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgb6(6,g3RN,2#K6";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGb\n\r3333\f\n\f\t\f\f B\r,\r\fI0146,\f+20%86664)\r\r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "8\f\tM\n7\nhsL(\f\f\f\n\n\r+7.7671\f \f\f\n9\f\n\n\n u.7459%\f\t,\n92%\n\f\f\n\f\t)\f\f\n\rBb C\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\f\r\f\f\f2 \nh\np2fr8Le";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HsL(-0\r,42\f%\f\t\tn ,n.ffb4%)H\r\t\f ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "ENg+G#BF25";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\n\f#fAN1M dm";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "fGB)+5\f\t\nr\f69,#i)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\trgba(\f\r\fm+1%\n,L0.923M5%\r\r,.3%2,-.2B31)\n\n  \t\t\n\nI";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rh#E5FAd\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fRgB(-60\t\n\r,\t O\rOU9667,\t+1L89114e6\n\f \t\t\f\t)Y";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "drGbA( \r-47715.42%, 35733.528702\t\r\rI \n\f,6527%,7 )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgB(+.934%\f\f\n,\r\r\f\r\f\n-.2%,\f \n\t\t\n8639)09%,.93551236\r\f\t \r\f\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\trGB1(.9%,A1s9585%\n\f,\r.39L556%477g)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rs\f\r\n\tIgtgEy(";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\f\f\f+\f\t\n\r \f \tGSL(\n\f\r \f-70,\n\r\r.1%,-5221084.96957%\f9)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBA(+06,\r-34\f\r,464uG8qg76,\r\f +241.71 \f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "dnId\rHSL(\t\r\r\r\r\n\n\r.8D\f\n\n\n\f+1.7(\f,5.,954%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\r\f\rr2gba(\r\f\r\nu\r\f\n\r+S240(3%,-.176%\n \f,.83922 )87,\r\t5)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\fhsL(.48e3\t\r-2(0%\r\r\n\n\n,  \r\f\t\n59794995.48P96%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGbA(.9760037%\r\f\n,-3226.62%,762%S%,.81400\f\r)\n\t\r\f\t\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "aiF.L8t\t2\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f \r\f\rHSl(\n.62980412,86205306mT0,.13%\r\f \nB\r\r\t\f\r\tn\t\f\f\r\r\t \f\f\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "gb(\r\t5621.0%D\f\f,0R.967O942%,d062%\r\n)\n\r\tS\nT\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n  L\n\r(\r\f#3c+b\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \f\f\r\t2\fbA(l6,07,\nP\n\r  -L32T,\n20432)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rR#b\n\n-1\f\f,\n\r\f59,\f\n\f\r\nd\n6723%58\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "(\n\t\f\r\fRg\ti(\f4U,+3%w\r,.92607%8)\f\t\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "mSl(+#31.66676\n\f\f \f,\n\n\ff.4%,+.470425%)\t\t\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\tL\ns-GYNTOE9AhM";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "gb(\rl\t\n\r1085R8001% \rMb\f,+40996Y.9%,\f\f\t\t\f\f \n\n \f-.438%\tT\r\r\r \n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "3sL(\r\fH\n\t\t -.691 \r\f,\f\f\n\r+3654844%\n\n,\f\f\t\r.5144%\r\n\n\f \f)\n\f\n\f\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\rHsl(.14451\r\f \r,-.2810839%,.661158877%\r\t\f\r\r\n\n\n-\f\n)\n \r\t\r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\r\r\n\r\r\rr1gB(\f72i\rR6 ,\f1\r\r\f\fR,+F.895(1U4793\t) \t\t ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\trGba9\f\f\n.621f98168164%,a+.84630%\f\t\r\n,+681.P1387775%,\f\f-.3 ) ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\r\f\n\f\n 8rGbA5(+04409C1277,-64\n \f\t\r,Pl0423,\f-3.07)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "q  \rheTG";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\r\f\n\n\f\t\n\rrg\rA(\n\n\f\f\f\r\n+.%,165%\n\r\n\r\t\r\f\r\f\r,+27757380402.4% \r\f\n\r\f\r\t1\r.3948583\nc\r\f\t\f\t\t)\t \t\f\f\t\n\n\r\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#BO.deEAlp";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Ugb(\f\n\t\r\f-49\r\t\ta\f\r,\f3752)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "df#\rA";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGba( \n\n \f \n0854.56%\t+10%,\f+.546%\f,%860793)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "L\n\f\n\nLUhsL(\n+.1, -1.83\n68%\n\f\f\f,830%\t\f\t  \r\t\n) \r\f\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " r\n(\rrgB(\n\f1.700%,101b022%\f\f\r3\f,\n\n.5%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGBIA(+2728B56.9% \n\f\r\r\f\n),\f\r\r\r\n+.(%K.1%,.838)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r \n \tf\rwgB(+8582,Aa\n\f-1415\t\f\n\n \r,-0736)\rY";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \t\rHsl(\n+57-682291i866.1\r\n\f,)\r\f\n\n\f\r+.G%, -w58790%\n)\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\r\n\t\nrgb(b15190,01+,\f5\t)\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\f\r \nRgba(+418\r,68997,3a,-90.879\t\r \f\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "h)l(\f04371,-.0%,A3 4\r2t1526.316092%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "licebu3\rLe\n,\r\r\n \rF";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nrgba( \n \n\r\f\t\n.61%\r,\r\r\t\f\n\f\r\r\r.163730598w%\n,\f\t+9494.3%\n,96)\r\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rlgba(\r.4A%,+%\r\f\f,.0n%,+.5457\t\n\tp\n\n\r\r\f \f\t \f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGbR69331T52\r \nGm\n\r),\f8.8,66";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rg3bA(\r\n\f\n\t\n\t\r5,p8\n\r\n-4\f, \f3,\r+.\t3e\n\r\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "OAlmive";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hOYpI-INUK";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\f\f\f\n\n\nRgB(2,\n\r5 \t\n\r\f\f\n\f6861131)\f\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgb(\r\f644\f%\f,\r-\fD\r\n\rK\r.36,\r\n.7973)\t\r\f\n\r\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "SGt(7\n\r\t,\f\r\r\r\n 5,+3572\f,+.0)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "De8#7dD1c21w";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\r\r8GbA(\n835118,398\n\r , 76289853\n,\n \n\n\n\f\r\t\rl\n\r\r\f51r9.Y)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\n\frGb\f\n\n\t\r\t\r8l8c715356,\r.,5065)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGB%A(-8\f,\n\f\n\r\f\n+1 ,+48\n,E870)\f\n \r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t0YB0e\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Hsl(\r\n \n\n. \f\f.0025663,.68847339%\f\n\n\r\t\n\f\r\r,\f+.123646947%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\n\rLGbA(\n\f\r(+69%,.77%,.\r\f\r.\r0%\f\ff,\r.37)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGB(-.7%,\r52.02%,\n.219973%\f \r4a \n\f\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "  \t\frGb(\n-.150%,.4,0#628%,.6%\n\n\n\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rFcb( \t\n\f\t+40\r\r\r+,\fU58 2\r)\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "FD";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "3\rdar5KSlAtGrEY";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSl1\r\n.11504209\n2\r\f\f\f,.0%\n\r\f\r5, \n \r\r593\n619908.302%) \t\f\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgba(-7.5%,\r+.5796%\f\r\ret\t\n\nm,\n\rr7.640%,+.\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#aEABEAa\n#\n\r\n\f#\n6\n\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgb(\t\f13%,\n .3321%,\f\f\n\f8%\r\r\r\f\n \f\n\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "0wsmL\n\f\fu";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGb(+46#09,97911%i\f3%,-.2% \r\f\r )\t\r\r  \f\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgB(\f\n\r\n4\nB\nl\r\f\f\r\r\t,7,8b\f\n\r\f\f\f\n\f \n7)O\n\r\r\n ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \rhsPl(\t\t\t\f-24.892\f\r\f\n\t,-.65%,\n\r0.488)F\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\f# bB";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGbA(33.r5%\f\r\n\n\t\r\t\r\n\f,\r\r\t+\n.633%,\n\r689.7%%i-o4029)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = ".\f\fHeCDEEF(e0";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r  \r\t\frgb(\r\r\t\n\r\r\n7M5A,\n89069n\n\rs\f\f,-69t1\f\f)\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\nrgBUO-F.8098206%\n \n\n\r\n\f\n\rm218179u%,\n\f\f\fd\f\f+.2%\n\f\n\r\t\r\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nr\f\rRGBa( \r \n\t\f\t4546282,I1,C +4, \n9.7)U\f\r\n\n\r\r\f \f\n ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\f\f\f\f#eDe2e0\r\n\f\t\n\rc5 ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGA(-890529.6%,94.7%h,.5G153%,\n\f\r \f\fG.78796M\n\n\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgB(\r .1432%.6715239(2%,\n\f\f\f.66270997%\r \f\r\n \f\n\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "T4ErSoDI";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "f#aF3afE3\n\n7\f\t\t\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgb(03882242573\n\r\n-\fP%\f+27P734b30176,\n3515969164\n79\n \n\f\r\t\n\f\n)\r\f\f \n \r\r ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\t\r\fRGTa(\f0\r\f-73528,\r\f\f%\n6\r\f\n,264 \n\n\t\n,H\t.5T12579434\n)\r\n\f\r\r\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB(\n\r\f(4L9%,\t\r\r-.U  t\n\n \r\r\n,\f\f\f\f\f\f\n\f\r\r 01r9%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "SL(\t\t0\f\t\f\f .56 L\n 3 ,+.N5%,\r\r\t\f\nn.6H5%\n)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\tRGBA(\f \f\f.577%,.21%,\r \n\r\r.6543%\f\f,-.53208319464";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t \t\f\ff\n\n h)sl(9  \f\rD\f\t,.7299103865%\n\n\t,.37%)   \f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\r\t\n\f\t HsL(\t\f \r l\r\n \tP.1E\r\n \r\r,\t\rt\n53%,\t\r5472k%9  \n\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\ftAu";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgB(\f\f \f\n\t\f\t.5%,.4% a\n\r \t\t\f\f\r\n,e\t\f\t.35%\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "GbL(F66\n\f58+\f41a\f\r+44299,E5c173.557984)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n \ng\n\rRGBa(+.5%\r\f\r\t\f,14591984.49911%,\r\t\n P\r\n\r\f 4%\f\n\n,U+0.0458650)\n\n\r\r\r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsL(33.89253178705F\f\n \f\t\f\r\n,b\r\r\n\t\n\r\n\r\r\t+2.65%,7%\t)\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \r gB(4%\fk,\t\t-66.2948528%41.86983%)\r\r\f\tg\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " a\t\f\r\f\n\r\trGb(-I8195.R6%,+.71695053%\n\n\f\n\r,.3%)B\t\n\n\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "chaRIrE%Hunts \f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rhsL(\t\t\n \t59.63248972,\r\f\t\r\t\n\n\t.38K\f\f \n ,.41734%\t\r\r\fg\n \r)\f\t\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "-Ehl(+q,\r.71%,0.16M00s3%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\th5l( \r\n Y67,\t\f\fl -23%,\tn\f\ni+8.b5(47%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\t\n\f.\n \rRgb(\n \t8,\n\n\n\n \r\n\r\n-661\n\t\n\n,69103r)\t9\n\t\r\n\r\f\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "IRlN\nRTqro\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgb(\r \n78082EH,-.N06%,+.5814%I";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\fhsL 115,-.18689436%,-.898L0625%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HsL(C-.3,-.47%,\n43381.7415%)\r\r G \n\n\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\fhsl(\f\r\n981776.8,\t4109%\n,\f \n\f\f+4#8.0%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "oyaaLblTE";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r% 0o";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB(\tsM \rh+2,4,%\n\t\r501253\f\fr\n\r\r)\r\f\t0\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\t\t\f\n\fSpRngGR8eN\r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "P\fGrPeYElloW r\n\r\n\nO";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " hsl(\r\r\r%\f\r\r\r\f73B\f\f\tn-.0%,\f\r\r\r.8%) \f\fT\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgB6(\te\f  +239\n \n,024\n\rN\r\r\n,lm+390481)\r \n\t\r\n \n\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\n\tRGGba(\t\f\n\n96% \n\r\r\t,-.40%,\f\n\t\f\f-.95033015234%\f   \r\n\r\f\f,+4187\r\f\f\t\n\n\r\r\n) \t\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "F\t \fhSl(5.3,\r\r\t\n\t\t\n\f.3245%\f\f\n,Y\f3.\f3%\n\t\nO)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgb(+799%,\f\t\n\t\n65467h019258.0173363%\f,+R3% \n\r2\r\t\f  )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t2\frGBa(+.881%\f\n\n\r\f+15781.6995%B\r\f,\t\r e\f\r92.6% \n\n\f\n\th,\n+6.342l\r\n\f\f\f)\n ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\nrGBA\r\nE\f\r\f\f-90u5548037233%,+5421478%,.46%,-631)\n\n7  \n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \trgb-43271217\r \t9)3\r\r, +0103306o7266w+9844385\r\r\t\f\f\f\f\f\t \f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rg(9-5p0\fg \n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\rrg(+6\f  \f \n,-86 \fFP\n\r\tm\t09)\r\n\rP \t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \tcgb(1,1\t\n\n2 \n\n\r ,\f\n87";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBA(\n776570\n4\f,\n\f\n\r\f\r0 -68\n\f\n\r\f\n43238.5)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " e\n\f\r\r\r#A7arbDf,a";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r \fbGb+-638650\f,106317,\r\n+549\r\n\n,\n\n\r\n\n\n\t\r\t543\r)\n\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\thsl(\f\r\f\f\f\rg\n.1\r\n(\f\rH,\n+.2M12%\r\r\rD\t\nL\r,+.8C59%)\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\nt\r\t\f\f2hsl(\r9-66\f\r\t\r\f,.906k,+%216%)\f\n\ti\f\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "u\np(\f#FFD";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \t\r\rRGba24g50\fU\n,\f\r\t\t\r-7\r-\n \f\n,.476010780s6\r\n \f\rG\r\n)\n\f\n\n\n\n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#eAi\t5bAiA";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\n\nu\t\frgba(-808708,\no\n\f-%1,\n-2e-94.4796\t \n \fY\rt \t\n)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " Hsl(.#403\n\f,.D702%,4%\r\r\t\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgb(-5,\r-92137\r\f\r, \n\r\rP\n\r\nS\n\r +99)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "eRgb(\t\n\n786102-,37\nU,014801h1p)\r \f \f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGb(83+7,+0,\rf.8\f\r)\n.DN ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGBa(\f\t+8\r,-6690 P\n\r\r\f\r 24\r,\r\n\r 67184)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGb(.80%\n L\n\r\f\f, \f-512%,\r-.7831%\r)\r\rt\n \r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\rergB(\n\f-6,+74S160,169)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \f\n \fhsle( +4.5173\f\r\f\t\f\f,g.2%,-15520%)s";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#\f+\n7f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RMba(\f\r\f\r\r.5%,5t67G\n.333%\f ,7.173%,.27\r. \t \n\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "gSL(+3.4,.,9%,e220592834)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB(8095%\r,\n\r+5A7%,7% \n)\t\n\r\t\t\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSl(\r.87377 \r ,68a807%,\r\f366Y1.477O47p28u1)\n\n\n\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "wgCNhmd";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgba(\f \n-264)\f\f\f,+35,\f 78653,\n\f+.5q2)\f\n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "CCOAcl)A60E";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB(-97n08747%,-69%,\n+.6,%\r\n\r\r\n\r, +.9) ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "SL(49.9\t,-.84% \f\r\t\rB\r ,C.1%)\n\r\r ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rF\rrGB(\n0751ca\r\r\ro\f-5,27\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\f,\f\r#eBB9aD";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "eGB((\n \f \n\n  \n\f\f+620028445\f\r\n\n\n\f,1845\r\f,95)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#aDckdr\rF\r\f\f ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rb(\f84072218+89\t\r ,S\f+45\r\n\n\t\t\n,P(.6%11F";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nrGb(\f \n -1865i3127872S,\f\t  \f+9)  \n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "FE1CK8m\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rRgba(\t\r367\t,+5662\t\n\f\r,-54\r\f\n+\n\r\f\f09.3097)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\n\n\r\n\n\r#aOBA0bh(\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSl(#.229196e5,.756% \t\n\r \t\n,88%\f\r )\f \t\n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nGba(\f\r\t\r-0\rA\t\t\t,\r-6,\t\f\n +61\fG\r,.3324\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fcECc1e%";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rRgbA(+604782,\r\n+76804,\n\f\r7 \r\t\t,g96\n\r\f\r)\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\n  \n\t\fRGB(\n88235r%\f\r\r,+.8%,-2691393.w50%\f  \r\f\n\n)\f\t ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgA(+7393\n\t,-1p019\t\f \n \t\r\r\r\f,3O,\n\rC\f+02r9Y3111i0186";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HslI(\r\r-.1307530B\f\r, \n\n\r\r+76%,-.90361i43%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\ra0AC1";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nrgBa(\f.0271%, e\n\n\f \n\r\n\n\r\n-.0%,\n\r\r\t\n.670055922%,-.9a\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\r \t \rRGb(35, \f\r\f-3\r\r,\r\n\n\n\r\r\t -2430F02598\f8 \r\r\r\fU\t\r\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n \r\fPHSL(O7.1h47\t872-7,\r \n\n\t4.672% \f\r.229%L)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "2sl(\r25210561\n\n\f\t\fG,\r\f \n.6446504%\f\n\r\r\t,\r\t \t\n017308.6%\f\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsG(\fS\f54.55\r\n \n\f\r \f,995191.75%,\f\r.2%)\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgba(\t\t\t21308%,8.23%\r\n\n\f\r\r\r,\f\n\r\f\f\n\r%\n\t\f.512%\f\f \r\r -.010\r\f\n)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#DEebmgDBD";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsl(\r.848\n\n D\t\nw,+.6-\t6%\f,\n\t)51%\f\n\t )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#bfCL6e\f ()\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\f\r\f\ngReENCeLoqT\f\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\r rGBA(\f\f\f\n\r\t\n.1%,2%,+239420%\n\n7\r\r\f\f,\r\f\f+.782 \r\t)\r\r\n \f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fB\r7\fEU\n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGa(\r,\n-c90f44\f1391584%2\n,\f -23%,992%),\f \f+f.184)\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGBA(+47,+786 5,1,\r\f1)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\t\r\r \f\frgb( \n\r\t\f+7907666\r\f\r\r\nw\r\f,  \f\r\r\t\r\t \r+64\n,\f\t\f45658\n\f\r \f\r\n\r\n\f\t, \n-0659.2)\n\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGB(\f\r.31152%\f\n\f\n\n\t,t+.7535%\r\r\r\t\r\f,o+7.6)\f\ri\r\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGBa(7018%,.81MD,c.95%,.99281)\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsl(.553.,+.9\t618%,\r\r\r\f.71)9%\n2\r\n\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGBA(d4636%\r,\r\f.6175771669%\f \t\f\f\f,\n0\r\r+.378509472%,+64 \t)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "+C#KF1fw(";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n RgBA(45,\n1\n\r\r\n\r,\f\f7 \f20,71636K41661340\n\n\r)\f\r\n\f\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\fRgB(+9.50%\r\n8\f\n ,\ruK\n\tG.93278%\t,\t\r\t\t-.9213%\t ) \n\f\f\fP";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\fT\f\f\f\t\n\t\nHsL(+27603933957.5498\f\n\n,\n\f.3(%, \t.38167%)\t\f\n\r\r\r\f\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nRgB(\t\r\f\t\r\n \fY 455645O90\t\t,\n8599\t\f,\f-3  \f\n\tG)\f\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\t\fCe\r \n\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#Bf4FakOo";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\frgbA(8991589952\f\t\n \r\f\n\f,1367\f\r\r\r\t\t\n,7\r,2771198.5)\f\fg\f\f\r\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBA(9,\r\r\n3q40m0,\r,7,-258221\f313M\n\r\f7 \f \f)\r \r\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "01(,\f\f\f-2%n,#S0%%D\to)\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#t(DP56AE2B";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "+5t\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGB(\f\n+n90%%,-.785%,.79%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "-m\nK\fBrarKLDtEnBlse";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "gpBA(d8710(6L22 \f \r,\f\r \r\f\nt 0\n+.\f5) \n\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBA(-.g85%\n,%4 ,-\f.413%\n\t\f\t\n\r\r,O\f\f \f5776A.6r54415)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "E\t5";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsL(.07616N221 ,\n+6%\n,\f\r+.1%\rN)\r \r\f\t\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r \f\n\t\ngB(\f\n6%\r\n,\r\f\f\f\r\t-.91996%,6085670% l)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "reb\f\r\n\fM5R58,\n\n\n\f\n+87,\f -5u44)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "DAowrkRb";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RPB(\f\r+264818\t,\n\f\n\t\f224\t\f\f \r\f,361\f)\f\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgbA(\rG\n\f452642.79004073%, 8%C\t\f\t,\r.854959%,+.P92)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nRgB,a(25l7g4133R,+4U094155Y85,\r\n\r\r ,.98734)\f ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\tmRgBC\f\n\r.\n\r3.I8% ,.16%9-8612.1%\nI)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "a PAepLeRd\f\nC\r \f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rRGBA(31%\r\t\tr-.3%,\t\f.76721%\f,+9)\f\f\t\r\n ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\n \nrgBA(.6R%,\r1 1.839,.3%g,\r\r\r\t\f+9,.15295\t\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "DARviOlT";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\n\r\n\rrgbB(-55%\f,.1%\r,+.145629646%\n\f\f\f\f\f\f \n)\n \n\r\f\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "DGBa\t(\r\f\t\f\n,\f-517%\rS,.0%, %.730%,+.1 \n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGBa(+90756M\r\n\r\r ,\f-, \f\f\f\nGA020194R9,\t\f\n\r\f\t\n\r-2905726)\t\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "3#eeA \nRb\f \t\t\f0\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HdmR\tDsyaLBlUE";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "MHS\tf(.40+5%4,-.Rd0%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGIA(+7\n,i1,2\f\t,k660.t14098\r\f\n\r\n\f\r\r\t\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGBda(.9%,\nf688.165693%\f\r\n\f4\r\t,\f,9%,\f\n\f-.26 )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "grEEnYElLO\t\n\r\t\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "gbA(+9258.8L4979493316%\n\r\r\r\f\r\tP\n\f,\f+.02% \r\r,\r\f-.5%,\n 9.624350 \n)\f\r\n\r\n\r\f\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGba(\f\f\n\r\r\tp+65 ,+43977557,\f\r\r\n\ro\ns08 ,a779i53.905\f)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGb(i\f9598\n 79\n\f\t\n \r \n,+51,\r7\r\n\t\f\t\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nhSL( \t\r\f\r638182\n,\f\fG64Y224.4384%\t\n,659%)\r\r\f\f\n  ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\f\n  \f\r\nwRGBa(1\n\t+414834700,\t\n696654325,\ns+.04)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\r\n\f\n\nhSl(\r\r+.7,.6i,\n\r \t+0K7587518%\f\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "g#FEEcBlAb";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGBa(+22906\re\t\n \f\n\n,3,+6\r\r\r\r \f\f\n\f, \n .68\n\r)\r\n\r\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\t\f\r\nHSl( \n\r.0848D985--.294%  \n, \tU\f-.s45084%f\t\r\t\r.\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HS(+604\t,\r \f\f\f\r\t\r\re\t0204.7%,-10.9e58874%\f \n)B\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgB2\r\n8\f\f\r\r\ti+404264,+5\nS+\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "gA(04294,93\r\f,\f+6,\nnT\f-d6548k4w6d\r\f\r\f\r\n\n+\f\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "DECb1A";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGBA(322214,\r6\t\r\t\nD \n\t\n ,\f\f\n\r\r\n\n0\n\n \n\t\n\r\f\t\r\f\f,-092742+059.99)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " rgb(82.6%,\tl\t.87%,\r\f\ni\r\f\n31E.8400%s";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rRgBa(\r%442671\f#+\f\r,,\r \ff\r\ne\n40,\f+6i5\r \f\r\r\r\f8.6\r\t\t\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\r\r\nrGB(\r\f\r\n-696%\r,-6810108107%\f\t.\f,-951.3 51%)\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgB(\f\n\n\n\f-.2285%\r,6o95%p,. 8571%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "4bG b09870#7%4 \f ,\f\r\r5803303%\f \rg\f\n+006754150% \tB\r\r )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rhSL(\r\n\n\f\rI2\t-4.82976,\r \f\f-1%,\t\f\f\r\n\n\t\r-.69%)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "%\fmIDNiGHtObL0EA\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\tgB(48\rU8%1649,\f-0\t\n\f\f\r\r\r\rk\r,\rs7)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\f\r\f\n \f\nrGBaR(\f\n\n\t \r\r\f+9.1293%\n\n,5134%\f,\f.47047064G73%\r\f\r\r\f,3 )\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "r2.iGb(623678\t,512\t,\f\f\f+,13";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgbY\f.595m1773)q4%,K.4\f\r\f \r\r\f\r,0D09.Y078042%\n\f\r\n\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#fKkP";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSL(+)084,\fw09F075f51.D%,.6g953%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RguBa(+50\f\f )\f\f\r\n,\f\f \t\n\n 8\r41463\rE +96163991,\r\t-.3374221\t\f\r\n\r\r\n)\f\t ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSl(+.68134I5828,- 752u14%\n  \r\t\t,-6.4988%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgba(\f\r\f\t\n-79\n\f,\f\n\r\n\n\r\n\r\r \f+6\n76e8791,\n  \r6510194\r\f \r\r\n,.3599605091) \f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \rlsL2(\t.8\f \t\n,\f \r\r\f\r.o0,-.1%\r\f \f\r\n\t L\n\f\f\n\rE\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\f\rrgbA(  \t\t \t5a\f\n,\n+604-935\f\r\n\r\r\f\n\nL+4)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#cHd0";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rB#S";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Hsl(52\f \f\r,\r35%\t\n\t,\r721-50O8.8%f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fRgtb(-0805%,.f1351o\f \r\n\n,\fn\f\f\f\n\n.8180649bn297% k\t\f\r\t\f\f\n) \f\r\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "ogBa(4%%\r,\f\r\t48.88612,89828302%\t\f\t,\f-2 \n)\n\n\n \n\n\n\r\n \r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSl(.47\t\r\ni\n \r\t\n ,93310.894897%,\r\r\t\r+.1799%)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\f\rt#dAF5\n\rR\r\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HsLI(\r\r\ne5273.5\n\t\rb\r, 8.78g562)%.227%\r\tp)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\rH\trGBaFB+6,\t\t+1,12,\f\f-.0s)\f\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Hs1.5\n\n\r,\n+.8,s1% ,";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\r\n\fGb(\n\f.7,5623%\t\f,+353%,\r\t\n.5070984%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nrGbT-604\n\t\r,\n\r \r+1\n\n- \r\t\r ,4\rh7\f\r\n\rGY\f)\n\r\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgb(\t\t\f\f\r\r\n\t\r.4454%(,\n\f61630.1830O5%\n\f\f,\n 2009.373%\n\n\r)\t\r\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\n\n\frgbA(259568T7%\n\t\f212700.80%\r\n),-.375101%.7731564981S\r\r )\r\f\n\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fRgBa(\f\f\f\f\f\n\r\f\f14r.a\f\f,\n\n \n\n \f 412,\f\n\t\r21926\tF\f\r\f\f\t\ne,\n-3) \n\r ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsl( \n +7\r,w-63%.033%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rB(\n\t\f+.7315%\r\n,8.3%,\n\t-\f16.871260%)\n\r\f\r\r\f\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBAe f\f\f\t\r\r+538946U,U4\t\r\f\t +1w,98\r\n\n\r\r\r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "1SF0g";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\n\n\n\r\r\fRgb(\r-5118\n\r \n\r,\rT953,-16\r\f#\r\f\t\r\n\n\t\r)\t\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "r\t2gbsa%6\f,+#98965\r,+4)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\rrEB( \r+.96R54%,.1I\n\t\f,-.137%)\t\t \r\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#4S38\r\nf\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGb(B4% \r \f\t \r\t\n,02.8%,\t+.19%\n\r)\t\tA\r\f\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Gb5E(+68)4\r\n,  \rt\r0 M+9w04546,+22)\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rghka(6,\t\f560,\n-30303872\f\t,-)109)816\f\r\f\f)\r \r3\r\t\n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \t\trGIba(\fF\r 1 \f  ,L\rt\n9116,\t\fU\n-2\f\r,+84820)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Hsl(\r4.130, -.294\r2%\fN,\f\nD\n\r\t\f\t\r+.189% \f)\n\t\n\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB( \f\f\nK\r\f\f\f+41598%\n,\t(\r.\t4038l9T%\f\n\n\f\t\t\f,.7%)\f\f\n\f\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGbh\t\n\r\f\t\f-9161\t\n\r\r,F\r,4 \r\r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "H6sE(.5\n\r\f,\f.8%\n,.1s)\r\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGa( \n3\n\t\f+0.592263% \f,+5472%,\r\f\r -113928764.120%\f\t\t\r I \r,-.717)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\rHSl(-.\n,\n\f u\f  \f.09%,+15483U.354%%\n\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rhSl(\n N\n\t+36832\n\n \t\n\f ,+83192219)60.4833738%\r,+1664.7%)\r\r3\n\f\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \f\rgBAl8\n12532.3467%\f\n\n\n\n\f,21496I%\t \t\f\nh\r\t1\n\n8Y7%,\rD\f\n.13)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " RGb(-.4%\r\f\f,\n\r\r0059g18.9U2(Y%,+05%)\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "DA0Hwa\fh\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rS rgT(\r \n+512640,38,8P,0)g8)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \r\r\r\f\rrGbA(\f\n\f\f\f\r\f+487.2% ,\t\f\n -.8093%,-3\f43350d22u.546L4%\r ,\f +137048851061s)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = ")RGB(\f70\r \f\f,+1\ti \r,+3S\f\f3)(\n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgb(-00 \f\n\f\na,83,\r-5,34)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f#C6ff#AFBbE";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "n\rRGBa(66%\r\n,310.707626n2%, \t\f\r\f\f\n\n\n\f+.237249%m\r,\n\f.35469064)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "(gbaY-4552,+27248F4l \f+\r+\tr+.92\n)\r\r\f\f\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgba(\fU\r-\f792-6363,\n\r745126\f\n\f\n\f\f\t,+5.2C\t\r\t  )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r   Rgb(+664.9,\f\r \n+58148\t\f,81791b9403\f\r\f\n\n\r,\n\f\f\t\f\r\r 0697d13)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Eetde";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "gB(\n\f\f\r\t+.8296%,-.82%05677172.837t%\f\n)q";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rgp(a1\f\r\t+740.6278%,\f\n\n\r\r-1780.7980%N\f\n\f,\f29%,\r\f\f\r\n\n\n.145387)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "d\nqKr\rrg";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rRGbA(-0085935d,\f2971M913\r\t,-7201106340S\n)\n\n\n ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\r.M\nRgbI(\f\f\f6.910L144%,+c78%\f,\r+137.07%\n\r\n)\f\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgbaUt(\n\r\n\r\f9\rh-846041\f\f\f\n\n, \r +4\r\f,+3\n\r\r\n \r\f\f\n,.48)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\nrgba(.5%u\f1573.6%\r\n\f\r,+3119324l.21%\f,-721481690.47\f\n\n\f\r \r\f\t)D\n\f\f3\n\f\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hl(6\f6646+\n.6393%\f\r \t\t,.92e6%\t)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGbA(\r.39117%\n,\n\f\t\r\r+.0A8T29%,+.01.54%,.0l83\t\t\f\f\n\f\n\t\nY)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hsL(\f\f  (\f\n\t\f98.5,\t\n\r.6%, \n\n\f+7504057829%)\nf ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\r0sfnk7";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HsL(\rt\r 2297,-.863%,-6207712%)\r\fu\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\f\f \r\r-G(\f\n\r5\t+6% \fP\t+\r, .5%,\f\r\f\f\f-.4T-8%\f\n\t\f) \f8\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\f\f7L\r4 rGba(09%\r\f \r,+.976631414815%,-.88%\r,\f.g082)\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r#ccdAq R\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rcmT";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rRRfb(.4233Y1185t%\t,\n \r 51%,\n8632%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \f\nrgba(-Yw\t\t \t ,\n\f+3930,-8129,\r.84597719\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \f\f\n\t\f \r\n\fRgB(2466.1%\r\r,\nIB\n+942.4813%\n\rF,\f \r\r\r3.0465%)1e\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\f\n\n\f  \frgba(\r\f\t \r\f\f\n\n+7,6\n\rT\np\f\n\n-87\f\n\r,5.67\n4304)\f\f\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSl(+.6, \fi\r\r\t629.18701725% \r,\r\f-00053.4463%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HsL(.2\t\r4\t\f ,\r+.12423%\f3565%\f) \n\r\r\n\t\n\f 2 ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#\nq63SBh7ED\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "UIUoipSeUY\fG\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#IC g\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rYb0A(75, \f\t\r 2 \r\n,4\n\t\n\f+743532I97)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t6sL(\f\n\r\t\n\f\t-7\f\n\f,\n\f581763,8824%\t)\n\t\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "c+\tDD";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGBa(.Tu%,2fr617+g26t\f,+.1401%,\tk\r\f+.1) ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " Bm9eMEpnpnq";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "b49,541M816014\f\t, 4\n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#MAEafdS7D\n\f\fH\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\r\t\t\n\t\f\rRgB(\t\r-\n\f-8\f\f\r,310,\n\t\f\t\r+99\r\r\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBa(452933\f\n\n,7738657,63i,+1\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "F\td\r\r\r\t\r\r\r#4BdfdBfaD";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "U\r \fbgORd";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nT-s,l(.89\f ,\t\f+.7%\n\r\f,\n+.iU403I19u0152%s\t\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB(\t \r\n\n\f\f\f\f\r8\t\f\f,+09NR329,\f)\r4 19\f\fh\n  \f )\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rMEiu4mLPt81Ue";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#brebKcBDB\tg\nd\fT";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgA(\n0151(,341U4069\n\rU\f\n\n454\n,-a3\t\fd+";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSl(0316.92061536,-.17%,\f\n\t\t\f+0883e7%\r\n#\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#\n q\tI4 #EcBb\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t\n\f7\f\n\rrb7.sh813q,.14d801737i%,-3%\f \f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSLS(873321.9,-29038%\f\t\f\r\r,.81Y6%)1\n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\t\r \f\r\n\r\trGBA(\n\r\r\fN 798,28,-5,\f-.3165\f\t\t\f\n \n P\r)\f\t\r\t\n ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rfrgB6\r+.3%\r,T\t\t\t+.904%,38.s7403%\t\r\n\t) ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "8\nnrGBA(\t\n-02585\n\f042%,\f-. 253D123%\n\f,\f \f\r+.2071405539%\f,\t39)\n\f\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\f \fRG(76, \n\f\f\r\n+\f\f, 4991\r\r\r\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "4RgBa(\ni\n+2\n712507,\f\n-2\t6\n\f\r ,\r3471820,-.8\n\n\n\f\f\f)\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBa(\r\r\n\f\t-049Y45,5,+5\n\n\r \t,\f\fr\n 8\fE\r)-\n\r\r\n\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "o\nTb\thsLM826,\r+.49%\t,\t\n\r\f\f  -0%4\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = ".haaC5 -7";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgb(\t\n\t\t\f-1.FS1202%,.H9%\r\r,5\n90062O\n\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = ")\fiImsOHN";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\frGA(\t\r\f-Pf9%\n\t,\r+E4805n9P59%,i\r\nq% \rG9,-39798)\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgba(56d246\n\r\r\r\t,\t\n\r\f+71762,37#295,93142.52 \f\r )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "tbA(9,\r6,\f\r5,\rF\n\r\f\r\n\t\n48)3.47)\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "slatEGREY\r\f\n\t\f\r \r\nq\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\frGBA(-6%\f\n,\f\n\n  .5%f,5.8l9%\n\r\r  ,\r\f+2)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r \fp\fiBA(-B9 998.4Y,.1%,\r\r\n-10%, -427.89\n\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\t \nhSL(-.0700\t\n\r,.5%,A.0g%\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB(+42g\n,   20h#.01232%\n,\r\r 91904.0%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\fhs(\f\r\f24aU\r ,40.6815%\r\r\rr,\r9034.95% \t\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Ng\f\fDaRpvIoehT\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fhsl(R6\n( \n ,C2F5q03%\f\t\f\t+0%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\r\n,\nUrgba(\n\n089411%,\n\t\r +3.7S%\f\f13%\f\f\n\n ,L30P78) \f\n\r\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fn\r\fRGbg+8889 ,24q84\f5D361T)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rg(\r\r\n\f\n\r\r-.u39%\r,\t  \n\f\n\n\f\f\t0.952%48%,7.1%\n \t,\f-704)\r\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \tHSl(\f\fK236.2\r h\r\f\n\n,\f\t\r887.1341554%\n, h\n\t\fS\f\f\n\r-22308344.3260%\r\n\r\t\f\n)\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\tRGBa(w5094.146i%\t\f,.9128852%,-.610225566%,\n04328.8)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Cr)MSoNU5hL\r\fO\frh n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nFifERIC\tk";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGba(\f\t\f\r-.794%\f \tY\r\t\n,+.94%,\f\t \t\n\n 0191927.02449232%\t \r \f\r5,-.77\f\t\f\td\t)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r(#b\rE";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HsL(\n.19682,+1.w516,\r\rr65%\t\r\n\n % G)\r\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSL(.03618u969,+86d.99%\f \t ,-S5%\f\r )\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HstLk(\r\r\fT6 \t\n,-.34Ga8tn1%,Ad1%\t\n\f\t\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB(+68590.9%,.732%,\t\f\f+b1%,\n\n\n\f. )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rrqgb6(+299\t\n\n\f\t\r80187,008\t\n\t\r\t\t,-97382.63L\n90400\f\f\f\r)E ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "H(38 \f,.9024433%\t,5(-32%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\t\thsL(2\r\n\f\n\t \t,\r\n\r\ti\n\r\n+415394.0380329%,\t47833534F.50727%\n\r\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rg(\r\rk\n\n\f\f\r\n\r45a\r\r\r\n \fF,81\r\f\f\r ,219\r  )\n\n\n\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "gReEnYeLlO.lw";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "BA(\r-9,-9(1+04DD7,\n\r\r+22780847 \f\t\f\r\f)Y \r\t\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "gbA( \f \r.9%\f\f\f\n ,.0910174007\n\r\t\n\f\n\nK,70% \r,\r\t\r.91\rOR\r\n\nG\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "h6sL(\f\f\t \f\t-.574,\n.8%,\r \n+0109.023948% \n\n\n\r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Hsl(h\r\f\n,\nq\n\f+25%,.I677%\t \t m)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nhSl(+4127\f\t,+.#L%,\t+.229I244691I9%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f+Rgb(Y+4M8340 \n,\f\f\r\r\r-5,-4T";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\t\r\f\t hsl(-.084\rh\r\f\f,\n\f 0\n\n\f18542%,-8800%)\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\rrnGBa(\t\t\nC \n89\n\t\f,\n-8,-21d,\n\n+222E  \f  -)\t\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgBA(\t\n\f\f369%,\f\n-4%, \f\n\n\r\r+.8428223%,\f\f.60O264\t)\r\fr ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGb(\n\t\n\n\f\r\f9%\r\f\n\r\n,\r\n\f\fn\f\n \r\r\t.4494895Y2%,.3633%\f\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Hsll4119.90865D1\r3 \r\f \t\f\t\n\r, 2-007.9%,+s.462%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RLgba(\n\r92fF-w76\f4,\f(49\t5\r\r,+.1\t   \r)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rLBA(\r\f8\n\r,\r\n\f\n\n\f\f\r12,41,\r\r\t \t5#\f\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#eEFf\fu\r\n\t\t\f6b\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\thSl3w\n\t+h5.73,\f\f\n\rg\r+26.5829N9%\n\t\r\t \t\n\f\f,.%\n\n\t\f )\r\t\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "K \rrgBA(+890935762,\r\r21007694061\n \t\f,+96,\r1\n\n\tT\n\f)\n\n\n\n\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "2AeYTUrdo";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "n\f#dAe";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n RgIBA(48 \f\t\r\n\r,\n\t\n\f\n\n\r\t\r7\r\f\r\r\r\f,q\r\r\n 6i\n\r,\f\r33\fI%\n\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSl(\r+.6063O,\n\r\r+47351319.7%\r\r\t\t\n,206317%d\n3";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nghsL(3\f\f\f\f\r\t 2009,490.3c05560%,.0400%\f\f\f\n \f)\te\r\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\n OwYchid\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Lm.6\n,\n\r+4984%6\f\n ,\n\td%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HsL8-.57404\f\r\n\f\r,+d436820s396.966045086%\r\f\f\f,.770%";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RGBA(+77.16%\nm\t\r\f,+9535021s69.46%,F\r-.0w%,+06973762122.851) \t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\f\f\r\tB\rwheT";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGb(\t\f\f5\t\n\f,\n\n-8\n\r\n\r,\n\f \nd205o75\r\t\t \f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\t \n\n \f\r\nRgIA(5%\f\f\f,-.U2%\r,+675.76450144a\n\n,\r-.857784)\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "Rmgb(\f .5%\r\rr,7Y%,\r+.073%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "4rgB4401766.47% \t\n,-.784748)% \f\n\f\r(\f.\t,\f\f\n\n4666%\n\r\f\t\f\f\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSL(s +30234\n\rG\r\f\n\n,\t956147.85l3 l25%, \t\r506701682.F12%\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \n\fpAPF(A\n9hS\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#dDdMu1bEC8\fw";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n \rOs\n\rHdSl(N \nr.C,73%\fL\f\f,\n\n+p1%)\n\t\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "IVRguqy\r";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgb(0\r\n\n6028590521%c,+0.2117962269%,1365259.l29%\t\f\r\r\f\n\n\f ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\tRGb(  \r\n\n\t\nf\r\r+.3585%\r\r,.1%\f,-56%\n\f\r\f\nS\n\r\n\t-G)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\fRgBA(9264\n,A98284\n\n\f,Y5\rh64752\t\t,+07538588122)\f\rfP";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#aAHYPFo";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\f\f\r \n\nHSl(o+.394\f,-2771#17.%M%,+0%\n )";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "7\rRGB(\t\r\n\f18\t\n\r4\n\r\n,14531,-4712\n)\r\n\t";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "#ewY";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HsL(-6,\r\r\n)\t\no03103.6756a%\r\t\f\f\n\f\r,\n\n\t\t \r\f\t-119.69% \n\f\t0";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = " \rrGB(+924282\f 1\r\f\t\r\f\f,+62 \r9,-9280+4552T)\r\r\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "RgB(.816t64%\f ,\rG+0%\t\r\n-.74%\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\r\f\r\r\tHsl(\r-.8,41%\r\t\f,-h3325-%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgB\r(75,-4\r\n\n\r\r,a043616672e784 22)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rG\n.5882051o39,\rnH\r,\n\nq\t-69%\n\f,+1.21%\r\n\t\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\n\f\f lIGhTsLALeRey";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\nM\f0\r\rhsl\r\f.991034734\f\f,+.545675%\n\f7 \f\f,\f\n\f\f\t pBG09.62%d\r\n)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "hSl(i29746649,-3,\r\f\r\n\n\t\n\n\n\r+.43F99%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rGB(\n1.3%,\f\n\t\r+A99%   \fd\r\rr,\r\t\f+.30329%)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "l\n\rc\n\n6AEafafS\f\r \n\f\n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSL(+82809017.77830 \r\f\n,.1%\f,67.392d)\n\r \n ";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "HSlP(-.71160\r\t\f\r \f\f,91.847571% \r\n, \t\r+5% )\f\f";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "\r\r\nRG2a(-1, \r\t\rI 5\f \n,\r-392N94105,+71346.5809317) \n";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
item = "rgbA(\r\r.8672422%\n\r\r  \t,.93,\t\f -6.7%\n,\r\t\f\n\r\f\n-.4\r\r\f)";
if(ColorValidator.ColorToRgba(item) == null)Assert.Fail(item);
}

    [Test]
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
  "\n\n\n HSL(\r\r\r \t\n\n\r+5914,\t+80.692%\r\t\r,\t000055%\n\t \n \r\n\n\r)\n"
    ,

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
  "\n\r \n\r\n\nhSL(+4787,+75.56752%,\r\n\r\n \r\n 97.247541%\t\r\t\r\t\t\n\r\n)"
    ,

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
  "\nRgb(\r\t \t\r\r\n 40.064%,+00003.28714259%\r,\r\t\n\r\t\t\n0040.1%)\n\r\t\t"
    ,

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
  " \n\r\n\r\n\n\t\r RGba(129\n\n\r , \r\n \r+3\n\t\r,+252, \r\n\n.9\n\r \n\n)\n"
    ,

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
  " \n\rhsL(+6532\r,\r\r\t9%\n \t \r\r\r\r\n,\n\n \r\t+00018.58%\t \r\r\n\n\r\r)"
    ,

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
  "\t\r\n\r\r \tRGb(\r\t\r\n\n-8% \n,\n\t\t \n\n\r +26295%\n \n \n,-.376830%\r) "
    ,

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
  "\t\r\r\r\r\r\n\r\nRGba(\r+5\n\t\t\t,\n -77,8\r\r\t,\r\r\t\n\n+700 \t\t\n\n\r)"
    ,

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
  "\n\thsL(\t .2\r,\n\r\t\t\t\n\r\r\r\t\n+.312907% \t\r,28408446402.74843805%)\n"
    ,

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
  "\nrgBA(\t\n\n\r\r\r \r\n\n\n139389,+0 \r,+348569708\r,\n\n\t\n3.41524 \r)\r\r"
    ,

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
  "\r rGba(\n\n\n0,+6999,\r\n\t \t\t+5, \n\n\n\n\n\t\r\n+16327\r\r\r \n\r\n\n\r)"
    ,

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
  " \t\n\tRGBA(-734362\n\n\r, \n\t15135\n\n \t,+003,\n\n\n-6368464354\r\r\n\t\r)"
    ,

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
  " \rrgB(+24726891.948% , \n\r\t .26162%, \r\n \t \t.388% \n\r\n\r\n\t\r\r)\n\n"
    ,

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
  "HsL(\t\n\t\r\t\r\r\r\t806145111090\n\t\r,-379.07920% \n\n\n, \r\r.60423%)\t\n"
    ,

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
  "RGBa(+428%\r \t\n\r ,-.5712%\r\r\n\t\r ,\r407611.237368%\n \r,\t-.01884\t)\r "
    ,

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
  "rGBA(\n\r\r\n\r-908%\r\r\t\n\r,\r \r\r\n.5%,.50%\t,\r.193926314027)\r\r\t\r\n"
    ,

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
  "rgba(-55%,\t\t\t\t-710.240074%,.61274383560% \r\r\n\n,\n\r\n.746401607) \t\n "
    ,

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
