using System.ComponentModel;
using System.Globalization;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe86
{
    public class Callcenter
    {
        public static void Start()
        {
            Queue<MissedCall> missedCalls = new Queue<MissedCall>();

            Console.WriteLine("Hat eine Person angerufen? ja oder nein");

            if (Console.ReadLine() == "ja")
            {
                Console.WriteLine("Wie lautet der Name?");
                string name = Console.ReadLine();
                Console.WriteLine("Wie lautet ihre Telefonnummer?");
                string phonenumber = Console.ReadLine();
                missedCalls.Enqueue(new MissedCall(name, phonenumber));
                while (true)
                {
                    Console.WriteLine("Hat noch eine Person angerufen? ja oder nein");
                    if (Console.ReadLine() == "nein")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wie lautet der Name?");
                        name = Console.ReadLine();
                        Console.WriteLine("Wie lautet ihre Telefonnummer?");
                        phonenumber = Console.ReadLine();
                        missedCalls.Enqueue(new MissedCall(name, phonenumber));
                    }
                }
                while (missedCalls.Count > 0)
                {
                    Console.WriteLine("Möchtest du den verpassten Anruf zurückrufen? ja oder nein");
                    if (Console.ReadLine() == "ja")
                    {
                        Console.WriteLine();
                        missedCalls.Dequeue();
                        Console.WriteLine("Diese Anrufe sind noch offen:");
                        if (missedCalls.Count == 0)
                        {
                            Console.WriteLine("keine");
                        }
                        else
                        {
                            foreach (var m in missedCalls)
                            {
                                Console.WriteLine(m);
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        public class MissedCall
        {
            public DateTime CalledAt;
            public string Name { get; set; }
            public string Phonenumber { get; set; }

            public MissedCall(string name, string phonenumber)
            {
                CalledAt = DateTime.Now;
                Name = name;
                Phonenumber = phonenumber;
            }
            public override string ToString()
            {
                return Name + " " + Phonenumber + " " + CalledAt.ToString("dd.MM.yyyy hh:mm");
            }
        }
    }
}
