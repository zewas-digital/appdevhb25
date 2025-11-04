using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe66
{
    public class Personen
    {

        public static void Start66()
        {
            int CountOfPersonsThatwhereUsed = 0;
            System.Console.WriteLine("Wie viele Personen wollen sie Eintragen: ");
            int countOfPersons = Convert.ToInt32(Console.ReadLine());
            TypischeEigenschaften[] Persons = new TypischeEigenschaften[countOfPersons];


            for (int i = 0; i < Persons.Length; i++)
            {
                System.Console.WriteLine("Wie groß is die Person: ");
                Persons[i] = new TypischeEigenschaften();
                Persons[i].Size = Convert.ToDouble(Console.ReadLine());

                System.Console.WriteLine("Wann ist die Person geboren zb(02.04.2009): ");
                Persons[i].Birthday = Convert.ToDateTime(Console.ReadLine());

                System.Console.WriteLine("Wie heißt die Person: ");
                Persons[i].Name = Console.ReadLine();

                System.Console.WriteLine("Wie viel Gewicht hat die Person zb(78,45): ");
                Persons[i].Weight = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                CountOfPersonsThatwhereUsed++;
            }



            for (int i = 0; i < CountOfPersonsThatwhereUsed; i++)
            {
                System.Console.WriteLine();
                System.Console.WriteLine();
                System.Console.WriteLine(i + 1 + " Person");
                Persons[i].Print();
                Persons[i].AgeCalculator();
            }

        }




    }
}