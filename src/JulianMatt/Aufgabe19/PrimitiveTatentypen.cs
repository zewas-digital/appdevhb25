using System;
using System.Runtime.CompilerServices;

namespace Appdevhb25.JulianMatt.Aufgabe19
{
    public class PrimitiveDatentypen
    {
        static long start;
        static long end;
        public static void Start19()
        {
            Input();
            Output();
        }

        public static void Input()
        {
            Console.WriteLine("Geben sie an von wo bis wo die Ganze Zahlen ausgegeben werden sollen");
            Console.WriteLine("von: ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bis: ");
            end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hier sind ihre Zahlen");
        }

        public static void Output()
        {
            for (long i = start + 1; i < end + 1; i++)
            {
                long reapeat = start + i;
                Console.WriteLine("Rechenweg: " + start + " + " + i + " = " + reapeat);
                start = reapeat;
            }
        }


    }
}