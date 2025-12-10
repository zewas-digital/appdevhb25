using System.Dynamic;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.zoo.teil4
{
    public class Pfleger(string name)
    {
        public string Name { get; private set; } = name;
        public List<Gehege> Gehege = new List<Gehege>();

        public void GehegeZuordnen(Gehege gehege)
        {
            Gehege.Add(gehege);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}