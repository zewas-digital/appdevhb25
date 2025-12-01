using System.Runtime.InteropServices;
using Appdevhb25.KerimAlkis.Aufgabe04;
using Appdevhb25.KerimAlkis.Aufgabe18;
using Appdevhb25.KerimAlkis.Bonusaufgabe06;
using Microsoft.VisualBasic;
using System.Windows;

namespace Appdevhb25.KerimAlkis.Bonusaufgabe76
{
    public class PersonInGruppeBonus
    {
        public static void Start()
        {
            Gruppe mainGruppe = new Gruppe();
            mainGruppe.PersonHinzufuegen(new Person(165, 22, "Mari", 60, 1232));
            mainGruppe.PersonHinzufuegen(new Person(180, 25, "Hans", 82, 4562));
            mainGruppe.PersonHinzufuegen(new Person(160, 19, "Laura", 55, 7892));
            mainGruppe.PersonHinzufuegen(new Person(175, 23, "Ben", 70, 1912));
            mainGruppe.PersonHinzufuegen(new Person(182, 30, "Sara", 75, 3333));
            mainGruppe.PersonHinzufuegen(new Person(170, 27, "Tom", 68, 4444));
            mainGruppe.PersonHinzufuegen(new Person(178, 24, "Ben", 72, 5555));
            mainGruppe.PersonHinzufuegen(new Person(159, 20, "Mila", 50, 6666));
            bool run = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Menü");
                System.Console.WriteLine("1. Sortiere nach Name");
                System.Console.WriteLine("2. Sortiere nach Groesse");
                System.Console.WriteLine("3. Sortiere nach Alter");
                System.Console.WriteLine("4. Sortiere nach Gewicht");
                System.Console.WriteLine("5. Suche Person");
                System.Console.WriteLine("6. Suche alle Personen");
                System.Console.WriteLine("7. Entferne Person mit der SVN");

                char input = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (input)
                {
                    case '1': Sortieren(mainGruppe.NameSortiert(), "Name"); break;
                    case '2': Sortieren(mainGruppe.GroesseSortiert(), "Groesse"); break;
                    case '3': Sortieren(mainGruppe.AlterSortiert(), "Alter"); break;
                    case '4': Sortieren(mainGruppe.GewichtSortiert(), "Gewicht"); break;
                    case '5': FindePerson(mainGruppe); break;
                    case '6': FindeAllePersonen(mainGruppe); break;
                    case '7': EntfernePerson(mainGruppe); break;
                    case 'o': run = false; break;
                    default: break;
                }

            } while (run);
        }
        public static void Sortieren(List<Person> sortierteGruppe, string SortNach)
        {
            int zaehler = 0;
            Console.WriteLine("Sortiere nach " + SortNach);
            foreach (var p in sortierteGruppe)
            {
                zaehler++;
                Console.WriteLine($"{zaehler}. {p.Name,-10} | Alter: {p.Alter,-2} | Größe: {p.Groesse}cm | Gewicht: {p.Gewicht}kg | SVNR: {p.SozialversicherungsNummber}");
            }
            Console.ReadKey();
        }
        public static void FindePerson(Gruppe mainGruppe)
        {
            Console.WriteLine("Welche Person ist gesucht? --- Name");
            string name = Console.ReadLine();

            Person gesuchtePerson = mainGruppe.FindePerson(name);
            if (gesuchtePerson == null)
            {
                return;
            }
            else
            {
                Console.WriteLine($"{gesuchtePerson.Name,-10} | Alter: {gesuchtePerson.Alter,-2} | Größe: {gesuchtePerson.Groesse}cm | Gewicht: {gesuchtePerson.Gewicht}kg | SVNR: {gesuchtePerson.SozialversicherungsNummber}");
            }
            Console.ReadKey();
        }
        public static void FindeAllePersonen(Gruppe mainGruppe)
        {
            Console.WriteLine("Welche Person ist gesucht? --- Name");
            string name = Console.ReadLine();

            List<Person> gesuchtePersonen = mainGruppe.FindeAllePersonen(name);
            if (gesuchtePersonen == null)
            {
                return;
            }
            else
            {
                foreach (var gesuchtePerson in gesuchtePersonen)
                    Console.WriteLine($"{gesuchtePerson.Name,-10} | Alter: {gesuchtePerson.Alter,-2} | Größe: {gesuchtePerson.Groesse}cm | Gewicht: {gesuchtePerson.Gewicht}kg | SVNR: {gesuchtePerson.SozialversicherungsNummber}");
            }
            Console.ReadKey();
        }
        public static void EntfernePerson(Gruppe mainGruppe)
        {
            Console.WriteLine("Gib die SVN um die Person zu entfernen");
            string entferenePerson = Console.ReadLine();
            mainGruppe.EntfernePerson(entferenePerson);
            Console.ReadKey();
        }
    }
    public class Person
    {
        public double Groesse;
        public int Alter;
        public string Name;
        public double Gewicht;
        private int _sozialversicherungsNummer;
        public int SozialversicherungsNummber{get{ return _sozialversicherungsNummer; } private set{ _sozialversicherungsNummer = value; }}

        public Person(double groesse, int alter, string name, double gewicht, int sozialversicherungsNummber)
        {
            Groesse = groesse;
            Alter = alter;
            Name = name;
            Gewicht = gewicht;
            SozialversicherungsNummber = sozialversicherungsNummber;
        }

    }
    public class Gruppe
    {
        private List<Person> PersonenGruppe;
        public Gruppe()
        {
            PersonenGruppe = new List<Person>();
        }
        public void PersonHinzufuegen(Person HinzuPers)
        {
            PersonenGruppe.Add(HinzuPers);
        }


        public List<Person> GroesseSortiert()
        {
            List<Person> groesseSortiert = PersonenGruppe.OrderByDescending(p => p.Groesse).ToList();
            return groesseSortiert;
        }
        public List<Person> AlterSortiert()
        {
            List<Person> alterSortiert = PersonenGruppe.OrderByDescending(p => p.Alter).ToList();
            return alterSortiert;
        }
        public List<Person> GewichtSortiert()
        {
            List<Person> gewichtSortiert = PersonenGruppe.OrderByDescending(p => p.Gewicht).ToList();
            return gewichtSortiert;
        }
        public List<Person> NameSortiert()
        {
            List<Person> nameSortiert = PersonenGruppe.OrderBy(p => p.Name).ToList();
            return nameSortiert;
        }

        public Person FindePerson(string name)
        {
            if (!PersonenGruppe.Any(p => p.Name.Equals(name)))
            {
                System.Console.WriteLine("Es gibt keine Person mit diesem Name");
                return null;
            }
            else
            {
                return PersonenGruppe.Find(p => p.Name.Equals(name));
            }
        }
        public List<Person> FindeAllePersonen(string name)
        {
            if (!PersonenGruppe.Any(p => p.Name.Equals(name)))
            {
                System.Console.WriteLine("Es gibt keine Person mit diesem Name");
                return null;
            }
            else
            {
                List<Person> gefundenePersonen = new List<Person>();
                gefundenePersonen.AddRange(PersonenGruppe.Where(p => p.Name.Equals(name)));
                return gefundenePersonen;
            }
        }
        public void EntfernePerson(string sozialversicherungsnummerString)
        {
            int sozialversicherungsnummer;
            if (int.TryParse(sozialversicherungsnummerString, out sozialversicherungsnummer)) { }
            else { Console.WriteLine("Es gibt keine Person mit dieser Nummer"); return; }
            
            if (!PersonenGruppe.Any(p => p.SozialversicherungsNummber.Equals(sozialversicherungsnummer)))
            {
                Console.WriteLine("Es gibt keine Person mit dieser Nummer");
                return;
            }
            else
            {
                Console.WriteLine(PersonenGruppe.Find(p => p.SozialversicherungsNummber.Equals(sozialversicherungsnummer)).Name +" mit der Nummer " + sozialversicherungsnummer + " wurde entfernt");
                PersonenGruppe.Remove(PersonenGruppe.Find(p => p.SozialversicherungsNummber.Equals(sozialversicherungsnummer)));
            }
        }

    }
}