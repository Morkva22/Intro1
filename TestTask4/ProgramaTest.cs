using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainTests
{
    [TestClass]
    public class ProgramaTests
    {
        [TestMethod]
        public void SwapDigits_SwapsCorrectly()
        {
            int number = 723895;
            int firstDigit = 1;
            int secondDigit = 6;
            
            string result = Programa.SwapDigits(number, firstDigit, secondDigit);
            
            Assert.AreEqual("523897", result);
        }

        [TestMethod]
        public void SwapDigits_ReturnsSameNumber_WhenSwappingSamePosition()
        {
            int number = 123456;
            int firstDigit = 3;
            int secondDigit = 3;
            
            string result = Programa.SwapDigits(number, firstDigit, secondDigit);
            
            Assert.AreEqual("123456", result);
        }
    }
}