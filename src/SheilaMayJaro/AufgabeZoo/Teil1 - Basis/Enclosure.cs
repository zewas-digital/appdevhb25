namespace Appdevhb25.SheilaMayJaro.AufgabeZoo
{
    public class Enclosure
    {
        public string Name { get; private init; }
        public List<Animal> animals { get; private set; } = new List<Animal>();
        public Enclosure(string name)
        {
            Name = name;
        }
        internal void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        internal void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }
        public void DisplayAnimals()
        {
            if (animals.Count > 0)
            {
                foreach (Animal animal in animals)
                {
                    System.Console.WriteLine($"|       ├── {animal.Name}, {animal.Species}");
                }
            }
            else
            {
                System.Console.WriteLine("|       ├── Gehege noch in Bearbeitung.");
            }

        }
    }
}