namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe84
{
    public class Fotoapparat : IGegenstand 
    {
        public string Inventarnummer { get; set; }
        public int Brennweite { get; set; }
        public string Modell { get; set; }
        public string Hersteller { get; set; }
        public double Megapixel { get; set; }
        
        public Fotoapparat(string inventarnummer, int brennweite, string modell, string hersteller, double megapixel)
        {
            Inventarnummer = inventarnummer;
            Brennweite = brennweite;
            Modell = modell;
            Hersteller = hersteller;
            Megapixel = megapixel;
        }

        public string GetGegenstandInfo()
        {
            return $"(Fotoapparat) Inv.-Nr.: {Inventarnummer} | {Hersteller} {Modell}, {Brennweite} mm, {Megapixel} MP";
        }
    }
}