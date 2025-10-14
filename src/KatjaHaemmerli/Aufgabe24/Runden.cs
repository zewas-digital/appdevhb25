using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe20;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe24
{
    // Erstelle eine Methode, welche eine Kommazahl (Parameter 0) auf eine bestimmte Anzahl an Nachkommastellen genau (Parameter 1) kaufmännisch rundet. 
    public class Runden
    {
        public static void Rund(double zahl, int anzahlDerKommastellen)
        {
            // - die Zahl selbst: double
            // - Anzahl Kommastellen: double
            
            // Ausgangszahl Komma nach zwei Stellen verschieben, damit am ende auf diese zwei gerundet werden kann.
            int zahlAsInt = (int)(zahl * Math.Pow(10, anzahlDerKommastellen) + 1);
            // Zahl in double umwandeln, damit Kommanzeige in der Konsole möglich.
            double zahlAsDouble = (double)zahlAsInt;
            Console.WriteLine(zahlAsDouble /Math.Pow(10, anzahlDerKommastellen));
        }

    }
}