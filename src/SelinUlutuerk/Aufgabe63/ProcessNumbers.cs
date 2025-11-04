using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe63
{
    class ProcessNumbers
    {
        public static void Start()
        {
            Console.Write("Wie viele Zahlen möchten Sie eingeben? ");
            if (int.TryParse(Console.ReadLine(), out int anzahl))
            {
                int[] numbers = new int[anzahl];
                Zahlen(numbers);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe.");
            }
        }

        public static void Zahlen(int[] numbers)
        {
            int posSum = 0;
            int negCount = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Geben Sie das {0}. Element ein:", i + 1);
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    numbers[i] = input;
                }
                else
                {
                    Console.WriteLine("Ungültige Zahl, wird als 0 gespeichert.");
                    numbers[i] = 0;
                }
            }

            Console.WriteLine("\nFolgendes wurde eingegeben:");
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            System.Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    negCount++;
                }
                else
                {
                    posSum += numbers[i];
                }
            }

            int[] zahlenAusgabe = new int[2];

            zahlenAusgabe[0] = posSum;
            zahlenAusgabe[1] = negCount;


            System.Console.WriteLine($"\n[{zahlenAusgabe[0]}, {zahlenAusgabe[1]}]");
        }
    }
}