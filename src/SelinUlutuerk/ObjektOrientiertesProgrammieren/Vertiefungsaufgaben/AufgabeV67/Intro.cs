using System;
using System.Globalization;

namespace Appdevhb25.SelinUlutuerk.AufgabeV67
{
    public class Intro
    {
        public static void Start()
        {
            int indexTeuerster = 0;
            int indexBilligster = 0;
            decimal summe = 0m;
            decimal alleArtikel = 0m;
            decimal durchschnittArtikel = 0m;

            string inputPath = "C:/Users/aau28234/Documents/appdevneu/appdevhb25/src/SelinUlutuerk/AufgabeV67/input.txt";
            string[] lines = File.ReadAllLines(inputPath);
            Artikel[] artikel = new Artikel[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("  ");

                // artikel[i] = new Artikel();
                // artikel[i].ProduktName = parts[0];
                // artikel[i].Menge = int.Parse(parts[1]);
                // artikel[i].Preis = decimal.Parse(parts[2], CultureInfo.InvariantCulture);

                // macht dasselbe wie unten:
                artikel[i] = new Artikel(parts[0], int.Parse(parts[1]), decimal.Parse(parts[2], CultureInfo.InvariantCulture));
            }

            for (int i = 0; i < artikel.Length; i++)
            {
                if (artikel[i].Preis > artikel[indexTeuerster].Preis)
                    indexTeuerster = i;

                if (artikel[i].Preis < artikel[indexBilligster].Preis)
                    indexBilligster = i;

                summe += artikel[i].Preis;
                alleArtikel += artikel[i].Menge;
            }

            durchschnittArtikel = summe / lines.Length;

            Console.WriteLine($"Teuerster Artikel: {artikel[indexTeuerster].ProduktName} ({artikel[indexTeuerster].Preis:F2})");
            Console.WriteLine($"Billigster Artikel: {artikel[indexBilligster].ProduktName} ({artikel[indexBilligster].Preis:F2})");
            Console.WriteLine($"Durchschnittspreis aller Artikel: {durchschnittArtikel:F2}");
            Console.WriteLine($"Die Anzahl der Artikel beträgt: {lines.Length}");
            Console.WriteLine($"Die Menge aller Artikel beträgt: {alleArtikel}");
        }
    }
}