namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe86
{
    public class Anruf(string name, string telefonnummer, DateTime zeitpunktDesAnrufs)
    {
        public string Name { get; set; } = name;
        public string Telefonnummer { get; set; } = telefonnummer;
        public DateTime ZeitpunktDesAnrufs { get; set; } = zeitpunktDesAnrufs;

        public override string ToString()
        {
            return $"Anruf von {Telefonnummer} - {Name} ({ZeitpunktDesAnrufs:G})";
        }
    }
}