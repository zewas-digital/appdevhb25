using System;
using System.Diagnostics;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe14
{
    class PrintCircle
    {
        public static void Start()
        {
            int radius = 5;
            double dist;

            for (int x = 0; x <= 2 * radius; x++)
            {
                for (int y = 0; y <= 2 * radius; y++)
                {
                    dist = Math.Sqrt((x - radius) * (x - radius) + (y - radius) * (y - radius));

                    if (dist > radius - 0.5 && dist < radius + 0.5)
                        Console.Write("*");

                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int x = 0; x <= 2 * radius; x++)
            {
                for (int y = 0; y <= 2 * radius; y++)
                {
                    dist = Math.Sqrt((x - radius) * (x - radius) + (y - radius) * (y - radius));

                    if (dist >= radius - 0.5 && dist >= radius + 0.5)
                        Console.Write(" ");

                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}