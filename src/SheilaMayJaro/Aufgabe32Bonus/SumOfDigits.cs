using System;
using System.Globalization;
namespace Appdevhb25.SheilaMayJaro.Aufgabe32
{
    public class SumOfDigits
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 32)");
            //Ziffernsumme bzw Quersumme berechnen 
            int number = 1234;
            int result = CalculateCrossSum(number); 
            System.Console.WriteLine(result);
            

        }
        public static int CalculateCrossSum(int number)
        {
            int crossSum = 0;
            char[] array = number.ToString().ToCharArray(); 
            for (int i = 0; i < array.Length; i++)
            {
                int digit = Convert.ToInt32(array[i].ToString());
                crossSum += digit; 
            }    
            return crossSum; 
        }
    }
}