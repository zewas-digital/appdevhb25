using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe54Bonus
{
    public  class DrawCalendar
    {
        /* Aufgabe: Erstelle ein Programm, welches einen Kalender korrekt darstellt.
        Der aktuelle Tag soll speziell markiert werden.
        
        Achte darauf, dass
        Der aktuellen Tag mit einem Stern gekennzeichnet ist
        Nicht jeder Monat mit einem Montag beginnt
        Nicht jeder Monat mit einem Sonntag endet
        Zum Testen sollst du verschiedene Tage als "heute" verwenden (vorgeben).*/
        public static void DrawingCalendar()
        {
            System.Console.WriteLine(new string('-', 36));
            System.Console.WriteLine(@"| {0,-3}| {1,-3}| {2,-2} | {3,-2} | {4,-2} | {5,-2} | {6,-2} |",
            "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So");
            
            for(int i = 0; i < 4; i++)
            {
                System.Console.WriteLine(new string('-', 36));
                for (int j = 0; j <= 6; j++)
                {
                    System.Console.Write(new string("|"));
                    System.Console.Write(new string("zahl"));
                }
                System.Console.Write("|");
                System.Console.WriteLine();               
            }
            System.Console.Write(new string('-', 36)); 
            
        }
    }
}