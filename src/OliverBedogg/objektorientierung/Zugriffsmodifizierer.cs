
using System.ComponentModel;

namespace Appdevhb25.OliverBedogg.objektorientierung
{
    /*
    Offizielle Tabelle mit den Zugriffsmodifizierern
    https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
    
    public: von überall aus erreichbar; am wenigsten Schutz
    private: nur innerhalb der Klasse bzw. des Objektes erreichbar; am meisten Schutz
    protected: erweitert private insofern, dass auch erbende bzw. abgeleitet Klassen zugreifen können
    internal: Erlaubt den Zugriff von überall innerhalb des "Projektes"

    Zugriffsmodifizierer für Klassen innerhalb eines Namespace:
    https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs1527?f1url=%3FappId%3Droslyn%26k%3Dk(CS1527)
    
    public: auch von außerhalb der aktuellen Assembly erreichbar
    internal: nur innerhalb der aktuellen Assembly erreichbar
    Assembly = Projekt / kompiliertes .dll oder .exe

    Definition einer Assembly: https://learn.microsoft.com/en-us/dotnet/standard/assembly/
    
    */

    public class Zugriffsmodifizierer
    {

        public static void Start()
        {
            Console.WriteLine("Zugriffsmodifizierer -------------------");

            Person p = new Person("Anna", 28);
            Console.WriteLine("Name: "+ p.Name);            // Zugriff erlaubt [public]

            // Console.WriteLine(p.age);          // Fehler: 'age' ist private
            Console.WriteLine("Alter: "+ p.Age);             // Zugriff erlaubt [public getter]

            Console.WriteLine("InternalInfo: "+ p.InternalInfo);    // Zugriff im selben Assembly [internal]

            // Console.WriteLine(p.Secret);        // Fehler: 'Secret' ist protected
            Console.WriteLine("Persons Secret: "+ p.GetSecret());     // Methode bietet Zugriff auf protected-Feld

            Student s = new Student("Tom", 20);
            Console.WriteLine("Students Secret: "+ s.GetStudentSecret()); // Zugriff auf protected-Feld aus abgeleiteter Klasse
        }
    }
}