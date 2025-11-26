namespace Appdevhb25.LiaLouiseNatter.Aufgabe96
{
    public static class GeometryStart
    {
        public static void Start()
        {
            Circle circle = new Circle(500);
            Circle circle1 = new Circle(50);
            Rectangle rectangle = new Rectangle(50,20);
            Rectangle rectangle1 = new Rectangle(20,20);
            Triangle triangle = new Triangle(12);
            Triangle triangle1 = new Triangle(112);
            Triangle triangle3 = new Triangle(112);

              List<AbstractFigure> figures = new List<AbstractFigure>
            {
                circle, circle1, rectangle,rectangle1, triangle, triangle1, triangle3
            };

            foreach(AbstractFigure figure in figures)
            {
                System.Console.WriteLine("----------------------------------------");
                System.Console.WriteLine(figure.ToString());

            }
            
            System.Console.WriteLine("-------------------------------");
            circle.Scale(70);
            System.Console.WriteLine(circle.ToString());
            

        }
        
    }
}