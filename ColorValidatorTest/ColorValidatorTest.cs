using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using PeterO;

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
        rgba[2] + ", " + rgba[3];
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
    public void TestRgbToColorDisplay() {
      try {
        ColorValidator.RgbToColorDisplay(null);
        Assert.Fail("Should have failed");
      } catch (ArgumentNullException) {
        // NOTE: Intentionally empty
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
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
    }
  }
}
