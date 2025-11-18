namespace Appdevhb25.MarcelSimma.Aufgabe77
{
    public class Serien
    {
        
        public static void Start()
        {
            /*
            Dictionary erstellen, um mehrere Seriennamen und Bewertungen zu speichern.
            Key: Name der Serie <string>
            Value: Bewertung <double>
            */

            // listeDerSerien = Objekt vom Typ Dictionary
            Dictionary<string, double> listeDerSerien = new Dictionary<string, double>();
            
            // Mit Add() kann ich ein Key-Value-Paar hinzufügen.
            listeDerSerien.Add("James Bond", 10);
            listeDerSerien.Add("Atypical", 8);
            listeDerSerien.Add("Stranger Things", 2);

            Serienausgabe(listeDerSerien);

            KeyValuePair<string, double> max = new KeyValuePair<string, double>();

            foreach (KeyValuePair<string, double> serie in listeDerSerien)
            {
                if (serie.Value > max.Value)
                {
                    max = serie;
                }
            }

            System.Console.WriteLine(max.Value);

            KeyValuePair<string, double> max2 = listeDerSerien.MaxBy(serie => serie.Value);

            System.Console.WriteLine(max2.Value);

            IEnumerable<KeyValuePair<string, double>> sorted = listeDerSerien.OrderBy(keyValuePairSerie => keyValuePairSerie.Key);

            double max3 = 0;
            max3 = listeDerSerien.Max(serie => serie.Value);
            System.Console.WriteLine(max3);

        }

        public static void Serienausgabe(Dictionary<string, double> serienliste)
        {
            foreach (KeyValuePair<string, double> serie in serienliste)
            {
                System.Console.WriteLine(serie.Key + " " + serie.Value);
            }
        }
    }
}