using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe70
{
    public class Output
    {
        public static void Start70()
        {
            Fahrzeug fahrzeug1 = new Fahrzeug("rot", "B 983 T", 43243);
            fahrzeug1.PrintDatePaper();
        
            Motorrad motorrad1 = new Motorrad("schwarz", "DO 324 AB", 3242, 150, 15000);
            motorrad1.PrintDatePaper();
            Double Revenue = Motorrad.CalculateTheMoneyMadePerVehicle();
            System.Console.WriteLine("Es wurde "+Revenue+" gemacht");

            Auto auto1 = new Auto("lila", "I 676 AX", 32, 6);
            auto1.PrintDatePaper();

        }
    }
}