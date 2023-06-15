using System;
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
                Console.WriteLine("\n" + userInput + " is a valid first name");
            else
                Console.WriteLine("\nYou've entered an invalid Details. Please try again!");
        }
    }
}
    
