namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe08
{
    public class PrintTriangle2
    {
        public static void Start(int size)
        {
            for (int y = 0; y < size; y++)
            {

                for (int x = 0; x < size; x++)
                {

                    if (x < y)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("x");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int y = 0; y < size; y++)
            {

                for (int x = 0; x < size; x++)
                {

                    if (x > y)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("x");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int y = 0; y < size; y++)
            {

                for (int x = size; x > 0; x--)
                {

                    if (x > y)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int y = 0; y < size; y++)
            {

                for (int x = 0; x < size; x++)
                {

                    if (x < size - y - 1)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("x");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}