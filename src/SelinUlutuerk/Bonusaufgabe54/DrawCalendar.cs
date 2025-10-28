using System;
using System.Globalization;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe54
{
    class DrawCalendar
    {
        public static void Start()
        {
            CultureInfo austrian = new CultureInfo("de-AT");
            // DateTime moment = DateTime.Now;
            DateTime moment = new DateTime(2024, 04, 27);
            int year = moment.Year;
            int month = moment.Month;

            DateTime firstDay = new DateTime(year, month, 1);
            int daysMonth = DateTime.DaysInMonth(year, month);


            System.Console.WriteLine(moment.ToString("yyyy MMMM"));
            System.Console.WriteLine("| Mo | Di | Mi | Do | Fr | Sa | So |");

            int startDay = ((int)firstDay.DayOfWeek + 6) % 7;

            int currentDay = 1;

            for (int week = 0; week < 6 && currentDay <= daysMonth; week++)
            {
                Console.Write("|");
                for (int day = 0; day < 7; day++)
                {
                    if (week == 0 && day < startDay)
                    {
                        Console.Write("    |");
                    }
                    else if (currentDay <= daysMonth)
                    {
                        if (currentDay == moment.Day)
                        {
                            Console.Write($" {currentDay,2}*|");
                            currentDay++;
                        }
                        else
                        {
                            Console.Write($" {currentDay,2} |");
                            currentDay++;
                        }
                    }
                    else
                    {
                        Console.Write("    |");
                    }
                }
                System.Console.WriteLine();
            }
        }
    }
}