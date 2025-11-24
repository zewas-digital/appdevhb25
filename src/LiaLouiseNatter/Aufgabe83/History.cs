
using System.Data.Common;
using Microsoft.VisualBasic;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe82
{
    public class History
    {
        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = name;
            }
        }

        public DateTime dateAndTime;

        public History(string Name, DateTime DateAndTime)
        {
            name = Name;
            dateAndTime = DateAndTime  ;
        }
        public override string ToString()
        {
            return $"Die Website {name} wurde am {dateAndTime}  Aufgerufen.";
        }   
       

    }
}