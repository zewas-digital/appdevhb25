using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe05
{

    public class CalculatePi
    {

        public static void StartCalculatePi()
        {
            Console.WriteLine("----------BonusAufgabe 05----------");

           
            LeibnizSeries();
            Nilakantha();
        }

        public static void LeibnizSeries()
        {
            double pi = 0;
            int divider = 1;

            Console.WriteLine("Wie genau möchtest du Pi berechnen? (Größere Zahl = genauere Berechnung)");
            ulong iterationAmount = Helper.checkUserInputULong();


            for (ulong counter = 2; iterationAmount > counter - 2; counter++)
            {
                if (counter % 2 == 0)
                {
                    pi += 4.0 / divider; //.0 damit ich double als ergebnis bekomme
                }
                else
                {
                    pi -= 4.0 / divider;
                }
                divider += 2;
            }
            Console.WriteLine("Leibniz: " + pi);
        }
        
        public static void Nilakantha()
        {
            double pi = 3;
            int divider = 2;

            Console.WriteLine("Wie genau möchtest du Pi berechnen? (Größere Zahl = genauere Berechnung)");
            ulong iterationAmount = Helper.checkUserInputULong();


            for (ulong counter = 2; iterationAmount > counter - 2; counter++)
            {
                if (counter % 2 == 0)
                {
                    pi += 4.0 / (divider*(divider+1)*(divider+2)); //.0 damit ich double als ergebnis bekomme
                }
                else
                {
                    pi -= 4.0 / (divider*(divider+1)*(divider+2));
                }
                divider += 2;
            }
            Console.WriteLine("Nilakantha: " + pi);
        }

    }
}
