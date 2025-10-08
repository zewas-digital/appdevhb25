namespace Appdevhb25.JonaSchnell.Aufgabe20
{
    public class Aufgabe20

    {

        public static void Start20()
        {
            Console.WriteLine("Das sind die Zahlen von 1-20 Faktorial.");
            long numbers = 1;
            long a1 = 0;
            int i = 1;
            while (a1 < 20)
            {
                a1 = a1 + 1;
                numbers = numbers * a1;
                Console.WriteLine(i + "! " + "=" + numbers);
                i++;
            }
        }
    }
}
