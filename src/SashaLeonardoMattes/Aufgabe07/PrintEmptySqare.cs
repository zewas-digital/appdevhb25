using System;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe07
{

    public class PrintEmptySqare
    {

        public static void StartPrintEmptySqare()
        {
            Console.WriteLine("----------Aufgabe 07----------");
            int size;

            Console.WriteLine("Gib eine Größe ein:");
            size = checkUserInput();

            WriteEmptySqare(size);
        }

        static void WriteEmptySqare(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int counter = 0; counter < size; counter++)
                {
                    if(i == 0 || i == size-1 || counter == 0 || counter == size-1)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
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
