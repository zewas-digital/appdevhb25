using MySql.Data.MySqlClient;
using Org.BouncyCastle.Security;
namespace Appdevhb25.LiaLouiseNatter.Test3
{
    public class SqlDataGetter
    {
        // Liste von Typ River
        public List<River> RiversNameLength{get; private set;}
        string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd= 1h|_|_Nu$€6ü1|/|;
            database=Mondial
            ";
        
        public void getData(string code)
        {
            /*
            using(StreamReader streamReader = new StreamReader(@"C:\Projekte\Kurs\appdevhb25\src\LiaLouiseNatter\Test3"))
            {
                databaseConnectionString = streamReader.ReadLine();
            }
            */

            using (MySqlConnection mySqlConnection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    // connection oeffnen und sql script ausführen
                    mySqlConnection.Open();
                    string querie = @"use mondial;
                                    select distinct river.Length, river.name
                                    from river 
                                        join geo_river gr 
                                            on river.name = gr.river
                                        join province p
                                            on gr.province = p.name
                                                And gr.country = p.country
                                        join country c 
                                            on p.country = c.code
                                    where c.code = @code
                                    order by river.length desc;";
                    MySqlCommand mySqlCommand = new MySqlCommand(querie, mySqlConnection);
                    mySqlCommand.Parameters.AddWithValue("@code", code);

                    // Zu liste hinzufügen
                    using(MySqlDataReader mySqlDataReader1 = mySqlCommand.ExecuteReader())
                    {
                        while (mySqlDataReader1.Read())
                        {
                            RiversNameLength.Add(new River(mySqlDataReader1.GetString("name"), mySqlDataReader1.GetDouble("length")));
                        }
                    }
                }
                catch(MySqlException)
                {
                    System.Console.WriteLine("Fehler");
                }
            }
        }

        
    }
}