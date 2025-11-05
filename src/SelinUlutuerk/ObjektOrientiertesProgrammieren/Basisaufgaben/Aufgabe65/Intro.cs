using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe65
{
    public class Intro
    {
        public static void Start()
        {
            Car[] cars = new Car[2];

            cars[0] = new Car();
            cars[0].Farbe = "rot";
            cars[0].Kilometerstand = 56_000;
            cars[0].Kennzeichen = "DO 234 ZH";
            cars[0].Verbrauch = 3.5;

            cars[1] = new Car();
            cars[1].Farbe = "schwarz";
            cars[1].Kilometerstand = 220_000;
            cars[1].Kennzeichen = "B 789 LL";
            cars[1].Verbrauch = 5.5;

            cars[0].Fahren(150);

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].PrintCar();
                System.Console.WriteLine();
            }   
        }
    }
}