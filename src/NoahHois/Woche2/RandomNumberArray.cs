using System;
using System.Runtime.InteropServices;

namespace Appdevhb25.NoahHois.Aufgabe24
{
    public class RandomNumberArray
    {
        public static void RandomNrArray()
        {
            int[] numbers = new int[5];

            Console.WriteLine("Anzahl der Elemente: 5");
            Random random = new Random();
            for (int r = 0; r < numbers.Length; r++)
            {
                numbers[r] = random.Next(100);
                Console.WriteLine(numbers[r]);
            }

            int maxNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (maxNumber < numbers[i])
                {
                    maxNumber = numbers[i];
                }
            }
            Console.WriteLine("Die größte nummer ist: " + maxNumber);

            int minNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (minNumber > numbers[i])
                {
                    minNumber = numbers[i];
                }
            }
            Console.WriteLine("Die kleinste nummer ist: " + minNumber);

            int sum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                sum = numbers[i] + sum;
            }
            Console.WriteLine("Die Summe ist: " + sum);

            int sumForAverage = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                sumForAverage = numbers[i] + sumForAverage;
            }
            double average = (double)sumForAverage / numbers.Length;
            Console.WriteLine("Der Durchschnitt beträgt: " + average);
        }
    }
}