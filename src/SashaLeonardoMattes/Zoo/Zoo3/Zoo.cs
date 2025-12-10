using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Org.BouncyCastle.Utilities.IO;

namespace Appdevhb25.SashaLeonardoMattes.AufgabeZoo03
{

    public class Zoo
    {
        public string Name { get; private set; }
        public int YearEstablished { get; private set; }

        public Zoo(string name, int yearEstablished)
        {
            Name = name;
            YearEstablished = yearEstablished;
        }

        public List<Enclosure> Enclosures { get; private set; } = new List<Enclosure>();
        public Dictionary<Food, double> TotalFeedRequirements { get; private set; } = new Dictionary<Food, double>();

        public void AddEnclosure(Enclosure enclosure)
        {
            Enclosures.Add(enclosure);
        }

        public void RemoveEnclosure(Enclosure enclosure)
        {
            Enclosures.Remove(enclosure);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"├── Zoo: {Name}, gegründet {YearEstablished}");

            if (Enclosures.Count < 1)
            {
                stringBuilder.AppendLine($"│   ├── (leer)");
            }
            else
            {
                foreach (var enclosure in Enclosures)
                {
                    stringBuilder.AppendLine($"│   ├── Gehege: {enclosure.Name}");

                    if (enclosure.animals.Count < 1)
                    {
                        stringBuilder.AppendLine($"│     ├── (leer)");
                    }
                    else
                    {
                        foreach (var animal in enclosure.animals)
                        {
                            stringBuilder.AppendLine($"│     ├── {animal.Name}, {animal.Species}");
                        }
                    }
                }
            }
            return stringBuilder.ToString();
        }

        public void UpdateTotalFeedRequirement()
        {
            foreach (var enclosure in Enclosures)
            {
                foreach (var animal in enclosure.animals)
                {
                    if (TotalFeedRequirements.ContainsKey(animal.FeedRequirement.Food))
                    {
                        TotalFeedRequirements[animal.FeedRequirement.Food] += animal.FeedRequirement.Amount;
                    }
                    else
                    {
                        TotalFeedRequirements.Add(animal.FeedRequirement.Food, animal.FeedRequirement.Amount);
                    }
                }
            }
        }

        public void PrintTotalFeedRequirement()
        {
            decimal sum = 0;
            System.Console.WriteLine("Futterbedarf");
            System.Console.WriteLine(new string('-', 47));
            foreach (var food in TotalFeedRequirements)
            {
                System.Console.WriteLine(
                $"{food.Key.Name, -20}" + //-20 = linksbündig  20 Zeichen
                $"{food.Value, 10:F2}" +     // 10 = rechtsbündig 10 Zeichen
                $"{food.Key.Unit, 4}" +
                $"{Math.Round(food.Key.UnitPrice*Convert.ToDecimal(food.Value), 2), 10:F2}" + 
                $" €"); //:F2 macht fix 2 Kommastellen
                sum+=food.Key.UnitPrice*Convert.ToDecimal(food.Value);
            }
            System.Console.WriteLine(new string('-', 47));
            System.Console.WriteLine($"{"Summe:",-34}{Math.Round(sum, 2), 10:F2} €"); //Summe linksbündig 24 (20+10+4) und Summe Rechtsbündig 10 (gleich wie Preise)
        }
        
    }
}