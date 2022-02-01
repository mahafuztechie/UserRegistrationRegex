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
       
        public  void ValidateFName(string fName) 
        {
            Regex regex = new Regex(FIRST_NAME);

            if (regex.IsMatch(fName))
            {
                Console.WriteLine("first name is matched with pattern");
            }
            else
            {
                Console.WriteLine("first name does not match with pattern");
            }
        
           
        }
    }
}
