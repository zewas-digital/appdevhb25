using System;

namespace Appdevhb25.NoahHois.Aufgabe7
{
    public class PrintTriangle
    {
        public static void Aufgabe7()
        {
            int zeilen = 5, spalten = 5;

            for (int x = 0; x < spalten; x++)
            {
                for (int y = 0; y < zeilen; y++)
                {
                    if (x <= y)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}