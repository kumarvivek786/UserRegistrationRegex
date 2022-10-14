using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexAssignment
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");

            Patterns patterns = new Patterns();
            Console.WriteLine("Enter the PhoneNumber");
            string PhoneNumber = Console.ReadLine();
            patterns.Validation(PhoneNumber);
            Console.ReadLine();
        }
    }
}
