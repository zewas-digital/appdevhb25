using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe55
{
    public class ParticipantsList
    {

        public static void Start55()
        {
            PartList();
        }

        public static void PartList()
        {
            using (StreamReader FileReader = new StreamReader(@"C:\Users\majn\Documents\Kurs\appdevhb25\src\JulianMatt\Aufgabe55\input.txt"))
            {

                FileReader.ReadLine();
                int number = 1;
                string endCondition;
                string Line;
                do
                {
                    Line = FileReader.ReadLine();
                    System.Console.WriteLine(number+"."+Line);
                    number += 1;
                } while ( Line != null);
              
            }
        }


    }
}