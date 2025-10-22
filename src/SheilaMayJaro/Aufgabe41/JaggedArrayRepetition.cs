using System; 
namespace Appdevhb25.SheilaMayJaro.Aufgabe41
{
    public class JaggedArrayRepetition
    {
        public static void Start()
        {
            /* Wiederholung Jagged Arrays
            ==========================
            */

            // Deklaration
            int[][] numbers7;

            // Initialisierung
            numbers7 = new int[3][];

            // Deklaration + Initialisierung
            int[][] numbers8 = new int[3][];
            numbers8[0] = new int[4]; // erste Zeile mit 4 Spalten
            numbers8[1] = new int[2]; // zweite Zeile mit 2
            numbers8[2] = new int[3]; // dritte Zeile mit 3

            // Werte zuweisen
            int[][] numbers9 = { new int[] {1, 2, 3, 4 }, // erste Zeile mit 4 Spalten
                                 new int[] {11, 22 },   // zweite Zeile mit 2
                                 new int[] {111, 222, 333 } }; // dritte Zeile mit 3

            // Array ausgeben, Variante 1
            /*Console.WriteLine("Array ausgeben, Variante 1"); 
            for (int i = 0; i < numbers9.Length; i++)
            {
                for (int j = 0; j < numbers9[i].Length; j++)
                {
                    Console.Write($"{numbers9[i][j]}    ");
                }
                Console.WriteLine();
            }

            // Array ausgeben, Variante 2
            Console.WriteLine("Array ausgaben, Variante 2"); 
            foreach (int[] row in numbers9)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number}    ");
                }
                Console.WriteLine();
            }*/
        }
    }
}