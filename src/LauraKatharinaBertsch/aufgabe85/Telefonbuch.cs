using System.Data;
using Appdevhb25.LauraKatharinaBertsch.Aufgabe75;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe85
{
    public class Telefonbuch
    {
        public static List<Kontakt> kontakts = new List<Kontakt>();
        public static void Start()
        {
            AddPerson();
            Change();
            DeletePerson();
            LookingForLastName();
        }
        public static void AddPerson()
        {
            while (true)
            {
                Console.WriteLine("Möchtest du eine Person zum Telefonbuch hinzufügen? ja oder nein");
                string answer = Console.ReadLine() ?? string.Empty;
                if (answer == "nein")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Person hinzufügen: Gib einen Nachnamen ein");
                    string lastName = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("Gib einen Ort ein, woher die Person kommt");
                    string location = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("Gib die Telefonnummer der Person ein");
                    string phonenumber = Console.ReadLine() ?? string.Empty;
                    Kontakt kontakt = new Kontakt(lastName, location, phonenumber);
                    kontakts.Add(kontakt);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Das Telefonbuch:");
            foreach (var k in kontakts)
            {
                Console.WriteLine(k);
            }
        }
        public static void Change()
        {
            Console.WriteLine();
            while (true)
            {
                Kontakt kontaktToChange = kontakts.Find(item => item.LastName == "");
                Console.WriteLine("Möchtest du einen Namen ändern? ja oder nein");
                string answer = Console.ReadLine() ?? string.Empty;
                if (answer == "nein")
                {
                    Console.WriteLine("Die Liste wurde erneuert:");
                    foreach (var k in kontakts)
                    {
                        Console.WriteLine(k);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Gib einen Namen ein, den du ändern willst");
                    string nameToChange = Console.ReadLine() ?? string.Empty;
                    kontaktToChange = kontakts.Find(item => item.LastName == nameToChange);
                    Console.WriteLine("Gib einen Namen ein, um den du den gesuchten Namen ändern willst:");
                    string changing = Console.ReadLine() ?? string.Empty;

                    kontaktToChange.LastName = changing;

                }
            }
        }
        public static void DeletePerson()
        {
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Möchtest du eine Person löschen? ja oder nein");
                string answer = Console.ReadLine() ?? string.Empty;
                if (answer == "nein")
                {
                    Console.WriteLine("Die Liste wurde erneuert:");
                    foreach (var k in kontakts)
                    {
                        Console.WriteLine(k);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Person löschen: Gib einem Namen ein, den du löschen willst");
                    string findPerson = Console.ReadLine() ?? string.Empty;
                    kontakts.Remove(kontakts.Find(element => element.LastName == findPerson));
                }
            }
        }
        public static void LookingForLastName()
        {
            Console.WriteLine();

            Console.WriteLine("Möchstest du eine Person suchen? ja oder nein");
            string answer = Console.ReadLine() ?? string.Empty;
            if (answer == "ja")
            {
                Console.WriteLine("Kontakt nach Nachnamen suchen: Gib einen Namen ein, den du suchen willst");
                string findPerson = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Die gefundenen Personen:");
                foreach (var k in kontakts)
                {
                    if (k.ToString().Contains(findPerson))
                    {
                        Console.WriteLine(k);
                    }
                }
            }
        }
    }
}
