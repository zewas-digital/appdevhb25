using System;

namespace Appdevhb25.NoahHois.Aufgabe14
{
    public class PrintCricle
    {
        public static void Aufgabe14(int radius)
        {
            for (int y = -radius; y <= radius; y++)
            {
                for (int x = -radius; x <= radius; x++)
                {
                    double c = Math.Sqrt(x * x + y * y);
                    if ((radius >= c) && (c > (radius - 2)))
                    {
                        Console.Write("*");
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