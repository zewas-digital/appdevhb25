namespace Appdevhb25.NoahHois.Aufgabe56
{
    public class ParticipantsList2
    {
        public static void Start()
        {
            string line;
            int i = 0;
            using (StreamReader stream = new StreamReader(@"C:\Users\NOHO\Documents\VSCode Projekte\appdevhb25\src\NoahHois\Woche4\Aufgabe56\InputNamen.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\NOHO\Documents\VSCode Projekte\appdevhb25\src\NoahHois\Woche4\Aufgabe56\Output.txt"))
                {
                    Console.WriteLine("Teilnehmer");
                    Console.WriteLine();
                    line = stream.ReadLine();

                    while (line != null)
                    {
                        writer.WriteLine(line);
                        Console.WriteLine(line);
                        line = stream.ReadLine();
                        i++;
                    }
                    writer.WriteLine();
                    writer.WriteLine(i + " Teilnehmer");
                }
            }
            
        }
    }
}