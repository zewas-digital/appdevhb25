using System.Runtime.CompilerServices;
using Appdevhb25.KerimAlkis.Aufgabe00;

namespace Appdevhb25.KerimAlkis.Bonusaufgabe02
{
    public class PrintCircle
    {
        public static void Start()
        {
            double radius = 20;
            double durchmesser = radius * 2;
            double toleranz = 0.5;


            for (double i = 0; i <= durchmesser; i++)
            {
                double testZeile;

                if (i < radius)
                {
                    testZeile = radius - i;
                }
                else if (i == radius)
                {
                    testZeile = 0;
                }
                else { testZeile = i - radius; }

                for (double punkt = 0; punkt <= durchmesser; punkt++)
                {

                    double b = Math.Sqrt((radius * radius) - (testZeile * testZeile));
                    double rechts = radius + b;
                    double links = radius - b;

                    if ((punkt >= links - toleranz && punkt <= links + toleranz) || (punkt >= rechts - toleranz && punkt <= rechts + toleranz))
                    {
                        Console.Write("X");
                    }
                    else { Console.Write(" "); }
                }
                Console.WriteLine();
            }

            System.Console.WriteLine();

            for (double i = 0; i <= durchmesser; i++)
            {
                double testZeile;

                if (i < radius)
                {
                    testZeile = radius - i;
                }
                else if (i == radius)
                {
                    testZeile = 0;
                }
                else { testZeile = i - radius; }

                for (double punkt = 0; punkt <= durchmesser; punkt++)
                {
                    
                    double b = Math.Sqrt((radius * radius) - (testZeile * testZeile));
                    double rechts = radius + b;
                    double links = radius - b;

                    if (punkt >= links - toleranz && punkt <= rechts + toleranz)
                    {
                        Console.Write("X");
                    }
                    else { Console.Write(" "); }
                }
                Console.WriteLine();
            }
            

        }
    }
}