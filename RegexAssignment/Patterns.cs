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
        public static string phonenumber ="^91[ ]?[0-9]{10}$";
        public void Validation(string sample)
        {
            if (Regex.IsMatch(sample, phonenumber))
                Console.WriteLine("Valid phonenumber");
            else
                Console.WriteLine("Invalid phonenumber");
        }
    }
}
