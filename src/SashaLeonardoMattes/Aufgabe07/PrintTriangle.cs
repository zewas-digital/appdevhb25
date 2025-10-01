using System;
using System.Data;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe07
{

    public class PrintTriangle
    {

        public static void StartPrintTriangle()
        {
            Console.WriteLine("----------Aufgabe 08----------");
            int size;


            Console.WriteLine("Gib eine Größe ein:");
            size = checkUserInput();

            CreateTriangle(size);
        }

        static void CreateTriangle(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine("");
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
