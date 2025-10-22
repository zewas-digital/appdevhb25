using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe52
{
    public class CalculatSundays
    {

        public static void Start52()
        {
            CalcSundays();
        }

        public static void CalcSundays()
        {
            
            DateTime currentDay = new DateTime(2025, 10, 21);
            TimeSpan span = new TimeSpan(5, 0, 0, 0);

            for (int i = 0; i < 3; i++)
            {
                DateTime newDate = currentDay.Add(span);
                System.Console.WriteLine(newDate.ToString());
                currentDay = newDate;
                span = new TimeSpan(7, 0, 0, 0);
            }
           
            
            
        }


    }
}