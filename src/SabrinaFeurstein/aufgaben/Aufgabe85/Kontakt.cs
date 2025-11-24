namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe85
{
    public class Kontakt
    {
        public string Nachname { get; set; }
        public string Ort { get; set; }
        public string Telefonnummer { get; set; }

        public Kontakt(string nachname, string ort, string telefonnummer)
        {
            Nachname = nachname;
            Ort = ort;
            Telefonnummer = telefonnummer;
        }
    }
}