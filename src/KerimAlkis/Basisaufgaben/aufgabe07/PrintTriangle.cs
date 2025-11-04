namespace Appdevhb25.KerimAlkis.Aufgabe07
{
    public class PrintTriangle
    {
        public static void Start(int hoehe, int breite)
        {

            for (int i = 0; i < hoehe; i++)
            {
                for (int y = 0; y < breite; y++)
                {
                    Console.Write("X");
                }
                breite -= 1;
                Console.WriteLine();
            }
            
        }
    }
}