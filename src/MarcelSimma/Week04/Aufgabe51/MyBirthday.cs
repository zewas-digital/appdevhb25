using System.Globalization;

namespace Appdevhb25.MarcelSimma
{
    public class MyBirthday
    {
        public static void Start()
        {

            string? input = Console.ReadLine();

            DateTime inputDate;

            DateTime.TryParse(input, new CultureInfo("de-AT"), out inputDate);
            // Wie wird das Datum 05.03.01 interpretiert?

            DateTime result = DateTime.ParseExact(input, "dd.MM.yyyy", new CultureInfo("de-AT"));

            DateTime myBirthday = new DateTime(2001, 05, 03);

            Console.WriteLine("My birthday is on: " + result.ToString("dddd, dd.MM.yyyy"));

            Console.WriteLine(DateTime.IsLeapYear(result.Year) ? "I was born in a leap year." : "I was not born in a leap year.");
        }
    }
}