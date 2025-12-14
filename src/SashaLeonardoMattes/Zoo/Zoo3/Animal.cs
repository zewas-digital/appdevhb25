using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.AufgabeZoo03
{

    public class Animal
    {
        public string Name { get; private set; }
        public string Species { get; private set; }
        public FeedRequirement FeedRequirement { get; set; }

        public Animal(string name, string species, FeedRequirement feedRequirement)
        {
            Name = name;
            Species = species;
            FeedRequirement = feedRequirement;
        }
        
    }
}