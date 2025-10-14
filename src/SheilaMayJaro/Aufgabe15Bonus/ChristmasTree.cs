using System;
using System.ComponentModel.DataAnnotations;

namespace Appdevhb25.SheilaMayJaro.Aufgabe15
{
    public class ChristmasTree
    { 
        public static void Start()
        {
            Console.WriteLine("Aufgabe 15)");
            PrintChristmasTree(9); 
        }
        public static void PrintChristmasTree(int number)
        {
            int length = number;
            int half = length / 2; 
            for (int y = 1; y <= length; y++)
            {
                for (int x = length; x > 0; x--)
                {
                    if (x > y)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        for (int a = 0; a < y * 2 - 1; a++)
                        {
                            Console.Write("*");

                        }
                        break;
                    }
                }
                Console.WriteLine();
            }
            for (int y = 0; y < 1; y++)
            {
                 for (int b = 0; b < length*2; b++)
                {
                    if (b % 2 == 0)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine(); 
         for (int i = 0; i < 2; i++)
            {
                for (int y = 0; y < length*2; y++)
                {
                    if ( y > 5 && y < 11)
                    {
                        Console.Write("+");
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