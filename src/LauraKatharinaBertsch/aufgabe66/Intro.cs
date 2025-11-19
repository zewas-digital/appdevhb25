namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe66
{
    public class Intro
    {
        public static void Start()
        {
            Personen Person1 = new Personen(1.70M, new DateTime(2007, 06, 16), "Luis", 70);
            Personen Person2 = new Personen(1.80M, new DateTime(2008, 05, 16), "Anna", 60);
            Personen Person3 = new Personen(1.60M, new DateTime(2009, 07, 16), "Lisa", 50);

            Personen[] personenArray = new Personen[3];
            personenArray[0] = Person1;
            personenArray[1] = Person2;
            personenArray[2] = Person3;

            int i = 0;
            foreach (Personen einePerson in personenArray)
            {
                i++;
                Console.WriteLine();
                Console.WriteLine("Person " + i);
                einePerson.Print();
                einePerson.GetBirthday();
            }

        }
    }
}