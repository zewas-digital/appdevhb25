using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe84
{
    public class Inventarliste
    {
        public static void Start()
        {
            List<IGegenstand> inventarliste = new List<IGegenstand>();

            inventarliste.Add(new Auto(5)); // Class aus anderer Übung 71
            inventarliste.Add(new Auto(3));
            inventarliste.Add(new Fotoapparat(23.3)); // Class aus anderer Übung v73
            inventarliste.Add(new Fotoapparat(34.2));
            inventarliste.Add(new Motorrad("Yamaha"));


            foreach(IGegenstand element in inventarliste)
            {
                System.Console.WriteLine(element.PrintGegenstand());
            }
        }
    }
}