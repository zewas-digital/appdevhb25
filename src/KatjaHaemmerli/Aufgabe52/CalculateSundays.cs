using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe52
{
    public  class CalculateSundays
    {
        public static void CalSundays()
        {
            // Ermittle das Datum der nächsten drei Sonntage von heute weg. 
            // Gib die Daten der drei Sonntage mit unterschiedlichen Formatierungen aus.
            DateTime today = DateTime.Now;
            Console.WriteLine($"Today is: {today.DayOfWeek}");
            int foundSundys = 0;

            //Solange Tag++ bis einen Sonntag gefunden
            while (foundSundys < 3)
            {
                if (today.DayOfWeek == DayOfWeek.Sunday)
                {
                    // foundSundys++;
                    // System.Console.WriteLine($"The Sunday {foundSundys}: {today}");
                    //Wert (foundSundays) wird zuerst erhöht und dann geschieht die Ausgabe
                    System.Console.WriteLine($"The Sunday {++foundSundys}: " + today);                    
                }
                today = today.AddDays(1);
            }
        }
    }
}