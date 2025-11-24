using System;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe64
{
    public class CarCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!); //! = possible null reference ignorieren

            Car car = new Car();
            car.PrintCar();
        }
    }
}
