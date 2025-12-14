using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeZoo.Teil1
{
    class ZooIntro
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


            Console.WriteLine(zoo);
        }
    }
}
