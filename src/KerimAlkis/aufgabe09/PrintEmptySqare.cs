namespace Appdevhb25.KerimAlkis.Aufgabe09
{
    public class PrintEmptySqare
    {
        public static void Start(int hoehe, int breite)
        {
            for (int i = 0; i < hoehe; i++)
            {
                for (int y = 0; y < breite; y++)
                {
                    if (i == 0 || i == hoehe - 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        if (y == 0 || y == breite - 1)
                        {
                            Console.Write("X");
                        }
                        else { Console.Write(" "); }
                    }

                }
                Console.WriteLine();
            }
        }
    }
}