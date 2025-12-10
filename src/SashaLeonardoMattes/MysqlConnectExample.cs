// MySQL Package über das Terminal installieren
// cd in Programm-Verzeichnis
// dotnet add package MySql.Data

using System;
using MySql.Data.MySqlClient;
using ZstdSharp.Unsafe;

namespace Appdevhb25.SashaLeonardoMattes
{

    public class MysqlConnectExample
    {

        public static void Start()
        {
            // Verbindungsinformation
            string? pwd;
            using(StreamReader sr = new StreamReader(@"C:\Users\sasha.mattes\Documents\sqlConnection.txt"))
            {
                pwd = sr.ReadLine();
            }
            string databaseConnectionString = @$"
            server=127.0.0.1;
            port=3307;
            uid=root;
            pwd={pwd};
            database=mondial
            ";

            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = "SELECT * FROM country WHERE code like @code;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@code", "A%");

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString("name"));
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