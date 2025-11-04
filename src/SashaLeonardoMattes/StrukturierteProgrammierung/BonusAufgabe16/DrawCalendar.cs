using System;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

using System.Diagnostics;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe16
{

    public class DrawCalendar
    {

        public static void StartDrawCalendar()
        {
            Console.WriteLine("----------Bonusaufgabe 16---------");

           

            System.Console.WriteLine("Gib ein Datum ein:");
            DateTime inputDate = Helper.checkUserInputDate();
            DateTime firstDay = new DateTime(inputDate.Year, inputDate.Month, 1);
            DateTime lastDay = new DateTime(inputDate.Year, inputDate.Month, DateTime.DaysInMonth(inputDate.Year, inputDate.Month));
            DateTime dayToMark = new DateTime(inputDate.Year, inputDate.Month, inputDate.Day);

            Console.WriteLine("| Mo | Di | Mi | Do | Fr | Sa | So |");

            int firstDayOfWeek = (int)firstDay.DayOfWeek == 0 ? 7 : (int)firstDay.DayOfWeek; //damit sonntag nicht als 0 sondern als 7 gespeichert wird


            for (int i = 0; i < firstDayOfWeek-1; i++)
            {
                Console.Write("|    ");
            }

            for (DateTime currentDay = firstDay; currentDay <= lastDay; currentDay = currentDay.AddDays(1))
            {
                if (currentDay == dayToMark)
                {
                    Console.Write("| " + currentDay.ToString("dd") + "*");
                }
                else
                {
                    Console.Write("| " + currentDay.ToString("dd") + " ");
                }

                if (currentDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    System.Console.WriteLine("|");
                }
            }

            
            int lastDayOfWeek = (int)lastDay.DayOfWeek == 0 ? 7 : (int)lastDay.DayOfWeek; //damit sonntag nicht als 0 sondern als 7 gespeichert wird

            for (int i = 7; i > lastDayOfWeek; i--)
            {
                if (i - 1 <= lastDayOfWeek)
                {
                    System.Console.Write("|    |");
                }
                else
                {
                    System.Console.Write("|    ");
                }
            }
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
