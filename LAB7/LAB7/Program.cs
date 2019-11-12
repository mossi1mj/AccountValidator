using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace LAB7
{
    class Program
    {
    // Write a method that will validate names. Names can only have alphabets, they should start with a capital letter, and they have a maximum length of 30.

        public static bool NameValidator(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]{0,30}$"))
            {
                return false;
            }
            return true;  
        }

    // Write a method that will validate emails. An email should be in the following format: {combination of alphanumeric characters, with a length between 5 and 30, 
    // and there are no special characters}@{combination of alphanumeric characters, with a length between 5 and 10, and there is no special characters}.{domain can be combination
    // of alphanumeric characters with a length of two or three}

        public static bool EmailValidator(string email)
        {
            if (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                return false;
            }
            return true;
        }

    // Write a method that will validate phone numbers. A phone number should be in the following format: { area code of 3 digits} – {3digits} – {4 digits}

        public static bool PhoneValidator (string phone)
        {
            if(!Regex.IsMatch(phone, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}"))
            {
                return false;
            }
            return true;
        }

    // Write a method that will validate date based on the following format: (dd/mm/yyyy).

        public static bool DateValidator(string date)
        {
            if(!Regex.IsMatch(date, @"^([0]?[0 - 9] |[12][0 - 9] |[3][01])[./ -]([0]?[1 - 9] |[1][0 - 2])[./ -]([0 - 9]{ 4}|[0 - 9]{ 2})$"))
            {
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE VALIDATOR APP!");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Let's start: \nWhat is your name?");
            string name = Console.ReadLine();

            if (NameValidator(name) == true)
                {
                    Console.WriteLine($"Hello {name}!");
                }
            else Console.WriteLine("Type in only letters");

            Console.WriteLine("What is your email?: ");
            string email = Console.ReadLine();
            if (EmailValidator(email) == true)
                {
                    Console.WriteLine("email success");
                }
            else Console.WriteLine("Not a valid email!");

            Console.WriteLine("What is your Phone Number?: ");
            string phone = Console.ReadLine();
            if (PhoneValidator(phone) == true)
                {
                    Console.WriteLine("This is a valide phone number!");
                }
            else Console.WriteLine("This phone number is NOT valid!");

            Console.WriteLine("What is the date?: ");
            string date = Console.ReadLine();
            if (DateValidator(date) == true)
                {
                    Console.WriteLine("This is a valid date.");
                }
            else Console.WriteLine("This is NOT a valid date!");

        }

    }
}
