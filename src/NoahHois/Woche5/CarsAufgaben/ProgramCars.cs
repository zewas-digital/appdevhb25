using System;
using Appdevhb25.NoahHois.Aufgabe64;

namespace Appdevhb25.NoahHois.Aufgabe64
{
    public class ProgramCar
    {
        public static void Start()
        {
            Car cars = new Car();
            cars.Color = "matt schwarz";
            cars.Mileage = 5_193;
            cars.Mark = "FKGH7361";
            cars.Consumption = 15;
            cars.PrintCar();

            cars.Fahren(45);
        }
    }
}