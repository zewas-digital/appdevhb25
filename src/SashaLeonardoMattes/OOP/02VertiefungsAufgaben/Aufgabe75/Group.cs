using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe75
{

    public class Group
    {

        private List<Person> persons = new List<Person>();

        public void AddPerson(Person p)
        {
            persons.Add(p);
        }

        public string GetBiggest()
        {
            int maxAge = persons.Max(p => p.Age);
            int maxHeight = persons.Max(p => p.Height);
            int maxWheight = persons.Max(p => p.Wheight);

            string maxHeightOutput = "Größte Person(en): " + string.Join(", ", persons.Where(p => p.Height == maxHeight).Select(p => p.Name)) + " mit: " + maxHeight;
            string maxAgeOutput = "Älteste Person(en): " + string.Join(", ", persons.Where(p => p.Age == maxAge).Select(p => p.Name)) + " mit: " + maxAge;
            string maxWheightOutput = "Schwerste Person(en): " + string.Join(", ", persons.Where(p => p.Wheight == maxWheight).Select(p => p.Name)) + " mit: " + maxWheight;

            return maxHeightOutput + "\n" + maxAgeOutput + "\n" + maxWheightOutput;
        }

        public string GetSmallest()
        {
            int minAge = persons.Min(p => p.Age);
            int minHeight = persons.Min(p => p.Height);
            int minWheight = persons.Min(p => p.Wheight);

            string minHeightOutput = "Kleinste Person(en): " + string.Join(", ", persons.Where(p => p.Height == minHeight).Select(p => p.Name)) + " mit: " +minHeight;
            string minAgeOutput = "Jüngste Person(en): " + string.Join(", ", persons.Where(p => p.Age == minAge).Select(p => p.Name)) + " mit: " + minAge;
            string minWheightOutput = "Leichteste Person(en): " + string.Join(", ", persons.Where(p => p.Wheight == minWheight).Select(p => p.Name)) + " mit: " + minWheight;

            return minHeightOutput + "\n" + minAgeOutput + "\n" + minWheightOutput;
        }
        
        public string GetAverage()
        {
            double averageAge = persons.Average(p => p.Age);
            double averageHeight = persons.Average(p => p.Height);
            double aveageWheight = persons.Average(p => p.Wheight);

            return $"Durchschnittsalter: {averageAge}\n DurchschnittsGröße: {averageHeight}\n Durchchnittsgewicht: {aveageWheight}";
        }
    }
}