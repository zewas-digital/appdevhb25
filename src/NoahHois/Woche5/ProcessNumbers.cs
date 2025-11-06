using System;
using System.IO;
using System.Globalization;
using Appdevhb25.NoahHois.Aufgabe3;

namespace Appdevhb25.NoahHois.Aufgabe63
{
    public class ProccesNumbers
    {
        public static int[] Start(int[] numbers)
        {
            int CountOfNegativeValues = 0;
            int SumOfPositiveValues = 0;
            numbers = new[] { 100, -6, 23, -87, 1, 0, 77, -543 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0 || 0 <= 100)
                {
                    SumOfPositiveValues += SumOfPositiveValues;
                }
                if (numbers[i] == 0 || 0 > -543)
                {
                    CountOfNegativeValues++;
                }
                System.Console.WriteLine(CountOfNegativeValues);
                System.Console.WriteLine(SumOfPositiveValues);
            }
            return numbers;
        }
    }
}