public class Motorrad
{
    public static int AnzahlMotorraeder;
    
    // privates Feld für den Wert
    private string _model;
    public string Model
    {
        get
        {
            return _model;
        }

        private set // privat, weil von Aussen soll das Model nicht verändert werden dürfen.
        {
            _model = value;
        }
       
    }
    
    // privates Feld für den Wert
    private string _farbe;
    public string Farbe { get; set; }
    // {
    //     get
    //     {
    //         return _farbe;
    //     }
    //     set
    //     {
    //         _farbe = value;
    //     }
    // }
    
    // privates Feld für den Wert
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

    public static double Umsatz;
   
    // privates Feld für den Wert
    private string _kennzeichen;
    public string Kennzeichen
    {
        get
        {
            return _kennzeichen;
        }
        set
        {
            // Kennzeichenprüfung: wenn kennzeichen kürzer als .. "nicht erlaubt."
            _kennzeichen = value;
        }

    }
    
    public Motorrad(string model, string farbe, int preis)
    {
        Model = model; // beim erzeugen des Objekts model mitgegeben wird und initialisiert wird
        AnzahlMotorraeder++;
        Farbe = farbe;
        // Umsatz = preis + Umsatz; 
        Umsatz += preis;
        AusgabeMotoradEigenschaften();
    }
    
    public void AusgabeMotoradEigenschaften()
    {
        System.Console.WriteLine($"Model: {Model}");        
        System.Console.WriteLine($"Farbe: {Farbe}");        
    }
    public static void BerechneDurchschnittsumsatz()
    {
        double durchschnitt = Umsatz / AnzahlMotorraeder;
        System.Console.WriteLine($"Der Durchschnittumsatz beträgt: {durchschnitt}");
    }
    public static void BerechnungUmsatz()
    {
        System.Console.WriteLine($"Der Umsatz beträgt: {Umsatz}");
    }
    
}
