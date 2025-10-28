using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe58
{
    public class PrintFileFormatted
    {

        public static void Start58()
        {
            PartList();
        }

        public static void PartList()
        {
            using (StreamReader FileReader = new StreamReader(@"C:\Users\majn\Documents\Kurs\appdevhb25\src\JulianMatt\Aufgabe56\input.txt"))
            {


                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                    }
                    System.Console.WriteLine("--------------------------------");
                }
            }
        }


    }
}