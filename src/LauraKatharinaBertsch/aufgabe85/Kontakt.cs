namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe85
{
    public class Kontakt
    {
        public string LastName;
        public string Location;
        public string Phonenumber;

        public Kontakt(string lastName, string location, string phonenumber)
        {
            LastName = lastName;
            Location = location;
            Phonenumber = phonenumber;
        }
        public override string ToString()
        {
            return $"{LastName} {Location} {Phonenumber}";
        }
    }
}