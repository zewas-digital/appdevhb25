namespace Appdevhb25.KerimAlkis.Aufgabe20
{   
    public class Generation
    {
        public static void Start()
        {
            AgeNameAsker();
        }

        public static void AgeNameAsker()
        {
            Console.Write("Please enter your Age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Enter a valid age!");
                Console.Write("Please enter your Age: ");
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

            Output(age, name);

        }

        public static string getGenerationByAge(int age)
        {
            if (age >= 97 && age <= 80)
            {
                return "Silent Generation";
            }

            if (age >= 61 && age <= 79)
            {
                return "Babyboomer";
            }

            if (age >= 60 && age <= 45)
            {
                return "Generation X";
            }

            if (age >= 44 && age <= 29)
            {
                return "Generation Y";
            }

            if (age >= 28 && age <= 13)
            {
                return "Generation Z";
            }

            else
            {
                return "Generation Alpha";
            }
        }

        public static void Output(int age, string name)
        {
            System.Console.WriteLine($"{name} {age}: {getGenerationByAge(age)}");
        }
    }
}