using System;
using MySql.Data.MySqlClient;

namespace Appdevhb25.NoahHois.Aufgabe102
{
    public class DBReadIntoOOP
    {
        public static void Start()
        {
            string databaseConnectionString;
            using (StreamReader sr = new StreamReader("./../../../_secure/mysql-connection.env"))
            {
                databaseConnectionString = sr.ReadLine() ?? string.Empty;
            }

            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    Bibliotheksverwaltung administration = new Bibliotheksverwaltung();
                    administration.connection = connection;

                    administration.ReadAllBooks();
                    foreach (string buch in administration.books)
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