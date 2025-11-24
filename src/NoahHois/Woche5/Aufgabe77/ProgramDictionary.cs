namespace Appdevhb25.NoahHois.Aufgabe77
{
    public class ProgramDictionary
    {
        public static void Start()
        {
            Series2 dictionary = new Series2();
            dictionary.Sotieren();
            System.Console.WriteLine();
            dictionary.BewertungUeber8();
            System.Console.WriteLine();
            dictionary.HoechsteBewertung();
            System.Console.WriteLine();
            string serienName = Console.ReadLine();
            dictionary.SucheSerie(serienName);
        }
    }
}