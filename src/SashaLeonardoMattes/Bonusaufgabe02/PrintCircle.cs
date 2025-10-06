using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq.Expressions;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe02
{

    public class PrintCircle
    {

        public static void StartPrintCircle()
        {
            Console.WriteLine("----------Bonusaufgabe 02----------");
            int size;

            Console.WriteLine("Gib den Radius ein:");
            size = Helper.checkUserInputInteger();
            Console.WriteLine("Gib eine Zeichen ein:");
            char symbol = Helper.checkUserInputChar();

            WriteCircle(size, symbol);
        }

        static void WriteCircle(int radius, char symbol)
        {
            double x; //AK = horizontale
            double y; //GK = vertikale
            double h; //hypotenuse
            
            //bei jedem Punkt prüfen ob dieser = x (inkl tolranz);
            for (int i = radius*-1; i < radius + 1; i++)
            {
                y = i;
                for (int j = radius * -1; j < radius + 1; j++)
                {

                    x = j * -1;
                    h = Math.Round(Math.Sqrt(x * x + y * y));
                    double upperTolerance = h + 0.5;
                    double lowerTolerance = h - 0.5;

                    if (radius < upperTolerance && radius > lowerTolerance)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine("");
            }


        }

       

    }
}
