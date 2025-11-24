namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe84
{
    public class Fotoapparat : IGegenstand
    {
        public int Inventarnummer { get; set; }
        private string _speicherplatz;
        public string Speicherplatz
        {
            get
            {
                return _speicherplatz;
            }
            set
            {
                _speicherplatz = value;
            }
        }
        public Fotoapparat(string speicherplatz)
        {
            Speicherplatz = speicherplatz;
        }
        public string GetGegenstandInfo()
        {
            Inventarnummer++;
            string inventarnummer = Inventarnummer.ToString();
            return $"Speicherplatz: {Speicherplatz} Inventarnummer: {inventarnummer}";
        }
        public override string ToString()
        {
            return "Fotoapparat";
        }
    }
}