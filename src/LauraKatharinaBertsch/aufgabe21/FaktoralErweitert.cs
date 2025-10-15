namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe21
{
    public class FaktoralErweitert
    {
        public static void Start()
        {
            Console.WriteLine("Alle Zahlen von 1 bis 20 werden multipliziert");
            Console.ReadLine();

            ulong multiplicator = 1;

            ulong i = 1;
            while (i <= 20)
            {
                Console.WriteLine($"{i}! = {multiplicator * i}");
                multiplicator = multiplicator * i;
                i++;
            }
            



        }
    }
}
