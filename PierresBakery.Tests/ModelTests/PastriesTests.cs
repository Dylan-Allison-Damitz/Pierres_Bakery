using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [TestClass]
    public class PastriesCalculatorMethodTests
    {
        [TestMethod]
            public void PastriesCalculator_TwoPastriesCostFour_Int()
            {
            Assert.AreEqual(4, Pastries.PastriesCalculator(2, 2));
            }
        [TestMethod]
            public void PastriesCalculator_ThreePastriesCostFive_Int()
            {
            Assert.AreEqual(5, Pastries.PastriesCalculator(2, 3));
            }
        [TestMethod]
            public void PastriesCalculator_SixPastriesCostTen_Int()
            {
            Assert.AreEqual(10, Pastries.PastriesCalculator(2, 6));
            }
    }
}