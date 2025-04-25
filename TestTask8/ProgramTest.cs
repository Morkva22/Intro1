using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void IsArmstrongNumber_ReturnsTrue_ForArmstrongNumber()
    {
        int number = 153;
        
        bool result = Program.IsArmstrongNumber(number);
        
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsArmstrongNumber_ReturnsFalse_ForNonArmstrongNumber()
    {
       
        int number = 123;
        
        bool result = Program.IsArmstrongNumber(number);
        
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsArmstrongNumber_ReturnsTrue_ForSingleDigitNumber()
    {
        int number = 5;
        
        bool result = Program.IsArmstrongNumber(number);
        
        Assert.IsTrue(result);
    }
}