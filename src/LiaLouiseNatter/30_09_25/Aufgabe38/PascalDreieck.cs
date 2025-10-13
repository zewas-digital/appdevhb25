using System;
using System.Globalization;


namespace Appdevhb25.LiaLouiseNatter.Aufgabe38
{

    public class PascalDreieck
    {
        public static void Start()
        {
            int number = UserInput();
            PascalDing(number);
        }

        public static void PascalDing(int number)
        {
            // Regel: Jede Zahl in der Matrix ist gleich die Summe der Nachbarzahlen nach Links und nach Oben.
            int[,] triangeArray = new int[number, number];

            for (int i = 0; i < number; i++)
            {
                triangeArray[i, 0] = 1; // zeilen
                triangeArray[0, i] = 1; // spalten
            }

            for (int i = 1; i < number; i++)
            {
                for(int j = 1; j < number; j++)
                {
                    triangeArray[i, j] = triangeArray[i - 1, j] + triangeArray[i, j-1];

                }
            }
            

            for (int i = 0; i < number; i++) 
            {
                for (int j = 0; j < number; j++) 
                {
                    System.Console.Write(triangeArray[i, j] + " ");

                }
                System.Console.WriteLine();
            }

        }
        
        public static int UserInput()
        {
            int number;
            Console.WriteLine("Bitte eine Zahl eingeben: ");
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Ungültige Eingabe. Bitte eine positive ganze Zahl eingeben:");
            }
            return number;
        }
    
    }  
    
}
