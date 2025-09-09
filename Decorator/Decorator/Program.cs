using Decorator;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Base message
            IMessage message = new SimpleMessage();

            // First decorator: encrypted 
            message = new EncryptedMessage(message);

            // Second decorator: adds emoji
            message = new EmojiMessage(message);

            // Send message
            message.Send("Hello world");
        }
    }
}