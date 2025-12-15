namespace Appdevhb25.KatjaHaemmerli.Aufgabe73
{
    class Fotoapparat : Hardware
    {

        private double _anzahlFotos;
        public double AnzahlFotos
        {
            get
            {
                return _anzahlFotos;
            }
            set
            {
                AnzahlFotos = value;
            }
        }        
    
        public Objektiv Objektiv;
        public Speicherkarte Speicherkarte;

        // beim Konstruktor die Anzahl Fotos am Anfang auf 0
        public Fotoapparat(string seriennummer, string modell): base(seriennummer, modell) // das base bezieht sich auf Hardware(Superklasse) 
                                                                     // mit base genau defiinieren was von Hardware genau geerbt werden soll.
        {

        }
        public double AnzahlVerfuegbarerFotos()
        {
            return AnzahlFotos;
        }  

         public void WechsleObjektiv(Objektiv neuesObjektiv)
        {
            Objektiv = neuesObjektiv;
        }

        public void WechsleSpeicherkarte(Speicherkarte neueSpeicherkarte)
        {
            Speicherkarte = neueSpeicherkarte;
        }
        public void Foto()
        {            
            System.Console.WriteLine("Macht ein Foto");
            Speicherkarte.Speichergroesse -= Speicherkarte.mbVerbrauchProFoto;
            AnzahlFotos++;
        }
    }
}