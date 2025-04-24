using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace DomainTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void GetFizzBuzzOutput_ReturnsFizz_WhenDivisibleBy3()
        {
            int input = 9;
            
            string result = Program.GetFizzBuzzOutput(input);

            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void GetFizzBuzzOutput_ReturnsBuzz_WhenDivisibleBy5()
        {
            int input = 10;
            
            string result = Program.GetFizzBuzzOutput(input);
            
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void GetFizzBuzzOutput_ReturnsFizzBuzz_WhenDivisibleBy3And5()
        {
            int input = 15;
            
            string result = Program.GetFizzBuzzOutput(input);
            
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void GetFizzBuzzOutput_ReturnsNumber_WhenNotDivisibleBy3Or5()
        {
            int input = 7;
            
            string result = Program.GetFizzBuzzOutput(input);
            
            Assert.AreEqual("7", result);
        }

        [TestMethod]
        public void GetFizzBuzzOutput_ReturnsNumber_WhenOutOfRange()
        {
            int input = 101;
            
            string result = Program.GetFizzBuzzOutput(input);
            
            Assert.AreEqual("101", result);
        }
    }
}