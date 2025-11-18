namespace Appdevhb25.MarcelSimma.RepetitionStatic
{
    // Diese Klasse übernimmt das Handling (Objekte erstellen, verarbeiten, Listen erzeugen, etc.)
    public class RepetitionStatic
    {
        public static void Start()
        {
            System.Console.WriteLine(Speicherkarte.AnzahlDerProduziertenSpeicherkarten);

            /*
            Informationen, die für jedes Objekt einzeln mit verschiedenen Werten (zB Autofarbe) verfügbarsein sollen, sind non-static.
            Folglich ist die Informatino einem Objekt = Instanz zugeordnet. 

            Informationen, die nur einmal verfügbar sein sollen, sind static. (zB AnzahlDerProduziertenAutos)
            Folglich ist die Information einer Klasse zugeordnet


            */

            Speicherkarte sp1 = new Speicherkarte(100); // Aufruf des Konstruktors der Klasse Speicherkarte
            System.Console.WriteLine(sp1.Kapazitaet);
            Speicherkarte sp2 = new Speicherkarte(200);
            System.Console.WriteLine(sp2.Kapazitaet);

            sp1.Kapazitaet = 1000;


        }
        
    }
}