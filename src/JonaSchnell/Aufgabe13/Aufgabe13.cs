namespace Appdevhb25.JonaSchnell.Aufgabe13
{
    public class Aufgabe13

    {

        public static void Start13()
        {
            Console.WriteLine("Das sind alle Zahlen von 20-50 addiert.");
            int numbers = 20;
            int a1 = 20;
            while (a1 < 50)
            {
                a1 = a1 + 1;
                numbers = numbers + a1;
            }
            Console.WriteLine(numbers);
        }
    }
}