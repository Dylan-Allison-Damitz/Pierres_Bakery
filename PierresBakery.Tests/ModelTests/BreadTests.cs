using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadMethodTests
  {
      [TestMethod]
          public void BreadCalculator_OneBreadCostFive_Int()
          {
          Assert.AreEqual(5, Bread.BreadCalculator(5, 1));
          }
      [TestMethod]
          public void BreadCalculator_TwoBreadCostTen_Int()
          {
          Assert.AreEqual(10, Bread.BreadCalculator(5, 2));
          }
  }
}