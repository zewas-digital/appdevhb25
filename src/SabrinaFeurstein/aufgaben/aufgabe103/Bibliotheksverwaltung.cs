using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Agreement.Kdf;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe103
{
    public class Bibliotheksverwaltung
    {
        public MySqlConnection? Connection { private get; set; }
        public List<Buch> Buecher { get; private set; } = new List<Buch>();
        public List<Autor> Autoren { get; private set; } = new List<Autor>();

        public void LeseBuecher()
        {
            string query = "SELECT * FROM buch JOIN autor ON buch.autor = autor.id ORDER BY isbn ASC;";

            MySqlCommand command = new MySqlCommand(query, Connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string isbn = reader.GetString("isbn");
                    string titel = reader.GetString("titel");
                    int erscheinungsjahr = reader.GetInt32("erscheinungsjahr");
                    string verlag = reader.GetString("verlag");
                    string sprache = reader.GetString("sprache");
                    string nachname = reader.GetString("nachname");
                    string vorname = reader.GetString("vorname");
                    string autor = vorname + " " + nachname;

                    Buecher.Add(new Buch(isbn, titel, erscheinungsjahr, verlag, sprache, autor));
                }
            }
        }

        public void LeseAutoren()
        {
            string query = "SELECT * FROM autor;";

            MySqlCommand command = new MySqlCommand(query, Connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nachname = reader.GetString("nachname");
                    string vorname = reader.GetString("vorname");

                    Autoren.Add(new Autor(id, nachname, vorname));
                }
            }
        }
    }
}