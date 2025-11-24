using System.Text.Json;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe87
{
    public class Aufgabe87
    {
        public static void Start()
        {
            TeilnehmerAbwesenheit teilnehmer = new TeilnehmerAbwesenheit();

            teilnehmer.TeilnehmerHinzufuegen("Schmidt");
            teilnehmer.TeilnehmerHinzufuegen("Mayer");
            teilnehmer.TeilnehmerHinzufuegen("Flatz");

            teilnehmer.AbwesenheitHinzufuegen("schmidt", new DateTime(2025, 11, 17, 13, 30, 00), new DateTime(2025, 11, 17, 16, 50, 00));
            teilnehmer.AbwesenheitHinzufuegen("schmidt", new DateTime(2025, 11, 20, 10, 00, 00), new DateTime(2025, 11, 20, 16, 00, 00));
            teilnehmer.AbwesenheitHinzufuegen("mayer", new DateTime(2025, 11, 17, 12, 15, 00), new DateTime(2025, 11, 17, 17, 30, 00));
            teilnehmer.AbwesenheitHinzufuegen("flatz", new DateTime(2025, 11, 17, 10, 45, 00), new DateTime(2025, 11, 17, 13, 45, 00));
            teilnehmer.AbwesenheitHinzufuegen("flatz", new DateTime(2025, 11, 17, 09, 30, 00), new DateTime(2025, 11, 17, 14, 00, 00));
            teilnehmer.AbwesenheitHinzufuegen("flatz", new DateTime(2025, 11, 17, 15, 15, 00), new DateTime(2025, 11, 17, 18, 15, 00));

            teilnehmer.AbwesenheitenAnzeigen("schmidt");
            Console.WriteLine();
            teilnehmer.AbwesenheitsStundenBerechnen("flatz");
        }
    }
}