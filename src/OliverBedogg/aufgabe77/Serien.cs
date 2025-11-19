using System;
using System.Collections.Generic;
using System.Linq;


namespace Appdevhb25.OliverBedogg.aufgabe77
{
    public class Serien
    {
        private readonly Dictionary<string, double> serien = new Dictionary<string, double>();

        // Methode erlaubt beliebig viele Tuples als Argumente --> beliebig viele Serien auf einmal zu ergänzen
        // Ein Tuple ist eine Datenstruktur, 
        // mit der mehrere Werte unterschiedlicher Typen zu einer Einheit zusammengefasst werden können
        // ohne eine eigenes Klasse oder Struktur zu definieren.
        // Hier: Jedes Tuple enthält den Namen der Serie (string) und die Bewertung (double)
        public void serienHinzufuegen(params (string name, double bewertung)[] serienListe)
        {
            // Iteriere über jedes Tuple in serienListe
            foreach (var serie in serienListe)
            {
                serien[serie.name] = serie.bewertung;
            }
        }

        // 1. Alle Serien alphabetisch zurückgeben
        public IEnumerable<KeyValuePair<string, double>> AlleSerienAlphabetisch()
        {
            return serien.OrderBy(kvp => kvp.Key);
        }

        // 2. Serien mit Bewertung > 8.0 zurückgeben
        public IEnumerable<KeyValuePair<string, double>> SerienMitBewertungUeber(double schwellwert)
        {
            return serien.Where(kvp => kvp.Value > schwellwert);
        }

        // 3. Beste Serie zurückgeben
        public KeyValuePair<string, double> BesteSerie()
        {
            // Aggregate, um das KeyValuePair mit der höchsten Bewertung zu finden
            // dabei wird eine Funktion auf jedes Paar im Dictionary angewendet:
            // Linker Eintrag (l) und rechter Eintrag (r) werden verglichen
            // Der Eintrag mit dem höheren Wert wird beibehalten
            return serien.Aggregate((l, r) => l.Value > r.Value ? l : r);
        }

        // 4. Bewertung zu einer Serie suchen (über TryGetValue)
        // gibt true zurück, wenn Serie gefunden wurde, sonst false
        // die Bewertung wird über out-Parameter zurückgegeben
        // dabei wird der out-Parameter nur gesetzt, wenn die Serie gefunden wurde
        public bool BewertungSuchen(string name, out double bewertung)
        {
            return serien.TryGetValue(name, out bewertung);
        }
    }
}