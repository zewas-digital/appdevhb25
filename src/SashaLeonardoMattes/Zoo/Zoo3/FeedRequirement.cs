using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.AufgabeZoo03
{

    public class FeedRequirement
    {
        public Food Food { get; private set; }
        public double Amount { get; private set; }
        public FeedRequirement(Food food, double amount)
        {
            Food = food;
            Amount = amount;
        }

        
        
    }
}