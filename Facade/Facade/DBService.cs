using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class DBService
    {
        public void SaveUser(string name, string email)
        {
            Console.WriteLine($"User '{name}' with email '{email}' saved in database.");
        }
    }
}
