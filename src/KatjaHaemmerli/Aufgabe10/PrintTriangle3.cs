using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe10
{
    /*Erstelle eine Methode PrintTriangle(int length), welche ein gleichschenkliges Dreieck auf der Console ausgibt. 
    Der Übergabeparameter length enthält die Länge der beiden Katheten. 
    Die letzte Zeile der Ausgabe entspricht der Hypotenuse des Dreiecks und wird in der Methode selbst berechnet.*/

    public class PrintTriangle3
    {
        public static void Triangle3(int length)
        {
            for (int y = 0; y < length - 1; y++) // Zeile für Zeile durch gehen. - 1 weil letzte Zeile nicht durchgehen diese sird separat(Hypothenuse) behandelt
            {
                for (int x = - length + 1; x < length; x++) // von der Mitte aus beginnen minus die Länge und + 1 wegen dem Index
                {
                    // Seite von Mitte nach rechts unten
                    if (x == y) // Wenn Koordinate x und y den selben wert haben dann *
                    {
                        Console.Write("*");
                    } 

                    // Seite von Mitte nach links unten
                    else if (Math.Abs(x) == Math.Abs(y)) // Math.Abs --> minus vor der -3 wird ignoriert.
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }                   
                }
                Console.WriteLine();
            }
            
            // Ausgabe Hypothenuse
            for (int x = 0; x < length * 2 - 1; x++)
            {                
                Console.Write("*");
            }

            // Console.WriteLine();
        }
    }
}
        
