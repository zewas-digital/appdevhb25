using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Appdevhb25.SabrinaFeurstein.uebung
{
    public class aufgabe02
    {
        public static void zahl(int zahl)
        {
            for (int i = 0; i <= 10; i++)
            {
                int produkt = i * zahl;
                Console.WriteLine(i + " * " + zahl + " = " + produkt);
            }
        }
    }
}