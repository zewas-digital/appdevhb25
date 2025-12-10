using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe102
{
    public class Aufgabe102
    {
        public static void Start()
        {
            string databaseConnectionString;
            using (StreamReader reader = new StreamReader("/home/laura/Documents/appdevhb25/src/LauraKatharinaBertsch/secure/mysql-connection.env"))
            {
                databaseConnectionString = reader.ReadLine() ?? string.Empty;
            }
            databaseConnectionString += "Bibliotheksverwaltung";
            Console.WriteLine(databaseConnectionString);

            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    Bibliotheksverwaltung administration = new Bibliotheksverwaltung();
                    administration.connection = connection;

                    administration.ReadingBookNames();
                    foreach (string book in administration.books)
                    {
                        Console.WriteLine(book);
                    }
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
                Bibliotheksverwaltung books = new Bibliotheksverwaltung();
                books.connection = connection;

                Console.WriteLine("Gib ein Buchtitel ein:");
                string title = Console.ReadLine();
                books.LookingForBooks(title);
                Console.WriteLine("Das gefundene Buch:");
                foreach (string book in books.bookNames)
                {
                    Console.WriteLine(book);
                }
            }

        }
    }
}