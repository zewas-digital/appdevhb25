namespace Appdevhb25.KatjaHaemmerli.Aufgabe71
{
    public abstract class Fahrzeug
    {
        private double _preis;
        public double Preis
        {
            get
            {
                return _preis;
            }
            set
            {
                _preis = value;
            }
        }

        // public virtual void Fahren()
        // {

        // }

        public abstract void AusgabeMotoradEigenschaften();
        public abstract void Fahren(double distance);
        public abstract void Dateblatt();

    }
}