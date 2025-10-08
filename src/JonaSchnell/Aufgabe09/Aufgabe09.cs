namespace Appdevhb25.JonaSchnell.Aufgabe09
{
    public class Aufgabe09

    {

        public static void Start09()
        {
            int size = 5;
            int spaces = 1;
            int line = 0;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (line == 1)
                    {
                        Console.WriteLine("");
                }
                    if (spaces == 1)
                    {
                        Console.Write("*");
                    }
                    if (spaces == size - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("x");
                    }
                    spaces = spaces + 1;
                }
            }
        }
    }
}