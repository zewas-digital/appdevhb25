using MySql.Data.MySqlClient;

namespace Appdevhb25.SheilaMayJaro.Aufgabe102
{
    public class Aufgabe102
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 102)");
            // Verbindungsinformation - Passwort muss dann noch eingegeben werden
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=; 
            database=Bibliotheksverwaltung
            ";
        LibraryManagement libraryManagement = new LibraryManagement();
        libraryManagement.GetTitles(databaseConnectionString);
        libraryManagement.DisplayAllTitles();
        System.Console.WriteLine();
        libraryManagement.SearchTitle(databaseConnectionString);
        libraryManagement.DisplayFoundTitles();
        }
    }
}