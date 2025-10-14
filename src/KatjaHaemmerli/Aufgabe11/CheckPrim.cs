using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe11
{
    public class CheckPrimzahl
    {
        public static void CheckPrim(int zahl)
        {
            // int rest = ganzZahl % 2;

            //Wenn Zahl keine Primzahl (Ganzzahl) zahl + 1
            for (int ganzZahl = 0; ganzZahl < 1; ganzZahl++) // Wenn keine Primzahl
            {
                if (zahl % 2 == 0)
                {
                    Console.WriteLine(zahl + 1);
                }
            }
            for (int primZahl = 0; primZahl < 1 ; primZahl--) // Wenn eine Primzahl
            {
                if (zahl % 2 == 1)
                {
                    Console.WriteLine(zahl - 1);                    
                }
            }            
           
        }
    }
}
