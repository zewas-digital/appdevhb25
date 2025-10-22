using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe42
{
    public  class ReverseWord
    {
        public static void Reverse()
        {
            System.Console.WriteLine("Pls enter a wort to reverse.");
            char[] originalUserWord = Console.ReadLine().ToCharArray();
            string reversedUserWord = "";

            for (int i = originalUserWord.Length - 1; i >= 0; i--)
            {
                System.Console.Write(originalUserWord[i]);
            }
            System.Console.WriteLine(reversedUserWord);

        }
    }
}