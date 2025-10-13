using System.Globalization;
using System.Runtime.InteropServices;

namespace Appdevhb25.KerimAlkis.Bonusaufgabe10
{
    public class SortingAlorithmen
    {
        public static void Start()
        {
            Console.WriteLine("Sorting-Algorithmen");
            Console.WriteLine("Wie viele Zahlen willst du generieren");

            int number = 0;
            do
            {
                if (int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    number = inputNumber; break;
                }
                else { Console.WriteLine("Versuchs Nochmal"); }
            } while (true);

            Random rndZahl = new Random();

            int[] numberArray = new int[number];

            for (int i = 0; i < number; i++)
            {
                numberArray[i] = rndZahl.Next(0, 1000);
            }

            Console.WriteLine();
            Console.WriteLine("Auflistung der generierten Nummern:");
            foreach (int zahl in numberArray)
            {
                Console.WriteLine(zahl);
            }
            //BubbleSorting(numberArray);

            //SelectionSort(numberArray);

            //InsertionSort(numberArray);

            //MergeSort(numberArray);

            //QuickSort(numberArray, 0, numberArray.Length-1);

            QuickSortTernary(numberArray, 0, numberArray.Length-1);


            Console.WriteLine("Auflistung:");
            foreach(int zahl in numberArray)
            {
                Console.WriteLine(zahl);
            }
        }


        public static int[] BubbleSorting(int[] numberArray)
        {
            for (int i = 0; i < numberArray.Length - 1; i++)
            {
                for (int j = 0; j < numberArray.Length - 1 - i; j++)
                {
                    if (numberArray[j] > numberArray[j + 1])
                    {
                        int temp = numberArray[j + 1];
                        numberArray[j + 1] = numberArray[j];
                        numberArray[j] = temp;
                    }
                }
            }
            return numberArray;
        }
        public static int[] SelectionSort(int[] numberArray)
        {
            for (int i = 0; i <= numberArray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < numberArray.Length; j++)
                {
                    if (numberArray[j] < numberArray[min])
                    {
                        min = j;
                    }
                }
                int temp = numberArray[i];
                numberArray[i] = numberArray[min];
                numberArray[min] = temp;

            }
            return numberArray;
        }
        public static int[] InsertionSort(int[] numberArray)
        {
            for (int i = 1; i < numberArray.Length; i++)
            {
                int j = i;
                do
                {
                    if (numberArray[j] < numberArray[j - 1])
                    {
                        int temp = numberArray[j];
                        numberArray[j] = numberArray[j - 1];
                        numberArray[j - 1] = temp;
                    }
                    j--;
                } while (j > 0);
            }
            return numberArray;
        }
        public static int[] MergeSort(int[] numberArray)
        {
            int length = numberArray.Length;
            if (numberArray.Length <= 1)
            {
                return numberArray;
            }
            int mitte = length / 2;
            int[] links = new int[mitte]; int[] rechts = new int[length - mitte];

            for (int i = 0; i < length; i++)
            {
                if (i < mitte)
                {
                    links[i] = numberArray[i];
                }
                else
                {
                    rechts[i - mitte] = numberArray[i];
                }
            }
            MergeSort(links);
            MergeSort(rechts);
            MergeSortHelper(links, rechts, numberArray);

            return numberArray;
        }
        public static int[] MergeSortHelper(int[] links, int[] rechts, int[] numberarray)
        {
            int l = 0;
            int r = 0;
            int i = 0;

            while (l < links.Length && r < rechts.Length)
            {
                if (links[l] < rechts[r])
                {
                    numberarray[i] = links[l];
                    i++;
                    l++;
                }
                else { numberarray[i] = rechts[r]; i++; r++; }
            }
            while (l < links.Length)
            {
                numberarray[i] = links[l];
                i++;
                l++;
            }
            while (r < rechts.Length)
            {
                numberarray[i] = rechts[r];
                i++;
                r++;
            }
            return numberarray;
        }
        public static int[] QuickSort(int[] numberArray, int start, int ende)
        {
            if (ende <= start)
            {
                return numberArray;
            }
            int p = QuickSortPartition(numberArray, start, ende);
            QuickSort(numberArray, start, p - 1);
            QuickSort(numberArray, p + 1, ende);

            return numberArray;
        }
        public static int QuickSortPartition(int[] numberarray, int start, int ende)
        {
            int pivot = numberarray[ende];
            int i = start - 1;
            for (int j = start; j < ende; j++)
            {
                if (numberarray[j] < pivot)
                {
                    i++;
                    int temp = numberarray[j];
                    numberarray[j] = numberarray[i];
                    numberarray[i] = temp;
                }
            }
            i++;
            int temp2 = numberarray[i];
            numberarray[i] = numberarray[ende];
            numberarray[ende] = temp2;

            return i;
        }
        public static int[] QuickSortTernary(int[] numberArray, int start, int ende)
        {
            if (ende <= start)
            {
                return numberArray;
            }
            (int i, int j) = QuickSortTernaryPartition(numberArray, start, ende);
            QuickSort(numberArray, start, i - 1);
            QuickSort(numberArray, j + 1, ende);

            return numberArray;
        }
        public static (int, int) QuickSortTernaryPartition(int[] numberarray, int start, int ende)
        {
            int pivot = numberarray[ende];
            int i = start - 1;
            int j = start;
            int k = ende;

            while(j <= k)
            {
                if (numberarray[j] < pivot)
                {
                    i++;
                    int temp = numberarray[j];
                    numberarray[j] = numberarray[i];
                    numberarray[i] = temp;
                    j++;
                }
                else if(numberarray[j] > pivot)
                {
                    k--;
                    int temp = numberarray[j];
                    numberarray[j] = numberarray[k];
                    numberarray[k] = temp;
                }
                else
                {
                    j++;
                }
            }
            int temp2 = numberarray[j];
            numberarray[j] = numberarray[ende];
            numberarray[ende] = temp2;

            return (i, j);
        }
    }    
}