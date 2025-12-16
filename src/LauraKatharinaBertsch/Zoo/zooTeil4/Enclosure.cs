namespace Appdevhb25.LauraKatharinaBertsch.ZooTeil4
{
    public class Enclosure
    {
        public List<Animal> animals = new List<Animal>();
        public  List<Carer> carers = new List<Carer>();
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
        public void AddCarer(Carer name)
        {
            carers.Add(name);
        }
        public void WriteCarer()
        {
            foreach(var carer in carers)
            {
                Console.WriteLine(carer + Name);
            }
        }
    }
}