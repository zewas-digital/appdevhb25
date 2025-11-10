namespace Appdevhb25.LiaLouiseNatter.Aufgabe71
{
    public class FahrzeugStarter()
    {
        public static void Start()
        {
            Fahrzeuge[] fahrzeuge = new Fahrzeuge[]
            {
                new Motorrad("Red", "AT 123455", 2_000, 100, 25_000),
                new Auto("Blue", "DE 567890", 3000, 5),
                new Motorrad("Black", "AT 56789", 4000, 150, 20_000)
            };


            foreach(Fahrzeuge fahrzeug in fahrzeuge)
            {
                fahrzeug.Fahren(500);
                fahrzeug.DruckeDatenblatt();
            }
        }
    }
}