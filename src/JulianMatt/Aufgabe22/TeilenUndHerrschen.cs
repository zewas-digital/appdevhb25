using System;
using System.Runtime.CompilerServices;

namespace Appdevhb25.JulianMatt.Aufgabe22
{
    public class TeilenUndHerrschen
    {
        static int start = 0;
        static int end = 20;
        public static void start22()
        {
            Program();
        }


        public static void Program()
        {
            for (int i = start; i <= end; i++)
            {
                int soluion = i / 5;
                Console.WriteLine(i + " / 5 =   " + soluion);
                double soluion2 = i / 5.0;
                Console.WriteLine(i + " / 5.0 = " + soluion2);
            }
        }


    }
}
