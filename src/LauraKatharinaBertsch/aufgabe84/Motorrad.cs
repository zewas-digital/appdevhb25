namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe84
{
    public class Motorrad : IGegenstand
    {
        public int Inventarnummer { get; set; }
        private string _farbe;
        public string Farbe
        {
            get
            {
                return _farbe;
            }
            set
            {
                _farbe = value;
            }
        }
        public Motorrad(string farbe)
        {
            Farbe = farbe;
        }
        public string GetGegenstandInfo()
        {
            Inventarnummer++;
            string inventarnummer = Inventarnummer.ToString();
            return $"Farbe: {Farbe} Inventarnummer: {inventarnummer}";
        }
        public override string ToString()
        {
            return "Motorrad";
        }
    }
}