using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.AufgabeZoo03
{

    public class Enclosure
    {
        public string Name { get; private set; }
        public List<Animal> animals { get; private set; } = new List<Animal>();
        public Enclosure(string name)
        {
            Name = name;
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }
        
    }
}