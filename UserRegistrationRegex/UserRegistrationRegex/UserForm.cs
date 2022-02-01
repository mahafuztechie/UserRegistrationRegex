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
        public const string PASSWORD_R1 = "^[a-z]{8}";
        public const string PASSWORD_R2 = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";
        public const string PASSWORD_R3 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        public const string PASSWORD_R4 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&-+=()]).{8,}$";
        public const string SAMPLE_EMAIL = "^[a-zA-z]{3}([+-_ .]*[a-zA-Z0-9]+)*[@][a-zA-z0-9]+(.[a-z]{2,3})*$";

        public void ValidateFName(string fName)
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

        public void ValidatePasswordR1(string password)
        {
            // create regex object & initialize pattern to it
            Regex regex = new Regex(PASSWORD_R1);

            //check if pattern match with string
            if (regex.IsMatch(password))
            {
                Console.WriteLine("Password is matched with pattern");
            }
            else
            {
                Console.WriteLine("Password does not match with pattern");
            }
        }

        // atleast one uppercase
        public bool ValidatePasswordR2()
        {
            Regex regex = new Regex(PASSWORD_R2);
            return regex.IsMatch("akXyb302");
        }
        //atleast one number
        public bool ValidatePasswordR3()
        {
            Regex regex = new Regex(PASSWORD_R3);
            return regex.IsMatch("akXybxy3");
        }
        // atleast one special character
        public bool ValidatePasswordR4()
        {
            Regex regex = new Regex(PASSWORD_R4);
            return regex.IsMatch("akXs@bx3");
        }

        // check array of strings if they match the pattern sample email
        public void ValidatingEmail()
        {
            string[] sample = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc-100@abc.net", "abc.100@abc.com.au",
                                 "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" ,"abc","abc@.com","abc123@gmail.a", "abc123@.com" ,
                                 "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a"};
            Regex regex = new Regex(SAMPLE_EMAIL);
            Console.WriteLine("Validates Email ID");
            Validate(sample, regex);
        }
        // printing email id status
        public void Validate(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool rs = regex.IsMatch(arr[i]);
                if (rs == true)
                    Console.WriteLine(arr[i] + "-->" + "Valid Email ID");
                else
                    Console.WriteLine(arr[i] + "-->" + "Invalid Email ID");
            }
        }
    }
}
