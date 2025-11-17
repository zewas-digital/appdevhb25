namespace Appdevhb25.LiaLouiseNatter.Aufgabe72
{
    public class Speicherkarte
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

        public Speicherkarte(double speicherkartenPlatz)
        {
            SpeicherkartenPLatz = speicherkartenPlatz;
        }

        
        public void SpeicherplatzPrinter()
        {
            System.Console.WriteLine($"Übriger Platz auf der Speicherkarte: {SpeicherkartenPLatz}");
        }
        

    }
}