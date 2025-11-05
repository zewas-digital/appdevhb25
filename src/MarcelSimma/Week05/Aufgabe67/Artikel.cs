namespace Appdevhb25.MarcelSimma.Aufgabe67
{
    public class Artikel
    {

        /*

        Überarbeite deine Lösung für Aufgabe 59 so, dass die einzelnen Artikel und ihre Informationen in Form von Objekten in ein Array gespeichert werden. 
        Iteriere anschließend über dieses Array, um die Ausgabe der folgenden Werte zu erzeugen: 
          - teuerster Artikel
          - billigster Artikel
          - Durchschnittspreis aller Artikel
          - Gesamtwert aller Artikel und Mengen

        1. Aufgabe lesen und verstehen
        2. Rückfragen klären
        3. Klassen und Objekte definieren
        4. In Teilaufgaben zerlegen
        4.1. Input (aus Datei einlesen) - ubersprungen
        4.2. jede Klasse für sich eine Teilaufgabe
        4.3. sonstige Verarbeitung: 4 Werte berechnen
        4.4. Output


        4.2.
        */

        // 1. Attribute
        public string Artikelname;
        public double Preis;
        public int Menge;

        // 2 Konstruktor
        public Artikel(string artikelname, double preis, int menge)
        {
            // Die Argumente, welche beim Aufruf des Konstruktors übergeben werden, 
            // werden in die Instanzattribute des Objektes gespeichert.
            Artikelname = artikelname;
            Preis = preis;
            Menge = menge;
        }
    }
}