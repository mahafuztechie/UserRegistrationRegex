using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    internal class UserForm
    {
        public const string FIRST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string LAST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string EMAIL = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public const string MOBILE = "^([9][1])+[ ]+[789]{1}[0-9]{9}$";
        public  void ValidateFName(string fName) 
        {
            // create regex object & initialize pattern to it
            Regex regex = new Regex(FIRST_NAME);

            //check if pattern match with string
            if (regex.IsMatch(fName))
            {
                Console.WriteLine("first name is matched with pattern");
            }
            else
            {
                Console.WriteLine("first name does not match with pattern");
            }
           
        }
        public void ValidateLName(string lName)
        {
            // create regex object & initialize pattern to it
            Regex regex = new Regex(LAST_NAME);

            //check if pattern match with string
            if (regex.IsMatch(lName))
            {
                Console.WriteLine("last name is matched with pattern");
            }
            else
            {
                Console.WriteLine("last name does not match with pattern");
            }
        }

        public void ValidateEmail(string email)
        {
            // create regex object & initialize pattern to it
            Regex regex = new Regex(EMAIL);

            //check if pattern match with string
            if (regex.IsMatch(email))
            {
                Console.WriteLine("email is matched with pattern");
            }
            else
            {
                Console.WriteLine("email does not match with pattern");
            }
        }
        public void ValidateMobile(string number)
        {
            // create regex object & initialize pattern to it
            Regex regex = new Regex(MOBILE);

            //check if pattern match with string
            if (regex.IsMatch(number))
            {
                Console.WriteLine("Mobile number is matched with pattern");
            }
            else
            {
                Console.WriteLine("Mobile number does not match with pattern");
            }
        }
    }
}
