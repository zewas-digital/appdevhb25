using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe86
{
    public class Callcenter
    {
        Queue<Anruf> anrufListe = new Queue<Anruf>();        

        public void AusgabeDerTelefonnummern()
        {
            foreach(Anruf anruf in anrufListe)
            {                
                System.Console.WriteLine($"\nAnruf am: {anruf.DatumUndUhrzeit}\nName: {anruf.Name}\nTelefonnummer: {anruf.Telfonnummern}"); // gezielt ausgewählt ausgeben               
            }
        }

        public void TelefonnummerHinzufuegen(Anruf contact)
        {
            anrufListe.Enqueue(contact);
        }
    }
}