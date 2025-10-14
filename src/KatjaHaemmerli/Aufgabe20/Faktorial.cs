using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe20;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe20
{
    public class Faktorial
    {
        public static void Fakt()
        {
            long fakultät = 1;

            for (long i = 1; i <= 20; i++)
            {                
                fakultät = fakultät * i;
                Console.WriteLine($"{i}! = {fakultät}");
                Console.WriteLine($"{i}! = {i}*{fakultät} = {fakultät}"); // noch nicht korrekt: soll: 1*1*2*3
            }        
            
                
        }  
        
    }
}