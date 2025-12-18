using System;
using MySql.Data.MySqlClient;
namespace Appdevhb25.SheilaMayJaro.Kompetenznachweis3
{
    public class CountriesAndRivers
    {
        public char CountryCode { get; private set; }
        public Dictionary<string, int> Rivers { get; private set; } = new Dictionary<string, int>();
        public Dictionary<string, int> GetRivers(string database)
        {
            using (MySqlConnection connection = new MySqlConnection(database))
            {
                try
                {
                    connection.Open();
                    // Datenbank Abfrage erstellen
                    string query = $@"Select distinct name, Length From river Inner Join geo_river on geo_river.river = river.name WHERE country = '{CountryCode}';";
                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@code", "A%");

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) //returns true, wenn es nichts mehr zum Auslesen gibt, returns false und Schleife bricht ab
                        {
                            Rivers.Add(
                                reader.GetString("name")
                                , reader.GetInt32("Length"));
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
                return Rivers;
            }
        }
        public int CalculateTotalLength()
        {
            int sum = 0; 
            foreach (KeyValuePair<string, int> item in Rivers)
            {
                sum += item.Value; 
            }
            return sum; 
        }
        public void DisplayRivers()
        {
            System.Console.WriteLine($"Flüsse in {CountryCode}");
            System.Console.WriteLine(new string('-', 50));
            foreach (KeyValuePair<string, int> item in Rivers)
            {
                
                System.Console.WriteLine($"{item.Key, -20} {item.Value, 10} km");
            }
            System.Console.WriteLine(new string('-', 60));
            Console.WriteLine($"Gesamtlänge: {CalculateTotalLength(), 18} km"); 
        }
        public static void Start()
        {
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=; 
            database=Mondial
            ";
            CountriesAndRivers countriesAndRivers = new CountriesAndRivers();
            countriesAndRivers.CountryCode = 'A'; 
            countriesAndRivers.GetRivers(databaseConnectionString);
            countriesAndRivers.DisplayRivers();
            
        }
    }
}