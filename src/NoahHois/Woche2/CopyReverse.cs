using System;
using System.Runtime.CompilerServices;

namespace Appdevhb25.NoahHois.Aufgabe26
{
    public class CopyReverse
    {
        public static void CopyArrayReversed()
        {
            int[] numbers = new int[5];
            int[] reversed = new int[numbers.Length];

            Console.WriteLine("Anzahl der Elemente: 5");
            Random random = new Random();
            for (int r = 0; r < numbers.Length; r++)
            {
                numbers[r] = random.Next(100);
                Console.WriteLine(numbers[r]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                reversed[i] = numbers[numbers.Length - 1 - i];
            }
            Console.WriteLine("Reversed copy:");
            foreach (int num in reversed)
            {
                Console.WriteLine(num);
            }
        }
    }
}