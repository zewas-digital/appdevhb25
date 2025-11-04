using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe49
{

    public class ProcessNumbers
    {

        public static void StartProcessNumbers()
        {
            Console.WriteLine("----------Aufgabe 49----------");

            System.Console.WriteLine("Wie viele Zahlen möchtest du eingeben?");
            int amountNumbers = Helper.checkUserInputInteger();
            int[] numbers = new int[amountNumbers];

            for (int i = 0; i < amountNumbers; i++)
            {
                System.Console.WriteLine($"Gib die {i + 1} . Zahl ein:");
                numbers[i] = Helper.checkUserInputInteger();
            }
            
            PrintProcessNumbersResult(numbers);
        }

        public static void PrintProcessNumbersResult(int[] numbers)
        {
            int[] result = new int[2];
            foreach (var number in numbers)
            {
                if (number < 0)
                {
                    result[0]++;
                }
                else
                {
                    result[1] += number;
                }
            }

            System.Console.WriteLine(result[0] + ", " + result[1]);
        }

    }
}
