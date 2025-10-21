using System; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe17
{
    public class CalculationOfPiLeibnizSeries
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 17)");
            double pi = 0;
            double length = 500_000; 
            for (int i = 1; i < length; i += 4)
            {
                //π=(4/1)-(4/3)+(4/5)-(4/7)+(4/9)-(4/11)+(4/13)-(4/15) 
                pi += 4.0 / i - 4.0 / (i + 2); 
            }
            System.Console.WriteLine(pi);
        }
    }
}