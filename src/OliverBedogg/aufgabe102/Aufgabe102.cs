using System;
using MySql.Data.MySqlClient;

namespace Appdevhb25.OliverBedogg.aufgabe102
{

    public class Aufgabe102
    {

        public static void Start()
        {
            // Verbindungsinformation
            string databaseConnectionString; // die .env fällt über gitignore aus dem commit heraus
            using(StreamReader sr = new StreamReader("./../../../_secure/mysql-connection.env"))
            {
                databaseConnectionString = sr.ReadLine() ?? string.Empty;
            }
            // ergänze die Datenbank
            databaseConnectionString += "Bibliotheksverwaltung";

            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    Bibliotheksverwaltung verwaltung = new Bibliotheksverwaltung();
                    verwaltung.connection = connection;

                    verwaltung.LeseAlleBuecher();
                    foreach (string buch in verwaltung.buecher)
                    {
                        Console.WriteLine(buch);
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