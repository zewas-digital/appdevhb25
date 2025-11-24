namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe84
{
    public class Auto : IGegenstand
    {
        public int Inventarnummer { get; set; }
         private string _anzahlDerTueren;
        public string AnzahlDerTueren
        {
            get
            {
                return _anzahlDerTueren;
            }
            set
            {
                _anzahlDerTueren = value;
            }
        }
        public Auto(string anzahlDerTueren)
        {
            AnzahlDerTueren = anzahlDerTueren;
        }
        public string GetGegenstandInfo()
        {
            Inventarnummer++;
            string inventarnummer = Inventarnummer.ToString();
            return $"Anzahl der Türen: {AnzahlDerTueren} Inventarnummer: {inventarnummer}";
        }
        public override string ToString()
        {
            return "Auto";
        }
    }
}