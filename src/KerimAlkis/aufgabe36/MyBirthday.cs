using System.Globalization;


namespace Appdevhb25.KerimAlkis.Aufgabe36
{
    public class MyBirthday
    {
        public static void Start()
        {
            CultureInfo austrian = new CultureInfo("de-AT");
            DateTime geburtsDatum;
            do
            {
                System.Console.WriteLine("GeburtsDatum");
                Console.Write("Gib dein Geburtsdatum ein (TT.MM.JJJJ): ");
                string input = Console.ReadLine();
                try
                {
                    geburtsDatum = DateTime.ParseExact(input, "dd.MM.yyyy", austrian);
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Try again");
                }

            } while (true);

            Console.WriteLine("Der Wochentag deines Geburtstages ist: " + geburtsDatum.DayOfWeek);
            if (DateTime.IsLeapYear(geburtsDatum.Year)) { Console.WriteLine("Dein Geburtsjahr ist ein Schaltjahr"); }
            else{Console.WriteLine("Dein Geburtsjahr ist kein Schaltjahr");}


            
        }
    }
}