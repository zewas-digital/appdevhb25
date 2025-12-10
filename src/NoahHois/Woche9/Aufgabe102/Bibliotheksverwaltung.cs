using System;
using MySql.Data.MySqlClient;

namespace Appdevhb25.NoahHois.Aufgabe102
{
    public class Bibliotheksverwaltung
    {
        public MySqlConnection connection { private get; set; }
        public List<string> books { get; private set; } = new List<string>();

        public void ReadAllBooks()
        {
            string query = "SELECT titel FROM buch";

            MySqlCommand command = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    books.Add(reader.GetString("titel"));
                }
            }
        }
    }
}