using System;
using System.Globalization;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class Inventur
    {
        public static void Start()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            string[] lines = File.ReadAllLines(@"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein\aufgaben\59input.txt");
            using (StreamWriter sw = new StreamWriter(@"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein\aufgaben\59output.txt"))
            {
                string[] artikel = new string[lines.Length];
                int[] menge = new int[lines.Length];
                double[] preis = new double[lines.Length];

                string teuerste = "";
                double teuerstePreis = 0;
                double durchschnittPreis = 0;
                double gesamtWert = 0;

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] part = lines[i].Split("  ");

                    artikel[i] = part[0];
                    menge[i] = int.Parse(part[1]);
                    preis[i] = double.Parse(part[2]);

                    gesamtWert += preis[i];

                    if (preis[i] > teuerstePreis)
                    {
                        teuerstePreis = preis[i];
                        teuerste = artikel[i];
                    }
                }

                string billigste = "";
                double billigstePreis = teuerstePreis;

                for (int i = 0; i < lines.Length - 1; i++)
                {
                    if (preis[i] < billigstePreis)
                    {
                        billigstePreis = preis[i];
                        billigste = artikel[i];
                    }
                }

                durchschnittPreis = gesamtWert / artikel.Length;

                sw.WriteLine($"Durchschnittspreis aller Artikel: {teuerste}");
                sw.WriteLine($"Durchschnittspreis aller Artikel: {billigste}");
                sw.WriteLine($"Durchschnittspreis aller Artikel: {durchschnittPreis:F2}");
                sw.WriteLine($"Gesamtwert aller Artikel und Mengen: {gesamtWert:F2}");
            }
        }
    }
}