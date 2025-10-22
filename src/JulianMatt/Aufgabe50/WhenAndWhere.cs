using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe50
{
    public class WhenAndWhere
    {

        public static void Start50()
        {
            TimeOutput();
        }

        public static void TimeOutput()
        {
            DateTime moment = DateTime.Now;

            Console.WriteLine(moment.ToString("d MMM yyyy"));
            System.Console.WriteLine(moment.ToString("h:mm"));
            System.Console.WriteLine(moment.ToString());
            DateTimeOffset dto = new DateTimeOffset(moment);
            Console.WriteLine(dto.ToString("dd MMM HH:mm zzz"));
            System.Console.WriteLine(moment.ToString("ss.ff"));
        }


    }
}