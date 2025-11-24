using System.Formats.Asn1;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe74
{
    public class ListeErstellen
    {
        public static void Start()
        {
            Random random = new Random();
            List<int> zahlen = new List<int>();

            Console.WriteLine("\nUnsortierte Liste:");
            for (int i = 0; i < 20; i++)
            {
                zahlen.Add(random.Next(0, 100));

                if (i < 19)
                    Console.Write(zahlen[i] + ", ");
                else
                    Console.WriteLine(zahlen[i]);
            }

            Console.WriteLine("\nAnzahl der geraden Zahlen: " + GeradeZahlen(zahlen));
            Console.WriteLine("Anzahl der kleinsten Zahl: " + KleinsteZahl(zahlen));
            Console.WriteLine("Anzahl der größten Zahl: " + GroessteZahl(zahlen));

            Sortieren(zahlen);
            Console.WriteLine("\nSortierte Liste:");
            for (int i = 0; i < zahlen.Count; i++)
            {
                if (i < zahlen.Count - 1)
                    Console.Write(zahlen[i] + ", ");
                else
                    Console.WriteLine(zahlen[i]);
            }

            UngeradeZahlenLoeschen(zahlen);
            Console.WriteLine("\nSortierte Liste ohne ungerade Zahlen:");
            for (int i = 0; i < zahlen.Count; i++)
            {
                if (i < zahlen.Count - 1)
                    Console.Write(zahlen[i] + ", ");
                else
                    Console.WriteLine(zahlen[i]);
            }
        }

        public static int GeradeZahlen(List<int> zahlen)
        {
            int anzahlGeradeZahlen = 0;
            for (int i = 0; i < zahlen.Count; i++)
            {
                if (zahlen[i] % 2 == 0)
                    anzahlGeradeZahlen++;
            }

            return anzahlGeradeZahlen;
        }

        public static int KleinsteZahl(List<int> zahlen)
        {
            // int kleinsteZahl = 100;
            // for (int i = 0; i < zahlen.Count; i++)
            // {
            //     if (zahlen[i] < kleinsteZahl)
            //         kleinsteZahl = zahlen[i];
            // }
            int kleinsteZahl = zahlen.Min();

            return kleinsteZahl;
        }

        public static int GroessteZahl(List<int> zahlen)
        {
            // int groessteZahl = 0;
            // for (int i = 0; i < zahlen.Count; i++)
            // {
            //     if (zahlen[i] > groessteZahl)
            //         groessteZahl = zahlen[i];
            // }
            int groessteZahl = zahlen.Max();
                        
            return groessteZahl;
        }

        public static List<int> Sortieren(List<int> zahlen)
        {
            // zahlen = zahlen.OrderByDescending(x => x).ToList();
            // zahlen.Sort((a, b) => b.CompareTo(a));
            zahlen.Sort();
            zahlen.Reverse();

            return zahlen;
        }

        public static List<int> UngeradeZahlenLoeschen(List<int> zahlen)
        {
            // for (int i = 0; i < zahlen.Count; i++)
            // {
            //     while (i < zahlen.Count && zahlen[i] % 2 != 0)
            //     {
            //         zahlen.RemoveAt(i);
            //     }
            // }
            zahlen.RemoveAll(n => n % 2 != 0);

            return zahlen;
        }
    }
}