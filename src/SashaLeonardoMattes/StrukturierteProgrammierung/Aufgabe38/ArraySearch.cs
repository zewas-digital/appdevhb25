using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe38
{

    public class ArraySearch
    {

        public static void StartArraySearch()
        {
            Console.WriteLine("----------Aufgabe 38----------");


            string[] words = { "test", "hallo", "tschau", "bitte", "danke", "wieso", "warum", "weshalb", "wer", "nicht" };
            bool found = false;

            System.Console.WriteLine("Gib ein Wort oder eine Silbe ein, die du suchen willst:");
            string toFind = Helper.checkUserInputString();
            
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].IndexOf(toFind) == -1) //muss aus for
                {
                    if (i == words.Length -1 && found == false)
                    {
                        System.Console.WriteLine("Deine Eingabe wurde nirgends gefunden");    
                    }
                    
                } 
                else
                {
                    System.Console.WriteLine("Deine Eingabe wurde an Index " + i + " gefunden");
                    found = true;
                }
            }

        }
        
        
    }
}
