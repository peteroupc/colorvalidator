using System;
using System.Collections.Generic;
using System.Text;
using PeterO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Test {
  [TestClass]
  public partial class ColorValidatorTest {
    [TestMethod]
    public void TestColorHtmlToRgba() {
      try {
        ColorValidator.ColorHtmlToRgba(null);
        Assert.Fail("Should have failed");
      } catch (ArgumentNullException) {
Console.Write(String.Empty);
} catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
    }
    [TestMethod]
    public void TestColorToRgb() {
      try {
        ColorValidator.ColorToRgb(null);
        Assert.Fail("Should have failed");
      } catch (ArgumentNullException) {
Console.Write(String.Empty);
} catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
    }
    [TestMethod]
    public void TestColorToRgba() {
      try {
        ColorValidator.ColorToRgba(null);
        Assert.Fail("Should have failed");
      } catch (ArgumentNullException) {
Console.Write(String.Empty);
} catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
    }
    [TestMethod]
    public void TestHlsToRgb() {
      try {
        ColorValidator.HlsToRgb(null);
        Assert.Fail("Should have failed");
      } catch (ArgumentNullException) {
Console.Write(String.Empty);
} catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
    }
    [TestMethod]
    public void TestRgbToColor() {
      try {
        ColorValidator.RgbToColor(null);
        Assert.Fail("Should have failed");
      } catch (ArgumentNullException) {
Console.Write(String.Empty);
} catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
    }
    [TestMethod]
    public void TestRgbToColorDisplay() {
      try {
        ColorValidator.RgbToColorDisplay(null);
        Assert.Fail("Should have failed");
      } catch (ArgumentNullException) {
Console.Write(String.Empty);
} catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
    }
    [TestMethod]
    public void TestRgbToColorHtml() {
      try {
        ColorValidator.RgbToColorHtml(null);
        Assert.Fail("Should have failed");
      } catch (ArgumentNullException) {
Console.Write(String.Empty);
} catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
    }
  }
}
