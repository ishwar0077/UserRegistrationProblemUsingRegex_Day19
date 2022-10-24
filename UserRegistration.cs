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
        public static string reg = "^[a-z]{3}[.][a-z]{3}@[a-z]{2}[.][a-z]{2}[.][a-z]{2}";
        public static bool validate(string word)
        {
            return Regex.IsMatch(word, reg);
        }
    }
}