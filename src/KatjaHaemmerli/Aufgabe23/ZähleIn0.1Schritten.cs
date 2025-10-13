using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe20;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe23
{
    //Erstelle eine Funktion, die von 0 bis 20 zählt und folgende Daten ausdrückt: Zähler selbst und die Rechnung. Und verwende var anstelle eines konkreten Datentypes
    public class ZählenIn01Schritten
    {
        public static void KleineSchritten()
        {
            // zähle in 0,1er Schritten bis 100

            // Variante 1
            for (double i = 0.1; i <= 100; i += 0.1)
            {
                Console.WriteLine($"{i}");
            }

            // Variante 2
            
        }

    }
}