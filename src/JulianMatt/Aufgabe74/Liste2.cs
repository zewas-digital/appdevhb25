using System;
using Appdevhb25.JulianMatt.Aufgabe42;
using Appdevhb25.JulianMatt.Aufgabe64;

namespace Appdevhb25.JulianMatt.Aufgabe74
{
    public class Liste2
    {
        public static void Start74()
        {
            List<int> ListOfNUmbersOne = CreateARandomList();
            List<int> ListOfNumbersTwo = CreateARandomList();

            List<int> CominedListOfNumbers = ListCombiner(ListOfNUmbersOne, ListOfNumbersTwo);

        }

        public static List<int> CreateARandomList()
        {
            List<int> numbers = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(rnd.Next(0, 99));
            }
            SortDeacreasing(numbers);
            return numbers;
        }

        public static void SortDeacreasing(List<int> listThatNeedsToBeSorted)
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            listThatNeedsToBeSorted.Sort();
            listThatNeedsToBeSorted.Reverse();

            foreach (var number in listThatNeedsToBeSorted)
            {
                System.Console.Write(number + " ");
            }
        }

        public static List<int> ListCombiner( List<int> List1, List<int> List2)
        {
            List<int> CombinedOfTheTwo = new List<int>(List1);
            CombinedOfTheTwo.AddRange(List2);
            SortDeacreasing(CombinedOfTheTwo);

            return CombinedOfTheTwo;
        }
        
    }
}