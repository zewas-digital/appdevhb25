using System;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace Appdevhb25.SelinUlutuerk.Aufgabe102
{
    class Bibliotheksverwaltung
    {
        public List<string> Buecher { get; private set; } = new List<string>();

        private string _connectionString;

        public Bibliotheksverwaltung()
        {
            // Verbindungsinformation
            using (StreamReader sr = new StreamReader(@"..\..\..\SQLAufgaben\Basisaufgaben\Aufgabe102\_secure\mysql-connection.env"))
            {
                _connectionString = sr.ReadLine() ?? string.Empty;
            }
        }

        // Bücher laden
        public void LadenDerBuecher()
        {
            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = "SELECT Titel FROM buch;";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Buecher.Add(new string(reader.GetString("Titel")));
                        }
                    }
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        // Buch suchen
        public List<string> SucheBuecher(string suchbegriff)
        {
            List<string> ergebnis = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = "SELECT Titel FROM buch Where Titel Like @code;";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@code", "%" + suchbegriff + "%");


                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ergebnis.Add(new string(reader.GetString("Titel")));
                        }
                    }
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
            return ergebnis;
        }
    }
}