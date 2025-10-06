using System;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe05
{

    public class PrintLine
    {

        public static void StartPrintLine()
        {
            Console.WriteLine("----------Aufgabe 05----------");
            int amount;

            Console.WriteLine("Wie viel x möchtst du ausgeben?");
            amount = checkUserInput();

            PrintX(amount);
        }

        static void PrintX(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write("x");
            }
            Console.WriteLine("");
        }

        static int checkUserInput()
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

    }
}
