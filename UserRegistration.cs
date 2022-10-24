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
        public static string reg = "^[A-Z][A-za-z]{2,}";

        public static bool Validate(String word)
        {
            return Regex.IsMatch(word, reg);
        }
    }
}