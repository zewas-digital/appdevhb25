namespace Appdevhb25.JonaSchnell.Aufgabe30
{
    public class Aufgabe30
    {


        public static void Start30()
        {
            Console.WriteLine("Wieviele Teilnehmer sind es dieses Jahr?");
            int insgesammt = Convert.ToInt32(Console.ReadLine());
            string[] teilnehmer = new string[insgesammt];
            Console.WriteLine("Wie heißt der Teilnehmer?");
            string? teilnehmer0 = Console.ReadLine();;
            
            int j = 1;
            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine(j + ". " + teilnehmer[i]);
                j++;
            }
        }
    }
}