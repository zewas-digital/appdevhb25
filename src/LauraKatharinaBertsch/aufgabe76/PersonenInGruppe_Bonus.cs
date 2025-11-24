namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe76
{
    public class PersonInGruppe_Bonus
    {
        public static void Start()
        {
            Gruppe.AddPerson(new Person(1.23m, 15, "Luise", 34.2m, 12345));
            Gruppe.AddPerson(new Person(1.17m, 13, "Peter", 55.3m, 12346));
            Gruppe.AddPerson(new Person(1.52m, 20, "Luise", 54.9m, 12347));
            Gruppe.AddPerson(new Person(1.79m, 19, "Felix", 43.1m, 12348));
            Gruppe.AddPerson(new Person(1.34m, 14, "Marie", 36.5m, 12349));

            List<Person> sortedHight = Gruppe.SortedHight();
            List<Person> sortedAge = Gruppe.SortedAge();
            List<Person> sortedWeight = Gruppe.SortedWeight();
            List<Person> sortedName = Gruppe.SortedName();

            Console.WriteLine("Sortiert nach Größe:");
            foreach (var size in sortedHight)
            {
                Console.WriteLine($"{size.Name}: | {size.Groesse}m | {size.Alter} Jahre | {size.Gewicht}kg | SV: {size.Sozialversicherungsnummer}");
            }
            Console.WriteLine();
            Console.WriteLine("Sortiert nach Alter:");
            foreach (var age in sortedAge)
            {
                Console.WriteLine($"{age.Name}: | {age.Groesse}m | {age.Alter} Jahre | {age.Gewicht}kg | SV: {age.Sozialversicherungsnummer}");
            }
            Console.WriteLine();
            Console.WriteLine("Sortiert nach Gewicht:");
            foreach (var weight in sortedWeight)
            {
                Console.WriteLine($"{weight.Name}: | {weight.Groesse}m | {weight.Alter} Jahre | {weight.Gewicht}kg | SV: {weight.Sozialversicherungsnummer}");
            }
            Console.WriteLine();
            Console.WriteLine("Sortiert nach Name:");
            foreach (var name in sortedName)
            {
                Console.WriteLine($"{name.Name}: | {name.Groesse}m | {name.Alter} Jahre | {name.Gewicht}kg | SV: {name.Sozialversicherungsnummer}");
            }

            Gruppe gruppe = new Gruppe();
            Person foundPerson = gruppe.FindePerson(p => p.Name == "Luise");
            Console.WriteLine();
            if (foundPerson != null)
            {

                Console.WriteLine($"Gefunden: {foundPerson.Name}: | {foundPerson.Groesse}m | {foundPerson.Alter} Jahre | {foundPerson.Gewicht}kg | SV: {foundPerson.Sozialversicherungsnummer}");
            }
            else
            {
                Console.WriteLine("Person nicht gefunden");
            }

            List<Person> foundPersons = gruppe.FindeAllePersonen(p => p.Name == "Luise");
            if (foundPersons != null)
            {
                int i = 0;
                foreach (var person in foundPersons)
                {
                    i++;
                    if (i == 1)
                    {
                        Console.WriteLine($"Gefunden: {person.Name}: | {person.Groesse}m | {person.Alter} Jahre | {person.Gewicht}kg | SV: {person.Sozialversicherungsnummer}");
                    }
                    else
                    {
                        Console.WriteLine($"          {person.Name}: | {person.Groesse}m | {person.Alter} Jahre | {person.Gewicht}kg | SV: {person.Sozialversicherungsnummer}");
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine("Die Liste nach dem Entfernen bestimmter Personen:");
            Gruppe.RemovePeople();
            foreach (var people in Gruppe.gruppe)
            {
                Console.WriteLine($"{people.Name}: | {people.Groesse}m | {people.Alter} Jahre | {people.Gewicht}kg | SV: {people.Sozialversicherungsnummer}");
            }
        }
    }
}
