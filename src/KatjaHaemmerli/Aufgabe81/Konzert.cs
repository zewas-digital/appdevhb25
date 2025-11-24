using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe81
{
    public  class Konzert
    {
        public string KonzertName;
        public Queue<string> Warteschlange;
    
        public Konzert(string konzertName)
        {
            KonzertName = konzertName;

            Warteschlange = new Queue<string>();
            System.Console.WriteLine($"Einreihende Personen: {Warteschlange}");            
        }
    }
}