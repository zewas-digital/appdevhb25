namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe103
{
    public class Buch(string isbn, string titel, int erscheinungsjahr, string verlag, string sprache, string autor)
    {
        public string ISBN { get; private set; } = isbn;
        public string Titel { get; private set; } = titel;
        public int Erscheinungsjahr { get; private set; } = erscheinungsjahr;
        public string Verlag { get; private set; } = verlag;
        public string Sprache { get; private set; } = sprache;
        public string Autor { get; private set; } = autor;

        public override string ToString()
        {
            return $"{ISBN} | {Titel} - {Erscheinungsjahr} - {Verlag} - {Sprache} - {Autor}";
        }
    }
}