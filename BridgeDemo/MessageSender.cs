using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDemo
{
    public interface IMessageSender
    {
        void SendMessage(string message);
    }

    public class SmsMessageSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"'{message}': This Message has been send using SMS");
        }
    }

    public class EmailMessageSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"'{message}': This Message has been send using Email");
        }
    }
}
