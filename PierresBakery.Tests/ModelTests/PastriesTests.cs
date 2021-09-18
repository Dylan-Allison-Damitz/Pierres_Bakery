using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [TestClass]
    public class PastriesMethodTests
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
    }
}