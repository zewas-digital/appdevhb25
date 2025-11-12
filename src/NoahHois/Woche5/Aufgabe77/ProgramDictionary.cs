namespace Appdevhb25.NoahHois.Aufgabe77
{
    public class ProgramDictionary
    {
        public static void Start()
        {
            Dictionary dictionary = new Dictionary();
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