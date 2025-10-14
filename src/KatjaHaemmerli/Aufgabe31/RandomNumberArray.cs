using System.Collections;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe20;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe31
{
    // Erstelle eine Methode, welche eine Kommazahl (Parameter 0) auf eine bestimmte Anzahl an Nachkommastellen genau (Parameter 1) kaufmännisch rundet. 
    public class RandomNumberArray
    {
        public static void RandomArray()
        {
            // int[] randomNum = new int[5] { 43, 96, 1, 3, 55 };

            // userInput (Anzahl Zahlen) in ein Array speichern.            
            Console.WriteLine("Wie viele Zahlen möchtest du eintragen? Bitte gib eine Zahl ein.");            
            int userNum = Convert.ToInt32(Console.ReadLine()); 

            int[] randomNum = new int[userNum];
            Random random = new Random();
            for (int i = 0; i < randomNum.Length; i++)
            {
                randomNum[i] = random.Next(0,100);
            }

            /* Stelle folgende Berechnungen an und gib das Ergebnis jeweils auf der Konsole aus:
                    größter Wert
                    kleinster Wert
                    Durchschnitt aller Werte
                    Summe aller Werte*/
            int maxNum = 0; // zur speicherung zuerst 0
            int minNum = 100;
            int sum = 0;

            // grösserer Wert finden
            // jedes element 
            foreach (int num in randomNum)
            {
                if (num > maxNum)
                {
                    maxNum = num;
                }
                if (num < minNum)
                {
                    minNum = num;
                }

                // summe aller Werte berechnen
                //sum = sum + num;
                sum += num;
            }

            // der Durchschnitt aller Werte berechnen
            int durchschnitt = sum / randomNum.Length; // Summe durch anzahl der Länge des Arrays
            Console.WriteLine($"Auflistung:");
            for (int i = 0; i < randomNum.Length; i++)
            {
                Console.WriteLine(randomNum[i]);                 
            }
            Console.WriteLine($"Die Max Number is: {maxNum}");
            Console.WriteLine($"Die Min Number is: {minNum}");
            Console.WriteLine($"Der Durchschnitt der Werte ist: {durchschnitt}");
            Console.WriteLine($"Die Summe aller Werte ist: {sum}");               
        }
    }
}