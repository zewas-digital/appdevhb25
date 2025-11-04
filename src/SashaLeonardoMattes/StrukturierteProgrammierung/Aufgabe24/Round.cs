using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe24
{

    public class Round
    {

        public static void StartRound()
        {
            Console.WriteLine("----------Aufgabe 24----------");

            Console.WriteLine("Gib eine Kommazahl ein:");
            double number = Helper.checkUserInputDouble();
            Console.WriteLine("Auf wie viele Kommastellen möchtest du runden:");
            int decimals = Helper.checkUserInputInteger();

            MyRound(number, decimals);
        }

        public static void MyRound(double numberInput, int decimals)
        {
            double result;
            int number = (int)(numberInput * Math.Pow(10, decimals));
            int lastNumber;

            lastNumber = (int)(numberInput * Math.Pow(10, decimals + 1)) % 10;
            if (lastNumber > 4)
            {
                number+=1;
                result = number / Math.Pow(10, decimals);
            }
            else
            {
                result = number / Math.Pow(10, decimals);
            }

            Console.WriteLine(result);
            
        }

    }
}
