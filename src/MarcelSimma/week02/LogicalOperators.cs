namespace Appdevhb25.MarcelSimma.LogicalOperators
{
    public class LogicalOperators
    {
        public static void Start()
        {
            Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 10 ein:");

            /*
            Logische Operatoren
            ===================

            !   Negierung (NOT)
            &&  und (AND)
            ||  oder (OR)
            ^   exklusives oder (XOR)

            --> werden zum Vergleichen von Wahrheitswerten eingesetzt
            */

            bool a = true,
            b = true;

            //System.Console.WriteLine(!a);
            // false

            // AND: Beide Seiten müssen true sein. Es wird nicht geschaut, ob sie gleich sind.
            System.Console.WriteLine(false && false); // false
            System.Console.WriteLine(true && false); // false
            System.Console.WriteLine(false && true); // false
            System.Console.WriteLine(true && true); // true

            System.Console.WriteLine();

            // OR: Mindestens eines muss richtig sein.
            System.Console.WriteLine(false || false); // false
            System.Console.WriteLine(true || false); // true
            System.Console.WriteLine(false || true); // true
            System.Console.WriteLine(true || true); // true

            System.Console.WriteLine();

            // XOR: Genau eines muss richtig sein.
            System.Console.WriteLine(false ^ false); // false
            System.Console.WriteLine(true ^ false); // true
            System.Console.WriteLine(false ^ true); // true
            System.Console.WriteLine(true ^ true); // true

            System.Console.WriteLine();

            // XOR: Genau eines muss richtig sein.
            System.Console.WriteLine((false ^ false) && !(false || true)); // false
            System.Console.WriteLine((false ^ false) && !(true || true)); // false

            System.Console.WriteLine((false ^ true) && !(false || true)); // false
            System.Console.WriteLine((false ^ true) && !(true || true)); // false

            System.Console.WriteLine((true ^ false) && !(false || true)); // false
            System.Console.WriteLine((true ^ false) && !(true || true)); // false

            System.Console.WriteLine((true ^ true) && !(false || true)); // false
            System.Console.WriteLine((true ^ true) && !(true || true)); // false

            // && nicht mit == verwechseln!




        }
    }
}