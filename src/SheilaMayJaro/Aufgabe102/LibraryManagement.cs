using System.Dynamic;
using MySql.Data.MySqlClient;

namespace Appdevhb25.SheilaMayJaro.Aufgabe102
{
    public class LibraryManagement
    {
        public List<string> BookTitles {get; private set;} = new List<string>();
        public List<string> FoundBookTitles {get; private set;} = new List<string>(); 
        public List<string> GetTitles(string databaseConnectionString)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = "SELECT * FROM Buch;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@code", "A%");

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) //returns true, wenn es nichts mehr zum Auslesen gibt, returns false und Schleife bricht ab
                        {
                            BookTitles.Add(reader.GetString("Titel"));
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
                return BookTitles; 
            }
        }
        public void DisplayAllTitles()
        {
            foreach (string item in BookTitles)
            {
                Console.WriteLine(item);
            }
        }
        public List<string> SearchTitle(string databaseConnectionString)
        {
            System.Console.WriteLine("Nach welchem Buch suchst du? Gib den Titel an.");
            string userInput = Console.ReadLine(); 
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = $"SELECT * FROM Buch WHERE Titel Like '{userInput}%';";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@code", "A%");

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) //returns true, wenn es nichts mehr zum Auslesen gibt, returns false und Schleife bricht ab
                        {
                            FoundBookTitles.Add(reader.GetString("Titel"));
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
                return FoundBookTitles;
            }
        }
        public void DisplayFoundTitles()
        {
            System.Console.WriteLine("Suchergebnisse:");
            foreach (string title in FoundBookTitles)
            {
                System.Console.WriteLine(title);
            }
        }
    }
}