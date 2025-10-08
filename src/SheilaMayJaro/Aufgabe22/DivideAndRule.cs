using System; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe22
{
    public class DivideAndRule
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 22)");
            PrintDivideAndRule(20); 
            //Der Grund des Unterschiedes ist, dass das Ergebnis mal als ganze Zahl und mal als Gleitkommazahl angegeben wird.
        }
        public static void PrintDivideAndRule(double length)
        {
            int quotient;
            double quotient2;
            int number = 5;
            double floatingNumber = 5.0;
            for (int i = 0; i <= length; i++)
            {
                quotient = i / number;
                quotient2 = i / floatingNumber;
                Console.WriteLine($"{i}/{number} = {quotient}"); 
                Console.WriteLine($"{i}/{floatingNumber} = {quotient2}"); 
            }
            
        }
    }
}