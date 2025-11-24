using System;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe65
{
    public class Car2Creator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            Car2 car = new Car2();

            car.PrintCar();
            
            car.Drive(10);
            car.PrintCar();
        }
    }
}
