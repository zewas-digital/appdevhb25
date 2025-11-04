using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe10
{

    public class SortAlgorithms
    {

        public static void StartSortAlgorithms()
        {
            Console.WriteLine("----------BonusAufgabe 10----------");

            System.Console.WriteLine("Wie viele Zahlen möchtest in das Array speichern?");

            int amount = Helper.checkUserInputInteger();
            int[] numbers = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                System.Console.WriteLine($"Gib die {i + 1}. Zahl ein:");
                numbers[i] = Helper.checkUserInputInteger();
            }

            int[] sortedByBubbleSorter = BubbleSorter(numbers);
            int[] sortedBySelectionSorter = SelectionSorter(numbers);
            int[] sortedByGnomeSorter = GnomeSorter(numbers);
            int[] sortedByCocktailSorter = CocktailSorter(numbers);

            System.Console.WriteLine("Bubble Sorter:");
            foreach (var number in sortedByBubbleSorter)
            {
                System.Console.WriteLine(number);
            }

            System.Console.WriteLine("Selection Sorter:");
            foreach (var number in sortedBySelectionSorter)
            {
                System.Console.WriteLine(number);
            }

            System.Console.WriteLine("Gnome Sorter:");
            foreach (var number in sortedByGnomeSorter)
            {
                System.Console.WriteLine(number);
            }

            System.Console.WriteLine("Cocktail Sorter:");
            foreach (var number in sortedByCocktailSorter)
            {
                System.Console.WriteLine(number);
            }

        }

        static int leftToSort;
        public static int[] BubbleSorter(int[] input)
        {

            leftToSort = input.Length;

            int temporary;

            for (int i = 0; i < leftToSort * 2; i++)
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


        public static int[] SelectionSorter(int[] input)
        {
            int lenght = input.Length;
            int min = input.Max();
            int startIndex = 0;
            int temp;

            for (int i = 0; i < lenght; i++)
            {
                for (int j = startIndex; j < lenght; j++)
                {
                    if (input[j] < min)
                    {
                        min = input[j];
                        temp = input[startIndex];
                        input[startIndex] = min;
                        input[j] = temp;
                    }
                }
                startIndex++;
                min = input.Max();
            }
            return input;
        }

        public static int[] GnomeSorter(int[] input)
        {
            int temp;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] < input[i - 1])
                {
                    temp = input[i - 1];
                    input[i - 1] = input[i];
                    input[i] = temp;
                    if (i > 1)
                    {
                        i -= 2;
                    }
                }
            }



            return input;
        }
        
        public static int[] CocktailSorter(int[] input)
        {

            leftToSort = input.Length;

            int temporary;
            int startIndex = 0;
            int endIndex = leftToSort;

            for (int i = 0; i < leftToSort; i++)
            {
                for (int j = startIndex; j < endIndex - 1; j++)
                {
                    if (input[j + 1] < input[j])
                    {
                        temporary = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temporary;
                    }
                }
                leftToSort--;
                endIndex--;
                for (int j = endIndex; j > startIndex; j--)
                {
                    if (input[j] < input[j - 1])
                    {
                        temporary = input[j];
                        input[j] = input[j - 1];
                        input[j - 1] = temporary;
                    }
                }
                leftToSort--;
                startIndex++;

            }
            return input;
        }


    }
}
