using MySql.Data.MySqlClient;
namespace Appdevhb25.SheilaMayJaro.AufgabeZoo
{
    public class Connection
    {
        public static string DatabaseConnectionString { get; private set; } = @"
            server=127.0.0.1;
            uid=root;
            pwd=my-secret-pw; 
            database=zoo
            ";
        public static void Start()
        {
            Connection connectingDatabase = new Connection();
            connectingDatabase.ConnectingWithMySQL(DatabaseConnectionString);
        }
        public void ConnectingWithMySQL(string databaseConnectionString)
        {
            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM zoo;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@code", "A%");

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString("name"));
                        }
                    }
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
        internal static void InsertAttributesToRelationshipTableAnimalFood(List<Animal> animals) // doch zu Food??? Oder Enclosure??? keine Ahnung zu welcher Klasse hinzufügen...
        {
            using (MySqlConnection connection = new MySqlConnection(Connection.DatabaseConnectionString))
            {
                try
                {
                    connection.Open();
                    Dictionary<string, int> animalNamesAndIds = new Dictionary<string, int>();
                    string query = "Select AnimalID, Name from animal"; //ID von der Tabelle animal auslesen und in einer Variablen speichern
                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            animalNamesAndIds.Add(reader.GetString("Name"), reader.GetInt32("AnimalID"));
                        }
                    }
                    query = @"Insert into animal_food (Amount, AnimalID, EAN, Unit) VALUES (@amount, @animalId, @ean, @unit) On duplicate key update Amount = @amount, Unit = @unit;";
                    command = new MySqlCommand(query, connection);
                    foreach (Animal animal in animals)
                    {
                        foreach (KeyValuePair<Food, double> item in animal.FodderRequirements)
                        {
                            command.Parameters.Clear(); //damit jeder Durchlauf mit einer leeren Parameterliste startet, ansonsten ist diese schon definiert 
                            command.Parameters.AddWithValue("@animalId", animalNamesAndIds[animal.Name]);
                            command.Parameters.AddWithValue("@ean", item.Key.EAN);
                            command.Parameters.AddWithValue("@amount", item.Value);
                            command.Parameters.AddWithValue("@unit", item.Key.Unit);
                            command.ExecuteNonQuery();
                        }
                    }
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
        internal static void InsertAttributesToTableEnclosure(string name)
        {
            using (MySqlConnection connection = new MySqlConnection(Connection.DatabaseConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO enclosure (Name) VALUES (@Name)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
        internal static void InsertAttributesToTableZoo(string name, DateTime year)
        {
            using (MySqlConnection connection = new MySqlConnection(Connection.DatabaseConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO zoo (Name, FoundingYear) VALUES (@Name, @FoundingYear)";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@code", "A%");
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@FoundingYear", year);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
        internal static void InsertAttributesToTableAnimal(string name, string species)
        {
            using (MySqlConnection connection = new MySqlConnection(Connection.DatabaseConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO animal (Name, Species) VALUES (@Name, @Species)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Species", species);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
        internal static void InsertAttributesToTableFood(string name, string unit, double unitPrice, int EAN)
        {
            using (MySqlConnection connection = new MySqlConnection(Connection.DatabaseConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO food (EAN, Name, Unit, Unitprice) VALUES (@ean, @Name, @Unit, @UnitPrice)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ean", EAN);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Unit", unit);
                    command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
        internal static void InsertAttributesToTableCareGiver(string name)
        {
            using (MySqlConnection connection = new MySqlConnection(Connection.DatabaseConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"INSERT INTO zookeeper (Name) VALUES (@Name)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
        public static void InsertAttributesToRelationshipTableEnclosureZookeeper(List<CareGiver> listCareGiver)
        {
            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(DatabaseConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM zookeeper;";
                    Dictionary<string, int> zooKeeperNamesAndIDs = new Dictionary<string, int>();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            zooKeeperNamesAndIDs.Add(reader.GetString("Name"), reader.GetInt32("ZooKeeperID"));
                        }
                    }
                    query = "SELECT * FROM enclosure;";
                    Dictionary<string, int> enclosureNamesAndIDs = new Dictionary<string, int>();
                    command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            enclosureNamesAndIDs.Add(reader.GetString("Name"), reader.GetInt32("EnclosureID"));
                        }
                    }
                    query = "Insert into zookeeper_enclosure (ZookeeperID, EnclosureID) VALUES (@zookeeperid, @enclosureid)";
                    command = new MySqlCommand(query, connection);
                    foreach (CareGiver careGiver in listCareGiver)
                    {
                        foreach (Enclosure enclosure in careGiver.enclosuresToDo)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@zookeeperid", zooKeeperNamesAndIDs[careGiver.Name]);
                            command.Parameters.AddWithValue("@enclosureid", enclosureNamesAndIDs[enclosure.Name]);
                            command.ExecuteNonQuery();
                        }
                    }
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
    }
}



