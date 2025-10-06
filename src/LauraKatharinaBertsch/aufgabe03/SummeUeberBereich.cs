namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe03
{
    public class SummeUeberBereich
    {
        public static void Start()
        {
            int sum = 0;
            for (int i = 8; i <= 10; i++)
            {
                sum = sum + i;

            }
            Console.WriteLine("Intervallstart: 8");
            Console.WriteLine("Intervallende: 10");
            Console.WriteLine("Summe über Intervall: " + sum);

        }
    }
}
