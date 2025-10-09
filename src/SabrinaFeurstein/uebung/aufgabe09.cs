using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using Appdevhb25.SabrinaFeurstein.uebung;

namespace Appdevhb25.SabrinaFeurstein.uebung
{
    public class aufgabe09
    {
        public static void PrintEmptySquare(int laenge)
        {
            Console.WriteLine("Seitenlänge: " + laenge);

            for (int i = 0; i < laenge; i++)
            {
                Console.Write('x');
            }
            Console.WriteLine();

            for (int i = 2; i < laenge; i++)
            {
                Console.Write('x');
                for (int j = 2; j < laenge; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine('x');
            }

            for (int i = 0; i < laenge; i++)
            {
                Console.Write('x');
            }
        }
    }
}
