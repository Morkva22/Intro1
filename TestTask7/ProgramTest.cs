using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void GetEvenNumbersInRange_ReturnsCorrectEvenNumbers_ForValidRange()
    {
        int firstNumber = 1;
        int secondNumber = 10;
        var expected = new List<int> { 2, 4, 6, 8, 10 };
        var result = Program.GetEvenNumbersInRange(firstNumber, secondNumber);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void GetEvenNumbersInRange_ReturnsCorrectEvenNumbers_ForReversedRange()
    {
        int firstNumber = 10;
        int secondNumber = 1;
        var expected = new List<int> { 2, 4, 6, 8, 10 };
        var result = Program.GetEvenNumbersInRange(firstNumber, secondNumber);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void GetEvenNumbersInRange_ReturnsEmptyList_ForNoEvenNumbersInRange()
    {
        int firstNumber = 3;
        int secondNumber = 3;
        var expected = new List<int>();
        var result = Program.GetEvenNumbersInRange(firstNumber, secondNumber);
        CollectionAssert.AreEqual(expected, result);
    }
}