using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Appdevhb25.NoahHois.Aufgabe74
{
    public class Liste
    {
        public static void Start()
        {
            List<int> randomList = randomList = GenerateRandomList(20, 0, 99);
            Console.WriteLine("Generierte Liste: [{0}]", string.Join(", ", randomList));
            int min = MinNumber(randomList);
            Console.WriteLine($"Min {min}");
            int max = MaxNumber(randomList);
            Console.WriteLine($"Max {max}");
            Sort(randomList);
            List<int> evenNumbers = RemoveOddNumbers(randomList);
            Console.WriteLine("Nach dem Entfernen ungerader Zahlen: [{0}]", string.Join(", ", evenNumbers));
        }
        private static int MinNumber(List<int> number)
        {
            return number.Min();
        }
        private static int MaxNumber(List<int> number)
        {
            return number.Max();
        }
        public static List<int> GenerateRandomList(int size, int minValue, int maxValue)
        {
            Random rand = new Random();
            List<int> randomList = new List<int>();

            for (int i = 0; i < size; i++)
            {
                randomList.Add(rand.Next(minValue, maxValue + 1));
            }
            randomList.AddRange(randomList);
            return randomList;
        }
        public static void Sort(List<int> sortedList)
        {
            sortedList.Sort();
            sortedList.Reverse();
        }
        private static List<int> RemoveOddNumbers(List<int> numbers)
        {
            List<int> kopie = new List<int>(numbers);
            kopie.RemoveAll(n => n % 2 != 0);
            return kopie;
        }
    }
}
