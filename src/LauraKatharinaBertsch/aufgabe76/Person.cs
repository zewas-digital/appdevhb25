namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe76
{
    public class Person
    {
        private decimal _groesse;
        private int _alter;
        private decimal _gewicht;
        private string _name;
        private int _sozialversicherungsnummer;

        public decimal Groesse
        {
            get
            {
                return _groesse;
            }
            set
            {
                _groesse = value;
            }
        }
        public int Alter
        {
            get
            {
                return _alter;
            }
            set
            {
                _alter = value;
            }
        }
        public decimal Gewicht
        {
            get
            {
                return _gewicht;
            }
            set
            {
                _gewicht = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Sozialversicherungsnummer
        {
            get
            {
                return _sozialversicherungsnummer;
            }
            set
            {
                _sozialversicherungsnummer = value;
            }
        }

        public Person(decimal groesse, int alter, string name, decimal gewicht, int sozialversicherungsnummer)
        {
            Groesse = groesse;
            Alter = alter;
            Name = name;
            Gewicht = gewicht;
            Sozialversicherungsnummer = sozialversicherungsnummer;
        }
        public static void RemovePeople(List<Person> persons, int sozialversicherunsnummer)
        {
            var personToRemove = persons.Where(person => person.Sozialversicherungsnummer == sozialversicherunsnummer).ToList();
            foreach (var person in personToRemove)
            {
                persons.Remove(person);
            }
        }
    }
}