using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe12
{

    public class PrintFibonacci
    {

        public static void StartPrintFibonacci()
        {
            Console.WriteLine("----------Aufgabe 12----------");

            Console.WriteLine("Gib ein wie lange du die Fibonacci-Reihe sehen willst");
            int amount = Helper.checkUserInputInteger();

            WriteFibonacci(amount);
        }

        static void WriteFibonacci(int amount)
        {
            int fibo0 = 0;
            int fibo1 = 1;
            int result;
            for (int i = 0; i < amount; i++)
            {
                result = fibo1 + fibo0;
                Console.WriteLine(result);
                fibo0 = fibo1;
                fibo1 = result;

            }
        }

    }
}
