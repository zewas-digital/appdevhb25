using System.Runtime.CompilerServices;

namespace Appdevhb25.JonaSchnell.Aufgabe38
{
    public class Aufgabe38
    {


        public static void Start38()
        {
            Console.WriteLine("Geben Sie eine Zahl ein:");
            int numbersquestion = Convert.ToInt32(Console.ReadLine());
            int l = numbersquestion;
            int[,] numbers = new int[l, l];
            int tmp = numbers[numbers.GetLength(0) - 1, numbers.GetLength(1) - 1] = l;
            int anzahlderziffern = 1;
            while (tmp >= 10)
            {
                tmp = tmp / 10;
                anzahlderziffern++;
            }

            for (int y = 0; y < numbers.GetLength(0); y++)
            {
                for (int x = 0; x < numbers.GetLength(1); x++)
                {
                    if (y == 0 || x == 0)
                    {
                        numbers[y, x] = 1;
                    }
                    else
                    {
                        numbers[y, x] = numbers[y - 1, x] + numbers[y, x - 1];
                    }
                }
                System.Console.WriteLine();
            }

            for (int y = 0; y < numbers.GetLength(0); y++)
            {
                for (int x = 0; x < numbers.GetLength(1); x++)
                {
                    System.Console.Write("{0, " + anzahlderziffern + "}", numbers[y, x] + "    ");
                }
                System.Console.WriteLine();
            }

            /* 
             Console.WriteLine("Geben Sie eine Zahl ein:");
             int numbersquestion = Convert.ToInt32(Console.ReadLine());
             int l = numbersquestion;
             int[,] numbers = new int[l, l];
             int k = 1;
             for (int y = 0; y < l; y++)
             {
                 for (int x = 0; x < numbers.GetLength(1); x++)
                 {
                     if (x == 0)
                     {
                         numbers[y, x] = 1;
                     }
                     if (y == 0)
                     {
                         numbers[y, x] = 1;
                     }
                     Console.Write(numbers[y, x] + "     ");
                     numbers[y, x] = numbers[y - 1, x] + numbers[y, x - 1];
                     if (k == l || k == l * (x + 1))
                     {
                         Console.WriteLine();
                     }
                     k++;
                 }
             }*/

        }
    }
}