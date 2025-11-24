namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe84
{
    public class Inventarliste
    {
        public static void Start()
        {
            List<IGegenstand> inventarliste = new List<IGegenstand>();

            inventarliste.Add(new Auto("5"));
            inventarliste.Add(new Motorrad("blau"));
            inventarliste.Add(new Fotoapparat("200"));

            foreach ( IGegenstand inventar in inventarliste)
            {
                Console.WriteLine("Das ist ein " + inventar );
                Console.WriteLine(inventar.GetGegenstandInfo());
            }  
        }
    }
}