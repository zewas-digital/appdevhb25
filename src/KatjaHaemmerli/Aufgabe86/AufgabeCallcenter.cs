using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe86
{
    public  class AufgabeCallcenter
    {
        public static void Start()
        {
            Anruf anruf = new Anruf("Katja","1234");
            Callcenter callcenter = new Callcenter();
            callcenter.TelefonnummerHinzufuegen(new Anruf("Sheila", "54655"));
            callcenter.TelefonnummerHinzufuegen(anruf); 
            callcenter.AusgabeDerTelefonnummern();
            
        }
    }
}