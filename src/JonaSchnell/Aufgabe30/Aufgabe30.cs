namespace Appdevhb25.JonaSchnell.Aufgabe30
{
    public class Aufgabe30
    {


        public static void Start30()
        {
            Console.WriteLine("Wieviele Teilnehmer sind es dieses Jahr?");
            int insgesammt = Convert.ToInt32(Console.ReadLine());
            string[] teilnehmer = new string[insgesammt];
            Console.WriteLine("Wie heißt der erste Teilnehmer?");
            string? teilnehmer0 = Console.ReadLine();
            teilnehmer[0] = teilnehmer0;
            Console.WriteLine("Wie heißt der nächste Teilnehmer?");
            string? teilnehmer1 = Console.ReadLine();
            teilnehmer[1] = teilnehmer1;
            Console.WriteLine("Wie heißt der nächste Teilnehmer?");
            string? teilnehmer2 = Console.ReadLine();
            teilnehmer[2] = teilnehmer2;
            Console.WriteLine("Wie heißt der nächste Teilnehmer?");
            string? teilnehmer3 = Console.ReadLine();
            teilnehmer[3] = teilnehmer3;
            Console.WriteLine("Wie heißt der nächste Teilnehmer?");
            string? teilnehmer4 = Console.ReadLine();
            teilnehmer[4] = teilnehmer4;
            Console.WriteLine("Wie heißt der nächste Teilnehmer?");
            string? teilnehmer5 = Console.ReadLine();
            teilnehmer[5] = teilnehmer5;
            Console.WriteLine("Wie heißt der nächste Teilnehmer?");
            string? teilnehmer6 = Console.ReadLine();
            teilnehmer[6] = teilnehmer6;
            Console.WriteLine("Wie heißt der nächste Teilnehmer?");
            string? teilnehmer7 = Console.ReadLine();
            teilnehmer[7] = teilnehmer7;
            Console.WriteLine("Wie heißt der nächste Teilnehmer?");
            string? teilnehmer8 = Console.ReadLine();
            teilnehmer[8] = teilnehmer8;
            Console.WriteLine("Wie heißt der letzte Teilnehmer?");
            string? teilnehmer9 = Console.ReadLine();
            teilnehmer[9] = teilnehmer9;
            
            int j = 1;
            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine(j + ". " + teilnehmer[i]);
                j++;
            }
        }
    }
}