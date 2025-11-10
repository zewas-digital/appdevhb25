namespace Appdevhb25.LiaLouiseNatter.Aufgabe73
{
    public class Speicherkarte : Hardware
    {
        private static double _speicherkartenPlatz;
        public double SpeicherkartenPLatz
        {
            get
            {
                return _speicherkartenPlatz;
            }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Speicherkarte darf nicht negativ sein.");
                }
                else
                {
                    _speicherkartenPlatz = value;
                }
            }
        }

        public Speicherkarte(string Seriennummer, string Modell, double speicherkartenPlatz):base(Modell, Seriennummer)
        {
            SpeicherkartenPLatz = speicherkartenPlatz;
        }


        public void SpeicherplatzPrinter()
        {
            System.Console.WriteLine($"Übriger Platz auf der Speicherkarte: {SpeicherkartenPLatz}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} Speicherplatz: {SpeicherkartenPLatz}";
        }

    }
}