using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Appdevhb25.LiaLouiseNatter.Monopoly
{
    public class Player
    {
        private int _maxPlayers;
        public int MaxPlayers
        {
            get
            {
                return _maxPlayers;
            }
            set
            {
                if (int.IsNegative(value) || value < 2 || value > 8)
                {
                    System.Console.WriteLine("Only 2-8 Players allowed!");
                }
                else
                {
                    _maxPlayers = value;
                }
            }
        }
        private int playerBank = 1500;
        public bool buyChoice;
        private string _buyInput;
        public string BuyInput
        {
            get
            {
                return _buyInput;
            }
            set
            {
                if (new[] { "y", "yes" }.Contains(value.ToLower()))
                {
                    _buyInput = value;
                    buyChoice = true;
                }
                else if (new[] { "n", "no" }.Contains(value.ToLower()))
                {
                    _buyInput = value;
                    buyChoice = false;
                }
                else
                {
                    System.Console.WriteLine("Only [y/yes/n/no] or [Y/YES/N/NO] allowed as Input!");
                }
            }
        }

        public Player(string buyinput, int maxPlayers)
        {
            BuyInput = buyinput;
            MaxPlayers = maxPlayers;
        }

        public void BuyFields()
        {
            System.Console.WriteLine("Do you want to Buy -NOCH EINFÜGEN- [y/n]");

        }
        
        public void PlayerInformations()
        {
            
        }


    }
}