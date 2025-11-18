namespace Appdevhb25.SheilaMayJaro.Aufgabe85
{
    public class Contact
    {
        private string? _firstName;
        private string? _lastName;

        private string? _place;
        private string? _phoneNumber;

        List<Contact> contacts = new List<Contact>();
        public string? FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string? LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string? Place
        {
            get { return _place; }
            set { _place = value; }
        }
        public string? PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public Contact()
        {

        }
        public Contact(string lastName, string phoneNumber)
        {
            _lastName = lastName;
            _phoneNumber = phoneNumber;
        }
        public Contact(string firstName, string lastName, string phoneNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            _phoneNumber = phoneNumber;
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }
        public void ModifyContact()
        {
            System.Console.WriteLine("Welchen Kontakt willst du bearbeiten?\nGib den Vor- oder Nachnamen ein.");
            string? temp = Console.ReadLine();
            foreach (Contact item in contacts)
            {
                if (item._lastName == temp || item._firstName == temp)
                {
                    System.Console.WriteLine("Was willst du ändern?");
                    temp = Console.ReadLine();
                    if ("Vorname" == temp)
                    {
                        System.Console.WriteLine("Gib den neuen Vornamen ein.");
                        item._firstName = Console.ReadLine();
                    }
                    else if ("Nachname" == temp)
                    {
                        System.Console.WriteLine("Gib den neuen Nachnamen ein.");
                        item._lastName = Console.ReadLine();
                    }
                    else
                    {
                        System.Console.WriteLine("Gib die neue Telefonnumer ein.");
                        item._phoneNumber = Console.ReadLine();
                    }
                }
            }
            System.Console.WriteLine("Es wurde erfolgreich geändert.");
        }
        public void DeleteContact()
        {
            System.Console.WriteLine("Welchen Kontakt willst du löschen?\nGib den Vor- oder Nachnamen ein.");
            string? temp = Console.ReadLine();
            foreach (Contact item in contacts)
            {
                if (item._lastName == temp || item._firstName == temp)
                {
                   contacts.Remove(item);
                   break;
                }
            }
            System.Console.WriteLine("Es wurde erfolgreich geändert.");
        }
        public void FindContact()
        {
            System.Console.WriteLine("Welchen Kontakt suchst du?\nGib den Nachnamen ein.");
            string? temp = Console.ReadLine();
            foreach (Contact item in contacts)
            {
                if (item._lastName == temp)
                {
                   System.Console.WriteLine($"\nGesuchter Kontakt:\nVorname: {item.FirstName}\nNachname: {item.LastName}\nTelefonnumer: {item.PhoneNumber}");
                }
            }
        }
        public void PrintContacts()
        {
            foreach (Contact item in contacts)
            {
                System.Console.WriteLine($"\nKontakt:\nVorname: {item.FirstName}\nNachname: {item.LastName}\nTelefonnumer: {item.PhoneNumber}");
            }
        }

    }
}