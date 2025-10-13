using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe23
{
    class bis100
    {
        public static void Start()
        {
            
            for (double i = 0.0 ; i <= 100.0; i+= 0.1)
            {
                Console.WriteLine($"Result 1 digit = {i:F1}");

                Console.WriteLine($"Result 2 digit = {i,6:F2}");
            }
        }
    }
}