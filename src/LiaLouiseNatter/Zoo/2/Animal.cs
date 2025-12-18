namespace Appdevhb25.LiaLouiseNatter.Zoo
{
    public class Animal
    {
        public string Name{get; private set;}
        public string Species{get; private set;}
        public FoodRequirements FoodRequirements{get; private set;}

        public Animal(string species, string name, FoodRequirements foodRequirements)
        {
            Species = species;
            Name = name;
            FoodRequirements = foodRequirements;
        }

    }
}
