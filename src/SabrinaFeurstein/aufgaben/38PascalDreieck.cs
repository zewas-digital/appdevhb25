using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class PascalDreieck
    {
        public static void Dreieck()
        {
            Console.Write("Größe: ");
            int anzahl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] array = new int[anzahl, anzahl];
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    bool eins = array[i, j] == array[0,j] ||  array[i, j] == array[i,0];
                    if (eins)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        int summe;
                        summe = array[i - 1, j] + array[i, j - 1];
                        array[i, j] = summe;
                    }
                    Console.Write($"{array[i, j], 10} ");
                }
                Console.WriteLine();
            }
        }
    }
}