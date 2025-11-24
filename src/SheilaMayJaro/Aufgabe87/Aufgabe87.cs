using System.Runtime.InteropServices;
using System.Security;

namespace Appdevhb25.SheilaMayJaro.Aufgabe87
{
    public class Aufgabe87
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 87)");
            //Erstelle eine Methode, mit der ein Abwesenheitseintrag zu einer Person hinzugefügt werden kann.
            //Erstelle eine Methode, mit der die Anzahl der Stunden, die eine Person gefehlt hat, berechnet werden kann.
            AbsenceList participantsAbsenceList = new AbsenceList();
            participantsAbsenceList.AddAbsenceEntry("Müller", new Absence(new DateTime(2025, 11, 19, 08, 00, 0), new DateTime(2025, 11, 19, 09, 25, 30)));
            participantsAbsenceList.AddAbsenceEntry("Fink", new Absence(new DateTime(2025, 11, 18, 07, 30, 0), new DateTime(2025, 11, 18, 09, 15, 0)));
            participantsAbsenceList.AddAbsenceEntry("Fink", new Absence(new DateTime(2025, 11, 10, 09, 30, 0), new DateTime(2025, 11, 10, 13, 12, 0)));
            participantsAbsenceList.AddAbsenceEntry("Kopf", new Absence(new DateTime(2025, 11, 18, 07, 30, 0), new DateTime(2025, 11, 18, 09, 15, 0)));
            //Zusammenrechnen der Abwesenheitsstunden
            Console.WriteLine($"Müller hat {participantsAbsenceList.HoursOfAbsence("Müller")} Abwesenheitsstunden.");
            Console.WriteLine($"Fink hat {participantsAbsenceList.HoursOfAbsence("Fink")} Abwesenheitsstunden.");
            Console.WriteLine($"Kopf hat {participantsAbsenceList.HoursOfAbsence("Kopf")} Abwesenheitsstunden.");
        }
    }
}