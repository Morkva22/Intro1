/*/
Користувач вводить із клавіатури дату.
Додаток має відобразити назву сезону і дня тижня.
Наприклад, якщо введено 22.12.2021, додаток має відобразити Winter Wednesday.
/*/

using System.Globalization;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input date (dd.MM.yyyy):");
        string input = Console.ReadLine();
        DateTime date;
        if (DateTime.TryParse(input, out date))
        {
            string season = GetSeason(date);
            string dayOfWeek = date.ToString("dddd", CultureInfo.InvariantCulture);
            Console.WriteLine($"{season} {dayOfWeek}");
        }
        else
        {
            Console.WriteLine("Invalid date");
        }
    }

    public static string GetSeason(DateTime date)
    {
        if (date.Month == 12 || date.Month == 1 || date.Month == 2)
        {
            return "Winter";
        }
        else if (date.Month >= 3 && date.Month <= 5)
        {
            return "Spring";
        }
        else if (date.Month >= 6 && date.Month <= 8)
        {
            return "Summer";
        }
        else
        {
            return "Autumn";
        }
    }
}