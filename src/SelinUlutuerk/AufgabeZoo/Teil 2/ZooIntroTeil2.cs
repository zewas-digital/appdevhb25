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
            alpenwiese.HinzufuegenTier(new Tier("Rijska", "Kuh"));

            ried.HinzufuegenTier(new Tier("Garmond", "Storch"));
            ried.HinzufuegenTier(new Tier("Hugo", "Storch"));
            ried.HinzufuegenTier(new Tier("Idaxis", "Storch"));

            Console.WriteLine(zoo);
        }
    }
}
