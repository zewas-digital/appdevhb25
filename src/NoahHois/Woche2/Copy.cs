using System;

namespace Appdevhb25.NoahHois.Aufgabe25
{
    public class Copy
    {
        public static void CopyArray()
        {
            int original = 5;
            int copy = CopyVariable(original);
            original = 6;

            Console.WriteLine(@$"Wert der ursprünglichen Variable: {original}
Wert der kopierten Variable: {copy}");

            int[] originalArray = { 1, 2, 3 };

            int[] copiedArray = CopyArray(originalArray);

            int[] copiedArray2 = CopyArray2(originalArray);

            originalArray[0] = -1;

            for (int i = 0; i < originalArray.Length; i++)
            {
                Console.WriteLine(originalArray[i]);
            }

            Console.WriteLine();

            foreach (int elem in copiedArray)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine();

            foreach (int elem in copiedArray2)
            {
                Console.WriteLine(elem);
            }
        }

        public static int[] CopyArray(int[] array)
        {
            int[] copy = array;
            return copy;
        }

        public static int[] CopyArray2(int[] array)
        {
            int[] copy = new int[array.Length];

            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = array[i];
            }
            return copy;
        }

        public static int CopyVariable(int a)
        {
            int b = a;
            return b;
        }
    }
}