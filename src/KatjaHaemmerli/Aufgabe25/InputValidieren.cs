using System.Collections;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe20;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe25
{
    // Erstelle eine Methode, welche eine Kommazahl (Parameter 0) auf eine bestimmte Anzahl an Nachkommastellen genau (Parameter 1) kaufmännisch rundet. 
    public class InputValidieren
    {
        public static int InputVal()
        {
            Console.WriteLine("Pls enter a number.");

            //int userInput = Convert.ToInt32(Console.ReadLine());

            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Pls enter a valid number.");
            }            
            return userInput;
        }

    }
}