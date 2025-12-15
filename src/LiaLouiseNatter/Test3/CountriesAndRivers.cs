namespace Appdevhb25.LiaLouiseNatter.Test3
{
    public class CountriesAndRivers
    {
        public static void Start()
        {
         
            string code = "A";
            SqlDataGetter sqlDataGetter = new SqlDataGetter();
            sqlDataGetter.getData(code); // Österreich

            System.Console.WriteLine($"Flüsse in {code}");
            System.Console.WriteLine("-------------------------------");
            double riverLengthSum = 0;
            foreach(River riverdata in sqlDataGetter.RiversNameLength)
            {
                riverLengthSum += riverdata.Length;
                System.Console.WriteLine($"{riverdata.Name, 5}{riverdata.Length, 2}km");
            }
            System.Console.WriteLine("-------------------------------");
            
            System.Console.WriteLine($"Gesamtlänge: {riverLengthSum, -16}");

        }
    }
}