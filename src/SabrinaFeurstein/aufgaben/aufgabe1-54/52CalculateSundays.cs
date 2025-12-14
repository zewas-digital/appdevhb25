using System;
using System.Data.Common;
using Microsoft.VisualBasic;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class CalculateSundays
    {
        public static void OhneZeitspanne()
        {
            DateTime now = DateTime.Now;
            DateTime[] sunday = new DateTime[3];
            sunday[0] = now;

            for (int i = 0; i < sunday.Length; i++)
            {
                if (i != 0)
                {
                    sunday[i] = sunday[i - 1];
                    sunday[i] = sunday[i].AddDays(1);
                }

                while (sunday[i].DayOfWeek != DayOfWeek.Sunday)
                {
                    sunday[i] = sunday[i].AddDays(1);
                }
            }

            Console.WriteLine("Heutiges Datum: " + now.ToString("dd. MM. yyyy"));
            Console.WriteLine("Datum von nächstem Sonntag: " + sunday[0].ToString("dd/MM/yy"));
            Console.WriteLine("Datum von übernächstem Sonntag: " + sunday[1].ToString("ddd, d. MMM yyyy"));
            Console.WriteLine("Datum von überübernächstem Sonntag: " + sunday[2].ToString("dddd, dd. MMMM yyyy"));
        }

        public static void MitZeitspanne()
        {
            DateTime now = DateTime.Now;
            DateTime[] sunday = new DateTime[3];
            sunday[0] = now;

            TimeSpan ts = new TimeSpan(24, 0, 0);

            for (int i = 0; i < sunday.Length; i++)
            {
                if (i != 0)
                {
                    sunday[i] = sunday[i - 1];
                    sunday[i] = sunday[i].Add(ts);
                }

                while (sunday[i].DayOfWeek != DayOfWeek.Sunday)
                {
                    sunday[i] = sunday[i].Add(ts);
                }
            }

            Console.WriteLine("Heutiges Datum: " + now.ToString("dd. MM. yyyy"));
            Console.WriteLine("Datum von nächstem Sonntag: " + sunday[0].ToString("dd/MM/yy"));
            Console.WriteLine("Datum von übernächstem Sonntag: " + sunday[1].ToString("ddd, d. MMM yyyy"));
            Console.WriteLine("Datum von überübernächstem Sonntag: " + sunday[2].ToString("dddd, dd. MMMM yyyy"));
        }
    }
}