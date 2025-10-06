using System;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.NoahHois.Aufgabe8
{
    public class PrintTriangle2
    {
        public static void Aufgabe8()
        {
            int size = 5;
            for (int y = 0; y < size; y++)             // 1.
            {
                for (int i = size; y < i; i--)
                {
                    if (i - 1 < y)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("x");
                    }
                 
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Aufgabe8_1();
        }
        public static void Aufgabe8_1()
        {
            int size = 5;
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if (x < y)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("x");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Aufgabe8_2();
        }
        public static void Aufgabe8_2()
        {
            int size = 5;
            for (int y = 0; y < size; y++)                    // 3.
            {
                for (int i = size; i > 0; i--)
                {
                    if (i - 1 > y)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("x");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Aufgabe8_3();
        }

        public static void Aufgabe8_3()
        {
            int size = 5;
            for (int i = 0; i < size; i++)             // 4.
            {
                for (int y = 0; y < size; y++)
                {
                    if (y <= i)
                    {
                        Console.Write("x");
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


