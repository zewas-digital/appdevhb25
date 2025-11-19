using System;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe79
{
    public class SeriesCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            StreamingPlatform sp1 = new StreamingPlatform();
            sp1.InitSeries();
            sp1.printSeries();

            do
            {
                System.Console.WriteLine("Gib die ID der Serie ein die du bewerten willst oder \"stopp\" um das Programm zu beenden");
                string? input = Console.ReadLine();

                if (input == "stopp" || input == null)
                {
                    break;
                }

                sp1.RateSeries(input);
                sp1.printTop3();
            } while (true);
        }

        
        
    }
}
