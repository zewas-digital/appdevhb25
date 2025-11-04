using System;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe42
{

    public class MyBirthday
    {

        public static void StartMyBirthday()
        {
            Console.WriteLine("----------Aufgabe 42----------");

            DateTime birthday;

            Console.WriteLine("Gib dein Geburtsdatum ein");
            birthday = Helper.checkUserInputDate();

            System.Console.WriteLine("Wochentag: " + birthday.DayOfWeek);
            System.Console.WriteLine("Schaltjahr: " + (DateTime.IsLeapYear(birthday.Year)? "Ja" : "Nein"));
        }

    

    }
}
