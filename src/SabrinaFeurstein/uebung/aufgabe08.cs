using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using Appdevhb25.SabrinaFeurstein.uebung;

namespace Appdevhb25.SabrinaFeurstein.uebung
{
    public class aufgabe08
    {
        public static void PrintTriangle(int size)
        {
            for (int y = 0; y < size; y++)
            {
                for (int x = size; x > y; x--)
                {
                    Console.Write('x');
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write(' ');
                }
                for (int x = size; x > y; x--)
                {
                    Console.Write('x');
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int y = 0; y < size; y++)
            {
                for (int x = size - 1; x > y; x--)
                {
                    Console.Write(' ');
                }
                for (int x = 0; x <= y; x++)
                {
                    Console.Write('x');
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x <= y; x++)
                {
                    Console.Write('x');
                }
                Console.WriteLine();
            }
        }
    }
}
