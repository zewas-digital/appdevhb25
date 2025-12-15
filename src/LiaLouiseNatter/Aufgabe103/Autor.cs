namespace Appdevhb25.LiaLouiseNatter.Aufgabe103;
using MySql.Data.MySqlClient;

public class Autor
{

    private List<string> authors = new List<string>();
    public List<string> Authors
    {
        get
        {
            return authors;
        }
    }
    private string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=1h|_|_Nu$€6ü1|/|;
            database=Bibliotheksverwaltung
            ";

    public void BookNames()
    {
        using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
        {
            try
            {
                connection.Open();
                string getBooksTerm = "Select Titel From buch;";
                MySqlCommand getAllBookTitel = new MySqlCommand(getBooksTerm, connection);

                using (MySqlDataReader reader = getAllBookTitel.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        authors.Add(reader.GetString("autoren"));
                    }
                }
                foreach(string book in Authors)
                {
                    System.Console.WriteLine(book);
                }
            }
            catch(MySqlException bum)
            {
                System.Console.WriteLine(bum);
            }
        }
    }
}