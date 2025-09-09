using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class EmailSender
    {
        public void SendWelcome(string email)
        {
            Console.WriteLine($"Welcome email sent to '{email}'.");
        }
    }
}
