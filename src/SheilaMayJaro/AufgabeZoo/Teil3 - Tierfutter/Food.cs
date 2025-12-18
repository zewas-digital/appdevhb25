using System.Globalization;
using System.Reflection;
using MySql.Data.MySqlClient;

namespace Appdevhb25.SheilaMayJaro.AufgabeZoo
{
    public class Food
    {
        public string Name { get; private init; }
        public string Unit { get; private init; }
        public double UnitPrice { get; private init; }
        public int EAN { get; private set; }
        public Food(string name, string unit, double unitPrice, int number)
        {
            Name = name;
            Unit = unit;
            UnitPrice = unitPrice;
            EAN = number; 
            Connection.InsertAttributesToTableFood(name, unit, unitPrice, EAN);
        }
    }
}