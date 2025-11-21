using System.Text.Json;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe80
{
    public class Aufgabe80
    {
        public static void Start()
        {
            string pfad = @"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein\aufgaben\Aufgabe80\GespeicherteDaten.json";
            List<Teilnehmer> teilnehmer = new List<Teilnehmer>();
            if (!(new FileInfo(pfad).Length == 0))
            {
                teilnehmer = JsonSerializer.Deserialize<List<Teilnehmer>>(File.ReadAllText(pfad))!;
            }

            teilnehmer.Add(new Teilnehmer("Julia", "Schmidt", 24));
            teilnehmer[0].AbwesenheitHinzufuegen(new DateTime(2025, 11, 17, 13, 30, 00), new DateTime(2025, 11, 17, 16, 50, 00), "Arzt", "ja");

            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (var person in teilnehmer)
            {
                person.KostenDurchAbwesenheiten();
                Console.WriteLine($"Stundensatz von {person}: {person.Stundensatz}");
                if (person.AbwesenheitsStundenInsgesamt > 0)
                {
                    Console.WriteLine();
                    person.AbwesenheitenAnzeigen();
                    Console.WriteLine($"\nKosten entstanden durch Abwesenheiten für {person}: {person.KostenDurchAbwesenheiten():F2} EUR");
                }
                Console.WriteLine("-----------------------------------------------------------------------------");
            }

            File.WriteAllText(pfad, JsonSerializer.Serialize(teilnehmer));
        }
    }
}