using System.Security.Cryptography;

namespace Appdevhb25.SheilaMayJaro.Aufgabe86
{
    public class Call
    {
        private string? _firstName;
        private string? _lastName;
        private string? _phoneNumber;
        public string? FirstName
        {
            get{return _firstName;}
            set{_firstName = value;}
        }
        public string? LastName
        {
            get{return _lastName;}
            set{_lastName = value;}
        }
        public string? PhoneNumber
        {
            get{return _phoneNumber;}
            set{_phoneNumber = value;}
        }
        public DateTime callTime = DateTime.Now;
        public Queue<Call> answeringMachine = new Queue<Call>();

        public Call(string lastName, string phoneNumber)
        {
            _lastName = lastName;
            _phoneNumber = phoneNumber;
        }
        public Call()
        {
            
        }
        public void AddCall(Call call)
        {
            answeringMachine.Enqueue(call);
        }
        public void ListeningToCalls()
        {
            do
            {
                Call call = answeringMachine.Dequeue();
                Console.WriteLine($"{call._firstName} {call._lastName} mit der Telefonnummer {call._phoneNumber} hat am {call.callTime} angerufen.");
            } while (answeringMachine.Count != 0);
        }
    }
}