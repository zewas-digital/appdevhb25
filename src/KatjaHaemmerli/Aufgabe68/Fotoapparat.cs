public class Fotoapparat
{
    private string Hersteller;    
    private double Megapixel;

    // privates Feld für den Wert
    private string _model;

    // öffentliches Attribut als Gatekeeper
    public string Model
    {
        get
        {
            // System.Console.WriteLine("Model:");
            return _model;
        }
        
    }

    // privates Feld für den Wert
    private double _brennweite;
    public double Brennweite
    {
        get
        {
            // System.Console.WriteLine("Model:");
            return _brennweite;
        }
        set
        {
            if (value > 0)
            {
                _brennweite = value;
            }
            else
            {
                System.Console.WriteLine("Brennweite weniger als gesetzte Brennweite ist nicht möglich.");
            }

        }
    }
    public Fotoapparat()
    {
        
    }

    // public Fotoapparat(string model)
    // {

    // }
    public void MacheEinFoto()
    {
        System.Console.WriteLine("Es wurde ein Foto gemacht.");
    }
    
    public void AusgabeBrennweite()
    {
        System.Console.WriteLine("Brennweite wurde eingestellt.");
    }
}
