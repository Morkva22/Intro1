using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;


[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void GetSeason_ReturnsWinter_ForDecember()
    {
        DateTime date = new DateTime(2021, 12, 22);
        
        string result = Program.GetSeason(date);
        
        Assert.AreEqual("Winter", result);
    }

    [TestMethod]
    public void GetSeason_ReturnsSpring_ForMarch()
    {
        DateTime date = new DateTime(2021, 3, 15);
        
        string result = Program.GetSeason(date);
        
        Assert.AreEqual("Spring", result);
    }

    [TestMethod]
    public void GetSeason_ReturnsSummer_ForJuly()
    {
        DateTime date = new DateTime(2021, 7, 10);
        
        string result = Program.GetSeason(date);
        
        Assert.AreEqual("Summer", result);
    }

    [TestMethod]
    public void GetSeason_ReturnsAutumn_ForOctober()
    {
        DateTime date = new DateTime(2021, 10, 5);
        
        string result = Program.GetSeason(date);
        
        Assert.AreEqual("Autumn", result);
    }

    [TestMethod]
    public void DayOfWeek_ReturnsCorrectDay()
    {
        DateTime date = new DateTime(2021, 12, 22);
        
        string dayOfWeek = date.ToString("dddd", CultureInfo.InvariantCulture);
        
        Assert.AreEqual("Wednesday", dayOfWeek);
    }
}