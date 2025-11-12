namespace Appdevhb25.JulianMatt.Aufgabe76
{
    public class PersonInGruppeBonus
    {
        public static void Start76()
        {
            List<Gruppe> groups = new List<Gruppe>();

            bool isTrue = true;
            int i = 0;

            i = ListFiller(groups, isTrue, i);

            Print(i, groups);

            FindOutSpecifics(groups, i);

            SortBy(groups);
            
            while (true)
            {
                Searcher(groups, i);

                Delete(groups, i);
            }




        }

        public static void Searcher (List<Gruppe> groups,int i)
        {
            bool isFound = false;
            System.Console.WriteLine("Nach welcher Person wollen sie suchen");
            string person = Console.ReadLine();
            for (int j = 0; j < i; j++)
            {
                isFound = groups[j].FindPerson(person);
                if (isFound == true)
                {
                    break;
                }
            }
            
            if (isFound == false)
            {
                System.Console.WriteLine("Niemand mit dem Namen wurde gefunden");
            }

            else
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Andere möglichkeiten");

                for (int j = 0; j < i; j++)
                {
                    groups[j].FindPerson(person);
                }
            }
            
        }
        
        public static void Delete (List<Gruppe> groups,int i)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Möchten sie einen Eintrag löschen? (ja/nein)");
            string input = Console.ReadLine();
            bool isFound = false;
            switch (input.ToLower())
            {
                case "ja":
                    System.Console.WriteLine("Wie lautet die Sozialversicherungsnummer der Person die sie löschen wollen:");
                    string socialNumber = Console.ReadLine();
                    for (int j = 0; j < i; j++)
                    {
                        isFound = groups[j].DeletePerson(socialNumber);
                    }

                    if (isFound == false)
                    {
                        System.Console.WriteLine("Kein eintrag gefunden");
                    }
                    
                    break;

                case "nein":
                    break;

                default:
                    System.Console.WriteLine("Ungültige Eingabe");
                    break;
            }
                
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
                groups[j].PrintGroup();
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
            System.Console.WriteLine();
            System.Console.WriteLine($"Die Kleinste größe ist {groups[0].Smallest(Field)}");
            System.Console.WriteLine($"Die Größte größe ist {groups[0].BiggestElement(Field)}");
            System.Console.WriteLine($"Die Durschnitliche größe ist {groups[0].Avg(Field)}");

        }

        public static void SpecificsOfAge(int i, List<Gruppe> groups)
        {
            string Field = "Age";
            System.Console.WriteLine();
            System.Console.WriteLine($"Die Jüngste Person ist {groups[0].Smallest(Field)}");
            System.Console.WriteLine($"Die Älteste Person ist {groups[0].BiggestElement(Field)}");
            System.Console.WriteLine($"Das Durchscnitsalter ist {groups[0].Avg(Field)}");
        }

        public static void SpecificsOfWieght(int i, List<Gruppe> groups)
        {
            string Field = "Wieght";
            System.Console.WriteLine();
            System.Console.WriteLine($"Die am wenigsten wiegende Person wiegt {groups[0].Smallest(Field)}");
            System.Console.WriteLine($"Die am meisten weigende Person wiegt {groups[0].BiggestElement(Field)}");
            System.Console.WriteLine($"Das durchschnits gewicht ist {groups[0].Avg(Field)}");
        }

        
        
        public static void SortBy(List<Gruppe> groups)
        {
            SortByHight(groups);
            SortByAge(groups);
            SortByWieght(groups);
            SortByName(groups);
        }

        public static void SortByHight(List<Gruppe> groups)
        {
            string Field = "Hight";
            groups[0].SortByField(Field, groups);

            System.Console.WriteLine();
            System.Console.WriteLine("Nach Größe sortiert:");
            Print(groups.Count, groups);
        }

        public static void SortByAge(List<Gruppe> groups)
        {
            string Field = "Age";
            groups[0].SortByField(Field, groups);

            System.Console.WriteLine();
            System.Console.WriteLine("Nach Alter sortiert");
            Print(groups.Count, groups);
        }

        public static void SortByWieght(List<Gruppe> groups)
        {
            string Field = "Wieght";
            groups[0].SortByField(Field, groups);

            System.Console.WriteLine();
            System.Console.WriteLine("Nach Gewicht sortiert");
            Print(groups.Count, groups);
        }

        public static void SortByName(List<Gruppe> groups)
        {
            string Field = "Name";
            groups[0].SortByFieldString(Field);

            System.Console.WriteLine();
            System.Console.WriteLine("Nach Name Sortieren");
            Print(groups.Count, groups);
        }
        


    }
}
