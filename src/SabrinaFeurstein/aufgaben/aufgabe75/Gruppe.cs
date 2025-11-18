namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe75
{
    public class Gruppe
    {
        public List<Person> Personen = new List<Person>();

        public void PersonenHinzufuegen(Person person)
        {
            Personen.Add(person);
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