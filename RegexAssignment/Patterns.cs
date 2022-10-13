using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    public class Patterns
    {
        public static string FirstName = "^[A-Z][a-z]{3,}";
        public void Validation(string sample)
        {
            if (Regex.IsMatch(sample, FirstName))
                Console.WriteLine("Valid FirstName");
            else
                Console.WriteLine("Invalid FirstName");
        }
    }
}
