using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class _2dArray
    {
        public static void Array()
        {
            Random rnd = new Random();
            int[,] array = new int[3, 3];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 100);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Zeilensumme von oben nach unten");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int summeZ = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    summeZ += array[i, j];
                }
                Console.WriteLine(summeZ);
            }

            Console.WriteLine("Spaltensumme von links nach rechts");
            for (int i = 0; i < array.GetLength(1); i++)
            {
                int summeS = 0;
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    summeS += array[j, i];
                }
                Console.Write($"{summeS} ");
            }
        }
    }
}