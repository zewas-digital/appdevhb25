using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Appdevhb25.LiaLouiseNatter.Aufgabe66;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe76
{
    class Gruppe
    {
        List<PersonInGruppe> group = new List<PersonInGruppe>();

        public void neuePerson(PersonInGruppe person)
        {
            group.Add(person);
        }

        public void Smallest()
        {
            int youngest = group[1].age;
            int smallest = group[1].height;
            int skinniest = group[1].weight;
            for (int i = 0; i < group.Count; i++)
            {
                if (group[i].age < youngest)
                {
                    youngest = group[i].age;
                }
                if (group[i].height < smallest)
                {
                    smallest = group[i].height;
                }
                if (group[i].weight < skinniest)
                {
                    skinniest = group[i].weight;
                }
            }
            System.Console.WriteLine($"Youngest: {youngest}");
            System.Console.WriteLine($"Smallest: {smallest}");
            System.Console.WriteLine($"Skinniest: {skinniest}");

        }
        public void Biggest()
        {
            int oldest = group[0].age;
            int tallest = group[0].height;
            int fattest = group[0].weight;
            for (int i = 0; i < group.Count; i++)
            {
                if (group[i].age > oldest)
                {
                    oldest = group[i].age;
                }
                if (group[i].height > tallest)
                {
                    tallest = group[i].height;
                }
                if (group[i].weight > fattest)
                {
                    fattest = group[i].weight;
                }
            }
            System.Console.WriteLine($"Oldest: {oldest}");
            System.Console.WriteLine($"Tallest: {tallest}");
            System.Console.WriteLine($"Fattest: {fattest}");
        }

        public void Average()
        {
            int heightAvg = 0;
            int ageAvg = 0;
            int weigtAvg = 0;
            for (int i = 0; i < group.Count; i++)
            {
                heightAvg += group[i].height;
                ageAvg += group[i].age;
                weigtAvg += group[i].weight;
            }
            heightAvg /= group.Count;
            ageAvg /= group.Count;
            weigtAvg /= group.Count;
            System.Console.WriteLine($"Avergae Age: {ageAvg}");
            System.Console.WriteLine($"Average weight: {weigtAvg}");
            System.Console.WriteLine($"Average height: {heightAvg}");



        }

        public void SortByHeight(bool ascDesc)
        {
            if (ascDesc == true)
            {
                List<PersonInGruppe> sortedByHeightAsc = group.OrderByDescending(h => h.height).ToList();
                ListPrinter(sortedByHeightAsc);
            }
            else
            {
                List<PersonInGruppe> sortedByHeightDesc = group.OrderBy(n => n.height).ToList();
                ListPrinter(sortedByHeightDesc);
            }
            
        }
        public void SortByWeight(bool ascDesc)
        {
            if (ascDesc == true)
            {
                List<PersonInGruppe> sortedByWeightAsc = group.OrderByDescending(person => person.weight).ToList();
                ListPrinter(sortedByWeightAsc);
            }
            else
            {
                List<PersonInGruppe> sortedByWeightDesc = group.OrderBy(n => n.weight).ToList();
                ListPrinter(sortedByWeightDesc);
            }
            
        }
        public void SortByAge(bool ascDesc)
        {
            if (ascDesc == true)
            {
                List<PersonInGruppe> sortedByAge = group.OrderByDescending(age => age.age).ToList();
                ListPrinter(sortedByAge);
            }
            else
            {
                List<PersonInGruppe> sortedByAgeDesc = group.OrderBy(n => n.age).ToList();
                ListPrinter(sortedByAgeDesc);
            }
            

        }
        public void SortByName(bool ascDesc)
        {
            if (ascDesc == true)
            {
                List<PersonInGruppe> sortedByNameDesc = group.OrderByDescending(x => x.name).ToList();
                ListPrinter(sortedByNameDesc);
            }
            else
            {
                List<PersonInGruppe> sortedByNameDesc = group.OrderBy(x => x.name).ToList();
                ListPrinter(sortedByNameDesc);
            }
            
        }

        public void ListPrinter(List<PersonInGruppe> personen/*, PersonInGruppe wishedAttribute*/)
        {
            foreach (var person in personen)
            {
                System.Console.WriteLine(person.name);
                /*
                if(wishedAttribute = person.age)
                {
                    
                }
                */
            }
        }

        public PersonInGruppe findPerson(string name)
        {
            PersonInGruppe keinePerson = new PersonInGruppe();
            for (int i = 0; i < group.Count; i++)
            {
                if (name == group[i].name)
                {
                    PersonInGruppe person = group[i];
                    return person;
                }
            }
            return keinePerson;
            //find methode
            
            
        }

        public List<PersonInGruppe> findAllPersons() // Alle personen die xy heißen
        {
            ListPrinter(group);
            return group;
        }
        
        public void DeletePerson(int social)
        {
            for (int i = 0; i < group.Count; i++)
            {
                if (social == group[i].socialSecurityNum)
                {
                    PersonInGruppe person = group[i];
                    group.Remove(person);
                }
            }
            ListPrinter(group);
        }

    }
}