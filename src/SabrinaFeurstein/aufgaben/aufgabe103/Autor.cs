namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe103
{
    public class Autor(int id, string nachname, string vorname)
    {
        public int Id { get; private set; } = id;
        public string Nachname { get; private set; } = nachname;
        public string Vorname { get; private set; } = vorname;

        public override string ToString()
        {
            return $"{Id} | {Vorname} {Nachname}";
        }
    }
}