using System.Windows.Markup;
using System.Collections.Generic;
using System.Net;

namespace Appdevhb25.SheilaMayJaro.Aufgabe74
{
    public class List
    {

        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 74.1)\n");
            /* 
            1/ Liste erstellen
            Erstelle eine Liste mit 20 Zufallszahlen zwischen 0 und 99.
            Erstelle jeweils eine Methode für:
            - Zählen der geraden Zahlen
            - Suche nach der kleinsten Zahl
            - Suche nach der größten Zahl
            - Sortiere die Elementen absteigend
            - Lösche alle Ungerade Zahlen

            */
            Random randomNumbers = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(randomNumbers.Next(0, 99)); //zwischen 0 und 99, Minuszahlen mag es nicht, Zahlen 1:1 übernommen
            }
            foreach (int number in numbers)
            {
                System.Console.Write(number + "\t");
            }
            System.Console.WriteLine();
            Console.WriteLine($"Anzahl gerader Zahlen: {CountEvenNumbers(numbers)}");
            System.Console.WriteLine($"Die kleinste Zahl ist: {SmallestNumber(numbers)}");
            System.Console.WriteLine($"Die größte Zahl ist: {BiggestNumber(numbers)}");
            System.Console.WriteLine("Liste absteigend sortiert:");
            foreach (int number in SortNumberDescending(numbers))
            {
                System.Console.Write(number + "\t"); 
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Liste ohne ungerade Zahlen:");
            foreach (int number in RemoveOddNumbers(numbers))
            {
                System.Console.Write(number + "\t");
            }
            /*    
            2/ Listen zusammenführen
            Erstelle zwei Listen mit 20 Elementen, die nach Größe sortiert sind.
            Erstelle eine dritte Liste, in dem du die Elemente der vorhergehenden 
            Listen zusammenfügst, die neu erstellte Liste soll immer noch sortiert sein.
            
            --> Erstelle nachvollziehbare Ausgaben für jedes Ergebnis
            */
            System.Console.WriteLine("\nAufgabe 74.2)\n");
            List<int> numberList1 = new List<int>();
            List<int> numberList2 = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                numberList1.Add(randomNumbers.Next(0, 50));
            }
            for (int i = 0; i < 20; i++)
            {
                numberList2.Add(randomNumbers.Next(51, 100));
            }

            SortNumberDescending(numberList1);
            SortNumberDescending(numberList2);
            
            List<int> numberList3 = MergeLists(numberList1, numberList2);
            System.Console.WriteLine("Zusammenführung von zwei Listen:");
            foreach (int number in SortNumberDescending(numberList3))
            {
                System.Console.WriteLine(number);
            }
        }
        //Zählen der geraden Zahlen 
        public static int CountEvenNumbers(List<int> list)
        {
            int count = 0;
            foreach (int number in list)
            {
                if (number % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        //Suche nach der kleinsten Zahl 
        public static int SmallestNumber(List<int> list)
        {
            int smallestNumber = 100;
            for (int i = 0; i < 20; i++)
            {
                if (list[i] < smallestNumber)
                {
                    smallestNumber = list[i];
                }
            }
            return smallestNumber;
        }
        public static int BiggestNumber(List<int> list)
        {
            int biggestNumber = 0;
            for (int i = 0; i < 20; i++)
            {
                if (list[i] > biggestNumber)
                {
                    biggestNumber = list[i];
                }
            }
            return biggestNumber;
        }
        //Sortiere die Elementen absteigend
        public static List<int> SortNumberDescending(List<int> list)
        {
            list.Sort();
            list.Reverse();
            return list;
        }
        // - Lösche alle Ungerade Zahlen
        public static List<int> RemoveOddNumbers(List<int> list)
        {
            // list.RemoveAll(); 
            int count = 20;
            for (int i = 0; i < count; i++)
            {
                if (!(list[i] % 2 == 0))
                {
                    list.Remove(list[i]);
                    count--;
                    i--;
                }
            }
            return list;
        }
        public static List<int> MergeLists(List<int> list1, List<int> list2)
        {
            list1.AddRange(list2); 
            return list1; 
        }
        
    }
}