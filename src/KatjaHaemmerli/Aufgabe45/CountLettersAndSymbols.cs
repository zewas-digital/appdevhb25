using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe45
{
    public  class CountLettersAndSymbols
    {
        public static void CountLettersSymbols()
        {
            // Aufgabe: Erstelle ein Programm, das ausgibt, wie oft einzelne Buchstaben und Zeichen im Text vorkommen.
            string text = "The quick brown fox jumps over the lazy dog. You can't get rid of me! Assign the address of number to a pointer.";
            // text in int[] umwandeln
            // int[] arrayText = text.Split(',').Select(s => Convert.ToInt32(s)).ToArray(); // s:
            // int[] arrayText = new int[] {};

            char zeichen = 'A';
            int anzahlZeichen = 0;
            int asciiWert = (int)zeichen;

            // User soll Zeichen bestimmen
            Console.WriteLine("Geben Sie ein Zeichen ein:");

            // int asciiWert = Console.Read(); // Console.Read() liest ein einzelnes Zeichen als Ganzzahl (ASCII-Wert) ein, während console.ReadLine() eine gesamte Zeile bis zum Drücken der Enter-Taste als String liest. 
            // char eingelesenesZeichen = (char)asciiWert;

            // for (int i = 0; i < text.Length; i++)
            // {
            //     anzahlZeichen++;
            //     //Aufgabe wie bei Beispiel verstanden als: den ASCII - Wert der einzelnen Zeichen ausgeben            
            //     System.Console.WriteLine($"ASCII - Wert: {(int)text[i]}");               
            // }
            
            foreach (char z in text)
            {
                // int asciiWert = (int)c;
                Console.WriteLine($"Das Zeichen '{z}' hat den ASCII-Wert: {(int)z}");
            }
            // Ausgabe nach Beschreib der Aufgabe: Erstelle ein Programm, das ausgibt, wie oft einzelne Buchstaben und Zeichen im Text vorkommen.
            System.Console.WriteLine($"Anzahl Zeichen Vorkommen: {anzahlZeichen}");            

        }
    }
}