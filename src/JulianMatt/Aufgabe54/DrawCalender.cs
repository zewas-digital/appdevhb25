using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe54
{
    public class DrawCalender
    {

        public static void Start54()
        {
            CalcCalender();
        }

        public static void CalcCalender()
        {
            DateTime currentDay = new DateTime(2025, 10, 21);
            int daysInMonth = System.DateTime.DaysInMonth(currentDay.Year, currentDay.Month);
            System.Console.WriteLine(" | Mo  | Di  | Mi  | Do  | Fr  | Sa  | So  |");
            int dayoftheweekinsp = (int)currentDay.DayOfWeek;

            for (int i = 0; i < dayoftheweekinsp; i++)
            {
                System.Console.Write(" |    ");
            }

            for (int i = 0; i < daysInMonth; i++)
            {
                DateTime date2 = currentDay.AddDays(-currentDay.Day + 1 + i);
                DayOfWeek dayOfWeek = date2.DayOfWeek;
                if (date2 == currentDay)
                {
                    System.Console.Write(" | {0,2}*", date2.Day);
                    if (date2.DayOfWeek == DayOfWeek.Sunday)
                    {
                        System.Console.WriteLine(" | ");
                    }
                }
                else
                {
                    System.Console.Write(" | {0,2} ", date2.Day);
                    if (date2.DayOfWeek == DayOfWeek.Sunday)
                    {
                        System.Console.WriteLine(" | ");
                    }
                }


            }
            DateTime lastDay = new DateTime(currentDay.Year, currentDay.Month, daysInMonth);
            int rest = (int)lastDay.DayOfWeek;

            if (rest != 0)
            {
                for (int i = rest; i < 7; i++)
                {
                    System.Console.Write(" |    ");
                }

            }
            System.Console.WriteLine(" |");


        }


    }
}