using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class MyBirthday
    {
        public static void Start()
        {
            DateTime birthday = new DateTime();
            Console.Write("Geburtstag eingeben: ");
            string birthdayAsString = Console.ReadLine()!;

            do
            {
                if (!DateTime.TryParse(birthdayAsString, out birthday))
                {
                    Console.WriteLine("Falsches Format! Bitte erneut eingeben: ");
                    birthdayAsString = Console.ReadLine()!;
                }         
            } while (!DateTime.TryParse(birthdayAsString, out birthday));
            

            int birthYear = birthday.Year;

            Console.WriteLine("Wochentag: " + birthday.ToString("dddd"));

            if (DateTime.IsLeapYear(birthYear))
                Console.WriteLine("Das Geburtsjahr war ein Schaltjahr.");
            else
                Console.WriteLine("Das Geburtsjahr war kein Schaltjahr.");
        }
    }
}