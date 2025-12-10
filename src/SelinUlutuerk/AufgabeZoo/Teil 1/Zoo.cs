using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeZoo.Teil1
{
    class Zoo
    {
        public string Name { get; private set; }
        public int Gruendungsjahr { get; private set; }
        public List<Gehege> GehegeListe = new List<Gehege>();

        public Zoo(string name, int gruendungsjahr)
        {
            Name = name;
            Gruendungsjahr = gruendungsjahr;
        }


        public void HinzufuegenGehege(Gehege gehege)
        {
            GehegeListe.Add(gehege);
        }


        public void EntfernenGehege(Gehege gehege)
        {
            GehegeListe.Remove(gehege);
        }

        public override string ToString()
        {
            string result = $"├── Zoo: {Name}, gegründet {Gruendungsjahr}\n";

            foreach (var g in GehegeListe)
            {
                result += $"{g}";     
            }

            return result;
        }
    }
}