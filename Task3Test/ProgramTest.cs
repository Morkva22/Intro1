using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainTest
    
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void CombineDigits_ReturnsCorrectNumber()
        {
            int digit1 = 1, digit2 = 5, digit3 = 7, digit4 = 8;
            
            int result = Program.CombineNumbers(digit1, digit2, digit3, digit4);
            
            Assert.AreEqual(1578, result);
        }

        [TestMethod]
        public void CombineDigits_ReturnsCorrectNumber_WithZeros()
        {
            int digit1 = 0, digit2 = 0, digit3 = 1, digit4 = 2;
            
            int result = Program.CombineNumbers(digit1, digit2, digit3, digit4);
            
            Assert.AreEqual(12, result);
        }
    }
}