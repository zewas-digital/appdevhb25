public class Speicherkarte : Hardware
{
    static double speichergroesse = 1600; // In eigenes File Speicherkarte Klasse
    public static double mbVerbrauchProFoto = 5;


    public double Speichergroesse
    {
        get
        {
            return Speichergroesse;
        }
        set
        {
            if (value < speichergroesse)
            {
                Speichergroesse = value;
            }
            else
            {
                System.Console.WriteLine("Kein Speicherplatz mehr frei.");
            }
        }
    }

    public Speicherkarte(string seriennummer, string modell, double speichergroesse) : base(seriennummer, modell) //speichergrösse ist nicht in Hardware(Superklasse) sonder in der Klasse Speicherkarte selbst
    {
        Speichergroesse = speichergroesse;
    }
}
