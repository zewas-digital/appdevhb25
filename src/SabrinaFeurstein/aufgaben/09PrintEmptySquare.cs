
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class PrintEmptySquare
    {
        public static void square(int laenge)
        {
            int a = 0;
            char zeichen = 'x';
            char leer = ' ';

            for (int i = 1; i < laenge; i++)
            {
                if (a == 0)
                {
                    for (int x = 0; x < laenge; x++)
                    {
                        Console.Write(zeichen);
                        a++;
                    }
                }
                else
                {
                    Console.WriteLine();
                    for (int y = 1; y < laenge; y++)
                    {
                        Console.Write(zeichen);
                        for (int j = 2; j < laenge; j++, y++)
                        {
                            Console.Write(leer);
                        }
                        Console.Write(zeichen);
                    }
                }
            }
            Console.WriteLine();
            for (int x = 0; x < laenge; x++)
            {
                Console.Write(zeichen);
            }
        }
    }
}