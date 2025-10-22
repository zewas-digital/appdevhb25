using System.Globalization;
using System.Runtime.InteropServices;

namespace Appdevhb25.JulianMatt.Aufgabe57
{
    public class Quadrieren
    {

        public static void Start57()
        {
            PartList();
        }

        public static void PartList()
        {
            using (StreamReader FileReader = new StreamReader(@"C:\Users\majn\Documents\Kurs\appdevhb25\src\JulianMatt\Aufgabe57\input.txt"))
            {

                string line;

                do
                {
                    line = FileReader.ReadLine();
                    int result = StringConverter(line);
                    int equals = result * result;
                    Console.WriteLine(result + " * " + result + " = " + equals);

                } while (line != null);

            }
        }
        
        public static int StringConverter(string line)
        {
            bool isInteger;
            int result;
            do
            {
                

                isInteger = int.TryParse(line, out result);

            } while (isInteger == false);

            return result;
            
        }


    }
}