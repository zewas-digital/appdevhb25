using System;
using System.Collections;

namespace Appdevhb25.OliverBedogg.dyndatenstrukturen
{
    public class dyndatenstrukturenIntro
    {

        public static void Start()
        {
            ArrayListBeispiel();
            ListBeispiel();
        }

        private static void ArrayListBeispiel()
        {
            /*
            ArrayList
            - Dynamisch in der Größe
            - Kann verschiedene Datentypen speichern
            - Teil des `System.Collections` Namespace
            - Elemente werden als `object` gespeichert, daher ist Typumwandlung erforderlich
            - Nicht typsicher, daher weniger performant als generische Sammlungen
            */
            ArrayList exampleList = new ArrayList();

            exampleList.Add(5);
            exampleList.Add("Text");
            exampleList.Add(DateTime.Now);


            System.Console.WriteLine("\nArrayList -----------------");
            foreach (var elem in exampleList)
            {
                System.Console.WriteLine(elem.ToString());
            }
            System.Console.WriteLine("-\n");

            int result = (int)exampleList[0] + 5;
            System.Console.WriteLine(result);

            System.Console.WriteLine("---\n");
        }

        private static void ListBeispiel()
        {
            /*
            List<T>
            - Generische Sammlung, die eine bestimmte Datentyp speichert
            - Dynamisch in der Größe
            - Teil des `System.Collections.Generic` Namespace
            - Bietet typsicheren Zugriff auf Elemente
            - Besser in Leistung im Vergleich zu ArrayList
            */
            List<int> zahlen = new List<int> { 5, 2, 9, 1, 5, 6 };
            List<int> zahlen2 = new List<int>();

            // Einträge hinzufügen:
            zahlen.Add(32);
            zahlen.AddRange([12, 37]);
            
            zahlen.Sort(); // Sortiert die Liste in-place (verändert die Original-Liste)

            System.Console.WriteLine("\nList -----------------");
            foreach (int zahl in zahlen)
            {
                Console.WriteLine(zahl); // Ausgabe: 1, 2, 5, 5, 6, 9
            }

            // Einträge entfernen
            zahlen.Remove(5); // erstes gefundenes Element entfernen
            zahlen.RemoveAt(5); // Element über Index-Position entfernen

            System.Console.WriteLine("\n- OrderBy");

            var sortierteZahlen = zahlen.OrderBy(x => x); // Gibt eine neue sortierte IEnumerable-Liste zurück

            foreach (int zahl in sortierteZahlen)
            {
                Console.WriteLine(zahl); // Ausgabe: 1, 2, 5, 5, 6, 9
            }

            System.Console.WriteLine("---\n");


            List<string> values = new List<string>();
            values.Add("Anna");
            values.Add("Lena");

            // Anzahl Listeneinträge
            Console.WriteLine("Count: {0}", values.Count); // 2
            // Kapazität bis intern ein Resize durchgeführt wird:
            Console.WriteLine("Capacity: {0}", values.Capacity); // 4

            // Werte Zusammenführen
            Console.WriteLine("Namen: [{0}]", string.Join(", ", values));

            // Suche
            Console.WriteLine("Ist Anna dabei? " + values.Contains("Anna"));

            System.Console.WriteLine("---\n");
        }
    }
}
