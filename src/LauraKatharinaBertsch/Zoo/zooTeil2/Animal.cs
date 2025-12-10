namespace Appdevhb25.LauraKatharinaBertsch.ZooTeil2
{
    public class Animal
    {
        public string Name{get; private set;}
        public string Genus{get; private set;}

        public Animal(string name, string genus)
        {
            Name = name;
            Genus = genus;
        }
        public override string ToString()
        {
            return $"|    |--{Name}, {Genus}";
        }
    }
}