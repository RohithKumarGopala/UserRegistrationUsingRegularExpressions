﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegularExpressions
{
    public class ValidatingDetails
    {
        public void ValidatingFirstName()
        {
            Console.Write("\nEnter Your first name: ");
            string firstName = @"^[A-Z][a-z]{4,}$";
            Regex regexObject = new Regex(firstName);
            string userInput = Console.ReadLine();
            Console.WriteLine("\nThank You For Entering The Details");
            if (regexObject.IsMatch(userInput))
                Console.WriteLine("\n" + userInput + " is a valid First Name");
            else
                Console.WriteLine("\nYou've entered an invalid Details. Please try again!");
        }
        public void ValidatingLastName()
        {
            Console.WriteLine("\nEnter Your Last Name: ");
            string lastName = @"^[A-Z][a-z]{4,}$";
            Regex regexObject = new Regex(lastName);
            string userInput = Console.ReadLine();
            Console.WriteLine("\nThank You For Entering The Details");
            if (regexObject.IsMatch(userInput))
                Console.WriteLine("\n " + userInput + " is a valid Last Name");
            else
                Console.WriteLine("\nYou've entered an invalid Details. Please try again!");
        }
        //UC9-Validating Email Samples
        public void ValidatingEmailaddress()
        {
            Console.Write("\nEnter Your Email address: ");
            //string emailAddress = @"^[a-z][a-zA-Z0-9.+-]{3,}@[a-z0-9]+[.][a-z]{2,3}[.]?[a-z]{0,3}$";
            string emailAddress = @"^[a-z]+([+_.-]?[A-Za-z0-9])*[@][A-Za-z0-9]+([.][a-z]{2,3}){1,2}$";
            Regex regexObject = new Regex(emailAddress);
            string userInput = Console.ReadLine();
            Console.WriteLine("\nThank You For Entering The Details");
            if
                (regexObject.IsMatch(userInput))
                Console.WriteLine("\n" + userInput + " is a valid email address");
            else
                Console.WriteLine("\nYou've entered an invalid email address. Please try again!");
        }
        public void ValidatingMoblieNumber()
        {
            Console.WriteLine("\nEnter Your Mobile Number: ");
            string MobileNumber = @"^(91)[\s][0-9]{10}$";
            Regex regexObject = new Regex(MobileNumber);
            string userInput = Console.ReadLine();
            Console.WriteLine("\nThank You For Entering The Details");
            if (regexObject.IsMatch(userInput))
                Console.WriteLine("\nThe Mobile Number " + userInput + " Is Valid. ");
            else
                Console.WriteLine("\nYou've entered an invalid Moblie Number. Please try again!");
        }
        public void ValidatingPassword()
        {
            Console.Write("\nEnter Your password: ");
            string password = @"^(?=.*[A-Z])(?=.*[1-9])(?=.*[~!@#$&*-])[a-zA-Z0-9~!@#$&*-]{8,}$";
            Regex regexObject = new Regex(password);
            string userInput = Console.ReadLine();
            Console.WriteLine("\nThank You For Entering The Details.");
            if (regexObject.IsMatch(userInput))
                Console.WriteLine("\n" + userInput + " is a valid password.");
            else
                Console.WriteLine("\nYou've entered an invalid password. Please try again!");
        }
    }
}



