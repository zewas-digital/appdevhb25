using System;
using System.Text.RegularExpressions;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class ValidateEmail
    {
        public static void Start()
        {
            string email = "max.m%u+_ster-man7n@gma-il.com";
            string pattern = @"^[a-z0-9._%+-]+@[a-z0-9]+[a-z0-9-]+[a-z0-9]+\.[a-z]{2,}$";

            if (Regex.IsMatch(email, pattern))
                Console.WriteLine("Gülitge Email");
            else
                Console.WriteLine("Ungültige Email");
        }
    }
}