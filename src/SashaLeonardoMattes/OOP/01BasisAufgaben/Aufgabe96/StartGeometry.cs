using System;
using System.Security.Cryptography;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe96
{
    public class StartGeometry
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            Circle c1 = new Circle("toller Kreis", 4);
            Circle c2 = new Circle("tollerer Kreis", 8);
            Triangle t1 = new Triangle("tolles Dreieck", 4);
            Rectangle r1 = new Rectangle("tolles Rechteck", 2, 2);

            List<Shape> myShapes = [c1, c2, t1, r1];

            foreach (Shape shape in myShapes)
            {
                System.Console.WriteLine(shape.ToString());
            }

            r1.Scale(2);
            System.Console.WriteLine();
            System.Console.WriteLine("Rechteck nach Scale:");
            System.Console.WriteLine(r1.ToString());

            System.Console.WriteLine("\nAnzahl Kreise: " + Circle.AmountProduced);
            System.Console.WriteLine("Anzahl Dreiecke: " + Triangle.AmountProduced);
            System.Console.WriteLine("Anzahl Rechtecke: " + Rectangle.AmountProduced);


        }
    
    }
}
