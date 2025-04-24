namespace Domain;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Write a number between 1 and 100");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(GetFizzBuzzOutput(number));
    }
    public static string GetFizzBuzzOutput(int number)
    {
        if (number < 1 || number > 100)
        {
            return number.ToString();
        }

        if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        }

        if (number % 3 == 0)
        {
            return "Fizz";
        }

        if (number % 5 == 0)
        {
            return "Buzz";
        }

        return number.ToString();
    }
}