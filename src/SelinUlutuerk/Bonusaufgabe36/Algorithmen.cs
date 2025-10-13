using System;
using System.Runtime.CompilerServices;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe36
{
    class Algorithmen
    {
        public static void Start()
        {
            Console.WriteLine("Selection Sort:");
            selectionSort();

            Console.WriteLine("\nInsertion Sort:");
            insertionSort();

            Console.WriteLine("\nGnome Sort:");
            gnomeSort();

            Console.WriteLine("\nShaker Sort:");
            shakerSort();

            Console.WriteLine("\nMerge Sort:");
            // mergeSort();
        }

        // Selection Sort
        public static void selectionSort()
        {
            int[] sort = [22, 7, 3, 10, 20, 55, 1, 33, 80, 23, 4, 24, 21, 6];
            int n = sort.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (sort[j] < sort[min])
                    {
                        min = j;
                    }
                }
                int temp = sort[i];
                sort[i] = sort[min];
                sort[min] = temp;
            }

            Console.Write($"Sorted array: ");
            foreach (int i in sort)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }

        // Insertion Sort
        public static void insertionSort()
        {
            int[] sort = [22, 7, 3, 10, 20, 55, 1, 33, 80, 23, 4, 24, 21, 6];
            int n = sort.Length;

            for (int i = 1; i < n; i++)
            {
                int j = i;

                int temp = sort[i];
                while (j > 0 && sort[j - 1] > temp)
                {
                    sort[j] = sort[j - 1];
                    j--;
                }
                sort[j] = temp;
            }

            Console.Write($"Sorted array: ");
            foreach (int i in sort)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }

        // Gnome Sort
        public static void gnomeSort()
        {
            int[] sort = [22, 7, 3, 10, 20, 55, 1, 33, 80, 23, 4, 24, 21, 6];
            int n = sort.Length;
            int i = 1;

            while (i < n)
            {
                if (sort[i - 1] <= sort[i])
                {
                    i++;
                }
                else
                {
                    int temp = sort[i];
                    sort[i] = sort[i - 1];
                    sort[i - 1] = temp;

                    if (i > 1)
                    {
                        i--;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            Console.Write($"Sorted array: ");
            foreach (int num in sort)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        //  Shaker Sort
        public static void shakerSort()
        {
            int[] sort = [22, 7, 3, 10, 20, 55, 1, 33, 80, 23, 4, 24, 21, 6];
            int n = sort.Length;

            int lo = 1;
            int hi = n - 1;
            int mov = lo;

            while (lo < hi)
            {
                for (int i = hi; i >= lo; i--)
                {
                    if (sort[i - 1] > sort[i])
                    {
                        int temp = sort[i - 1];
                        sort[i - 1] = sort[i];
                        sort[i] = temp;

                        mov = i;
                    }
                }

                lo = mov;

                for (int i = lo; i < hi; i++)
                {
                    if (sort[i] > sort[i + 1])
                    {
                        int temp = sort[i];
                        sort[i] = sort[i + 1];
                        sort[i + 1] = temp;

                        mov = i;
                    }
                }

                hi = mov;

            }

            Console.Write("Sorted array: ");
            foreach (int num in sort)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        //  Merge Sort
        // public static void mergeSort()
        // {
        //     int[] sort = [22, 7, 3, 10, 20, 55, 1, 2, 33, 80, 23, 4, 24, 21, 6];
        //     int n = sort.Length;
            
        //     int hi = n - 1;
        //     int lo = 0;

        //     if (hi - lo < 1)
        //         return;
            
        //     int mid = (lo + hi) / 2;

        //     mergeSort(sort, lo, mid);
        //     mergeSort(sort, mid, hi);
        
        //     int i = lo, j = mid, k = 0;

        //     while (i < mid && j < hi)
        //     {
        //         if (sort[i] < sort[j])
        //         {
        //             temp[k++] = sort[i++];
        //         }
        //         else
        //         {
        //             temp[k++] = sort[j++];
        //         }
        //     }

        //     while (i <= mid)
        //     {
        //         temp[k++] = sort[i++];
        //     }

        //     while (j <= hi)
        //     {
        //         temp[k++] = sort[j++];
        //     }

        //     for (i = lo, k = 0; i <= hi; i++, k++)
        //     {
        //         sort[i] = temp[k];
        //     }

        //     Console.Write("Sorted array: ");
        //     foreach (int num in sort)
        //     {
        //         Console.Write(num + " ");
        //     }
        //     Console.WriteLine();

        // }
    }
}