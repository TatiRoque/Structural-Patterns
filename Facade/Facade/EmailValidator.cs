using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Facade
{
    public  class EmailValidator
    {
        public bool IsValid(string email)
        {
            // Simple regex for email validation
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            bool valid = Regex.IsMatch(email, pattern);
            if (!valid)
            {
                Console.WriteLine($"Invalid email: {email}");
            }
            return valid;
        }
    }
}
