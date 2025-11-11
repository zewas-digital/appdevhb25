namespace Appdevhb25.LiaLouiseNatter.Aufgabe74
{
    public class Start()
    {
        public static void ListStarter()
        {
            Liste liste = new Liste();
            System.Console.WriteLine("-----------------------Random Numbers-----------------------");
            List<int> randomList = liste.randomNumberMaker();
            liste.ListPrinter(randomList);
            System.Console.WriteLine("\n-----------------------Even numbers-----------------------");
            int evenNums = liste.CountEven();
            liste.numberPrinter(evenNums);
            System.Console.WriteLine("-----------------------Smallest number-----------------------");
            int smallNum = liste.SmallestNumber();
            liste.numberPrinter(smallNum);
            System.Console.WriteLine("-----------------------Biggest number-----------------------");
            int bigNUm = liste.BiggestNumber();
            liste.numberPrinter(bigNUm);
            System.Console.WriteLine("-----------------------Sort descending-----------------------");
            List<int> DescList = liste.SortDesc();
            liste.ListPrinter(DescList);
            System.Console.WriteLine("\n-----------------------Delete uneven numbers-----------------------");
            List<int> DeleteList = liste.DeleteUnevenNum();
            liste.ListPrinter(DeleteList);





            ListeZusammenfuehren listezsf = new ListeZusammenfuehren();
            
            System.Console.WriteLine("\n-----------------------1. List-----------------------");
            List<int> liste1 = listezsf.RandomNumberMaker();
            listezsf.ListSorter(liste1);
            listezsf.ListPrinter(liste1);
            

            System.Console.WriteLine("\n-----------------------2. List-----------------------");
            List<int> liste2 = listezsf.RandomNumberMaker();
            listezsf.ListSorter(liste2);
            listezsf.ListPrinter(liste2);

            
            System.Console.WriteLine("\n-----------------------Lists Added Together-----------------------");
            List<int> listsTogether = listezsf.PutListsTogether(liste1, liste2);
            listezsf.ListSorter(listsTogether);
            listezsf.ListPrinter(listsTogether);
     
            




            

        }
    }
}