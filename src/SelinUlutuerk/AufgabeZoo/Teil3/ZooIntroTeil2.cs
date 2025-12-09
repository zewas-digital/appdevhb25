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
            Futter fleisch = new Futter ("Fleisch", "kg", 10.00m);

            // Gehege anlegen
            Gehege alpenwiese = new Gehege("Alpenwiese");
            Gehege ried = new Gehege("Ried");
            Gehege terrarium1 = new Gehege("Terrarium (warm)");
            Gehege arktis = new Gehege ("Arktis");

            zoo.HinzufuegenGehege(arktis);
            zoo.HinzufuegenGehege(alpenwiese);
            zoo.HinzufuegenGehege(ried);
            zoo.HinzufuegenGehege(terrarium1);

            // Tiere
            alpenwiese.HinzufuegenTier(new Tier("Rijska", Tier.Gattungen.Kuh, heu, 5));

            ried.HinzufuegenTier(new Tier("Garmond", Tier.Gattungen.Storch, fisch, 3));
            ried.HinzufuegenTier(new Tier("Hugo", Tier.Gattungen.Storch, fisch, 2));
            ried.HinzufuegenTier(new Tier("Idaxis",Tier.Gattungen.Storch, fisch, 3));

            arktis.HinzufuegenTier(new Tier("Berni", Tier.Gattungen.Eisbaer, fleisch, 10.50m));

            Console.WriteLine(zoo);
            System.Console.WriteLine();
            zoo.AusgabeFutterbedarf();
            
        }
    }
}
