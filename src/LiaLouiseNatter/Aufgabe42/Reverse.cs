using System;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe42
{
    public class Reverse
    {
        public static void Start()
        {
            Reverser();
        }
        
        public static void Reverser()
        {
            System.Console.Write("Geben Sie ihren Text ein: ");
            string? textUnreversed = Console.ReadLine() ??"";

            char[]? backwardsArray = textUnreversed.ToCharArray();
            Array.Reverse(backwardsArray);

            string textReversed = new string(backwardsArray);
            System.Console.WriteLine($"Ihr umgedrehter Text: {textReversed}");


        }
    }
}

