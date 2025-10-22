using System;
using System.Globalization;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe50
{
    public  class WhenAndWhere
    {
        public static void WhenWhere()
        {
            // Aufgaben:
            // 1. Nur das Datum
            // 2. Nur die Uhrzeit
            // 3. Datum und Uhrzeit
            // 4. Datum und Uhrzeit mit Zeitzone (z. B. 10.10.2024 11:00 +01:00)
            // 5. Die aktuelle Sekunde mit Millisekunde

            // TODOs von Vorsellung Thema DateTime
            // 6. Teste verschiedene Formate und kulturelle Kontexte
            // 7. Gib ein Datum im Format Donnerstag, 24. Oktober 2024 aus
            // 8. Welche Kürzel gibt es für Jahr, Monat, Tag, Stunde, Minute, Sekunde

            DateTime time = DateTime.Now;
            DateTime time2 = new DateTime(2004, 3, 13);
            // Console.WriteLine(time2); 
            Console.WriteLine(time2.ToString("yyyy,mm,dddd,hhhh"));
            Console.WriteLine(time2.ToString("G"));

            //1.
            DateOnly date = DateOnly.FromDateTime(DateTime.Now);
            System.Console.WriteLine(date);
            System.Console.WriteLine(date.ToString("d")); // gib nur das Datum aus

            //2.
            int hour = time.Hour;
            int minute = time.Minute;
            System.Console.WriteLine($"{hour}:{minute}");
            Console.WriteLine(time2.ToString("t")); // gibt nur Stunde
            
            //3.
            DateTime now = DateTime.Now;
            System.Console.WriteLine(now);

            //4. Datum und Uhrzeit mit Zeitzone (z. B. 10.10.2024 11:00 +01:00)
            // int zeitzone = TimeZoneInfo.GetSystemTimeZones();
            TimeZoneInfo zeitzone = TimeZoneInfo.Utc;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            System.Console.WriteLine(time.ToString("G") + localZone);
            Console.ForegroundColor = ConsoleColor.White;

            //5. 
            Console.WriteLine(time.ToString("fff")); // aktuellen millisekunden ausgeben

            // 6. Teste verschiedene Formate und kulturelle Kontexte            
            CultureInfo austrian = new CultureInfo("de-AT");
            CultureInfo schweiz = new CultureInfo("de-CH");
            CultureInfo frSchweiz = new CultureInfo("fr-CH");
            CultureInfo itSchweiz = new CultureInfo("it-CH");
            CultureInfo usa = new CultureInfo("us-USA");
            DayOfWeek dow = austrian.DateTimeFormat.FirstDayOfWeek;
            DayOfWeek dow2 = schweiz.DateTimeFormat.FirstDayOfWeek;
            DayOfWeek dow3 = frSchweiz.DateTimeFormat.FirstDayOfWeek;
            DayOfWeek dow4 = itSchweiz.DateTimeFormat.FirstDayOfWeek;
            DayOfWeek dow5 = itSchweiz.DateTimeFormat.FirstDayOfWeek;
            Console.WriteLine(dow);
            Console.WriteLine(dow2);
            Console.WriteLine(dow3);
            Console.WriteLine(dow4);
            Console.WriteLine(dow5);
            
            // 7. Gib ein Datum im Format Donnerstag, 24. Oktober 2024 aus
            System.Console.WriteLine(time.ToLongDateString());

            // 8. Welche Kürzel gibt es für Jahr, Monat, Tag, Stunde, Minute, Sekunde
            // yy,yyyy, MM,MMMM,dd,dddd,hh,mm,ss
        }
    }
}