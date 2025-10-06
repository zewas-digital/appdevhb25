using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe12
{
    // Erstelle eine Methode, welche die ersten n Folgenglieder der Fibonacci-Folge auf der Konsole ausgibt.
    public class Fibonacci
    {
        public static void Fibo(int folgenglieder)
        {
            int ersteZahl = 1;
            int zweiteZahl = 1;
            int summeAusVorherigenZweiZahlen = ersteZahl + zweiteZahl;

            for (int i = 0; i < folgenglieder; i++)
            {
                summeAusVorherigenZweiZahlen = ersteZahl + zweiteZahl; // dritte zahl ist die Summe von ersteZahl und zweitZahl
                Console.WriteLine(summeAusVorherigenZweiZahlen);
                // In Fibonacci - Folge nach vorne rücken nach jedem berechnen der zahl aus den zwei vorherigen zwei zahlen  
                ersteZahl = zweiteZahl; // Wert von zweiterZahl wird in ersteZahl gespeichert (erste Zahl wird zur zweiten)
                zweiteZahl = summeAusVorherigenZweiZahlen; // summe aus ersteZahl und zweiteZahl wird in zweite Zahl gespeichert. (zahl von summe wird zur zweiten Zahl)
            }
        }

    }
}
