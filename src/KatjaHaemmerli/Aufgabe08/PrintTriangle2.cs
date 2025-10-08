using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe08
{
    public class PrintTriangle2
    {
        public static void Triangle2(int size)
        {
            // size ist grösse des Dreiecks und grösse der iteration

            // erstes Dreieck
            for (int y = 0; y < size; y++) // Schleife geht Zeile für Zeile durch 
            {
                for (int x = size; x > y; x--)
                { 
                    Console.Write("@");
                }
                Console.WriteLine();
            }

            Console.WriteLine(); // Abstand zwischen den Dreiecken

            // zweites Dreieck
            for (int y = 0; y < size; y++)
                {
                    for (int x = 0; x < size; x++)
                    {
                        if (x < y)
                        {
                            Console.Write(" ");
                        }

                        else
                        {
                            Console.Write("o");
                        }

                    }
                    Console.WriteLine();

                }
            
            Console.WriteLine(); // Abstand zwischen den Dreiecken

            // drittes Dreieck
            for (int y = 0; y < size; y++) // Schleife geht Zeile für Zeile durch 
            {
                for (int x = size; x > 0; x--)
                {
                    if (x - 1 > y) // x - 1 weil max 4 Leerzeichen
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("A");
                    }
                }
                Console.WriteLine();           

            }
                
            Console.WriteLine(); // Abstand zwischen den Dreiecken

            // viertes Dreieck
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if (y < x)
                    {
                        Console.Write(" ");
                    }

                    else
                    {
                        Console.Write("x");
                    }

                }
                Console.WriteLine();

            }

        }
    }
}