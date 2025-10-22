using System;
using System.Data;
namespace Appdevhb25.SheilaMayJaro.Aufgabe51
{
    public class MyBirthday
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 51)");
            /*
            Erstelle ein Programm, das den Anwender nach seinem Geburtstag fragt und verarbeitet. 
            Als Ergebnis soll das Programm zurückgeben, an welchem Wochentag der Geburtstag des Anwenders war.
            Zusatz: War das Geburtsjahr ein Schaltjahr?
            */
            /*
            EVA - Prinzip 
            Eingabe - Nutzer gibt seinen Geburtstag ein 
            Verarbeitung
            Ausgabe - Ausgabe des Wochentages vom Geburtstag 
            */

            //Eingabe vom Nutzer
            System.Console.WriteLine("Möchtest du wissen, an welchem Wochentag dein Geburtstag war? \nDann gib bitte folgende Daten in Zahlen ein.");
            System.Console.WriteLine("In welchem Jahr bist du auf die Welt gekommen?");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            
            System.Console.WriteLine("In welchem Monat?");
            string monthAsString = Console.ReadLine();
            int.TryParse(monthAsString, out int birthMonth); // Die Rückgabe des Wertes erfolgt erst, wenn die Umwandlung in einen Integer auch erfolgreich war

            System.Console.WriteLine("Und zu guter Letzt an welchem Tag?");
            string dayAsString = Console.ReadLine();
            int.TryParse(dayAsString, out int birthDay);

            DateTime birthday = new DateTime(birthYear, birthMonth, birthDay);
            System.Console.WriteLine($"Dein Geburtstag war an einem {birthday.ToString("dddd")}");
            //Zusatz: War das Geburtsjahr ein Schaltjahr? 
            if (DateTime.IsLeapYear(birthday.Year)) //.Year ist ein Property/eine Eigenschaft auf welche das DateTime zugreifen kann 
            //Link: https://learn.microsoft.com/de-de/dotnet/api/system.datetime.year?view=net-9.0
            {
                System.Console.WriteLine($"Dein Geburtsjahr {birthday.Year} ist ein Schaltjahr.");
            }
            

            



             


        }
    }
}