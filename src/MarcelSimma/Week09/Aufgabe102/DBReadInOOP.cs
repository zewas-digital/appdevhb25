// get MySQL Package: 'dotnet add package MySql.Data --version 9.1.0'

using System;
using MySql.Data.MySqlClient;


namespace Appdevhb25.MarcelSimma.Week09.Aufgabe102
{

    public class MysqlConnectExample
    {

        public static void Start()
        {
            // Verbindungsinformation
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=abcd1234!;
            database=Bibliotheksverwaltung
            ";

            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {

                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = "SELECT * FROM Autor WHERE Nachname LIKE @nachname;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@nachname", "CO%");

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString("vorname"));
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