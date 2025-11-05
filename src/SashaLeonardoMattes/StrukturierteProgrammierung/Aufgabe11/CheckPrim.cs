using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe11
{

    public class PrimTest
    {

        public static void StartPrimTest()
        {
            Console.WriteLine("----------Aufgabe 11----------");
            int number;

            Console.WriteLine("Gib eine Zahl ein:");
            number = Helper.checkUserInputInteger();

            PrimCheck(number);
        }

        static void PrimCheck(int number)
        {
            if (number < 2)
            {
                Console.WriteLine("-1");
                return;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("-1");
                    return;
                }
            }
            Console.WriteLine("1");
        }

    }
}
