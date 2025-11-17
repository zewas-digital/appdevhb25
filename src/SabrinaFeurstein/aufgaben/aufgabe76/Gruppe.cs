using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe76
{
    public class Gruppe
    {
        private List<Person> _personen;
        public List<Person> Personen
        {
            get { return _personen; }
        }

        public Gruppe()
        {
            _personen = new List<Person>();
        }

        public void PersonenHinzufuegen(Person person)
        {
            Personen.Add(person);
        }

        // Personen anhand ihrer Sozialversicherungsnummer entfernen
        public void PersonEntfernen(string sozialversicherungsnummer)
        {
            Personen.RemoveAll(p => p.Sozialversicherungsnummer == sozialversicherungsnummer);

            // foreach (Person person in Personen)
            // {
            //     if (person.Sozialversicherungsnummer == sozialversicherungsnummer)
            //     {
            //         Personen.Remove(person);
            //         break;
            //     }
            // }
        }

        // Methoden zum Suchen nach Personen
        public Person FindePerson(string suche)
        {
            Person gefundenePerson = new Person("", 0, 0, 0, "");

            gefundenePerson = Personen.Find(p => p.Name.Contains(suche))!;

            // foreach (Person person in Personen)
            // {
            //     if (person.Name.Contains(suche))
            //     {
            //         gefundenePerson = person;
            //         break;
            //     }
            // }

            return gefundenePerson;
        }

        public List<Person> FindeAllePersonen(string suche)
        {
            List<Person> gefundenePersonen = new List<Person>();

            gefundenePersonen = Personen.FindAll(p => p.Name.Contains(suche));

            // foreach (Person person in Personen)
            // {
            //     if (person.Name.Contains(suche))
            //     {
            //         gefundenePersonen.Add(person);
            //     }
            // }

            return gefundenePersonen;
        }

        // Methoden zum Sortieren der Liste
        public List<Person> SortiereNachGroesse(string richtung)
        {
            if (richtung.Contains("auf"))
                return Personen.OrderBy(p => p.Groesse).ToList();

            else if (richtung.Contains("ab"))
                return Personen.OrderByDescending(p => p.Groesse).ToList();

            else
            {
                Console.WriteLine("Ungültiger Parameter!");
                return new List<Person>();
            }
        }

        public List<Person> SortiereNachAlter(string richtung)
        {
            if (richtung.Contains("auf"))
                return Personen.OrderBy(p => p.Alter).ToList();

            else if (richtung.Contains("ab"))
                return Personen.OrderByDescending(p => p.Alter).ToList();

            else
            {
                Console.WriteLine("Ungültiger Parameter!");
                return new List<Person>();
            }
        }

        public List<Person> SortiereNachGewicht(string richtung)
        {
            List<Person> PersonenSortiertNachGewicht = new List<Person>();
            if (richtung.Contains("auf"))
                PersonenSortiertNachGewicht = Personen.OrderBy(p => p.Gewicht).ToList();
            else if (richtung.Contains("ab"))
            {
                PersonenSortiertNachGewicht = Personen.OrderBy(p => p.Gewicht).ToList();
                PersonenSortiertNachGewicht.Reverse();
            }
            else
                Console.WriteLine("Ungültiger Parameter!");

            return PersonenSortiertNachGewicht;
        }

        public List<Person> SortiereNachName(string richtung)
        {
            List<Person> PersonenSortiertNachName = new List<Person>();
            if (richtung.Contains("auf"))
                PersonenSortiertNachName = Personen.OrderBy(p => p.Name).ToList();
            else if (richtung.Contains("ab"))
            {
                PersonenSortiertNachName = Personen.OrderBy(p => p.Name).ToList();
                PersonenSortiertNachName.Reverse();
            }
            else
                Console.WriteLine("Ungültiger Parameter!");

            return PersonenSortiertNachName;
        }



        // Min-, Max-Werte und Durchschnitt für Größe
        public double GroesseMin()
        {
            return Personen.Min(p => p.Groesse);
        }

        public double GroesseMax()
        {
            return Personen.Max(p => p.Groesse);
        }

        public double GroesseDurchschnitt()
        {
            return Personen.Average(p => p.Alter);
        }

        // Min-, Max-Werte und Durchschnitt für Alter
        public double AlterMin()
        {
            var sortiert = Personen.OrderByDescending(p => p.Alter).ToList();
            return sortiert[sortiert.Count - 1].Alter;
        }

        public double AlterMax()
        {
            var sortiert = Personen.OrderByDescending(p => p.Alter).ToList();
            return sortiert[0].Alter;
        }

        public double AlterDurchschnitt()
        {
            return Personen.Sum(p => p.Alter) / Personen.Count;
        }

        // Min-, Max-Werte und Durchschnitt für Gewicht
        public double GewichtMin()
        {
            double gewichtMin = GewichtMax();
            foreach (Person person in Personen)
            {
                if (person.Gewicht < gewichtMin)
                    gewichtMin = person.Gewicht;
            }
            return gewichtMin;
        }

        public double GewichtMax()
        {
            double gewichtMax = 0;
            foreach (Person person in Personen)
            {
                if (person.Gewicht > gewichtMax)
                    gewichtMax = person.Gewicht;
            }
            return gewichtMax;
        }

        public double GewichtDurchschnitt()
        {
            double gewichtSumme = 0;
            foreach (Person person in Personen)
            {
                gewichtSumme += person.Gewicht;
            }
            return gewichtSumme / Personen.Count;
        }
    }
}