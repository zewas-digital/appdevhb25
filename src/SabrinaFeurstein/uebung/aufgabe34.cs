using System;
using Appdevhb25.SabrinaFeurstein.aufgaben;

namespace Appdevhb25.SabrinaFeurstein.uebung
{

    public class CopyReverse
    {
        public static void Start()
        {
            Random random = new Random();

            int[] arrayog = new int[5];

            for (int i = 0; i < arrayog.Length; i++)
            {
                arrayog[i] = random.Next(1, 100);
                Console.WriteLine(arrayog[i]);
            }

            int[] arraycopy = CopyArray(arrayog);

            foreach (int elem in arraycopy)
            {
                Console.WriteLine(elem);    
            }
        }
        
        public static int[] CopyArray(int[] array)
        {
            int[] copy = new int[array.Length];

            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = array[copy.Length - 1 - i];
            }

            return copy;
        }
    }
}