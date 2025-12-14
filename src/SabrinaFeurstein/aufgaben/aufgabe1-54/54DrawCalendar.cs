using System;
using System.Formats.Asn1;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class DrawCalendar
    {
        public static void Start()
        {
            DateTime today = DateTime.Now;
            int month = today.Month;
            int year = today.Year;
            DateTime calendar = new DateTime(year, month, 1);
            DateTime weekday = new DateTime();
            int dayOfWeek;
            Console.WriteLine(today.ToString("yyyy MMMM"));

            for (int i = 0; i < 7; i++)
            {
                Console.Write(@$"| {weekday.ToString("ddd")} ");
                weekday = weekday.AddDays(1);
            }
            Console.WriteLine("|");

            while (calendar.Month == month)
            {
                dayOfWeek = 1;
                for (int i = 0; i < 7; i++)
                {
                    if (dayOfWeek == 7)
                        dayOfWeek = 0;

                    if ((int)calendar.DayOfWeek == dayOfWeek && calendar.Month == month)
                    {
                        if (calendar.Day < 10 && calendar.Date == today.Date)
                            Console.Write(@$"| {calendar.ToString(" d")}*");
                        else if (calendar.Date == today.Date)
                            Console.Write(@$"| {calendar.ToString("dd")}*");
                        else if (calendar.Day < 10)
                            Console.Write(@$"| {calendar.ToString(" d")} ");
                        else
                            Console.Write(@$"| {calendar.ToString("dd")} ");
                        calendar = calendar.AddDays(1);
                    }
                    else
                        Console.Write(@$"|    ");

                    dayOfWeek++;
                }
                Console.WriteLine("|");
            }
        }
    }
}