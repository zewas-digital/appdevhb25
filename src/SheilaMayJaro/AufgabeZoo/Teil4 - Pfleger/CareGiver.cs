namespace Appdevhb25.SheilaMayJaro.AufgabeZoo
{
    public class CareGiver
    {
        public string Name { get; private init; }
        public List<Enclosure> enclosuresToDo {get; private set; } = new List<Enclosure>(); 
        public CareGiver(string name)
        {
            Name = name; 
        }
        internal void AddEnclosure(Enclosure enclosure)
        {
            enclosuresToDo.Add(enclosure); 
        }
    }
}