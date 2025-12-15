using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe80Bonus
{
    public  class Teilnehmer
    {
       string Name;
       string Vorname;
       double Stundensatz;
       public int Abwesenheit;
       public string Fehlgrund;
       public string Entschuldigung;


        public Teilnehmer(string name, string vorname, double stundensatz,  int abwesenheit, string fehlgrund, string entschuldigung)
        {
            Name = name;
            Vorname = vorname;
            Stundensatz = stundensatz;
            Abwesenheit = abwesenheit;
            Fehlgrund = fehlgrund;
            Entschuldigung = entschuldigung;            
        }
    }
}