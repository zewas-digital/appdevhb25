using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe04
{

    public class DividableTest
    {

        public static void StartDividableTest()
        {
            Console.WriteLine("----------Aufgabe 04----------");
            int divider;
            int start;
            int end;
            bool isZero;

            do
            {
                Console.WriteLine("Gib einen Teiler ein:");
                divider = checkUserInput();
                if (divider == 0)
                {
                    Console.WriteLine("Der Teiler darf nicht 0 sein!");
                    isZero = true;
                }
                else
                {
                    isZero = false;
                }
            } while (isZero);
            

            Console.WriteLine("Gib einen Startwert für das Intervall ein:");
            start = checkUserInput();

            Console.WriteLine("Gib einen Endwert für das Intervall ein:");
            end = checkUserInput();


            PrintDividable(divider, start, end);
        }

        static void PrintDividable(int divider, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (i % divider == 0)
                {
                    Console.WriteLine(i);
                }
            }
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
