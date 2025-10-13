using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe03;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe19
{
    public class Datentypensum
    {
        public static void Summe()
        {
            int ersteZahl = 20;
            int zweiteZahl = 21;
            for (int i = 20; i <= 50; i++)
            {                
                int sum = ersteZahl + zweiteZahl;
                Console.WriteLine($"{ersteZahl} + {zweiteZahl} = {sum}");
                ersteZahl = sum;
                zweiteZahl++;                           
            }
                
        }  
        
    }
}