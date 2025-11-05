using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe07
{
    class PrintEmptySquare
    {
        public static void Start()
        {
            int seite = 5;

            for(int y = 0; y < seite; y++)
            {
                for(int x = 0; x < seite; x++)
                {
                    if (y == 0 || x == 0 || y == seite - 1 || x == seite - 1)
                    {
                        Console.Write("* "); 
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
               Console.WriteLine();
            }
        }
    }
} 