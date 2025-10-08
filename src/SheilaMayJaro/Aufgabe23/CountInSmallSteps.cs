using System; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe23
{
    public class CountInSmallSteps
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 23)");
            PrintCountInSmallSteps(10); 

        }
        public static void PrintCountInSmallSteps(int length)
        {
            for (double i = 0.0d; i < length; i+=0.1d)
            {
                Console.WriteLine(i.ToString("F"));
                Console.WriteLine(i.ToString("F2")); 
                Console.WriteLine($"Result 1 digit = {i}"); 
            }
        }
    }
}