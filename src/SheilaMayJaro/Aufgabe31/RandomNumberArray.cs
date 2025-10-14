using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Appdevhb25.SheilaMayJaro.Aufgabe31
{
    public class RandomNumberArray
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 31)");
            int[] numbers = new int[5];
            numbers[0] = 54;
            numbers[1] = 21;
            numbers[2] = 13;
            numbers[3] = 96;
            numbers[4] = 3;
            Console.WriteLine($"Anzahl der Elemente {numbers.Length}");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();
            // Größter Wert berechnen 
            int maxVal = 0;
            foreach ( int num in numbers)
            {
                if (num > maxVal)
                {
                    maxVal = num; 
                }
            }
            Console.WriteLine($"Der größte Wert ist {maxVal}.");
            //Kleinster Wert berechnen 
            int minVal = numbers.Min();
            foreach ( int num in numbers)
            {
                if (num < minVal)
                {
                    minVal = num; 
                }
            }
            Console.WriteLine($"Der kleinste Wert ist {minVal}.");
            //Summe aller Werte
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Die Summe aller Werte ist {sum}.");
            //Durchschnitt aller Werte
            int average = sum / numbers.Length;
            Console.WriteLine($"Der Durchschnitt aller Werte ist {average}"); 
        }
    }
}