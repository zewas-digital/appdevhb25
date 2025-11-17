namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe73
{
    public class Hardware
    {
        public string Modell { get; init; }
        public string Seriennummer { get; init; }

        public Hardware(string modell, string seriennummer)
        {
            Modell = modell;
            Seriennummer = seriennummer;
        }

        public override string ToString()
        {
            return $"{Modell} (SN: {Seriennummer})";
        }
    }
}