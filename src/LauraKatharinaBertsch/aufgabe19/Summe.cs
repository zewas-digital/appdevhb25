namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe19
{
    public class Summe
    {
        public static void Start()
        {
            Console.WriteLine("Alle Zahlen von 20 bis 50 werden addiert");
           // Console.ReadLine() ?? string.Empty;
            int sum = 20;
            int i = 21;

            while (i <= 50)
            {

                Console.WriteLine("Rechenweg: " + sum + "+" + i + "=" + (sum + i));
                sum = sum + i;
                i++;
            }
            Console.WriteLine("Die Summe ist " + sum);





        }
    }
}
