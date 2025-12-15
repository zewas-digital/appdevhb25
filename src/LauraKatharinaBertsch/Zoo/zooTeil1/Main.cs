namespace Appdevhb25.LauraKatharinaBertsch.ZooTeil1
{
    public class Main
    {
        public static void Start()
        {
           
            Zoo zoo = new Zoo("Tiergarten BlaBla", 2025);

            Console.WriteLine(zoo);
            Zoo.AddEnclosure();

            foreach (Enclosure e in Zoo.enclosures)
            {
                Console.WriteLine(e);
            }
        }
    }
}