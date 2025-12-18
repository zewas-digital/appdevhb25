using System.Configuration;
using System.Text;
using Appdevhb25.SheilaMayJaro.Aufgabe64and65;
using MySql.Data.MySqlClient;

namespace Appdevhb25.SheilaMayJaro.AufgabeZoo
{
    public class Zoo
    {
        public string Name { get; private init; }
        public DateTime FoundingYear { get; private init; }
        public List<Enclosure> Enclosures { get; private set; } = new List<Enclosure>();
        public Dictionary<Food, double> FodderRequirementsPerDay { get; private set; } = new Dictionary<Food, double>(); //Futtername und Menge vom ganzen Zoo pro Tag
        public List<CareGiver> CareGivers { get; private set; } = new List<CareGiver>();
        public Zoo(string name, DateTime year)
        {
            Name = name;
            FoundingYear = year;
            Connection.InsertAttributesToTableZoo(name, year);
        }
        internal void AddEnclosure(Enclosure enclosure)
        {
            Enclosures.Add(enclosure);
        }
        internal void RemoveEnclosure(Enclosure enclosure)
        {
            Enclosures.Remove(enclosure);
        }
        public List<string> ZooStructure()
        {
            List<string> temp = new List<string>();
            temp.Add(ReturnAttributes());
            {
                foreach (Enclosure enclosure in Enclosures)
                {
                    temp.Add(enclosure.ReturnName());

                    if (enclosure.animals.Count > 0) //was, wenn noch keine Tiere im Gehege sind
                    {
                        foreach (var animal in enclosure.animals)
                        {
                            temp.Add(animal.ReturnAttributes());
                            temp.Add(animal.ReturnFodderRequirements());
                        }
                    }
                    else
                    {
                        temp.Add($"|       ├── Es gibt noch keine Bewohner für dieses Gehege.");
                    }
                    foreach (CareGiver careGiver in CareGivers) //Damit die Pfleger zu den Gehegen mitangegeben werden
                    {
                        foreach (Enclosure careGiverEnclosure in careGiver.enclosuresToDo)
                        {
                            if (careGiverEnclosure == enclosure) //erkennen, dass der Pfleger zu diesem Gehege gehört
                            {
                                temp.Add(careGiver.ReturnName());
                            }
                        }
                    }
                }
            }
            foreach (Enclosure enclosure in Enclosures)
            {
                Connection.InsertAttributesToRelationshipTableAnimalFood(enclosure.animals);
            }
            Connection.InsertAttributesToRelationshipTableEnclosureZookeeper(CareGivers); 
            return temp;
        }
        internal List<string> SumOfFodderRequirementsPerDay()
        {
            List<string> temp = new List<string>();
            string seperator = new string('-', 100);
            temp.Add("Futterbedarf");
            temp.Add(seperator);
            foreach (KeyValuePair<Food, double> foodRequirement in FodderRequirementsPerDay)
            {
                temp.Add(@$"
{foodRequirement.Key.Name,-20}{foodRequirement.Key.Unit,-10}{foodRequirement.Value,8:N2}"); //Futtername und Menge
            }
            temp.Add(seperator);
            return temp;
        }
        internal void ZooFodderRequirements()
        {
            foreach (Enclosure enclosure in Enclosures)
            {
                foreach (Animal animal in enclosure.animals)
                {
                    foreach (KeyValuePair<Food, double> item in animal.FodderRequirements)
                    {
                        if (FodderRequirementsPerDay.ContainsKey(item.Key))
                        {
                            FodderRequirementsPerDay[item.Key] += item.Value;
                        }
                        else
                        {
                            FodderRequirementsPerDay.Add(item.Key, item.Value);
                        }
                    }
                }
            }
        }
        internal void AddCareGiver(CareGiver careGiver)
        {
            CareGivers.Add(careGiver);
        }
        internal string ReturnAttributes()
        {
            return $"\n├── Zoo: {Name}, gegründet {FoundingYear}";
        }
    }
}