using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class WhenAndWhere
    {
        public static void Start()
        {
            DateTime now = DateTime.Now;
            DateTime utc = DateTime.UtcNow;

            Console.WriteLine(now);
            Console.WriteLine(now.ToString("d"));
            Console.WriteLine(now.ToString("t"));
            Console.WriteLine(now.ToString("g"));
            Console.WriteLine(utc.ToString("g") + now.ToString(" zzz"));
            Console.WriteLine(now.ToString("ss.fff"));
        }
    }
}