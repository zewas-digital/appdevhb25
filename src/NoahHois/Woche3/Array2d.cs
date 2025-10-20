using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Appdevhb25.NoahHois.Aufgabe27
{
    public class Array2d
    {
        public static void Output()
        {
            Random random = new Random();

            int[,] numbers = new int[3, 3];

            // Fill the array with random numbers and print them
            for (int y = 0; y < numbers.GetLength(0); y++)
            {
                for (int x = 0; x < numbers.GetLength(1); x++)
                {
                    numbers[y, x] = random.Next(0, 9);
                    Console.Write(numbers[y, x] + "   ");
                }
                Console.WriteLine();
            }

            // Sum of lines (y)
            Console.WriteLine("Sum of lines:");
            for (int y = 0; y < numbers.GetLength(0); y++)
            {
                int sum = 0;
                for (int x = 0; x < numbers.GetLength(1); x++)
                {
                    sum = sum + numbers[y, x];
                }
                Console.WriteLine(sum);
            }

            // Sum of columns (x)
            Console.WriteLine("Sum of columns");
            for (int x = 0; x < numbers.GetLength(1); x++)
            {
                int sum = 0;
                for (int y = 0; y < numbers.GetLength(0); y++)
                {
                    sum = sum + numbers[y, x]; // 1,0  2,0
                }
                Console.WriteLine(sum);
            }

            // Sum of matrix:
            int matrixSumme = 0;
            Console.WriteLine("Sum of matrix");
            for (int x = 0; x < numbers.GetLength(1); x++)
            {
                for (int y = 0; y < numbers.GetLength(0); y++)
                {
                    matrixSumme = matrixSumme + numbers[y, x]; // 1,0  2,0
                }
            }
            Console.WriteLine(matrixSumme);

        }
    }
}