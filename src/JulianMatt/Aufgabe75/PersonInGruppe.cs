
namespace Appdevhb25.JulianMatt.Aufgabe75
{
    public class PersonInGruppe
    {
        public static void Start75()
        {
            List<Gruppe> groups = new List<Gruppe>();

            bool isTrue = true;
            int i = 0;

            i = ListFiller(groups, isTrue, i);
            Print(i, groups);
            FindOutSpecifics(groups, i);
        }

        public static int ListFiller(List<Gruppe> groups, bool isTrue, int i)
        {
            while (isTrue == true)
            {
                System.Console.WriteLine("Wollen sie eine Person eintragen? (ja/nein)");

                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "ja":
                        groups.Add(new Gruppe());
                        groups[i].AddPerson(i);
                        i++;
                        break;
                    case "nein":
                        isTrue = false;
                        break;

                    default:
                        System.Console.WriteLine("Ungültige Eingabe, bitte 'ja' oder 'nein' eingeben.");
                        break;
                }
            }
            Console.Clear();
            return i;
        }

        public static void Print(int i, List<Gruppe> groups)
        {
            for (int j = 0; j < i; j++)
            {
                groups[j].PrintGroup(j);
                System.Console.WriteLine("----------------------------");
                System.Console.WriteLine();
            }
        }

        public static void FindOutSpecifics(List<Gruppe> groups, int i)
        {
            SpecificsOfHight(i, groups);
            SpecificsOfAge(i, groups);
            SpecificsOfWieght(i, groups);
        }

        public static void SpecificsOfHight(int i, List<Gruppe> groups)
        {
            string Field = "Hight";
            System.Console.WriteLine($"Die Kleinste größe ist {groups[0].Smallest(Field)}");
            System.Console.WriteLine($"Die Größte größe ist {groups[0].BiggestElement(Field)}");
            System.Console.WriteLine($"Die Durschnitliche größe ist {groups[0].Avg(Field)}");

        }

        public static void SpecificsOfAge(int i, List<Gruppe> groups)
        {
            string Field = "Age";
            System.Console.WriteLine($"Die Jüngste Person ist {groups[0].Smallest(Field)}");
            System.Console.WriteLine($"Die Älteste Person ist {groups[0].BiggestElement(Field)}");
            System.Console.WriteLine($"Das Durchscnitsalter ist {groups[0].Avg(Field)}");
        }

        public static void SpecificsOfWieght(int i, List<Gruppe> groups)
        {
            string Field = "Wieght";
            System.Console.WriteLine($"Die am wenigsten wiegende Person wiegt {groups[0].Smallest(Field)}");
            System.Console.WriteLine($"Die am meisten weigende Person wiegt {groups[0].BiggestElement(Field)}");
            System.Console.WriteLine($"Das durchschnits gewicht ist {groups[0].Avg(Field)}");
        }
    }
}
