using MySql.Data.MySqlClient;
namespace Appdevhb25.LiaLouiseNatter.Aufgabe102;
public class DbReadIntoOOP
{
    private List<string> searchedBooks = new List<string>();
    public List<string> SearchedBooks
    {
        get
        {
            return searchedBooks;
        }
    }

    private List<string> books = new List<string>();
    public List<string> Books
    {
        get
        {
            return books;
        }
    }
    private string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=;
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
                        books.Add(reader.GetString("titel"));
                    }
                }
                foreach(string book in Books)
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

    public void searchBooks(string searchTerm)
    {
        using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
        {
            try
            {
                connection.Open();
                string searchBooksTerm = "Select titel from buch where titel Like @titel;";
                MySqlCommand searchBookCommand = new MySqlCommand(searchBooksTerm, connection);
                searchBookCommand.Parameters.AddWithValue("@titel", "%" + searchTerm + "%");

                using (MySqlDataReader reader = searchBookCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        searchedBooks.Add(reader.GetString("Titel"));
                    }
                }
                foreach(string book in SearchedBooks)
                {
                    System.Console.WriteLine($"Buch: {book}");
                }

            }
            catch
            {
                System.Console.WriteLine("Fehler");
            }
        }
        
    }
}