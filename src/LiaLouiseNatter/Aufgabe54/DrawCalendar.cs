using System;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Globalization;


namespace Appdevhb25.LiaLouiseNatter.Aufgabe54
{
    public class DrawCalendar
    {
        public static void Start()
        {
            MonthYearGetter();
        }

        private static void MonthYearGetter()
        {
            CultureInfo austrian = new CultureInfo("de-AT");
            int year = 0;
            int month = 0;
            int day = 0;

            do
            {
                System.Console.Write("Year: ");
            } while (!int.TryParse(Console.ReadLine(), out year));

            do
            {
                System.Console.Write("Month: ");
            } while (!int.TryParse(Console.ReadLine(), out month));
             do
            {
                System.Console.Write("Current Day: ");
            } while (!int.TryParse(Console.ReadLine(), out day));


            string monthname = new DateTime(year, month, 1).ToString("MMMM");
            CalendarDrawer(year, month, day, monthname);
        }
        
        private static void CalendarDrawer(int year, int month, int day, string monthname)
        {
            System.Console.WriteLine($"{year} {monthname}");

            int lastDay = DateTime.DaysInMonth(year, month);
            DateTime firstDay = new DateTime(year, month, 1);
            DateTime last = new DateTime(year, month, lastDay);

            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("| Mo | Di | Mi | Do | Fr | Sa | So |");
            System.Console.WriteLine("------------------------------------");

            int startDay = 0;
            startDay = ((int)firstDay.DayOfWeek + 6) % 7;

            for (int i = 0; i < startDay ; i++)
            {
                System.Console.Write("|    ");
            }
            for (DateTime currentDay = firstDay; currentDay <= last; currentDay = currentDay.AddDays(1))
            {
                string formatedDay = currentDay.ToString("dd");

                if (currentDay.DayOfWeek == DayOfWeek.Monday && currentDay != firstDay)
                {
                    System.Console.Write("|");
                    System.Console.WriteLine();
                }
                System.Console.Write($"| {formatedDay}");
                if (currentDay.Day == day)
                {
                    System.Console.Write("*");
                }
                else
                {
                    System.Console.Write(" ");
                }
            }

            int endDay = ((int)last.DayOfWeek + 6) % 7;
            if (endDay != 6)
            {
                for (int i = endDay + 1; i <= 6; i++)
                {
                    System.Console.Write("|    ");
                }
            }
            System.Console.WriteLine("|");
            System.Console.WriteLine("------------------------------------");

        }

    }
}

