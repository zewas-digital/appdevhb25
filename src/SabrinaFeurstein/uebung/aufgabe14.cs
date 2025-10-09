using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using Appdevhb25.SabrinaFeurstein.uebung;

namespace Appdevhb25.SabrinaFeurstein.uebung
{
    public class aufgabe14
    {
        public static void CircleFull(int radius)
        {
            for (int y = -radius; y < radius; y++)
            {
                for (int x = -radius; x < radius; x++)
                {
                    if (x * x + y * y < radius * radius)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
        public static void CircleEmpty(int radius)
        {
            for (int y = -radius; y <= radius; y++)
            {
                for (int x = -radius; x <= radius; x++)
                {
                    double distanz = Math.Sqrt(x * x + y * y);
                    if (Math.Abs(distanz - radius) < 0.5)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}