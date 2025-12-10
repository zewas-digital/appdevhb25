using Org.BouncyCastle.Asn1.X509;

namespace Appdevhb25.LauraKatharinaBertsch.ZooTeil1
{
    public class Zoo
    {
        public static  List<Enclosure> enclosures = new List<Enclosure>();
        public string Name { get; private set; }
        public int Date { get; private init; }

        public Zoo(string name, int date)
        {
            Name = name;
            Date = date;
        }
        public override string ToString()
        {
            return $"|--Zoo: {Name}, gegründet {Date}";
        }
        public static void AddEnclosure()
        {

            Enclosure enclosure1 = new Enclosure("Dschungel");
            enclosures.Add(enclosure1);
            Enclosure enclosure2 = new Enclosure("Nordpool");
            enclosures.Add(enclosure2);
            Enclosure enclosure3 = new Enclosure("Aquarium");
            enclosures.Add(enclosure3);
            Enclosure enclosure4 = new Enclosure("Savanne");
            enclosures.Add(enclosure4);
        }
    }
}