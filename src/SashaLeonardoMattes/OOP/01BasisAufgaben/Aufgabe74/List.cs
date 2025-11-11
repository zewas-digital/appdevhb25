using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe74
{
    public class List
    {
        public static Random rndGen = new Random();
        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);


            List<int> list1 = new List<int>();

            FillList(list1);
            System.Console.Write("Liste: ");
            PrintList(list1);

            System.Console.WriteLine("\nKleinste Zahl: " + getSmallest(list1));
            System.Console.WriteLine("Größte Zahl: " + getBiggest(list1));

            list1 = SortDesc(list1);

            System.Console.Write("Liste absteigend sortiert: ");
            PrintList(list1);

            list1 = RemoveOdd(list1);

            System.Console.Write("\nListe ohne ungerde Zahlen: ");
            PrintList(list1);

            List<int> list2 = new List<int>();

            FillList(list2);
            list2.Sort();

            List<int> list3 = new List<int>();

            FillList(list3);
            list3.Sort();

            List<int> list4 = new List<int>();
            list4.AddRange(list2);
            list4.AddRange(list3);
            list4.Sort();

            System.Console.Write("\nListe aus 2 Listen: ");
            PrintList(list4);



        }

        public static void PrintList(List<int> list)
        {
            foreach (int number in list)
            {
                System.Console.Write(number + " ");
            }
        }

        public static List<int> FillList(List<int> list)
        {
            for (int i = 0; i < 20; i++)
            {
                list.Add(rndGen.Next(0, 100));
            }
            return list;
        }

        public static int getAmountEvenNumbers(List<int> list)
        {
            int result = 0;
            foreach (var item in list)
            {
                if (item % 2 == 0)
                {
                    result++;
                }
            }
            return result;
        }

        public static int getSmallest(List<int> list)
        {
            return list.Min();
        }

        public static int getBiggest(List<int> list)
        {
            return list.Max();
        }

        public static List<int> SortDesc(List<int> list)
        {
            list.Sort();
            list.Reverse();
            return list;
        }
        
        public static List<int> RemoveOdd(List<int> list)
        {
            list.RemoveAll(n => n % 2 == 1);
            return list;
        }
    }
}
