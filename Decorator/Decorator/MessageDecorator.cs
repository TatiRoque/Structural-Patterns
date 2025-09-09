using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class MessageDecorator : IMessage
    {
        protected IMessage _innerMessage;

        protected MessageDecorator(IMessage innerMessage)
        {
            _innerMessage = innerMessage;
        }

        public abstract void Send(string message);
    }
}
