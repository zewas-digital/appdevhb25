namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe67
{
    public class Inventory
    {
        public static void Start()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            string[] lines = File.ReadAllLines(@"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein\aufgaben\aufgabe67\input.txt");

            Article[] artikel = new Article[lines.Length];

            string teuerste = "";
            double teuerstePreis = 0;
            double durchschnittPreis;
            double gesamtPreis = 0;
            double gesamtWert = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] part = lines[i].Split("  ");
                artikel[i] = new Article(part[0], int.Parse(part[1]), double.Parse(part[2]));

                for (int j = 0; j < artikel[i].Menge; j++)
                    gesamtWert += artikel[i].Preis;

                gesamtPreis += artikel[i].Preis;

                if (artikel[i].Preis > teuerstePreis)
                {
                    teuerstePreis = artikel[i].Preis;
                    teuerste = artikel[i].Name;
                }
            }

            string billigste = "";
            double billigstePreis = teuerstePreis;

            for (int i = 0; i < lines.Length - 1; i++)
            {
                if (artikel[i].Preis < billigstePreis)
                {
                    billigstePreis = artikel[i].Preis;
                    billigste = artikel[i].Name;
                }
            }

            durchschnittPreis = gesamtPreis / artikel.Length;

            Console.WriteLine($"teuerster Artikel: {teuerste}");
            Console.WriteLine($"billigster Artikel: {billigste}");
            Console.WriteLine($"Durchschnittspreis aller Artikel: {durchschnittPreis:F2}");
            Console.WriteLine($"Gesamtwert aller Artikel und Mengen: {gesamtWert:F2}");
        }
    }
}