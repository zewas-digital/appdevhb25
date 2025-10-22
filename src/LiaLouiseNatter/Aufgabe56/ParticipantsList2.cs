using System;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe56
{
    public class ParticipantsList2
    {
        public static void Start()
        {
            ParticipantReader();
        }

        private static void ParticipantReader()
        {
            string outputFile = @"C:\Projekte\Kurs\appdevhb25\src\LiaLouiseNatter\Files\ParticipantsOutput.txt";
            string[] names = File.ReadAllLines(@"C:\Projekte\Kurs\appdevhb25\src\LiaLouiseNatter\Files\Participants.txt");

            for (int i = 0; i < names.Length; i++)
            {
                System.Console.WriteLine($"{i + 1}.  {names[i]}");
            }


            for (int i = 0; i < names.Length; i++)
            {
                File.AppendAllText(outputFile, names[i]);
                File.AppendAllText(outputFile, "\n");
            }
            File.AppendAllText(outputFile, names.Length + "Teilnehmer");
        }
        
        

       


        


    }
}

