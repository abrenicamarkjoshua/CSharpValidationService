using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidationService {
    public class rulesCollection {

        public static rule mustBeNumber(string input) { 
            return new rule(new Error(005, "only numbers are allowed"), Regex.IsMatch(input, @"^\d+$")); 
        }
        public static rule mustBeValidString(string input)
        {
            return new rule(new Error(004, "invalid characters are not allowed"), new Regex(@"^[\w\s.-_]+$").IsMatch(input));
        }
        public static rule mustBeValidEmail(string input)
        {
            return new rule(new Error(006, "must be valid email"), (input.Contains(".com") && input.Contains('@')));
        }
        public static rule mustNotBeNumber(string input)
        {
            return new rule(new Error(015, "numbers are not allowed"), !Regex.IsMatch(input, @"^\d+$"));
        }       
    }
}
