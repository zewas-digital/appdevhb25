namespace Appdevhb25.KatjaHaemmerli.AufgabeZoo
{
    public  class Tier
    {
        public string TierName;
        public string Gattung;
        public Dictionary<Futter, double> Futterbedarf = new Dictionary<Futter, double>(); // Futter und Menge
        public Tier(string name, string gattung)
        {
            TierName = name;
            Gattung = gattung;
        }
        public void AusgabeTierNamen()
        {     
            System.Console.WriteLine($"|          ├── {TierName}, {Gattung}");                        
        }
         public void FutterbedarfSpeichern(Futter futter, double menge)
        {
            Futterbedarf.Add(futter, menge);            
        }
        
    }
}