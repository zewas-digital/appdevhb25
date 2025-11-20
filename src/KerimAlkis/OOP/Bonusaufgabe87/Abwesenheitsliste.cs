namespace Appdevhb25.KerimAlkis.Bonusaufgabe87
{
    public class Abwesenheitsliste
    {
        public static void Start()
        {
            Dictionary<string, List<Abwesenheit>> abwesenheitsliste = new();
            abwesenheitsliste.Add("Hans", new List<Abwesenheit>());
            abwesenheitsliste.Add("Peter", new List<Abwesenheit>());
            abwesenheitsliste.Add("Gunter", new List<Abwesenheit>());
            abwesenheitsliste.Add("Werner", new List<Abwesenheit>());
            do
            {
                Console.Clear();
                System.Console.WriteLine("PersonenListe:");
                foreach (var person in abwesenheitsliste)
                {
                    System.Console.WriteLine($"- {person.Key, -10} {CheckeAbwesenheit(person.Value)} Stunden");
                }
                System.Console.WriteLine();

                System.Console.WriteLine("Eingabe (Name): ");
                string? inputName = Console.ReadLine();
                if (abwesenheitsliste.ContainsKey(inputName))
                {
                    AbwesenheitHinzu(abwesenheitsliste, inputName);
                }
                else
                {
                    System.Console.WriteLine("Diesen Namen gibt es nicht");
                    Console.ReadKey();
                }
            } while (true);


        }
        public static void AbwesenheitHinzu(Dictionary<string, List<Abwesenheit>> liste, string name)
        {
            Console.Clear();
            System.Console.WriteLine(name + "'s Fehlzeit:");
            System.Console.WriteLine("StartDatum");
            DateTime start = GetDateTime();
            Console.Clear();
            System.Console.WriteLine("Enddatum");
            DateTime ende = GetDateTime();
            liste[name].Add(new Abwesenheit(start, ende));
        }
        public static double CheckeAbwesenheit(List<Abwesenheit> abwesenheiten)
        {
            if(abwesenheiten.Count == 0){ return 0; }
            double fehlstunden = 0;
            foreach (Abwesenheit abwesenheit in abwesenheiten)
            {
                fehlstunden += (abwesenheit.Endzeitpunkt - abwesenheit.Startzeitpunkt).TotalHours;
            }
            return fehlstunden;
        }
        public static DateTime GetDateTime()
        {
            Console.Write("Tag: ");
            int tag = Convert.ToInt16(Console.ReadLine());
            Console.Write("Monat: ");
            int monat = Convert.ToInt16(Console.ReadLine());
            Console.Write("Jahr: ");
            int jahr = Convert.ToInt16(Console.ReadLine());

            Console.Write("stunde: ");
            int stunde = Convert.ToInt16(Console.ReadLine());
            Console.Write("minute: ");
            int minute = Convert.ToInt16(Console.ReadLine());

            return new DateTime(jahr, monat, tag, stunde, minute, 0);
        }

    }
    public class Abwesenheit
    {
        public DateTime Startzeitpunkt;
        public DateTime Endzeitpunkt;

        public Abwesenheit(DateTime startzeitpunkt, DateTime endzeitpunkt)
        {
            Startzeitpunkt = startzeitpunkt;
            Endzeitpunkt = endzeitpunkt;
        }
    }
}