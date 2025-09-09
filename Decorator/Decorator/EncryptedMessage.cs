using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class EncryptedMessage : MessageDecorator
    {
        public EncryptedMessage(IMessage innerMessage) : base(innerMessage) { }

        public override void Send(string message)
        {
            string encryptedMessage = message.ToUpper();
            _innerMessage.Send(encryptedMessage);
        }
    }
}
