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
            // brZoo.DisplayZooStructure();
            //Futter 
            Food water = new Food("Wasser", "L", 0.80);
            Food fruit = new Food("Frucht", "kg", 2.30); 
            Food waterSnails = new Food("Wasserschnecken", "g", 28.24); 
            Food shrimps = new Food("Garnelen", "kg", 32.78); 
            Food crustaceans = new Food("Krebstiere", "kg", 22.68); //Krebstiere
            Food fish = new Food("Fisch", "kg", 98.45); 
            Food vegetables = new Food("Gemüse", "kg", 74.53);
            Food steak = new Food("Steak", "kg", 154.26);   
            bobLion.AddFodderRequirements(steak, 78.78);
            bobLion.AddFodderRequirements(water, 8); 
            carmenCapybara.AddFodderRequirements(vegetables, 75.12); 
            carmenCapybara.AddFodderRequirements(water, 4); 
            simbaLion.AddFodderRequirements(steak, 27.05);
            simbaLion.AddFodderRequirements(water, 9); 
            eliseCapybara.AddFodderRequirements(vegetables, 60.16);
            eliseCapybara.AddFodderRequirements(water, 5); 
            walterShark.AddFodderRequirements(fish, 42.78);
            lindaAxolotl.AddFodderRequirements(crustaceans, 2.15); 
            nemoWhale.AddFodderRequirements(shrimps, 274.36); 
            robertFlamingo.AddFodderRequirements(waterSnails, 2.36);
            robertFlamingo.AddFodderRequirements(water, 12); 
            weathersEmu.AddFodderRequirements(fruit, 2.45);
            weathersEmu.AddFodderRequirements(water, 6); 
            azulPeacock.AddFodderRequirements(fruit, 14.00);
            azulPeacock.AddFodderRequirements(water, 7);
            kingJulienLemur.AddFodderRequirements(fruit, 123.45);
            kingJulienLemur.AddFodderRequirements(water, 4);  
            mortLemur.AddFodderRequirements(fruit, 80.56); 
            mortLemur.AddFodderRequirements(water, 3); 
            mauriceLemur.AddFodderRequirements(fruit, 102.45);
            mauriceLemur.AddFodderRequirements(water, 4); 
            sandraChimpanzee.AddFodderRequirements(fruit, 87.23);
            sandraChimpanzee.AddFodderRequirements(water, 5); 
            brZoo.ZooFodderRequirements();
            // brZoo.DisplayZooStructure();
            System.Console.WriteLine();
            brZoo.DisplaySumOfFodderRequirementsAndCostsPerDay();

            System.Console.WriteLine("Aufgabe Zoo - Teil 4:\nPfleger hinzufügen");
            CareGiver michael = new CareGiver("Michael"); 
            CareGiver katja = new CareGiver("Katja"); 
            brZoo.AddCareGiver(katja); 
            brZoo.AddCareGiver(michael); 
            katja.AddEnclosure(aquarium); 
            katja.AddEnclosure(birdEnclosure); 
            michael.AddEnclosure(monkeyhouse);
            michael.AddEnclosure(lionEnclosure);
            brZoo.DisplayZooStructure(); 
            
         


        


            
        }
    }
}