namespace Appdevhb25.SabrinaFeurstein.aufgaben.zoo.teil2
{
    public class Zoo(string name, int gruendungsjahr)
    {
        public string Name { get; private set; } = name;
        public int Gruendungsjahr { get; private init; } = gruendungsjahr;
        public List<Gehege> Gehege { get; private set; } = new List<Gehege>();

        public void GehegeHinzufuegen(string name)
        {
            Gehege.Add(new Gehege(name));
        }
        public void GehegeEntfernen(string name)
        {
            bool gehegeEntfernt = false;
            foreach (Gehege gehege in Gehege)
            {
                if (gehege.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                {
                    Gehege.Remove(gehege);
                    gehegeEntfernt = true;
                    break;
                }
            }
            if (!gehegeEntfernt)
                Console.WriteLine("Unbekanntes Gehege. Gehege wurde nicht entfernt!");
        }
        public override string ToString()
        {
            return $"{Name}, gegründet {Gruendungsjahr}";
        }
    }
}