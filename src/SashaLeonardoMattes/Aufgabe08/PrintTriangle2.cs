using System;
using System.Data;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe08
{

    public class PrintTriangle2
    {

        public static void StartPrintTriangle2()
        {
            Console.WriteLine("----------Aufgabe 08----------");
            int size;


            Console.WriteLine("Gib eine Größe ein:");
            size = checkUserInput();

            CreateTriangle(size);
        }

        static void CreateTriangle(int size)
        {
            Console.WriteLine("Lage 1:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Lage 2:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (size - i + j < size)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("x");
                    }

                }
                Console.WriteLine("");
            }

            Console.WriteLine("Lage 3:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j < size - i-1 )
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("x");
                    }

                }
                Console.WriteLine("");
            }

            Console.WriteLine("Lage 4:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (size - i + j-1 < size)
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
