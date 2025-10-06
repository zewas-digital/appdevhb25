
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class PrintTriangle2
    {
        public static void Triangle(int laenge)
        {
            char zeichen = 'x';
            char leer = ' ';

            for (int i = 0; i < laenge; i++)
            {
                for (int j = laenge; j > i; j--)
                {
                    Console.Write(zeichen);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < laenge; i++)
            {
                for (int l = 0; l < i; l++)
                {
                    Console.Write(leer);
                }
                for (int j = laenge; j > i; j--)
                {
                    Console.Write(zeichen);
                }
                Console.WriteLine();
            }

            for (int i = 0; i <= laenge; i++)
            {
                for (int l = laenge; l > i; l--)
                {
                    Console.Write(leer);
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(zeichen);
                }
                Console.WriteLine();
            }

            for (int i = 0; i <= laenge; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(zeichen);
                }
                Console.WriteLine();
            }
        }
    }
}
