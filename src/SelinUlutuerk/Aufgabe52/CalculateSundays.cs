using System;
using System.Globalization;

namespace Appdevhb25.SelinUlutuerk.Aufgabe52
{
    class CalculateSundays
    {
        public static void Start()
        {
            CultureInfo austrian = new CultureInfo("de-AT");
            DateTimeFormatInfo dtfi = austrian.DateTimeFormat;

            DateTime moment = DateTime.Today;
            Console.WriteLine(moment.ToString("m"));

            DateTime sun1 = moment.AddDays(6);
            System.Console.WriteLine(sun1.ToString("g"));

            DateTime sun2 = sun1.AddDays(7);
            System.Console.WriteLine(sun2.ToString("D"));

            DateTime sun3 = sun2.AddDays(7);
            System.Console.WriteLine(sun3.ToString("d"));
        }
    }
}
