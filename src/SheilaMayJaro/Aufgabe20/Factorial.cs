using System; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe20
{
    public class Factorial
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 20)");
            Console.Write(PrintFactorial(20)); 
        }
        public static long PrintFactorial(int length)
        {
            long product = 1;

            for (int i = 2; i <= length; i++)
            {
                product *= i;
            }
            return product; 
        }
    }
}
