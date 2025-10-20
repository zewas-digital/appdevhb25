using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Appdevhb25.NoahHois.Aufgabe28
{
    public class PascalDreieck
    {
        public static void Output()
        {
            Console.WriteLine("Gib eine Zahl ein: ");
            string numberQuestion = Console.ReadLine();

            int size = int.Parse(numberQuestion);
            int[,] numbers = new int[size, size];

            for (int y = 0; y < numbers.GetLength(0); y++)
            {
                for (int x = 0; x < numbers.GetLength(1); x++)
                {
                    if (y == 0 || x == 0)
                    {
                        numbers[y, x] = 1;
                    }
                }
            }

            for (int y = 1; y < numbers.GetLength(0); y++)
            {
                for (int x = 1; x < numbers.GetLength(1); x++)
                {
                    numbers[y, x] = numbers[y - 1, x] + numbers[y, x - 1];
                }
            }

            for (int y = 0; y < numbers.GetLength(0); y++)
            {
                for (int x = 0; x < numbers.GetLength(1); x++)
                {
                    Console.Write(numbers[y, x] + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}