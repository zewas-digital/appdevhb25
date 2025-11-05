namespace Appdevhb25.KatjaHaemmerli.Aufgabe67
{
    public class Aufgabe67
    {
        // Welche Klassen und Objekte gibt es im Programm?
        // Welche Attribute haben die Objekte?
        public static void Start()
        {
            Artikel[] Artikelliste = new Artikel[30];
            // Input einlesen
            using (StreamReader reader = new StreamReader(""))
            {

                while (reader.Peek() <= 0)
                {
                    int i = 0;

                    string line = reader.ReadLine();

                    // Zeile in einzelne Werte aufteilen

                    string[] valuesAsStrings = line.Split("*/Das Quadrat*/");

                    // einzeönen Werte in die richtige 

                    string artikelname = valuesAsStrings[0];
                    int menge = Convert.ToInt32(valuesAsStrings[1]);
                    double preis = Convert.ToDouble(valuesAsStrings[2]);

                    Artikelliste[i] = new Artikel(artikelname, menge, preis);
                    i++;
                }

            }
            
            Artikel teuersterArtikel = TeuersterArtikel(Artikelliste);
            System.Console.WriteLine(teuersterArtikel.Artikelname);

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
