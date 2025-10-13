namespace Appdevhb25.KerimAlkis.Aufgabe15
{
    public class TeilenUndHerrschen
    {
        public static void Start()
        {
            //Devide();
            Devide2();

        }

        public static void Devide()
        {
            for (float i = 1f; i <= 20; i += 1f)
            {
                float zaehler = i;
                System.Console.WriteLine("Zähler = " + zaehler);
                System.Console.WriteLine("--------------");
                float divg = i / 5;
                System.Console.WriteLine("dividiert durch 5 = " + divg);
                float divgNull = i / 5.0f;
                System.Console.WriteLine("dividiert durch 5.0 = " + divg);

            }

        }
        
        public static void Devide2()
        {
            // er speichert es wenn durch 5.0 gerechnet wird als double und wenn durch 5 gerechnet wird als int
            for (var i = 1; i <= 20; i += 1)
            {
                var zaehler = i;
                System.Console.WriteLine("Zähler = " + zaehler);
                System.Console.WriteLine("--------------");
                var divg = i / 5;
                System.Console.WriteLine("dividiert durch 5 = " + divg);
                var divgNull = i / 5.0;
                System.Console.WriteLine("dividiert durch 5.0 = " + divgNull);

            }

        }

        
    }
}