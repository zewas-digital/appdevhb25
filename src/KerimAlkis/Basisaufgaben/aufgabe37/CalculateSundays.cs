using System.Globalization;

namespace Appdevhb25.KerimAlkis.Aufgabe37
{
    public class CalculateSundays
    {
        public static void Start()
        {
            CultureInfo austrian = new CultureInfo("de-AT");
            DateTime datum = new DateTime();
            datum = DateTime.Today;


            while (datum.DayOfWeek != DayOfWeek.Sunday)
            {
                datum = datum.AddDays(1);
            }

            System.Console.WriteLine(datum.ToString("d"));
            datum = datum.AddDays(7);
            System.Console.WriteLine(datum.ToString("m"));
            datum = datum.AddDays(7);
            System.Console.WriteLine(datum.ToString("r"));


            
        }
    }
}