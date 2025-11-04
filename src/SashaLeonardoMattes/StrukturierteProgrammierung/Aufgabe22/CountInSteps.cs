using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe22
{

    public class CountInSteps
    {

        public static void StartCountInSteps()
        {
            Console.WriteLine("----------Aufgabe 22----------");

            for (float i = 0f; i <= 100; i += 0.1f)
            {
                Console.WriteLine("Result 1 digit = {0,6:F1}", i);
                Console.WriteLine("Result 2 digit = {0,6:F2}", i);
            }

        }

    }
}
