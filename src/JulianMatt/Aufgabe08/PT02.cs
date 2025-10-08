using System;
using System.Runtime.CompilerServices;

namespace Appdevhb25.JulianMatt.Aufgabe08
{
    public class PT02
    {

        public static void Start0801()
        {
            Console.WriteLine("Geben sie die größe des Dreiecks an");
            int seitenlaenge = Convert.ToInt32(Console.ReadLine());
            int e = 1;
            Console.WriteLine("Hier ist ihr Dreieck");
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
        }
    }
}    
