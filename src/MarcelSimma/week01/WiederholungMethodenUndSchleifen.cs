using System;

namespace Appdevhb25.MarcelSimma.Aufgabe09
{
    public class WiederholungMethodenUndSchleifen
    {
        public static void Start()
        {
            /*
            Coding Conventions - Programmiervorschriften
            ============================================

               - für Variablen und Parameter verwenden wir camelCase, zB ichBinEineVariable
               - für Klassen und Methoden verwenden wir PascalCase, zB IchBinEineMethode
               - keine Umlaute: ä wird zu ae, ß wird zu ss, etc.
               - keine Sonderzeichen
               - keine Leerzeichen
               - nicht mit einer Zahl beginnen
               - sinnvolle Benennungen, "sprechende Namen", mindestens drei Zeichen (außer bei Zählvariablen)
               - Zählvariablen starten bei i und gehen von dort alphabetisch weiter
               - Ordner und Dateinamen: keine Leerzeichen, keine Sonderzeichen, Dateiendungen

            Coding Conventions sind abhängig von der Programmiersprache und den unternehmensinternen Richtlinien.

            
            Wiederholung Konsolenausgabe
            ============================ 
            */

            Console.WriteLine("Mein Name: \tMarcel"); // Ausgabe mit Tabulator
            Console.Write("\\\n"); // Ausgabe \ gefolgt von Zeilenumbruch
            Console.WriteLine("Hallo " + "Hallo" + " Hallo"); // Verkettung von Strings
            Console.WriteLine("Hallo 'Hallo' Hallo");
            Console.WriteLine("Hallo \"Hallo\" Hallo"); // doppelte Anführungszeichen in Ausgabe
            Console.WriteLine("Copyright Zeichen: \u00A9"); // Ausgabe von Unicode Zeichen

            /*
            Interpolations-Operator: $, (Python: f-String)
               - Alles innerhalb der {} wird als Ausdruck und nicht als String interpretiert.
            */

            int alter = 24;
            Console.WriteLine("Ich bin " + alter + " Jahre alt");
            Console.WriteLine($"Ich bin {alter} Jahre alt");

            /* 
            Verbatem Literal: @
               - Escape Sequenzen (zB "\n") werden ignoriert
               - Strings über mehrere Zeilen
            */

            Console.Write(@"
            \
             \
              \
            ");

            /*
            if-Abfragen
            ===========

               - keine if-Schleifen, keine if-Methoden
               - Verwendung für bedingte Ausführung von Befehlen

            Aufbau:

            if (Bedingung) {
                Befehle
            } else if (alternative Bedingung) {
                alternative Befehle
            } else {
                fallback Befehle
            }

            --> Die Reihenfolge der Bedingungen entscheidend. Es wird immer nur die erste ausgeführt, die richtig ist. Alles danach wird übersprungen.
            Wird ein if oder else if ausgeführt, wird alles danach folgende ignoriert.

            
            if (Bedingung) {
                Befehle
            }
            if (alternative Bedingung) {
                alternative Befehle
            }
            Wenn man zwei if-Abfragen hintereinander verwendet, könnenn beide ausgeführt werden. Die zweite wird nicht übersprungen, wenn die erste richtig ist.


            Arithmetische Operatoren
            ========================

            + ... Addition
            - ... Subtraktion
            * ... Multiplikation
            / ... Division;                                       zB 10 / 2 = 5, 11 / 2 = 5
            % ... Modulo Operator: berechnet Rest einer Division; zB 10 % 2 = 0, 11 % 2 = 1


            Wiederholung Schleifen
            ======================

            Mit Schleifen soll ein bestimmter Code solange ausgeführt werden, wie eine Bedingung richtig ist. 

            Arten von Schleifen:
              1. for Schleife; zB für Listen (Arrays) verarbeiten
              2. while; zB Wertvalidierungen
              3. do while; zB Input, der mindestens einmal abgefragt werden soll
              4. (foreach); wird erst später behandelt; Alternative für for-Schleife

            Aufbau for-Schleife

            for (Zählvariable; Bedingung; Inkrement/Dekrement) {
                Befehle, die in jeder Iteration ausgeführt werden sollen
            }

            for (int i = 0; i < 10; i++) {
                Befehle, die in jeder Iteration ausgeführt werden.
            }


            Vorgehensweise bei einer Programmieraufgabe
            ===========================================

              1. Lesen und verstehen
              2. Rückfragen stellen und klären
              3. Die Aufgabe in Teilaufgaben aufteilen; jede Teilaufgabe isoliert betrachten
              4. Lösungsweg überlegen: Wie kann ich die Aufgabe im C# implementieren?
              5. Methoden, Schleifen, Abfragen, Variablen bestimmen. Wofür brauche ich diese Ressourcen? Was sind gültige Werte?
                zwei Schleifen, Iteration über Zeilen und Spalten
                eine Abfrage um "x" oder "." Ausgabe zu bestimmen
                Variable size für die Größe des "X", hat immer den gleichen Wert
                Zählvariablen x und y
            
            
            Beispiel: PrintX 
            
            Es soll folgende Ausgabe erzeugt werden:
            x...x
            .x.x.
            ..x..
            .x.x.
            x...x

              1. erledigt
              2. Ist die Größe variabel? Ja, die Größe wird durch einen Übergabeparameter bestimmt.
              3. Teilaufgaben:
                   a. Erste Diagonale \
                   b. Zweite Diagonale /
                   c. Leerzeichen
              4. 
  
            Diagonale \
                    x   y
            x...x   0   0
            .x.x.   1   1
            ..x..   2   2
            .x.x.   3   3
            x...x   4   4

            Diagonale /
                    x   y   E
            x...x   0   4   4
            .x.x.   1   3   3
            ..x..   2   2   2
            .x.x.   3   1   1
            x...x   4   0   0

            E: size - x -1 == y

            Implementierung Variante 1
            */

            Console.WriteLine();

            int size = 7;

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    // Diagonale von links oben nach rechts unten \
                    if (x == y)
                    {
                        Console.Write("*");
                    }
                    // Diagonale von rechts oben nach links unten /
                    else if (size - x - 1 == y)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }


            Console.WriteLine();

            /* 
            Variante 2: Wir verschieben den Koordinatenursprung in den Kreuzungspunkt der Diagonalen

                     x   y
            x...x   -2  -2
            .x.x.   -1  -1
            ..x..    0   0
            .x.x.    1   1
            x...x    2   2

            // Diagonale /
                     x   y   E
            x...x    2  -2   4
            .x.x.    1  -1   3
            ..x..    0   0   2
            .x.x.   -1   1   1
            x...x   -2   2   0
            */

            //int size = 7;

            for (int y = -size / 2; y <= size / 2; y++)
            {
                for (int x = -size / 2; x <= size / 2; x++)
                {
                    // Diagonale von links oben nach rechts unten \
                    if (Math.Abs(x) == Math.Abs(y))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }


        /*
        Wiederholung Methoden
        =====================

        Warum?
           - besser lesbar, übersichtlicher, strukturierter
           - Wiederverwendbarkeit

        Aufbau:

        Zugriffsmodifizierer (static= Rückgabedatentyp NameDerMethode(Datentyp1 Parametername1, DatentypN, ParameternameN) {
            Befehle
            return, wenn Rückgabedatentyp nicht void ist; jeder Pfad in der Methode muss ein return haben; zB bei if, else Abfrage
        }
        */

        public static void PrintX(int size)
        {
            for (int y = -size / 2; y <= size / 2; y++)
            {
                for (int x = -size / 2; x <= size / 2; x++)
                {
                    // Diagonale von links oben nach rechts unten \
                    if (Math.Abs(x) == Math.Abs(y))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }

        // Beispiel: Methode nimmt Zahl, vergleicht ob größer oder kleiner zehn und gibt einen String als Rückgabe zurück.

        // void: kein Rückgabewert, wie wenn man in Minecraft ins leere fällt
        public static string Compoare(int number)
        {
            if (number > 10)
            {
                return "Zahl ist größer als 10";
            }
            else
            {
                return "Zahl ist kleiner als 10";
            }
        }

        public static string Compoare(double number)
        {
            string message = "";
            if (number > 10)
            {
                message = "Zahl ist größer als 10";
            }
            else
            {
                message = "Zahl ist kleiner als 10";
            }
            return message;
        }

        public static string Compoare(float number)
        {
            if (number > 10)
            {
                return "Zahl ist größer als 10";
            }
            return "Zahl ist kleiner als 10";
        }

        /*
        Signatur einer Bethode:
           - besteht aus dem Namen der Methode und der Parameterliste
           - Kombination aus Namen und Parameterliste muss eindeutig sein.
        
        --> Es ist also möglich, dass es mehrere Methoden mit dem gleichen Namen gibt, sofern die Datentypen der Parameter anders sind.
        */
    }
}
