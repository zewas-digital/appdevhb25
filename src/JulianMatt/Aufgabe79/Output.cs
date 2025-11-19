using System;
using System.Collections;
using System.Collections.Generic;
using Appdevhb25.JulianMatt.Aufgabe79;

namespace Appdevhb25.JulianMatt.Aufgabe79
{
    public class Output
    {
        public static void Start79()
        {
            while (true)
            {
                StreamingPlatform streamingplatform = new StreamingPlatform();
                streamingplatform.FillRatingUp();

                streamingplatform.Print();

                Console.WriteLine("Welche Serie willst du bewerten (0 zum Beenden)");
                int seriesnumber = Convert.ToInt32(Console.ReadLine());

                if (seriesnumber == 0)
                {
                    Environment.Exit(0);
                }
    
                streamingplatform.RatingInput(seriesnumber - 1);

                streamingplatform.TopThreeSeries();

                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            
        }

    }
}