using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class EmojiMessage : MessageDecorator
    {
        public EmojiMessage(IMessage innerMessage) : base(innerMessage) { }

        public override void Send(string message)
        {
            string textWithEmoji = $"{message} 😊";
            _innerMessage.Send(textWithEmoji);
        }
    }
}
