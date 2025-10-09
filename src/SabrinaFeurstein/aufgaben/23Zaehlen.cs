
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class Zaehlen

    {
        public static void Round(int min, int max)
        {
            double ergebnis = min;

            Console.WriteLine("Math.Round Variante:");
            for (int i = min; i < max; i++)
            {
                ergebnis = ergebnis + 0.1;

                Console.WriteLine($"Result 1 digit = {Math.Round(ergebnis, 1)}");
                Console.WriteLine("Result 2 digit = " + Math.Round(ergebnis, 2));
            }
            Console.WriteLine();
        }

        public static void Format(int min, int max)
        {
            double ergebnis = min;

            Console.WriteLine("String.Format Variante:");
            for (int i = min; i < max; i++)
            {
                ergebnis = ergebnis + 0.1;

                Console.WriteLine($"Result 1 digit = {String.Format("{0:0.0}", ergebnis)}");
                Console.WriteLine("Result 2 digit = " + String.Format("{0:0.00}", ergebnis));
            }
            Console.WriteLine();
        }

        public static void ToString(int min, int max)
        {
            double ergebnis = min;

            Console.WriteLine("ToString Variante:");
            for (double i = min; i < max; i += 0.1)
            {
                ergebnis = ergebnis + 0.1;

                Console.WriteLine($"Result 1 digit = {ergebnis.ToString("F1")}");
                Console.WriteLine($"Result 2 digit = {ergebnis,6:F2}");
            }
        }
    }
}

