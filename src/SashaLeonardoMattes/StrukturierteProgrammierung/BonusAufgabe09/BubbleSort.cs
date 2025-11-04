using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe09
{

    public class BubbleSort
    {

        public static void StartBubbleSort()
        {
            Console.WriteLine("----------BonusAufgabe 09----------");

            System.Console.WriteLine("Wie viele Zahlen möchtest in das Array speichern?");

            int amount = Helper.checkUserInputInteger();
            int[] numbers = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                System.Console.WriteLine($"Gib die {i + 1}. Zahl ein:");
                numbers[i] = Helper.checkUserInputInteger();
            }

            System.Console.WriteLine("Sortiert: ");
            int[] sorted = BubbleSorter(numbers);
            foreach (var number in sorted)
            {
                System.Console.WriteLine(number);
            }

        }

        static int leftToSort;
        public static int[] BubbleSorter(int[] input)
        {

            leftToSort = input.Length;

            int temporary;

            for (int i = 0; i < leftToSort*2; i++)
            {
                for (int j = 0; j < leftToSort - 1; j++)
                {
                    if (input[j + 1] < input[j])
                    {
                        temporary = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temporary;
                    }
                }
                leftToSort--;
            }
            return input;
        }

    }
}
