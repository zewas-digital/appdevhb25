namespace Appdevhb25.KerimAlkis.Aufgabe19
{   
    public class Fuehrerschein
    {
        public static void Start()
        {
            AgeChecker();

        }

        public static void AgeChecker()
        {

            bool moped = false;
            bool car = false;

            

            Console.Write("Please enter your Age: ");
            int age;
            
            while (!int.TryParse(Console.ReadLine(), out age) || int.IsNegative(age))
            {
                Console.WriteLine("Enter a valid age!");
            }

            Console.Write("Please enter your name: ");
            string? name;
            do
            {
                name = Console.ReadLine();
              
                if (int.TryParse(name, out int n))
                {
                    Console.Write("Enter a valid name!");
                }
                //else { break; }
            } while (true || string.IsNullOrEmpty(name));


            if (age >= 15 && age < 18)
            {
                moped = true;
                car = false;
            }
            if (age >= 18)
            {
                moped = true;
                car = true;
            }

            if (age < 15)
            {
                moped = false;
                car = false;
            }
            printOutput(name, age, car, moped);

        }

        public static string carCheck(bool car)
        {
            if (car == true)
            {
                return "Auto Ja,";
            }
            else
            {
                return "Auto Nein,";
            }
        }
        public static string mopedCheck(bool moped)
        {
            if (moped == true)
            {
                return "Moped Ja,";
            }
            else
            {
                return "Moped Nein,";
            }
            
        }

        public static string bothCheck(bool car, bool moped)
        {
            if (car == true && moped == true)
            {
                return "für Beide Fahrzeuge: Ja";
            }
            else
            {
                return "Für Beide Fahruzeuge: Nein";
            }

        }

        public static void printOutput(string name, int age, bool car, bool moped)
        {
            System.Console.WriteLine($"{name} {age}:  { mopedCheck(moped)} {carCheck(car)} {bothCheck(car, moped)}");
        }
    }
}