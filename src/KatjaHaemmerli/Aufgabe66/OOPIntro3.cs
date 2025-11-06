namespace Appdevhb25.KatjaHaemmerli.Aufgab66
{
    public class OOPIntro3
    {
        public static void Start()
        {
            
            Person person = new Person();
            person.Name = "Katja";
            person.Geburtstag = new DateTime(1991,12,30);
            person.Groesse = 1.63;
            person.Gewicht = 46;

            Person person1 = new Person();
            person1.Name = "Nora"; // Nora braucht .Name weil auf den 1. Konstruktor(ohne Übergabeparameter) zugreift
            person1.Geburtstag = new DateTime(2000,01,31);
            person1.Groesse = 1.73;
            person1.Gewicht = 62;

            Person person2 = new Person("Anna", 1.83); // Anna braucht person2. Name nicht, 
            // weil "Anna" hier in der Objekterstellung steht und auf den 2.Konstruktor (mit Übergabewerte) zugreift,
            // wo Name definiert ist (Name = name;)
            person2.Geburtstag = new DateTime(2001,02,20);            
            person2.Gewicht = 75;

            person.PrintPersonenAttribute();
            person.AlterBerechnen();
            System.Console.WriteLine(); // Abstand
            person1.PrintPersonenAttribute();
            person1.AlterBerechnen();
            System.Console.WriteLine();
            person2.PrintPersonenAttribute();
            person2.AlterBerechnen();

            // Personen in Array
            Person[] personen = new Person[3];

            System.Console.WriteLine("Personen im Array:");
            personen[0] = new Person("Kat", 1,63);
            personen[1] = new Person("Carola", 1.61);
            personen[2] = new Person("Jessica", 1.60);           

            System.Console.WriteLine(); // Abstand zum Vorherigen

            foreach (Person p in personen)
            {
                System.Console.WriteLine($"Name: {p.Name}"); // .Name weil ich auf einem Wert im Objekt zugreifen möchte
                System.Console.WriteLine($"Grösse: {p.Groesse}");
                              
            }
            
        }
    }
}
