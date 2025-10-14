using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe20;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe27
{

    public class Generationen
    {
        //Erstelle ein Programm, das prüft, ob Personen aufgrund ihres alters berechtigt sind ein Moped und/oder Auto zu fahren.
        public static void OrdneGen()
        {
            // Console.WriteLine("Pls enter your name.");
            // string name = Console.ReadLine();
            Console.WriteLine("Hallo let´s find out your generation.");

            Console.WriteLine("Pls enter your year number. Example: 1991");
            int age = Convert.ToInt32(Console.ReadLine());
            
                if (age >= 1928 && age <= 1945)
                {
                    Silent();
                }                    
            
                if (age >= 1945 && age <= 1964)
                {
                    BabyBoomer();
                }
                
                Console.WriteLine("Hallo");
                if (age >= 1965 && age <= 1980)
                {
                    X();
                }
                
                if (age >= 1981 && age <= 1996)
                {
                    Y();
                }                    

                if (age >= 1997 && age <= 2009)
                {
                    Z();
                }
                
                else if (age >= 2011 && age <= 2024)
                {
                    Alpha();
                }                
                
                // kein Valider Input
                else
                {
                    Console.WriteLine("Pls enter a number.");
                }
                    
        }           
        
        public static void Silent()
        {
            Console.WriteLine("Your Generation is: Silent");
        }       
    
        public static void BabyBoomer()
        {
            Console.WriteLine("Your Generation is: BabyBomer");
        }
        public static void Y()
        {
            Console.WriteLine("Your Generation is: Y");
        }
        public static void X()
        {
            Console.WriteLine("Your Generation is: X");
        }
        public static void Z()
        {
            Console.WriteLine("Your Generation is: Z");
        }
         public static void Alpha()
        {
            Console.WriteLine("Your Generation is: Alpha");
        }  

    }
}