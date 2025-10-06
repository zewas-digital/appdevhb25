namespace Appdevhb25.KerimAlkis.Bonusaufgabe04
{
    public class HigherOrLower
    {
        public static void Start()
        {
            int range = 100;

            Random random = new Random();
            int gesuchteZahl = random.Next(0, range);
            Console.WriteLine("Higher Lower Spiel");
            Console.WriteLine($"Gib eine Zahl zwischen 0 und {range}");


            int versuche = 0;
            while (true)
            {
                versuche++;
                int zahl = Convert.ToInt32(Console.ReadLine());
                if (zahl == gesuchteZahl)
                {
                    Console.WriteLine($"Du hast mit {versuche} Versuchen gewonnen. Die gesuchte Zahl war {gesuchteZahl}.");
                    break;
                }
                else if (zahl < gesuchteZahl)
                {
                    Console.WriteLine("Higher");
                }
                else if (zahl > gesuchteZahl)
                {
                    Console.WriteLine("Lower");
                }
            }
            

        }
    }
}