using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class DateTimeUebung
    {
        public static void Start()
        {
            DateTime date = new DateTime();
             DateTime date2 = new DateTime(2024, 10, 24);
            DateTime now = DateTime.Now;

            Console.WriteLine(date.ToString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(date2.ToString("dddd, dd. MMMM yyyy"));
        }
    }
}