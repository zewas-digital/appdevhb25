using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using Appdevhb25.JulianMatt.Aufgabe03;

namespace Appdevhb25.JulianMatt.Aufgabe31
{
    public class RandomNumberArray
    {

        public static void Start31()
        {
            int[] number = NumberList();
            Console.Clear();
            NumberListing(number);
            NumberChoosing(number);

        }

        public static int ZahlenAnzahl()
        {
            Console.WriteLine("Wie viele nummern wollen sie benutzen?");

            int countOfNumbers = Convert.ToInt32(Console.ReadLine());
            return countOfNumbers;
        }

        public static int[] NumberList()
        {

            int[] number;

            int countOfNumbers = ZahlenAnzahl();

            Console.WriteLine("Bitte geben sie ihre " + countOfNumbers + " Zahlen an :");

            number = new int[countOfNumbers];

            for (int j = 0; j < countOfNumbers; j++)
            {
                number[j] = Convert.ToInt32(Console.ReadLine());
            }
            return number;
        }

        public static void NumberListing(int[] number)
        {
            Console.WriteLine("Anzahl der Elemente: " + number.Length);
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

        }

        public static void NumberChoosing(int[] number)
        {
            Max(number);
            Min(number);
            Average(number);
            Sum(number);


        }

        public static void Max(int[] number)
        {
            int whatIsMax = number[0];

            for (int i = 1; i < number.Length; i++)
            {
                if (number[i] > whatIsMax)
                {
                    whatIsMax = number[i];
                }
            }

            Console.WriteLine("Der größte Wert ist: " + whatIsMax);
        }

        public static void Min(int[] number)
        {
            int whatIsMin = number[0];

            for (int i = 1; i < number.Length; i++)
            {
                if (number[i] < whatIsMin)
                {
                    whatIsMin = number[i];
                }
            }

            Console.WriteLine("Der kleinste Wert ist: " + whatIsMin);
        }
        public static void Average(int[] number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }

            double whatIsAverage = (double)sum / number.Length;
            Console.WriteLine("Der Durchschnitt ist: " + whatIsAverage);
        }

        public static void Sum(int[] number)
        {
            int whatIsSum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                whatIsSum += number[i];
            }

            Console.WriteLine("Die Summe ist: " + whatIsSum);
        }
    }



}