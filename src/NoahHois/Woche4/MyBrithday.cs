using System.Security.Cryptography;

namespace Appdevhb25.NoahHois.Aufgabe37
{
    public class MyBirthday
    {
        public static void Start()
        {
            Console.WriteLine("Sag mir bitte das Jahr indem du Geburtstag hast:");
            string inputYear = Console.ReadLine();
            int integerInputYear = Convert.ToInt32(inputYear);

            Console.WriteLine("Sag mir bitte den Monat indem du Geburtstag hast:");
            string inputMonth = Console.ReadLine();
            int integerInputMonth = Convert.ToInt32(inputMonth);

            Console.WriteLine("Sag mir bitte den Tag andem du Geburtstag hast:");
            string inputDay = Console.ReadLine();
            int integerInputDay = Convert.ToInt32(inputDay);

            DateTime date = new DateTime(integerInputYear, integerInputMonth, integerInputDay);
            Console.WriteLine("Du hast am {0} {1} {2}", date.Year, date.Month, date.DayOfWeek);

            Console.WriteLine(IsLeapYear(date));
        }
        public static bool IsLeapYear(DateTime date)
        {
            
            if (DateTime.IsLeapYear(date.Year) == true)
            {
                Console.WriteLine("Du hast in einem Schaltjahr Geburtstag.");
                return true;
            }
            return false;
        }
    }
}