using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDemo
{
    public abstract class AbstractMessage
    {
        protected IMessageSender messageSender;
        public abstract void SendMessage(string Message);

        protected AbstractMessage(IMessageSender messageSender)
        {
            this.messageSender = messageSender;
        }
    }

    public class ShortMessage : AbstractMessage
    {
        public ShortMessage(IMessageSender messageSender) : base(messageSender) 
        { 
        }

        public override void SendMessage(string Message)
        {
            if (Message.Length <= 10)
            {
                messageSender.SendMessage(Message);
            }
            else
            {
                Console.WriteLine("Unable to send the message as length > 10 characters");
            }
        }
    }

    public class LongMessage : AbstractMessage
    {
        public LongMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        public override void SendMessage(string Message)
        {
            messageSender.SendMessage(Message);
        }
    }
}
