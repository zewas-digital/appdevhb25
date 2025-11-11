using System;
using Appdevhb25.JulianMatt.Aufgabe64;

namespace Appdevhb25.JulianMatt.Aufgabe74
{
    public class Liste
    {
        public static void Start74()
        {
            List<int> randomNumbers = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                randomNumbers.Add(rnd.Next(0, 99));
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Unveränderte liste:");

            foreach (var number in randomNumbers)
            {
                System.Console.Write(number + " ");
            }

            StraightNumbers(randomNumbers);

            SearchForSmallestNumber(randomNumbers);
            SearchForBiggestNumber(randomNumbers);
            
            SortDeacreasing(randomNumbers);

            DeleteUnevenNumbers(randomNumbers);
        }

        public static void StraightNumbers(List<int> randomNumbers)
        {
            List<int> straightNumbers = new List<int>();
            int counter = 100;

            for (int i = 0; i < randomNumbers.Count; i++)
            {
                if (randomNumbers[i] % 2 == 0)
                {
                    straightNumbers.Add(randomNumbers[i]);
                    counter++;
                }
                else
                {

                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Gerade Zahlen:");
            System.Console.WriteLine($"Es sind {counter} gerade Zahlen in der Liste");

            foreach (var number in straightNumbers)
            {
                System.Console.Write(number + " ");
            }
        }

        public static void SearchForSmallestNumber(List<int> randomNumbers)
        {
            int smallestNumber = 0;

            for (int i = 0; i < randomNumbers.Count; i++)
            {
                if (randomNumbers[i] < smallestNumber)
                {
                    smallestNumber = randomNumbers[i];
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine($"Die kleinse nummer ist {smallestNumber}");
        }
        public static void SearchForBiggestNumber(List<int> randomNumbers)
        {
            int smallestNumber = 0;

            for (int i = 0; i < randomNumbers.Count; i++)
            {
                if (randomNumbers[i] > smallestNumber)
                {
                    smallestNumber = randomNumbers[i];
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine($"Die größte nummer ist {smallestNumber}");
        }

        public static void SortDeacreasing(List<int> randomNumbers)
        {
            List<int> numbersToSort = new List<int>(randomNumbers);

            for (int i = 0; i < randomNumbers.Count; i++)
            {
                for (int j = 0; j < randomNumbers.Count - 1; j++)
                {
                    if (numbersToSort[j] < numbersToSort[j + 1])
                    {
                        int tmpSave = numbersToSort[j];
                        numbersToSort[j] = numbersToSort[j + 1];
                        numbersToSort[j + 1] = tmpSave;
                    }
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Sortiert von der höchsten Zahl bis zur niedriegen Zahl");
            foreach (var number in numbersToSort)
            {
                System.Console.Write(number + " ");
            }
        }
        
        public static void DeleteUnevenNumbers (List<int> randomNumbers)
        {
            List<int> straightNumbers = new List<int>(randomNumbers);

            for (int i = 0; i < straightNumbers.Count; i++)
            {
                if (straightNumbers[i] % 2 != 0)
                {
                    straightNumbers.RemoveAt(i);
                    i--;
                }
                else
                {

                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine();

            foreach (var number in straightNumbers)
            {
                System.Console.Write(number + " ");
            }
        }
    }
}
