using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe37
{
    public class AufgabeArray2D()
    {
        public static void Array2D()
        {
            /*Speichere eine Tabelle mit 3 Zeilen und 3 Spalten in ein zweidimensionales Array. 
            Befülle anschließend die einzelnen Zellen mit zufälligen Werten. 
            Berechne anschließend für jede Zeile und für jede Spalte die Summe der Werte. 
            Gib die Matrix und die berechneten Ergebnisse auf der Konsole aus*/

            // int[,] zeileSpalte = new int[3, 3]; // 3 Zeilen und 3 Spalten

            // zeileSpalte[0, 0] = 1;
            // zeileSpalte[0, 1] = 1;
            // zeileSpalte[0, 2] = 1;

            // zeileSpalte[1, 0] = 2;
            // zeileSpalte[1, 1] = 2;
            // zeileSpalte[1, 2] = 2;

            // zeileSpalte[2, 0] = 3;
            // zeileSpalte[2, 1] = 3;
            // zeileSpalte[2, 2] = 3;

            // Andere Möglichkeit die Indexe zu befüllen
            int[,] zeileSpalte = new int[3, 3] // 3 Zeilen und 3 Spalten
            {
               {1, 1, 1}, // Index [0]
               {2, 2, 2}, // Index [1]
               {3, 3, 3} // Index [2]
            };  

            // Console.Write($"{zeileSpalte[0, 0]} ");
            // Console.Write($"{zeileSpalte[0, 1]} ");
            // Console.WriteLine($"{zeileSpalte[0, 2]} ");
            // Console.Write($"{zeileSpalte[1, 0]} ");
            // Console.Write($"{zeileSpalte[1, 1]} ");
            // Console.WriteLine($"{zeileSpalte[1, 2]} ");
            // Console.Write($"{zeileSpalte[2, 0]} ");
            // Console.Write($"{zeileSpalte[2, 1]} ");
            // Console.WriteLine($"{zeileSpalte[2, 2]} ");

            int zeilenSumme = zeileSpalte[0, 0] + zeileSpalte[0, 1] + zeileSpalte[0, 2];
            int zeilenSumme2 = zeileSpalte[1, 0] + zeileSpalte[1, 1] + zeileSpalte[1, 2];
            int zeilenSumme3 = zeileSpalte[2, 0] + zeileSpalte[2, 1] + zeileSpalte[2, 2];

            for (int z = 0; z < zeileSpalte.GetLength(0); z++)
            {

                for (int s = 0; s < zeileSpalte.GetLength(1); s++) // kleiner als 1 weil nur ein ZeilenSpalten Block 
                {
                    Console.Write(zeileSpalte[z, s] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Summe 1. Zeile:\n{zeilenSumme}");
            Console.WriteLine($"Summe 2. Zeile:\n{zeilenSumme2}");
            Console.WriteLine($"Summe 3. Zeile:\n{zeilenSumme3}");

            // int spaltenSumme = zeileSpalte[0, 0] + zeileSpalte[1, 0] + zeileSpalte[2, 0];
            // int spaltenSumme2 = zeileSpalte[0, 1] + zeileSpalte[1, 1] + zeileSpalte[2, 1];
            // int spaltenSumme3 = zeileSpalte[0, 2] + zeileSpalte[1, 2] + zeileSpalte[2, 2];

            int spaltenSumme = 0;
            for (int i = 0; i < zeileSpalte.GetLength(0); i++)
            {
                for (int j = 0; j < zeileSpalte.GetLength(1); j++)
                {
                    spaltenSumme += zeileSpalte[i, j];
                }
            }
            Console.WriteLine($"Summe von Spalten:\n{spaltenSumme}");            

            

            // Console.WriteLine($"Summe 1. Spalte:\n{spaltenSumme}");
            // Console.WriteLine($"Summe 2. Spalte:\n{spaltenSumme2}");
            // Console.WriteLine($"Summe 3. Spalte:\n{spaltenSumme3}");
        }
    }
}