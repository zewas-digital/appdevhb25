using System;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe47
{

    public class Square
    {

        public static void StartSquare()
        {
            string? line;
            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\sasha.mattes\Documents\Zewas\appdevhb25\src\SashaLeonardoMattes\Aufgabe47\output.txt"))
            {
                using (StreamReader streamReader = new StreamReader(@"C:\Users\sasha.mattes\Documents\Zewas\appdevhb25\src\SashaLeonardoMattes\Aufgabe47\input.txt"))
                {

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        streamWriter.WriteLine(line + " * " + line + " = " + Convert.ToInt32(line) * Convert.ToInt32(line));
                    }
                }
            }

        }


    }
}
