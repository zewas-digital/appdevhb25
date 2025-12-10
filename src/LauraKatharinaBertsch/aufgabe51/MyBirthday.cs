using System.Globalization;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe51
{
    public class MyBirthday
    {
        public static void Start()
        {
            Console.WriteLine("Wann hast du Geburtstag? Schreibe TT.MM.JJJJ");
            string birthday = Console.ReadLine() ?? string.Empty;
            CultureInfo austria = new CultureInfo("de-AT");
            DateTime day = DateTime.Parse(birthday, austria);
            Console.WriteLine("Dein Geburtstag war an einem " + day.ToString("dddd", austria));
            if (DateTime.IsLeapYear(day.Year))
            {
                Console.WriteLine("Dein Geburtsjahr war ein Schaltjahr");
            }
        }
    }
}