using System;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SelinUlutuerk.Aufgabe34
{
    class CopyReverse
    {
        public static void Copy2()
        {
            Console.WriteLine("Wie viele Werte soll es geben?");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            Random zahl = new Random();

            int[] originalArray = new int[anzahl];


            for (int i = 0; i < originalArray.Length; i++)
            {
                int randomZahl = zahl.Next(1, 101);
                originalArray[i] = randomZahl;
            }

            //originalArray
            Console.WriteLine();

            foreach (int elem in originalArray)
            {
                System.Console.WriteLine(elem);
            }

            //Ausgabe copiedArray
            Console.WriteLine();

            int[] copiedArray = CopyArray(originalArray);

            for (int i = 0; i <= originalArray.Length ; i++)
            {
                Console.WriteLine($"{copiedArray[i]}");
            }
        }

        public static int[] CopyArray(int[] array)
        {
            int[] copy = new int[array.Length];

            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = array[array.Length - i - 1];
            }
            return copy;
        }

    }
}