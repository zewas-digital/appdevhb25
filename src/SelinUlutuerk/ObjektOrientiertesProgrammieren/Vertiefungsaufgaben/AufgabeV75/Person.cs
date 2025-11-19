using System;
using System.Linq;

namespace Appdevhb25.SelinUlutuerk.AufgabeV75
{
    class Person
    {
        public double Groesse { get; private set; }
        public int Alter { get; private set; }
        public string? Name { get; init; }
        public double Gewicht { get; private set; }

        public Person(string name, int alter, double groesse, double gewicht)
        {
            Name = name;
            Alter = alter;
            Groesse = groesse;
            Gewicht = gewicht;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Alter: " + Alter + ", Groesse: " + Groesse + ", Gewicht: " + Gewicht;
        }
    }

    class Gruppe
    {
        // speichern von angelegten Perosnen in der Liste
        private List<Person> personen = new List<Person>();

        public void AddPerson(Person p)
        {
            personen.Add(p);
        }

        // Methoden für Min/Max/Durchschnitt
        // Größe:
        public double GetMinGroesse()
        {
            return personen.Min(p => p.Groesse);
        }
        public double GetMaxGroesse()
        {
            return personen.Max(p => p.Groesse);
        }
        public double GetAverageGroesse()
        {
            return personen.Average(p => p.Groesse);
        }


        // Alter:
        public int GetMinAlter()
        {
            return personen.Min(p => p.Alter);
        }
        public int GetMaxAlter()
        {
            return personen.Max(p => p.Alter);
        }
        public double GetAverageAlter()
        {
            return personen.Average(p => p.Alter);
        }


        // Gewicht:
        public double GetMinGewicht()
        {
            return personen.Min(p => p.Gewicht);
        }
        public double GetMaxGewicht()
        {
            return personen.Max(p => p.Gewicht);
        }
        public double GetAverageGewicht()
        {
            return personen.Average(p => p.Gewicht);
        }
    }

    class PerosnenInGruppe
    {
        public static void Start()
        {
            Gruppe gruppe = new Gruppe();

            gruppe.AddPerson(new Person("Lina", 11, 1.45, 40.2));
            gruppe.AddPerson(new Person("Ela", 17, 1.65, 55.23));
            gruppe.AddPerson(new Person("Leon", 20, 1.76, 57));
            gruppe.AddPerson(new Person("Tim", 25, 1.70, 67.8));
            gruppe.AddPerson(new Person("Franz", 44, 1.77, 80));

            System.Console.WriteLine($"Alter:\nmin = {gruppe.GetMinAlter()}, max = {gruppe.GetMaxAlter()}, avg = {gruppe.GetAverageAlter():F2}");
            System.Console.WriteLine($"Größe:\nmin = {gruppe.GetMinGroesse():F2}m, max = {gruppe.GetMaxGroesse():F2}m, avg = {gruppe.GetAverageGroesse():F2}m");
            System.Console.WriteLine($"Größe:\nmin = {gruppe.GetMinGewicht():F2} kg, max = {gruppe.GetMaxGewicht():F2} kg, avg = {gruppe.GetAverageGewicht():F2} kg"); 
        }
    }
}