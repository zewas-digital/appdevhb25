using System;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe103
{
    class Bibliotheksverwaltung
    {
        public List<Buch> Buecher { get; private set; } = new List<Buch>();
        public List<Autor> Autoren { get; private set; } = new List<Autor>();


        private string _connectionString;

        public Bibliotheksverwaltung()
        {
            // Verbindungsinformation
            using (StreamReader sr = new StreamReader(@"..\..\..\SQLAufgaben\Basisaufgaben\Aufgabe102\_secure\mysql-connection.env"))
            {
                _connectionString = sr.ReadLine() ?? string.Empty;
            }
        }

        // Bücher lesen
        public void LeseBuecher()
        {
            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = "SELECT ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor FROM buch;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int autorId = reader.GetInt32("Autor");

                            Autor? autorObj = Autoren.FirstOrDefault(a => a.ID == autorId);

                            Buch b = new Buch(
                                reader.GetString("ISBN"),
                                reader.GetString("Titel"),
                                reader.GetInt32("Erscheinungsjahr"),
                                reader.GetString("Verlag"),
                                reader.GetString("Sprache"),
                                autorObj
                            );

                            Buecher.Add(b);
                        }
                    }
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public void LeseAutoren()
        {
            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = "SELECT ID, Vorname, Nachname FROM Autor;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Autor a = new Autor(
                                reader.GetInt32("ID"),
                                reader.GetString("Vorname"),
                                reader.GetString("Nachname")
                            );

                            Autoren.Add(a);
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