namespace Appdevhb25.MarcelSimma.Week07.InterfaceIntro
{

    public class Auto : IGegenstand
    {
        // Das Interface schreibt nur einen Mindeststandard vor. Ich kann mehr (in diesem Fall einen Setter) bereitstellen.
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