using System.Runtime.CompilerServices;

namespace Appdevhb25.JonaSchnell.Aufgabe37
{
    public class Aufgabe37
    {


        public static void Start37()
        {
            int[][] numbers = new int[3][];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new int[3];
            }
            int k = 1;
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    numbers[i][j] = random.Next(1, 9);
                    Console.Write(numbers[i][j] + " ");
                    if (k == 3 || k == 6 || k == 9)
                    {
                        Console.WriteLine();
                    }
                    k++;
                }
            }
        }
    }
}