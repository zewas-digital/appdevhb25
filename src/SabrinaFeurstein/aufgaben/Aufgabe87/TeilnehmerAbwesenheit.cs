namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe87
{
    public class TeilnehmerAbwesenheit
    {


        private readonly Dictionary<string, List<Abwesenheit>> TeilnehmerMitAbwesenheitsListe = new Dictionary<string, List<Abwesenheit>>(StringComparer.OrdinalIgnoreCase);

        public void TeilnehmerHinzufuegen(string name)
        {
            TeilnehmerMitAbwesenheitsListe.Add(name, new List<Abwesenheit>());
        }

        public void AbwesenheitHinzufuegen(string name, DateTime startzeitpunkt, DateTime endzeitpunkt)
        {
            TeilnehmerMitAbwesenheitsListe[name].Add(new Abwesenheit(startzeitpunkt, endzeitpunkt));
        }

        public void AbwesenheitenAnzeigen(string name)
        {
            foreach (var person in TeilnehmerMitAbwesenheitsListe)
            {
                if (person.Key.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Abwesenheiten von {person.Key}:\n-----------------------------------------------");
                    foreach (Abwesenheit abwesenheit in person.Value)
                    {
                        Console.WriteLine(abwesenheit);
                    }
                }
            }
        }

        public void AbwesenheitsStundenBerechnen(string name)
        {
            double AbwesenheitsStundenInsgesamt = 0;
            foreach (var person in TeilnehmerMitAbwesenheitsListe)
            {
                if (person.Key.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write($"Anzahl der Abwesenheitstunden von {person.Key}: ");
                    foreach (Abwesenheit abwesenheit in person.Value)
                    {
                        TimeSpan abwesenheitsZeit = abwesenheit.Endzeitpunkt - abwesenheit.Startzeitpunkt;
                        AbwesenheitsStundenInsgesamt += abwesenheitsZeit.TotalHours;
                    }
                    Console.WriteLine(AbwesenheitsStundenInsgesamt);
                }
            }
        }
    }
}