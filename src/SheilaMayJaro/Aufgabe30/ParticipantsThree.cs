using System; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe30
{
    public class ParticipantsThree
    {
        public static void Start()
        {
            PrintParticipants();
            Console.WriteLine("Aufgabe 30a)");
            InputParticipants();
            Console.WriteLine("Aufgabe 30b");
            InputParticipantsTwo(); 


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
        public static void InputParticipants()
        {
            string[] participants = new string[5];
            Console.WriteLine($"Fügen Sie bitte Ihre {participants.Length} Teilnehmer ein.");
            for (int i = 0; i < participants.Length; i++)
            {
                participants[i] = Console.ReadLine();
            }
            Console.WriteLine("Ihre eingefügten Teilnehmer:");
            for (int j = 0; j < participants.Length; j++)
            {
                Console.WriteLine(participants[j]);
            }
            Console.WriteLine($"Anzahl der Teilnehmer {participants.Length}");
        }
        public static void InputParticipantsTwo()
        {
            string temp = Console.ReadLine();

            if (int.TryParse(temp, out int participantsNumber))
            {
                string[] participants = new string[participantsNumber];

                for (int i = 0; i < participants.Length; i++)
                {
                    participants[i] = Console.ReadLine();
                }
                Console.WriteLine("Ihre eingefügten Teilnehmer:");
                for (int j = 0; j < participants.Length; j++)
                {
                    Console.WriteLine(participants[j]);
                }
                Console.WriteLine($"Anzahl der Teilnehmer {participants.Length}");
            }
            else
            {
                Console.WriteLine("Falsche Angabe!");
            }
            
        }
    }
}