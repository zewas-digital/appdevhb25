namespace Appdevhb25.KatjaHaemmerli.AufgabeZoo
{
    public  class Gehege
    {
        public string GehegeName;
        internal List<Tier> tierListe = new List<Tier>();
        
        public Gehege(string gehegeName)
        {
            GehegeName = gehegeName;
        }
        public void TierHinzugfügen(Tier tier)
        {
            tierListe.Add(tier);
        }
        public void TierEntfernen(Tier tier)
        {
            tierListe.Remove(tier);
        }
    }
}