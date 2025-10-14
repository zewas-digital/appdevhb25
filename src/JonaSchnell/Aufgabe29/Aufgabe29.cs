namespace Appdevhb25.JonaSchnell.Aufgabe29
{
    public class Aufgabe29
    {


        public static void Start29()
        {
            string[] teilnehmer = new string[10];
            teilnehmer[0] = "Jona";
            teilnehmer[1] = "Julian";
            teilnehmer[2] = "Lia";
            teilnehmer[3] = "Noah";
            teilnehmer[4] = "Katja";
            teilnehmer[5] = "Kerim";
            teilnehmer[6] = "Sabrina";
            teilnehmer[7] = "Sasha";
            teilnehmer[8] = "Selin";
            teilnehmer[9] = "Sheila";
            int j = 1;
            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine(j + ". " + teilnehmer[i]);
                j++;
            }
        }
    }
}