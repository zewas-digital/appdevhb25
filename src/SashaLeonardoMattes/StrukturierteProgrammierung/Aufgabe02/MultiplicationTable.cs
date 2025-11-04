using System;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe02
{

    public class MultiplicationTable
    {

        public static void StartMultiplicationTable()
        {
            Console.WriteLine("----------Aufgabe 02----------");
            bool input;
            int number;

            Console.WriteLine("Welche Malreihe möchtest du?");
            do
            {
                input = int.TryParse(Console.ReadLine(), out number);

                if (input == false)
                {
                    Console.WriteLine("Bitte nur Ganzzahlen eingeben");
                }
            } while (input == false);
            
            Multipliate(number);
        }

        static void Multipliate(int number)
        {
            int result;
            for (int i = 0; i < 11; i++)
            {
                result = i * number;
                Console.WriteLine(i + " * " + number + " = " + result);
            }
        }
    }
}
