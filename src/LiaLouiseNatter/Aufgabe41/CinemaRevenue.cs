using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.LiaLouiseNatter.Aufgabe19;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe41
{

    public class CinemaRevenue
    {

        public static void Start()
        {
            int[][] KinoArray = KinoCash();
            WenigstenVerkaufteTickets(KinoArray);
            
        }

        public static int[][] KinoCash()
        {
            int[][] KinoArray =
            {
                new int[] { 120, 80, 100, 90 },
                new int[] { 150, 160, 140, 155, 145 },
                new int[] { 90, 70, 85 },
                new int[] { 200, 180, 190, 210, 220, 195 },
                new int[] { 110, 95, 105, 100 }
            };
            TicketsProRaum(KinoArray);
            int[] length = TicketsProRaum(KinoArray);
            int roomSum = TicketsGesamt(KinoArray);
            double averageTickRounded = DurchschnittAnzahlTickets(KinoArray);
            int max = MeistVerkaufteTickets(KinoArray);
            int min = WenigstenVerkaufteTickets(KinoArray);

            for (int i = 0; i < KinoArray.Length; i++)
            {
                System.Console.WriteLine($"Verkaufte Tickets im Raum {i+1}: {length[i]}");

            }
            System.Console.WriteLine($"Gesamt verkaufte Tickets: {roomSum}");
            System.Console.WriteLine($"Durchschnittlich verkaufte Tickets: {averageTickRounded}");
            System.Console.WriteLine($"Meist verkaufte Tickets: {max}");
            System.Console.WriteLine($"Wenigsten verkaufte Tickets: {min}");
            

            System.Console.WriteLine();
            return KinoArray;
            

            
        }

        public static int[] TicketsProRaum(int[][] KinoArray)
        {
            int[] length = new int[KinoArray.Length];
            for (int r = 0; r < KinoArray.Length; r++)
            {
                int[] shows = KinoArray[r];
                length[r] = KinoArray[r].Sum();

            }
            return length;
        }

        public static int TicketsGesamt(int[][] KinoArray)
        {
            int roomSum = 0;
            for (int r = 0; r < KinoArray.Length; r++)
            {
                foreach(int num in KinoArray[r])
                {
                    roomSum += num;
                }
            }
            return roomSum;
            
        }

        public static double DurchschnittAnzahlTickets(int[][] KinoArray)
        {
            // => Lambda Operator
            // Alle inneren Arrays werden zu einer Großen Liste zusammengeführt
            // (innerArray => innerArray) nimmt das innere array und gibt es einfach weiter -> SelectMnay Nimmt dass für das "Entpacken" des Arrays.
            double averageTick = KinoArray.SelectMany(innerArray => innerArray).Average();
            double averageTickRounded = Math.Round(averageTick, 2);
            return averageTickRounded;
        }

        public static int MeistVerkaufteTickets(int[][] KinoArray)
        {
            int maxIdx = 0;
            int maxSm = 0;

            for (int i = 0; i < KinoArray.Length; i++)
            {
                int curSm = 0;

                foreach (int num in KinoArray[i])
                {
                    curSm += num;
                }

                if (curSm > maxSm)
                {
                    maxSm = curSm;
                    maxIdx = i;
                }
            }
            return maxSm;

        }
        
        public static int WenigstenVerkaufteTickets(int[][] KinoArray)
        {
            int minIdx = 0;
            int minSm = KinoArray[0].Sum();

            for (int i = 1; i < KinoArray.Length; i++)
            {
                int curSm = KinoArray[i].Sum();
                if (curSm < minSm)
                {
                    minSm = curSm;
                    minIdx = i;
                }
            }
            return minSm;
        }
    } 
    
}
