namespace Appdevhb25.LiaLouiseNatter.Aufgabe84
{
    public class GegenstandStart
    {
        public static void Start()
        {
     
            Motorrad motorrad = new Motorrad(500,"Red", 200, 200, "AT3467890","4567");
            System.Console.WriteLine(motorrad.GegenstandInfo());

            Cars2 cars2 = new Cars2("blue", "AT23489", "2345");
            System.Console.WriteLine(cars2.GegenstandInfo());
            

        }
    }
}