namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe13
{
    public class PrintDeltoid
    {
        public static void Start(int size)
        {
            for (int y = -size + 1; y < size; y++)
            {
                for (int x = -size + 1; x < size; x++)
                {
                    if (x + y == -size + 1)
                    {
                        Console.Write("x");
                    }
                    else if (x + y == size - 1)
                    {
                        Console.Write("x");
                    }
                    else if (x * -1 + y == size - 1)
                    {
                        Console.Write("x");
                    }
                    else if (y * -1 + x == size - 1)
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
