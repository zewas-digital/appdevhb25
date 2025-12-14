using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.AufgabeZoo02
{
    public class Main
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Tiergarten Dornbirn", 2022);

            Enclosure e1 = new Enclosure("Alpenwiese");
            Enclosure e2 = new Enclosure("Ried");
            Enclosure e3 = new Enclosure("Terrarium (warm)");

            Animal a1 = new Animal("Rijska", "Kuh");
            Animal a2 = new Animal("Garmond", "Storch");
            Animal a3 = new Animal("Hugo", "Storch");
            Animal a4 = new Animal("Idaxis", "Storch");


            zoo.AddEnclosure(e1);
            zoo.AddEnclosure(e2);
            zoo.AddEnclosure(e3);

            zoo.enclosures[0].AddAnimal(a1);

            zoo.enclosures[1].AddAnimal(a2);
            zoo.enclosures[1].AddAnimal(a3);
            zoo.enclosures[1].AddAnimal(a4);

            System.Console.WriteLine(zoo.ToString());
        }       
    }
}