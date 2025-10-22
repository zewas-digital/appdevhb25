using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe56
{
    public class ParticipantsListTwo
    {

        public static void Start56()
        {
            PartList();
        }

        public static void PartList()
        {
            using (StreamReader FileReader = new StreamReader(@"C:\Users\majn\Documents\Kurs\appdevhb25\src\JulianMatt\Aufgabe56\input.txt"))
            {

                string start = FileReader.ReadLine();
                Console.WriteLine(start);
                System.Console.WriteLine();
                int number = 1;
                string endCondition;
                string Line;
                do
                {
                    FileReader.ReadLine();
                    Line = FileReader.ReadLine();
                    if (Line != null)
                    {
                        System.Console.WriteLine(Line);
                        number++;
                    }
                } while (Line != null);
                System.Console.WriteLine("Es sind " + number + " Teilnehmer");

            }
        }


    }
}