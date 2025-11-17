using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe76
{
    public class Aufgabe76
    {
        public static void Start()
        {
            Gruppe gruppe = new Gruppe();

            gruppe.PersonenHinzufuegen(new Person("John", 19, 1.70, 60, "43249502"));
            gruppe.PersonenHinzufuegen(new Person("Maria", 35, 1.69, 70, "2347657"));
            gruppe.PersonenHinzufuegen(new Person("Julia", 21, 1.72, 59, "786832"));
            gruppe.PersonenHinzufuegen(new Person("Hans", 40, 1.98, 95, "96864563"));
            gruppe.PersonenHinzufuegen(new Person("Sofia", 17, 1.58, 52, "64578u678"));

            foreach (Person person in gruppe.Personen)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine($"\nKleinste Größe: {gruppe.GroesseMin():F2} m");
            Console.WriteLine($"Größte Größe: {gruppe.GroesseMax():F2} m");
            Console.WriteLine($"Durchschnittliche Größe: {gruppe.GroesseDurchschnitt():F2} m");

            Console.WriteLine($"\nJüngstes Alter: {gruppe.AlterMin()}");
            Console.WriteLine($"Ältestes Alter: {gruppe.AlterMax()}");
            Console.WriteLine($"Durchschnittliches Alter: {gruppe.AlterDurchschnitt():F0}");

            Console.WriteLine($"\nNiedrigstes Gewicht: {gruppe.GewichtMin():F1} kg");
            Console.WriteLine($"Höchstes Gewicht: {gruppe.GewichtMax():F1} kg");
            Console.WriteLine($"Durchschnittliches Gewicht: {gruppe.GewichtDurchschnitt():F1} kg");

            Console.WriteLine();
            foreach (Person person in gruppe.SortiereNachGroesse("ab"))
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            foreach (Person person in gruppe.SortiereNachAlter("ab"))
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            foreach (Person person in gruppe.SortiereNachGewicht("auf"))
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            foreach (Person person in gruppe.SortiereNachName("auf"))
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            Console.WriteLine(gruppe.FindePerson("J"));

            Console.WriteLine();
            foreach (Person person in gruppe.FindeAllePersonen("J"))
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            gruppe.PersonEntfernen("43249502");
            foreach (Person person in gruppe.Personen)
            {
                Console.WriteLine(person);
            }
        }
    }
}