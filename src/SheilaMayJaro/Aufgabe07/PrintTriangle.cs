using System; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe07
{
    public class PrintTriangle
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 7)"); 
            int length = 5;
            string fillSpace = "x"; 

        for (int i = 0; i <= length; i++)
            {
                for (int j= length; j > i; j--)
            {
                Console.Write(fillSpace);
            } Console.WriteLine(); 
            }
        }
    }
}
