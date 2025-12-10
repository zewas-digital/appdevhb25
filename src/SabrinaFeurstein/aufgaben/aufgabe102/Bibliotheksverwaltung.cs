using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe102
{
    public class Bibliotheksverwaltung
    {
        public MySqlConnection? Connection { private get; set; }
        public List<string> Buecher { get; private set; } = new List<string>();

        public void BuecherInListeSpeichern()
        {
            string query = "SELECT * FROM buch;";

            MySqlCommand command = new MySqlCommand(query, Connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Buecher.Add(reader.GetString("titel"));
                }
            }
        }

        public List<string> BuecherSuche(string suche)
        {
            List<string> gefundeneBuecher = new List<string>();

            string query = "SELECT * FROM buch;";

            MySqlCommand command = new MySqlCommand(query, Connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader.GetString("titel").Contains(suche, StringComparison.OrdinalIgnoreCase))
                        gefundeneBuecher.Add(reader.GetString("titel"));
                }
            }

            return gefundeneBuecher;
        }
    }
}