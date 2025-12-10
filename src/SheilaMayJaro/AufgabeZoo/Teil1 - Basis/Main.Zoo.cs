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
            Enclosure monkeyhouse = new Enclosure("Affengehege");
            brZoo.AddEnclosure(monkeyhouse);
            System.Console.WriteLine(new string('-', 70));
            // brZoo.DisplayZooStructure();

            System.Console.WriteLine("Aufgabe Zoo - Teil 2:\nTiere hinzufügen");
            System.Console.WriteLine();

            Animal bobLion = new Animal("Bob", "Löwe");
            Animal carmenCapybara = new Animal("Carmen", "Wasserschwein");
            lionEnclosure.AddAnimal(bobLion);
            Animal simbaLion = new Animal("Simba", "Löwe");
            lionEnclosure.AddAnimal(simbaLion); 
            capybaraEnclosure.AddAnimal(carmenCapybara);
            Animal eliseCapybara = new Animal("Elise", "Wasserschwein");
            capybaraEnclosure.AddAnimal(eliseCapybara);
            Animal walterShark = new Animal("Walter", "Hai");
            aquarium.AddAnimal(walterShark);
            Animal lindaAxolotl = new Animal("Linda", "Axolotl");
            aquarium.AddAnimal(lindaAxolotl); 
            Animal nemoWhale = new Animal("Nemo", "Belugawal");
            aquarium.AddAnimal(nemoWhale); 
            Animal tigeraugeButterfly = new Animal("Tigerauge", "Zitronenfalter");
            butterflyHouse.AddAnimal(tigeraugeButterfly); 
            Animal mariaButterfly = new Animal("Maria", "Bläuling"); 
            butterflyHouse.AddAnimal(mariaButterfly);
            Animal robertFlamingo = new Animal("Robert", "Flamingo");
            birdEnclosure.AddAnimal(robertFlamingo); 
            Animal weathersEmu = new Animal("Weathers", "Emu");
            birdEnclosure.AddAnimal(weathersEmu);
            Animal azulPeacock = new Animal("Azul", "Pfau");
            birdEnclosure.AddAnimal(azulPeacock);
            // brZoo.DisplayZooStructure();
            Animal kingJulienLemur = new Animal("King Julien", "Lemur"); 
            Animal mortLemur = new Animal("Mort", "Lemur"); 
            Animal mauriceLemur = new Animal("Maurice","Lemur");
            Animal sandraChimpanzee = new Animal("Sandra","Schimpanse");
            monkeyhouse.AddAnimal(kingJulienLemur); 
            monkeyhouse.AddAnimal(mortLemur); 
            monkeyhouse.AddAnimal(mauriceLemur); 
            monkeyhouse.AddAnimal(sandraChimpanzee); 
            System.Console.WriteLine();
            System.Console.WriteLine(new string('-', 70));
            System.Console.WriteLine("Aufgabe Zoo - Teil 3:\nTierfutter hinzufügen");
            brZoo.DisplayZooStructure();
            
            //Futter 
            Food water = new Food("Wasser", "L", 0.80);
            Food fruit = new Food("Frucht", "g", 2.30); 
            Food waterSnails = new Food("Wasserschnecken", "g", 28.24); 
            Food shrimps = new Food("Garnelen", "kg", 32.78); 
            Food crustaceans = new Food("Krebstiere", "g", 22.68); //Krebstiere
            Food fish = new Food("Fisch", "kg", 98.45); 
            Food vegetables = new Food("Gemüse", "kg", 74.53);
            Food steak = new Food("Steak", "kg", 154.26);
            bobLion.AddFodderRequirements(steak, 27);
            carmenCapybara.AddFodderRequirements(vegetables,18); 
            simbaLion.AddFodderRequirements(steak, 23); 
            eliseCapybara.AddFodderRequirements(vegetables, 13); 
            walterShark.AddFodderRequirements(fish, 51); 
            lindaAxolotl.AddFodderRequirements(crustaceans, 9); 
            nemoWhale.AddFodderRequirements(shrimps, 17); 
            robertFlamingo.AddFodderRequirements(waterSnails, 7);
             

        


            
        }
    }
}