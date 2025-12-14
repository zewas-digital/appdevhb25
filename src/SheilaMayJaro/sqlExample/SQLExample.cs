// MySQL Package über das Terminal installieren
// cd in Programm-Verzeichnis
// dotnet add package MySql.Data

using System;
using MySql.Data.MySqlClient;

namespace Appdevhb25.SheilaMayJaro.sqlExample
{
    public class MysqlConnectExample
    {
        public static void Start()
        {
            // Verbindungsinformation
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=my-secret-pw;
            database=Mondial
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
                        while (reader.Read()) //returns true, wenn es nichts mehr zum Auslesen gibt, returns false und Schleife bricht ab
                        {
                            Console.WriteLine(reader.GetString("name")); //Auslesen konkret auf die Feldbezeichnung "name"
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