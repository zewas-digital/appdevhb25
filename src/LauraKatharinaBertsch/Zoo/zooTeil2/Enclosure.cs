namespace Appdevhb25.LauraKatharinaBertsch.ZooTeil2
{
    public class Enclosure
    {
        public List<Animal> animals = new List<Animal>();
        public string Name { get; private set; }
        public Enclosure(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            string enclosure = $"| |--Gehege: {Name}\n";
            foreach (var animal in animals)
            {
                enclosure += animal + "\n";
            }
            return enclosure;
        }
        public void AddAnimals(Animal name)
        {
            animals.Add(name);
        }
    }
}