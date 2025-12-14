using MySql.Data.MySqlClient;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe102
{
    public class Aufgabe102
    {
        public static void Start()
        {
            Bibliotheksverwaltung bibliotheksverwaltung = new Bibliotheksverwaltung();

            string databaseConnectionString;

            using (StreamReader sr = new StreamReader(@"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein\secure\bibliotheksverwaltung-connection.env"))
            {
                databaseConnectionString = sr.ReadLine()!;
            }

            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();
                    bibliotheksverwaltung.Connection = connection;
                    bibliotheksverwaltung.BuecherInListeSpeichern();

                    foreach (var buch in bibliotheksverwaltung.Buecher)
                    {
                        Console.WriteLine(buch);
                    }

                    Console.Write("\nNach Buch suchen: ");

                    foreach (var buch in bibliotheksverwaltung.BuecherSuche(Console.ReadLine()!))
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