
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe10
{
    public class PrintTriangle
    {
        public static void Triangle(int length)
        {
            char zeichen = 'x';
            char leer = ' ';

            for (int i = 0; i < length - 1; i++)
            {
                Console.Write(new string(leer, length - 1 - i));
                Console.Write(zeichen);

                if (i > 0)
                {
                    Console.Write(new string(leer, 2 * i - 1));
                    Console.Write(zeichen);
                }

                Console.WriteLine();
            }

            Console.WriteLine(new string(zeichen, 2 * length - 1));



            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1 - i; j++)
                {
                    Console.Write(leer);
                }

                Console.Write(zeichen);

                if (i > 0)
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        Console.Write(leer);
                    }
                    Console.Write(zeichen);
                }

                Console.WriteLine();
            }

            for (int i = 0; i < 2 * length - 1; i++)
            {
                Console.Write(zeichen);
            }
            Console.WriteLine();
        }
    }
}


