using System;

namespace Appdevhb25.NoahHois.Aufgabe10
{
    public class PrintTriangle3
    {
        public static void Aufgabe10()
        {
            Console.Write("Geben Sie die Hoehe des Dreiecks ein: ");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int y = 0; y < height -1; y++)
            {
                
                for (int x = height*-1 +1; x < height; x++){
                    
                    if (Math.Abs(x) == Math.Abs(y))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            
            for (int l = height*-1 +1; l < height; l++)
            {
            Console.Write("*");
            }
            
        }
    }        
}
