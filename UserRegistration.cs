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
        public static string reg = "[A-Za-z1-9]{8}";

        //method for comparision
        public static bool validate(string password)
        {
            return Regex.IsMatch(password, reg);
        }


    }
}