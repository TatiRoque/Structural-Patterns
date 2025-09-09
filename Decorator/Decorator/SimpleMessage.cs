using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SimpleMessage: IMessage
    {
        public void Send (string message)
        {
            Console.WriteLine (message);
        }
    }
}
