using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe08
{
    class PrintTriangle
    {
        public static void Start()
        {
            int seite = 5;
            
            for (int y = seite; y > 0; y--)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }
    }
}