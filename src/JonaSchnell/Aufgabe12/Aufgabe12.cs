using System.Drawing;

namespace Appdevhb25.JonaSchnell.Aufgabe12
{
    public class Aufgabe12

    {

        public static void Start12()
        {
            int j = 100;
            int[] fibonacci = new int[j];

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < j; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            Console.WriteLine("Die ersten " + j + " Fibonacci-Zahlen sind:");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(fibonacci[i]);
            }
        }
    }
}