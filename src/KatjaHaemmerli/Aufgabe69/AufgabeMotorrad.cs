using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe69
{
    public class AufgabeMotorrad
    {
        public static void Start()
        {
            Motorrad motorrad = new Motorrad("Yamaha", "schwarz", 20_000);            

            Motorrad motorrad2 = new Motorrad("Honda", "rot", 10_000);
            
            Motorrad motorrad3 = new Motorrad("Honda", "weiss", 15_000);

            Motorrad.BerechneDurchschnittsumsatz();
            Motorrad.BerechnungUmsatz();            
        }
    }
}