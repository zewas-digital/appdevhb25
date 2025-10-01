using System;
using System.Data;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe10
{

    public class PrintTriangle3
    {

        public static void StartPrintTriangle3()
        {
            Console.WriteLine("----------Aufgabe 10----------");
            int size;


            Console.WriteLine("Gib die Länge der Katheten ein:");
            size = Helper.checkUserInputInteger();

            CreateTriangle(size);
        }

        static void CreateTriangle(int size)
        {
            int mid = size / 2;
            for (int i = 0; i < size / 2; i++)
            {
                for (int j = 0; j < size + 1; j++)
                {
                    if (j == mid - i || j == (mid - i) * -1 || j == size - (mid - i) ||i == size /2 -1)
                    {
                        Console.Write("x");
                    }
                    else if (j == mid + (size - i))
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine("");


            }
            Console.WriteLine();
        }

    }
}
