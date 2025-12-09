namespace Appdevhb25.SheilaMayJaro.AufgabeZoo
{
    public class Animal
    {
        public string Name { get; private init; }
        public string Species { get; private init; }
        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
        }
    }
}