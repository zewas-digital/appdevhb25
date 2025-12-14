using System;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe103
{
    public class LibraryManagerCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            LibraryManager l1 = new LibraryManager();
            l1.GetBooks();
            System.Console.WriteLine("-------------------------Bücher-------------------------");
            foreach (var item in l1.Books)
            {
                System.Console.WriteLine(item.Title + " " + item.ISBN);
            }
            System.Console.WriteLine("-------------------------Bücher:-------------------------");

            System.Console.WriteLine("Gib ein Buch ein, das du suchen willst");
            string toSearch = Helper.checkUserInputString();
            //List<string> booksFound = l1.SearchBooks(toSearch);
            System.Console.WriteLine("-------------------------gefundene Bücher:-------------------------");
            //foreach (var item in booksFound)
            {
                //System.Console.WriteLine(item);
            }
            System.Console.WriteLine("-------------------------gefundene Bücher:-------------------------");
        }

        
        
    }
}
