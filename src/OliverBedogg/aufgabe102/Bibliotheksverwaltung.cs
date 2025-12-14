using System;
using MySql.Data.MySqlClient;

namespace Appdevhb25.OliverBedogg.aufgabe102
{
    public class Bibliotheksverwaltung
    {
        public MySqlConnection connection { private get; set; }
        public List<string> buecher { get; private set; } = new List<string>();

        public void LeseAlleBuecher()
        {
            string query = "SELECT titel FROM buch;";

            MySqlCommand command = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    buecher.Add(reader.GetString("titel"));
                }
            }
        }
    }
}