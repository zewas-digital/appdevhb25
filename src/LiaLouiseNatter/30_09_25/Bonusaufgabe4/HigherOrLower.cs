using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.BonusAufgabe4
{
    public class HigherOrLower
    {
        public static void Start()
        {
            RandomNumber();
        }

        public static void RandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);


            while (true)
            {
                try
                {
                    System.Console.Write("Guess a Random number from 1-100: ");
                    int guess = Convert.ToInt32(Console.ReadLine());
                    if (guess < randomNumber)
                    {
                        System.Console.WriteLine("Die gesuchte Zahl ist Größer als " + guess);
                        System.Console.WriteLine();
                    }

                    else if (guess > randomNumber)
                    {
                        System.Console.WriteLine("Die gesuchte Zahl ist Kleiner als " + guess);
                        System.Console.WriteLine();
                    }
                    else
                    {
                        System.Console.WriteLine(guess + " ist richtig!");
                        break;
                    }
                }
                catch
                {
                    System.Console.WriteLine("Es sind nur Zahlen erlaubt...");
                }
                
            }
        }

        

        
    }
}