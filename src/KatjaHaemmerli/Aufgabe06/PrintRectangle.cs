using System;
using System.ComponentModel.DataAnnotations;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe06
{
    public class PrintRectangle
    {
        public static void Rectangle(int zeilen, int spalten)
        {
            //Erstelle ein Programm, das ein Rechteck mit einer bestimmten Länge und Breite ausgibt.
            
            for (int y = 0; y < spalten; y++)
            {
                for (int z = 0; z < zeilen; z++)
                {
                    Console.Write("x");                    
                }
                Console.WriteLine();
            }         
        }

    }
        
}