namespace Appdevhb25.MarcelSimma
{
    public class Arrays
    {
        public static void Start()
        {
            string teilnehmer0 = "Jona";
            string teilnehmer1 = "Kerim";
            string teilnehmer2 = "Julian";

            Console.WriteLine(teilnehmer0);
            Console.WriteLine(teilnehmer1);
            Console.WriteLine(teilnehmer2);

            string[] teilnehmer = new string[3];
            // Länge (length) = Anzahl der Elemente

            teilnehmer[0] = "Jona";
            teilnehmer[1] = "Kerim";
            teilnehmer[2] = "Julian";

            /*
            teilnehmer[0] -> 1. Element
            teilnehmer[1] -> 2. Element
            teilnehmer[2] -> 3. Element
            teilnehmer[3] -> Angabe der Länge vom Array bei der Initialisierung
            */

            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine(teilnehmer[i]);
            }
        }
    }
}