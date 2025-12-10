using Org.BouncyCastle.Asn1.X509;

namespace Appdevhb25.LauraKatharinaBertsch.ZooTeil2
{
    public class Zoo
    {
        public static List<Enclosure> enclosures = new List<Enclosure>();
        public string Name { get; private set; }
        public int Date { get; private init; }

        public Zoo(string name, int date)
        {
            Name = name;
            Date = date;
        }
        public override string ToString()
        {
            string zoo = $"|--Zoo: {Name}, gegründet {Date}\n";
            foreach (var enclosure in enclosures)
            {
                zoo += enclosure;
            }
            return zoo;
        }
        public void AddEnclosure(Enclosure name)
        {
            enclosures.Add(name);
        }
    }
}