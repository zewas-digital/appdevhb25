namespace Appdevhb25.MarcelSimma.Week07.InterfaceIntro
{

    public class Auto : IGegenstand
    {
        public string Inventarnummer { get; private set; }
        private int _anzahlDerTueren;
        public int AnzahlDerTueren
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
        public Auto(int anzahlDerTueren)
        {
            AnzahlDerTueren = anzahlDerTueren;
        }

        public string PrintGegenstand()
        {
            return "Das ist ein Auto.";
        }
    }
}