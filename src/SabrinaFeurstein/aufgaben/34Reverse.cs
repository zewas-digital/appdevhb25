using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class Reverse

    {
        public static int[] Reverser(int[] original)
        {
            int[] reverse = new int[original.Length];

            for (int i = 0; i < reverse.Length; i++)
            {
                reverse[i] = original[reverse.Length - i - 1];
            }
            return reverse;
        }

        public static void Array()
        {
            Random rnd = new Random();
            int[] original = new int[5];

            for (int i = 0; i < original.Length; i++)
            {
                original[i] = rnd.Next(0, 100);
            }
            int[] reverse = Reverser(original);

            foreach (int elem in original)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();
            foreach (int elem in reverse)
            {
                Console.WriteLine(elem);
            }
        }
    }
}