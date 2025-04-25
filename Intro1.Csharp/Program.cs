public class Programa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a six-symbol number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 100000 && number <= 999999)
        {
            Console.WriteLine("Enter the first symbol to swap:");
            int firstDigit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second symbol to swap:");
            int secondDigit = Convert.ToInt32(Console.ReadLine());

            string result = SwapDigits(number, firstDigit, secondDigit);
            Console.WriteLine($"The new number is: {result}");
        }
        else
        {
            Console.WriteLine("Error: The number is not six digits.");
        }
    }
    public static string SwapDigits(int number, int firstDigit, int secondDigit)
    {
        string numberString = number.ToString();
        char[] numberArray = numberString.ToCharArray();

        char temp = numberArray[firstDigit - 1];
        numberArray[firstDigit - 1] = numberArray[secondDigit - 1];
        numberArray[secondDigit - 1] = temp;

        return new string(numberArray);
    }
}