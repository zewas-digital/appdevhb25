using System; 
namespace Appdevhb25.SheilaMayJaro.Aufgabe52
{
    public class ClaculateSundays
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 52)");
            //Ermittle das Datum der nächsten drei Sonntage von heute weg. 
            //Gib die Daten der drei Sonntage mit unterschiedlichen Formatierungen aus.
            //Verwendung von TimeSpan bietet sich an Link: https://learn.microsoft.com/en-us/dotnet/api/system.timespan.-ctor?view=net-9.0#system-timespan-ctor(system-int32-system-int32-system-int32-system-int32)

            DateTime today = DateTime.Today;
            int foundSundays = 0; 
            while (foundSundays < 3) // man möchte die nächsten 3 Sonntage herausfinden
            {
                if (today.DayOfWeek == DayOfWeek.Sunday)
                {
                    foundSundays++;
                    System.Console.WriteLine($"Sonntag {foundSundays}: " + today);
                }
                today = today.AddDays(1); 
            }
        }
    }
}