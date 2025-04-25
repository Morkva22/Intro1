using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ProgramTest
{
    [TestMethod]
    public void ConvertTemperature_ReturnsCelsius_ForFahrenheitInput()
    {
        double temperature = 100; 
        int choice = 1;

        string result = Program.ConvertTemperature(temperature, choice);

        Assert.AreEqual("Temperature in Celsius: 37.77777777777778", result);
    }

    [TestMethod]
    public void ConvertTemperature_ReturnsFahrenheit_ForCelsiusInput()
    {
        double temperature = 0;
        int choice = 2;

        string result = Program.ConvertTemperature(temperature, choice);

        Assert.AreEqual("Temperature in Fahrenheit: 32", result);
    }

    [TestMethod]
    public void ConvertTemperature_ReturnsInvalidChoice_ForInvalidInput()
    {
        double temperature = 0;
        int choice = 3;

        string result = Program.ConvertTemperature(temperature, choice);

        Assert.AreEqual("Invalid choice", result);
    }
}