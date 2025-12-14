using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;

namespace Appdevhb25.JulianMatt.JulianMatt;

public class CountriesAndRivers
{
    private double OverallLength;

    private string CountryCode;
    private Dictionary<string, double> RiverInformation = new Dictionary<string, double>();
    public void GetDictionary()
    {

        System.Console.WriteLine("In Welchem Land wollen sie nach Flüßen suchen geben sie dafür den Länder Code ein zb(Österreich = A)");
        CountryCode = Console.ReadLine();

        string databaseCode = @"
        server=127.0.0.1;
        uid=root;
        pwd=Livercheese4Life!;
        database=Mondial
        ";

        using (MySqlConnection con = new MySqlConnection(databaseCode))
        {
            try
            {
                con.Open();

                string query = $@"Select Distinct gr.river, gr.country, r.length From geo_river gr Left Join River r On r.name = gr.river Where gr.country = @code Order by r.length DESC;";

                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("@code", CountryCode);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RiverInformation.Add(reader.GetString("river"), reader.GetDouble("length"));
                    }
                }


            }
            catch (MySqlException exit)
            {
                Console.Write(exit.Message);
            }
        }

    }

    private void GetOverallLength()
    {
        foreach (var lenght in RiverInformation)
        {
            OverallLength += lenght.Value;
        }
    }

    public void PrintInformation()
    {
        GetOverallLength();
        string line = new string('-', 23);

        System.Console.WriteLine($"Flüsse in {CountryCode}");
        System.Console.WriteLine(line);

        foreach (var river in RiverInformation)
        {
            System.Console.WriteLine("{0, -14} {1, 7}", $"{river.Key}", $"{river.Value} km");
        }

        System.Console.WriteLine(line);
        System.Console.WriteLine("{0, -14} {1, 7}", "Gesamtlänge:", $"{OverallLength} km");

    }
}