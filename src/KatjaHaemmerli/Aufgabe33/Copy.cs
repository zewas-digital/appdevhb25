using System.Collections;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe20;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe33
{
    // Erstelle eine Methode, welche eine Kommazahl (Parameter 0) auf eine bestimmte Anzahl an Nachkommastellen genau (Parameter 1) kaufmännisch rundet. 
    public class CopyArray
    {
        public static void Array()
        {
            // // Mehrdimensionales Array
            // int[,,] array = new int[3, 3, 3];

            // // eindimenionales Array mit Zuweisung von Werten
            // int[] array2 = [1, 2, 3];
            int[] originalArray = new int[] { 1, 2, 3 };
            int [] result = Copy(originalArray); // Rückgabewet wird in result gespeichert -> newArray kommt in result 

            originalArray[0] =- 1; //zum prüfen ob copy by value richtig gemacht

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            
        }
        public static int[] Copy(int[] oArray) //oArray erhält den Wert von originalArray
        {
            // int[] copiedArray = Copy(originalArray);
            int[] newArray = new int[oArray.Length];            

            for (int i = 0; i < oArray.Length; i++)
            {
                newArray[i] = oArray[i]; // Wert von origianalArray wird in newArray gespeichert.
            }
            return newArray;
        }

    }
}