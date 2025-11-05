using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe10
{
    class PrintTriangle
    {
        public static void StartPrintTriangle(int length)
        {
            for (int y = 1; y <= length; y++)
            {
                for (int x = 1; x <= length - y; x++)
                {
                    Console.Write(" ");
                }

                for (int z = 1; z <= 2 * y - 1; z++)
                {
                    if (y == 1 || y == length || z == 1 || z == 2 * y - 1)
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