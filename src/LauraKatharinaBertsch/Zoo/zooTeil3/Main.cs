namespace Appdevhb25.LauraKatharinaBertsch.ZooTeil3
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

            Food food1 = new Food("Steak", 20, 200);
            tiger.AddFood(food1);
            Food food2 = new Food("Fisch", 3, 70.50m);
            penguin.AddFood(food2);

            Console.WriteLine(zoo);

            Console.WriteLine("Futterbedarf");
            Console.WriteLine("---------------------");
            foreach (var food in Animal.foods)
            {
                Console.WriteLine(food);
                Food.price = Food.price + food.Price;
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Summe          " + Food.price + " €");

        }
    }
}