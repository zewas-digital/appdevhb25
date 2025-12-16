using Org.BouncyCastle.Asn1;

namespace Appdevhb25.LauraKatharinaBertsch.ZooTeil3
{
    public class Animal
    {
        public Animal FavouriteFood { get; private set; }
        public string Name { get; private set; }
        public string Genus { get; private set; }
        public static List<Food> foods = new List<Food>();
        public Animal(string name, string genus)
        {
            Name = name;
            Genus = genus;
        }
        public override string ToString()
        {
            string animal = $"|    |--{Name}, {Genus}";
            
            return animal;
        }
        public void AddFood(Food food)
        {
            foods.Add(food);
        }
    }
}
