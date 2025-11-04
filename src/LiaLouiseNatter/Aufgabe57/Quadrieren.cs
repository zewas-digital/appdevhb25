using System;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe57
{
    public class Quadrieren
    {
        public static void Start()
        {
            QuadrierenFromFile();
        }

        public static void QuadrierenFromFile()
        {
            using (StreamReader FileReader = new StreamReader(@"C:\Projekte\Kurs\appdevhb25\src\LiaLouiseNatter\Files\QuadrierenInput.txt"))
            using (StreamWriter FileWriter = new StreamWriter(@"C:\Projekte\Kurs\appdevhb25\src\LiaLouiseNatter\Files\QuadrierenOutput.txt"))
            {
                string line;
                while ((line = FileReader.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    int zahl = int.Parse(line);
                    int result = zahl * zahl;
                    FileWriter.WriteLine($"{line} * {line} = {result}");
                    

                }
            }
            
            

        }
        




        


    }
}

