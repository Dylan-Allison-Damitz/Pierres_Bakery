using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace MyBakery.Tests
{
    [TestClass]
    public class PastriesMethodTests
    {
        [Test Method]
        public void CalculatePastries_TwoPastriesCostsFour_int()
        {
            Assert.AreEqual(4, Pastries.PastriesCalculator(2,2));
        }
    }
}