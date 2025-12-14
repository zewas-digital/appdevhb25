using System;
namespace Appdevhb25.KatjaHaemmerli.AufgabeZoo
{
    public  class AufgabeZoo
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Walterzoo", "1961");
            Gehege gehege = new Gehege("Löwengehege");
            Gehege gehege2 = new Gehege("Wolfsgehege");
                     
            zoo.GehegeHinzufuegen(gehege);
            zoo.GehegeHinzufuegen(gehege2);
            zoo.AusgabeNamen();
            zoo.GehegeEntfernen(gehege2);
            zoo.AusgabeNamen();

            // Teil2
            Tier tier = new Tier("Leo", "Löwe");
            tier.AusgabeNamen();
            
        }
    }
}