using System.Reflection.Metadata.Ecma335;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe83
{
    public class History
    {
        public string Name { get; set; }
        public DateTime TimeVisited { get; set; }

        public History(string name)
        {
            Name = name;
            TimeVisited = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Name} (Date/Time visited: {TimeVisited:G})";
        }
    }
}