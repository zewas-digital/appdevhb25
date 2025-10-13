using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe20;


namespace Appdevhb25.KatjaHaemmerli.Aufgabe04
{    
    public class Teilbarkeit
    {
        /*Gib alle Zahlen innerhalb eines bestimmten Intervalls aus, 
        die durch eine andere Zahl ohne Rest teilbar sind.*/       
        public static void Fakt()
        {
            int intervallStart = 8;
            int internallEnde = 10;
            int sum = 0;
            int teiler = 3;
            
            for (int i = intervallStart; i <= internallEnde; i++)
            {
                if (i % teiler == 0) // Wenn kein Modulo (keinen Restwert von Rechnung/ Wenn Zahl gerade ist)
                {
                    sum = sum + i;
                    Console.WriteLine(sum);
                }
            }
        }
    }
}