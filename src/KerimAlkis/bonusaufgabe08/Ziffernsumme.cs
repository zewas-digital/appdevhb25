namespace Appdevhb25.KerimAlkis.Bonusaufgabe08
{
    public class Ziffernsumme
    {
        public static void Start()
        {
            randomZiffernsumme();
        }

       
        public static void randomZiffernsumme()
        {

            Random random = new Random();
            int randomNumber = random.Next(1, 1000);
            var ImmutableNum = randomNumber;
            

            int[] randomNum = new int[randomNumber.ToString().Length];

            int singleNumSum = 0;
            
            for (int i = 0; i <= randomNumber.ToString().Length + 1; i++)
            {
                
                singleNumSum += randomNumber % 10;

                randomNumber = randomNumber / 10;

            }
            System.Console.WriteLine($"Die Ziffernsumme von {ImmutableNum} ist {singleNumSum}");



            ghajdskfausf



        }
    }
}