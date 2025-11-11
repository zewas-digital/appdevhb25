using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe74
{
    class Liste
    {
        public Liste()
        {

        }

        // erstellen von Liste mit Ausgabe
        public static List<int> CreateList()
        {
            Random random = new Random();
            List<int> zahlen = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                int randomZahl = random.Next(1, 99);
                zahlen.Add(randomZahl);
            }

            return zahlen;
        }

        // Zählen der geraden Zahlen
        public static void ZaehlenGerade()
        {
            List<int> zahlen = CreateList();
            int counter = 0;

            foreach (int zahl in zahlen)
            {
                if (zahl % 2 == 0)
                {
                    counter++;
                }
            }

            var geradeZahlen = from zahl in zahlen
                               where zahl % 2 == 0
                               select zahl;

            var geradeZahlen2 = zahlen.Where(zahl => zahl % 2 == 0);

            System.Console.WriteLine(new string ('-',10));
            System.Console.WriteLine($"Die Anzahl der geraden Zahlen (mit foreach) beträgt: {counter}");
            System.Console.WriteLine($"Die Anzahl der geraden Zahlen (mit Abfrage) beträgt: {geradeZahlen.Count()}");
            System.Console.WriteLine($"Die Anzahl der geraden Zahlen (mit Where Methode) beträgt: {geradeZahlen2.Count()}");
            System.Console.WriteLine(new string ('-',10));
        }

        // Suche nach der kleinsten Zahl
        public static void KleinsteZahl()
        {
            List<int> zahlen = CreateList();
            int kleinsteZahl = 99;

            foreach (int zahl in zahlen)
            {
                if (zahl < kleinsteZahl)
                {
                    kleinsteZahl = zahl;
                }
            }

            int kleinsteZahl2 = zahlen.Min();

            System.Console.WriteLine($"Die kleinste Zahl in der Liste ist (mit Schleife): {kleinsteZahl}");
            System.Console.WriteLine($"Die kleinste Zahl in der Liste ist (mit Methode): {kleinsteZahl2}");
            System.Console.WriteLine(new string ('-',10));
        }

        // Suche nach der größten Zahl
        public static void GroessteZahl()
        {
            List<int> zahlen = CreateList();
            int groessteZahl = 0;

            foreach (int zahl in zahlen)
            {
                if (zahl > groessteZahl)
                {
                    groessteZahl = zahl;
                }
            }

            int greossteZahl2 = zahlen.Max();

            System.Console.WriteLine($"Die größte Zahl in der Liste ist (mit Schleife): {groessteZahl}");
            System.Console.WriteLine($"Die größte Zahl in der Liste ist (mit Methode): {greossteZahl2}");
            System.Console.WriteLine(new string ('-',10));
        }

        // Sortieren der Elemente
        public static void Sortieren()
        {
            List<int> zahlen = CreateList();

            var sortierteZahlen = zahlen.OrderBy(x => x);

            System.Console.WriteLine("Sortierte Liste mit OrderBy:");
            foreach (int zahl in sortierteZahlen)
            {
                System.Console.Write(zahl + ", ");
            }

            zahlen.Sort();
            System.Console.WriteLine("\nSortierte Liste mit Sort:");
            System.Console.WriteLine(string.Join(", ", zahlen));
            System.Console.WriteLine(new string ('-',10));
        }

        // Löschen der ungeraden Zahlen
        public static void LoeschenUngerade()
        {
            List<int> zahlen = CreateList();
            List<int> kopie = new List<int>(zahlen);

            for (int i = 0; i < zahlen.Count; i++)
            {
                if (zahlen[i] % 2 == 1)
                {
                    zahlen.RemoveAt(i);
                    i--;
                }
            }

            kopie.RemoveAll(n => n % 2 != 0);
            // foreach (int zahl in zahlen)
            // {
            //     if (zahl % 2 == 1)
            //     {
            //         zahlen.Remove(zahl);
            //     }
            // }
            
            Console.WriteLine("Gelöschte Ungerade Zahlen mit RemoveAll:\n"+string.Join(", ", kopie));
            Console.WriteLine("Gelöschte Ungerade Zahlen mit RemoveAt und for Schleife:\n"+string.Join(", ", zahlen));
            System.Console.WriteLine(new string('-', 10));


        }
        

        // 2. Teil der Aufgabenstelung

        public static void Teil2()
        {
            List<int> liste1 = CreateList();
            List<int> liste2 = CreateList();

            liste1.Sort();
            liste2.Sort();

            Console.WriteLine("Liste 1 sortiert: " + string.Join(", ", liste1));
            Console.WriteLine("Liste 2 sortiert: " + string.Join(", ", liste2));

            liste1.AddRange(liste2);
            liste1.Sort();
            Console.WriteLine("Liste 3 sortiert: " + string.Join(", ", liste1));
            
        }

        public static void Start()
        {
            ZaehlenGerade();
            KleinsteZahl();
            GroessteZahl();
            Sortieren();
            LoeschenUngerade();

            System.Console.WriteLine("Teil 2 der Übung");
            System.Console.WriteLine(new string('-', 50));

            Teil2();

        }

    }

}