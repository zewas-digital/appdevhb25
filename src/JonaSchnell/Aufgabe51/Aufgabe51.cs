using System.ComponentModel;
using System.Globalization;

namespace Appdevhb25.JonaSchnell.Aufgabe51
{
    public class Aufgabe51
    {
        public static void MyBirthday()
        {
            Console.WriteLine("Wann bist du geboren? (z.B. 20.03.2010)");

            string? input = Console.ReadLine();

            DateTime date;

            CultureInfo austrian = new CultureInfo("de-AT");

            DateTime.TryParse(input, new CultureInfo("de-AT"), out date);
            
            DateTime result = DateTime.ParseExact(input, "dd.MM.yyyy", new CultureInfo("de-AT"));

            Console.WriteLine("Mein Geb. ist am " + result.ToString("dddd, dd.MM.yyyy"));
        }
    }
}