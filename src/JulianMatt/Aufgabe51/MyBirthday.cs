using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe51
{
    public class MyBirthday
    {

        public static void Start51()
        {
            DateTime date = InputDate();
            DateChecker(date);
        }

        public static DateTime InputDate()
        {
            Console.WriteLine("Bitte gib dein Geburtsdatum ein (z.B. 21.10.2005): ");
            string text = Console.ReadLine();
            DateTime geburtstag = Convert.ToDateTime(text);

            return geburtstag;
        }

        public static void DateChecker(DateTime date)
        {
            CultureInfo austrian = new CultureInfo("de-AT");
            Console.WriteLine($"Du bist an einem {date.ToString("dddd", austrian)} geboren.");
        }
    }
}