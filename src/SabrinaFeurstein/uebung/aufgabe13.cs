using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using Appdevhb25.SabrinaFeurstein.uebung;

namespace Appdevhb25.SabrinaFeurstein.uebung
{
    public class aufgabe13
    {
        public static void PrintDeltoid(int size)
        {
            for (int y = 0; y < size / 2; y++)
            {
                for (int x = size / 2; x > y; x--)
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
            for (int y = 0; y <= size / 2; y++)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write(' ');
                }
                Console.Write('x');
                if (y < size / 2 && size % 2 == 0)
                {
                    for (int x = size - 1; x > y * 2 ; x--)
                    {
                        Console.Write(' ');
                    }
                    Console.Write('x');
                }
                if (y < size / 2 && size % 2 != 0)
                {
                    for (int x = size - 1; x > y * 2 + 1; x--)
                    {
                        Console.Write(' ');
                    }
                    Console.Write('x');
                }
                Console.WriteLine();
            }
        }
    }
}