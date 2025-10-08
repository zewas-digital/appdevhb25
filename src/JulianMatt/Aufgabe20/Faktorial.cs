using System;
using System.Runtime.CompilerServices;

namespace Appdevhb25.JulianMatt.Aufgabe20
{
    public class Faktorial
    {
        static long Fakultät;
        static long Calculation = 1;
        public static void Start20()
        {
            Input();
            Output();
        }

        public static void Input()
        {
            Console.WriteLine("Geben sie eine Zahl ein um die Fakultät zu berechnen");
            Fakultät = Convert.ToInt32(Console.ReadLine());
        }

        public static void Output()
        {
            Console.Write(Fakultät +"!:");
            for (long i = Fakultät; i > 1; i--)
            {
                Calculation *= i; 
            }
            Console.WriteLine(Calculation);
        }


    }
}