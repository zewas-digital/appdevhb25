using Appdevhb25.KerimAlkis.Aufgabe04;

namespace Appdevhb25.KerimAlkis.Aufgabe74
{
    public class Liste
    {
        public static void Start()
        {
            //Teil 1
            Console.WriteLine("Teil 1");
            List<int> zufallsZahlen = new List<int>();

            Random rdn = new Random();
            for (int i = 0; i < 20; i++)
            {
                zufallsZahlen.Add(rdn.Next(0, 99));
            }
            System.Console.WriteLine("ZufallsZahlen");
            foreach(int zahl in zufallsZahlen){ System.Console.Write(zahl+ " "); }
            System.Console.WriteLine();

            GeradeZahlenZaehler(zufallsZahlen);
            KleinsteZahl(zufallsZahlen);
            GroessteZahl(zufallsZahlen);
            zufallsZahlen = SortAbsteigend(zufallsZahlen);
            LoescheUngeradenZahlen(zufallsZahlen);

            //Teil 2
            System.Console.WriteLine();
            Console.WriteLine("Teil 2");
            List<int> List1 = new List<int>();
            List<int> List2 = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                List1.Add(rdn.Next(0, 99));
            }
            for (int i = 0; i < 20; i++)
            {
                List2.Add(rdn.Next(0, 99));
            }
            List1.Sort();
            List2.Sort();
            foreach(int zahl in List1){ System.Console.Write(zahl+ " "); }
            System.Console.WriteLine();
            foreach(int zahl in List2){ System.Console.Write(zahl+ " "); }
            System.Console.WriteLine();

            List<int> NeueList = new List<int>();
            NeueList.AddRange(List1);
            NeueList.AddRange(List2);
            NeueList.Sort();
            foreach(int zahl in NeueList){ System.Console.Write(zahl+ " "); }
            System.Console.WriteLine();

        }
        public static void GeradeZahlenZaehler(List<int> zufallsZahlen)
        {
            System.Console.WriteLine("Ungerade Zahlen: " + zufallsZahlen.Count(TestUngeradeZahl));
        }

        public static void KleinsteZahl(List<int> zufallsZahlen)
        {
            System.Console.WriteLine("Kleinste Zahl: " + zufallsZahlen.Min());
        }

        public static void GroessteZahl(List<int> zufallsZahlen)
        {
            System.Console.WriteLine("Groesste Zahl: " + zufallsZahlen.Max());
        }

        public static List<int> SortAbsteigend(List<int> zufallsZahlen)
        {
            var geordnet = zufallsZahlen.OrderDescending();
            
            System.Console.WriteLine("GeordneteZahlen");
            foreach (var zahl in geordnet) { System.Console.Write(zahl + " "); }
            zufallsZahlen = geordnet.ToList();
            System.Console.WriteLine();
            return zufallsZahlen;
        }

        public static void LoescheUngeradenZahlen(List<int> zufallsZahlen)
        {
            //zufallsZahlen.RemoveAll(n => n % 2 != 0);
            zufallsZahlen.RemoveAll(TestUngeradeZahl);

            System.Console.WriteLine("ZufallsZahlen");
            foreach (int zahl in zufallsZahlen) { System.Console.Write(zahl + " "); }
            System.Console.WriteLine();
        }
        public static bool TestUngeradeZahl(int i)
        {
            if (i % 2 == 0) { return false; }
            else{ return true; }
        }
    }
}