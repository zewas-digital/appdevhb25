namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe73
{
    public abstract class Hardware
    {
        private string _modell;
        private string _seriennummer;

        public string Modell
        {
            get
            {
                return _modell;
            }
            private set
            {
                _modell = value;
            }
        }

        public string Seriennummer
        {
            get
            {
                return _seriennummer;
            }
            private set
            {
                _seriennummer = value;
            }
        }

        public Hardware(string modell, string seriennummer)
        {
            Seriennummer = seriennummer;
            Modell = modell;
        }
        public override string ToString()
        {

            return $"Modell: {Modell} Seriennummer: {Seriennummer} ";
        }
    }
}