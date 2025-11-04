using System;
namespace Appdevhb25.SheilaMayJaro.Aufgabe50
{
    public class WhenAndWhere
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 50)");
            /*
            Erstelle ein Programm, das das aktuelle Datum und die Uhrzeit ausgibt. Verwende für jede unten angegebene Ausgabe ein eigenes DateTime und erstelle eine Ausgabe folgender Informationen: 

            1. Nur das Datum
            2. Nur die Uhrzeit
            3. Datum und Uhrzeit
            4. Datum und Uhrzeit mit Zeitzone (z. B. 10.10.2024 11:00 +01:00)
            5. Die aktuelle Sekunde mit Millisekunde
            */

            DateTime moment = DateTime.Now;
            System.Console.WriteLine(moment);
            System.Console.WriteLine();

            System.Console.WriteLine("Aufgabe 50.1)");
            //1. Nur das Datum 21.10.2025
            DateTime dateOfExercise = new DateTime(2025, 10, 21);
            System.Console.WriteLine(dateOfExercise.ToString("d"));
            System.Console.WriteLine();

            System.Console.WriteLine("Aufgabe 50.2)");
            // 2. Nur die Uhrzeit 11:04 Uhr
            DateTime timeOfExercise = new DateTime(2025, 10, 21, 11, 04, 00); //Datum muss man eingeben, ansonsten kommt eine Fehlermeldung
            System.Console.WriteLine(timeOfExercise.ToString("t") + " Uhr");
            System.Console.WriteLine();

            System.Console.WriteLine("Aufgabe 50.3)");
            // 3. Datum und Uhrzeit 21.10.2025 um 11:08:35 Uhr 
            DateTime timeStampOfExercise = new DateTime(2025, 10, 21, 11, 08, 35);
            System.Console.WriteLine(timeStampOfExercise.ToString("G") + " Uhr");
            System.Console.WriteLine();

            System.Console.WriteLine("Aufgabe 50.4)");
            //4. Datum und Uhrzeit mit Zeitzone (z. B. 21.10.2025 11:39 +01:00) 
            DateTime timeStampOfExercise2 = new DateTime(2025, 10, 21, 11, 39, 37);
            DateTimeOffset dto = new DateTimeOffset(moment.ToUniversalTime()); 
            System.Console.WriteLine(timeStampOfExercise2.ToString("G") + dto);
            System.Console.WriteLine();

            System.Console.WriteLine("Aufgabe 50.5)");
            //5. Die aktuelle Sekunde mit Millisekunde - Format
            System.Console.WriteLine(moment.ToString("fff")); 
            


            



        }
    }
}