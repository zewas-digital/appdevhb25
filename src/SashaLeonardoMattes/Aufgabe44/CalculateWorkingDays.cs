using System;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe44
{

    public class CalculateWorkingDays
    {

        public static void StartCalculateWorkingDays()
        {
            Console.WriteLine("----------Aufgabe 44----------");



            System.Console.WriteLine("Gib Monat und Jahr ein (Format MM.yyyy) für das du die Arbeitstage wissen willst:");
            DateTime date = checkInput();
            System.Console.WriteLine("Arbeitstage: " + getWorkingDays(date.Year, date.Month));
            
        }

        public static int getWorkingDays(int year, int month)
        {
            DateTime firstDay = new DateTime(year, month, 1);
            DateTime lastDay = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            int workingDays = lastDay.Day;

            for (DateTime currentDay = lastDay; currentDay > firstDay; currentDay = currentDay.AddDays(-1))
            {
                if (currentDay.DayOfWeek == DayOfWeek.Sunday || currentDay.DayOfWeek == DayOfWeek.Saturday)
                {
                    workingDays--;
                }
            }

            return workingDays;
        }
        
        public static DateTime checkInput()
        {
            bool checkInput;
            DateTime result;
            string format = "MM.yyyy";
            do
            {
                checkInput = DateTime.TryParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture, DateTimeStyles.None, out result);

                if (checkInput == false)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte benutze das Format MM.yyyy");
                }
            } while (checkInput == false);

            return result;
        }

    

    }
}
