namespace Appdevhb25.LiaLouiseNatter.Zoo
{
    public class Compound
    {
        public string CompoundName{get;private set;}
        public List<Animal> animals{get;private set;}
        
        public Compound(string compoundName)
        {
            CompoundName = compoundName;
            animals = new List<Animal>();
        }
         public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void DeleteAnimal(Animal animal)
        {
            if (animals.Contains(animal))
            {
                animals.Remove(animal);
            }
            else
            {
                System.Console.WriteLine($"Animal doesnt exist yet...");
            }
        }
        
    }
}