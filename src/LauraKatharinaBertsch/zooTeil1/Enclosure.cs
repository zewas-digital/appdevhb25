namespace Appdevhb25.LauraKatharinaBertsch.ZooTeil1
{
    public class Enclosure
    {
        public string Name{get; private set;}
        public Enclosure(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"| |--Gehege: {Name}";
        }
    }
}