namespace Appdevhb25.JonaSchnell.Aufgabe05
{
    public class Aufgabe06
    {

        public static void Start05()
        {
            Console.WriteLine("Wieviele Zeichen soll ich ausgeben?");
            int Anzahl = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= Anzahl; i++)
            {
                Console.Write("x");
            }
        }
    }
}