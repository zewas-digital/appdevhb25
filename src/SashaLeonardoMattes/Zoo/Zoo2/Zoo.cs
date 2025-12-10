using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Appdevhb25.SashaLeonardoMattes.AufgabeZoo02
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

        public List<Enclosure> enclosures { get; private set; } = new List<Enclosure>();

        public void AddEnclosure(Enclosure enclosure)
        {
            enclosures.Add(enclosure);
        }

        public void RemoveEnclosure(Enclosure enclosure)
        {
            enclosures.Remove(enclosure);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"├── Zoo: {Name}, gegründet {YearEstablished}");

            if (enclosures.Count < 1)
            {
                stringBuilder.AppendLine($"│   ├── (leer)");
            }
            else
            {
                foreach (var enclosure in enclosures)
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
        
    }
}