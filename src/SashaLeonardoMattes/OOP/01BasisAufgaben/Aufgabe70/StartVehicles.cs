using System;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe70
{
    public class VehicleCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            Vehicles v1 = new Vehicles("blauV", "abc123V", 10000);
            Vehicles v2 = new Vehicles("rotV", "cde123V", 20000);

            Car c1 = new Car("blauC", "abc123C", 10000, 5);
            Car c2 = new Car("rotC", "cde123C", 20000, 3);

            MotorCycle m1 = new MotorCycle(50, "blauM", 5000, "abc123M", 10000);
            MotorCycle m2 = new MotorCycle(50, "rotM", 5000, "cde123M", 20000);

            System.Console.WriteLine("Vehicle 1:");
            v1.PrintVehicle();
            System.Console.WriteLine("----------Vehicle 2------------------");
            v2.PrintVehicle();

                        
            System.Console.WriteLine("----------Car 1------------------");
            c1.PrintVehicle();
            c1.Drive(1000);
            System.Console.WriteLine("----------Car 1 nach 1000km Fahren------------------");
            c1.PrintVehicle();
            System.Console.WriteLine("----------------------------");
            Car.PrintAmountProducedCars();

            System.Console.WriteLine("--------------Motorcycle 1--------------");
            m1.PrintVehicle();
            System.Console.WriteLine("-------------Durchschnitlicher Umsatz----------------");
            MotorCycle.GetAverageRevenue();

            System.Console.WriteLine("Anzahl verkaufte Fahrzeuge " + Vehicles.amountProducedVehicles);


        }
    }
}
