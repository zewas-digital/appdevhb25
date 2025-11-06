using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace Appdevhb25.KerimAlkis.Vertiefungsaufgabe03
{
    public class Inventur
    {
        public static void Start()
        {
            string path = @"C:\Users\ALKIKER\Documents\appdevhb25\src\KerimAlkis\Vertiefungsaufgaben\vertiefungsaufgabe03\input.txt";
            string pathoutput = @"C:\Users\ALKIKER\Documents\appdevhb25\src\KerimAlkis\Vertiefungsaufgaben\vertiefungsaufgabe03\output.txt";
            string[] articels = File.ReadAllLines(path);

            using(StreamWriter sw = new StreamWriter(pathoutput))
            {

                double teuerPreis = 0;
                double billigPreis = 100;

                string teuer = "";
                string billig = "";


                double gesamtwert = 0;
                double gesamtwertMenge = 0;
                double durchschnittsPreis = gesamtwert/articels.Length-1;


                for (int i = 0; i < articels.Length-1; i++)
                {
                    string[] parts = articels[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    string name = parts[0];
                    int menge = int.Parse(parts[1]);
                    double preis = double.Parse(parts[2]);

                    if (preis > teuerPreis) { teuer = name; }
                    if (preis < billigPreis) { billig = name; }
                    gesamtwert += preis;
                    gesamtwertMenge += preis * menge;

                }
                sw.WriteLine("teuerster Artikel: " + teuer);
                sw.WriteLine("billigster Artikel: " + billig);
                sw.WriteLine("durschnittsPreis aller Artikel: " + durchschnittsPreis);
                sw.WriteLine("Gesamtwert aller Artikel und Mengen: " + gesamtwertMenge);
            }
        }
    }
}