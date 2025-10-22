using System;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe15
{

    public class ValidateEmail
    {

        public static void StartValidateEmail()
        {
            Console.WriteLine("----------Bonusaufgabe 15---------");

            string? email;
            System.Console.WriteLine("Gib eine Email ein:");
           
            do
            {
                email = Console.ReadLine();
            } while (string.IsNullOrEmpty(email));

            bool valid = Regex.IsMatch(email, @"^[a-zA-Z0-9\._%+-]+@[a-zA-Z0-9](?!.*\.\.)[a-zA-Z0-9-\.]*(?<!-)\.[a-z]{2,}$");
            // (?!.*\.\.)  nicht 2 Punkte hintereinander
            // (?<!-) kein Bindestrich am Ende
            // {2,} heißt 2 bis unendlich
            System.Console.WriteLine((valid)? "Gültig" : "Ungültig");


        }
        
    }
}
