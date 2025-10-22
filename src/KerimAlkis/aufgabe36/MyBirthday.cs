using System.Globalization;

namespace Appdevhb25.KerimAlkis.Aufgabe36
{
    public class MyBirthday
    {
        public static void Start()
        {
            CultureInfo austrian = new CultureInfo("de-AT");
            DateOnly geburtsDatum;
            do
            {
                Console.Clear();
                System.Console.WriteLine("Wann ist dein Geburtstag? - \"TT.MM.JJJJ\" <-- in diesem Format");

                if (DateOnly.TryParse(Console.ReadLine(), out DateOnly input))
                {
                    geburtsDatum = input;
                    break;
                }
                else { System.Console.WriteLine("Try again"); Thread.Sleep(1000); }

            } while (true);

            Console.WriteLine("Der Wochentag deines Geburtstages ist: "+ geburtsDatum.DayOfWeek);


            
        }
    }
}