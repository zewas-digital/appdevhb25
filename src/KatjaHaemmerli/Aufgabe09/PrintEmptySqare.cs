//Erstelle eine Methode welche einen Rhombus von variabler Größe und mit angegebene Zeichen ausgibt. 
//Die Größe soll dabei die Höhe des Rhombus sein. erstelle ein in der mitte leeres Quadrat
using System;
using System.ComponentModel.DataAnnotations;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe09
{
    public class PrintEmptySqare
    {
        public static void EmptySqare(int zeilen, int spalten)
        {            
            Console.WriteLine();
            
            for (int z = 0; z < zeilen; z++)
            {

                for (int s = 0; s < spalten; s++)
                {
                    if (z == 0 || z == zeilen - 1) // obere und untere Zeilen
                    {
                        Console.Write("x");
                    }
                    else if (s == 0 || s == spalten - 1)
                    {
                        Console.Write("x");
                    }
                    else {Console.Write(" ");}

                }
                Console.WriteLine();
            }
           
                
        }

    }
        
}