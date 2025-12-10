using System.Runtime.InteropServices;

namespace Appdevhb25.NoahHois.ZooTeil3
{
    public class Tier
    {
        public string Name { get; private set; }
        public string Gattung { get; private init; }
        public double Futterbedarf { get; private init; }

        public Tier(string name, string gattung, int futterbedarf)
        {
            Name = name;
            Gattung = gattung;
            Futterbedarf = futterbedarf;
        }
        public List<Tierfutter> _tierfutter = new List<Tierfutter>();

        public void FutterbedarfGanzenZoo()
        {
            foreach (Tierfutter futter in _tierfutter)
            {

            }
        }
    }
}