using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class PrintChristmasTree
    {
        public static void Tree(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j <= i * 2; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(" 0");
            }
            Console.WriteLine();
            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j < size / 1.3; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < size / 2; j++)
                {
                    Console.Write('+');
                }
                Console.WriteLine();
                if (size <= 5)
                {
                    i++;
                }
            }
        }
    }
}