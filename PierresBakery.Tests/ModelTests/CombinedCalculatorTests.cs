using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class CombinedCalculatorMethodTests
  {
      [TestMethod]
          public void FinalOrder_ThreePastryPlusThreeBreadIsSix_Int()
          {
          Assert.AreEqual(6, UserOrder.FinalOrder(3, 3));
          }
      [TestMethod]
          public void FinalOrder_TenPastryPlusEightBreadIsEighteen_Int()
          {
          Assert.AreEqual(18, UserOrder.FinalOrder(10, 8));
          }
    }
}