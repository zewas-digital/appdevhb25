using System; 
namespace Appdevhb25.SheilaMayJaro.Aufgabe21
{
    public class FactorialExtended
    {
        public static void Start()
        {
            System.Console.WriteLine("Bonusaufgabe 21)");
            /*
            Erweitere deinen Ausdruck damit, dass die Werte rechtsbündig ausgedruckt werden. 
            Verwende Console.WriteLine mit einem einfachen String Format
            */
            int length = 21; //inkl. 20

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i,2}! = {PrintFactorial(i), 20}"); 
            }


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