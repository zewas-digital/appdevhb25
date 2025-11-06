using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe69
{
    public class MotorradA69
    {
        public static void Start69()
        {
            Motorrad[] Bike = new Motorrad[2];

            Bike[0] = new Motorrad("Rot", 15000, "AB", 123, 100);
            Bike[1] = new Motorrad(5000, "CD", 567, 150);

            Motorrad.RevenueCounter();
        }
    }
}