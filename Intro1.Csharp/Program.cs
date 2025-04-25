public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter 1 digit:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter 2 digit:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter 3 digit:");
        int number3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter 4 digit:");
        int number4 = Convert.ToInt32(Console.ReadLine());

        int result = CombineNumbers(number1, number2, number3, number4);
        Console.WriteLine("Result: " + result);
    }

    public static int CombineNumbers(int number1, int number2, int number3, int number4)
    {
        return int.Parse($"{number1}{number2}{number3}{number4}");
    }
}