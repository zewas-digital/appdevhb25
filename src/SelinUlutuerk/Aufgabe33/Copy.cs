using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe33
{
    class Copy
    {
        public static void Start()
        {
            Console.WriteLine("Wie viele Werte soll es geben?");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            Random zahl = new Random();

            

            int[] originalArray = new int[anzahl];

            originalArray[0] = -1;

            for (int i = 0; i < originalArray.Length; i++)
            {
                int randomZahl = zahl.Next(1, 101);
                originalArray[i] = randomZahl;
            }

            //Ausgabe originalArray
            for (int i = 0; i < originalArray.Length; i++)
            {
                Console.WriteLine($"{originalArray[i]}");
            }

            //copiedArray1
            Console.WriteLine();

            int[] copiedArray = CopyArray(originalArray);

            foreach (int elem in copiedArray)
            {
                System.Console.WriteLine(elem);
            }


            //copiedArray2
            Console.WriteLine();
            
            int[] copiedArray2 = CopyArray2(originalArray);

            foreach (int elem in copiedArray2)
            {
                System.Console.WriteLine(elem);
            }
        }

        //eigentlich falsch - die -1 wird in der copy auch angepasst - soll aber nicht so sein
        public static int[] CopyArray(int[] array)
        {
            int[] copy = array;
            return copy;
        }

        // richtige art
        public static int[] CopyArray2(int[] array)
        {
            int[] copy = new int[array.Length];

            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = array[i];
            }
            return copy;
        }
    }
}