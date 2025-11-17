using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe77
{
    public  class DictionaryAufgabe
    {   
        public static void Start()
        {
            Serien serienListe = new Serien();
            // Dictionary erstellen
            serienListe.SerienHinzufuegen("Strangerthings", 10);
            serienListe.SerienHinzufuegen("Atypical", 9);
            serienListe.SerienHinzufuegen("Alice in Borderland", 8);
            serienListe.SerienHinzufuegen("Dark", 7);
            serienListe.SerienHinzufuegen("Money Heist", 6);
            
            serienListe.SortNachNamen();
            System.Console.WriteLine(); // Abstand
            serienListe.BesteBewertungErmitteln();
            System.Console.WriteLine(); // Abstand

            // List<KeyValuePair<string, double>> listeDerFilme = BewertungUeber8();
            // PrintListAusgabeUeber8(listeDerFilme);
            // PrintListAusgabeUeber8(BewertungUeber8());

            serienListe.BewertungUeber8();
            System.Console.WriteLine(); // Abstand
            serienListe.BewertungsSuche();
        }
        
    }
}