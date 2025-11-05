using System.Drawing;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe65
{
    public class Cars2()
    {
        public string Color;
        public int Kilometers;
        public string NumberPlate;
        public float Usage;

        public int Distanz;
        public void PrintCar()
        {
            System.Console.WriteLine($"Farbe: {Color}\nKilometerstand: {Kilometers}\nKennzeichen: {NumberPlate}\nVerbrauch: {Usage}");
        }
        
        public void Fahren(int Distanz)
        {
            System.Console.WriteLine($"Vorheriger Kilometerstand: {Kilometers}");
            System.Console.WriteLine($"Neuer Kilometerstabd: {Kilometers+Distanz}");
        }

    }
}
