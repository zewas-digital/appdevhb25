// MySQL Package über das Terminal installieren
// cd in Programm-Verzeichnis
// dotnet add package MySql.Data

using System;
using MySql.Data.MySqlClient;

namespace Appdevhb25.SabrinaFeurstein.sql
{

    public class MysqlConnectExample
    {

        public static void Start()
        {
            // Verbindungsinformation
            string databaseConnectionString;

            using (StreamReader sr = new StreamReader(@"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein\aufgaben\secure\mysql-connections.env"))
            {
                databaseConnectionString = sr.ReadLine()!;
            }

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