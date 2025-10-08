using System;
using System.Runtime.CompilerServices;

namespace Appdevhb25.JulianMatt.Aufgabe10
{
    public class PrintTrianglev02
    {

        public static void Start10()
        {
            Console.WriteLine("Geben sie die größe des Dreiecks an");
            int seitenlaenge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hier ist ihr Dreieck");


            for (int i = 2; i <= seitenlaenge; i++)
            {
                for (int j = 0; j <= seitenlaenge - i; j++)
                {
                    Console.Write("-");
                }
                if (i == 2)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write("x");

                    for (int j = 3; j <= 2 * i - 3; j++)
                    {
                        Console.Write("-");
                    }

                    Console.Write("x");

                }
                Console.WriteLine();
            }
            for (int l = 1; l <= seitenlaenge * 2 - 1; l++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
        }
    }
}
