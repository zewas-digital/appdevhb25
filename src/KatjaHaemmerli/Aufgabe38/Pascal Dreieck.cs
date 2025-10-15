
// Frage den Anwender nach der gewünschten Größe und erstelle ein Pascal-Dreieck mit der entsprechenden Dimension.
 
//Regel: Jede Zahl in der Matrix ist gleich die Summe der Nachbarzahlen nach Links und nach Oben.
 
 using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe38
{
    public  class PascalDreieck
    {
        public static void Dreieck()
        {
            int[,] array = new int[6, 6];

            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    if (y == 0) // 0.Zeile
                    {
                        array[y, x] = 1;
                    }
                    else if (x == 0) // 0.Spalte
                    {
                        array[y, x] = 1;
                    }
                    else // Wenn x < 0 || y < 0
                    {
                        array[y, x] = array[y - 1, x] + array[y, x - 1];
                    }
                }
            }

            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    // Console.Write(array[y, x]);
                    // Ausgabe mit Formatierung
                    Console.Write("{0, 10}", array[y, x]);
                }
            Console.WriteLine();
            }
            
        }
    }
}
