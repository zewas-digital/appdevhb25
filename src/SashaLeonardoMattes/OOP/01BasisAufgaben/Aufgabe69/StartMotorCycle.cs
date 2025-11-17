using System;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe69
{
    public class MotorCycleCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            MotorCycle[] motorCycles = new MotorCycle[2];
            
            MotorCycle m1 = new MotorCycle(100, "blau", 1000, "abc123");
            motorCycles[0] = m1;

            MotorCycle m2 = new MotorCycle(-75, -7, "grün", 500, "defg456");
            motorCycles[1] = m2;

            foreach (var motorCycle in motorCycles)
            {
                System.Console.WriteLine($"Kilometerstand: {motorCycle.Mileage}\n PS: {motorCycle.HorsePower}\n Farbe: {motorCycle.Color}\n Preis: {motorCycle.Price}\n Kennzeichen: {motorCycle.LicensePlate}");
                System.Console.WriteLine("----------------------------------");
            }
            
            System.Console.WriteLine("Verkaufte Motorräder: " + MotorCycle.amountProduced + " Average Revenue: " + MotorCycle.GetAverageRevenue());
        }
    }
}
