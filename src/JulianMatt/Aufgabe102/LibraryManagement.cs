using System;
using System.ComponentModel;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;

namespace Appdevhb25.JulianMatt.Augabe102
{

    public class LibraryManagement
    {
        public List<string> Titel { get; private set; }

        public List<string> FoundBook { get; private set; }

        public void ReadOutBook()
        {

            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=Livercheese4Life!;
            database=bibliotheksverwaltung2
            ";

            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Titel FROM buch";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    Titel = new List<string>();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Titel.Add(reader.GetString("Titel"));
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public void SearchForBook(string input)
        {
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=Livercheese4Life!;
            database=bibliotheksverwaltung2
            ";

            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();


                    string query = "SELECT Titel FROM buch Where Titel Like @code;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@code", "%" + input + "%");

                    FoundBook = new List<string>();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FoundBook.Add(reader.GetString("Titel"));
                        }
                    }


                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
    }
}