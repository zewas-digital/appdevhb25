using System.Formats.Asn1;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe74
{
    public class ListeZusammenfuehren
    {
        public static void Start()
        {
            Random random = new Random();
            List<int> zahlen1 = new List<int>();
            List<int> zahlen2 = new List<int>();
            List<int> zahlen3 = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                zahlen1.Add(random.Next(0, 100));
                zahlen2.Add(random.Next(0, 100));
            }

            zahlen1.Sort();
            zahlen2.Sort();

            Console.WriteLine("\nListe 1:");
            for (int i = 0; i < zahlen1.Count; i++)
            {
                if (i < zahlen1.Count - 1)
                    Console.Write(zahlen1[i] + ", ");
                else
                    Console.WriteLine(zahlen1[i]);
            }

            Console.WriteLine("\nListe 2:");
            for (int i = 0; i < zahlen2.Count; i++)
            {
                if (i < zahlen2.Count - 1)
                    Console.Write(zahlen2[i] + ", ");
                else
                    Console.WriteLine(zahlen2[i]);
            }

            zahlen3 = zahlen1;
            zahlen3.AddRange(zahlen2);
            zahlen3.Sort();

            Console.WriteLine("\nListe 3:");
            for (int i = 0; i < zahlen3.Count; i++)
            {
                if (i < zahlen3.Count - 1)
                    Console.Write(zahlen3[i] + ", ");
                else
                    Console.WriteLine(zahlen3[i]);
            }
        }
    }
}