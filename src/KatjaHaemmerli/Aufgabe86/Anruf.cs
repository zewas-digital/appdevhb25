using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe86
{
    public  class Anruf
    {
        public string Name;
        public DateTime DatumUndUhrzeit;
        public string Telfonnummern;
        public Anruf(string name, string telefonnummern)
        {
            Name = name;
            DatumUndUhrzeit = DateTime.Now;
            Telfonnummern = telefonnummern;
        }
        public Anruf()
        {
            
        }
    }
}