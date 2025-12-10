namespace Appdevhb25.NoahHois.ZooTeil3
{
    public class ProgrammStart
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Wildpark", 1990);
            Gehege tropisch = new Gehege("Tropisch");
            Gehege alpen = new Gehege("Alpen");
            Gehege meer = new Gehege("Meer");
            Gehege wald = new Gehege("Wald");
            Gehege wueste = new Gehege("Wüste");
            Gehege ried = new Gehege("Ried");
            Gehege luft = new Gehege("Luft");

            Tier murmeltier = new Tier("Freddie", "Murmeltier");
            Tier waschbaer = new Tier("Silke", "Waschbär");
            Tier storch = new Tier("Sven", "Storch");
            Tier spatz = new Tier("Sebastian", "Spatz");
            Tier elefant = new Tier("Tim", "Elefant");
            Tier adler = new Tier("Kerim", "Steinadler");
            zoo.GehegeHinzufügen(tropisch);
            zoo.GehegeHinzufügen(alpen);
            zoo.GehegeHinzufügen(meer);
            zoo.GehegeHinzufügen(wald);
            zoo.GehegeHinzufügen(wueste);
            zoo.GehegeHinzufügen(ried);
            zoo.GehegeHinzufügen(luft);
            zoo.GehegeEntfernen(tropisch);
            zoo.GehegeEntfernen(meer);
            zoo.GehegeEntfernen(wueste);
            alpen.TierHinzufügen(murmeltier);
            wald.TierHinzufügen(waschbaer);
            ried.TierHinzufügen(storch);
            luft.TierHinzufügen(spatz);
            luft.TierHinzufügen(elefant);
            luft.TierEntfernen(elefant);
            alpen.TierHinzufügen(adler);
            zoo.AusgabeZoo();


        }
    }
}