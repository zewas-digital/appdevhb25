namespace Appdevhb25.JonaSchnell.Aufgabe08
{
    public class Aufgabe08

    {

        public static void Start08()
        {
            Console.WriteLine("Wie groß soll dein Dreieck sein?");
            int size = Convert.ToInt32(Console.ReadLine());
            //1
            for (int y = 0; y < size; y++)
            {
                for (int x = size; x > y; x--)
                {
                    if (y < x)
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
            Console.WriteLine();
            //2
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if (x < y)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("x");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //3
            for (int y = 0; y < size; y++)
            {
                for (int x = size; x > 0; x--)
                {
                    if (x - 1 > y)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("x");
                    }
                }
                Console.WriteLine();
            }
            //4
            for (int y = 0; y <= size; y++)
            {
                for (int x = 0; x <= size; x++)
                {
                    if (x < y)
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