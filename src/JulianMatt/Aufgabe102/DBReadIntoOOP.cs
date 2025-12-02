using System;
using System.ComponentModel;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;

namespace Appdevhb25.JulianMatt.Augabe102
{

    public class DBReadIntoOOP
    {
        public static void Start()
        {
            LibraryManagement libraryManagement = new LibraryManagement();

            libraryManagement.ReadOutBook();
            foreach (var entry in libraryManagement.Titel)
            {
                System.Console.WriteLine(entry);
            }

            System.Console.WriteLine("\n");

            System.Console.WriteLine("Nach welchem Buchtitel möchten Sie suchen?");
            string input = Console.ReadLine();
            libraryManagement.SearchForMovie(input);
            if (libraryManagement.FoundBook.Count == 0)
            {
                System.Console.WriteLine("Es wurde kein Buch gefunden");
            }
            else
            {
                foreach (var entry in libraryManagement.FoundBook)
                {
                    System.Console.WriteLine(entry);
                }
            }

        }

    }
}
