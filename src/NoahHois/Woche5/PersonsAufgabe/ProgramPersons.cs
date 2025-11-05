using System;
using Appdevhb25.NoahHois.Aufgabe66;

namespace Appdevhb25.NoahHois.Aufgabe66
{
    public class ProgramPerson
    {
        public static void Start()
        {
            Person[] people = new Person[2];
            Person firstPerson = new Person(175, new DateTime(2010, 4, 16), "Noah", 60);
            Person secondPerson = new Person(190, new DateTime(2007, 6, 23), "Hans", 80);
            people[0] = firstPerson;
            people[1] = secondPerson;

            foreach (Person p in people)
            {
                p.Print();
                p.GetBirthday();
                Console.WriteLine();
            }
        }
    }
}