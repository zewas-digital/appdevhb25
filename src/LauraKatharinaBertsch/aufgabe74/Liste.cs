namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe74
{
    public class Liste
    {
        public static void Start()
        {
            Random random = new Random();

            List<int> numbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(random.Next(1, 99));
                Console.Write(numbers[i] + " ");
            }
            int anzahlGeradeZahlen = GeradeZahlen(numbers);
            int kleinsteZahl = KleinsteZahl(numbers);
            int größteZahl = GrößteZahl(numbers);
            List<int> sortierteZahlen = ListeSortiert(numbers);
            List<int> ungeradeZahlenGelöscht = UngeradeZahlenLöschen(numbers);
            List<int> zweiListen = ZweiListenErstellen();
            Console.WriteLine();
            Console.WriteLine("Anzahl der geraden Zahlen: " + anzahlGeradeZahlen);
            Console.WriteLine("Die kleinste Zahl ist: " + kleinsteZahl);
            Console.WriteLine("Die größte Zahl ist: " + größteZahl);
            Console.WriteLine("Die Zahlen von groß nach klein sortiert sind: " + string.Join(" ", sortierteZahlen));
            Console.WriteLine("Die ungeraden Zahlen sind gelöscht: " + string.Join(" ", ungeradeZahlenGelöscht));
            Console.WriteLine("Zwei Listen zusammengefügt: " + string.Join(" ", zweiListen));
        }

        public static int GeradeZahlen(List<int> number)
        {
            List<int> sortierteListe = new List<int>(number);
            sortierteListe.RemoveAll(number => number % 2 == 1);
            int count = sortierteListe.Count;
            return count;
        }

        public static int KleinsteZahl(List<int> number)
        {
            int kleinsteZahl = number.Min();
            return kleinsteZahl;
        }

        public static int GrößteZahl(List<int> number)
        {
            int größteZahl = number.Max();
            return größteZahl;
        }

        public static List<int> ListeSortiert(List<int> number)
        {
            List<int> sortierteListe = new List<int>(number);
            sortierteListe.Sort();
            sortierteListe.Reverse();
            return sortierteListe;
        }

        public static List<int> UngeradeZahlenLöschen(List<int> number)
        {
            List<int> sortierteListe = new List<int>(number);
            sortierteListe.RemoveAll(number => number % 2 == 1);
            return sortierteListe;
        }

        public static List<int> ZweiListenErstellen()
        {
            Random random = new Random();

            List<int> numbers1 = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                numbers1.Add(random.Next(1, 99));
                numbers1.Sort();
            }

            List<int> numbers2 = new List<int>();
            for (int j = 0; j < 20; j++)
            {
                numbers2.Add(random.Next(1, 99));
                numbers2.Sort();
            }
            List<int> list = ListenZusammenfügen(numbers1, numbers2);
            return list;
        }
        public static List<int> ListenZusammenfügen(List<int> numbers1, List<int> numbers2)
        {
            List<int> list1 = new List<int>(numbers1);
            List<int> list2 = new List<int>(numbers2);
            list1.AddRange(list2);
            list1.Sort();
            return list1;
        }
    }
}