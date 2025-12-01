using System.Threading.Tasks.Dataflow;

namespace Appdevhb25.NoahHois.Aufgabe96
{
    public abstract class Figur
    {
        private string Type { get; }
        private string Designnation { get; }
        public Figur(string type, string designnation)
        {
            Type = type;
            Designnation = designnation;
        }
        public abstract double CalculateScope();
        public abstract double CalculateArea();
        public override string ToString()
        {
            return $"Name {Type} Bezeichnung {Designnation} {CalculateScope()}";
        }
    }
}