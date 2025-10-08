using System;
using System.Runtime.CompilerServices;

namespace Appdevhb25.JulianMatt.Aufgabe08
{
    public class PrintTriangle02
    {

        public static void Start08()
        {
            Console.WriteLine("Geben sie die größe des Dreiecks an");
            int seitenlaenge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hier ist ihr Dreieck");

            for (int g = 0; g < seitenlaenge; g++)
            {

                for (int x = seitenlaenge; x > g; x--)
                {
                    Console.Write("x");
                }
                Console.WriteLine(" ");

            }

            Console.WriteLine();

            for (int y = 0; y < seitenlaenge; y++)
            {
                for (int x = 0; x < seitenlaenge; x++)
                {
                    if (x < y)
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

            Console.WriteLine();

            for (int r = 0; r < seitenlaenge; r++)
            {
                for (int i = 0; i < seitenlaenge -1 - r; i++)
                {
                    Console.Write(" ");
                }
                for (int f = seitenlaenge + 1; f > seitenlaenge - r; f--)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }   
            
            for (int f = 0; f <= seitenlaenge; f++)
            {
                for (int x = 0; x < seitenlaenge; x++)
                {
                    if (x < f)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

       
       
       
        }


    }
}