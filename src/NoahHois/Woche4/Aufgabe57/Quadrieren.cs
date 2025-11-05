using System.ComponentModel;

namespace Appdevhb25.NoahHois.Aufgabe57
{
    public class Quadrieren
    {
        public static void Start()
        {
            using (StreamReader stream = new StreamReader(@"C:\Users\NOHO\Documents\VSCode Projekte\appdevhb25\src\NoahHois\Woche4\Aufgabe57\Input.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\NOHO\Documents\VSCode Projekte\appdevhb25\src\NoahHois\Woche4\Aufgabe57\Output.txt"))
                {
                    string input = stream.ReadLine();
                    while (input != null)
                    {
                        int number = Convert.ToInt32(input);
                        int sumOfNumbers = number * number;
                        writer.WriteLine($"{number} * {number} = {sumOfNumbers}");
                        input = stream.ReadLine();
                    }
                }
            }

        }
    }
}