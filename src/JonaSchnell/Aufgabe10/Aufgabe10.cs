using System.Drawing;

namespace Appdevhb25.JonaSchnell.Aufgabe10
{
    public class Aufgabe10

    {

        public static void Start10()
        {
            Console.WriteLine("Wie groß soll dein Dreieck sein?");
            int size = Convert.ToInt32(Console.ReadLine());
            if (size == 1)
            {
                Console.WriteLine("x");

            }
            for (int i = 0; i < size - 1; i++)
            {
                int spaces = size - 1 - i;
                Console.Write(new string(' ', spaces));
                Console.Write('x');

                if (i > 0)
                {
                    int spaces2 = 2 * i - 1;
                    Console.Write(new string(' ', spaces2));
                    Console.Write('x');
                }

                Console.WriteLine();
            }
            Console.WriteLine(new string('x', 2 * size - 1));
        }
    }
}