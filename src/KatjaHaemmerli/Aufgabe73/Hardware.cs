public class Hardware
{
    private string _modell;
    public string Modell
    {
        get
        {
            return _modell;
        }
        set
        {
            Modell = value;
        }
    }

    private string _serienummer;
    public string Seriennummer
    {
        get
        {
            return _serienummer;
        }
        set
        {
            Seriennummer = value;
        }
    }

    public Hardware(string seriennummer, string modell)
    {
        seriennummer = _serienummer;
        modell = _modell;
    }
    public Hardware() // für die Subklasse Speicherkarte
    {
        
    }
}