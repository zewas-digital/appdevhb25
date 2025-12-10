using Org.BouncyCastle.Asn1.Misc;

namespace Appdevhb25.NoahHois.ZooTeil1
{
    //  ─ │ ┌ ┐ └ ┘ ├ ┤ ┬ ┴ ┼|│
    public class Zoo
    {
        public string Name { get; private set; }
        public int Gruendungsjahr { get; private set; }

        public Zoo(string name, int gruendungsjahr)
        {
            Name = name;
            Gruendungsjahr = gruendungsjahr;
        }
        private List<Gehege> _gehege = new List<Gehege>();

        public void GehegeHinzufügen(Gehege gehege)
        {
            _gehege.Add(gehege);
        }
        public void GehegeEntfernen(Gehege gehege)
        {
            _gehege.Remove(gehege);
        }
        public void AusgabeZoo()
        {
            System.Console.WriteLine($"├── Zoo: {Name} Feldkirch, gegründet {Gruendungsjahr}");
            foreach (var gehege in _gehege)
            {
                System.Console.WriteLine($"│    ├── Gehege: {gehege.Name}");
            }
        }
    }
}