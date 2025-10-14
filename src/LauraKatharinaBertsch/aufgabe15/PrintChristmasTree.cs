using System.Formats.Asn1;
using System.Runtime.CompilerServices;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe15
{
    public class PrintChristmasTree
    {
        public static void Start(int size)
        {

            for (int y = -size + 1; y <= 0; y++)
            {
                for (int x = -size + 1; x < size; x++)
                {
                    if (y == 0)
                    {
                        Console.Write("O");
                    }
                    else if (Math.Abs(x) + Math.Abs(y) < size)
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

            for (int i = 1; i < size - 2; i++)
            {
                for (int j = -size + 1; j < size - 1; j++)
                {
                    if (Math.Abs(j) <= size - 4)
                    {
                        Console.Write("+");
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