using System.ComponentModel;

namespace Appdevhb25.JonaSchnell.Aufgabe96
{
    public static class Main
    {
        public static void Start()
        {
            System.Console.WriteLine("Hallo von was wollen sie den Umfang und die Fläche sehen? Kreis, Rechteck, Dreieck?");
            string input = Console.ReadLine();

            if (input == "Kreis")
            {
                System.Console.WriteLine("Wie breit soll der Kreis sein?");
                double diameter = Convert.ToInt32(Console.ReadLine());
                Circle c = new Circle("Mein Kreis", diameter);

                Console.WriteLine("Umfang: " + c.CalculateCircumference());
                Console.WriteLine("Flächeninhalt: " + c.CalculateArea());
            }
            else if (input == "Rechteck")
            {
                System.Console.WriteLine("Wie lang soll das Rechteck sein?");
                double width = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Wie breit soll das Rechteck sein?");
                double height = Convert.ToInt32(Console.ReadLine());
                Rectangle r = new Rectangle("Mein Rechteck", height, width);

                Console.WriteLine("Umfang: " + r.CalculateCircumference());
                Console.WriteLine("Flächeninhalt: " + r.CalculateArea());
            }
            else if (input == "Dreieck")
            {
                System.Console.WriteLine("Wie lange soll eine seite des Dreiecks sein?");
                int sideLength = Convert.ToInt32(Console.ReadLine());
                Triangle t = new Triangle("Mein Gleichsetiges Dreieck", sideLength);

                Console.WriteLine("Umfang: " + t.CalculateCircumference());
                Console.WriteLine("Flächeninhalt: " + t.CalculateArea());
            }
            else
            {
                System.Console.WriteLine("Pi = " + Math.PI);
            }
        }
    }
}