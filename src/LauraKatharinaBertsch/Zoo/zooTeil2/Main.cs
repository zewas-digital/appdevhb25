namespace Appdevhb25.LauraKatharinaBertsch.ZooTeil2
{
    public class Main
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Tiergarten BlaBla", 2025);

            Enclosure dschungel = new Enclosure("Dschungel");
            zoo.AddEnclosure(dschungel);
            Enclosure nordpool = new Enclosure("Nordpool");
            zoo.AddEnclosure(nordpool);
            Enclosure aquarium = new Enclosure("Aquarium");
            zoo.AddEnclosure(aquarium);
            Enclosure savanne = new Enclosure("Savanne");
            zoo.AddEnclosure(savanne);

            Animal tiger = new Animal("Peter", "Tiger");
            dschungel.AddAnimals(tiger);
            Animal shark = new Animal("Fresssack", "Hai");
            aquarium.AddAnimals(shark);
            Animal snake = new Animal("Mitzekatze", "Schlange");
            dschungel.AddAnimals(snake);
            Animal penguin = new Animal("Kartoffel", "Pinguin");
            nordpool.AddAnimals(penguin);
            Animal zebra = new Animal("Zottelviech", "Zebra");
            savanne.AddAnimals(zebra);

            Console.WriteLine(zoo);

        }
    }
}