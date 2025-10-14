using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class Algorithmen

    {
        public static void SelectionSort()
        {
            int[] array = [4, 9, 6, 7, 2];

            for (int i = 0; i < array.Length - 1; i++)
            {
                int min;
                min = array.Max();
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        array[j] = array[i];
                        array[i] = min;
                    }
                }
            }
            foreach (int elem in array)
            {
                Console.Write($"{elem} ");
            }
        }

        public static void InsertionSort()
        {
            int[] array = [4, 9, 6, 7, 2];

            for (int j = 1; j < array.Length; j++)
            {
                while (j > 0 && array[j - 1] > array[j])
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;

                    j--;
                }
            }
            foreach (int elem in array)
            {
                Console.Write($"{elem} ");
            }
        }

        public static void CocktailShakerSort()
        {
            int[] array = [4, 9, 6, 7, 2];
            int start = 0;
            int end = array.Length - 1;
            bool swapped = true;

            while (swapped)
            {
                swapped = false;
                for (int i = start; i < end; i++)
                {
                    if (array[i + 1] < array[i])
                    {
                        int temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;

                swapped = false;
                end--;
                for (int i = end; i > start; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        int temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                        swapped = true;
                    }
                }
                start++;
            }
            foreach (int elem in array)
            {
                Console.Write($"{elem} ");
            }
        }
    }
}