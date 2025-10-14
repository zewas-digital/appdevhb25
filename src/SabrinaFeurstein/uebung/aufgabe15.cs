using System;

namespace Appdevhb25.SabrinaFeurstein.uebung
{
    public class aufgabe15
    {
        public static void PrintChristmasTree(int size)
        {
            for (int y = 0; y < size; y++)
            {
                for (int x = size; x > y; x--)
                {
                    Console.Write(' ');
                }
                for (int x = 0; x <= y * 2; x++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            for (int x = 0; x < size; x++)
            {
                Console.Write(" 0");
            }
            Console.WriteLine();
            if (size % 2 == 1)
            {
                for (int y = 0; y < 2; y++)
                {
                    for (int x = 0; x < size / 1.3; x++)
                    {
                        Console.Write(' ');
                    }
                    for (int x = 0; x < size / 2 + 1; x++)
                    {
                        Console.Write('+');
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int y = 0; y < 2; y++)
                {
                    for (int x = 0; x < size / 1.3; x++)
                    {
                        Console.Write(' ');
                    }
                    for (int x = 0; x < size / 2; x++)
                    {
                        Console.Write('+');
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}