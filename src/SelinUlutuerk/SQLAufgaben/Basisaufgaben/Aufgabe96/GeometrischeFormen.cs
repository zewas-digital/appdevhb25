using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe96
{
    class GeometrischeFormen
    {
        public static void Start()
        {
             Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("      GEOMETRISCHE FIGUREN");
            Console.WriteLine("=======================================\n");

            // Figurenliste
            List<Figur> figuren = new List<Figur>();

            // Beispielobjekte
            Kreis k1 = new Kreis(5, "Kreis A", "Kreis");
            Rechteck r1 = new Rechteck(4, 2, "Rechteck A", "Rechteck");
            GleichseitigesDreieck d1 = new GleichseitigesDreieck(3, "Dreieck A", "Gleichseitiges Dreieck");

            figuren.Add(k1);
            figuren.Add(r1);
            figuren.Add(d1);

            Console.WriteLine("ERSTELLTE FIGUREN:");
            Console.WriteLine(new string('-',20));

            foreach (var f in figuren)
            {
                Console.WriteLine(f.ToString());
                Console.WriteLine(new string('-',20));
            }

            // Statistiken
            Console.WriteLine("\nAnzahl der verschiedenen Figuren:");
            Kreis.PrintAnzahl();
            Rechteck.PrintAnzahl();
            GleichseitigesDreieck.PrintAnzahl();
            Console.WriteLine($"Gesamtanzahl Figuren: {Figur.AnzahlFiguren}");

            // Skalieren-Beispiel
            Console.WriteLine("\nSKALIEREN Beispiel (Kreis A * 2):");
            k1.Skalieren(2);
            Console.WriteLine(k1.ToString());
        }
    }
}