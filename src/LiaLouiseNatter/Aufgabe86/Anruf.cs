namespace Appdevhb25.LiaLouiseNatter.Aufgabe86
{
    public class Anruf
    {
        public string Name{get; set;}
        public DateTime Datum{get;set;}
        public string Telefonnummer{get;set;}

        public Anruf(string name, DateTime datum, string telefonNummer)
        {
            Name = name;
            Datum = datum;
            Telefonnummer = telefonNummer;
        }
    }
}