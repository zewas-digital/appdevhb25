namespace Appdevhb25.KerimAlkis.Bonusaufgabe07
{
    public class Faktorial
    {
        public static void Start()
        {
            FaktorialBerechnen();
            //System.Console.WriteLine($"Das Fakorial von 20 ist: {FaktorialBerechnen()}");
        }
        public static void FaktorialBerechnen()
        {
            long sum = 1;
            int counter = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum *= i;
                counter++;
                //System.Console.WriteLine($"{i}! = {sum}");
                System.Console.WriteLine("{0}! = {1,30}", i, sum);
            }
        }
    }
}