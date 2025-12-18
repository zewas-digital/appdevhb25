using MySql.Data.MySqlClient;

namespace Appdevhb25.SheilaMayJaro.AufgabeZoo
{
    public class Enclosure
    {
        public string Name { get; private init; }
        public List<Animal> animals { get; private set; } = new List<Animal>();
        public Enclosure(string name)
        {
            Name = name;
            Connection.InsertAttributesToTableEnclosure(name);
        }
        internal void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        internal void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }
        internal string ReturnName()
        {
            return $"|   ├── Gehege: {Name}";
        }
    }
}