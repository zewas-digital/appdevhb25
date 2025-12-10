using Org.BouncyCastle.Crypto.Modes;

namespace Appdevhb25.SheilaMayJaro.AufgabeZoo
{
    public class AufgabeZoo
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe Zoo - Teil 1:\nBasis vom Zoo erstellen");
            System.Console.WriteLine();
            Zoo brZoo = new Zoo("Bregenzer Zoo", "2025");
            Enclosure lionEnclosure = new Enclosure("Löwengehege"); 
            Enclosure birdEnclosure = new Enclosure("Vögelparadies"); 
            Enclosure capybaraEnclosure = new Enclosure("Wasserschweingehege"); 
            Enclosure aquarium = new Enclosure("Aquarium"); 
            Enclosure butterflyHouse = new Enclosure("Schmetterlingshaus"); 

            brZoo.AddEnclosure(lionEnclosure);
            brZoo.AddEnclosure(birdEnclosure); 
            brZoo.AddEnclosure(capybaraEnclosure); 
            brZoo.AddEnclosure(aquarium); 
            brZoo.AddEnclosure(butterflyHouse); 
            // brZoo.DisplayZooStructure();
            brZoo.RemoveEnclosure(capybaraEnclosure); 
            brZoo.AddEnclosure(new Enclosure("Affengehege"));
            System.Console.WriteLine("----------------------------------------------------");
            // brZoo.DisplayZooStructure();

            System.Console.WriteLine("Aufgabe Zoo - Teil 2:\nTiere hinzufügen");
            System.Console.WriteLine();

            Animal lion = new Animal("Bob", "Löwe");
            Animal capybara = new Animal("Carmen", "Wasserschwein");
            lionEnclosure.AddAnimal(lion);
            lionEnclosure.AddAnimal(new Animal("Simba", "Löwe")); 
            capybaraEnclosure.AddAnimal(capybara);
            capybaraEnclosure.AddAnimal(new Animal ("Elise", "Wasserschwein"));
            aquarium.AddAnimal(new Animal("Walter", "Hai"));
            aquarium.AddAnimal(new Animal("Linda", "Axolotl")); 
            aquarium.AddAnimal(new Animal("Nemo", "Balugawal")); 
            butterflyHouse.AddAnimal(new Animal("Tigerauge", "Zitronenfalter")); 
            butterflyHouse.AddAnimal(new Animal("Maria", "Bläuling"));
            birdEnclosure.AddAnimal(new Animal("Robert", "Flamingo")); 
            birdEnclosure.AddAnimal(new Animal("Weathers", "Emu"));
            birdEnclosure.AddAnimal(new Animal("Azul", "Pfau"));
            brZoo.DisplayZooStructure();
        }
    }
}