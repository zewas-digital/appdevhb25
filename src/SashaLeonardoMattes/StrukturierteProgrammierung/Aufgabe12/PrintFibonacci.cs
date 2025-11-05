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

            WriteFibonacci(amount, 0, 1, true);
        }

        static void WriteFibonacci(int amount, int fibo1par, int fibo2par, bool isFirstRun)
        {
            int fibo1;
            int fibo2;
            int result;

            if (isFirstRun == true)
            {
                Console.WriteLine("Fibonacci Folge:");
                Console.WriteLine("0");
                Console.WriteLine("1");
            }

            result = fibo1par + fibo2par;
            Console.WriteLine(result);
            amount--;
            fibo1 = fibo2par;
            fibo2 = result;

            if (amount > 0)
            {
                WriteFibonacci(amount, fibo1, fibo2, false);
            }
            
            /*for (int i = 0; i < amount; i++)
            {
                result = fibo1 + fibo0;
                Console.WriteLine(result);
                fibo0 = fibo1;
                fibo1 = result;

            }*/
        }

    }
}
