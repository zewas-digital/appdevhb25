using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe43
{
    public  class ArraySearch
    {
        public static void Search()
        {
            // 1. Variante

            // string[] woerter = ["Apfel", "Birne", "Maus", "Haus", "Tee", "Tasse", "Baum", "Blume", "Vase", "Wasser"];

            // Console.WriteLine("Bitte gib ein Wort ein.");
            // string? wort = Console.ReadLine();

            // int indexOfFound = -1; // - 1 weil 0 und andere positive Zahlen mit den Indexen vom array woerter belegt sind
            // // Am Anfang / Standartmässig auf "nicht gefunden" setzen.

            // if (indexOfFound == -1) // Wenn Wort (userInput) nicht gefunden
            // {
            //     Console.WriteLine("Wort nicht gefunden.");
            // }
            // else
            // {
            //     Console.WriteLine($"Wort Index: {indexOfFound + 1}"); // + 1 damit Element an Stelle eins als 1 angezeigt wird und nicht 0                           
            // }

            // for (int i = 0; i < woerter.Length; i++)
            // {
            //     if (wort == woerter[i])
            //     {
            //         indexOfFound = i;
            //         break;
            //     }
            // } 


            // Variante 2

            string[] woerter2 = ["Apfel", "Birne", "Maus", "Haus", "Tee", "Tasse", "Baum", "Blume", "Vase", "Wasser"];

            Console.WriteLine("Bitte gib ein Wort ein.");
            
            string? silbe = Console.ReadLine();

            int indexOfFound2 = -1; // - 1 weil 0 und andere positive Zahlen mit den Indexen vom array woerter belegt sind
            // Am Anfang / Standartmässig auf "nicht gefunden" setzen.

            foreach(string wort2 in woerter2)
            {
                if(wort2.ToLower().Contains(silbe.ToLower()))
                {
                    Console.WriteLine(silbe);
                    Console.WriteLine($"Wort {silbe} Index: {indexOfFound2 + 1}"); 
                    
                }
            }
        }
    }
}