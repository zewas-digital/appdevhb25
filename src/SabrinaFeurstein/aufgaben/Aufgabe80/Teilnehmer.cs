namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe80
{
    public class Teilnehmer
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public double Stundensatz { get; set; }
        public List<Abwesenheit> Abwesenheiten { get; set; }
        public double AbwesenheitsStundenInsgesamt;

        public Teilnehmer(string vorname, string nachname, double stundensatz)
        {
            Vorname = vorname;
            Nachname = nachname;
            Stundensatz = stundensatz;
            Abwesenheiten = new List<Abwesenheit>();
            AbwesenheitsStundenInsgesamt = 0;
        }

        public void AbwesenheitHinzufuegen(DateTime startzeitpunkt, DateTime endzeitpunkt, string fehlgrund, string entschuldigt)
        {
            Abwesenheiten.Add(new Abwesenheit(startzeitpunkt, endzeitpunkt, fehlgrund, entschuldigt));
        }

        public override string ToString()
        {
            return $"{Vorname} {Nachname}";
        }

        public void AbwesenheitenAnzeigen()
        {
            Console.WriteLine($"Abwesenheiten von {Vorname} {Nachname}:");
            foreach (var abwesenheit in Abwesenheiten)
            {
                Console.WriteLine("- " + abwesenheit);
            }
        }

        public double KostenDurchAbwesenheiten()
        {
            foreach (var abwesenheit in Abwesenheiten)
            {
                TimeSpan abwesenheitsZeit = abwesenheit.Endzeitpunkt - abwesenheit.Startzeitpunkt;
                AbwesenheitsStundenInsgesamt += abwesenheitsZeit.TotalHours;
            }
            return AbwesenheitsStundenInsgesamt * Stundensatz;
        }
    }
}