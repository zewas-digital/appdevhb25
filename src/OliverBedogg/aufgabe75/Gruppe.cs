using System;
using System.Collections.Generic;

namespace Appdevhb25.OliverBedogg.aufgabe75
{
    public class Gruppe
    {
        private List<Person> _Personen;
        public List<Person> Personen
        {
            get { return _Personen; }
        }

        public Gruppe()
        {
            _Personen = new List<Person>();
        }

        public void plusPerson(Person person)
        {
            _Personen.Add(person);
        }

        public double durchschnittsalter()
        {
            return _Personen.Average(p => p.Alter);
        }

        public double groesstePerson()
        {
            // LINQ OrderBy-Methode aus System.Linq in eine sortierte Liste umwandeln
            // Sortiert wird nach dem Feld p.Groesse absteigend
            var sortiert = _Personen.OrderByDescending(p => p.Groesse).ToList();
            // Die erste Person in der sortierten Liste ist die Größte
            return sortiert[0].Groesse;
        }

        public double kleinsterWert(string Feld)
        {
            // Veriefende Implementierung einer Sortierung nach beliebigem Feld (Property)
            // Lösungsvariante: Abfrage mittels Reflection
            // Reflection ermöglicht den Zugriff auf Metadaten von Klassen, Methoden, Properties, etc.
            // https://learn.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo?view=net-8.0

            // Prüfen ob das Feld existiert
            if (_Personen[0].GetType().GetProperty(Feld) == null)
            {
                throw new ArgumentException("Ungültiges Feld: " + Feld);
            }
            else
            {
                var sortiert = _Personen.OrderBy(
                    // dynamischer Zugriff auf das Feld und dessen Wert, um zu sortieren
                    p => p.GetType().GetProperty(Feld).GetValue(p, null)).ToList();

                // Die erste Person in der sortierten Liste beinhaltet 
                // den kleinsten Wert im angegebenen Feld
                return Convert.ToDouble(
                    sortiert[0].GetType().GetProperty(Feld).GetValue(sortiert[0], null)
                    );
            }
        }
        
        public override string ToString()
        {
            return "Personen der Gruppe: " + string.Join(", ", _Personen);
        }
    }
}