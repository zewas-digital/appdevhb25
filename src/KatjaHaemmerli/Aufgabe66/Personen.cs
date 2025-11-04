
namespace Appdevhb25.KatjaHaemmerli.Aufgab66
{
    public class Personen
    {
        public string Name;
        public DateTime Geburtstag;
        public double Grösse;
        public int Gewicht;

        public void PrintPersonenAttribute()
        {
            System.Console.WriteLine(Name);
            System.Console.WriteLine(Geburtstag);
            System.Console.WriteLine(Grösse);
            System.Console.WriteLine(Gewicht);
        }
    }
}