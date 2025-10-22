namespace Appdevhb25.NoahHois.Aufgabe55
{
    public class ParticipantsList
    {
        public static void Start()
        {
            using (StreamReader stream = new StreamReader(@"C:\Users\NOHO\Documents\VSCode Projekte\appdevhb25\src\NoahHois\Woche4\InputNamen.txt"))
            {
                Console.WriteLine("Teilnehmer");
                Console.WriteLine();
                string line = stream.ReadLine();
                int i = 1;
                while (line != null)
                {
                    Console.WriteLine(i + ". " + line);
                    line = stream.ReadLine();
                    i++;
                }
            }
        }
    }
}