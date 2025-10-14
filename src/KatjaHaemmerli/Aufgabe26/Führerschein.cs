using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe20;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe26
{

    public class Führerschein
    {
        //Erstelle ein Programm, das prüft, ob Personen aufgrund ihres alters berechtigt sind ein Moped und/oder Auto zu fahren.
        public static void Schein()
        {
            Console.WriteLine("Pls enter your name.");
            string name = Console.ReadLine();

            Console.WriteLine("Pls enter your age.");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You are not old enough for driving a car");
            }
            if (age == 16)
            {
                Console.WriteLine("You can drive a moped.");
            }
            else // grösser oder gleich 18
            {
                Console.WriteLine("You are old enough for driving a car.");
            }            
            Console.WriteLine($"Your name is: {name} and you are {age} years old.");
        }        

    }
}