using System.Collections;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe20;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe34
{
    // Erstelle eine Methode, welche eine Kommazahl (Parameter 0) auf eine bestimmte Anzahl an Nachkommastellen genau (Parameter 1) kaufmännisch rundet. 
    public class CopyReverseArray
    {
        public static void CopyReverse()
        {
            int[] array1 = new int[] { 1, 2, 3 };
            int[] result = Copy(array1);

            // Console.WriteLine(result[2]);
            // Console.WriteLine(result[1]);
            // Console.WriteLine(result[0]);

            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(result[i]);
            }
        }
        public static int[] Copy(int[] array1)
        {
            int[] array2 = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i]; // Wert von origianalArray wird in newArray gespeichert.
            }
            return array2;

        }

    }
}