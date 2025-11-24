namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe87
{
    public class Abwesenheit
    {
        public DateTime Startzeitpunkt { get; set; }
        public DateTime Endzeitpunkt { get; set; }

        public Abwesenheit(DateTime startzeitpunkt, DateTime endzeitpunkt)
        {
            Startzeitpunkt = startzeitpunkt;
            Endzeitpunkt = endzeitpunkt;
        }

        public override string ToString()
        {
            return $"Start: {Startzeitpunkt:g}, Ende: {Endzeitpunkt:g}";
        }
    }
}