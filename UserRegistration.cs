using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegEX
{
    public class UserRegistration
    {
        //Regular expression
        public static string reg = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*]{1}).{8}";
        public static bool validate(string word)
        {
            //return true if the word matches the regex
            return Regex.IsMatch(word, reg);
        }


    }
}