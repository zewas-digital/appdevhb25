using System.Runtime.Intrinsics.X86;

namespace Appdevhb25.JonaSchnell.Aufgabe50
{
    public class Aufgabe50
    {
        public static void DateAndTime()
        {
            DateTime datum = DateTime.Now;
            System.Console.WriteLine("Heute ist der " + datum);
        }
        public static void Date()
        {
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }

        public static void Time()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }

        public static void TimeZone()
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss zzz"));
        }

        public static void Millisecond()
        {
            Console.WriteLine(DateTime.Now.ToString("ss.fff"));
        }
    }
}