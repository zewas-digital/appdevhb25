namespace Appdevhb25.JonaSchnell.Aufgabe08
{
    public class Aufgabe08

    {

        public static void Start08()
        {
            Console.WriteLine("Wie groß soll dein Dreieck sein?");
            int size = Convert.ToInt32(Console.ReadLine());
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
            }
        }
    }
}