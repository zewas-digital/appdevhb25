using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Appdevhb25.KatjaHaemmerli.Aufgabe66;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe75
{
    public class AufgabePersonInGruppe
    {
        public static void Start()
        {
            Gruppe erwachsene = new Gruppe();
            Gruppe teenager = new Gruppe();
            Gruppe kinder = new Gruppe();

            Person person1 = new Person("Anna", 15, 1.70, 65);
            Person person2 = new Person("Ben", 35, 1.88, 85);
            Person person3 = new Person("Carina", 5, 1.10, 20);
            Person person4 = new Person("Daniel", 65, 1.55, 80);
            Person person5 = new Person("Emil", 17, 1.50, 55);
            Person person6 = new Person("Flora", 7, 1.17, 25);
            Person person7 = new Person("Gerben", 45, 1.65,70);
            Person person8 = new Person("Hans", 16, 1.63, 75);
            Person person9 = new Person("Irene", 9, 1.20, 35);

            erwachsene.PersonHinzufuegen(person2);
            erwachsene.PersonHinzufuegen(person4);
            erwachsene.PersonHinzufuegen(person7);

            kinder.PersonHinzufuegen(person3);
            kinder.PersonHinzufuegen(person6);
            kinder.PersonHinzufuegen(person9);

            teenager.PersonHinzufuegen(person1);
            teenager.PersonHinzufuegen(person5);
            teenager.PersonHinzufuegen(person8);

            List<Gruppe> groups = new List<Gruppe>
            {
                erwachsene,
                kinder,
                teenager
            };
            foreach (Gruppe element in groups)
            {
                System.Console.WriteLine($"Das grösste Gewicht beträgt: {element.GroessterWertErmitterln("Gewicht")}");
                System.Console.WriteLine($"Das kleinste Gewicht beträgt: {element.KleinsterWertErmitterln("Gewicht")}");
                System.Console.WriteLine($"Das Durchschnittsgewicht Gewicht beträgt: {element.DurschnittswertErmitteln("Durchschnittsgewicht")}");
                System.Console.WriteLine($"Das älteste Alter beträgt: {element.GroessterWertErmitterln("Alter")}");
                System.Console.WriteLine($"Das jüngste Alter beträgt: {element.KleinsterWertErmitterln("Alter")}");
                System.Console.WriteLine($"Das Durchschnittsalter beträgt: {element.DurschnittswertErmitteln("Alter")}");
                System.Console.WriteLine($"Die grösste Grösse beträgt: {element.GroessterWertErmitterln("Grösse")}");
                System.Console.WriteLine($"Die kleinste Grösse beträgt: {element.KleinsterWertErmitterln("Grösse")}");
                System.Console.WriteLine($"Die Durchschnittsgrösse beträgt: {element.DurschnittswertErmitteln("Grösse")}");
            }            
        } 
        
    }

}
