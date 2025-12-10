using System.Configuration;
using System.Text;

namespace Appdevhb25.SheilaMayJaro.AufgabeZoo
{
    public class Zoo
    {
        public string Name { get; private init; }
        public string FoundationYear { get; private init; }
        private List<Enclosure> enclosures { get; set; } = new List<Enclosure>();
        public Zoo(string name, string year)
        {
            Name = name;
            FoundationYear = year;
        }
        internal void AddEnclosure(Enclosure enclosure)
        {
            enclosures.Add(enclosure);
        }
        internal void RemoveEnclosure(Enclosure enclosure)
        {
            enclosures.Remove(enclosure);
        }
        public void DisplayZooStructure()
        {
            System.Console.WriteLine($"\n├── Zoo: {Name}, gegründet {FoundationYear}");
            foreach (Enclosure item in enclosures)
            {
                System.Console.WriteLine($"|   ├── Gehege: {item.Name}");
                item.DisplayAnimals(); 
            }
        }
    }
}