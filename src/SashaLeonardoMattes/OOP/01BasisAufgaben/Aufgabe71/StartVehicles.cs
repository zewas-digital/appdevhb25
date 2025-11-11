using System;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe71
{
    public class VehicleCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            Vehicles[] vehicles = new Vehicles[4];

            Car c1 = new Car("blauC", "abc123C", 10000, 5);
            Car c2 = new Car("rotC", "cde123C", 20000, 3);

            MotorCycle m1 = new MotorCycle(50, "blauM", 5000, "abc123M", 10000);
            MotorCycle m2 = new MotorCycle(50, "rotM", 5000, "cde123M", 20000);

            vehicles[0] = c1;
            vehicles[1] = c2;
            vehicles[2] = m1;
            vehicles[3] = m2;
            
            foreach (Vehicles vehicle in vehicles)
            {
                vehicle.PrintVehicle();
            }
        }
    }
}
