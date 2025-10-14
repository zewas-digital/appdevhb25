using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Appdevhb25.JulianMatt.Aufgabe23
{
    public class Von0Bis100
    {
        static int from;
        static int to;

        public static void Program()
        {
            Start23();
            Start2301();
        }
        public static void Start23()
        {
            NumberRanege();
            Output();

        }

        static void NumberRanege()
        {
            while (true)
            {
                Console.WriteLine("Gebens sie die Zahlen an von wo bis wo sie die Zahlen ausgegeben haben wollen z.B 0-100");
                Console.Write("Von: ");
                from = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bis: ");
                to = Convert.ToInt32(Console.ReadLine());
                if (from > to)
                {
                    Console.WriteLine("Die erste Zahl muss kleiner als die zweite Zahl sein. versuchen sie es erneut.");
                }
                else
                {
                    break;
                }
            }
        }
        static void Output()
        {
            for (double i = from; i <= to; i += 0.1)
            {
                Console.WriteLine(Math.Round(i, 1));
            }
        }


        public static void Start2301()
        {
            Beginning();
            Process();
        }

        public static void Beginning()
        {
            Console.WriteLine("Lösung 2 von 0 bis 100");
            Console.WriteLine("Nun werden ihnen alle Zahlen zwischen 0 und 100 nur mit der ersten Kommerstelle angezeigt.");
        }

        public static void Process()
        {
            double fr = 0.0;
            int t = 100;

            while (fr <= t)
            {
                Console.WriteLine(Math.Round(fr, 1));
                fr += 0.1;
            }
        }

    }
}

