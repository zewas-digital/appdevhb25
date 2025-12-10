using System.Configuration;
using System.Text;

namespace Appdevhb25.SheilaMayJaro.AufgabeZoo
{
    public class Zoo
    {
        public string Name { get; private init; }
        public string FoundationYear { get; private init; }
        public List<Enclosure> Enclosures { get; private set; } = new List<Enclosure>();
        public Dictionary<Food, double> FodderRequirementsPerDay { get; private set; } = new Dictionary<Food, double>(); //Futtername und Menge vom ganzen Zoo pro Tag
        public List<CareGiver> CareGivers { get; private set; } = new List<CareGiver>();
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
            foreach(CareGiver careGiver in CareGivers)
            {
                foreach (Enclosure enclosure in Enclosures)
                {
                    foreach (Enclosure careGiverEnclosure in careGiver.enclosuresToDo)
                    {
                        if (careGiverEnclosure == enclosure)
                        {
                            System.Console.WriteLine($"|   ├── Pfleger: {careGiver.Name}");
                        }
                    }
                    System.Console.WriteLine($"|   ├── Gehege: {enclosure.Name}");
                    if (enclosure.animals.Count > 0)
                    {
                        foreach (Animal animal in enclosure.animals)
                        {
                            System.Console.WriteLine($"|       ├── {animal.Name}, {animal.Species}");

                            foreach (KeyValuePair<Food, double> food in animal.FodderRequirements)
                            {
                                System.Console.WriteLine($"|           *──{food.Key.Name}: {food.Value}{food.Key.Unit}");
                            }
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("|   ├── Gehege noch in Bearbeitung.");
                    }
                }
            }
        }
        internal void DisplaySumOfFodderRequirementsAndCostsPerDay()
        {
            System.Console.WriteLine("Futterbedarf");
            System.Console.WriteLine("-", 40);
            foreach (KeyValuePair<Food, double> foodRequirement in FodderRequirementsPerDay)
            {
                System.Console.WriteLine(@$"
{foodRequirement.Key.Name,-20}{foodRequirement.Key.Unit,-10}{foodRequirement.Value,8:N2}€");
            }
            System.Console.WriteLine(new string('-', 100));
        }
        internal void ZooFodderRequirements()
        {
            foreach (Enclosure enclosure in Enclosures)
            {
                foreach (Animal animal in enclosure.animals)
                {
                    foreach (KeyValuePair<Food, double> item in animal.FodderRequirements)
                    {
                        if (FodderRequirementsPerDay.ContainsKey(item.Key))
                        {
                            FodderRequirementsPerDay[item.Key] += item.Value;
                        }
                        else
                        {
                            FodderRequirementsPerDay.Add(item.Key, item.Value);
                        }
                    }
                }
            }
        }
        internal void AddCareGiver(CareGiver careGiver)
        {
            CareGivers.Add(careGiver);
        }
    }
}