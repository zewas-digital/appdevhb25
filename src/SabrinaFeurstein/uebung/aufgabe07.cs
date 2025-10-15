using System;

namespace Appdevhb25.SabrinaFeurstein.uebung
{
    public class aufgabe07
    {
        public static void PrintTriangle(int size)
        {
            for (int y = 0; y < size; y++)
            {
                for (int x = size - y; x > 0; x--)
                {
                    Console.Write('x');
                }
                Console.WriteLine();
            }
        }
    }
}