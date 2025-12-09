using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeZoo.Teil3
{
    class ZooIntro
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Tiergarten Dornbirn", 2025);

            // Futterbedarf
            Futter heu = new Futter("Heu", "kg", 0.50m);
            Futter wasser = new Futter("Wasser", "L", 0.02m);
            Futter fisch = new Futter("Fisch", "kg", 3.00m);
            Futter fleisch = new Futter("Fleisch", "kg", 10.00m);

            // Gehege anlegen
            Gehege alpenwiese = new Gehege("Alpenwiese");
            Gehege ried = new Gehege("Ried");
            Gehege terrarium1 = new Gehege("Terrarium (warm)");
            Gehege arktis = new Gehege("Arktis");

            zoo.HinzufuegenGehege(arktis);
            zoo.HinzufuegenGehege(alpenwiese);
            zoo.HinzufuegenGehege(ried);
            zoo.HinzufuegenGehege(terrarium1);

            // Tiere
            Tier kuh1 = new Tier("Rijska", Tier.Gattungen.Kuh);
            kuh1.Futterbedarf.Add(heu, 5);
            kuh1.Futterbedarf.Add(wasser,10);
            alpenwiese.HinzufuegenTier(kuh1);

            Tier storch1 = new Tier("Garmond", Tier.Gattungen.Storch);
            storch1.Futterbedarf.Add(fisch, 3);
            ried.HinzufuegenTier(storch1);

            Tier storch2 = new Tier("Hugo", Tier.Gattungen.Storch);
            storch2.Futterbedarf.Add(fisch, 2);
            ried.HinzufuegenTier(storch2);

            Tier storch3 = new Tier("Idaxis", Tier.Gattungen.Storch);
            storch3.Futterbedarf.Add(fisch, 1.5m);
            ried.HinzufuegenTier(storch3);

            Tier eisbaer1 = new Tier("Berni", Tier.Gattungen.Eisbaer);
            eisbaer1.Futterbedarf.Add(fleisch,10.50m);
            eisbaer1.Futterbedarf.Add(wasser,3);
            arktis.HinzufuegenTier(eisbaer1);

            Console.WriteLine(zoo);
            System.Console.WriteLine();
            zoo.AusgabeFutterbedarf();

        }
    }
}
