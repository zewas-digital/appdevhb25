using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using Appdevhb25.SabrinaFeurstein.uebung;

namespace Appdevhb25.SabrinaFeurstein.uebung
{
    public class aufgabe03
    {
        public static void intervall(int start, int ende)
        {
            int summe = 0;

            for (int i = start; i <= ende; i++)
            {
                summe = i + summe;
            }

            Console.WriteLine("Intervallstart: " + start);
            Console.WriteLine("Intervallende: " + ende);
            Console.WriteLine("Summe über Intervall: " + summe);
        }
    }
}