using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeV86
{
    class Callcenter
    {
        public static void Start()
        {
            Queue<Anruf> warteschlange = new Queue<Anruf>();

            warteschlange.Enqueue(new Anruf("Selin", DateTime.Now.AddHours(-2), "0660 1234567"));
            warteschlange.Enqueue(new Anruf("Lena", DateTime.Now.AddHours(-1), "0660 1234567"));
            warteschlange.Enqueue(new Anruf("Max", DateTime.Now.AddHours(-3), "0660 1234567"));

            System.Console.WriteLine("Erhaltene Anrufe:\n");

            foreach(var a in warteschlange)
            {
                System.Console.WriteLine(a);
            }

            while(warteschlange.Count > 0 )
            {
                Anruf aktuell = warteschlange.Dequeue();
                System.Console.WriteLine($"Anruf abgearbeitet: {aktuell}");
            }

            System.Console.WriteLine("\nAlle Anrufe wurden abgearbeitet");
        }
    }

    class Anruf
    {
        public string Name { get; set; }
        public DateTime Datum { get; set; }
        public string Telefonnummer { get; set; }


        public Anruf(string name, DateTime datum, string telefonnummer)
        {
            Name = name;
            Datum = datum;
            Telefonnummer = telefonnummer;
        }

        public override string ToString()
        {
            return $"{Datum:G} - {Name} ({Telefonnummer})";
        }
    }
}