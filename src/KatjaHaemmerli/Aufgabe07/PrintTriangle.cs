using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe07
{
    public class PrintTriangle
    {
        public static void Triangle(int size)
        {
            // size ist grösse des Dreiecks und grösse der iteration

            for (int y = 0; y < size; y++) // Schleife geht Zeile für Zeile durch (5 Zeilen)
            {
                for (int x = size; x > y; x--) 
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

        }

    }
}
        
