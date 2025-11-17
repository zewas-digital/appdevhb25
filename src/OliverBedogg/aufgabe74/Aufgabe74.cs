using System;

namespace Appdevhb25.OliverBedogg.aufgabe74
{
    public class Aufgabe74
    {

        public static void Start()
        {
            List<int> randomList1 = randomList1 = GenerateRandomList(20, 0, 99);
            Console.WriteLine("Generierte Liste: [{0}]", string.Join(", ", randomList1));

            // Minimum
            // Alternativ zur Suche mittels Schleife:
            int min = FindMinimumBySorting(randomList1);
            Console.WriteLine("Minimum: {0}", min);


            min = FindMinimumByLinqList(randomList1);
            Console.WriteLine("Minimum (LINQ List): {0}", min);

            min = FindMinimumByLinqEnumerable(randomList1);
            Console.WriteLine("Minimum (LINQ Enumerable): {0}", min);

            // Ungerade entfernen
            // Alternativ zur Entfernung mittels Schleife:
            List<int> evenNumbers = RemoveOddNumbers(randomList1);
            Console.WriteLine("Nach dem Entfernen ungerader Zahlen: [{0}]", string.Join(", ", evenNumbers));
        }

        private static int FindMinimumBySorting(List<int> numbers)
        {
            // Kopie der Liste erstellen und sortieren: 1. Element ist Minimum
            List<int> kopie = new List<int>(numbers);
            kopie.Sort();
            return kopie[0];
        }

        private static int FindMinimumByLinqList(List<int> numbers)
        {
            // LINQ OrderBy-Methode aus System.Linq in eine sortierte Liste umwandeln
            var sortiert = numbers.OrderBy(n => n).ToList();
            return sortiert[0];
        }

        private static int FindMinimumByLinqEnumerable(List<int> numbers)
        {
            // LINQ Min-Methode aus System.Linq
            // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable?view=net-8.0
            return numbers.Min();
        }

        private static List<int> RemoveOddNumbers(List<int> numbers)
        {
            List<int> kopie = new List<int>(numbers);
            kopie.RemoveAll(n => n % 2 != 0); // Lambda-Ausdruck für ungerade Zahlen
            /*
            Der Lambda-Ausdruck entspricht der anonymen Methode:
            kopie.RemoveAll(delegate(int n) {
                return n % 2 != 0;
            });
            */
            return kopie;

            // Alternativ: LINQ Where-Methode aus System.Linq in eine neue Liste umwandeln
            // return numbers.Where(n => n % 2 == 0).ToList();
        }

        public static List<int> GenerateRandomList(int size, int minValue, int maxValue)
        {
            Random rand = new Random();
            List<int> randomList = new List<int>();

            for (int i = 0; i < size; i++)
            {
                randomList.Add(rand.Next(minValue, maxValue + 1));
            }

            return randomList;
        }
    }
}