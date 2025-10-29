using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Appdevhb25.KatjaHaemmerli.Aufgabe03;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe59
{
    public  class Einkaufliste
    {
        static string einkaufListe = @"C:\Users\haka\DigitalCampus\appdevhb25\src\KatjaHaemmerli\Aufgaben59\einkaufliste.txt";
        static string sortierteEinkaufliste = @"C:\Users\haka\DigitalCampus\appdevhb25\src\KatjaHaemmerli\Aufgaben59\sortierteEinkaufliste.txt";
        public static void Einkauf()
        {

            // StreamReader: den Text lesen
            using (StreamReader reader = new StreamReader(einkaufListe))
            {
                using (StreamWriter sw = new StreamWriter(sortierteEinkaufliste))

                {
                    // ReadLine() liest die nächste Zeile aus der Datei, gibt die Zeile mit return zurück und speichert sie in die variable line.
                    string line = reader.ReadLine();  // Die Variable line ist ein Zwischenspeicher, weil ich den Wert für die while-Bedingung und für die Ausgabe brauche.

                    decimal teuersterArtikel = 0;
                    decimal billigsterArtikel = 0.50M;                    
                    decimal gesamtwert = 0;
                    decimal durchschnittspreis = 0;
                    int anzahlArtikel = 0; 

                    while (line != null) // Solange in der variable line ein Text gespeichert ist, soll dieser auf der Konsole ausgegeben und eine neue Zeile eingelesen werden.
                    {
                        string[] arrayEinkaufliste = line.Split("  ");
                        decimal einzelpreis = Convert.ToDecimal(arrayEinkaufliste[2], CultureInfo.InvariantCulture);

                        // teuerster Artikel finden 
                        if (einzelpreis > teuersterArtikel)
                        {
                            teuersterArtikel = einzelpreis;
                        }

                        // billigster Artikel finden                        
                        if (einzelpreis < billigsterArtikel)
                        {
                            billigsterArtikel = einzelpreis;
                        }

                        // die Menge aller Artikel berechnen  
                        anzahlArtikel++;

                        // der Gesamtwert aller Artikel berechnen
                        gesamtwert += einzelpreis;

                        // der Durchschnittpreis aller Artikel (alle Artikel zusammen zählen und dann das Resultat durch 30)
                        durchschnittspreis = gesamtwert / anzahlArtikel;

                        line = reader.ReadLine(); // Liest Zeile für Zeile ein nicht den ganzen Text auf einmal
                    }
                    sw.WriteLine($"Der teuerste Artikel kostet: {teuersterArtikel}\nDer billigste Artikel kostet: {billigsterArtikel}");
                    sw.WriteLine($"Der Durchschnittspreis aller Artikel beträgt: {durchschnittspreis}\nDie Anzahl aller Artikel beträgt: {anzahlArtikel}\nDer Gesamtwert aller Artikel beträgt: {gesamtwert}");
                }

            }
        }
        
    }
}