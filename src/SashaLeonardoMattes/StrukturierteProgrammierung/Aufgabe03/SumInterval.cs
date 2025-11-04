using System;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe03
{

    public class SumInterval
    {

        public static void StartSumInterval()
        {
            Console.WriteLine("----------Aufgabe 03----------");
            int start;
            int end;


            Console.WriteLine("Gib einen Startwert für das Intervall ein:");
            start = checkUserInput();

            Console.WriteLine("Gib einen Endwert für das Intervall ein:");
            end = checkUserInput();


            CalcIntervalSum(start, end);
        }

        static void CalcIntervalSum(int start, int end)
        {
            int result = start;
            for (int i = start; i < end; i++)
            {
                result += i + 1;
            }
            Console.WriteLine("Summe über Intervall: " + result);
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
