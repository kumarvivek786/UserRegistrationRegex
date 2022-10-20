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
        public static string password1 = @"^(.*[A-Z])[A-Za-z0-9]{8,}";

        public void Validation(string sample)
        {
            if (Regex.IsMatch(sample, password1))
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid Password");
        }
    }
}
