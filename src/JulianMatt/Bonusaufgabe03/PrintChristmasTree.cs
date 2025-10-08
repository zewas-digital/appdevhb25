using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Appdevhb25.JulianMatt.Bonusaufgabe03
{
    public class PrintChirstmasTree
    {
        private static int decoreSolution = 5;
        private static int size = 0;
        public static void BonusStart03()
        {
            Eingabe();
            // Star();
            // Tree();
            Stam();
        }

        public static void Eingabe()
        {
            Console.WriteLine("Geben sie die größe des Baumes an");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hier ist ihr Christmastree");
        }

        public static void Star()
        {
            if (size >= 7)
            {
                for (int i = 0; i <= size / 2; i++)
                {
                    for (int j = 0; j <= size - i; j++)
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
        public static void Tree()
        {
            for (int i = 2; i <= size; i++)
            {
                for (int j = 0; j <= size - i; j++)
                {
                    Console.Write(" ");
                }

                if (i == 2)
                {
                    Console.Write("+");
                }
                else if (i == 3)
                {
                    Console.Write("x");
                    Console.Write("0");
                    Console.Write("x");
                }
                else
                {
                    Console.Write("x");
                    Console.Write("x");

                    for (int j = 3; j <= 2 * i - decoreSolution; j++)
                    {
                        Console.Write("0x");
                        decoreSolution = decoreSolution + 1;
                    }
                    Console.Write("x");

                }
                Console.WriteLine();
            }
            for (int l = 1; l <= size; l++)
            {
                Console.Write("0 ");
            }
        }


        public static void Stam()
        {
            Console.WriteLine();

            for (int l = 1; l <= size / 4; l++)
            {
                for (int j = 0; j <= size / 5; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= size / 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


    }
}
