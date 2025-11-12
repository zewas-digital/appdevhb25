using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe75
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
    }
}