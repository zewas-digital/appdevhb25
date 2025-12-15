using Appdevhb25.LauraKatharinaBertsch.sql;
using MySql.Data.MySqlClient;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe102
{
    public class Bibliotheksverwaltung
    {
        public List<string> books { get; set; } = new List<string>();
        public List<string> bookNames { get; set; } = new List<string>();

        public MySqlConnection connection { get; set; }

        public void ReadingBookNames()
        {
            string query = "SELECT Titel FROM Buch;";
            MySqlCommand command = new MySqlCommand(query, connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    books.Add(reader.GetString("Titel"));
                }
            }
        }
        public void LookingForBooks(string bookName)
        {
            string query = "SELECT Titel FROM Buch WHERE Titel LIKE @Titel";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Titel", bookName);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    bookNames.Add(reader.GetString("Titel"));
                }
            }
        }
    }
}