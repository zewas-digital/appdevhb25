using System.Globalization;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe74
{
    public class Liste
    {
        Random rnd = new Random();
        private List<int> randomNumbers = new List<int>();
        private  int evenNumberCount;

        public List<int> randomNumberMaker()
        {
            for (int i = 0; i < 20; i++)
            {
                randomNumbers.Add(rnd.Next(1,9));
            }
            return randomNumbers;
        }

        public int CountEven()
        {
            foreach (int number in randomNumbers)
            {
                if (number % 2 == 0)
                {
                    evenNumberCount++;
                }
            }
            return evenNumberCount;
        }

        public int SmallestNumber()
        {
            int minNumber = randomNumbers.Min();
            int smallestNum = randomNumbers[0];
            foreach (int number in randomNumbers)
            {
                if (number < smallestNum)
                {
                    smallestNum = number;
                }
            }
            return minNumber;
        }

        public int BiggestNumber()
        {
            int maxNumber = randomNumbers.Max();
            int biggestNum = randomNumbers[0];
            foreach (int number in randomNumbers)
            {
                if (number > biggestNum)
                {
                    biggestNum = number;
                }
            }
            return maxNumber;
        }

        public List<int> SortDesc()
        {
            randomNumbers.Sort();
            randomNumbers.Reverse();
            return randomNumbers;
        }

        public List<int> DeleteUnevenNum()
        {
            randomNumbers.RemoveAll( number => number % 2 != 0);
            return randomNumbers;
        }

        public void ListPrinter(List<int> userList)
        {
            foreach (int number in userList)
            {
                System.Console.Write(number);
            }
        }
        
        public void numberPrinter(int number)
        {
            System.Console.WriteLine(number);
        }
    }
}