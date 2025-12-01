namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe84
{
    public class Auto : IGegenstand
    {
        public string Inventarnummer { get; set; }
        public string Farbe { get; set; }
        public double Kilometerstand { get; set; }
        public string Kennzeichen { get; set; }
        public double Verbrauch { get; set; }

        public Auto(string inventarnummer, string farbe, double kilometerstand, string kennzeichen, double verbrauch)
        {
            Inventarnummer = inventarnummer;
            Farbe = farbe;
            Kilometerstand = kilometerstand;
            Kennzeichen = kennzeichen;
            Verbrauch = verbrauch;

        }

        public string GetGegenstandInfo()
        {
            return $"(Auto) Inv.-Nr.: {Inventarnummer} | {Kennzeichen}, {Farbe}, {Kilometerstand} km, {Verbrauch:F2} L/100";
        }
    }
}