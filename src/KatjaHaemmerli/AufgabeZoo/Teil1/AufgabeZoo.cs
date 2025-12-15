using System;
using System.Text;
namespace Appdevhb25.KatjaHaemmerli.AufgabeZoo
{
    public  class AufgabeZoo
    {
        public static void Start()
        {
            Console.OutputEncoding = Encoding.Default;
            Zoo zoo = new Zoo("Walterzoo", "1961");
            Gehege gehege = new Gehege("Löwengehege");
            Gehege gehege2 = new Gehege("Wolfsgehege");
            Gehege aquarium = new Gehege("Aquarium");
                     
            zoo.GehegeHinzufuegen(gehege2);           
            zoo.GehegeHinzufuegen(gehege);
            zoo.GehegeHinzufuegen(aquarium);
            // zoo.GehegeEntfernen(gehege2);   

            // Teil2
            Tier tier1 = new Tier("Leo", "Löwe");
            Tier tier2 = new Tier("Lupin", "Wolf");
            Tier tier3 = new Tier("Simba","Löwe");
            gehege.TierHinzugfuegen(tier3);
            gehege.TierHinzugfuegen(tier1);
            gehege2.TierHinzugfuegen(tier2);
            //zoo.AusgabeNamen();

            //Teil4 (wegen reihenfolge der Ausgabe ist Teil4 nach Teil 2)
            Pfleger pfleger = new Pfleger("Walter");
            Pfleger pfleger2 = new Pfleger("Moritz");
            Pfleger pfleger3 = new Pfleger("Norman");
            
            zoo.PflegerHinzufügen(pfleger, pfleger2, pfleger3);
            pfleger.PflegerGehegeHinzufuegen(gehege);
            pfleger2.PflegerGehegeHinzufuegen(gehege2);
            pfleger3.PflegerGehegeHinzufuegen(aquarium);
            
            //Teil3
            Futter futterLöwe = new Futter("Zebrafleisch     ","kg", 50, "€");
            Futter futterWolf = new Futter("rohes Rindfleisch", "kg", 40, "€");
            tier1.FutterbedarfSpeichern( futterLöwe , 40);
            tier2.FutterbedarfSpeichern( futterWolf , 25);            

            zoo.FutterbedarfZusammenzaehlen();
            System.Console.WriteLine(); // Abstand
            zoo.FutterbedarfAusgeben();
            zoo.AusgabeGanzeStruktur();             
        }
    }
}