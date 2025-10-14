using System;

namespace Appdevhb25.SabrinaFeurstein.uebung
{
    public class aufgabe10
    {
        public static void PrintTriangle(int length)
        {
            for (int y = 0; y < length; y++)
            {
                for (int x = length; x > y; x--)
                {
                    Console.Write(' ');
                }
                Console.Write('x');
                if (y > 0)
                {
                    for (int x = 0; x < y * 2 - 1; x++)
                    {
                        Console.Write(' ');
                    }
                    Console.Write('x');
                }
                Console.WriteLine();
            }
            for (int x = 0; x < length * 2 + 1; x++)
            {
                Console.Write('x');
            }
        }
    }
}