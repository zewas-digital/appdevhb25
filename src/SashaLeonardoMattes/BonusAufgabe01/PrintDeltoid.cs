using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq.Expressions;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe01
{

    public class PrintDeltoid
    {

        public static void StartPrintDeltoid()
        {
            Console.WriteLine("----------Bonusaufgabe 01----------");
            int size;

            Console.WriteLine("Gib eine Größe ein:");
            size = checkUserInput();
            Console.WriteLine("Gib eine Zeichen ein:");
            char symbol = checkUserInputChar();
            WriteDeltoid(size, symbol);
        }

        static void WriteDeltoid(int size, char symbol)
        {
            int correction; //für gerade/ungerade größe

            if (size % 2 == 0)
            {
                correction = 1;
            }
            else
            {
                correction = 0;
            }

            int mid = size / 2;

            for (int i = 0; i < size + correction; i++)
            {
                for (int j = 0; j < size + 1; j++)
                {
                    if (j == mid - i || j == (mid - i) * -1 || j == size - (mid - i))
                    {
                        Console.Write(symbol);
                    }
                    else if (j == mid + (size - i))
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(".");
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

                if (result < 3)
                {
                    Console.WriteLine("Du musst mindestens 3 eingeben");
                }

            } while (checkInput == false && result < 3);

            return result;
        }
        
        static char checkUserInputChar()
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

    }
}
