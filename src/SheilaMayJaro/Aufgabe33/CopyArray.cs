using System;
using System.Reflection.Metadata.Ecma335;

namespace Appdevhb25.SheilaMayJaro.Aufgabe33
{
    public class CopyArray
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 33)");
            int a = 3;
            int b = 13;
            a = b;
            Console.WriteLine(b);

            int[] originalArray = [1, 2, 3];
            int[] copiedArray = PrintCopyArray(originalArray);
            int[] copiedArrayTwo = PrintCoppyArrayTwo(originalArray);
            originalArray[0] = -1;
            for (int i = 0; i < originalArray.Length; i++)
            {
                Console.WriteLine(originalArray[i]);
            }
            foreach (int elem in copiedArray)
            {
                Console.WriteLine(elem);
            }
            foreach (int elem in copiedArrayTwo)
            {
                Console.WriteLine(elem); 
            }


        }
        public static int PrintCopyValue(int a)
        {
            int b = 13;
            a = b;
            return b;
        }
        public static int[] PrintCopyArray(int[] array)
        {
            int[] copy = array;
            return copy;
        }
        public static int[] PrintCoppyArrayTwo(int[] array)
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