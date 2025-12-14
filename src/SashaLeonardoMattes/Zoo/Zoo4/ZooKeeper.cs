using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.AufgabeZoo04
{

    public class ZooKeeper
    {
        public string Name { get; private set; }
        public List<Enclosure> Enclosures { get; private set; } = new List<Enclosure>();

        public ZooKeeper(string name)
        {
            Name = name;
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            Enclosures.Add(enclosure);
        }

        public void RemoveEnclosure(Enclosure enclosure)
        {
            Enclosures.Remove(enclosure);
        }
        
        
    }
}