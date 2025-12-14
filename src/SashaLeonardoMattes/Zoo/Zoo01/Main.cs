using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.AufgabeZoo01
{
    public class Main
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Tiergarten Dornbirn", 2022);
            zoo.AddEnclosure(new Enclosure("Alpenwiese"));
            zoo.AddEnclosure(new Enclosure("Ried"));
            zoo.AddEnclosure(new Enclosure("Terrarium (warm)"));

            System.Console.WriteLine(zoo.ToString());
        }       
    }
}