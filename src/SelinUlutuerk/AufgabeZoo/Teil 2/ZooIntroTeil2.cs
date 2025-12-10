using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeZoo.Teil1
{
    class ZooIntroTeil2
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Tiergarten Dornbirn", 2025);

            // Gehege anlegen
            Gehege alpenwiese = new Gehege("Alpenwiese");
            Gehege ried = new Gehege("Ried");
            Gehege terrarium1 = new Gehege("Terrarium (warm)");

            zoo.HinzufuegenGehege(alpenwiese);
            zoo.HinzufuegenGehege(ried);
            zoo.HinzufuegenGehege(terrarium1);

            // Tiere
            alpenwiese.HinzufuegenTier(new Tier("Rijska", Tier.Gattungen.Kuh));

            ried.HinzufuegenTier(new Tier("Garmond", Tier.Gattungen.Storch));
            ried.HinzufuegenTier(new Tier("Hugo", Tier.Gattungen.Storch));
            ried.HinzufuegenTier(new Tier("Idaxis", Tier.Gattungen.Storch));

            Console.WriteLine(zoo);
        }
    }
}
