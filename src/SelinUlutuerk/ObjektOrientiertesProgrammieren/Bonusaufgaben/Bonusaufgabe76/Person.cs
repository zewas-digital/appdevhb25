using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.XPath;
using Appdevhb25.SelinUlutuerk.Aufgabe66;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe76
{
    class Person
    {
        public double Groesse { get; private set; }
        public int Alter { get; private set; }
        public string? Name { get; init; }
        public double Gewicht { get; private set; }
        public int Sozialversicherungsnummer { get; init; }

        public Person(string name, int alter, double groesse, double gewicht, int sozialNr)
        {
            Name = name;
            Alter = alter;
            Groesse = groesse;
            Gewicht = gewicht;
            Sozialversicherungsnummer = sozialNr;
        }


        // public override string ToString()
        // {
        //     return "Name: " + Name + ", Alter: " + Alter + ", Groesse: " + Groesse + ", Gewicht: " + Gewicht + ", Sozialverischerungsnummer: " + Sozialversicherungsnummer;
        // }

        public override string ToString()
        {
            return $"{Name,-7} {Alter,3} Jahre   {Groesse,6} cm   {Gewicht,6} kg   {Sozialversicherungsnummer}";
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


        // Methoden für Sortierung
        // Größe:
        public List<Person> SortierungNachGroesse(string sortierung)
        {
            if (sortierung == "ab")
            {
                return personen.OrderByDescending(p => p.Groesse).ToList();
            }
            if (sortierung == "auf")
            {
                return personen.OrderBy(p => p.Groesse).ToList();
            }
            // fallback: wenn Sortierung nicht erkannt wird
            return personen.ToList();
        }

        // Alter:
        public List<Person> SortierungNachAlter(string sortierung)
        {
            if (sortierung == "ab")
            {
                return personen.OrderByDescending(p => p.Alter).ToList();
            }
            if (sortierung == "auf")
            {
                return personen.OrderBy(p => p.Alter).ToList();
            }
            // fallback: wenn Sortierung nicht erkannt wird
            return personen.ToList();
        }

        // Gewicht:
        public List<Person> SortierungNachGewicht(string sortierung)
        {
            if (sortierung == "ab")
            {
                return personen.OrderByDescending(p => p.Gewicht).ToList();
            }
            if (sortierung == "auf")
            {
                return personen.OrderBy(p => p.Gewicht).ToList();
            }
            // fallback: wenn Sortierung nicht erkannt wird
            return personen.ToList();
        }

        // Name:
        public List<Person> SortierungNachName(string sortierung)
        {
            if (sortierung == "ab")
            {
                return personen.OrderByDescending(p => p.Name).ToList();
            }
            if (sortierung == "auf")
            {
                return personen.OrderBy(p => p.Name).ToList();
            }
            // fallback: wenn Sortierung nicht erkannt wird
            return personen.ToList();
        }


        // Methoden um Perosnen zu finden:
        // einzelne Person
        public Person? FindePerson(string name)
        {
            return personen.Find(p => p.Name != null && p.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        // alle gefundenen Personen
        public List<Person> FindeAllePersonen(string name)
        {
            return personen.FindAll(p => p.Name != null && p.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }


        // Methode zum Löschen von Personen
        public Person? EntfernePerson(int svnr)
        {
            Person? person = personen.Find(p => p.Sozialversicherungsnummer == svnr);
            if (person != null)
            {
                personen.Remove(person);
                Console.WriteLine($"Person {person.Name} (SVNR: {svnr}) wurde gelöscht.");
                return person;
            }
            Console.WriteLine($"Keine Person mit der SVNR {svnr} gefunden!");
            return null;
        }
    }

    class PersonenInGruppe
    {
        public static void Start()
        {
            Gruppe gruppe = new Gruppe();

            gruppe.AddPerson(new Person("Lina", 11, 1.45, 40.2, 1234220215));
            gruppe.AddPerson(new Person("Ela", 17, 1.65, 55.2, 1234020804));
            gruppe.AddPerson(new Person("Leon", 20, 1.76, 57.5, 1234060605));
            gruppe.AddPerson(new Person("Tim", 25, 1.85, 67.8, 1234190600));
            gruppe.AddPerson(new Person("Franz", 44, 1.77, 80.3, 1234140681));
            gruppe.AddPerson(new Person("Deniz", 14, 1.70, 60.4, 1234140611));

            System.Console.WriteLine($"Alter:\nmin = {gruppe.GetMinAlter()}, max = {gruppe.GetMaxAlter()}, avg = {gruppe.GetAverageAlter():F2}");
            System.Console.WriteLine($"Größe:\nmin = {gruppe.GetMinGroesse():F2}m, max = {gruppe.GetMaxGroesse():F2}m, avg = {gruppe.GetAverageGroesse():F2}m");
            System.Console.WriteLine($"Größe:\nmin = {gruppe.GetMinGewicht():F2} kg, max = {gruppe.GetMaxGewicht():F2} kg, avg = {gruppe.GetAverageGewicht():F2} kg");


            System.Console.WriteLine(new string('-', 60));
            System.Console.WriteLine("Sortierung nach Größe:");
            foreach (var person in gruppe.SortierungNachGroesse("auf"))
            {
                System.Console.WriteLine(person);
            }

            System.Console.WriteLine(new string('-', 60));
            System.Console.WriteLine("Sortierung nach Alter:");
            foreach (var person in gruppe.SortierungNachAlter("ab"))
            {
                System.Console.WriteLine(person);
            }

            System.Console.WriteLine(new string('-', 60));
            System.Console.WriteLine("Sortierung nach Gewicht:");
            foreach (var person in gruppe.SortierungNachGewicht("auf"))
            {
                System.Console.WriteLine(person);
            }

            System.Console.WriteLine(new string('-', 60));
            System.Console.WriteLine("Sortierung nach Name:");
            foreach (var person in gruppe.SortierungNachName("ab"))
            {
                System.Console.WriteLine(person);
            }

            System.Console.WriteLine(new string('-', 60));

            string suchbegriff = "l";
            var gefundene = gruppe.FindeAllePersonen(suchbegriff);

            System.Console.WriteLine($"Gefundene Personen (\"{suchbegriff}\"):");
            if (gefundene.Count == 0)
            {
                System.Console.WriteLine("— keine —");
            }
            else
            {
                foreach (var p in gefundene)
                {
                    System.Console.WriteLine(p);
                }
            }

            System.Console.WriteLine(new string('-', 60));


            gruppe.EntfernePerson(1234060605);
        }
    }
}
