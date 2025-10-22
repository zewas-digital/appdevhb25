namespace Appdevhb25.NoahHois.Aufgabe38
{
    public class WhenAndWhere
    {
        public static void Start()
        {
            DateTime date = new DateTime(2025, 10, 21, 11, 11, 11, 111);

            // Minuten: 15' = 15 min
            // Sekunden: 15'' = 15 sek

            Console.WriteLine(date.ToString("d"));
            Console.WriteLine(date.ToString("t"));
            Console.WriteLine(date.ToString(""));
            Console.WriteLine(date.ToString("dd.MM.yyyy hh:mm zzz"));
            Console.WriteLine(date.ToString("ss.ffff"));
        }
    }
}