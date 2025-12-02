namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe20
{
    public class Faktoral
    {
        public static void Start()
        {
            Console.WriteLine("Alle Zahlen von 1 bis 20 werden multipliziert");
            //Console.ReadLine() ?? string.Empty;

            ulong multiplicator = 1;

            ulong i = 1;
            while (i <= 20)
            {
                Console.WriteLine("Rechenweg: " + multiplicator + " * " + i + " = " + multiplicator * i);
                multiplicator = multiplicator * i;
                i++;
            }
            Console.WriteLine("Die Summe ist " + multiplicator);




        }
    }
}
