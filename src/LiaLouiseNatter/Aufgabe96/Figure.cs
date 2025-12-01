using System.Dynamic;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe96
{
    public abstract class AbstractFigure
    {
        public double extent{get; protected set;}
        public double area{get;protected set;}
        //public static int countFigures{get;set;}
        public string name{get;set;}
        public string elementType{get;set;}
        
        public abstract double calculateExtent();
        public abstract double calculateArea();
        public override string ToString()
        {
            return $"Name of the Element: {name}\nType: {elementType}\n";
        }

    }
}