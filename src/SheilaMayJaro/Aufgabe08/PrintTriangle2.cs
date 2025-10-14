using System; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe08
{
    public class PrintTriangle2
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 8)");
            int size = 5;

            for (int i = 0; i <= size; i++)
            {
                for (int j = size; j > i; j--)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
            for (int y = 0; y <= size; y++)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write(" ");
                }

                for (int x = size; x > y; x--)
                {
                    Console.Write("x");
                }
                Console.WriteLine();

            }
            for (int y = 0; y <= size; y++)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write("x");
                }
                for (int x = size; x > y; x--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int y = 0; y <= size; y++)
            {
                for (int x = size; x > y; x--)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < y; x++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }
    }
}