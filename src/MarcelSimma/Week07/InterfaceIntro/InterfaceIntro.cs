
namespace Appdevhb25.MarcelSimma.Week07.InterfaceIntro
{
    public class InterfaceIntro
    {
        public static void Start()
        {
            List<IGegenstand> inventarliste = new List<IGegenstand>();

            inventarliste.Add(new Auto(4));
            inventarliste.Add(new Motorrad("KTM"));
            inventarliste.Add(new Fotoapparat(23.12));


            // Man kann nur auf jene Memeber zugreifen, die über das Interface vorgeschrieben werden.
            foreach (IGegenstand element in inventarliste)
            {
                System.Console.WriteLine(element.PrintGegenstand());
            }
        }
    }
}