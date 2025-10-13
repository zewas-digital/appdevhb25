using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe07
{

    public class RandomNumberArray
    {

        public static void StartRandomNumberArray()
        {
            Console.WriteLine("----------BonusAufgabe 07----------");

            System.Console.WriteLine("Wie groß soll das Zufallsarray sein:");

            Random rndGen = new Random();
            int size = Helper.checkUserInputInteger();

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = rndGen.Next(0, 100 + 1); //rndGen ist Untergrenze, Obergrenze allerdings Obergrenze exklusiv also +1 wenn 100 möglich sein soll
            }

            System.Console.WriteLine("Anzahl der Elemente: " + size);
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("Größter Wert: " + getMaxValue(numbers));
            System.Console.WriteLine("Kleinster Wert: " + getMinValue(numbers));
            System.Console.WriteLine("Durchschnitt aller Werte: " + getAverageValue(numbers));
            System.Console.WriteLine("Summe aller Werte: " + getSumValue(numbers));
        }

        public static int getMaxValue(int[] numbers)
        {
            int maxValue = numbers[0];
            foreach (var number in numbers)
            {
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }
            return maxValue;
        }

        public static int getMinValue(int[] numbers)
        {
            int minValue = numbers[0];
            foreach (var number in numbers)
            {
                if (number < minValue)
                {
                    minValue = number;
                }
            }
            return minValue;
        }

        public static double getAverageValue(int[] numbers)
        {
            double average = 0;
            foreach (var number in numbers)
            {
                average += number;
            }
            return average / numbers.Length;
        }

         public static int getSumValue(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

    }
}
