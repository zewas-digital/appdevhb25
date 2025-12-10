using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.AufgabeZoo02
{

    public class Animal
    {
        public string Name { get; private set; }
        public string Species { get; private set; }

        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
        }
        
    }
}