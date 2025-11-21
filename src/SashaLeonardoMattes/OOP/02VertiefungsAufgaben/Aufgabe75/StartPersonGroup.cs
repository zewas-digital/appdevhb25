using System;
using System.Runtime.InteropServices;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe75
{
    public class PersonGroupCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            Person p1 = new Person("a", 10, 100, 50);
            Person p2 = new Person("b", 20, 200, 60);
            Person p3 = new Person("c", 30, 300, 70);
            Group g1 = new Group();
            g1.AddPerson(p1);
            g1.AddPerson(p2);
            g1.AddPerson(p3);
            Person p4 = new Person("d", 40, 400, 80);
            Person p5 = new Person("e", 50, 500, 90);
            Person p6 = new Person("f", 60, 600, 100);
            Group g2 = new Group();
            g2.AddPerson(p4);
            g2.AddPerson(p5);
            g2.AddPerson(p6);

            System.Console.WriteLine(g1.GetBiggest());
             System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine(g1.GetSmallest());
             System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine(g1.GetAverage());

            System.Console.WriteLine("----------------------------------------------------------------");

            System.Console.WriteLine(g2.GetBiggest());
             System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine(g2.GetSmallest());
             System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine(g2.GetAverage());

        }
    }
}
