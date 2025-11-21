namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe86
{
    public class Callcenter
    {
        public static void Start()
        {
            Queue<Anruf> anrufliste = new Queue<Anruf>();

            anrufliste.Enqueue(new Anruf("Laura Stern", "+43 54 657567", new DateTime(2025, 11, 18, 17, 09, 16)));
            anrufliste.Enqueue(new Anruf("Sofía Mendez", "+43 345 132407", new DateTime(2025, 11, 18, 17, 56, 54)));
            anrufliste.Enqueue(new Anruf("Claire Cottril", "+43 886 95822", new DateTime(2025, 11, 18, 18, 05, 32)));
            anrufliste.Enqueue(new Anruf("Fiona Apple", "+43 245 007854", new DateTime(2025, 11, 18, 18, 17, 56)));
            anrufliste.Enqueue(new Anruf("Karen Wheeler", "+43 68 355087", new DateTime(2025, 11, 18, 18, 50, 09)));
            anrufliste.Enqueue(new Anruf("Candice Crook", "+43 19 376876", new DateTime(2025, 11, 18, 19, 13, 24)));

            Console.WriteLine("Abgearbeitete Anrufe (in Reihenfolge)\n---------------------------------------");

            while (anrufliste.Count > 0)
            {
                Console.WriteLine(anrufliste.Dequeue());
            }
        }
    }
}