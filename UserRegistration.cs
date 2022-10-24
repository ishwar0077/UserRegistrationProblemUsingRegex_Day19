using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegEX
{
    public class UserRegistration
    {
        //Regex formatting
        public static String reg = "^[9]{1}[1]{1}[\\s][6-9]{1}[0-9]{9}";

        //method for comparision
        public static bool validate(String word)
        {
            return Regex.IsMatch(word, reg);
        }
    }
}