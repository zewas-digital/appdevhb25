using System;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe52
{
    public class CalculateSundays
    {
        public static void Start()
        {
            SundayCalc();
        }
        
        private static void SundayCalc()
        {
            CultureInfo austrian = new CultureInfo("de-AT");
            DateTime today = DateTime.Today;

            int daysTilSunday = 0;
            if (today.DayOfWeek == DayOfWeek.Sunday)
            {
                daysTilSunday = 7;
            }
            else
            {
                daysTilSunday = DayOfWeek.Sunday - today.DayOfWeek;
            }

            DateTime week1 = today.AddDays(daysTilSunday);
            DateTime week2 = today.AddDays(daysTilSunday + 7);
            DateTime week3 = today.AddDays(daysTilSunday + 14);

            System.Console.WriteLine(week1.ToString("F", austrian));
            System.Console.WriteLine(week2.ToString("d", austrian));
            System.Console.WriteLine(week3.ToString("f", austrian));


            
        }

     

        


    }
}

