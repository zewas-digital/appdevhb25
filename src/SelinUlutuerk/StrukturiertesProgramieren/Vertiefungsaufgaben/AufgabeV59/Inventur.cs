using System;
using System.Globalization;
using System.IO;

namespace Appdevhb25.SelinUlutuerk.AufgabeV59
{
    class Inventur
    {
        public static void Start()
        {
            string outputPath = "C:/Users/aau28234/Documents/appdevneu/appdevhb25/src/SelinUlutuerk/AufgabeV59/output.txt";
            string inputPath = "C:/Users/aau28234/Documents/appdevneu/appdevhb25/src/SelinUlutuerk/AufgabeV59/input.txt";

            string[] lines = File.ReadAllLines(inputPath);

            int summeMenge = 0;
            decimal summePreis = 0;
            decimal gesamtwert = 0;

            int indexTeuerster = 0;
            int indexBilligster = 0;


            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                string[] produkt = new string[lines.Length];
                int[] menge = new int[lines.Length];
                decimal[] preis = new decimal[lines.Length];

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split("  ");

                    produkt[i] = parts[0];
                    menge[i] = int.Parse(parts[1]);
                    preis[i] = decimal.Parse(parts[2]);

                    writer.WriteLine($"{produkt[i]}: Menge = {menge[i]}, Preis = {preis[i].ToString("C")}");

                    summeMenge += menge[i];
                    summePreis += preis[i];
                    gesamtwert += menge[i] * preis[i];

                    if (preis[i] > preis[indexTeuerster])
                        indexTeuerster = i;

                    if (preis[i] < preis[indexBilligster])
                        indexBilligster = i;
                }

                decimal durchschnittPreis = summePreis / lines.Length;


                writer.WriteLine();
                writer.WriteLine($"Teuerster Artikel: {produkt[indexTeuerster]} ({preis[indexTeuerster]})");
                writer.WriteLine($"Billigster Artikel: {produkt[indexBilligster]} ({preis[indexBilligster]})");

                writer.WriteLine($"Durchschnittspreis aller Artikel: {durchschnittPreis}");
                writer.WriteLine($"Gesamtwert aller Artikel und Mengen: {gesamtwert}");
                writer.WriteLine($"Gesamtmenge aller Artikel: {summeMenge}");
            }
        }
    }
}