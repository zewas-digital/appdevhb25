using System; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe29
{
    public class ParticipantsTwo
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 29)");
            PrintParticipants(); 
        }
        public static void PrintParticipants()
        {
            string[] participants = new string[13];
            participants[0] = "Jona";
            participants[1] = "Julian";
            participants[2] = "Katja";
            participants[3] = "Kerim";
            participants[4] = "Laura";
            participants[5] = "Lia";
            participants[6] = "Noah";
            participants[7] = "Sabrina";
            participants[8] = "Sasha";
            participants[9] = "Selin";
            participants[10] = "Sheila";
            participants[11] = "Marcel";
            participants[12] = "Oliver"; 

            for (int i = 0; i < participants.Length; i++)
            {
                Console.WriteLine(participants[i]);
            }
            Console.WriteLine($"Anzahl der Teilnehmer {participants.Length}"); 
        }
    }
}