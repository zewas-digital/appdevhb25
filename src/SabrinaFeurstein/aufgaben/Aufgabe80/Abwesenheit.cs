namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe80
{
    public class Abwesenheit
    {
        public DateTime Startzeitpunkt { get; set; }
        public DateTime Endzeitpunkt { get; set; }
        public string Fehlgrund { get; set; }
        public string Entschuldigt { get; set; }

        public Abwesenheit(DateTime startzeitpunkt, DateTime endzeitpunkt, string fehlgrund, string entschuldigt)
        {
            Startzeitpunkt = startzeitpunkt;
            Endzeitpunkt = endzeitpunkt;
            Fehlgrund = fehlgrund;
            Entschuldigt = entschuldigt;
        }

        public override string ToString()
        {
            return $"Start: {Startzeitpunkt:T}, Ende: {Endzeitpunkt:T}, Fehlgrund: {Fehlgrund}, Entschuldigt: {Entschuldigt}";
        }
    }
}