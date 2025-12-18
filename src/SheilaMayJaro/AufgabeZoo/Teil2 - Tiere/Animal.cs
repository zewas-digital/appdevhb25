using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;

namespace Appdevhb25.SheilaMayJaro.AufgabeZoo
{
    public class Animal
    {
        public string Name { get; private init; }
        public string Species { get; private init; }
        public Dictionary<Food, double> FodderRequirements { get; set; } = new Dictionary<Food, double>();  //Futterbedarf
        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
            Connection.InsertAttributesToTableAnimal(name, species);
        }
        public void AddFodderRequirements(Food food, double amount)
        {
            FodderRequirements.Add(food, amount);
        }
        internal string ReturnAttributes()
        {
            return $"|       ├── {Name}, {Species}";
        }
        internal string ReturnFodderRequirements()
        {
            foreach (KeyValuePair<Food, double> item in FodderRequirements)
            {
                return $"|          ├── {item.Key.Name}: {item.Value} {item.Key.Unit}";
            }
            return ""; //gibt es eine Alternative dazu?
        }
        
        
    }
}