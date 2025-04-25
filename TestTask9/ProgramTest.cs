using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void IsPerfectNumber_ReturnsTrue_ForPerfectNumber()
    {
        int number = 28;
        bool result = Program.IsPerfectNumber(number);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsPerfectNumber_ReturnsFalse_ForNonPerfectNumber()
    {
       
        int number = 10;
        bool result = Program.IsPerfectNumber(number);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsPerfectNumber_ReturnsFalse_ForNegativeNumber()
    {
      
        int number = -6;
        bool result = Program.IsPerfectNumber(number);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsPerfectNumber_ReturnsFalse_ForZero()
    {
        int number = 0;
        bool result = Program.IsPerfectNumber(number);
        Assert.IsFalse(result);
    }
}