using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [TestClass]
    public class PastriesMethodTests
    {
        [TestMethod]
            public void PastriesCalculator_TwoPastriesCost_Int()
            {
            Assert.AreEqual(4, Pastries.PastriesCalculator(2, 2));
            }
    }
}