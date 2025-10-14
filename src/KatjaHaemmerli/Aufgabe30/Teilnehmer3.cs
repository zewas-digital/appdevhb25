using System.Collections;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe20;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe30
{
    // Erstelle eine Methode, welche eine Kommazahl (Parameter 0) auf eine bestimmte Anzahl an Nachkommastellen genau (Parameter 1) kaufmännisch rundet. 
    public class Teilehmer3Liste
    {
        public static void Teilnehmer()
        {

            // userInput (Anzahl Teilnehmer) in ein Array speichern.            
            Console.WriteLine("Wie viele Teilnehmer möchtest du eintragen? Bitte gib eine Zahl ein.");            
            string temp = Console.ReadLine(); 
            
            if (int.TryParse(temp, out int anzahlTeilnehmer))
            {                
                string [] teilnehmer = new string[anzahlTeilnehmer]; // Länge definiert durch den UserInput
                for (int i = 0; i < teilnehmer.Length; i++)
                {
                    Console.WriteLine($"Anzahl Teilnehmer: {anzahlTeilnehmer}");
                    Console.WriteLine("Bitte gib nun den Namen ein den du hinzufügen möchtest.");
                    teilnehmer[i] = Console.ReadLine();
                    Console.WriteLine(teilnehmer[i]);
                } 
            }
            else
            {
                Console.WriteLine("Falsche Eingabe");
            }                

        }
    }
}