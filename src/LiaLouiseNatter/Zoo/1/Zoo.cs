namespace Appdevhb25.LiaLouiseNatter.Zoo
{
    public class Zoo
    {
        public string Name{get; private set;}
        public int Established{get; private set;}
        public List<Compound> Compounds;
        public Zoo(string name, int established)
        {
            Name = name;
            Established = established;
            Compounds = new List<Compound>();
        }

        public void AddCompound(Compound compountAdd)
        {
            Compounds.Add(compountAdd);
        }
        public void DeleteCompound(Compound compoundDelete)
        {
            if (Compounds.Contains(compoundDelete))
            {
                Compounds.Remove(compoundDelete);
            }
            else
            {
                System.Console.WriteLine("Compound doesnt exist yet...");
            }
        }

        public void PrintZooStructure()
        {
            System.Console.WriteLine($"├── Zoo: {Name}, established {Established}");
            foreach(Compound compound in Compounds)
            {
                System.Console.WriteLine($"│   ├── Gehege: {compound.CompoundName}");
            }
        }
        

    }
}