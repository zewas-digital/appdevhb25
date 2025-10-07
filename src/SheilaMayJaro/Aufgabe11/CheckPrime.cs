using System;

namespace Appdevhb25.SheilaMayJaro.Aufgabe11
{
    public class CheckPrime
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 11)");
        }
        public static int PrimeNumber(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return +1;
                }
            }
            return -1;             
        }
    }
}