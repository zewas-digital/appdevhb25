using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe19
{

    public class Sum20To50
    {

        public static void StartSum20To50()
        {
            Console.WriteLine("----------Aufgabe 19----------");

            short sum1 = 20;
            short sum2;
            for (short i = 21; i < 51; i++)
            {
                sum2 = (short)(sum1 + i);
                Console.WriteLine(sum1 + " + " + i + " = " + sum2);
                sum1 = sum2;
                
            }

        }

    }
}
