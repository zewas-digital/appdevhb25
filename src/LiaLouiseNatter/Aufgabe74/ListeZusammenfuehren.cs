using System.Globalization;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe74
{
    public class ListeZusammenfuehren
    {
        Random rnd = new Random();
        

        public List<int> RandomNumberMaker()
        {
            
            List<int> randomNumbers = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                randomNumbers.Add(rnd.Next(1, 9));
            }
            return randomNumbers;
        }
        
        public List<int> ListSorter(List<int> list)
        {
            list.Sort();
            list.Reverse();
            return list;
        }

        public List<int> PutListsTogether(List<int> list1, List<int> list2)
        {
            List<int> addedList = new List<int>();
            addedList.AddRange(list1);
            addedList.AddRange(list2);
            ListSorter(addedList);
            return addedList;
        }
        
        public void ListPrinter(List<int> userList)
        {
            foreach (int number in userList)
            {
                System.Console.Write(number);
            }
        }
        

    }
}