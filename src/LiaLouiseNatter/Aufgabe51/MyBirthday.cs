using System;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe51
{
    public class MyBirthday
    {
        public static void Start()
        {
            BirthdayChecker();
        }
        
        private static void BirthdayChecker()
        {
            CultureInfo austrian = new CultureInfo("de-AT");
            System.Console.Write("Please enter your Birthday [DD.MM.YYYY]: ");
            string userBirthday = Console.ReadLine();

            if(DateOnly.TryParse(userBirthday, out DateOnly birthday))
            {
                string weekday = birthday.DayOfWeek.ToString();
                System.Console.WriteLine($"{birthday} was a {weekday}.");
                bool leapYear = DateTime.IsLeapYear(birthday.Year);
                

                if (leapYear)
                {
                    System.Console.WriteLine($"{birthday} was a Leap Year.");
                }
                else
                {
                    System.Console.WriteLine($"{birthday} was not a Leap Year.");
                }
            }
        }

     

        


    }
}

