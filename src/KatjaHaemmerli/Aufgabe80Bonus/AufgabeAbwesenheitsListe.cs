using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe80Bonus
{
    public class AufgabeAbwesenheitsListe
    {
        public static double summeAbwesenheiten = 0;
        public static void Start()
        {
            Queue<Teilnehmer> teilnehmerListe = new Queue<Teilnehmer>();

            Teilnehmer katja = new Teilnehmer("Katja", "Hämmerli", 38.5, 3, "Physiotherapie", "Ja"); // zuerst Objekt erstellen 
            teilnehmerListe.Enqueue(katja); // dann Objekt der Liste teilnehmerListe hinzufügen
            teilnehmerListe.Enqueue(new Teilnehmer("Carola", "Hämmerli", 39, 1, "Zug hatte verspätung.", "Nein")); // Objekt erstellen und direkt in die Liste teilnehmerListe speichern (beides in einem Schritt)
            teilnehmerListe.Enqueue(new Teilnehmer("Jessica", "Hämmerli", 39.5, 2, "Handwerker", "Ja"));

            Teilnehmer dequeued = teilnehmerListe.Dequeue();
            KostenAbwesenheitenBerechnen(dequeued.Abwesenheit);

            while (teilnehmerListe.Count > 0)
            {
                KostenAbwesenheitenBerechnen(teilnehmerListe.Dequeue().Abwesenheit);
            }
            System.Console.WriteLine($"Die Summer aller Abwesenheiten beträt: {summeAbwesenheiten}");            
        }

        // Liste für Festplatte
        Queue<Festplatte> festplatte = new Queue<Festplatte>();

        public static void KostenAbwesenheitenBerechnen(double abwesenheit)
        {
            summeAbwesenheiten += abwesenheit;
            
        }
    }
}