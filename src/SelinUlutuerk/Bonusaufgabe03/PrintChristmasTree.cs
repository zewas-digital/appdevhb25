using System;
using System.Globalization;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe03
{
    class PrintChristmasTree
    {
        public static void StartPrintChristmasTree(int width)
        {
            int number = (width);
            int count = number - 1;

            //Triangle  
            for (int y = 1; y <= number; y++)
            {
                for (int x = 1; x <= count; x++)
                    Console.Write(" ");
                count--;
                for (int x = 1; x <= 2 * y - 1; x++)
                    Console.Write("*");
                Console.WriteLine();
            }

            //width
            for (int z = 0; z < (width * 2) - 1; z++)
            {
                if ((z % 2) != 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("O");
                }

            }
            Console.WriteLine();
            
            //Stamm
            for (int y = 0; y < 2; y++)
            {
                for (int x = 0; x <= width / 2 + 1 ; x++)
                {
                    Console.Write(" ");
                }

                for (int z = 0; z < width / 2 + 1; z++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }
        }
    }
}