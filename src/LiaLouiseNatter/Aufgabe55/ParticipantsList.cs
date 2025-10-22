using System;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe55
{
    public class ParticipantsList
    {
        public static void Start()
        {
            ParticipantReader();
        }
        
        private static void ParticipantReader()
        {
            string[] names = File.ReadAllLines(@"C:\Projekte\Kurs\appdevhb25\src\LiaLouiseNatter\Files\Participants.txt");

            for(int i = 0; i < names.Length; i++)
            {
                System.Console.WriteLine($"{i+1}.  {names[i]}");
            }
        }

       


        


    }
}

