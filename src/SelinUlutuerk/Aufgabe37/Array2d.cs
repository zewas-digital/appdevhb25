using System;
using Appdevhb25.SelinUlutuerk.Arrays;
using static Appdevhb25.SelinUlutuerk.Arrays.ArrayHelper;

namespace Appdevhb25.SelinUlutuerk.Aufgabe37
{
    class Array2d
    {
        public static void Start()
        {
            Random random = new Random();
            int[,] tabelle =
            {
                { random.Next(1,101), random.Next(1,101), random.Next(1,101) },
                { random.Next(1,101), random.Next(1,101), random.Next(1,101) },
                { random.Next(1,101), random.Next(1,101), random.Next(1,101) },
            };

            // { { 1, 3, 5 }, { 6, 0, 7 }, { 5, 5, 1 } };

            ArrayHelper.PrintArray(tabelle);

            int summeZeile = 0;

            int summeSpalte = 0;

            Console.WriteLine("Zeilensummen von oben nach unten");

            for (int i = 0; i < tabelle.GetLength(0); i++)
            {

                for (int j = 0; j < tabelle.GetLength(1); j++)
                {
                    summeZeile += tabelle[i, j];
                }
                Console.WriteLine($"Zeile {i + 1}: {summeZeile}");
            }

            Console.WriteLine();

            Console.WriteLine("Spaltensummen von links nach rechts");

            for (int j = 0; j < tabelle.GetLength(1); j++)
            {

                for (int i = 0; i < tabelle.GetLength(0); i++)
                {
                    summeSpalte += tabelle[i, j];
                }
                Console.WriteLine($"Zeile {j + 1}: {summeSpalte}");
            }

        }
    }
}