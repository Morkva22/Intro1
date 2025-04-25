/*/
Користувач вводить число.
Програма повинна визначити, чи є це число досконалим.
Досконале число — це число,
яке дорівнює сумі всіх своїх дільників, крім самого себе (наприклад, 28 = 1 + 2 + 4 + 7 + 14).
/*/

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPerfectNumber(number))
        {
            Console.WriteLine($"{number} is a perfect number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect number.");
        }
    }

    public static bool IsPerfectNumber(int number)
    {
        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        return sum == number;
    }
}