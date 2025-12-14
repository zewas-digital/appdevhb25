using MySql.Data.MySqlClient;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe103
{
    public class Aufgabe103
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

                    bibliotheksverwaltung.LeseBuecher();
                    bibliotheksverwaltung.LeseAutoren();
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(bibliotheksverwaltung.Buecher[i]);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(bibliotheksverwaltung.Autoren[i]);
            }
        }
    }
}