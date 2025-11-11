using System;
using System.Runtime.InteropServices;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe66
{
    public class PersonCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            List<Person> persons = new List<Person>();
            
            Person p1 = new Person();
            p1.Name = "a";
            p1.BirthDate = new DateTime(2020, 10, 10);
            p1.Height = 1;
            p1.Weight = 1;
            persons.Add(p1);

            Person p2 = new Person();
            p2.Name = "b";
            p2.BirthDate = new DateTime(2000,10,10);
            p2.Height = 1;
            p2.Weight = 1;
            persons.Add(p2);

            Person p3 = new Person();
            p3.Name = "c";
            p3.BirthDate = new DateTime(2010,10,10);
            p3.Height = 1;
            p3.Weight = 1;
            persons.Add(p3);


            foreach (var person in persons)
            {
                person.PrintPerson();
            }

            p3.WriteBirthDay();

        }
    }
}
