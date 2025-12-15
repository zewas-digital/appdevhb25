using System;
using Appdevhb25.KatjaHaemmerli.Aufgabe88UML;
namespace Appdevhb25.KatjaHaemmerli.Aufgab88UML
{
    public  class AufgabeInventarliste
    {
        public static void Start()
        {
            Car car = new Car("schwarz", "1234");
            Motorcycle1 motorrad = new Motorcycle1("Yamaha", "schwarz", 12.12, "5678");

            List<IGegenstand> gegenstandliste = new List<IGegenstand>();
            gegenstandliste.Add(car);
            gegenstandliste.Add(motorrad);

            foreach(List<IGegenstand> item in gegenstandliste)
            {
                System.Console.WriteLine(gegenstandliste);
            }
        }
       
    }
}