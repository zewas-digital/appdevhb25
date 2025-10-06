using System;

namespace Appdevhb25.NoahHois.Aufgabe15
{
    public class PrintChristmasTree
    {
        public static void Aufgabe15()
        {
            Console.Write("Geben Sie die Groeße des Baums ein: ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int y = 0; y < size; y++)
            {

                for (int x = size * -1 + 1; x < size; x++)
                {
                    // Console.WriteLine(Math.Abs(x) + "-" + Math.Abs(y));
                    if (Math.Abs(x) == Math.Abs(y)||(x <= y && Math.Abs(x)<= y))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for (int b = size*-1 +1; b < size; b++)
            {
            Console.Write("0");
            }
        }
    }
}