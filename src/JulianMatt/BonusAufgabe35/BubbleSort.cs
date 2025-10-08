using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using Appdevhb25.JulianMatt.Aufgabe03;

namespace Appdevhb25.JulianMatt.Bonusaufgabe35
{
    public class BubbleSort
    {

        public static void Start35()
        {
            int[] Array = CreatArry();
            Console.Clear();
            SortArry(Array);
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

        public static void SortArry(int[] number)
        {
            bool swapped;
            int temp;

            do
            {
                swapped = false;
                for (int i = 0; i < number.Length - 1; i++)
                {
                    if (number[i] > number[i + 1]) 
                    {
                      
                        temp = number[i];
                        number[i] = number[i + 1];
                        number[i + 1] = temp;

                        swapped = true;
                    }
                }
            } while (swapped); 
            Console.WriteLine("Sortiertes Array (aufsteigend):");
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
        }
       
    }



}