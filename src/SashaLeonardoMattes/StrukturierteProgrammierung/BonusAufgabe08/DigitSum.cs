using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe08
{

    public class DigitSum
    {

        public static void StartDigitSum()
        {
            Console.WriteLine("----------BonusAufgabe 08----------");

            System.Console.WriteLine("Gib eine Zahl ein:");
            int number = Helper.checkUserInputInteger();

            string input = number.ToString();
            int lenght = input.Length;

            int digitSum = 0;

            for (int i = 0; i < lenght; i++)
            {
                digitSum += number % 10;
                number /= 10;
            }

            System.Console.WriteLine("Ziffernsumme: " + digitSum);
        

        }

    }
}
