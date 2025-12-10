namespace Appdevhb25.SheilaMayJaro.AufgabeZoo
{
    public class Animal
    {
        public string Name { get; private init; }
        public string Species { get; private init; }
        public Dictionary<Food, int> FodderRequirements { get; set; } //Futterbedarf
        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
        }
        public void AddFodderRequirements(Food food, int amount)
        {
            FodderRequirements.Add(food, amount);
        }
    }
}