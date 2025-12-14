using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.AufgabeZoo04
{
    public class Main
    {
        public static void Start()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            Zoo zoo = new Zoo("Tiergarten Dornbirn", 2022);

            Enclosure e1 = new Enclosure("Alpenwiese");
            Enclosure e2 = new Enclosure("Ried");
            Enclosure e3 = new Enclosure("Terrarium (warm)");

            Food f1 = new Food("Heu", "kg", 0.5m);
            Food f2 = new Food("Wasser", "L", 0.02m);

            FeedRequirement fr1 = new FeedRequirement(f1, 20);
            FeedRequirement fr2 = new FeedRequirement(f2, 100.05);


            Animal a1 = new Animal("Rijska", "Kuh", fr1);
            Animal a2 = new Animal("Garmond", "Storch", fr1);
            Animal a3 = new Animal("Hugo", "Storch", fr2);
            Animal a4 = new Animal("Idaxis", "Storch", fr1);


            zoo.AddEnclosure(e1);
            zoo.AddEnclosure(e2);
            zoo.AddEnclosure(e3);

            zoo.Enclosures[0].AddAnimal(a1);

            zoo.Enclosures[1].AddAnimal(a2);
            zoo.Enclosures[1].AddAnimal(a3);
            zoo.Enclosures[1].AddAnimal(a4);
            
            System.Console.WriteLine(zoo.ToString());
            zoo.UpdateTotalFeedRequirement();
            zoo.PrintTotalFeedRequirement();
        }       
    }
}