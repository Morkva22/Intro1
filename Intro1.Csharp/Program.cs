using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input temperature in Fahrenheit or Celsius:");
        double temperature = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input 1 for Fahrenheit to Celsius or 2 for Celsius to Fahrenheit:");
        int choice = Convert.ToInt32(Console.ReadLine());

        string result = ConvertTemperature(temperature, choice);
        Console.WriteLine(result);
    }

    public static string ConvertTemperature(double temperature, int choice)
    {
        if (choice == 1)
        {
            double celsius = (temperature - 32) * 5 / 9;
            return $"Temperature in Celsius: {celsius}";
        }
        else if (choice == 2)
        {
            double fahrenheit = (temperature * 9 / 5) + 32;
            return $"Temperature in Fahrenheit: {fahrenheit}";
        }
        else
        {
            return "Invalid choice";
        }
    }
}