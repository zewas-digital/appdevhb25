
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe07
{
    public class PrintTriangle
    {
        public static void Triangle(int laenge)
        {
            char zeichen = 'x';

            for (int i = 0; i < laenge; i++)
            {
                for (int j = laenge; j > i; j--)
                {
                    Console.Write(zeichen);
                }
                Console.WriteLine();
            }
        }
    }
}
