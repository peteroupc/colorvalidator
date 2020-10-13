package com.upokecenter.test;

import java.util.*;

import org.junit.Assert;
import org.junit.Test;
import com.upokecenter.util.*;

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
      if ((rgba) == null) {
 Assert.fail(str);
 }
      String valueSMsg = str + "\n" + rgba[0] + ", " + rgba[1] + ", " +
        rgba[2] + ", " + rgba[3];
      Assert.assertEquals(valueSMsg + ": red",r,rgba[0],1.5);
      Assert.assertEquals(valueSMsg + ": green",g,rgba[1],1.5);
      Assert.assertEquals(valueSMsg + ": blue",b,rgba[2],1.5);
      Assert.assertEquals(valueSMsg + ": alpha",a,rgba[3],1.5);
    }

    @Test
    public void TestColorNames() {
      this.AssertCssColor("Red", 255, 0, 0, 255);
    }

    @Test
    public void TestRgbToColorDisplay() {
      try {
        ColorValidator.RgbToColorDisplay(null);
        Assert.fail("Should have failed");
      } catch (NullPointerException ex) {
        // NOTE: Intentionally empty
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
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
    }
  }
