// Erstelle eine Methode welche einen Rhombus von variabler Größe und mit angegebene Zeichen ausgibt. 
// Die Größe soll dabei die Höhe des Rhombus sein. erstelle ein in der mitte leeres Quadrat
// using System;
// using System.ComponentModel.DataAnnotations;

namespace Appdevhb25.KatjaHaemmerli.Bonusaufgabe013
{
    public class PrintDeltoid
    {
        public static void Start(int length)
        {

            for (int y = - length /2; y <= length/2 ; y++) // Ausgangspisition minus 6
            {
                //Console.WriteLine(y); // zur überprüfung wohin output landet

                for (int x = - length / 2; x <= length / 2; x++)
                {
                    // unterer Teil Deltoid
                    if (y == x + length / 2 || y + x == length / 2)
                    {
                        Console.Write("X");
                    }
                    // oberer Teil Deltoid
                    else if (y == x - length / 2 || y == Math.Abs(x) - length / 2) // Math.Abs ist der Abstand zu null immer positiv
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" "); //Leerraum
                    }
                }
                Console.WriteLine();
            } 
        }

    }
        
}