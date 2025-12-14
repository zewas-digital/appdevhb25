using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class PrintDeltoid
    {
        public static void Deltoid(int size)
        {
            char zeichen = 'x';
            char leer = ' ';

            for (int i = 0; i < size / 2; i++)
            {
                for (int j = 0; j < size / 2 - i; j++)
                {
                    Console.Write('.');
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

                for (int j = 0; j < size / 2 - i; j++)
                {
                    Console.Write('.');
                }

                Console.WriteLine();
            }

            for (int i = size / 2; i >= 0; i--)
            {
                for (int j = 0; j < size / 2 - i; j++)
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
        }
    }
}