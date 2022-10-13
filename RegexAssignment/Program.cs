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
            Console.WriteLine("Welcome to User Registratuiuon Program");

            Patterns patterns = new Patterns();
            Console.WriteLine("Enter the First name");
            string FirstName = Console.ReadLine();
            patterns.Validation(FirstName);
            Console.ReadLine();
        }
    }
}
