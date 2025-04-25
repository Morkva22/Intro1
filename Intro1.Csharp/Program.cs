/*/
Користувач вводить число.
Програма повинна визначити, чи є це число числом Армстронга (число Армстронга — це таке число,
що дорівнює сумі своїх цифр, піднесених до степеня, що дорівнює кількості цих цифр).
Наприклад, число 153 є числом Армстронга, оскільки 1^3 + 5^3 + 3^3 = 153.
/*/

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("input number:");
        int number = int.Parse(Console.ReadLine());

        if (IsArmstrongNumber(number))
        {
            Console.WriteLine($"{number} is armstrong number");
        }
        else
        {
            Console.WriteLine($"{number} isnt armstrong number");
        }
    }

    public static bool IsArmstrongNumber(int number)
    {
        int originalNumber = number;
        int sum = 0;
        int digitsCount = number.ToString().Length;

        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, digitsCount);
            number /= 10;
        }

        return sum == originalNumber;
    }
}