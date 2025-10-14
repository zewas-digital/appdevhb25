using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

namespace Appdevhb25.JulianMatt.Bonusaufgabe32
{
    public class Ziffernsumme
    {

        public static void Start32()
        {
            while (true)
            {
                int zahl = GetNumber();
                int summe = BerechneZiffernsumme(zahl);
                Console.WriteLine("Die Ziffernsumme ist: " + summe);
                Console.WriteLine();
            }



        }
        public static int GetNumber()
        {
            bool isInteger;
            int result;
            do
            {
                Console.WriteLine("Gib eine Zahl wie z.b: 563 an und wir berechnen dan für sie 5 + 6 + 3 = 14: ");
                string eingabe = Console.ReadLine();

                isInteger = int.TryParse(eingabe, out result);

            } while (isInteger == false);

            return result;
        }

        public static int BerechneZiffernsumme(int zahl)
        {
            if (zahl < 0)
                zahl = -zahl;
            int summe = 0;

            while (zahl > 0)
            {
                int letzteZiffer = zahl % 10;
                summe += letzteZiffer;
                zahl /= 10;
            }

            return summe;
        }
    }
}