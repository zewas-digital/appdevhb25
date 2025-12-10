using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;


namespace Appdevhb25.SashaLeonardoMattes.Aufgabe102
{

    public class LibraryManager
    {
        private List<string> books = new List<string>();

        public List<string> Books
        {
            get
            {
                return books;
            }
        }

        public void GetBooks()
        {
            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = "SELECT Titel FROM buch";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(reader.GetString("Titel"));
                        }
                    }

                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public List<string> SearchBooks(string titleToSearch)
        {
            List<string> result = new List<string>();
            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = $"SELECT Titel FROM buch WHERE Titel LIKE @code";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@code", "%" + titleToSearch + "%");

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(reader.GetString("Titel"));
                        }
                    }

                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }

            return result;
        }

        private string getConnectionString()
        {
            string? pwd;
            using(StreamReader sr = new StreamReader(@"C:\Users\sasha.mattes\Documents\sqlConnection.txt"))
            {
                pwd = sr.ReadLine();
            }

            return @$"
            server=127.0.0.1;
            port=3307;
            uid=root;
            pwd={pwd};
            database=bibliotheksverwaltung
            ";
        }

    }
}
