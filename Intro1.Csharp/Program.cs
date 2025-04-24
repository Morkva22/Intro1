/*/
Користувач вводить із клавіатури два числа.
 Перше число — це значення, друге число відсоток, який необхідно порахувати.
 Наприклад, ми ввели з клавіатури 90 і 10.
Потрібно вивести на екран 10 відсотків від 90. Результат: 9.
/*/
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter number:");
        double number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("enter percent:");
        double percent = Convert.ToDouble(Console.ReadLine());

        double result = CalculatePercentage(number, percent);

        Console.WriteLine($"{percent} % from {number} = {result}");
    }

    public static double CalculatePercentage(double number, double percent)
    {
        return (number * percent) / 100;
    }
}