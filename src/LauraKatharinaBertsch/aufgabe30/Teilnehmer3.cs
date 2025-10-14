namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe30
{
    public class Teilnehmer3
    {
        public static void Start()
        {
            string[] teilnehmer = new string[11];


            for (int i = 0; i < teilnehmer.Length; i++)
            {
                teilnehmer[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Teilnehmerliste:");
            for (int j = 0; j < teilnehmer.Length; j++)
            {
                Console.WriteLine(j + 1 + ". " + teilnehmer[j]);
            }
            Console.WriteLine("Anzahl der Teilnehmer: " + teilnehmer.Length);




        }
    }
}