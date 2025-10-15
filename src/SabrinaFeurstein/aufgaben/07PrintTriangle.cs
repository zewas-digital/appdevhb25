using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
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