using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe25
{

    public class Validation
    {

        public static void StartValidation()
        {
            Console.WriteLine("----------Aufgabe 25----------");
            Console.WriteLine("Gib einen Integer ein:");
            int number = checkUserInputInteger();
            Console.WriteLine("Gib einen Char ein:");
            char character = checkUserInputChar();
            Console.WriteLine("Gib einen Double ein:");
            double numberComma = checkUserInputDouble();
            Console.WriteLine("Gib einen Long ein:");
            ulong numberUlong = checkUserInputULong();
            
        }

        public static int checkUserInputInteger()
        {
            bool checkInput;
            int result;
            do
            {
                checkInput = int.TryParse(Console.ReadLine(), out result);

                if (checkInput == false)
                {
                    Console.WriteLine("Bitte nur Ganzzahlen eingeben");
                }
            } while (checkInput == false);

            return result;
        }


        public static char checkUserInputChar()
        {
            bool checkInput;
            char result;
            do
            {
                checkInput = char.TryParse(Console.ReadLine(), out result);

                if (checkInput == false)
                {
                    Console.WriteLine("Bitte nur ein Zeichen eingeben");
                }
            } while (checkInput == false);

            return result;
        }

        public static ulong checkUserInputULong()
        {
            bool checkInput;
            ulong result;
            do
            {
                checkInput = ulong.TryParse(Console.ReadLine(), out result);

                if (checkInput == false)
                {
                    Console.WriteLine("Bitte nur positive Ganzzahlen eingeben");
                }
            } while (checkInput == false);

            return result;
        }

        public static double checkUserInputDouble()
        {
            bool checkInput;
            double result;
            do
            {
                checkInput = double.TryParse(Console.ReadLine(), out result);

                if (checkInput == false)
                {
                    Console.WriteLine("Bitte nur Zahlen eingeben");
                }
            } while (checkInput == false);

            return result;
        }

    }
}
