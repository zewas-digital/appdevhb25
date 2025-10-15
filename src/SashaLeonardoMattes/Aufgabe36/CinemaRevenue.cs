using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe36
{

    public class CinemaRevenue
    {

        public static void StartCinemaRevenue()
        {
            Console.WriteLine("----------Aufgabe 36----------");

            int[][] cinemaRooms = new int[5][];

            cinemaRooms[0] = new int[] { 10, 20 };
            cinemaRooms[1] = new int[] { 10, 20, 30 };
            cinemaRooms[2] = new int[] { 10, 20, 30, 40 };
            cinemaRooms[3] = new int[] { 10, 20, 30, 40, 50 };
            cinemaRooms[4] = new int[] { 10, 20, 30, 40, 50, 60 };

            System.Console.WriteLine($"Verkaufte Tickets insgesamt: {soldTicketsTotal(cinemaRooms)}");

            System.Console.Write("Verkaufte Tickets pro Raum: ");
            int[] roomSums = soldTicketsRoom(cinemaRooms);
            for (int i = 0; i < roomSums.Length; i++)
            {
                System.Console.Write($"Raum {i + 1}: {roomSums[i]} ");
            }

            System.Console.WriteLine();
             
            System.Console.WriteLine($"Durchschnittlich verkaufte Tickets: {averageTicketsTotal(cinemaRooms)}");

            System.Console.Write("Durchschnittlich verkaufte Tickets pro Raum: ");
            double[] roomAverages = averageTicketsRoom(cinemaRooms);
            for (int i = 0; i < roomAverages.Length; i++)
            {
                System.Console.Write($"Raum {i + 1}: {roomAverages[i]} ");
            }

            System.Console.WriteLine();

            int[] indexMaxValue = maxSoldTotal(cinemaRooms);
            System.Console.WriteLine($"Vorstellung mit den meisten verkauften Tickets: Raum {indexMaxValue[0] + 1} Vorstellung {indexMaxValue[1] + 1} mit {cinemaRooms[indexMaxValue[0]][indexMaxValue[1]]}");

            System.Console.WriteLine("Vorstellung mit meisten verkauften Tickets pro Raum:");
            int[] indexMaxValueRoom = maxSoldRoom(cinemaRooms);
            for (int i = 0; i < cinemaRooms.GetLength(0); i++)
            {
                System.Console.WriteLine($"Raum  {i + 1}: Vorstellung {indexMaxValueRoom[i] + 1} mit {cinemaRooms[i][indexMaxValueRoom[i]]}");
            }

            System.Console.WriteLine();
            
            int[] indexMinValue = minSoldTotal(cinemaRooms);
            System.Console.WriteLine($"Vorstellung mit den wenigsten verkauften Tickets: Raum {indexMinValue[0] + 1} Vorstellung {indexMinValue[1] + 1} mit {cinemaRooms[indexMinValue[0]][indexMinValue[1]]}");

            System.Console.WriteLine("Vorstellung mit wenigsten verkauften Tickets pro Raum:");
            int[] indexMinValueRoom = minSoldRoom(cinemaRooms);
            for (int i = 0; i < cinemaRooms.GetLength(0); i++)
            {
                System.Console.WriteLine($"Raum  {i + 1}: Vorstellung {indexMinValueRoom[i] + 1} mit {cinemaRooms[i][indexMinValueRoom[i]]}");
            }
        }

        public static int soldTicketsTotal(int[][] cinema)
        {
            int sum = 0;

            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                for (int j = 0; j < cinema[i].Length; j++)
                {
                    sum += cinema[i][j];
                }
            }
            return sum;
        }

        public static int[] soldTicketsRoom(int[][] cinema)
        {
            int[] roomSums = new int[cinema.GetLength(0)];

            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                for (int j = 0; j < cinema[i].Length; j++)
                {
                    roomSums[i] += cinema[i][j];

                }
            }
            return roomSums;
        }

        public static double averageTicketsTotal(int[][] cinema)
        {
            int sum = soldTicketsTotal(cinema);

            double length = 0.0; //dass er bei der return Berechnung auch einen Double zurückgibt

            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                for (int j = 0; j < cinema[i].Length; j++)
                {
                    length++;
                }
            }

            return sum / length;
        }

        public static double[] averageTicketsRoom(int[][] cinema)
        {
            double[] roomAverages = new double[cinema.GetLength(0)];

            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                for (int j = 0; j < cinema[i].Length; j++)
                {
                    roomAverages[i] += cinema[i][j];

                }
                roomAverages[i] = roomAverages[i] / cinema[i].Length;
            }
            return roomAverages;
        }

        public static int[] maxSoldTotal(int[][] cinema)
        {
            int max = 0;
            int[] indexMax = new int[2];

            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                if (i == 0)
                {
                    max = cinema[0][0];
                }

                for (int j = 0; j < cinema[i].Length; j++)
                {
                    if (cinema[i][j] > max)
                    {
                        max = cinema[i][j];
                    }
                }

            }

            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                for (int j = 0; j < cinema[i].Length; j++)
                {
                    if (cinema[i][j] == max)
                    {
                        indexMax[0] = i;
                        indexMax[1] = j;
                    }
                }

            }

            return indexMax;
        }

        public static int[] maxSoldRoom(int[][] cinema)
        {
            int[] max = new int[cinema.GetLength(0)];
            int[] indexMax = new int[cinema.GetLength(0)];

            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                if (i == 0)
                {
                    max[i] = cinema[0][0];
                }

                for (int j = 0; j < cinema[i].Length; j++)
                {
                    if (cinema[i][j] > max[i])
                    {
                        max[i] = cinema[i][j];
                    }
                }

            }

            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                for (int j = 0; j < cinema[i].Length; j++)
                {
                    if (cinema[i][j] == max[i])
                    {
                        indexMax[i] = j;
                    }
                }

            }

            return indexMax;
        }
        
        public static int[] minSoldTotal(int[][] cinema)
        {
            int min = 0;
            int[] indexMax = new int[2];

            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                if (i == 0)
                {
                    min = cinema[0][0];
                }

                for (int j = 0; j < cinema[i].Length; j++)
                {
                    if (cinema[i][j] < min)
                    {
                        min = cinema[i][j];
                    }
                }

            }

            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                for (int j = 0; j < cinema[i].Length; j++)
                {
                    if (cinema[i][j] == min)
                    {
                        indexMax[0] = i;
                        indexMax[1] = j;
                    }
                }

            }

            return indexMax;
        }
        
        public static int[] minSoldRoom(int[][] cinema)
        {
            int[] min = new int[cinema.GetLength(0)];
            int[] indexMax = new int[cinema.GetLength(0)];

            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                if (i == 0)
                {
                    min[i] = cinema[0][0];
                }

                for (int j = 0; j < cinema[i].Length; j++)
                {
                    if (cinema[i][j] < min[i])
                    {
                        min[i] = cinema[i][j];
                    }
                }

            }

            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                for (int j = 0; j < cinema[i].Length; j++)
                {
                    if (cinema[i][j] == min[i])
                    {
                        indexMax[i] = j;
                    }
                }

            }

            return indexMax;  
        }
        
        
    }
}
