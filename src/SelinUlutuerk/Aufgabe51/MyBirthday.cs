using System;
using System.Dynamic;
using System.Globalization;

namespace Appdevhb25.SelinUlutuerk.Aufgabe51
{
    class MyBirthday
    {
        public static void Start()
        {
            CultureInfo austrian = new CultureInfo("de-AT");

            System.Console.WriteLine("Gib hier deinen Geburtstag ein: (TT.MM.JJJJ)");
            string eingabe = Console.ReadLine();

            if (DateTime.TryParseExact(eingabe, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime geb))
            {
                Console.WriteLine("Du wurdest an einem {0} geboren.", geb.DayOfWeek);

                bool schaltjahr = DateTime.IsLeapYear(geb.Year);
                Console.WriteLine("War dein Geburtsjahr ein Schaltjahr? {0}", schaltjahr ? "Ja": "Nein");
            }
            else
            {
                Console.WriteLine("Ungültiges Datum. Bitte verwende das Format TT.MM.JJJJ.");
            }
        }
    }
}