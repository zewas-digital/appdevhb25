using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe63
{
    public  class ProcessNumbers
    {
        /* Aufgabe: 
        Erstelle eine Methode, welche ein Integer-Array als Parameter entgegen nimmt 
        und die Anzahl der negativen Werte 
        und die Summe der positiven Werte (inkl. der Zahl 0) berechnet. 
        Die Methode soll ein Integer-Array der Größe 2 zurückgeben. 
        An der Stelle 0 im Array soll die Anzahl der negativen Werte gespeichert werden. 
        An der Stelle 1 im Array soll die Summe der positiven Werte gespeichert werden.*/

        public static void Start()
        {
            int[] numbers = new int[] { 200, -2, 0, 30 };
            int[] result = ProcessNum(numbers);
            
            int[] numbers2 = new int[] { -26, 30, 45, -58, -3 };
            int[] result2 = ProcessNum(numbers2);                       

            for (int i = 0; i < result.Length; i++)
            {
                if (i == 0) // array[0] - Anzahl der negativen Werte an der Stelle 0
                {
                    Console.WriteLine($"Anzahl negativ Zahlen: {result[0]}");
                }
                else
                {
                    Console.WriteLine($"Summe positive Zahlen: {result[1]}");
                }
            }
            System.Console.WriteLine(); // nur für den Abstand zwischen Output result und result2
            System.Console.WriteLine("Result2:");

            for(int i = 0; i < result2.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"Anzahl negativ Zahlen: {result2[0]}");
                }
                else
                {
                   Console.WriteLine($"Summe positive Zahlen: {result2[1]}"); 
                }
            }
        }

        public static int[] ProcessNum(int[] numbers)
        {
            int[] ergebnisse = new int[2]; // int[] in dieser Zeile ist der Rückgabedatentyp der Methode                     

            foreach(int num in numbers)
            {
                if (num < 0)
                {
                    // Zahl ist negativ                    
                    ergebnisse[0]++;
                }
                else
                {
                    // Zahl ist positiv
                    ergebnisse[1] += num;
                }
                
            }            
            return ergebnisse; 
        }        
        
    }
}