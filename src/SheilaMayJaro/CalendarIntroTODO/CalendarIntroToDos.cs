using System;
using System.Globalization;
namespace Appdevhb25.SheilaMayJaro.CalendarIntroTODO
{
    public class CalendarIntro
    {
        public static void Start()
        {
            System.Console.WriteLine("CalendarIntro Aufgaben)");
            // TODO
            // 1. Teste verschiedene Formate und kulturelle Kontexte
            // 2. Gib ein Datum im Format Donnerstag, 24. Oktober 2024 aus
            // 3. Welche Kürzel gibt es für Jahr, Monat, Tag, Stunde, Minute, Sekunde

            System.Console.WriteLine("Intro)");

            //Struktur für einen Zeitstempel 
            DateTime dt1 = new DateTime(); //DateTime ist ein Datentyp und eine Klasse //mit dem keyword 'new' wird ein neues Objekt erzeugt 
            //Man kann es ohne Parameter anlegen, dann werden die Standardwerte eingefügt, die je nach Programmiersprache anders ist CSharp -> 01/01/0001 00:00:00
            DateTime dt2 = new DateTime(2025, 10, 21);
            // DateTime dt3 = new DateTime(21, 10, 2025); - ArgumentOutOfRangeException kommt 
            // System.Console.WriteLine("DateTime3:" + dt3.ToString());
            System.Console.WriteLine("DateTime1: " + dt1.ToString());
            System.Console.WriteLine("DateTime2: " + dt2.ToString());
            System.Console.WriteLine("Format dd.MMMM.yy: " + dt2.ToString("dd.MMMM.yy")); //Es gibt verschiedene Arten der Formatierung - Link https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings
            System.Console.WriteLine("Format MM-yyyy: " + dt2.ToString("MM-yyyy"));

            DateTime moment = DateTime.Now; //Es wird das heutige Datum mit Uhrzeit im Zeitpunkt der Ausführung angegeben 
            System.Console.WriteLine("Zeitstempel der Ausführung: " + moment);

            System.Console.WriteLine();
            System.Console.WriteLine("Aufgabe 1.)");
            // 1. Teste verschiedene Formate und kulturelle Kontexte
            CultureInfo austrian = new CultureInfo("de-AT"); //anderes Land, andere Kulturen - daher Sprache - Land angeben 
            DayOfWeek dow = austrian.DateTimeFormat.FirstDayOfWeek; //Standardmäßig ist z.B. Monday hinterlegt, wenn man es culturespezifisch haben möchte, muss man es mit der Methode unten zurückgeben
            System.Console.WriteLine("Anfang der Woche ist " + dow);

            DayOfWeek day = DayOfWeek.Thursday;
            DateTimeFormatInfo dtfi = austrian.DateTimeFormat;
            System.Console.WriteLine(dtfi.GetDayName(dow)); //Mit der Methode .GetDayName() wird der Name kulturspezifisch zurückgegeben 
            System.Console.WriteLine(austrian.DateTimeFormat.GetDayName(day));

            System.Console.WriteLine(moment.ToString("D"));
            System.Console.WriteLine(moment.ToString("M", austrian));

            CultureInfo british = new CultureInfo("en-GB");
            DateTimeFormatInfo dtfi2 = british.DateTimeFormat;
            System.Console.WriteLine(dtfi2.GetDayName(day));
            System.Console.WriteLine(british.DateTimeFormat.GetDayName(day));

            CultureInfo spanish = new CultureInfo("es-ES");
            DateTimeFormatInfo dtfi3 = spanish.DateTimeFormat;
            System.Console.WriteLine(dtfi3.GetDayName(day));
            System.Console.WriteLine(spanish.DateTimeFormat.GetDayName(day));

            // 2. Gib ein Datum im Format Donnerstag, 24. Oktober 2024 aus
            System.Console.WriteLine();
            System.Console.WriteLine("Aufgabe 2.)");

            DateTime dt3 = new DateTime(2025, 10, 21, 16, 23, 49);
            System.Console.WriteLine(dt3);

            // 3. Welche Kürzel gibt es für Jahr, Monat, Tag, Stunde, Minute, Sekunde

            System.Console.WriteLine();
            System.Console.WriteLine("Aufgabe 3.)");
            /* 
            y = year/Jahre
            M = month/Monate
            d = day/Tag
            h = hours/Stunden
            m = minutes/Minuten
            s = seconds/Sekunden
            */        

        










        }
    }
}