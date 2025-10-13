using System;

namespace Appdevhb25.OliverBedogg.arrays
{

    public class ArrayHelper
    {
        public static void print2DIntArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---");
        }
        public static void print2DIntJaggedArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---");
        }

        public static void PrintArrayForEach(int[] arr)
        {
            Console.Write("[");
            bool first = true;
            foreach (int value in arr)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write(value);
                first = false;
            }
            Console.WriteLine("]");
        }

        public static int[] CreateArrayRandom(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(101);
            }
            return arr;
        }

        public static int[] CreateArrayRandom(int size, int min, int max)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(min, max);
            }
            return arr;
        }

    }
}