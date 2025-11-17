namespace Appdevhb25.MarcelSimma.Week07
{
    public class QueueIntro
    {
        public static void Start()
        {
            Queue<string> teilnehmerliste = new Queue<string>();

            teilnehmerliste.Enqueue("Sabrina");
            teilnehmerliste.Enqueue("Katja");
            teilnehmerliste.Enqueue("Lia");

            System.Console.WriteLine(teilnehmerliste.Peek());

            string pruefungVonSabrina = teilnehmerliste.Dequeue();

            bool enthalten = teilnehmerliste.Contains("Sabrina");
            System.Console.WriteLine(enthalten);

            System.Console.WriteLine(pruefungVonSabrina);

            teilnehmerliste.Enqueue(pruefungVonSabrina);
            enthalten = teilnehmerliste.Contains("Sabrina");
            System.Console.WriteLine(enthalten);

            foreach (string teilnehmer in teilnehmerliste)
            {
                System.Console.WriteLine(teilnehmer);
            }

            System.Console.WriteLine("-------------------");

            teilnehmerliste.Enqueue("Sabrina");
            teilnehmerliste.Enqueue("Katja");
            teilnehmerliste.Enqueue("Lia");

            for (int i = 0; i < teilnehmerliste.Count; i++)
            {
                System.Console.WriteLine(teilnehmerliste.Dequeue());
            }
            
        }
    }
}

