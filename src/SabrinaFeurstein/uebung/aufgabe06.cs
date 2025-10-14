using System;

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