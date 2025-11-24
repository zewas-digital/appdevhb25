using System;
using System.Runtime.CompilerServices;
namespace Appdevhb25.SheilaMayJaro.Aufgabe66
{
    public class PersonalInformations
    {


        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 66)");
            /* 
            1. Erstelle eine Print() Methode, welche alle Informationen zu einer Person übersichtlich ausgibt. 
            2. Erstelle eine Methode GetBirthday(), welche das Alter basierend auf dem Geburtsdatum berechnet und ausgibt. 
            3. Erstelle mehrere Personen und speichere diese in eine Array. Iteriere anschließend mit einer Schleife über diesen Array und teste deine erstellten Methoden.
            */

            Information person = new Information();
            person.Name = "West";
            person.Familyname = "Weston";
            person.Height = 174.35;
            person.Birthday = new DateTime(1994, 12, 15); //year, month, day
            person.Weight = 80.56;

            person.PrintInformations();
            person.CalculateAge(person.Birthday);
            System.Console.WriteLine();

            Information[] people = new Information[3];

            people[0] = new Information();
            people[0].Name = "West";
            people[0].Familyname = "Weston";
            people[0].Height = 174.35;
            people[0].Birthday = new DateTime(1994, 12, 15);
            people[0].Weight = 80.56;
            people[0].PrintInformations();
            person.CalculateAge(people[0].Birthday);

            System.Console.WriteLine();
            people[1] = new Information(); 
            DateTime birthday = new DateTime(1998, 03, 10);
            people[1].PrintInformations("Anna", "Green", 162.57, 65.08, birthday);
            person.CalculateAge(people[1].Birthday);

            System.Console.WriteLine();
            people[2] = new Information(); 
            DateTime birthday2 = new DateTime(2000,09,23);
            people[2].PrintInformations("Rain", "White", 171.57, 58.08, birthday2);
            person.CalculateAge(people[2].Birthday);

            // for (int i = 0; i < people.Length; i++)
            // {
            //     people[i].PrintInformations();
            //     people[i].CalculateAge(people[i].Birthday);
            //     System.Console.WriteLine();
            // }
        }
    }
}