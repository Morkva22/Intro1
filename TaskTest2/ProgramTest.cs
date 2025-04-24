using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void CalculatePercentage_ReturnsCorrectResult()
        {
            double number = 90;
            double percent = 10;
            double result = Program.CalculatePercentage(number, percent);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void CalculatePercentage_ReturnsZero_WhenPercentIsZero()
        {
            double number = 90;
            double percent = 0;
            double result = Program.CalculatePercentage(number, percent);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculatePercentage_ReturnsZero_WhenNumberIsZero()
        {
            double number = 0;
            double percent = 10;
            double result = Program.CalculatePercentage(number, percent);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculatePercentage_ReturnsNegativeResult_WhenInputsAreNegative()
        {
            double number = -90;
            double percent = -10;
            double result = Program.CalculatePercentage(number, percent);
            
            Assert.AreEqual(9, result);
        }
    }
}