using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe51
{
    public  class MyBirthday
    {
        public static void Birthday()
        {
            //Erstelle ein Programm, das den Anwender nach seinem Geburtstag fragt und verarbeitet. 
            // Als Ergebnis soll das Programm zurückgeben, an welchem Wochentag der Geburtstag des Anwenders war.

            Console.WriteLine("Pls enter your birthday");
            string input = Console.ReadLine();
            DateTime birthday = DateTime.Parse(input);
            Console.WriteLine("Your birthday is: " + birthday.ToLongDateString());
            Console.WriteLine("Your birthday is: " + birthday.DayOfWeek);
            
            // prüfe ob der Geburtstag an einem Schaltjahr war
                if (DateTime.IsLeapYear(birthday.Year))
                {
                    System.Console.WriteLine("Your Birthday is on a leap year.");
                }
                else
                System.Console.WriteLine("Your Birthday is not on a leap year.");
        }
    }
}