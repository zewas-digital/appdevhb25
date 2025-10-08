namespace Appdevhb25.JonaSchnell.Aufgabe07
{
    public class Aufgabe07

    {

        public static void Start07()
        {
            Console.WriteLine("Wie lang soll dein Dreieck sein?");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int y = 0; y < size; y++)
            {
                for (int x = size; x > y; x--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}