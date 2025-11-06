namespace Appdevhb25.NoahHois.Aufgabe58
{
    public class PrintFileFormatted
    {
        // ─ │ ┌ ┐ └ ┘ ├ ┤ ┬ ┴ ┼
        public static void Start()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\NOHO\Documents\VSCode Projekte\appdevhb25\src\NoahHois\Woche4\Aufgabe58\Input.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\NOHO\Documents\VSCode Projekte\appdevhb25\src\NoahHois\Woche4\Aufgabe58\Output.txt"))
                {
                    string? line = reader.ReadLine();
                    string[] parts = line.Split(' ');
                    writer.WriteLine($"{string.Format("{0, -15}", parts[0])}│ {string.Format("{0, -10}", parts[1])}│ {string.Format("{0, 7}", parts[2])}");
                    line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine($"{new string('─', 15)}┼{new string('─', 11)}┼{new string('─', 8)}");
                        parts = line.Split(' ');
                        double height = Convert.ToDouble(parts[1].Replace('.', ','));
                        writer.WriteLine($"{string.Format("{0, -15}", parts[0])}│ {string.Format("{0, -10:0.00}", height)}│ {string.Format("{0, 7}", parts[2])}");
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}