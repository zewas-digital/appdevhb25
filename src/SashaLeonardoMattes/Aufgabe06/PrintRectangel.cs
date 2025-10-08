using System;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe06
{

    public class PrintRectangle
    {

        public static void StartPrintRectangle()
        {
            Console.WriteLine("----------Aufgabe 06----------");
            int height;
            int length;

            System.Console.WriteLine("Aufgabe 5:");
            Console.WriteLine("Gib eine Höhe ein:");
            height = checkUserInput();

            Console.WriteLine("Gib eine Länge ein:");
            length = checkUserInput();


            WriteRectangle(height, length);
        }

        static void WriteRectangle(int height, int length)
        {
            for (int i = 0; i < height; i++)
            {
                for (int counter = 0; counter < length; counter++)
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
