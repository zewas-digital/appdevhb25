using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe20;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe22
{
    //Erstelle eine Funktion, die von 0 bis 20 zählt und folgende Daten ausdrückt: Zähler selbst und die Rechnung. Und verwende var anstelle eines konkreten Datentypes
    public class TeilenUndHerrschen
    {
        public static void TeilundHerr()
        {           
            var rechenZahl1 = 5;
            double rechenZahl2 = 5.0d;

            for (double i = 1; i <= 5; i++)
            {
                var ergebnis1 = i / rechenZahl1;
                double ergebnis2 = i / rechenZahl2;
                // Console.WriteLine($"{startZahl} / {rechenZahl1} = {ergebnis1}");
                Console.WriteLine($"{i} / {rechenZahl2} = {ergebnis2}");
                rechenZahl1++;
                rechenZahl2++;                
            }
        }

    }
}