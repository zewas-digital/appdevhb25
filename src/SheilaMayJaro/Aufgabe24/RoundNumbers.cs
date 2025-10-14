using System;

namespace Appdevhb25.SheilaMayJaro.Aufgabe24
{
    public class RoundNumbers
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 24a)");
            PrintRoundNumbers(33.33333m, 4);
            PrintRoundNumbers(222.222222m, 3);
            PrintRoundNumbers(1.112357m, 4);
            PrintRoundNumbers(45.235648565m, 6);
            Console.WriteLine("Aufgabe 24b)");
            PrintRoundNumbersMethodB(89.25698m, 3);
            PrintRoundNumbersMethodB(1354.456786546m, 6);

        }
        public static void PrintRoundNumbers(decimal number, int decimalPlaces)
        {
            Console.WriteLine($"Result with {decimalPlaces} digits = {number.ToString($"F{decimalPlaces}")}");
        }
        public static void PrintRoundNumbersMethodB(decimal number, int decimalPlaces)
        {
            decimal wholeNumber = number * (decimal) Math.Pow(10, decimalPlaces + 1);
            decimal remains = wholeNumber % 10;
            if (remains >= 5)
            {
                decimal newNumber = wholeNumber + 10;
                decimal newerNumber =  newNumber / 10;
                int wholeNumber2 = (int)newerNumber;
                Console.WriteLine(wholeNumber2); 
                decimal numberWithXDigits = wholeNumber2 *(decimal) Math.Pow(10, -decimalPlaces);
                Console.WriteLine(numberWithXDigits); 
                Console.WriteLine($"Result with {decimalPlaces} digits = {numberWithXDigits}");
            }
            else
            {
                int wholeNumber2 = (int)wholeNumber;
                decimal numberWithXDigits = wholeNumber2 * (decimal)Math.Pow(10, -decimalPlaces);
                Console.WriteLine($"Result with {decimalPlaces} digits = {numberWithXDigits}");
            }
        }
    }
}