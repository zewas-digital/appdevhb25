namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe84
{
    public class Motorrad : IGegenstand
    {
        public string Inventarnummer { get; set; }
        public double Kilometerstand { get; set; }
        public string Farbe { get; set; }
        public int Leistung { get; set; }
        public double Kaufpreis { get; set; }
        public string Kennzeichen { get; set; }

        public Motorrad(string inventarnummer, double kilometerstand, string farbe, int leistung, double kaufpreis, string kennzeichen)
        {
            Inventarnummer = inventarnummer;
            Kilometerstand = kilometerstand;
            Farbe = farbe;
            Leistung = leistung;
            Kaufpreis = kaufpreis;
            Kennzeichen = kennzeichen;
        }

        public string GetGegenstandInfo()
        {
            return $"(Auto) Inv.-Nr.: {Inventarnummer} | {Kennzeichen}, {Farbe}, {Kilometerstand} km, {Leistung} kW, {Kaufpreis} EUR";
        }
    }
}