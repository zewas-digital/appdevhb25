using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;


namespace Appdevhb25.SashaLeonardoMattes.Aufgabe103
{

    public class LibraryManager
    {
        private List<Book> books = new List<Book>();

        public List<Book> Books
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
                    string query = "SELECT * FROM buch";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {                                
                            Book b = new Book(); 
                            b.ISBN = reader.GetString("ISBN");
                            b.Title = reader.GetString("Titel");
                            b.Releaseyear = Convert.ToInt16(reader.GetInt32("Erscheinungsjahr"));
                            b.Publisher = reader.GetString("Verlag");
                            b.Language = reader.GetString("Sprache");
                            b.Author = Convert.ToInt16(reader.GetInt32("Autor"));
                            books.Add(b);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
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
