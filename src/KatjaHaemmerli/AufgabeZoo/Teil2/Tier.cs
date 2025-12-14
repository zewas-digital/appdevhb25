namespace Appdevhb25.KatjaHaemmerli.AufgabeZoo
{
    public  class Tier
    {
        public string TierName;
        public string Gattung;
        public Tier(string name, string gattung)
        {
            TierName = name;
            Gattung = gattung;
        }
        public void AusgabeNamen()
        {           
            System.Console.WriteLine($"|      ├── {TierName}, {Gattung}");                        
        }
    }
}