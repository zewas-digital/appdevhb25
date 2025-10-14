using System; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe04
{
    public class Divisibility
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 4)"); 
            int teiler = 3, intervallstart = 8, intervallende = 14; 
            

            for(int i = intervallstart; i <= intervallende; i++){
                if(i % teiler == 0){
                    Console.WriteLine(i); 
                }
            }
        }
    }
}