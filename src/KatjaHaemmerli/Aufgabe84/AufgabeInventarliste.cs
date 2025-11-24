using System;
using Appdevhb25.KatjaHaemmerli.Aufgab84;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe84
{
    public  class AufgabeInventarliste
    {
        public static void Start()
        {
            Car car = new Car("schwarz", "1234");
            Motorrad motorrad = new Motorrad("Yamaha", "schwarz", "5678");

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