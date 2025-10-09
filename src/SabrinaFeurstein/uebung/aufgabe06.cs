using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using Appdevhb25.SabrinaFeurstein.uebung;

namespace Appdevhb25.SabrinaFeurstein.uebung
{
    public class aufgabe06
    {
        public static void PrintRectangle(int zeilen, int spalten)
        {
            for (int y = 0; y < zeilen; y++)
            {
                for (int x = 0; x < spalten; x++)
                {
                    Console.Write('x');
                }
                Console.WriteLine();
            }
        }
    }
}
