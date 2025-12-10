using System.Configuration;
using System.Text;

namespace Appdevhb25.SheilaMayJaro.AufgabeZoo
{
    public class Zoo
    {
        public string Name { get; private init; }
        public string FoundationYear { get; private init; }
        private List<Enclosure> Enclosures { get; set; } = new List<Enclosure>();
        private Dictionary<Food, double> FodderRequirementsPerDay {get; set; } = new Dictionary<Food, double>(); //Futtername und Menge vom ganzen Zoo pro Tag
        public Zoo(string name, string year)
        {
            Name = name;
            FoundationYear = year;
        }
        internal void AddEnclosure(Enclosure enclosure)
        {
            Enclosures.Add(enclosure);
        }
        internal void RemoveEnclosure(Enclosure enclosure)
        {
            Enclosures.Remove(enclosure);
        }
        public void DisplayZooStructure()
        {
            System.Console.WriteLine($"\n├── Zoo: {Name}, gegründet {FoundationYear}");
            foreach (Enclosure item in Enclosures)
            {
                System.Console.WriteLine($"|   ├── Gehege: {item.Name}");
                item.DisplayAnimals();
            }
        }
        internal void DisplaySumOfFodderRequirementsAndCostsPerDay()
        {
            double Sum = 0;
            System.Console.WriteLine("Futterbedarf");
            System.Console.WriteLine("-", 40);
            foreach (KeyValuePair<Food, double> item in FodderRequirementsPerDay)
            {
                System.Console.WriteLine(@$"
{item.Key.Name, -10} {item.Key.Unit,-20} {item.Value, -30}");
            }
            System.Console.WriteLine("-", 40);

        }
        internal void ZooFodderRequirements()
        {
            foreach (Enclosure enclosure in Enclosures)
            {
                foreach (Animal animal in enclosure.animals)
                {
                    foreach (KeyValuePair<Food, int> item in animal.FodderRequirements)
                    {
                        if (FodderRequirementsPerDay.ContainsKey(item.Key))
                        {
                            FodderRequirementsPerDay[item.Key] = item.Value; 
                        }
                        else
                        {
                            FodderRequirementsPerDay.Add(item.Key, item.Value); 
                        }
                    }
                }
                
            }
        }
    }
}