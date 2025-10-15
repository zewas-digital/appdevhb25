namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe29
{
    public class Teilnehmer2
    {
        public static void Start()
        {
            string[] teilnehmer = new string[11];

            teilnehmer[0] = "Jona";
            teilnehmer[1] = "Kerim";
            teilnehmer[2] = "Julian";
            teilnehmer[3] = "Katja";
            teilnehmer[4] = "Laura";
            teilnehmer[5] = "Lia";
            teilnehmer[6] = "Noah";
            teilnehmer[7] = "Sabrina";
            teilnehmer[8] = "Sasha";
            teilnehmer[9] = "Selin";
            teilnehmer[10] = "Sheila";


            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + teilnehmer[i]);

            }
            Console.WriteLine("Anzahl der Teilnehmer: " + teilnehmer.Length);
        }
    }
}