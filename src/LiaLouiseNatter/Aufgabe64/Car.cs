using System.Drawing;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe64
{
    public class Car()
    {
        public string Color;
        public int Kilometers;
        public string NumberPlate;
        public float Usage;
        
        public void PrintCar()
        {
            System.Console.WriteLine($"Farbe: {Color}\nKilometerstand: {Kilometers}\nKennzeichen: {NumberPlate}\nVerbrauch: {Usage}");
        }

    }
}
