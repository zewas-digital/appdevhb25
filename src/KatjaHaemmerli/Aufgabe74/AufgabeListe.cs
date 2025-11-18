using System;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe03;
using System.Collections.Generic;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe74
{
    public class AufgabeListe
    {
        /*Erstelle eine Liste mit 20 Zufallszahlen zwischen 0 und 99.
        Erstelle jeweils eine Methode für:
        - Zählen der geraden Zahlen
        - Suche nach der kleinsten Zahl
        - Suche nach der größten Zahl
        - Sortiere die Elementen absteigend
        - Lösche alle Ungerade Zahlen
        2/ Listen zusammenführen
        Erstelle zwei Listen mit 20 Elementen, die nach Größe sortiert sind.
        Erstelle eine dritte Liste, in dem du die Elemente der vorhergehenden Listen zusammenfügst, 
        die neu erstellte Liste soll immer noch sortiert sein.*/
        public static void Start()
        {
            List<int> zahlen = RandomZahlenGenerieren(); // methode RandomZahlenGenerieren liefert eine befüllte Liste aus random zahlen zurück.
            System.Console.WriteLine($"Liste mit Zufallszahlen: {string.Join(", ", RandomZahlenGenerieren())}");
            System.Console.WriteLine($"Anzahl gerader Zahlen: {AnzahlGeradeZahlen(zahlen)}");
            System.Console.WriteLine($"Die kleinste Zahl ist: {SucheNachDerKleinstenZahl(zahlen)}");
            System.Console.WriteLine($"Die grösste Zahl ist: {SucheNachDerGroesstenZahl(zahlen)}");
            System.Console.WriteLine($"Zahlen absteigend sortiert: {string.Join(", ", SortiereDieZahlenAbsteigend(zahlen))}");
            System.Console.WriteLine($"Alle ungeraden Zahlen aus der Liste gelöscht: {AlleUngeradenZahlenLoeschen(zahlen)}");
            System.Console.WriteLine($"Listen zusammengführt: {string.Join(", ",ListenZusammenführen(zahlen))}");        
        }
        public static List<int> RandomZahlenGenerieren()
        {
            int zufallsZahl;
            List<int> zufallsZahlen = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                zufallsZahl = random.Next(0, 99);
                zufallsZahlen.Add(zufallsZahl);
            }
            return zufallsZahlen;
        }

        public static int AnzahlGeradeZahlen(List<int> zahlen)
        {
            int geradezahl = 0;
            foreach (int zahl in zahlen)
            {
                if (zahl % 2 == 0)
                {
                    geradezahl++;
                }
            }
            return geradezahl;
        }
        public static int SucheNachDerKleinstenZahl(List<int> zahlen)
        {
            int kleinsteZahl = 0;
            kleinsteZahl = zahlen.Min();
            return kleinsteZahl;
        }

        public static int SucheNachDerGroesstenZahl(List<int> zahlen)
        {
            int groessteZahl = 0;
            groessteZahl = zahlen.Max();
            return groessteZahl;           
        }

        public static List<int> SortiereDieZahlenAbsteigend(List<int> zahlen)
        {            
            zahlen.Sort();
            zahlen.Reverse();
            return zahlen;
        }

        public static List<int> AlleUngeradenZahlenLoeschen(List<int> zahlen)
        {
            foreach (int zahl in zahlen)
            {
                zahlen.RemoveAll(number => number % 2 != 0);
            }
            return zahlen;
        }
        
        public static List<int> ListenZusammenführen(List<int> zahlen)
        {
            int zufallsZahl;
            List<int> zweiteListe = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                zufallsZahl = random.Next(0, 99);
                zweiteListe.Add(zufallsZahl);
            }
            return zweiteListe;

            List<int> zusammengeführteListe = new List<int>(zahlen);
            // ListA.AddRange(ListB) pappt beide Listen zusammen. Source: mycsharp.de
            zusammengeführteListe.AddRange(zweiteListe);
            zusammengeführteListe.Sort();
            
            return zusammengeführteListe;
        }

    }
}