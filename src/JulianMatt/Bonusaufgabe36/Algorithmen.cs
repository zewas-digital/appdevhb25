using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using Appdevhb25.JulianMatt.Aufgabe03;
using Appdevhb25.JulianMatt.Bonusaufgabe35;

namespace Appdevhb25.JulianMatt.Bonusaufgabe36
{
    public class Algotithmen
    {
        public static void BonusStart36()
        {
            //SelectionSort();
            //BubbleSort();
            InsertionSort();
        }

        public static int[] CreatArry()
        {
            int[] number;
            int countOfParticipants = TeilnehmerAnzahl();
            Console.WriteLine("Geben sie ihre Zahlen an:");
            number = new int[countOfParticipants];

            for (int j = 0; j < countOfParticipants; j++)
            {
                number[j] = Convert.ToInt32(Console.ReadLine());
            }
            return number;
        }

        public static int TeilnehmerAnzahl()
        {
            int countOfNumbers;
            Console.WriteLine("Geben sie die Anzahl ihrer Zahlen an");
            countOfNumbers = Convert.ToInt32(Console.ReadLine());
            return countOfNumbers;
        }

        // Selection Sort
        public static void SelectionSort()
        {
            int[] Array = CreatArry();
            Console.Clear();
            SortArry(Array);
        }

        public static void SortArry(int[] Array)
        {
            for (int j = 0; j < Array.Length - 1; j++)
            {
                int min = Array[j];
                int newIndex = 0;

                for (int i = j + 1; i < Array.Length; i++)
                {
                    int minTemp = Math.Min(min, Array[i]);
                    if (Array[i] < min)
                    {
                        newIndex = i;
                    }
                    min = minTemp;
                }

                if (newIndex > 0)
                {
                    int tempStorage = Array[j];
                    Array[newIndex] = tempStorage;
                    Array[j] = min;
                }
            }

            Console.WriteLine("Sortiertes Array (Selection Sort):");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }

        // Bubble Sort
        public static void BubbleSort()
        {
            int[] Array = CreatArry();
            Console.Clear();
            BubbleSort(Array);
        }

        public static void BubbleSort(int[] Array)
        {
            bool swapped;
            int temp;

            do
            {
                swapped = false;
                for (int i = 0; i < Array.Length - 1; i++)
                {
                    if (Array[i] > Array[i + 1])
                    {

                        temp = Array[i];
                        Array[i] = Array[i + 1];
                        Array[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
            Console.WriteLine("Sortiertes Array (Bubble Sort):");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }

        // Insertion Sort
        public static void InsertionSort()
        {
            int[] Array = CreatArry();
            //Console.Clear();
            InsertionSort(Array);
        }

        public static void InsertionSort(int[] Array)
        {
            for (int i = 1; i < Array.Length; i++)
            {
                int tempStorage = Array[i];
                int j = i - 1;
                while (j >= 0 && Array[j] > tempStorage)
                {
                    Array[j + 1] = Array[j];
                    j--;
                }
                Array[j + 1] = tempStorage;

            }

            Console.WriteLine("Sortiertes Array (Insertion Sort):");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }

    }



}