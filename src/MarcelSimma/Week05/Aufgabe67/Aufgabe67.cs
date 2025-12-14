namespace Appdevhb25.MarcelSimma.Aufgabe67
{
    public class Aufgabe67
    {
        public static void Start()
        {
            // 4.1. Input einlesen

            // Artikel-Array erstellen
            Artikel[] artikelliste = new Artikel[30];

            using (StreamReader reader = new StreamReader("/Users/marcel/Documents/code/appdevhb25/src/MarcelSimma/Week05/Aufgabe67/input.txt"))
            {
                int i = 0;
                while (reader.Peek() >= 0)
                // Solange gültige Zeichen (= Zeilen) vorhanden sind, soll weiter eingelesen werden.
                {
                    // Zeile einlesen
                    string? zeile = reader.ReadLine();

                    // Zeile in einzelne Werte aufspalten
                    string[] werteAlsStrings = zeile.Split("  ");

                    // die einzelnen Werte in die richtigen Datentypen konvertieren
                    string artikelname = werteAlsStrings[0];
                    int menge = Convert.ToInt32(werteAlsStrings[1]);
                    double preis = Convert.ToDouble(werteAlsStrings[2]);

                    artikelliste[i] = new Artikel(artikelname, preis, menge); // Preise und Mengen werden fiktiv berechnet.
                    i++;
                }
            }


            // 4.3. sonstige Verarbeitung

            Artikel teuersterArtikelInListe = TeuersterArtikel(artikelliste);

            System.Console.WriteLine(teuersterArtikelInListe.Artikelname);
        }

        public static Artikel TeuersterArtikel(Artikel[] liste)
        {
            Artikel teuersterArtikel = liste[0];

            for (int i = 1; i < liste.Length; i++)
            {
                if (teuersterArtikel.Preis < liste[i].Preis)
                {
                    teuersterArtikel = liste[i];
                }
            }

            return teuersterArtikel;
        }
    }
}