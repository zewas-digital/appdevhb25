using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.AufgabeZoo03
{

    public class Food
    {
        public string Name { get; private set; }
        public string Unit { get; private set; }
        public decimal UnitPrice { get; private set; }
        public Food(string name, string unit, decimal unitPrice)
        {
            Name = name;
            Unit = unit;
            UnitPrice = unitPrice;
        }

        
        
    }
}