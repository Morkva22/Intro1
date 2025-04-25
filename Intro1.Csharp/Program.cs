public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input first number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second number:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        var evenNumbers = GetEvenNumbersInRange(firstNumber, secondNumber);
        Console.WriteLine($"Even numbers between {firstNumber} and {secondNumber}:");
        Console.WriteLine(string.Join(" ", evenNumbers));
    }

    public static List<int> GetEvenNumbersInRange(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }

        var evenNumbers = new List<int>();
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers.Add(i);
            }
        }
        return evenNumbers;
    }
}