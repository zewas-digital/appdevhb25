using System;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe14
{

    public class ValidatePhoneNumber
    {

        public static void StartValidatePhoneNumber()
        {
            Console.WriteLine("----------Bonusaufgabe 14---------");

            string? phoneNumber;
            System.Console.WriteLine("Gib eine Telefonnummber ein:");
           
            do
            {
                phoneNumber = Console.ReadLine();
            } while (string.IsNullOrEmpty(phoneNumber));

            bool valid = Regex.IsMatch(phoneNumber, @"^(\+\d{1,3}|00\d{1,3})?(?:[\s\-\(\)]*\d){3,15}$");
            System.Console.WriteLine((valid)? "Gültig" : "Ungültig");


        }
        
    }
}
