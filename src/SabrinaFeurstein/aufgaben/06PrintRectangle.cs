
using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe06
{
    public class PrintRectangle
    {
        public static void Start()
        {
            int höhe = 5;
            int länge = 3;
            char zeichen = 'x';

            Console.WriteLine("Höhe:" + höhe);
            Console.WriteLine("Länge:" + länge);

            for (int i = 0; i < höhe; i++)
            {
                string zeile = new string(zeichen, länge);
                Console.WriteLine(zeile);
            }

            int zeilen = 5;
            int spalten = 3;

            for (int y = 0; y < zeilen; y++)
            {
                for (int x = 0; x < spalten; x++)
                {
                    Console.Write('+');
                }
                Console.WriteLine();
            }
        }
    }
}