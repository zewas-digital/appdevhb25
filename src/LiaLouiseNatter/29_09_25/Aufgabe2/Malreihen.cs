using System;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe2
{
    public class Malreihen
    {
        public static void Start()
        {

            System.Console.WriteLine("5er Reihe:");
            int multipicator = 5;
            for (int i = 1; i < 11; i++)
            {
                int result = i * multipicator;
                Console.WriteLine(i + "*" + multipicator + "=" + result);
            }
            

        }
    }
    }

