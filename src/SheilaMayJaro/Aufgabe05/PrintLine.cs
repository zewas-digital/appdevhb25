using System; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe05
{
    public class PrintLine
    {
        public static void Start()
        { int finish = 5; 
            Console.WriteLine("Aufgabe 5)");
            for( int i = 0; i < finish; i++)
            {
            Console.Write("x"); 
            }
            Console.WriteLine(); 

            int ausgegebeneZahlen = 0; 
            while(ausgegebeneZahlen < finish){
                Console.Write("x"); 
                ausgegebeneZahlen++; 
            }
            Console.WriteLine(); 
        }
     
    }
}