namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe32
{
    public class Ziffernsumme
    {
        public static void Start()
        {
            Console.WriteLine("Schreibe eine Zahl hin");
            int number = Convert.ToInt32(Console.ReadLine());
            int numberSum = 0;
            while (number > 0)
            {
                numberSum += number % 10;
                number /= 10;
            }
            Console.WriteLine("Die Ziffernsumme ist: " + numberSum);
            
        }
    }
}