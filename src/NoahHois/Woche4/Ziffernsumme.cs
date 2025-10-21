using System.Linq.Expressions;

namespace Appdevhb25.NoahHois.BonusAufgabe5
{
    public class Ziffernsumme
    {
        public static void DigitSum()
        {
            Random random = new Random();

            int number = random.Next();
            Console.WriteLine(number);

            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine();
            Console.WriteLine("Die Ziffernsumme beträgt: " + sum);
        }

        public static void DigitSumArray()
        {
            Random random = new Random();

            int number = random.Next();
            Console.WriteLine(number);

            int sum = 0;

            string numberString = number.ToString();

            foreach (char elem in numberString)
            {
                sum += ((int)elem - 48);
            }
            Console.WriteLine();
            Console.WriteLine("Die Ziffernsumme beträgt: " + sum);
        }
    }
}