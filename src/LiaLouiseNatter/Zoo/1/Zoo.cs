using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.LiaLouiseNatter.Zoo
{
    public class Zoo
    {
        public string Name{get; private set;}
        public int Established{get; private set;}
        public List<Compound> compounds{get; private set;}
        public Dictionary<Food,double> foodRequirementDict{get; private set;}

        public Zoo(string name, int established)
        {
            Name = name;
            Established = established;
            compounds = new List<Compound>();
            foodRequirementDict = new Dictionary<Food, double>();
        }

        public void AddCompound(Compound compountAdd)
        {
            compounds.Add(compountAdd);
        }
        public void DeleteCompound(Compound compoundDelete)
        {
            if (compounds.Contains(compoundDelete))
            {
                compounds.Remove(compoundDelete);
            }
            else
            {
                System.Console.WriteLine("Compound doesnt exist yet...");
            }
        }


        public void PrintZooStructure()
        {
            System.Console.WriteLine($"├── Zoo: {Name}, established {Established}");
            foreach(Compound compound in compounds)
            {
                System.Console.WriteLine($"│   ├── Gehege: {compound.CompoundName}");
                if(compound.animals.Count == 0)
                {
                    System.Console.WriteLine("│     ├── (leer)");
                }
                else
                {
                    foreach(Animal animal in compound.animals)
                    {
                        System.Console.WriteLine($"│     ├── {animal.Species}, {animal.Name}");
                    }
                }
            }
        }

        public void UpdateFoodList()
        {
            foreach(Compound compound in compounds)
            {
                foreach(Animal animal in compound.animals)
                {
                    if (foodRequirementDict.ContainsKey(animal.FoodRequirements.Feed))
                    {
                        foodRequirementDict[animal.FoodRequirements.Feed] += animal.FoodRequirements.Amount;
                    }
                    else
                    {
                        foodRequirementDict.Add(animal.FoodRequirements.Feed,animal.FoodRequirements.Amount);
                    }
                }
            }
        }

        public double CalculateTotalCost()
        {
            double totalPrice = 0;
            foreach(var keyValuePairs in foodRequirementDict)
            {
                totalPrice += keyValuePairs.Key.UnitPrice * keyValuePairs.Value;
            }
            return totalPrice;
        }

        public void PrintFoodCosts()
        {
            System.Console.WriteLine("\nFutterbedarf");
            System.Console.WriteLine("--------------------------------");
            foreach(var keyValuePairs in foodRequirementDict)
            {
                System.Console.WriteLine($"{keyValuePairs.Key.Name, -10}{keyValuePairs.Value,1 :f2}{keyValuePairs.Key.Unit,-13}{keyValuePairs.Key.UnitPrice * keyValuePairs.Value}€");
            }
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine($"Summe{CalculateTotalCost(),25}€");
            

        }
        

    }
}